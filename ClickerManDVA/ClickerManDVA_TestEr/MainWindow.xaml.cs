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
    }
}
