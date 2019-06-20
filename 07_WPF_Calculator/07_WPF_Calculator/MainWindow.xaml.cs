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

namespace _07_WPF_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool is_first = true;
        bool is_second = false;
        double first = 0;
        double second = 0;
        string operation = "";
        string first_str = "";
        string second_str = "";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Bt1_Click(object sender, RoutedEventArgs e)
        {
            if (is_first == true && is_second == false)
            {
                first_str += "1";
                textBox_1.Text = first_str;
            }
            else if (is_first == false && is_second == true)
            {
                second_str += "1";
                textBox_1.Text = second_str;
            }
            if (is_first == false && is_second == false)
            {
                first_str = "1";
                textBox_1.Text = first_str;
                second_str = "";
                operation = "";
                is_first = true;
                is_second = false;
            }
        }

        private void Bt2_Click(object sender, RoutedEventArgs e)
        {
            if (is_first==true&&is_second==false)
            {
                first_str += "2";
                textBox_1.Text = first_str;
            }
            else if(is_first==false&&is_second==true)
            {
                second_str += "2";
                textBox_1.Text = second_str;
            }
            if (is_first == false && is_second == false)
            {
                first_str = "2";
                textBox_1.Text = first_str;
                second_str = "";
                operation = "";
                is_first = true;
                is_second = false;
            }
        }

        private void Bt3_Click(object sender, RoutedEventArgs e)
        {
            if (is_first == true && is_second == false)
            {
                first_str += "3";
                textBox_1.Text = first_str;
            }
            else if (is_first == false && is_second == true)
            {
                second_str += "3";
                textBox_1.Text = second_str;
            }
            if(is_first==false&&is_second==false)
            {
                first_str = "3";
                textBox_1.Text = first_str;
                second_str = "";
                operation = "";
                is_first = true;
                is_second = false;
            }
        }

        private void Bt4_Click(object sender, RoutedEventArgs e)
        {
            if (is_first == true && is_second == false)
            {
                first_str += "4";
                textBox_1.Text = first_str;
            }
            else if (is_first == false && is_second == true)
            {
                second_str += "4";
                textBox_1.Text = second_str;
            }
            if (is_first == false && is_second == false)
            {
                first_str = "4";
                textBox_1.Text = first_str;
                second_str = "";
                operation = "";
                is_first = true;
                is_second = false;
            }
        }

        private void Bt5_Click(object sender, RoutedEventArgs e)
        {
            if (is_first == true && is_second == false)
            {
                first_str += "5";
                textBox_1.Text = first_str;
            }
            else if(is_first == false && is_second == true)
            {
                second_str += "5";
                textBox_1.Text = second_str;
            }
            if (is_first == false && is_second == false)
            {
                first_str = "5";
                textBox_1.Text = first_str;
                second_str = "";
                operation = "";
                is_first = true;
                is_second = false;
            }
        }

        private void Bt6_Click(object sender, RoutedEventArgs e)
        {
            if (is_first == true && is_second == false)
            {
                first_str += "6";
                textBox_1.Text = first_str;
            }
            else if (is_first == false && is_second == true)
            {
                second_str += "6";
                textBox_1.Text = second_str;
            }
            if (is_first == false && is_second == false)
            {
                first_str = "6";
                textBox_1.Text = first_str;
                second_str = "";
                operation = "";
                is_first = true;
                is_second = false;
            }
        }

        private void Bt7_Click(object sender, RoutedEventArgs e)
        {
            if (is_first == true && is_second == false)
            {
                first_str += "7";
                textBox_1.Text = first_str;
            }
            else if (is_first == false && is_second == true)
            {
                second_str += "7";
                textBox_1.Text = second_str;
            }
            if (is_first == false && is_second == false)
            {
                first_str = "7";
                textBox_1.Text = first_str;
                second_str = "";
                operation = "";
                is_first = true;
                is_second = false;
            }
        }

        private void Bt8_Click(object sender, RoutedEventArgs e)
        {
            if (is_first == true && is_second == false)
            {
                first_str += "8";
                textBox_1.Text = first_str;
            }
            else if (is_first == false && is_second == true)
            {
                second_str += "8";
                textBox_1.Text = second_str;
            }
            if (is_first == false && is_second == false)
            {
                first_str = "8";
                textBox_1.Text = first_str;
                second_str = "";
                operation = "";
                is_first = true;
                is_second = false;
            }
        }

        private void Bt9_Click(object sender, RoutedEventArgs e)
        {
            if (is_first == true && is_second == false)
            {
                first_str += "9";
                textBox_1.Text = first_str;
            }
            else if (is_first == false && is_second == true)
            {
                second_str += "9";
                textBox_1.Text = second_str;
            }
            if (is_first == false && is_second == false)
            {
                first_str = "9";
                textBox_1.Text = first_str;
                second_str = "";
                operation = "";
                is_first = true;
                is_second = false;
            }
        }

        private void BtPnt_Click(object sender, RoutedEventArgs e)
        {
            if (textBox_1.Text.IndexOf('.') != -1)
                return;
            if (is_first == true && is_second == false)
            {
                if (first_str=="")
                {
                    first_str += "0,";
                    textBox_1.Text = first_str;
                }
                else
                {
                    first_str += ",";
                    textBox_1.Text = first_str;
                }
            }
            else if (is_first == false && is_second == true)
            {
                if(second_str=="")
                {
                    second_str += "0,";
                    textBox_1.Text = second_str;
                }
                else
                {
                    second_str += ",";
                    textBox_1.Text = second_str;
                }

            }
            if (is_first == false && is_second == false)
            {
                first_str = "0,";
                textBox_1.Text = first_str;
                second_str = "";
                operation = "";
                is_first = true;
                is_second = false;
            }
        }

        private void BtEql_Click(object sender, RoutedEventArgs e)
        {
            if (first_str == ""|| operation == "")
                return;
            if (second_str == "")
            {
                first = double.Parse(first_str);
                second = first;
                second_str = first.ToString();
            }
            else if (is_first == false && is_second == true)
            {
                first = double.Parse(first_str);
                second = double.Parse(second_str);
            }
            switch(operation)
            {
                case "+": { first += second; textBox_1.Text = (first).ToString(); is_second = false; }break;
                case "-": { first -= second; textBox_1.Text = (first).ToString(); is_second = false; } break;
                case "*": { first *= second; textBox_1.Text = (first).ToString(); is_second = false; } break;
                case "/": {
                        if (second == 0)
                        {
                            textBox_1.Text="ERROR";
                            return;
                        }
                        first /= second; textBox_1.Text = (first).ToString(); is_second = false; ;
                          } break;
            }

        }

        private void BtPls_Click(object sender, RoutedEventArgs e)
        {
            if ((is_first != false && is_second != false)||operation=="")
            {
                operation = "+";
                is_first = false;
                is_second = true;
            }
        }

        private void BtMns_Click(object sender, RoutedEventArgs e)
        {
            if ((is_first != false && is_second != false) || operation == "")
            {
                operation = "-";
                is_first = false;
                is_second = true;
            }
        }

        private void BtMlt_Click(object sender, RoutedEventArgs e)
        {
            if ((is_first != false && is_second != false) || operation == "")
            {
                operation = "*";
                is_first = false;
                is_second = true;
            }
        }

        private void BtDvd_Click(object sender, RoutedEventArgs e)
        {
            if ((is_first != false && is_second != false) || operation == "")
            {
                operation = "/";
                is_first = false;
                is_second = true;
            }
        }

        private void BtC_Click(object sender, RoutedEventArgs e)
        {
            is_first = true;
            is_second = false;
            first_str = "";
            second_str = "";
            operation = "";
            textBox_1.Text = "0";
            first = 0;
            second = 0;
        }

        private void BtBS_Click(object sender, RoutedEventArgs e)
        {
            if(is_first == true && is_second == false && operation == "")
            {
                first_str = "";
                textBox_1.Text = "0";
            }
            else if (is_first == false && is_second == true)
            {
                second_str = "";
                textBox_1.Text = "0";
            }
        }

        private void Bt0_Click(object sender, RoutedEventArgs e)
        {
            if (textBox_1.Text == "0")
                return;
            if (is_first == true && is_second == false)
            {
                first_str += "0";
                textBox_1.Text = first_str;
            }
            else if (is_first == false && is_second == true)
            {
                second_str += "0";
                textBox_1.Text = second_str;
            }
            if (is_first == false && is_second == false)
            {
                first_str = "0";
                textBox_1.Text = first_str;
                second_str = "";
                operation = "";
                is_first = true;
                is_second = false;
            }
        }
    }
}
