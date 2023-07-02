#region Юзинги
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
using WindowsInput.Native;
using WindowsInput;
using static WpfDiplom.Pages.PGSetings;
using System.Reflection.Emit;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Windows.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using Microsoft.Win32;
using System.Runtime.CompilerServices;
//using ClickerManDVA_DVA;
using System.Threading;
using System.Windows.Media.Media3D;
using System.IO;
#endregion

namespace WpfDiplom.Pages
{
    public partial class PGMainMenu : System.Windows.Controls.Page
    {
        
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);
        [DllImport("user32.dll")]
        private static extern short GetKeyState(int nVirtKey);
        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);



        //WpfDiplom.Pages.PGMainMenu.p_DataContext
        //private static ClickerManDVA_DVA.DataContext p_DataContext = new ClickerManDVA_DVA.DataContext();
        #region Библиотеки
        //Подключение библиотек
        /*
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetCursorPos(ref Win32Point pt);

        [DllImport("User32.dll")]
        private static extern bool SetCursorPos(int X, int Y);
        */
        #endregion

        //////////////////////////////////////////////////////
        public PGMainMenu __Down(byte _bVk) { keybd_event(_bVk, 0, 0, 0); return this; }
        public PGMainMenu __Up(byte _bVk) { keybd_event(_bVk, 0, 2, 0); return this; }
        public System.Boolean __Is(byte _bVk) { switch (GetKeyState(_bVk)){ case -127: case -128: return true; break;default: return false; break;} return false; }
        //////////////////////////////////////////////////////
        

        /// <summary> Тестовый Мод Первый. Выводить в титульник название только что нажатой клациши</summary>
        private System.Boolean p_TestMod_1 = true;
        private Thread thread = null;
        private Thread threadRun = null;
        
        public PGMainMenu()
        {
            InitializeComponent();
            this.ForKeyIs();

            WpfDiplom.ThreadKran.StopKran = () => {
                Dispatcher.InvokeAsync(() => WpfDiplom.ThreadKran._Flag = false);
                if(this.thread!=null)this.thread.Abort();
                if (this.threadRun != null) this.threadRun.Abort();
            };
            

        }
        /// <summary>ФлагЗаписи</summary>
        private System.Boolean p_Record = false;
        private List<List<System.String>> p_LLS_Record= new List<List<System.String>>();
        /// <summary>Запись</summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.p_Record = true;
        }

        /// <summary>Сохранение в файл</summary>
        private void Button_Click_1(object sender, RoutedEventArgs e) 
        {
            using (TextWriter textWriter = File.CreateText("Temp.txt"))
            {
                foreach (List<System.String> ListString in this.p_LLS_Record)
                    textWriter.WriteLine(System.String.Join(";", ListString));
            }
            var process = System.Diagnostics.Process.Start("notepad.exe", "Temp.txt");

            process.WaitForExit();
        }
        /// <summary>Загрузить сценарий из файла</summary>
        private void Button_Click_2(object sender, RoutedEventArgs e) 
        {
            List<System.String> FileLines = File.ReadAllLines("Temp.txt", Encoding.UTF8).ToList<System.String>();
            this.p_LLS_Record.Clear();
            this.p_LLS_Record.Add(new List<string>());
            foreach (string line in FileLines)
                this.p_LLS_Record.Add(line.Split(';').ToList<System.String>());
        }
        
        //////////////////////////////////////////////////////
        
        private void btn_StopRec_Click(object sender, RoutedEventArgs e)
        {
            this.p_Record = false;
        }
        /// <summary> Воспроизведения</summary>
        async private void btn_StartWork_Click(object sender, RoutedEventArgs e)
        {
            if(threadRun!=null)threadRun.Abort();
            threadRun = null;
            threadRun = new Thread(A => {
                this.Runn();
            });
            threadRun.Start();

        }
        #region Переход на страницу настроек
        private void btn_Setings_Click(object sender, RoutedEventArgs e)
        {NavigationService.Navigate(new PGSetings());}
        
        #endregion
        /// <summary>Очистка</summary>
        private void btn_AllDel_Click(object sender, RoutedEventArgs e)
        {
            this.p_LLS_Record.Clear();
            this.p_LLS_Record.Add(new List<string>()) ;
        }
        /// <summary>Читать скрипт</summary>
        private void btn_Read_Click(object sender, RoutedEventArgs e)
        {
            var process =  System.Diagnostics.Process.Start("notepad.exe", "Temp.txt");
            
            process.WaitForExit();
        }
        
        async private void btn_Test_Click(object sender, RoutedEventArgs e){}

     

        private void Grid_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {
            
            //thread = null;
        }

        private void lblProgVivod_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}