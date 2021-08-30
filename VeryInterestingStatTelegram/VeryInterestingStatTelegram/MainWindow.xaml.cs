using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.IO;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VeryInterestingStatTelegram
{
    public partial class MainWindow : Window
    {
        public OpenFileDialog ofd { get; set;  }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void findButton_Click(object sender, RoutedEventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.Filter = "JSON files(*.json)|*.json|All files(*.*)|*.*";
            
            if(ofd.ShowDialog() == true)
            {
                pathBox.Text = ofd.FileName;
            }

        }

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(pathBox.Text))
            {
                try
                {
                    int minSymb = int.Parse(symBox.Text);
                    string path = pathBox.Text;
                    string json;

                    using (StreamReader sr = new StreamReader(path))
                    {
                        json =sr.ReadToEnd();
                    }


                    JObject o = JObject.Parse(json);

                    resultBox.Items.Clear();
                    resultBox.Items.Add("Переписка с " + o["name"].ToString() + ":");

                    var Mesages = o["messages"].Select(t => (JObject)t).ToList();
                    

                    List<string> list = new List<string>();

                    foreach (JObject m in Mesages)
                    {
                        if(!string.IsNullOrWhiteSpace((string)m["text"].ToString()))
                            list.Add(" " + ((string)m["text"].ToString().ToLower()));
                    }

                    char[] wordBreaks = new[] { ' ', '.', ',', '\'', '\n' };

                    var res = list.SelectMany(c => c.Split(wordBreaks))
                                 .GroupBy(c => c)
                                 .Select(c => new KeyValuePair<string, int>(c.Key, c.Count()))
                                 .OrderByDescending(c => c.Value);


                    var ress = res.Where(x => x.Key.ToString().Length >= minSymb
                        && x.Key.ToString()!="\"text_link\":"
                        && x.Key.ToString() != "\"text_link\""
                        && x.Key.ToString() != "\"link\""
                        && x.Key.ToString() != "\"bold\""
                        && x.Key.ToString() != "\"href\":" 
                        && x.Key.ToString() != "\"type\":" 
                        && x.Key.ToString() != "\"text\":").Take(10).ToList();


                    if(ress.Count >= 10)
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            resultBox.Items.Add(ress[i].Key.ToString() + " " + ress[i].Value.ToString());
                        }
                    }
                    else
                    {
                        foreach (var item in ress)
                        {
                            resultBox.Items.Add(item.Key.ToString() + " " + item.Value.ToString());
                        }
                    }
                    

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            else
            {
                MessageBox.Show("Не выбран путь файла");
            }
        }
    }
}
