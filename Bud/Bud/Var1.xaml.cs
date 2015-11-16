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
    /// Логика взаимодействия для Var1.xaml
    /// </summary>
    public partial class Var1 : Window
    {
        
        public Var1()
        {
            InitializeComponent();
            UserContext db = new UserContext();
            dataGridBud.ItemsSource = db.BudVar1s.ToList();
            New.Visibility = Visibility.Hidden;
            Spisok.Visibility = Visibility.Visible;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Spisok.Visibility = Visibility.Visible;
            New.Visibility = Visibility.Hidden;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            New.Visibility = Visibility.Visible;
            Spisok.Visibility = Visibility.Hidden;
            textBlock_Id.Text = Convert.ToString(-1);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridBud.SelectedItem != null)
            {
                BudVar1 viewmodel = dataGridBud.SelectedItem as BudVar1;
                
                UserContext db = new UserContext();
                BudVar1 r = db.BudVar1s.Find(viewmodel.Id);
                db.BudVar1s.Remove(viewmodel);
                db.SaveChanges();
                //UserContext db1 = new UserContext();
                //dataGridBud.ItemsSource = db1.BudVar1s.ToList();
            }
            else
            {
                MessageBox.Show("Воу, ну ты выбери", "Ошибка", MessageBoxButton.OK);
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (textBlock_Id.Text == "-1")
            {
                BudVar1 var = new BudVar1();
                var.Name = textBox1.Text;
                string f = textBox.Text as string;
                String[] words = f.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                int hour = Convert.ToInt32(words[0]);
                int minute = Convert.ToInt32(words[1]);
                DateTime s = new DateTime(Datepicker.SelectedDate.Value.Year, Datepicker.SelectedDate.Value.Month, Datepicker.SelectedDate.Value.Day, hour, minute, 0);
                var.Date = s;
                var.Repeat = Convert.ToInt32(textBox2.Text);
                UserContext db = new UserContext();
                db.BudVar1s.Add(var);
                db.SaveChanges();
                UserContext db1 = new UserContext();
                dataGridBud.ItemsSource = db1.BudVar1s.ToList();
                textBox.Text = null;
                textBox1.Text = null;
                textBox2.Text = null;
                Spisok.Visibility = Visibility.Visible;
                New.Visibility = Visibility.Hidden;
            }
            else
            {
                UserContext db = new UserContext();
                BudVar1 var = db.BudVar1s.Find(Convert.ToInt32(textBlock_Id.Text));
                var.Name = textBox1.Text;
                string f = textBox.Text as string;
                String[] words = f.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                int hour = Convert.ToInt32(words[0]);
                int minute = Convert.ToInt32(words[1]);
                DateTime s = new DateTime(Datepicker.SelectedDate.Value.Year, Datepicker.SelectedDate.Value.Month, Datepicker.SelectedDate.Value.Day, hour, minute, 0);
                var.Date = s;
                var.Repeat = Convert.ToInt32(textBox2.Text);
                db.SaveChanges();
                UserContext db1 = new UserContext();
                dataGridBud.ItemsSource = db1.BudVar1s.ToList();
                textBox.Text = null;
                textBox1.Text = null;
                textBox2.Text = null;
                Spisok.Visibility = Visibility.Visible;
                New.Visibility = Visibility.Hidden;
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (dataGridBud.SelectedItem != null)
            {
                BudVar1 viewmodel = dataGridBud.SelectedItem as BudVar1;
                string hour = Convert.ToString(viewmodel.Date.Hour);
                string minute = Convert.ToString(viewmodel.Date.Minute);
                textBox.Text = hour+':'+minute;
                textBox1.Text = viewmodel.Name;
                textBox2.Text = Convert.ToString(viewmodel.Repeat);
                textBlock_Id.Text = Convert.ToString(viewmodel.Id);
                Datepicker.SelectedDate = viewmodel.Date;
                New.Visibility = Visibility.Visible;
                Spisok.Visibility = Visibility.Hidden;
            }
            else
            {
                MessageBox.Show("Воу, ну ты выбери", "Ошибка", MessageBoxButton.OK);
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = null;
            textBox1.Text = null;
            textBox2.Text = null;
            Spisok.Visibility = Visibility.Visible;
            New.Visibility = Visibility.Hidden;
        }
    }
}
