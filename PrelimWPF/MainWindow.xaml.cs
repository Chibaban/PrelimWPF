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

namespace PrelimWPF
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
        private void btnLeaderboards_Click(object sender, RoutedEventArgs e)
        {
            Leaderboards leaderboards = new Leaderboards();
            leaderboards.Show();
            this.Close();
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            Game game = new Game();
            game.Show();
            this.Close();
        }

        private void btnRules_Click(object sender, RoutedEventArgs e)
        {
            Rules rules = new Rules();
            rules.Show();
            this.Close();
        }
    }
}
