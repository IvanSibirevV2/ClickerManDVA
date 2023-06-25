using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfDiplom.Pages;
using static WpfDiplom.Pages.PGMainMenu;
using static WpfDiplom.Pages.PGSetings;



namespace WpfDiplom
{
    public static class ThreadKran
    {
        public static System.Boolean _Flag = true;
        public static System.Action StopKran = () => { };
    }
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

           

            string strSetings = "";
            if (System.IO.File.Exists("Conf.txt"))
                strSetings = System.IO.File.ReadAllText("Conf.txt");
            else
            {
                strSetings = "100"+'\n'+"145";
                System.IO.File.WriteAllText("Conf.txt", strSetings);
            }
            
            List<string> tempStr = strSetings.Split('\n').ToList();
            
            VarSettings.WaitSec = Convert.ToInt32(tempStr[0]);
            VarSettings.HotKey = Convert.ToInt32(tempStr[1]);
            //Горячая клавиши esc для закрытия приложения
            //this.PreviewKeyDown += new KeyEventHandler(HandleEsc);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            // UnregisterHotkey();
            //System.Windows.Forms.MessageBox.Show("Do you want to close this window?");
            WpfDiplom.ThreadKran._Flag = false;
            WpfDiplom.ThreadKran.StopKran();
        }

        private void Frame_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {

        }



        //private void HandleEsc(object sender, KeyEventArgs e)
        //{
        //    if (e.Key == Key.Escape)
        //        Close();
        //}





    }
}
