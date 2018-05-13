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

namespace _39_Templates
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btncontrolTempl_Click(object sender, RoutedEventArgs e)
        {
            W_ControlTemplate w = new W_ControlTemplate();
            this.Hide();
            w.ShowDialog();
            this.Show();
        }

        private void btndataTempl_Click(object sender, RoutedEventArgs e)
        {
            W_DataTemplate w = new W_DataTemplate();
            this.Hide();
            w.ShowDialog();
            this.Show();
        }
        
    }
}
