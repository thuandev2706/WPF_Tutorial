using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Controls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = Employee.GetEmployees();
            GetListViewData();
        }
        //button event
        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You have clicked the button");
        }
        //calendar event
        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            var calendar = sender as Calendar;
            if(calendar.SelectedDate.HasValue)
            {
                DateTime date = calendar.SelectedDate.Value;
                this.Title = date.ToShortDateString();
            }
        }
        //checkbox event
        private void HandleCheck(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Name == "checkBox1") textBox1.Text = "2 state CheckBox is checked.";
            else textBox2.Text = "3 state CheckBox is checked.";
        }
        private void HandleUnchecked(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Name == "checkBox1") textBox1.Text = "2 state CheckBox is unchecked.";
            else textBox2.Text = "3 state CheckBox is unchecked.";
        }
        private void HandleThirdState(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            textBox2.Text = "3 state CheckBox is in indeterminate state.";
        }

        //comboBox event
        private void Combo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textBox1.Text = comboBox.SelectedItem.ToString();
        }
        private void Combo1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textBox2.Text = comboBox1.SelectedItem.ToString();
        }
        //Context menu event
        private void Bold_Checked(object sender, RoutedEventArgs e)
        {
            textBox3.FontWeight = FontWeights.Bold;
        }
        private void Bold_Unchecked(object sender, RoutedEventArgs e)
        {
            textBox3.FontWeight = FontWeights.Normal;
        }
        private void Italic_Checked(object sender, RoutedEventArgs e)
        {
            textBox3.FontStyle = FontStyles.Italic;
        }
        private void Italic_Unchecked(object sender, RoutedEventArgs e)
        {
            textBox3.FontStyle = FontStyles.Normal;
        }
        private void IncreaseFont_Click(object sender, RoutedEventArgs e)
        {
            if(textBox3.FontSize < 18)
            {
                textBox3.FontSize += 2;
            }
        }
        private void DecreaseFont_Click(object sender, RoutedEventArgs e)
        {
            if(textBox3.FontSize > 10)
            {
                textBox3.FontSize -= 2;
            }
        }
        // Data grid event
        public enum Party
        {
            Indepentent,
            Federalist,
            DemocratRepublican,
        }
        public class Employee : INotifyPropertyChanged
        {
            private string name;
            public string Name
            {
                get { return name; }
                set
                {
                    name = value;
                    RaiseProperChanged();
                }
            }

            private string title;
            public string Title
            {
                get { return title; }
                set
                {
                    title = value;
                    RaiseProperChanged();
                }
            }

            private bool wasReElected;

            public bool WasReElected
            {
                get { return wasReElected; }
                set
                {
                    wasReElected = value;
                    RaiseProperChanged();
                }
            }

            private Party affiliation;

            public event PropertyChangedEventHandler PropertyChanged;

            public Party Affiliation
            {
                get { return affiliation; }
                set
                {
                    affiliation = value;
                    RaiseProperChanged();
                }
            }

            public static ObservableCollection<Employee> GetEmployees()
            {
                var employees = new ObservableCollection<Employee>();
                employees.Add(new Employee()
                {
                    Name = "Ali",
                    Title = "Minister",
                    WasReElected = true,
                    Affiliation = Party.Indepentent
                });
                employees.Add(new Employee()
                {
                    Name = "Ahmed",
                    Title = "CM",
                    WasReElected = false,
                    Affiliation = Party.Federalist
                });

                employees.Add(new Employee()
                {
                    Name = "Amjad",
                    Title = "PM",
                    WasReElected = true,
                    Affiliation = Party.DemocratRepublican
                });

                employees.Add(new Employee()
                {
                    Name = "Waqas",
                    Title = "Minister",
                    WasReElected = false,
                    Affiliation = Party.Indepentent
                });

                employees.Add(new Employee()
                {
                    Name = "Bilal",
                    Title = "Minister",
                    WasReElected = true,
                    Affiliation = Party.Federalist
                });

                employees.Add(new Employee()
                {
                    Name = "Waqar",
                    Title = "Minister",
                    WasReElected = false,
                    Affiliation = Party.DemocratRepublican
                });

                return employees;
            }
            private void RaiseProperChanged([CallerMemberName] string caller = "")
            {

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(caller));
                }
            }
        }
        //Date Picker event
        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var picker = sender as DatePicker;
            DateTime? date = picker.SelectedDate;
            if(date == null)
            {
                this.Title = "No Date";
            }
            else
            {
                this.Title = date.Value.ToShortDateString();
            }
        }
        //Message Box event
        private void ShowMessageBox_Click(object sender, RoutedEventArgs e)
        {
            string mstText = "Click any button";
            string txt = "My Title";
            MessageBoxButton button = MessageBoxButton.YesNoCancel;
            MessageBoxResult result = MessageBox.Show(mstText, txt, button);
            switch(result)
            {
                case MessageBoxResult.Yes:
                    txtmss.Text = "Yes";
                    break;
                case MessageBoxResult.No:
                    txtmss.Text = "No";
                    break;
                case MessageBoxResult.Cancel:
                    txtmss.Text = "Cancel";
                    break;
            }
        }
        // List view
        class Person
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }
        }
        private void GetListViewData()
        {
            MenList.Items.Add(new Person() { Name = "Ali", ID = "123A", Age = 20 });
            MenList.Items.Add(new Person() { Name = "Akram", ID = "456X", Age = 35 });
            MenList.Items.Add(new Person() { Name = "Salman", ID = "333E", Age = 49 });
        }
        //Menu
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem item = sender as MenuItem;
            this.Title = "File: " + item.Header;
        }
        private void MenuItem_Click1(object sender, RoutedEventArgs e)
        {
            MenuItem item = sender as MenuItem;
            this.Title = "Edit: " + item.Header;

        }
        private void MenuItem_Click2(object sender, RoutedEventArgs e)
        {
            MenuItem item = sender as MenuItem;
            this.Title = "View: " + item.Header;
        }

        // Password Box
        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
            if(pswbox.Password.ToString() == "wpf12345")
            {
                lblstatus.Content = "Login Success";
            }
            else
            {
                lblstatus.Content = "Wrong Password";
            }

        }
        //Slider event
        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int val = Convert.ToInt32(e.NewValue);
            string msg = String.Format("{0}", val);
            this.txtslider.Text = msg;
        }
    }
} 

