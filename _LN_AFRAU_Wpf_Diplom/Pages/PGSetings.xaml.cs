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

namespace WpfDiplom.Pages
{
    /// <summary>
    /// Логика взаимодействия для PGSetings.xaml
    /// </summary>
    public partial class PGSetings : Page
    {
        public static class VarSettings
        {
            public static int WaitSec;
            public static int HotKey;
        }

        public PGSetings()
        {
            InitializeComponent();
            txbTimeSleep.Text = VarSettings.WaitSec.ToString();
        }

        private void btnCansel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PGMainMenu());
        }

        private void txbDefPath_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            VarSettings.WaitSec = Convert.ToInt32(txbTimeSleep.Text);
            VarSettings.HotKey = Convert.ToInt32(txbHotKey.Text);

            System.IO.File.WriteAllText("Conf.txt", VarSettings.WaitSec.ToString()+'\n'+VarSettings.HotKey.ToString());
            NavigationService.Navigate(new PGMainMenu());
        }

        private void txbDefPath_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
