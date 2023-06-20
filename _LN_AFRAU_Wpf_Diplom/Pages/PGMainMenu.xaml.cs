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
using ClickerManDVA_DVA;
using System.Threading;
using System.Windows.Media.Media3D;
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
        private static ClickerManDVA_DVA.DataContext p_DataContext = new ClickerManDVA_DVA.DataContext();
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
        private System.Boolean ExitFlag = true;
        public PGMainMenu()
        {
            InitializeComponent();
            thread = new Thread(A => {
                System.Boolean _wrewrew = true;
                while (_wrewrew)
                {
                    System.Threading.Thread.Sleep(50);
                    if (this.A_Is()) { this.A_Set_Background_Green(); } else { this.A_Set_Background_Gray(); }
                    if (this.B_Is()) { this.B_Set_Background_Green(); } else { this.B_Set_Background_Gray(); }
                    if (this.C_Is()) { this.C_Set_Background_Green(); } else { this.C_Set_Background_Gray(); }
                    if (this.D_Is()) { this.D_Set_Background_Green(); } else { this.D_Set_Background_Gray(); }
                    if (this.E_Is()) { this.E_Set_Background_Green(); } else { this.E_Set_Background_Gray(); }
                    if (this.F_Is()) { this.F_Set_Background_Green(); } else { this.F_Set_Background_Gray(); }
                    if (this.G_Is()) { this.G_Set_Background_Green(); } else { this.G_Set_Background_Gray(); }
                    if (this.H_Is()) { this.H_Set_Background_Green(); } else { this.H_Set_Background_Gray(); }
                    if (this.I_Is()) { this.I_Set_Background_Green(); } else { this.I_Set_Background_Gray(); }
                    if (this.J_Is()) { this.J_Set_Background_Green(); } else { this.J_Set_Background_Gray(); }
                    if (this.K_Is()) { this.K_Set_Background_Green(); } else { this.K_Set_Background_Gray(); }
                    if (this.L_Is()) { this.L_Set_Background_Green(); } else { this.L_Set_Background_Gray(); }
                    if (this.M_Is()) { this.M_Set_Background_Green(); } else { this.M_Set_Background_Gray(); }
                    if (this.N_Is()) { this.N_Set_Background_Green(); } else { this.N_Set_Background_Gray(); }
                    if (this.O_Is()) { this.O_Set_Background_Green(); } else { this.O_Set_Background_Gray(); }
                    if (this.P_Is()) { this.P_Set_Background_Green(); } else { this.P_Set_Background_Gray(); }
                    if (this.Q_Is()) { this.Q_Set_Background_Green(); } else { this.Q_Set_Background_Gray(); }
                    if (this.R_Is()) { this.R_Set_Background_Green(); } else { this.R_Set_Background_Gray(); }
                    if (this.S_Is()) { this.S_Set_Background_Green(); } else { this.S_Set_Background_Gray(); }
                    if (this.T_Is()) { this.T_Set_Background_Green(); } else { this.T_Set_Background_Gray(); }
                    if (this.U_Is()) { this.U_Set_Background_Green(); } else { this.U_Set_Background_Gray(); }
                    if (this.V_Is()) { this.V_Set_Background_Green(); } else { this.V_Set_Background_Gray(); }
                    if (this.W_Is()) { this.W_Set_Background_Green(); } else { this.W_Set_Background_Gray(); }
                    if (this.X_Is()) { this.X_Set_Background_Green(); } else { this.X_Set_Background_Gray(); }
                    if (this.Y_Is()) { this.Y_Set_Background_Green(); } else { this.Y_Set_Background_Gray(); }
                    if (this.Z_Is()) { this.Z_Set_Background_Green(); } else { this.Z_Set_Background_Gray(); }
                    if (this._0_Is()) { this._0_Set_Background_Green(); } else { this._0_Set_Background_Gray(); }
                    if (this._1_Is()) { this._1_Set_Background_Green(); } else { this._1_Set_Background_Gray(); }
                    if (this._2_Is()) { this._2_Set_Background_Green(); } else { this._2_Set_Background_Gray(); }
                    if (this._3_Is()) { this._3_Set_Background_Green(); } else { this._3_Set_Background_Gray(); }
                    if (this._4_Is()) { this._4_Set_Background_Green(); } else { this._4_Set_Background_Gray(); }
                    if (this._5_Is()) { this._5_Set_Background_Green(); } else { this._5_Set_Background_Gray(); }
                    if (this._6_Is()) { this._6_Set_Background_Green(); } else { this._6_Set_Background_Gray(); }
                    if (this._7_Is()) { this._7_Set_Background_Green(); } else { this._7_Set_Background_Gray(); }
                    if (this._8_Is()) { this._8_Set_Background_Green(); } else { this._8_Set_Background_Gray(); }
                    if (this._9_Is()) { this._9_Set_Background_Green(); } else { this._9_Set_Background_Gray(); }
                    if (this.F1_Is()) { this.F1_Set_Background_Green(); } else { this.F1_Set_Background_Gray(); }
                    if (this.F2_Is()) { this.F2_Set_Background_Green(); } else { this.F2_Set_Background_Gray(); }
                    if (this.F3_Is()) { this.F3_Set_Background_Green(); } else { this.F3_Set_Background_Gray(); }
                    if (this.F4_Is()) { this.F4_Set_Background_Green(); } else { this.F4_Set_Background_Gray(); }
                    if (this.F5_Is()) { this.F5_Set_Background_Green(); } else { this.F5_Set_Background_Gray(); }
                    if (this.F6_Is()) { this.F6_Set_Background_Green(); } else { this.F6_Set_Background_Gray(); }
                    if (this.F7_Is()) { this.F7_Set_Background_Green(); } else { this.F7_Set_Background_Gray(); }
                    if (this.F8_Is()) { this.F8_Set_Background_Green(); } else { this.F8_Set_Background_Gray(); }
                    if (this.F9_Is()) { this.F9_Set_Background_Green(); } else { this.F9_Set_Background_Gray(); }
                    if (this.F10_Is()) { this.F10_Set_Background_Green(); } else { this.F10_Set_Background_Gray(); }
                    if (this.F11_Is()) { this.F11_Set_Background_Green(); } else { this.F11_Set_Background_Gray(); }
                    if (this.F12_Is()) { this.F12_Set_Background_Green(); } else { this.F12_Set_Background_Gray(); }
                    if (this.NumZero_Is()) { this.NumZero_Set_Background_Green(); } else { this.NumZero_Set_Background_Gray(); }
                    if (this.NumOne_Is()) { this.NumOne_Set_Background_Green(); } else { this.NumOne_Set_Background_Gray(); }
                    if (this.NumTwo_Is()) { this.NumTwo_Set_Background_Green(); } else { this.NumTwo_Set_Background_Gray(); }
                    if (this.NumThree_Is()) { this.NumThree_Set_Background_Green(); } else { this.NumThree_Set_Background_Gray(); }
                    if (this.NumFor_Is()) { this.NumFor_Set_Background_Green(); } else { this.NumFor_Set_Background_Gray(); }
                    if (this.NumFive_Is()) { this.NumFive_Set_Background_Green(); } else { this.NumFive_Set_Background_Gray(); }
                    if (this.NumSix_Is()) { this.NumSix_Set_Background_Green(); } else { this.NumSix_Set_Background_Gray(); }
                    if (this.NumSeven_Is()) { this.NumSeven_Set_Background_Green(); } else { this.NumSeven_Set_Background_Gray(); }
                    if (this.NumEight_Is()) { this.NumEight_Set_Background_Green(); } else { this.NumEight_Set_Background_Gray(); }
                    if (this.NumNine_Is()) { this.NumNine_Set_Background_Green(); } else { this.NumNine_Set_Background_Gray(); }
                    if (this.NumStar_Is()) { this.NumStar_Set_Background_Green(); } else { this.NumStar_Set_Background_Gray(); }
                    if (this.NumPlus_Is()) { this.NumPlus_Set_Background_Green(); } else { this.NumPlus_Set_Background_Gray(); }
                    if (this.NumMinus_Is()) { this.NumMinus_Set_Background_Green(); } else { this.NumMinus_Set_Background_Gray(); }
                    if (this.NumDot_Is()) { this.NumDot_Set_Background_Green(); } else { this.NumDot_Set_Background_Gray(); }
                    if (this.NumSlash_Is()) { this.NumSlash_Set_Background_Green(); } else { this.NumSlash_Set_Background_Gray(); }
                    if (this.NumEnter_Is()) { this.NumEnter_Set_Background_Green(); } else { this.NumEnter_Set_Background_Gray(); }
                    if (this.NUMLOCK_Is()) { this.NUMLOCK_Set_Background_Green(); } else { this.NUMLOCK_Set_Background_Gray(); }
                    //if (this.Slash_Is()) { this.Slash_Set_Background_Green(); } else { this.Slash_Set_Background_Gray(); }
                    if (this.Space_Is()) { this.Space_Set_Background_Green(); } else { this.Space_Set_Background_Gray(); }
                    if (this.Enter_Is()) { this.Enter_Set_Background_Green(); } else { this.Enter_Set_Background_Gray(); }
                    if (this.Escape_Is()) { this.Escape_Set_Background_Green(); } else { this.Escape_Set_Background_Gray(); }
                    if (this.LShift_Is()) { this.LShift_Set_Background_Green(); } else { this.LShift_Set_Background_Gray(); }
                    if (this.RShift_Is()) { this.RShift_Set_Background_Green(); } else { this.RShift_Set_Background_Gray(); }
                    if (this.BackSpace_Is()) { this.BackSpace_Set_Background_Green(); } else { this.BackSpace_Set_Background_Gray(); }
                    if (this.Tab_Is()) { this.Tab_Set_Background_Green(); } else { this.Tab_Set_Background_Gray(); }
                    if (this.LeftCTRL_Is()) { this.LeftCTRL_Set_Background_Green(); } else { this.LeftCTRL_Set_Background_Gray(); }
                    if (this.RightCTRL_Is()) { this.RightCTRL_Set_Background_Green(); } else { this.RightCTRL_Set_Background_Gray(); }
                    if (this.LeftAlt_Is()) { this.LeftAlt_Set_Background_Green(); } else { this.LeftAlt_Set_Background_Gray(); }
                    if (this.RightAlt_Is()) { this.RightAlt_Set_Background_Green(); } else { this.RightAlt_Set_Background_Gray(); }
                    if (this.Pause_Is()) { this.Pause_Set_Background_Green(); } else { this.Pause_Set_Background_Gray(); }
                    if (this.CapsLock_Is()) { this.CapsLock_Set_Background_Green(); } else { this.CapsLock_Set_Background_Gray(); }
                    if (this.PageUp_Is()) { this.PageUp_Set_Background_Green(); } else { this.PageUp_Set_Background_Gray(); }
                    if (this.PageDown_Is()) { this.PageDown_Set_Background_Green(); } else { this.PageDown_Set_Background_Gray(); }
                    if (this.End_Is()) { this.End_Set_Background_Green(); } else { this.End_Set_Background_Gray(); }
                    if (this.Home_Is()) { this.Home_Set_Background_Green(); } else { this.Home_Set_Background_Gray(); }
                    if (this.ArrowUp_Is()) { this.ArrowUp_Set_Background_Green(); } else { this.ArrowUp_Set_Background_Gray(); }
                    if (this.ArrowLeft_Is()) { this.ArrowLeft_Set_Background_Green(); } else { this.ArrowLeft_Set_Background_Gray(); }
                    if (this.ArrowRight_Is()) { this.ArrowRight_Set_Background_Green(); } else { this.ArrowRight_Set_Background_Gray(); }
                    if (this.ArrowDown_Is()) { this.ArrowDown_Set_Background_Green(); } else { this.ArrowDown_Set_Background_Gray(); }
                    if (this.Insert_Is()) { this.Insert_Set_Background_Green(); } else { this.Insert_Set_Background_Gray(); }
                    if (this.Delete_Is()) { this.Delete_Set_Background_Green(); } else { this.Delete_Set_Background_Gray(); }
                    if (this.LeftWin_Is()) { this.LeftWin_Set_Background_Green(); } else { this.LeftWin_Set_Background_Gray(); }
                    if (this.RightWin_Is()) { this.RightWin_Set_Background_Green(); } else { this.RightWin_Set_Background_Gray(); }
                    if (this.PrintScreen_Is()) { this.PrintScreen_Set_Background_Green(); } else { this.PrintScreen_Set_Background_Gray(); }
                    //////////////////////////////////////////////////////
                    if (this.ScrollLock_Is()) { this.ScrollLock_Set_Background_Green(); } else { this.ScrollLock_Set_Background_Gray(); }

                    

                    //if (this.__Is(222)) System.Windows.MessageBox.Show("222");


                    Dispatcher.InvokeAsync(() => _wrewrew = this.ExitFlag);
                }
            });
            thread.Start();

            //пОДСВЕТИТЬ ПОДДЕРЖИВАЕМЫЕ КЛАВИШИ


            if (true)
                this
                    .A_Set_Background_White().B_Set_Background_White().C_Set_Background_White().D_Set_Background_White()
                    .E_Set_Background_White().F_Set_Background_White().G_Set_Background_White().H_Set_Background_White()
                    .I_Set_Background_White().J_Set_Background_White().K_Set_Background_White().L_Set_Background_White()
                    .M_Set_Background_White().N_Set_Background_White().O_Set_Background_White().P_Set_Background_White()
                    .Q_Set_Background_White().R_Set_Background_White().S_Set_Background_White().T_Set_Background_White()
                    .U_Set_Background_White().V_Set_Background_White().W_Set_Background_White().X_Set_Background_White()
                    .Y_Set_Background_White().Z_Set_Background_White()
                    ._0_Set_Background_White()._1_Set_Background_White()._2_Set_Background_White()._3_Set_Background_White()
                    ._4_Set_Background_White()._5_Set_Background_White()._6_Set_Background_White()._7_Set_Background_White()
                    ._8_Set_Background_White()._9_Set_Background_White()
                    .F1_Set_Background_White().F2_Set_Background_White().F3_Set_Background_White().F4_Set_Background_White()
                    .F5_Set_Background_White().F6_Set_Background_White().F7_Set_Background_White().F8_Set_Background_White()
                    .F9_Set_Background_White().F10_Set_Background_White().F11_Set_Background_White().F12_Set_Background_White()
                    .NumZero_Set_Background_White().NumOne_Set_Background_White().NumTwo_Set_Background_White()
                    .NumThree_Set_Background_White().NumFor_Set_Background_White().NumFive_Set_Background_White()
                    .NumSix_Set_Background_White().NumSeven_Set_Background_White().NumEight_Set_Background_White().NumNine_Set_Background_White()
                    .NumStar_Set_Background_White().NumPlus_Set_Background_White().NumMinus_Set_Background_White()
                    .NumDot_Set_Background_White().NumSlash_Set_Background_White().NumEnter_Set_Background_White().NUMLOCK_Set_Background_White()
                    //.Slash_Set_Background_White()
                    .Space_Set_Background_White().Enter_Set_Background_White()
                    .Escape_Set_Background_White().LShift_Set_Background_White().RShift_Set_Background_White()
                    .BackSpace_Set_Background_White().Tab_Set_Background_White().LeftCTRL_Set_Background_White().RightCTRL_Set_Background_White()
                    .Pause_Set_Background_White().CapsLock_Set_Background_White().PageUp_Set_Background_White().PageDown_Set_Background_White()
                    .End_Set_Background_White().Home_Set_Background_White()
                    .ArrowUp_Set_Background_White().ArrowDown_Set_Background_White().ArrowLeft_Set_Background_White().ArrowRight_Set_Background_White()
                    .Insert_Set_Background_White().Delete_Set_Background_White()
                    .LeftWin_Set_Background_White().RightWin_Set_Background_White()
                    .PrintScreen_Set_Background_White().ScrollLock_Set_Background_White()
                    

                ;
        }

        
        private void Button_Click_1(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Button_Click_1"); }
        private void Button_Click_2(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Button_Click_2"); }
        private void Btn21_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn21_Click"); }
        private void Btn59_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn59_Click"); }
        
        
        private void Btn212_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn212_Click"); }
        private void Btn213_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn213_Click"); }
        private void Btn312_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn312_Click"); }
        private void Btn313_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn313_Click"); }
        private void Btn411_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn411_Click"); }
        private void Btn412_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn412_Click"); }
        private void Btn510_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn510_Click"); }
        private void Btn511_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn511_Click"); }




        //////////////////////////////////////////////////////
        //(186,"PeriodComma")
        public System.String PeriodComma_String() { return "PeriodComma"; }
        public System.Byte PeriodComma_ASCII() { return 186; }
        public PGMainMenu PeriodComma() { return this; }
        public PGMainMenu PeriodComma_Down() { return this.__Down(this.PeriodComma_ASCII()); }
        public PGMainMenu PeriodComma_Up() { return this.__Up(this.PeriodComma_ASCII()); }
        public bool PeriodComma_Is() { return this.__Is(this.PeriodComma_ASCII()); }
        //////////////////////////////////////////////////////
        //(187,"Equally")
        public System.String Equally_String() { return "Equally"; }
        public System.Byte Equally_ASCII() { return 187; }
        public PGMainMenu Equally() { return this; }
        public PGMainMenu Equally_Down() { return this.__Down(this.Equally_ASCII()); }
        public PGMainMenu Equally_Up() { return this.__Up(this.Equally_ASCII()); }
        public bool Equally_Is() { return this.__Is(this.Equally_ASCII()); }
        //////////////////////////////////////////////////////
        //(188,"Сomma")
        public System.String Сomma_String() { return "Сomma"; }
        public System.Byte Сomma_ASCII() { return 188; }
        public PGMainMenu Сomma() { return this; }
        public PGMainMenu Сomma_Down() { return this.__Down(this.Сomma_ASCII()); }
        public PGMainMenu Сomma_Up() { return this.__Up(this.Сomma_ASCII()); }
        public bool Сomma_Is() { return this.__Is(this.Сomma_ASCII()); }
        //////////////////////////////////////////////////////
        //(189,"Minus")
        public System.String Minus_String() { return "Minus"; }
        public System.Byte Minus_ASCII() { return 189; }
        public PGMainMenu Minus() { return this; }
        public PGMainMenu Minus_Down() { return this.__Down(this.Minus_ASCII()); }
        public PGMainMenu Minus_Up() { return this.__Up(this.Minus_ASCII()); }
        public bool Minus_Is() { return this.__Is(this.Minus_ASCII()); }
        //////////////////////////////////////////////////////
        //(190,"Dot")
        public System.String Dot_String() { return "Dot"; }
        public System.Byte Dot_ASCII() { return 190; }
        public PGMainMenu Dot() { return this; }
        public PGMainMenu Dot_Down() { return this.__Down(this.Dot_ASCII()); }
        public PGMainMenu Dot_Up() { return this.__Up(this.Dot_ASCII()); }
        public bool Dot_Is() { return this.__Is(this.Dot_ASCII()); }
        //////////////////////////////////////////////////////
        //(192,"Tilda")
        public System.String Tilda_String() { return "NUMLOCK"; }
        public System.Byte Tilda_ASCII() { return 192; }
        public PGMainMenu Tilda() { return this; }
        public PGMainMenu Tilda_Down() { return this.__Down(this.Tilda_ASCII()); }
        public PGMainMenu Tilda_Up() { return this.__Up(this.Tilda_ASCII()); }
        public bool Tilda_Is() { return this.__Is(this.Tilda_ASCII()); }
        //////////////////////////////////////////////////////
        //(219,"SquScobOtk")
        public System.String SquScobOtk_String() { return "SquScobOtk"; }
        public System.Byte SquScobOtk_ASCII() { return 219; }
        public PGMainMenu SquScobOtk() { return this; }
        public PGMainMenu SquScobOtk_Down() { return this.__Down(this.SquScobOtk_ASCII()); }
        public PGMainMenu SquScobOtk_Up() { return this.__Up(this.SquScobOtk_ASCII()); }
        public bool SquScobOtk_Is() { return this.__Is(this.SquScobOtk_ASCII()); }
        //////////////////////////////////////////////////////
        //(220,"ObratSlash")
        public System.String ObratSlash_String() { return "NUMLOCK"; }
        public System.Byte ObratSlash_ASCII() { return 220; }
        public PGMainMenu ObratSlash() { return this; }
        public PGMainMenu ObratSlash_Down() { return this.__Down(this.ObratSlash_ASCII()); }
        public PGMainMenu ObratSlash_Up() { return this.__Up(this.ObratSlash_ASCII()); }
        public bool ObratSlash_Is() { return this.__Is(this.ObratSlash_ASCII()); }
        //////////////////////////////////////////////////////
        //(221,"SquScobZak")
        public System.String SquScobZak_String() { return "SquScobZak"; }
        public System.Byte SquScobZak_ASCII() { return 221; }
        public PGMainMenu SquScobZak() { return this; }
        public PGMainMenu SquScobZak_Down() { return this.__Down(this.SquScobZak_ASCII()); }
        public PGMainMenu SquScobZak_Up() { return this.__Up(this.SquScobZak_ASCII()); }
        public bool SquScobZak_Is() { return this.__Is(this.SquScobZak_ASCII()); }
        //////////////////////////////////////////////////////
        //(1,"MouseL")
        public System.String MouseL_String() { return "MouseL"; }
        public System.Byte MouseL_ASCII() { return 1; }
        public PGMainMenu MouseL() { return this; }
        public PGMainMenu MouseL_Down() { return this.__Down(this.MouseL_ASCII()); }
        public PGMainMenu MouseL_Up() { return this.__Up(this.MouseL_ASCII()); }
        public bool MouseL_Is() { return this.__Is(this.MouseL_ASCII()); }
        //////////////////////////////////////////////////////
        //(2,"MouseR")
        public System.String MouseR_String() { return "NUMLOCK"; }
        public System.Byte MouseR_ASCII() { return 2; }
        public PGMainMenu MouseR() { return this; }
        public PGMainMenu MouseR_Down() { return this.__Down(this.MouseR_ASCII()); }
        public PGMainMenu MouseR_Up() { return this.__Up(this.MouseR_ASCII()); }
        public bool MouseR_Is() { return this.__Is(this.MouseR_ASCII()); }
        //////////////////////////////////////////////////////
        //(4,"MMouse")
        public System.String MMouse_String() { return "MMouse"; }
        public System.Byte MMouse_ASCII() { return 4; }
        public PGMainMenu MMouse() { return this; }
        public PGMainMenu MMouse_Down() { return this.__Down(this.MMouse_ASCII()); }
        public PGMainMenu MMouse_Up() { return this.__Up(this.MMouse_ASCII()); }
        public bool MMouse_Is() { return this.__Is(this.MMouse_ASCII()); }
        //////////////////////////////////////////////////////
        //(222,"Mark")
        public System.String Mark_String() { return "Mark"; }
        public System.Byte Mark_ASCII() { return 222; }
        public PGMainMenu Mark() { return this; }
        public PGMainMenu Mark_Down() { return this.__Down(this.Mark_ASCII()); }
        public PGMainMenu Mark_Up() { return this.__Up(this.Mark_ASCII()); }
        public bool Mark_Is() { return this.__Is(this.Mark_ASCII()); }
        
        //////////////////////////////////////////////////////
        private void Button_Click(object sender, RoutedEventArgs e){}
        private void btn_StopRec_Click(object sender, RoutedEventArgs e){}
        async private void btn_StartWork_Click(object sender, RoutedEventArgs e){}
        #region Переход на страницу настроек
        private void btn_Setings_Click(object sender, RoutedEventArgs e)
        {NavigationService.Navigate(new PGSetings());}
        
        #endregion
        private void btn_AllDel_Click(object sender, RoutedEventArgs e){}
        private void btn_Read_Click(object sender, RoutedEventArgs e){}
        private void MouseBtnLeft_Click(object sender, RoutedEventArgs e){}
        async private void btn_Test_Click(object sender, RoutedEventArgs e){}

     

        private void Grid_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {
            this.ExitFlag = false;
            System.Threading.Thread.Sleep(50);
            this.thread.Abort();
            //thread = null;
        }

    }
}