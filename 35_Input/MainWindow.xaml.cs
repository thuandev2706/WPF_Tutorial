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

namespace _35_Input
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CommandBinding();
        }
        //Mouse
        private void OnMouseEnter(object sender, MouseEventArgs e)
        {
            Rectangle source = e.Source as Rectangle;
            if(source != null)
            {
                source.Fill = Brushes.SlateGray;
            }
            txt1.Text = "Mouse Entered";
        }
        private void OnMouseLeave(object sender, MouseEventArgs e)
        {
            //Cast the source of the event to a button
            Rectangle source = e.Source as Rectangle;
            // If source is a Button
            if(source != null)
            {
                source.Fill = Brushes.AliceBlue;
            }
            txt1.Text = "Mouse Leave";
            txt2.Text = "";
            txt3.Text = "";
        }
        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            Point pnt = e.GetPosition(mrRec);
            txt2.Text = "Mouse Move: " + pnt.ToString();
        }
        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            Rectangle source = e.Source as Rectangle;
            Point pnt = e.GetPosition(mrRec);
            txt3.Text = "Mouse Click: " + pnt.ToString();
            if(source != null)
            {
                source.Fill = Brushes.Beige;
            }
        }

        //Keyboard
        private void OnTextInputKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.O && Keyboard.Modifiers == ModifierKeys.Control)
            {
                Handle();
                e.Handled = true;
            }
        }
        private void OnTextInputButonClick(object sender, RoutedEventArgs e)
        {
            Handle();
            e.Handled = true;
        }
        public void Handle()
        {
            MessageBox.Show("Do you want to open a file ?");
        }

        //ContextMenu - RoutedCommands
        private void NewExcuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Create a new file ?");
        }
        private void CanNew(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        private void OpenExcuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Open a exist file ?");
        }
        private void CanOpen(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        private void SaveExcuted(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Save a current file ?");
        }
        private void CanSave(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
        private void CommandBinding()
        {
            CommandBindings.Add(new CommandBinding(ApplicationCommands.New, NewExcuted, CanNew));
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Open, OpenExcuted, CanOpen));
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Save, SaveExcuted, CanSave));
        }
    }
}
