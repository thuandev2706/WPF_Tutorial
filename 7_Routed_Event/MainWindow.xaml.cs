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

namespace Original_Routed_Event
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
        private void Button_Click(object sender,RoutedEventArgs e)
        {
            txt1.Text = "Button is Clicked";
        }
        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            txt2.Text = "Click event is bubbled to Stack Panel";
            e.Handled = true; // to stop the routed event at any particular level
        }
        private void Window_Click(object sender, RoutedEventArgs e)
        {
            txt3.Text = "Click event is buddled to Window";
        }
        private void MyCustomControl_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" It is the custom routed event of your custom control");
        }
    }
}
