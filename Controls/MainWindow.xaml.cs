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
    }
}