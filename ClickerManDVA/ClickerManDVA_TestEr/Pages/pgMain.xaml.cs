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
using System.Threading;
using ClickerManDVA_TestEr.Windows;

namespace ClickerManDVA_TestEr.Pages
{
    /// <summary>
    /// Логика взаимодействия для pgMain.xaml
    /// </summary>
    /// 
    public static class _Setting
    {
        public static int sleepTime;
        public static int timeSnape;
    }

    public partial class pgMain : Page
    {
        public System.Threading.Thread p_Thread = null;
        public System.DateTime p_DateTime = System.DateTime.Now;
        public System.TimeSpan p_TimeSpan = System.TimeSpan.Zero;

        public pgMain()
        {
            this.p_Thread = new Thread(() => {
                while (true)
                {
                    System.TimeSpan _TimeSpan_Now = System.DateTime.Now - this.p_DateTime;
                    if ((_TimeSpan_Now - this.p_TimeSpan).TotalMilliseconds > 100)
                    {
                        this.p_TimeSpan = _TimeSpan_Now;
                        Dispatcher.InvokeAsync(() => this.Title = this.p_TimeSpan.TotalMilliseconds.ToString());
                    }
                }
                //System.Threading.Thread.Sleep(100);
            });
            InitializeComponent();
        }


        private void btnRec_Click(object sender, RoutedEventArgs e)
        {
            //this.p_Thread.Start();
            //MessageBox.Show("0");
            //System.Klava.Test_Record_HistoryExecute();
            System.Mouse.Test_SuperClickManiak();// Test_SuperClickManiak();
            MessageBox.Show("1");
        }

        private void btnStopRec_Click(object sender, RoutedEventArgs e)
        {
            this.p_Thread.Abort();
        }

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnVirtKlava_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new pgKlava());
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            Window wnd = new Window();
            wnd = new wndSettings();
            wnd.ShowDialog();
        }
    }
}
