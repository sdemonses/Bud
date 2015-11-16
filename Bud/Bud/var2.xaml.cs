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
using System.Windows.Shapes;

namespace Bud
{
    /// <summary>
    /// Логика взаимодействия для var2.xaml
    /// </summary>
    public partial class var2 : Window
    {
        public var2()
        {
            InitializeComponent();
        }
        public bool sun = false;
        public bool mon = false;
        public bool tues = false;
        public bool wednes = false;
        public bool thurs = false;
        public bool frid = false;
        public bool sat = false;

        private void Ellipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void button_Monday_Click(object sender, RoutedEventArgs e)
        {
            Button s = sender as Button;
            if (mon)
            {
                s.Background = Brushes.White;
                s.Foreground = Brushes.Gray;
                mon = false;
            }
            else
            {
                s.Background = Brushes.Green;
                s.Foreground = Brushes.White;
                mon = true;
            }
        }

        private void button_hourup_Click(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt32(textBox_Hour.Text);
            string res = "";
            if (i >= 23)
            {
                i = 0;
            }
            else
            {
                i++;
            }
            if (i >= 0 && i < 10)
                res += "0";
            res += Convert.ToString(i);
            textBox_Hour.Text = res;
        }

        private void button_minuteup_Click(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt32(textBox_Minute.Text);
            string res = "";
            if (i >= 59)
            {
                i = 0;
            }
            else
            {
                i++;
            }
            if (i >= 0 && i < 10)
                res += "0";
            res += Convert.ToString(i);
            textBox_Minute.Text = res;
        }

        private void button_hourdown_Click(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt32(textBox_Hour.Text);
            string res = "";
            if (i==0)
            {
                i = 23;
            }
            else
            {
                i--;
            }
            if (i >= 0 && i < 10)
                res += "0";
            res += Convert.ToString(i);
            textBox_Hour.Text = res;
        }

        private void button_minutedown_Click(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt32(textBox_Minute.Text);
            string res = "";
            if (i == 0)
            {
                i = 59;
            }
            else
            {
                i--;
            }
            if (i >= 0 && i < 10)
                res += "0";
            res += Convert.ToString(i);
            textBox_Minute.Text = res;
        }

        private void button_Sunday_Click(object sender, RoutedEventArgs e)
        {
            Button s = sender as Button;
            if (sun)
            {
                s.Background = Brushes.White;
                s.Foreground = Brushes.Gray;
                sun = false;
            }
            else
            {
                s.Background = Brushes.Green;
                s.Foreground = Brushes.White;
                sun = true;
            }
        }

        private void button_Wednesday_Click(object sender, RoutedEventArgs e)
        {
            Button s = sender as Button;
            if (wednes)
            {
                s.Background = Brushes.White;
                s.Foreground = Brushes.Gray;
                wednes = false;
            }
            else
            {
                s.Background = Brushes.Green;
                s.Foreground = Brushes.White;
                wednes = true;
            }
        }

        private void button_Thursday_Click(object sender, RoutedEventArgs e)
        {
            Button s = sender as Button;
            if (thurs)
            {
                s.Background = Brushes.White;
                s.Foreground = Brushes.Gray;
                thurs = false;
            }
            else
            {
                s.Background = Brushes.Green;
                s.Foreground = Brushes.White;
                thurs = true;
            }
        }

        private void button_Friday_Click(object sender, RoutedEventArgs e)
        {
            Button s = sender as Button;
            if (frid)
            {
                s.Background = Brushes.White;
                s.Foreground = Brushes.Gray;
                frid = false;
            }
            else
            {
                s.Background = Brushes.Green;
                s.Foreground = Brushes.White;
                frid = true;
            }
        }

        private void button_Tuesday_Click(object sender, RoutedEventArgs e)
        {
            Button s = sender as Button;
            if (tues)
            {
                s.Background = Brushes.White;
                s.Foreground = Brushes.Gray;
                tues = false;
            }
            else
            {
                s.Background = Brushes.Green;
                s.Foreground = Brushes.White;
                tues = true;
            }
        }

        private void button_Saturday_Click(object sender, RoutedEventArgs e)
        {
            Button s = sender as Button;
            if (sat)
            {
                s.Background = Brushes.White;
                s.Foreground = Brushes.Gray;
                sat = false;
            }
            else
            {
                s.Background = Brushes.Green;
                s.Foreground = Brushes.White;
                sat = true;
            }
        }

        private void button_pausedown_Click(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt32(textBlock.Text);
            if (i == 0)
            {

            }
            else
            {
                i--;
            }
            textBlock.Text = Convert.ToString(i);
        }

        private void button_pauseup_Click(object sender, RoutedEventArgs e)
        {
            int i = Convert.ToInt32(textBlock.Text);
            if (i == 59)
            {

            }
            else
            {
                i++;
            }
            textBlock.Text = Convert.ToString(i);
        }
    }
}
