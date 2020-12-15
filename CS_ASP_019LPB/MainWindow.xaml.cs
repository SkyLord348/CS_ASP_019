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

namespace CS_ASP_019LPB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

           // heightTextBox.Text = "100";
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {

            int a, b, c;
            double answer;

            // get answer for box dimensions

            try
            {
                a = int.Parse(heightTextBox.Text);
                b = ((int)double.Parse(widthTextBox.Text) / 2);
                c = int.Parse(widthTextBox.Text);
                answer = a * b * c / 3;
                answerLabel.Content = answer.ToString();


            }
            catch (Exception)
            {

                answerLabel.Content = "Error 404 Answer is Unknown";

            }







        }
    }
}
