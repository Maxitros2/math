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

namespace Matan.Views
{
    /// <summary>
    /// Логика взаимодействия для DataView.xaml
    /// </summary>
    public partial class DataView : Window
    {
        ICalcData Data;
        public DataView(ICalcData data)
        {
            Data = data;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Output.Text  =Data.ProcessInput(Input.Text.Split(' '));
        }
    }
}
