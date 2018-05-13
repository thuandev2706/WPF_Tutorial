﻿using System;
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

namespace _37_Data_Binding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person person = new Person { Name = "Thuan", Age = 25 };
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = person;
        }

        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            string message = person.Name + " is " + person.Age;
            MessageBox.Show(message);
        }
        public class Person
        {
            private string nameValue;
            public string Name
            {
                get { return nameValue; }
                set { nameValue = value; }
            }
            private double ageValue;
            public double Age
            {
                get { return ageValue; }
                set { ageValue = value; }
            }
        }
    }
}
