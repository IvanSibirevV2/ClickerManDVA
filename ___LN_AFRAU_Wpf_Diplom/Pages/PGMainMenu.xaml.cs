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
#endregion

namespace WpfDiplom.Pages
{
    public partial class PGMainMenu : System.Windows.Controls.Page
    {
        #region Библиотеки
        //Подключение библиотек
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool GetCursorPos(ref Win32Point pt);

        [DllImport("User32.dll")]
        private static extern bool SetCursorPos(int X, int Y);
        #endregion
        #region Временные хранилища
        // Создание временных хранилищ
        const int SW_HIDE = 0;
        const int SW_SHOW = 5;
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private static LowLevelKeyboardProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        private static string[] RKey = new string[] { "Ф", "Ы", "В", "А", "Й", "Ц", "У", "К", "Е", "Н", "Г", "Ш", "Щ", "З", "Х", "Ъ", "П", "Р", "О", " ", "Л", "Д", "Ж", "Э", "Ё", "Я", "Ч", "С", "М", "И", "Т", "Ь", "Б", "Ю", "." };
        private static string[] EKey = new string[] { "A", "S", "D", "F", "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "[", "]", "G", "H", "J", "Space", "K", "L", ";", "'", "`", "Z", "X", "C", "V", "B", "N", "M", ",", ".", "/" };

        private static List<string> arrModifire = new List<string>();
        private static List<string> arrIsKey = new List<string>();
        private static List<VirtualKeyCode> arrVkCode = new List<VirtualKeyCode>();

        public static string tempVivod = "";

        public static class MyClickS
            {
                public static void Upd()
                {
                MegaClick("");
               // btn_Read_Click(null,null);
                }
            }
        #endregion

        public static PGMainMenu mo = new PGMainMenu();

        //Инициализация
        public PGMainMenu()
        {
            InitializeComponent();
            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Tick += GetMousePos;
            dt.Start();
            
            

        }

        #region Координаты мыши
        [StructLayout(LayoutKind.Sequential)]
        internal struct Win32Point
        {
            public Int32 X;
            public Int32 Y;
        };

        public static Point GetMousePosition()
        {
            Win32Point w32Mouse = new Win32Point();
            GetCursorPos(ref w32Mouse);
            return new Point(w32Mouse.X, w32Mouse.Y);
        }
        
        private void GetMousePos(object sender, EventArgs e)
        {
            //string.Format("{0:N1}", Mouse.GetPosition(this).Y);
            lblXCoord.Content = GetMousePosition().X.ToString();
            lblYCoord.Content = GetMousePosition().Y.ToString();
        }
        #endregion
        #region Индусокод
        // Индусокод
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);
        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }
            
        }
        #endregion
        #region Запись во временный массив и в файл
        //Запись во временный массив и в файл.
        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                arrVkCode.Add((VirtualKeyCode)vkCode);
                tempVivod += vkCode.ToString();
                /*
                string text = ((Keys)vkCode).ToString();

                кstring text2 = "";

                Конвертация кодов в буквы
                for (int i = 0; i < EKey.Length; i++)
                {
                    if (text == EKey[i]) text2 = RKey[i];
                }
                
                System.IO.File.AppendAllText("C:\\Users\\LordN\\Desktop\\test\\WriteText.txt", vkCode.ToString());
                */


                ///
                //System.IO.File.AppendAllText("C:\\Users\\LordN\\Desktop\\test\\WriteText.txt", vkCode.ToString() + " ");
                ///
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }
        #endregion
        #region Начало записи действий
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //System.IO.File.WriteAllText("C:\\Users\\LordN\\Desktop\\test\\WriteText.txt", "");
            arrVkCode.Clear();
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_SHOW);
            _hookID = SetHook(_proc);
        }
        #endregion
        #region Остановка записи
        private void btn_StopRec_Click(object sender, RoutedEventArgs e)
        {
            lblProgVivod.Text = tempVivod;
            UnhookWindowsHookEx(_hookID);
            string tempStr = "";
            for (int i = 0; i < arrVkCode.Count; i++)
            {
                tempStr += arrVkCode[i]+" "+Convert.ToInt32(arrVkCode[i]).ToString()+" ";
            }
            lblProgVivod.Text = tempStr;
        }
        #endregion
        #region Воспроизведение
        async private void btn_StartWork_Click(object sender, RoutedEventArgs e)
        {
            UnhookWindowsHookEx(_hookID);
            var simu = new InputSimulator();
            for (int i = 0; i < arrVkCode.Count; i++)
            {
                simu.Keyboard.ModifiedKeyStroke(null, arrVkCode[i]);
                await Task.Delay(VarSettings.WaitSec);
            }
        }
        #endregion
        #region Переход на страницу настроек
        private void btn_Setings_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PGSetings());
        }

        //Кнопка LWin
        private void Btn62_Click(object sender, RoutedEventArgs e)
        {
            arrVkCode.Add((VirtualKeyCode)91);
        }
        #endregion
        #region Очистка
        private void btn_AllDel_Click(object sender, RoutedEventArgs e)
        {
            //System.IO.File.WriteAllText("C:\\Users\\LordN\\Desktop\\test\\WriteText.txt", "");
            arrVkCode.Clear();
            //lblProgVivod.Text = "";
        }
        #endregion
        #region функция воспроизведения скрипта из строки
        async public static void MegaClick(string script)
        {
            if (!string.IsNullOrWhiteSpace(script))
            {
                arrVkCode.Clear();
                arrModifire.Clear();
                arrIsKey.Clear();
                List<string> temp = new List<string>();
                temp.AddRange(script.Split(' '));

                for (int i = 0; i < temp.Count; i++)
                {
                    if (temp[i][0] == '(')
                    {
                        string tempModif = "";
                        if (i - 2 > 0 && temp[i - 2] == "+") tempModif = temp[i - 3];

                        var tStr = temp[i];
                        tStr = tStr.Substring(1, tStr.Length - 2);

                        for (int j = 1; j < Convert.ToInt32(tStr); j++)
                        {
                            var tt = Convert.ToInt32(temp[i - 1]);
                            arrVkCode.Add((VirtualKeyCode)tt);
                            if (tempModif != "") arrModifire.Add(tempModif); else arrModifire.Add("");
                            arrIsKey.Add("Yes");
                        }
                    }
                    else if (temp[i][0] == '+')
                    {
                        arrModifire.Add(temp[i - 1].ToString());
                        if (i < temp.Count - 1)
                        {
                            var tt = Convert.ToInt32(temp[i + 1]);
                            arrVkCode.Add((VirtualKeyCode)tt);
                            i++;
                        }
                        arrIsKey.Add("Yes");
                    }
                    else if (temp[i][0] == '1' || temp[i][0] == '2' || temp[i][0] == '3' || temp[i][0] == '4' || temp[i][0] == '5' || temp[i][0] == '6' || temp[i][0] == '7' || temp[i][0] == '8' || temp[i][0] == '9')
                    {
                        try
                        {
                            var tt = Convert.ToInt32(temp[i]);
                            arrVkCode.Add((VirtualKeyCode)tt);
                            arrModifire.Add("");
                            arrIsKey.Add("Yes");
                        }
                        catch (Exception)
                        {
                            System.Windows.MessageBox.Show("Сценарий действий написан не правильно!");
                            return;
                        }

                    }
                    else if (temp[i].Contains("MouseMoveTo"))
                    {
                        arrIsKey.Add("MouseMoveTo" + " " + temp[i + 1] + " " + temp[i + 2]);
                        arrModifire.Add("");
                        arrModifire.Add("");
                        arrModifire.Add("");
                        arrVkCode.Add(VirtualKeyCode.F24);
                        arrVkCode.Add(VirtualKeyCode.F24);
                        arrVkCode.Add(VirtualKeyCode.F24);
                        i += 2;
                    }
                    else if (temp[i].Contains("MouseMoveBy"))
                    {
                        arrIsKey.Add("MouseMoveBy" + " " + temp[i + 1] + " " + temp[i + 2]);
                        i += 2;
                        arrModifire.Add("");
                        arrModifire.Add("");
                        arrModifire.Add("");
                        arrVkCode.Add(VirtualKeyCode.F24);
                        arrVkCode.Add(VirtualKeyCode.F24);
                        arrVkCode.Add(VirtualKeyCode.F24);
                    }
                    else if (temp[i] == "LeftButtonClick")
                    {
                        arrIsKey.Add("LeftButtonClick");
                        i++;
                        arrModifire.Add("");
                        arrVkCode.Add(VirtualKeyCode.F24);
                    }
                    else if (temp[i] == "RightButtonClick")
                    {
                        arrIsKey.Add("RightButtonClick");
                        i++;
                        arrModifire.Add("");
                        arrVkCode.Add(VirtualKeyCode.F24);
                    }
                }

                var simu = new InputSimulator();
                for (int i = 0; i < arrIsKey.Count; i++)
                {
                    if (arrIsKey[i] == "Yes")
                    {
                        switch (arrModifire[i])
                        {
                            case "":
                                simu.Keyboard.ModifiedKeyStroke(null, arrVkCode[i]);
                                break;
                            case "LSHIFT":
                                simu.Keyboard.ModifiedKeyStroke((VirtualKeyCode)160, arrVkCode[i]);
                                break;
                            case "LWIN":
                                simu.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LWIN, arrVkCode[i]);
                                break;
                            case "LCTRL":
                                simu.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LCONTROL, arrVkCode[i]);
                                break;
                            case "LALT":
                                simu.Keyboard.ModifiedKeyStroke(VirtualKeyCode.LMENU, arrVkCode[i]);
                                break;
                        }
                    }
                    else if (arrIsKey[i].Contains("MouseMoveTo"))
                    {
                        var tt = arrIsKey[i].Split(' ');
                        SetCursorPos(Convert.ToInt32(tt[1]), Convert.ToInt32(tt[2]));
                    }
                    else if (arrIsKey[i].Contains("MouseMoveBy"))
                    {
                        var tt = arrIsKey[i].Split(' ');
                        SetCursorPos((int)GetMousePosition().X + Convert.ToInt32(tt[1]), (int)GetMousePosition().Y + Convert.ToInt32(tt[2]));
                    }
                    else if (arrIsKey[i] == "LeftButtonClick")
                    {
                        simu.Mouse.LeftButtonClick();
                    }
                    else if (arrIsKey[i] == "RightButtonClick")
                    {
                        simu.Mouse.RightButtonClick();
                    }
                    await Task.Delay(VarSettings.WaitSec);
                }

            }
            else System.Windows.MessageBox.Show("Заполните поле скрипта!");
        }
        #endregion
        #region Прочтение строки скрипта
        private void btn_Read_Click(object sender, RoutedEventArgs e)
        {
            MegaClick(lblProgVivod.Text);
        }
        #endregion
        #region Тесты
        private void MouseBtnLeft_Click(object sender, RoutedEventArgs e)
        {
            MouseBtnLeft.Background = Brushes.Green;
        }
        #endregion

        #region Тестирование
        async private void btn_Test_Click(object sender, RoutedEventArgs e)
        {
            var simu = new InputSimulator();
            SetCursorPos(295,1043);
            await Task.Delay(VarSettings.WaitSec);
            simu.Mouse.RightButtonClick();


            await Task.Delay(VarSettings.WaitSec);
        }
        #endregion

        #region Сохранение в файл
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(lblProgVivod.Text))
            {
                System.Windows.Forms.SaveFileDialog saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
                saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                // получаем выбранный файл
                string filename = saveFileDialog1.FileName;
                // сохраняем текст в файл
                System.IO.File.WriteAllText(filename, lblProgVivod.Text);
                System.Windows.MessageBox.Show("Файл сохранен");
            }
            else
            {
                System.Windows.MessageBox.Show("Сценарий действий пуст!");
            }
        }
        #endregion
# region Импорт из файла
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            lblProgVivod.Text = System.IO.File.ReadAllText(filename);
        }
        #endregion
       
    }
}
