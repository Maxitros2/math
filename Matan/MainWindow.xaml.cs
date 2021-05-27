using Matan.Tasks;
using Matan.Views;
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

namespace Matan
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new DataView(new l2t1()).ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new DataView(new l3t2()).ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            new DataView(new l4t1()).ShowDialog();
        }
    }
}
