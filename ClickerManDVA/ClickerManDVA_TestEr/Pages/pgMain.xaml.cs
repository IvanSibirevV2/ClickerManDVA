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
            //System.Mouse.OMTS();
            new Klava()

                .p_Mouse
                .p_Klava

                .VK_Win.Down().Sender.D.VK_Win.Up().Sender.VK_Win.Down().Sender.D.VK_Win.Up().Sender.Sleep(10);
            /*
            .H.U.T.D.O.W.N.Space.Slash.S.Space.Slash.T.Space._1._0
                .Space.Slash.C.Space.VK_Win.Down().Sender.Mark.VK_Shift.Up().Sender
                .A.N.Y.T.H.I.N.G.Space.E.L.S.E
                .VK_Shift.Down().Sender.Mark.VK_Shift.Up().Sender.P
                .Enter.Enter
                .p_Mouse
                .Set_CursorPos((int)1919 / 2, (int)1058 / 2)
                .L.L
                .Sleep(1000)

            ;
            */
            //System.Mouse.Test_SuperClickManiak();// Test_SuperClickManiak();
            
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
           
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            Window wnd = new Window();
            wnd = new wndSettings();
            wnd.ShowDialog();
        }


        #region wpRow1 Btn11-Btn116
        private void Btn11_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn11_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn12_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn12_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn13_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn13_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn14_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn14_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn15_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn15_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn16_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn16_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn17_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn17_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn18_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn18_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn19_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn19_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn110_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn110_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn111_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn111_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn112_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn112_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn113_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn113_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn114_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn114_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn115_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn115_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn116_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn116_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        #endregion
        #region wpRow2 Btn21-Btn221
        private void Btn21_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn21_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn22_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn22_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn23_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn23_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn24_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn24_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn25_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn25_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn26_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn26_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn27_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn27_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn28_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn28_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn29_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn29_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn210_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn210_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn211_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn211_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn212_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn212_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn213_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn213_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn214_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn214_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn215_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn215_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn216_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn216_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn217_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn217_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn218_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn218_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn219_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn219_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn220_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn220_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn221_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn221_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        #endregion
        #region wpRow3 Btn31-Btn321
        private void Btn31_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn31_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn32_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn32_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn33_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn33_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn34_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn34_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn35_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn35_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn36_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn36_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn37_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn37_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn38_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn38_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn39_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn39_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn310_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn310_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn311_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn311_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn312_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn312_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn313_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn313_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn314_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn314_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn315_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn315_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn316_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn316_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn317_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn317_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn318_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn318_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn319_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn319_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn320_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn320_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn321_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn321_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        #endregion
        #region wpRow4 Btn41-Btn416
        private void Btn41_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn41_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn42_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn42_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn43_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn43_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn44_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn44_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn45_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn45_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn46_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn46_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn47_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn47_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn48_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn48_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn49_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn49_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn411_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn411_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn410_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn410_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn412_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn412_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn413_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn413_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn414_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn414_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn415_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn415_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn416_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn416_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        #endregion
        #region wpRow5 Btn51-Btn517
        private void Btn51_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn51_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn52_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn52_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn53_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn53_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn54_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn54_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn55_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn55_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn56_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn56_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn57_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn57_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn58_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn58_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn59_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn59_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn510_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn510_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn511_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn511_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn512_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn512_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn513_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn513_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn514_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn514_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn515_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn515_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn516_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn516_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn517_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn517_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        #endregion
        #region wpRow6 Btn61-Btn610
        private void Btn61_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn61_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn62_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn62_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn63_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn63_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn64_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn64_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn65_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn65_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn66_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn66_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn67_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn67_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn68_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn68_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn69_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn69_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        private void Btn610_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e) { }
        private void Btn610_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e) { }
        #endregion

        private void Btn62_Click(object sender, RoutedEventArgs e)
        { Klava _Klava = new Klava();
            _Klava.HistoryVKS.AddRange(new List<List<VK>>
            {
               new List<VK>()
               ,new List<VK>(){new VK().Set(_str:"Win",_nVirtKey: Convert.ToByte(91))}
               ,new List<VK>()
            });
            _Klava.HistoryExecute();
            //true,false,false
            ;
            MessageBox.Show("123");
        }
    }
}
