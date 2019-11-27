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

namespace IceCreamCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double totalSIze=0;
        private double tfavlour = 0;
        private double tTopping = 0;

       
      
        public MainWindow()
        {
            InitializeComponent();


        }






        private void RbtnSmall_Click(object sender, RoutedEventArgs e)
        {
            if (rbtnSmall.IsChecked == true)
                totalSIze = 1;

            txtTotal.Text = (totalSIze + tfavlour + tTopping).ToString("c2");
        }

        private void RbtnMedium_Click(object sender, RoutedEventArgs e)
        {

            if (rbtnMedium.IsChecked == true)
                totalSIze = 2;

            txtTotal.Text = (totalSIze + tfavlour + tTopping).ToString("c2");
        }

        private void RbtnLarge_Click(object sender, RoutedEventArgs e)
        {
            if (rbtnLarge.IsChecked == true)
                totalSIze = 3;
            txtTotal.Text = (totalSIze + tfavlour + tTopping).ToString("c2");
        }

        private void RbtnChocolate_Click(object sender, RoutedEventArgs e)
        {
            if (rbtnChocolate.IsChecked == true)
                tfavlour = .5;
            txtTotal.Text = (totalSIze + tfavlour + tTopping).ToString("c2");
        }

        private void RbtnRocky_Click(object sender, RoutedEventArgs e)
        {
            if (rbtnRocky.IsChecked == true)
                tfavlour = 1.5;

            txtTotal.Text = (totalSIze + tfavlour + tTopping).ToString("c2");
        }

        private void RbtnMint_Click(object sender, RoutedEventArgs e)
        {
            if (rbtnMint.IsChecked == true)
                tfavlour = 2.5;
            txtTotal.Text = (totalSIze + tfavlour + tTopping).ToString("c2");
        }

        private void ChbxSmarties_Click(object sender, RoutedEventArgs e)
        {
            if (chbxSmarties.IsChecked == true)
                tTopping += .5;
            else
                tTopping -= 0.5;

            txtTotal.Text = (totalSIze + tfavlour + tTopping).ToString("c2");
        }

        private void ChbxOreo_Click(object sender, RoutedEventArgs e)
        {
            if (chbxOreo.IsChecked == true)
                tTopping += 1.5;
            else
                tTopping -= 1.5;

            txtTotal.Text = (totalSIze + tfavlour + tTopping).ToString("c2");
        }

        private void ChbxSprinkles_Click(object sender, RoutedEventArgs e)
        {
            if (chbxSprinkles.IsChecked == true)
                tTopping += 2.5;
            else
                tTopping -= 2.5;

            txtTotal.Text = (totalSIze + tfavlour + tTopping).ToString("c2");
        }

        private void ChbxCaramel_Click(object sender, RoutedEventArgs e)
        {
            if (chbxCaramel.IsChecked == true)
                tTopping += 2;
            else
                tTopping -= 2;

            txtTotal.Text = (totalSIze + tfavlour + tTopping).ToString("c2");

        }
    }
}
