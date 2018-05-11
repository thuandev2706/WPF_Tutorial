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
using System.IO;


namespace _36_CommandLine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        
            String[] args = App.Args;
            try
            {
               
                //open the text file using a stream reader
                using (var sr = new StreamReader(args[0]))
                {
                    String line = sr.ReadToEnd();
                    txtresult.AppendText(line.ToString());
                    txtresult.AppendText("\n");
                }
            }
            catch (Exception e)
            {
                txtresult.AppendText("The file could not be read with error: ");
                txtresult.AppendText("\n");
                txtresult.AppendText(e.Message);
            }
        }
       
    }
}
