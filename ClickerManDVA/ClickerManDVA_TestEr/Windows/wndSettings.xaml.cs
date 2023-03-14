using ClickerManDVA_TestEr.Pages;
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

namespace ClickerManDVA_TestEr.Windows
{
    /// <summary>
    /// Логика взаимодействия для wndSettings.xaml
    /// </summary>
    public partial class wndSettings : Window
    {
        public wndSettings()
        {
            InitializeComponent();
        }

        private void btnCansel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            _Setting.timeSnape = Convert.ToInt16(txbTimeSnap.Text);
            _Setting.sleepTime = Convert.ToInt16(txbTimeSleep.Text);
            this.Close();
        }
    }
}
