using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 1;

        public MainWindow()
        {
            
            InitializeComponent();
            //test
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {


            MessageBox.Show("You pressed the button: " + i.ToString() + " times.");
            

            label1.Content = "Test: " + i.ToString() + ".";                //dysplays text in label
            i++;

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            textBox2.Text = textBox1.Text;

        }
    }
}
