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
using System.Windows.Shapes;

namespace _39_Templates
{
    /// <summary>
    /// Interaction logic for W_DataTemplate.xaml
    /// </summary>
    public partial class W_DataTemplate : Window
    {
        Person src = new Person { Name = "Ali", Age = 27 };
        List<Person> people = new List<Person>();
        public W_DataTemplate()
        {
            InitializeComponent();
            people.Add(src);
            people.Add(new Person { Name = "Mike", Age = 62 });
            people.Add(new Person { Name = "Brian", Age = 12 });
            this.DataContext = people;
        }
        private void btnShow_Click(object sender, RoutedEventArgs e)
        {
            string message = src.Name + " is " + src.Age;
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
                set
                {
                    if (value != ageValue)
                    {
                        ageValue = value;
                    }
                }
            }
        }
    }
}
