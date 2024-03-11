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
using System.Windows.Shapes;

namespace PrelimWPF
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        public Game()
        {
            InitializeComponent();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if (btn1.Content.ToString() == "0")
            {
                btn1.Content = "1";
                Apple8.Source = new BitmapImage(new Uri("/Golden_Apple_JE2_BE2-removebg-preview.png", UriKind.RelativeOrAbsolute));
            }
            else
            {
                btn1.Content = "0";
                Apple8.Source = new BitmapImage(new Uri("/minecraft_apple-removebg-preview.png", UriKind.RelativeOrAbsolute));
            }
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if (btn2.Content.ToString() == "0")
            {
                btn2.Content = "1";
                Apple7.Source = new BitmapImage(new Uri("/Golden_Apple_JE2_BE2-removebg-preview.png", UriKind.RelativeOrAbsolute));
            }
            else
            {
                btn2.Content = "0";
                Apple7.Source = new BitmapImage(new Uri("/minecraft_apple-removebg-preview.png", UriKind.RelativeOrAbsolute));
            }
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            if (btn4.Content.ToString() == "0")
            {
                btn4.Content = "1";
                Apple6.Source = new BitmapImage(new Uri("/Golden_Apple_JE2_BE2-removebg-preview.png", UriKind.RelativeOrAbsolute));
            }
            else
            {
                btn4.Content = "0";
                Apple6.Source = new BitmapImage(new Uri("/minecraft_apple-removebg-preview.png", UriKind.RelativeOrAbsolute));
            }
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            if (btn8.Content.ToString() == "0")
            {
                btn8.Content = "1";
                Apple5.Source = new BitmapImage(new Uri("/Golden_Apple_JE2_BE2-removebg-preview.png", UriKind.RelativeOrAbsolute));
            }
            else
            {
                btn8.Content = "0";
                Apple5.Source = new BitmapImage(new Uri("/minecraft_apple-removebg-preview.png", UriKind.RelativeOrAbsolute));
            }
        }

        private void Btn16_Click(object sender, RoutedEventArgs e)
        {
            if (btn16.Content.ToString() == "0")
            {
                btn16.Content = "1";
                Apple4.Source = new BitmapImage(new Uri("/Golden_Apple_JE2_BE2-removebg-preview.png", UriKind.RelativeOrAbsolute));
            }
            else
            {
                btn16.Content = "0";
                Apple4.Source = new BitmapImage(new Uri("/minecraft_apple-removebg-preview.png", UriKind.RelativeOrAbsolute));
            }
        }

        private void Btn32_Click(object sender, RoutedEventArgs e)
        {
            if (btn32.Content.ToString() == "0")
            {
                btn32.Content = "1";
                Apple3.Source = new BitmapImage(new Uri("/Golden_Apple_JE2_BE2-removebg-preview.png", UriKind.RelativeOrAbsolute));
            }
            else
            {
                btn32.Content = "0";
                Apple3.Source = new BitmapImage(new Uri("/minecraft_apple-removebg-preview.png", UriKind.RelativeOrAbsolute));
            }
        }

        private void Btn64_Click(object sender, RoutedEventArgs e)
        {
            if (btn64.Content.ToString() == "0")
            {
                btn64.Content = "1";
                Apple2.Source = new BitmapImage(new Uri("/Golden_Apple_JE2_BE2-removebg-preview.png", UriKind.RelativeOrAbsolute));
            }
            else
            {
                btn64.Content = "0";
                Apple2.Source = new BitmapImage(new Uri("/minecraft_apple-removebg-preview.png", UriKind.RelativeOrAbsolute));
            }
        }

        private void Btn128_Click(object sender, RoutedEventArgs e)
        {
            if (btn128.Content.ToString() == "0")
            {
                btn128.Content = "1";
                Apple.Source = new BitmapImage(new Uri("/Golden_Apple_JE2_BE2-removebg-preview.png", UriKind.RelativeOrAbsolute));
            }
            else
            {
                btn128.Content = "0";
                Apple.Source = new BitmapImage(new Uri("/minecraft_apple-removebg-preview.png", UriKind.RelativeOrAbsolute));
            }
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnFinish_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
