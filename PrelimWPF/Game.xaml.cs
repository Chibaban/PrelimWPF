using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Threading;

namespace PrelimWPF
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        int _plus1 = 0;
        int _plus2 = 0;
        int _plus4 = 0;
        int _plus8 = 0;
        int _plus16 = 0;
        int _plus32 = 0;
        int _plus64 = 0;
        int _plus128 = 0;

        int _rounds = 1;
        int _score = 0;

        Random _rnd = new Random();

        DispatcherTimer _dt = null;
        DispatcherTimer _dtplaytime = null;
        int _sec = 0;

        public Game()
        {
            InitializeComponent();
            _dt = new DispatcherTimer();
            _dt.Tick += _dt_Tick;
            _dt.Interval = new TimeSpan(0, 0, 0, 1, 0);

            _dtplaytime = new DispatcherTimer();
            _dtplaytime.Tick += _dtplaytime_Tick;
            _dtplaytime.Interval = new TimeSpan(0, 0, 0, 1, 0);
        }

        private void _dtplaytime_Tick(object sender, EventArgs e)
        {
            int sec = int.Parse(tbplaytimeSec.Text.ToString());
            int min = int.Parse(tbplaytimeMin.Text.ToString());

            sec++;

            if (sec == 60)
            {
                sec = 0;
                min++;
            }

            tbplaytimeSec.Text = sec.ToString();
            tbplaytimeMin.Text = min.ToString();
        }

        private void _dt_Tick(object sender, EventArgs e)
        {
            _sec = int.Parse(lbTimer.Content.ToString());
            _sec--;

            if (_sec == 0)
            {
                string totalplayedtime = tbplaytimeMin.Text.ToString() + ":" + tbplaytimeSec.Text.ToString();
                _dtplaytime.Stop();

                string playername = UsernameWindow();
                Recorded(playername, _score, totalplayedtime);

                _dt.Stop();

                btnStart.IsEnabled = true;
                btnFinish.IsEnabled = false;
                _sec = 30;

                btn1.Content = "0";
                btn2.Content = "0";
                btn4.Content = "0";
                btn8.Content = "0";
                btn16.Content = "0";
                btn32.Content = "0";
                btn64.Content = "0";
                btn128.Content = "0";

                _plus1 = 0;
                _plus2 = 0;
                _plus4 = 0;
                _plus8 = 0;
                _plus16 = 0;
                _plus32 = 0;
                _plus64 = 0;
                _plus128 = 0;

                Apple.Source = new BitmapImage(new Uri("/minecraft_apple-removebg-preview.png", UriKind.RelativeOrAbsolute));
                Apple2.Source = new BitmapImage(new Uri("/minecraft_apple-removebg-preview.png", UriKind.RelativeOrAbsolute));
                Apple3.Source = new BitmapImage(new Uri("/minecraft_apple-removebg-preview.png", UriKind.RelativeOrAbsolute));
                Apple4.Source = new BitmapImage(new Uri("/minecraft_apple-removebg-preview.png", UriKind.RelativeOrAbsolute));
                Apple5.Source = new BitmapImage(new Uri("/minecraft_apple-removebg-preview.png", UriKind.RelativeOrAbsolute));
                Apple6.Source = new BitmapImage(new Uri("/minecraft_apple-removebg-preview.png", UriKind.RelativeOrAbsolute));
                Apple7.Source = new BitmapImage(new Uri("/minecraft_apple-removebg-preview.png", UriKind.RelativeOrAbsolute));
                Apple8.Source = new BitmapImage(new Uri("/minecraft_apple-removebg-preview.png", UriKind.RelativeOrAbsolute));

                lbRandomNum.Content = "";

                _rounds = 1;
                lbRounds.Content = _rounds.ToString();

                _score = 0;
                lbScore.Content = _score.ToString();

                Leaderboard();
                this.Close();
            }

            lbTimer.Content = _sec.ToString();
        }

        private string UsernameWindow()
        {
            string userInput = "";
            Playername playername = new Playername();

            if (playername.ShowDialog() == true)
            {
                userInput = playername.uInput;
            }

            return userInput;
        }

        private void Recorded(string username, int score, string playtime)
        {
            using (StreamWriter sw = new StreamWriter("LeaderboardsContent.csv", true))
            {
                sw.WriteLine($"{username},{score},{playtime}");
            }
        }

        private void Leaderboard()
        {
            Leaderboards leaderboards = new Leaderboards();
            leaderboards.Show();
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if (btn1.Content.ToString() == "0")
            {
                btn1.Content = "1";
                Apple8.Source = new BitmapImage(new Uri("/Golden_Apple_JE2_BE2-removebg-preview.png", UriKind.RelativeOrAbsolute));
                _plus1 = 1;
            }
            else
            {
                btn1.Content = "0";
                Apple8.Source = new BitmapImage(new Uri("/minecraft_apple-removebg-preview.png", UriKind.RelativeOrAbsolute));
                _plus1 = 0;
            }
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if (btn2.Content.ToString() == "0")
            {
                btn2.Content = "1";
                Apple7.Source = new BitmapImage(new Uri("/Golden_Apple_JE2_BE2-removebg-preview.png", UriKind.RelativeOrAbsolute));
                _plus2 = 2;
            }
            else
            {
                btn2.Content = "0";
                Apple7.Source = new BitmapImage(new Uri("/minecraft_apple-removebg-preview.png", UriKind.RelativeOrAbsolute));
                _plus2 = 0;
            }
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            if (btn4.Content.ToString() == "0")
            {
                btn4.Content = "1";
                Apple6.Source = new BitmapImage(new Uri("/Golden_Apple_JE2_BE2-removebg-preview.png", UriKind.RelativeOrAbsolute));
                _plus4 = 4;
            }
            else
            {
                btn4.Content = "0";
                Apple6.Source = new BitmapImage(new Uri("/minecraft_apple-removebg-preview.png", UriKind.RelativeOrAbsolute));
                _plus4 = 0;
            }
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            if (btn8.Content.ToString() == "0")
            {
                btn8.Content = "1";
                Apple5.Source = new BitmapImage(new Uri("/Golden_Apple_JE2_BE2-removebg-preview.png", UriKind.RelativeOrAbsolute));
                _plus8 = 8;
            }
            else
            {
                btn8.Content = "0";
                Apple5.Source = new BitmapImage(new Uri("/minecraft_apple-removebg-preview.png", UriKind.RelativeOrAbsolute));
                _plus8 = 0;
            }
        }

        private void Btn16_Click(object sender, RoutedEventArgs e)
        {
            if (btn16.Content.ToString() == "0")
            {
                btn16.Content = "1";
                Apple4.Source = new BitmapImage(new Uri("/Golden_Apple_JE2_BE2-removebg-preview.png", UriKind.RelativeOrAbsolute));
                _plus16 = 16;
            }
            else
            {
                btn16.Content = "0";
                Apple4.Source = new BitmapImage(new Uri("/minecraft_apple-removebg-preview.png", UriKind.RelativeOrAbsolute));
                _plus16 = 0;
            }
        }

        private void Btn32_Click(object sender, RoutedEventArgs e)
        {
            if (btn32.Content.ToString() == "0")
            {
                btn32.Content = "1";
                Apple3.Source = new BitmapImage(new Uri("/Golden_Apple_JE2_BE2-removebg-preview.png", UriKind.RelativeOrAbsolute));
                _plus32 = 32;
            }
            else
            {
                btn32.Content = "0";
                Apple3.Source = new BitmapImage(new Uri("/minecraft_apple-removebg-preview.png", UriKind.RelativeOrAbsolute));
                _plus32 = 0;
            }
        }

        private void Btn64_Click(object sender, RoutedEventArgs e)
        {
            if (btn64.Content.ToString() == "0")
            {
                btn64.Content = "1";
                Apple2.Source = new BitmapImage(new Uri("/Golden_Apple_JE2_BE2-removebg-preview.png", UriKind.RelativeOrAbsolute));
                _plus64 = 64;
            }
            else
            {
                btn64.Content = "0";
                Apple2.Source = new BitmapImage(new Uri("/minecraft_apple-removebg-preview.png", UriKind.RelativeOrAbsolute));
                _plus64 = 0;
            }
        }

        private void Btn128_Click(object sender, RoutedEventArgs e)
        {
            if (btn128.Content.ToString() == "0")
            {
                btn128.Content = "1";
                Apple.Source = new BitmapImage(new Uri("/Golden_Apple_JE2_BE2-removebg-preview.png", UriKind.RelativeOrAbsolute));
                _plus128 = 128;
            }
            else
            {
                btn128.Content = "0";
                Apple.Source = new BitmapImage(new Uri("/minecraft_apple-removebg-preview.png", UriKind.RelativeOrAbsolute));
                _plus128 = 0;
            }
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {
            _dt.Start();
            _dtplaytime.Start();

            btnStart.IsEnabled = false;
            btnFinish.IsEnabled = true;

            btn1.IsEnabled = true;
            btn2.IsEnabled = true;
            btn4.IsEnabled = true;
            btn8.IsEnabled = true;
            btn16.IsEnabled = true;
            btn32.IsEnabled = true;
            btn64.IsEnabled = true;
            btn128.IsEnabled = true;

            int rnd = _rnd.Next(0, 256);
            lbRandomNum.Content = rnd.ToString();

            btnBack.IsEnabled = false;
        }

        private void BtnFinish_Click(object sender, RoutedEventArgs e)
        {
            int result = _plus1 + _plus2 + _plus4 + _plus8 + _plus16 + _plus32 + _plus64 + _plus128;

            if (result.ToString() == lbRandomNum.Content.ToString())
            {
                _dt.Stop();
                _dtplaytime.Start();

                _rounds++;
                lbRounds.Content = _rounds.ToString();

                double minus = _rounds * 0.066;
                int roundTimer = 30 - (int)(30 * minus);
                lbTimer.Content = roundTimer.ToString();

                if (_rounds >= 11)
                {
                    _sec = 10;
                    lbTimer.Content = _sec.ToString();
                }

                MessageBox.Show("Correct!");
                btnStart.IsEnabled = true;
                btnFinish.IsEnabled = false;

                btn1.IsEnabled = false;
                btn2.IsEnabled = false;
                btn4.IsEnabled = false;
                btn8.IsEnabled = false;
                btn16.IsEnabled = false;
                btn32.IsEnabled = false;
                btn64.IsEnabled = false;
                btn128.IsEnabled = false;

                btn1.Content = "0";
                btn2.Content = "0";
                btn4.Content = "0";
                btn8.Content = "0";
                btn16.Content = "0";
                btn32.Content = "0";
                btn64.Content = "0";
                btn128.Content = "0";

                _plus1 = 0;
                _plus2 = 0;
                _plus4 = 0;
                _plus8 = 0;
                _plus16 = 0;
                _plus32 = 0;
                _plus64 = 0;
                _plus128 = 0;

                Apple.Source = new BitmapImage(new Uri("/minecraft_apple-removebg-preview.png", UriKind.RelativeOrAbsolute));
                Apple2.Source = new BitmapImage(new Uri("/minecraft_apple-removebg-preview.png", UriKind.RelativeOrAbsolute));
                Apple3.Source = new BitmapImage(new Uri("/minecraft_apple-removebg-preview.png", UriKind.RelativeOrAbsolute));
                Apple4.Source = new BitmapImage(new Uri("/minecraft_apple-removebg-preview.png", UriKind.RelativeOrAbsolute));
                Apple5.Source = new BitmapImage(new Uri("/minecraft_apple-removebg-preview.png", UriKind.RelativeOrAbsolute));
                Apple6.Source = new BitmapImage(new Uri("/minecraft_apple-removebg-preview.png", UriKind.RelativeOrAbsolute));
                Apple7.Source = new BitmapImage(new Uri("/minecraft_apple-removebg-preview.png", UriKind.RelativeOrAbsolute));
                Apple8.Source = new BitmapImage(new Uri("/minecraft_apple-removebg-preview.png", UriKind.RelativeOrAbsolute));

                lbRandomNum.Content = "";

                _score+= 5;
                lbScore.Content = _score.ToString();
            }
            else
            {
                MessageBox.Show($"Wrong! {result}");
            }
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Menu = new MainWindow();
            Menu.Show();
            this.Close();
        }
    }
}
