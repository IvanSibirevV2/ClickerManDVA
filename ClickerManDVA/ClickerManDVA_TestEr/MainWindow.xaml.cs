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
///////////////////////////////////////////////
using System.Threading;


namespace ClickerManDVA_TestEr
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public System.Threading.Thread p_Thread = null;
        public System.DateTime p_DateTime = System.DateTime.Now;
        public System.TimeSpan p_TimeSpan = System.TimeSpan.Zero;
        public MainWindow()
        {
            this.p_Thread= new Thread(() => {
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
            this.p_Thread.Start();
            
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.p_Thread.Abort();
            MessageBox.Show("Встали ли вы сегодня с той ноги когда проснулись?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning);
        }

        private void NameBtn11_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NameBtn12_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NameBtn13_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NameBtn14_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NameBtn15_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NameBtn16_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NameBtn17_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NameBtn18_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NameBtn11_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("dsfdsf");
        }

        private void NameBtn11_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("uo");
        }

        private void NameBtn12_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void NameBtn12_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void NameBtn13_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn21_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn21_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn22_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn22_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn23_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn23_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn24_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn24_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn25_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn25_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn26_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn26_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn27_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn27_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn28_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn28_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn11_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn11_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn12_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn12_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn13_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn13_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn14_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn14_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn15_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn15_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn16_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn16_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn17_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn17_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn18_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn18_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn19_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn19_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn110_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn110_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn111_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn111_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn112_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn112_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn113_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn113_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn114_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn114_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn115_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn115_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn116_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn116_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn31_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn31_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn32_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn32_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn33_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn33_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn34_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn34_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn35_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn35_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn36_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn36_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn37_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn37_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn38_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn38_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn39_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn39_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn310_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn310_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn311_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn311_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn312_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn312_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn313_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn313_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn314_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn314_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn315_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn315_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn316_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn316_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn317_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn317_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn318_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn318_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn319_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn319_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn320_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn320_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn321_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn321_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn51_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn51_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn52_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn52_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn53_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn53_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn54_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn54_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn55_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn55_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn56_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn56_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn57_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn57_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn58_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn58_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn59_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn59_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn510_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn510_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn511_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn511_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn512_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn512_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn513_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn513_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn514_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn514_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn515_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn515_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn516_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn516_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn517_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void Btn517_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
