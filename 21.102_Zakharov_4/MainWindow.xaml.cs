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

namespace _21._102_Zakharov_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        List<string> alph = new List<string>()
        {
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", ",", ".", ";", "-", "/", "?", "!", " "
        };
        private void Button_Click(object sender, RoutedEventArgs e)
        {
           // MessageBox.Show(alph.Count.ToString());
            string input = "";
            string result = "";
            result_TextBlock.Text = "";
            bool work = true;
            try
            {
                input = Convert.ToString(input_TextBox.Text);
                foreach(char let in input)
                {
                    if(!alph.Contains(let.ToString().ToUpper()))
                    {
                        MessageBox.Show("Введите предложение, состоящее только из английских букв и знаков препинания");
                        work = false;
                        break;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("");
            }
            if (work)
            {
                string[] str = input.Trim().Split(' ');
                /*  foreach(string a in str)
                  {
                      MessageBox.Show(a);
                  }*/
                for (int i = 0; i < str.Length; i++)
                {
                    char[] word = str[i].ToCharArray();
                    string word1 = "";
                    if (str[i].Length == 0)
                    {
                        str[i] = "это_пробел";
                    }
                    else
                    {
                        word[0] = Convert.ToChar(word[0].ToString().ToUpper());
                        word[word.Length - 1] = Convert.ToChar(word[word.Length - 1].ToString().ToUpper());
                        for (int j = 0; j < word.Length; j++)
                        {
                            word1 += word[j];
                        }
                        str[i] = word1;
                    }
                }
                foreach (string word in str)
                {
                    result += word + " ";
                }
                result_TextBlock.Text = result;
            }
        }
    }
}
