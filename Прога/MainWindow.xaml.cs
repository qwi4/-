using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace Прога
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
        double y1;
        double y2;

        private void Func1Bt_Click(object sender, RoutedEventArgs e)
        {
            
            if (aTb.Text != "" && xTb.Text != "")
            {
                y1 = 0;
                double.TryParse(aTb.Text, out double a);
                double.TryParse(xTb.Text, out double x);
                y1 = a * Math.Pow(x, 5);
                MessageBox.Show($"Функция 1\ny = {Convert.ToString(y1)}");
            }
            else
            {
                MessageBox.Show("Введите значение для A и для X");
            }
        }

        private void Func2Bt_Click(object sender, RoutedEventArgs e)
        {
            
            if (xTb.Text != "")
            {
                y2 = 0;
                double.TryParse(xTb.Text, out double x);
                y2 = Math.Tan(x);
                MessageBox.Show($"Функция 2\ny = {Convert.ToString(y2)}");
            }
            else
            {
                MessageBox.Show("Введите значение для X");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (y1 == y2)
            {
                MessageBox.Show("Кайф", "AHAHHAHA");
            }
            else
            {
                MessageBox.Show("не Кайф", "((((");
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
