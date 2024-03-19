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
    /// Interaction logic for Playername.xaml
    /// </summary>
    public partial class Playername : Window
    {
        public string uInput { get; private set; }

        public Playername()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            uInput = tbUsername.Text;
            DialogResult = true;
        }
    }
}
