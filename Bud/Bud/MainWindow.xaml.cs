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

namespace Bud
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //using (UserContext db = new UserContext())
            //{
            //    BudVar1 var1 = new BudVar1() { Name = "Son", Date = DateTime.Now, Repeat = 3 };
            //    db.BudVar1s.Add(var1);
            //    db.SaveChanges();
            //}
            }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Var1 v = new Var1();
            v.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var2 v = new var2();
            v.Show();
        }
    }
}
