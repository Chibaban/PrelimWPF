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
using System.IO;

namespace PrelimWPF
{
    /// <summary>
    /// Interaction logic for Leaderboards.xaml
    /// </summary>
    public partial class Leaderboards : Window
    {
        public Leaderboards()
        {
            InitializeComponent();
            Contents();
        }

        private void Contents()
        {
            if (File.Exists("LeaderboardsContent.csv"))
            {
                List<string[]> ContentData = new List<string[]>();

                using (StreamReader sr = new StreamReader("LeaderboardsContent.csv"))
                {
                    string line = "";
                    while ((line = sr.ReadLine()) != null) 
                    {
                        string[] data = line.Split(',');
                        ContentData.Add(data);
                    }
                }

                for (int x = 0; x < ContentData.Count - 1; x++)
                {
                    for (int y = x + 1; y < ContentData.Count; y++)
                    {
                        if (int.Parse(ContentData[y][1]) > int.Parse(ContentData[x][1]))
                        {
                            string[] temp = ContentData[x];
                            ContentData[x] = ContentData[y];
                            ContentData[y] = temp;
                        }
                    }
                }

                lbLeaderboards.Items.Clear();

                for(int x = 0; x < Math.Min(ContentData.Count, 10); x++)
                {
                    lbLeaderboards.Items.Add($"{ContentData[x][0]} - Score: {ContentData[x][1]}, Playtime: {ContentData[x][2]}");
                }
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
