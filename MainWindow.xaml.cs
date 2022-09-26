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

namespace ISRPO_PR1_Cherednichenko402
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

       

        float a, b;
        int count;
        bool znak = true;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Content= a.ToString() + "+";
            znak = true;
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Content = a.ToString() + "-";
            znak = true;
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Content = a.ToString() + "*";
            znak = true;
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Content = a.ToString() + "/";
            znak = true;
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            calculate();
            label1.Content = "";
        }

        private void calculate()
        {
            switch(count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                default:
                    break;
            }
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            label1.Content = "";
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else if (znak == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                znak = true;
            }
        }

    }



}
