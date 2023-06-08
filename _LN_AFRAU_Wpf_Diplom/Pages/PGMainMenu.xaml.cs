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


        //Инициализация
        public PGMainMenu()
        {
            InitializeComponent();
            //A_Set_Background_Green();
        }
        //////////////////////////////////////////////////////
        public PGMainMenu __Down(byte _bVk) { keybd_event(_bVk, 0, 0, 0); return this; }
        public PGMainMenu __Up(byte _bVk) { keybd_event(_bVk, 0, 2, 0); return this; }
        public System.Boolean __Is(byte _bVk) { switch (GetKeyState(_bVk)){ case -127: case -128: return true; break;default: return false; break;} return false; }
        //////////////////////////////////////////////////////
        //(65, "A")
        public System.String A_String() { return "A"; }
        public System.Byte A_ASCII() { return 65; }
        public PGMainMenu A() { return this; }
        public PGMainMenu A_Down() { return this.__Down(this.A_ASCII()); }
        public PGMainMenu A_Up() { return this.__Up(this.A_ASCII()); }
        public bool A_Is() { return this.__Is(this.A_ASCII()); }
        //public PGMainMenu A_Set_Background_White() { this.Btn44.Background = Brushes.White; return this; }
        //public PGMainMenu A_Set_Background_Green() { this.Btn44.Background = Brushes.Green; return this; }
        //////////////////////////////////////////////////////
        //(66, "B")
        public System.String B_String() { return "B"; }
        public System.Byte B_ASCII() { return 66; }
        public PGMainMenu B() { return this; }
        public PGMainMenu B_Down() { return this.__Down(this.B_ASCII()); }
        public PGMainMenu B_Up() { return this.__Up(this.B_ASCII()); }
        public bool B_Is() { return this.__Is(this.B_ASCII()); }
        //////////////////////////////////////////////////////
        //(67, "C")
        public System.String C_String() { return "C"; }
        public System.Byte C_ASCII() { return 67; }
        public PGMainMenu C() { return this; }
        public PGMainMenu C_Down() { return this.__Down(this.C_ASCII()); }
        public PGMainMenu C_Up() { return this.__Up(this.C_ASCII()); }
        public bool C_Is() { return this.__Is(this.C_ASCII()); }
        //////////////////////////////////////////////////////
        //(68, "D")
        public System.String D_String() { return "D"; }
        public System.Byte D_ASCII() { return 68; }
        public PGMainMenu D() { return this; }
        public PGMainMenu D_Down() { return this.__Down(this.D_ASCII()); }
        public PGMainMenu D_Up() { return this.__Up(this.D_ASCII()); }
        public bool D_Is() { return this.__Is(this.D_ASCII()); }
        //////////////////////////////////////////////////////
        //(69, "E")
        public System.String E_String() { return "E"; }
        public System.Byte E_ASCII() { return 69; }
        public PGMainMenu E() { return this; }
        public PGMainMenu E_Down() { return this.__Down(this.E_ASCII()); }
        public PGMainMenu E_Up() { return this.__Up(this.E_ASCII()); }
        public bool E_Is() { return this.__Is(this.E_ASCII()); }
        //////////////////////////////////////////////////////
        //(70, "F")
        public System.String F_String() { return "F"; }
        public System.Byte F_ASCII() { return 70; }
        public PGMainMenu F() { return this; }
        public PGMainMenu F_Down() { return this.__Down(this.F_ASCII()); }
        public PGMainMenu F_Up() { return this.__Up(this.F_ASCII()); }
        public bool F_Is() { return this.__Is(this.F_ASCII()); }
        //////////////////////////////////////////////////////
        //(71, "G")
        public System.String G_String() { return "G"; }
        public System.Byte G_ASCII() { return 71; }
        public PGMainMenu G() { return this; }
        public PGMainMenu G_Down() { return this.__Down(this.G_ASCII()); }
        public PGMainMenu G_Up() { return this.__Up(this.G_ASCII()); }
        public bool G_Is() { return this.__Is(this.G_ASCII()); }
        //////////////////////////////////////////////////////
        //(72, "H")
        public System.String H_String() { return "H"; }
        public System.Byte H_ASCII() { return 72; }
        public PGMainMenu H() { return this; }
        public PGMainMenu H_Down() { return this.__Down(this.H_ASCII()); }
        public PGMainMenu H_Up() { return this.__Up(this.H_ASCII()); }
        public bool H_Is() { return this.__Is(this.H_ASCII()); }
        //////////////////////////////////////////////////////
        //(73, "I")
        public System.String I_String() { return "I"; }
        public System.Byte I_ASCII() { return 73; }
        public PGMainMenu I() { return this; }
        public PGMainMenu I_Down() { return this.__Down(this.I_ASCII()); }
        public PGMainMenu I_Up() { return this.__Up(this.I_ASCII()); }
        public bool I_Is() { return this.__Is(this.I_ASCII()); }
        //////////////////////////////////////////////////////
        //(74, "J")
        public System.String J_String() { return "J"; }
        public System.Byte J_ASCII() { return 74; }
        public PGMainMenu J() { return this; }
        public PGMainMenu J_Down() { return this.__Down(this.J_ASCII()); }
        public PGMainMenu J_Up() { return this.__Up(this.J_ASCII()); }
        public bool J_Is() { return this.__Is(this.J_ASCII()); }
        //////////////////////////////////////////////////////
        //(75, "K")
        public System.String K_String() { return "K"; }
        public System.Byte K_ASCII() { return 75; }
        public PGMainMenu K() { return this; }
        public PGMainMenu K_Down() { return this.__Down(this.K_ASCII()); }
        public PGMainMenu K_Up() { return this.__Up(this.K_ASCII()); }
        public bool K_Is() { return this.__Is(this.K_ASCII()); }
        //////////////////////////////////////////////////////
        //(76,"L")
        public System.String L_String() { return "L"; }
        public System.Byte L_ASCII() { return 76; }
        public PGMainMenu L() { return this; }
        public PGMainMenu L_Down() { return this.__Down(this.L_ASCII()); }
        public PGMainMenu L_Up() { return this.__Up(this.L_ASCII()); }
        public bool L_Is() { return this.__Is(this.L_ASCII()); }
        //////////////////////////////////////////////////////
        //(77,"M")
        public System.String M_String() { return "M"; }
        public System.Byte M_ASCII() { return 77; }
        public PGMainMenu M() { return this; }
        public PGMainMenu M_Down() { return this.__Down(this.M_ASCII()); }
        public PGMainMenu M_Up() { return this.__Up(this.M_ASCII()); }
        public bool M_Is() { return this.__Is(this.M_ASCII()); }
        //////////////////////////////////////////////////////
        //(78,"N")
        public System.String N_String() { return "N"; }
        public System.Byte N_ASCII() { return 78; }
        public PGMainMenu N() { return this; }
        public PGMainMenu N_Down() { return this.__Down(this.N_ASCII()); }
        public PGMainMenu N_Up() { return this.__Up(this.N_ASCII()); }
        public bool N_Is() { return this.__Is(this.N_ASCII()); }
        //////////////////////////////////////////////////////
        //(79,"O")
        public System.String O_String() { return "O"; }
        public System.Byte O_ASCII() { return 79; }
        public PGMainMenu O() { return this; }
        public PGMainMenu O_Down() { return this.__Down(this.O_ASCII()); }
        public PGMainMenu O_Up() { return this.__Up(this.O_ASCII()); }
        public bool O_Is() { return this.__Is(this.O_ASCII()); }
        //////////////////////////////////////////////////////
        //(80,"P")
        public System.String P_String() { return "P"; }
        public System.Byte P_ASCII() { return 80; }
        public PGMainMenu P() { return this; }
        public PGMainMenu P_Down() { return this.__Down(this.P_ASCII()); }
        public PGMainMenu P_Up() { return this.__Up(this.P_ASCII()); }
        public bool P_Is() { return this.__Is(this.P_ASCII()); }
        //////////////////////////////////////////////////////
        //(81,"Q")
        public System.String Q_String() { return "Q"; }
        public System.Byte Q_ASCII() { return 81; }
        public PGMainMenu Q() { return this; }
        public PGMainMenu Q_Down() { return this.__Down(this.Q_ASCII()); }
        public PGMainMenu Q_Up() { return this.__Up(this.Q_ASCII()); }
        public bool Q_Is() { return this.__Is(this.Q_ASCII()); }
        //////////////////////////////////////////////////////
        //(82,"R")
        public System.String R_String() { return "R"; }
        public System.Byte R_ASCII() { return 82; }
        public PGMainMenu R() { return this; }
        public PGMainMenu R_Down() { return this.__Down(this.R_ASCII()); }
        public PGMainMenu R_Up() { return this.__Up(this.R_ASCII()); }
        public bool R_Is() { return this.__Is(this.R_ASCII()); }
        //////////////////////////////////////////////////////
        //(83,"S")
        public System.String S_String() { return "S"; }
        public System.Byte S_ASCII() { return 83; }
        public PGMainMenu S() { return this; }
        public PGMainMenu S_Down() { return this.__Down(this.S_ASCII()); }
        public PGMainMenu S_Up() { return this.__Up(this.S_ASCII()); }
        public bool S_Is() { return this.__Is(this.S_ASCII()); }
        //////////////////////////////////////////////////////
        //(84,"T")
        public System.String T_String() { return "T"; }
        public System.Byte T_ASCII() { return 84; }
        public PGMainMenu T() { return this; }
        public PGMainMenu T_Down() { return this.__Down(this.T_ASCII()); }
        public PGMainMenu T_Up() { return this.__Up(this.T_ASCII()); }
        public bool T_Is() { return this.__Is(this.T_ASCII()); }
        //////////////////////////////////////////////////////
        //(85,"U")
        public System.String U_String() { return "U"; }
        public System.Byte U_ASCII() { return 85; }
        public PGMainMenu U() { return this; }
        public PGMainMenu U_Down() { return this.__Down(this.U_ASCII()); }
        public PGMainMenu U_Up() { return this.__Up(this.U_ASCII()); }
        public bool U_Is() { return this.__Is(this.U_ASCII()); }
        //////////////////////////////////////////////////////
        //(86,"V")
        public System.String V_String() { return "V"; }
        public System.Byte V_ASCII() { return 86; }
        public PGMainMenu V() { return this; }
        public PGMainMenu V_Down() { return this.__Down(this.V_ASCII()); }
        public PGMainMenu V_Up() { return this.__Up(this.V_ASCII()); }
        public bool V_Is() { return this.__Is(this.V_ASCII()); }
        //////////////////////////////////////////////////////
        //(87,"W")
        public System.String W_String() { return "W"; }
        public System.Byte W_ASCII() { return 87; }
        public PGMainMenu W() { return this; }
        public PGMainMenu W_Down() { return this.__Down(this.W_ASCII()); }
        public PGMainMenu W_Up() { return this.__Up(this.W_ASCII()); }
        public bool W_Is() { return this.__Is(this.W_ASCII()); }
        //////////////////////////////////////////////////////
        //(88,"X")
        public System.String X_String() { return "X"; }
        public System.Byte X_ASCII() { return 88; }
        public PGMainMenu X() { return this; }
        public PGMainMenu X_Down() { return this.__Down(this.X_ASCII()); }
        public PGMainMenu X_Up() { return this.__Up(this.X_ASCII()); }
        public bool X_Is() { return this.__Is(this.X_ASCII()); }
        //////////////////////////////////////////////////////
        //(89,"Y")
        public System.String Y_String() { return "Y"; }
        public System.Byte Y_ASCII() { return 89; }
        public PGMainMenu Y() { return this; }
        public PGMainMenu Y_Down() { return this.__Down(this.Y_ASCII()); }
        public PGMainMenu Y_Up() { return this.__Up(this.Y_ASCII()); }
        public bool Y_Is() { return this.__Is(this.Y_ASCII()); }
        //////////////////////////////////////////////////////
        //(90,"Z")
        public System.String Z_String() { return "Z"; }
        public System.Byte Z_ASCII() { return 90; }
        public PGMainMenu Z() { return this; }
        public PGMainMenu Z_Down() { return this.__Down(this.Z_ASCII()); }
        public PGMainMenu Z_Up() { return this.__Up(this.Z_ASCII()); }
        public bool Z_Is() { return this.__Is(this.Z_ASCII()); }
        //////////////////////////////////////////////////////
        //(48,"_0")
        public System.String _0_String() { return "_0"; }
        public System.Byte _0_ASCII() { return 48; }
        public PGMainMenu _0() { return this; }
        public PGMainMenu _0_Down() { return this.__Down(this._0_ASCII()); }
        public PGMainMenu _0_Up() { return this.__Up(this._0_ASCII()); }
        public bool _0_Is() { return this.__Is(this._0_ASCII()); }
        //////////////////////////////////////////////////////
        //(49,"_1")
        public System.String _1_String() { return "_1"; }
        public System.Byte _1_ASCII() { return 49; }
        public PGMainMenu _1() { return this; }
        public PGMainMenu _1_Down() { return this.__Down(this._1_ASCII()); }
        public PGMainMenu _1_Up() { return this.__Up(this._1_ASCII()); }
        public bool _1_Is() { return this.__Is(this._1_ASCII()); }
        //////////////////////////////////////////////////////
        //(50,"_2")
        public System.String _2_String() { return "_2"; }
        public System.Byte _2_ASCII() { return 50; }
        public PGMainMenu _2() { return this; }
        public PGMainMenu _2_Down() { return this.__Down(this._2_ASCII()); }
        public PGMainMenu _2_Up() { return this.__Up(this._2_ASCII()); }
        public bool _2_Is() { return this.__Is(this._2_ASCII()); }
        //////////////////////////////////////////////////////
        //(51,"_3")
        public System.String _3_String() { return "_3"; }
        public System.Byte _3_ASCII() { return 51; }
        public PGMainMenu _3() { return this; }
        public PGMainMenu _3_Down() { return this.__Down(this._3_ASCII()); }
        public PGMainMenu _3_Up() { return this.__Up(this._3_ASCII()); }
        public bool _3_Is() { return this.__Is(this._3_ASCII()); }
        //////////////////////////////////////////////////////
        //(52,"_4")
        public System.String _4_String() { return "_4"; }
        public System.Byte _4_ASCII() { return 52; }
        public PGMainMenu _4() { return this; }
        public PGMainMenu _4_Down() { return this.__Down(this._4_ASCII()); }
        public PGMainMenu _4_Up() { return this.__Up(this._4_ASCII()); }
        public bool _4_Is() { return this.__Is(this._4_ASCII()); }
        //////////////////////////////////////////////////////
        //(53,"_5")
        public System.String _5_String() { return "_5"; }
        public System.Byte _5_ASCII() { return 53; }
        public PGMainMenu _5() { return this; }
        public PGMainMenu _5_Down() { return this.__Down(this._5_ASCII()); }
        public PGMainMenu _5_Up() { return this.__Up(this._5_ASCII()); }
        public bool _5_Is() { return this.__Is(this._5_ASCII()); }
        //////////////////////////////////////////////////////
        //(54,"_6")
        public System.String _6_String() { return "_6"; }
        public System.Byte _6_ASCII() { return 54; }
        public PGMainMenu _6() { return this; }
        public PGMainMenu _6_Down() { return this.__Down(this._6_ASCII()); }
        public PGMainMenu _6_Up() { return this.__Up(this._6_ASCII()); }
        public bool _6_Is() { return this.__Is(this._6_ASCII()); }
        //////////////////////////////////////////////////////
        //(55,"_7")
        public System.String _7_String() { return "_7"; }
        public System.Byte _7_ASCII() { return 55; }
        public PGMainMenu _7() { return this; }
        public PGMainMenu _7_Down() { return this.__Down(this._7_ASCII()); }
        public PGMainMenu _7_Up() { return this.__Up(this._7_ASCII()); }
        public bool _7_Is() { return this.__Is(this._7_ASCII()); }
        //////////////////////////////////////////////////////
        //(56,"_8")
        public System.String _8_String() { return "_8"; }
        public System.Byte _8_ASCII() { return 56; }
        public PGMainMenu _8() { return this; }
        public PGMainMenu _8_Down() { return this.__Down(this._8_ASCII()); }
        public PGMainMenu _8_Up() { return this.__Up(this._8_ASCII()); }
        public bool _8_Is() { return this.__Is(this._8_ASCII()); }
        //////////////////////////////////////////////////////
        //(57,"_9")
        public System.String _9_String() { return "_9"; }
        public System.Byte _9_ASCII() { return 57; }
        public PGMainMenu _9() { return this; }
        public PGMainMenu _9_Down() { return this.__Down(this._9_ASCII()); }
        public PGMainMenu _9_Up() { return this.__Up(this._9_ASCII()); }
        public bool _9_Is() { return this.__Is(this._9_ASCII()); }
        //////////////////////////////////////////////////////
        //(112,"F1")
        public System.String F1_String() { return "F1"; }
        public System.Byte F1_ASCII() { return 112; }
        public PGMainMenu F1() { return this; }
        public PGMainMenu F1_Down() { return this.__Down(this.F1_ASCII()); }
        public PGMainMenu F1_Up() { return this.__Up(this.F1_ASCII()); }
        public bool F1_Is() { return this.__Is(this.F1_ASCII()); }
        //////////////////////////////////////////////////////
        //(113,"F2")
        public System.String F2_String() { return "F2"; }
        public System.Byte F2_ASCII() { return 113; }
        public PGMainMenu F2() { return this; }
        public PGMainMenu F2_Down() { return this.__Down(this.F2_ASCII()); }
        public PGMainMenu F2_Up() { return this.__Up(this.F2_ASCII()); }
        public bool F2_Is() { return this.__Is(this.F2_ASCII()); }
        //////////////////////////////////////////////////////
        //(114,"F3")
        public System.String F3_String() { return "F3"; }
        public System.Byte F3_ASCII() { return 114; }
        public PGMainMenu F3() { return this; }
        public PGMainMenu F3_Down() { return this.__Down(this.F3_ASCII()); }
        public PGMainMenu F3_Up() { return this.__Up(this.F3_ASCII()); }
        public bool F3_Is() { return this.__Is(this.F3_ASCII()); }
        //////////////////////////////////////////////////////
        //(115,"F4")
        public System.String F4_String() { return "F4"; }
        public System.Byte F4_ASCII() { return 115; }
        public PGMainMenu F4() { return this; }
        public PGMainMenu F4_Down() { return this.__Down(this.F4_ASCII()); }
        public PGMainMenu F4_Up() { return this.__Up(this.F4_ASCII()); }
        public bool F4_Is() { return this.__Is(this.F4_ASCII()); }
        //////////////////////////////////////////////////////
        //(116,"F5")
        public System.String F5_String() { return "F5"; }
        public System.Byte F5_ASCII() { return 116; }
        public PGMainMenu F5() { return this; }
        public PGMainMenu F5_Down() { return this.__Down(this.F5_ASCII()); }
        public PGMainMenu F5_Up() { return this.__Up(this.F5_ASCII()); }
        public bool F5_Is() { return this.__Is(this.F5_ASCII()); }
        //////////////////////////////////////////////////////
        //(117,"F6")
        public System.String F6_String() { return "F6"; }
        public System.Byte F6_ASCII() { return 117; }
        public PGMainMenu F6() { return this; }
        public PGMainMenu F6_Down() { return this.__Down(this.F6_ASCII()); }
        public PGMainMenu F6_Up() { return this.__Up(this.F6_ASCII()); }
        public bool F6_Is() { return this.__Is(this.F6_ASCII()); }
        //////////////////////////////////////////////////////
        //(118,"F7")
        public System.String F7_String() { return "F7"; }
        public System.Byte F7_ASCII() { return 118; }
        public PGMainMenu F7() { return this; }
        public PGMainMenu F7_Down() { return this.__Down(this.F7_ASCII()); }
        public PGMainMenu F7_Up() { return this.__Up(this.F7_ASCII()); }
        public bool F7_Is() { return this.__Is(this.F7_ASCII()); }
        //////////////////////////////////////////////////////
        //(119,"F8")
        public System.String F8_String() { return "F8"; }
        public System.Byte F8_ASCII() { return 119; }
        public PGMainMenu F8() { return this; }
        public PGMainMenu F8_Down() { return this.__Down(this.F8_ASCII()); }
        public PGMainMenu F8_Up() { return this.__Up(this.F8_ASCII()); }
        public bool F8_Is() { return this.__Is(this.F8_ASCII()); }
        //////////////////////////////////////////////////////
        //(120,"F9")
        public System.String F9_String() { return "F9"; }
        public System.Byte F9_ASCII() { return 120; }
        public PGMainMenu F9() { return this; }
        public PGMainMenu F9_Down() { return this.__Down(this.F9_ASCII()); }
        public PGMainMenu F9_Up() { return this.__Up(this.F9_ASCII()); }
        public bool F9_Is() { return this.__Is(this.F9_ASCII()); }
        //////////////////////////////////////////////////////
        //(121,"F10")
        public System.String F10_String() { return "F10"; }
        public System.Byte F10_ASCII() { return 121; }
        public PGMainMenu F10() { return this; }
        public PGMainMenu F10_Down() { return this.__Down(this.F10_ASCII()); }
        public PGMainMenu F10_Up() { return this.__Up(this.F10_ASCII()); }
        public bool F10_Is() { return this.__Is(this.F10_ASCII()); }
        //////////////////////////////////////////////////////
        //(122,"F11")
        public System.String F11_String() { return "F11"; }
        public System.Byte F11_ASCII() { return 122; }
        public PGMainMenu F11() { return this; }
        public PGMainMenu F11_Down() { return this.__Down(this.F11_ASCII()); }
        public PGMainMenu F11_Up() { return this.__Up(this.F11_ASCII()); }
        public bool F11_Is() { return this.__Is(this.F11_ASCII()); }
        //////////////////////////////////////////////////////
        //(123,"F12")
        public System.String F12_String() { return "F12"; }
        public System.Byte F12_ASCII() { return 123; }
        public PGMainMenu F12() { return this; }
        public PGMainMenu F12_Down() { return this.__Down(this.F12_ASCII()); }
        public PGMainMenu F12_Up() { return this.__Up(this.F12_ASCII()); }
        public bool F12_Is() { return this.__Is(this.F12_ASCII()); }
        //////////////////////////////////////////////////////
        //(96,"NumZero")
        public System.String NumZero_String() { return "NumZero"; }
        public System.Byte NumZero_ASCII() { return 96; }
        public PGMainMenu NumZero() { return this; }
        public PGMainMenu NumZero_Down() { return this.__Down(this.NumZero_ASCII()); }
        public PGMainMenu NumZero_Up() { return this.__Up(this.NumZero_ASCII()); }
        public bool NumZero_Is() { return this.__Is(this.NumZero_ASCII()); }
        //////////////////////////////////////////////////////
        //(97,"NumOne")
        public System.String NumOne_String() { return "NumOne"; }
        public System.Byte NumOne_ASCII() { return 97; }
        public PGMainMenu NumOne() { return this; }
        public PGMainMenu NumOne_Down() { return this.__Down(this.NumOne_ASCII()); }
        public PGMainMenu NumOne_Up() { return this.__Up(this.NumOne_ASCII()); }
        public bool NumOne_Is() { return this.__Is(this.NumOne_ASCII()); }
        //////////////////////////////////////////////////////
        //(98,"NumTwo")
        public System.String NumTwo_String() { return "NumTwo"; }
        public System.Byte NumTwo_ASCII() { return 98; }
        public PGMainMenu NumTwo() { return this; }
        public PGMainMenu NumTwo_Down() { return this.__Down(this.NumTwo_ASCII()); }
        public PGMainMenu NumTwo_Up() { return this.__Up(this.NumTwo_ASCII()); }
        public bool NumTwo_Is() { return this.__Is(this.NumTwo_ASCII()); }
        //////////////////////////////////////////////////////
        //(99,"NumThree")
        public System.String NumThree_String() { return "NumThree"; }
        public System.Byte NumThree_ASCII() { return 99; }
        public PGMainMenu NumThree() { return this; }
        public PGMainMenu NumThree_Down() { return this.__Down(this.NumThree_ASCII()); }
        public PGMainMenu NumThree_Up() { return this.__Up(this.NumThree_ASCII()); }
        public bool NumThree_Is() { return this.__Is(this.NumThree_ASCII()); }
        //////////////////////////////////////////////////////
        //(100,"NumFor")
        public System.String NumFor_String() { return "NumFor"; }
        public System.Byte NumFor_ASCII() { return 100; }
        public PGMainMenu NumFor() { return this; }
        public PGMainMenu NumFor_Down() { return this.__Down(this.NumFor_ASCII()); }
        public PGMainMenu NumFor_Up() { return this.__Up(this.NumFor_ASCII()); }
        public bool NumFor_Is() { return this.__Is(this.NumFor_ASCII()); }
        //////////////////////////////////////////////////////
        //(101,"NumFive")
        public System.String NumFive_String() { return "NumFive"; }
        public System.Byte NumFive_ASCII() { return 101; }
        public PGMainMenu NumFive() { return this; }
        public PGMainMenu NumFive_Down() { return this.__Down(this.NumFive_ASCII()); }
        public PGMainMenu NumFive_Up() { return this.__Up(this.NumFive_ASCII()); }
        public bool NumFive_Is() { return this.__Is(this.NumFive_ASCII()); }
        //////////////////////////////////////////////////////
        //(102,"NumSix")
        public System.String NumSix_String() { return "NumSix"; }
        public System.Byte NumSix_ASCII() { return 102; }
        public PGMainMenu NumSix() { return this; }
        public PGMainMenu NumSix_Down() { return this.__Down(this.NumSix_ASCII()); }
        public PGMainMenu NumSix_Up() { return this.__Up(this.NumSix_ASCII()); }
        public bool NumSix_Is() { return this.__Is(this.NumSix_ASCII()); }
        //////////////////////////////////////////////////////
        //(103,"NumSeven")
        public System.String NumSeven_String() { return "NumSeven"; }
        public System.Byte NumSeven_ASCII() { return 103; }
        public PGMainMenu NumSeven() { return this; }
        public PGMainMenu NumSeven_Down() { return this.__Down(this.NumSeven_ASCII()); }
        public PGMainMenu NumSeven_Up() { return this.__Up(this.NumSeven_ASCII()); }
        public bool NumSeven_Is() { return this.__Is(this.NumSeven_ASCII()); }
        //////////////////////////////////////////////////////
        //(104,"NumEight")
        public System.String NumEight_String() { return "NumEight"; }
        public System.Byte NumEight_ASCII() { return 104; }
        public PGMainMenu NumEight() { return this; }
        public PGMainMenu NumEight_Down() { return this.__Down(this.NumEight_ASCII()); }
        public PGMainMenu NumEight_Up() { return this.__Up(this.NumEight_ASCII()); }
        public bool NumEight_Is() { return this.__Is(this.NumEight_ASCII()); }
        //////////////////////////////////////////////////////
        //(105,"NumNine")
        public System.String NumNine_String() { return "NumNine"; }
        public System.Byte NumNine_ASCII() { return 105; }
        public PGMainMenu NumNine() { return this; }
        public PGMainMenu NumNine_Down() { return this.__Down(this.NumNine_ASCII()); }
        public PGMainMenu NumNine_Up() { return this.__Up(this.NumNine_ASCII()); }
        public bool NumNine_Is() { return this.__Is(this.NumNine_ASCII()); }
        //////////////////////////////////////////////////////
        //(106,"NumStar")
        public System.String NumStar_String() { return "NumStar"; }
        public System.Byte NumStar_ASCII() { return 106; }
        public PGMainMenu NumStar() { return this; }
        public PGMainMenu NumStar_Down() { return this.__Down(this.NumStar_ASCII()); }
        public PGMainMenu NumStar_Up() { return this.__Up(this.NumStar_ASCII()); }
        public bool NumStar_Is() { return this.__Is(this.NumStar_ASCII()); }
        //////////////////////////////////////////////////////
        //(107,"NumPlus")
        public System.String NumPlus_String() { return "NumPlus"; }
        public System.Byte NumPlus_ASCII() { return 107; }
        public PGMainMenu NumPlus() { return this; }
        public PGMainMenu NumPlus_Down() { return this.__Down(this.NumPlus_ASCII()); }
        public PGMainMenu NumPlus_Up() { return this.__Up(this.NumPlus_ASCII()); }
        public bool NumPlus_Is() { return this.__Is(this.NumPlus_ASCII()); }
        //////////////////////////////////////////////////////
        //(109,"NumMinus")
        public System.String NumMinus_String() { return "NumMinus"; }
        public System.Byte NumMinus_ASCII() { return 109; }
        public PGMainMenu NumMinus() { return this; }
        public PGMainMenu NumMinus_Down() { return this.__Down(this.NumMinus_ASCII()); }
        public PGMainMenu NumMinus_Up() { return this.__Up(this.NumMinus_ASCII()); }
        public bool NumMinus_Is() { return this.__Is(this.NumMinus_ASCII()); }
        //////////////////////////////////////////////////////
        //(110,"NumDot")
        public System.String NumDot_String() { return "NumDot"; }
        public System.Byte NumDot_ASCII() { return 110; }
        public PGMainMenu NumDot() { return this; }
        public PGMainMenu NumDot_Down() { return this.__Down(this.NumDot_ASCII()); }
        public PGMainMenu NumDot_Up() { return this.__Up(this.NumDot_ASCII()); }
        public bool NumDot_Is() { return this.__Is(this.NumDot_ASCII()); }
        //////////////////////////////////////////////////////
        //(111,"NumSlash")
        public System.String NumSlash_String() { return "NumSlash"; }
        public System.Byte NumSlash_ASCII() { return 111; }
        public PGMainMenu NumSlash() { return this; }
        public PGMainMenu NumSlash_Down() { return this.__Down(this.NumSlash_ASCII()); }
        public PGMainMenu NumSlash_Up() { return this.__Up(this.NumSlash_ASCII()); }
        public bool NumSlash_Is() { return this.__Is(this.NumSlash_ASCII()); }
        //////////////////////////////////////////////////////
        //(144,"NUMLOCK")
        public System.String NUMLOCK_String() { return "NUMLOCK"; }
        public System.Byte NUMLOCK_ASCII() { return 144; }
        public PGMainMenu NUMLOCK() { return this; }
        public PGMainMenu NUMLOCK_Down() { return this.__Down(this.NUMLOCK_ASCII()); }
        public PGMainMenu NUMLOCK_Up() { return this.__Up(this.NUMLOCK_ASCII()); }
        public bool NUMLOCK_Is() { return this.__Is(this.NUMLOCK_ASCII()); }
        //////////////////////////////////////////////////////
        //(191,"Slash")
        public System.String Slash_String() { return "Slash"; }
        public System.Byte Slash_ASCII() { return 191; }
        public PGMainMenu Slash() { return this; }
        public PGMainMenu Slash_Down() { return this.__Down(this.Slash_ASCII()); }
        public PGMainMenu Slash_Up() { return this.__Up(this.Slash_ASCII()); }
        public bool Slash_Is() { return this.__Is(this.Slash_ASCII()); }
        //////////////////////////////////////////////////////
        //(32,"Space")
        public System.String Space_String() { return "Space"; }
        public System.Byte Space_ASCII() { return 32; }
        public PGMainMenu Space() { return this; }
        public PGMainMenu Space_Down() { return this.__Down(this.Space_ASCII()); }
        public PGMainMenu Space_Up() { return this.__Up(this.Space_ASCII()); }
        public bool Space_Is() { return this.__Is(this.Space_ASCII()); }
        //////////////////////////////////////////////////////
        //(13,"Enter")
        public System.String Enter_String() { return "Enter"; }
        public System.Byte Enter_ASCII() { return 13; }
        public PGMainMenu Enter() { return this; }
        public PGMainMenu Enter_Down() { return this.__Down(this.Enter_ASCII()); }
        public PGMainMenu Enter_Up() { return this.__Up(this.Enter_ASCII()); }
        public bool Enter_Is() { return this.__Is(this.Enter_ASCII()); }
        //////////////////////////////////////////////////////
        //(222,"Mark")
        public System.String Mark_String() { return "Mark"; }
        public System.Byte Mark_ASCII() { return 222; }
        public PGMainMenu Mark() { return this; }
        public PGMainMenu Mark_Down() { return this.__Down(this.Mark_ASCII()); }
        public PGMainMenu Mark_Up() { return this.__Up(this.Mark_ASCII()); }
        public bool Mark_Is() { return this.__Is(this.Mark_ASCII()); }
        //////////////////////////////////////////////////////
        //(16,"Shift")
        public System.String Shift_String() { return "Shift"; }
        public System.Byte Shift_ASCII() { return 16; }
        public PGMainMenu Shift() { return this; }
        public PGMainMenu Shift_Down() { return this.__Down(this.Shift_ASCII()); }
        public PGMainMenu Shift_Up() { return this.__Up(this.Shift_ASCII()); }
        public bool Shift_Is() { return this.__Is(this.Shift_ASCII()); }
        //////////////////////////////////////////////////////
        //(8,"BACKSPACE")
        public System.String BACKSPACE_String() { return "BACKSPACE"; }
        public System.Byte BACKSPACE_ASCII() { return 8; }
        public PGMainMenu BACKSPACE() { return this; }
        public PGMainMenu BACKSPACE_Down() { return this.__Down(this.BACKSPACE_ASCII()); }
        public PGMainMenu BACKSPACE_Up() { return this.__Up(this.BACKSPACE_ASCII()); }
        public bool BACKSPACE_Is() { return this.__Is(this.BACKSPACE_ASCII()); }
        //////////////////////////////////////////////////////
        //(9,"TAB")
        public System.String TAB_String() { return "TAB"; }
        public System.Byte TAB_ASCII() { return 9; }
        public PGMainMenu TAB() { return this; }
        public PGMainMenu TAB_Down() { return this.__Down(this.TAB_ASCII()); }
        public PGMainMenu TAB_Up() { return this.__Up(this.TAB_ASCII()); }
        public bool TAB_Is() { return this.__Is(this.TAB_ASCII()); }
        //////////////////////////////////////////////////////
        //(17,"CTRL")
        public System.String CTRL_String() { return "CTRL"; }
        public System.Byte CTRL_ASCII() { return 17; }
        public PGMainMenu CTRL() { return this; }
        public PGMainMenu CTRL_Down() { return this.__Down(this.CTRL_ASCII()); }
        public PGMainMenu CTRL_Up() { return this.__Up(this.CTRL_ASCII()); }
        public bool CTRL_Is() { return this.__Is(this.CTRL_ASCII()); }
        //////////////////////////////////////////////////////
        //(18,"ALT")
        public System.String ALT_String() { return "ALT"; }
        public System.Byte ALT_ASCII() { return 18; }
        public PGMainMenu ALT() { return this; }
        public PGMainMenu ALT_Down() { return this.__Down(this.ALT_ASCII()); }
        public PGMainMenu ALT_Up() { return this.__Up(this.ALT_ASCII()); }
        public bool ALT_Is() { return this.__Is(this.ALT_ASCII()); }
        //////////////////////////////////////////////////////
        //(19,"PAUSE")
        public System.String PAUSE_String() { return "PAUSE"; }
        public System.Byte PAUSE_ASCII() { return 19; }
        public PGMainMenu PAUSE() { return this; }
        public PGMainMenu PAUSE_Down() { return this.__Down(this.PAUSE_ASCII()); }
        public PGMainMenu PAUSE_Up() { return this.__Up(this.PAUSE_ASCII()); }
        public bool PAUSE_Is() { return this.__Is(this.PAUSE_ASCII()); }
        //////////////////////////////////////////////////////
        //(20,"CAPSLOCK")
        public System.String CAPSLOCK_String() { return "CAPSLOCK"; }
        public System.Byte CAPSLOCK_ASCII() { return 20; }
        public PGMainMenu CAPSLOCK() { return this; }
        public PGMainMenu CAPSLOCK_Down() { return this.__Down(this.CAPSLOCK_ASCII()); }
        public PGMainMenu CAPSLOCK_Up() { return this.__Up(this.CAPSLOCK_ASCII()); }
        public bool CAPSLOCK_Is() { return this.__Is(this.CAPSLOCK_ASCII()); }
        //////////////////////////////////////////////////////
        //(27,"ESCAPE")
        public System.String ESCAPE_String() { return "ESCAPE"; }
        public System.Byte ESCAPE_ASCII() { return 27; }
        public PGMainMenu ESCAPE() { return this; }
        public PGMainMenu ESCAPE_Down() { return this.__Down(this.ESCAPE_ASCII()); }
        public PGMainMenu ESCAPE_Up() { return this.__Up(this.ESCAPE_ASCII()); }
        public bool ESCAPE_Is() { return this.__Is(this.ESCAPE_ASCII()); }
        //////////////////////////////////////////////////////
        //(33,"PAGEUP")
        public System.String PAGEUP_String() { return "PAGEUP"; }
        public System.Byte PAGEUP_ASCII() { return 33; }
        public PGMainMenu PAGEUP() { return this; }
        public PGMainMenu PAGEUP_Down() { return this.__Down(this.PAGEUP_ASCII()); }
        public PGMainMenu PAGEUP_Up() { return this.__Up(this.PAGEUP_ASCII()); }
        public bool PAGEUP_Is() { return this.__Is(this.PAGEUP_ASCII()); }
        //////////////////////////////////////////////////////
        //(34,"PAGEDOWN")
        public System.String PAGEDOWN_String() { return "PAGEDOWN"; }
        public System.Byte PAGEDOWN_ASCII() { return 34; }
        public PGMainMenu PAGEDOWN() { return this; }
        public PGMainMenu PAGEDOWN_Down() { return this.__Down(this.PAGEDOWN_ASCII()); }
        public PGMainMenu PAGEDOWN_Up() { return this.__Up(this.PAGEDOWN_ASCII()); }
        public bool PAGEDOWN_Is() { return this.__Is(this.PAGEDOWN_ASCII()); }
        //////////////////////////////////////////////////////
        //(35,"END")
        public System.String END_String() { return "END"; }
        public System.Byte END_ASCII() { return 35; }
        public PGMainMenu END() { return this; }
        public PGMainMenu END_Down() { return this.__Down(this.END_ASCII()); }
        public PGMainMenu END_Up() { return this.__Up(this.END_ASCII()); }
        public bool END_Is() { return this.__Is(this.END_ASCII()); }
        //////////////////////////////////////////////////////
        //(36,"HOME")
        public System.String HOME_String() { return "HOME"; }
        public System.Byte HOME_ASCII() { return 36; }
        public PGMainMenu HOME() { return this; }
        public PGMainMenu HOME_Down() { return this.__Down(this.HOME_ASCII()); }
        public PGMainMenu HOME_Up() { return this.__Up(this.HOME_ASCII()); }
        public bool HOME_Is() { return this.__Is(this.HOME_ASCII()); }
        //////////////////////////////////////////////////////
        //(37,"LEFT")
        public System.String LEFT_String() { return "LEFT"; }
        public System.Byte LEFT_ASCII() { return 37; }
        public PGMainMenu LEFT() { return this; }
        public PGMainMenu LEFT_Down() { return this.__Down(this.LEFT_ASCII()); }
        public PGMainMenu LEFT_Up() { return this.__Up(this.LEFT_ASCII()); }
        public bool LEFT_Is() { return this.__Is(this.LEFT_ASCII()); }
        //////////////////////////////////////////////////////
        //(38,"UP")
        public System.String UP_String() { return "UP"; }
        public System.Byte UP_ASCII() { return 38; }
        public PGMainMenu UP() { return this; }
        public PGMainMenu UP_Down() { return this.__Down(this.UP_ASCII()); }
        public PGMainMenu UP_Up() { return this.__Up(this.UP_ASCII()); }
        public bool UP_Is() { return this.__Is(this.UP_ASCII()); }
        //////////////////////////////////////////////////////
        //(39,"RIGHT")
        public System.String RIGHT_String() { return "RIGHT"; }
        public System.Byte RIGHT_ASCII() { return 39; }
        public PGMainMenu RIGHT() { return this; }
        public PGMainMenu RIGHT_Down() { return this.__Down(this.RIGHT_ASCII()); }
        public PGMainMenu RIGHT_Up() { return this.__Up(this.RIGHT_ASCII()); }
        public bool RIGHT_Is() { return this.__Is(this.RIGHT_ASCII()); }
        //////////////////////////////////////////////////////
        //(40,"DOWN")
        public System.String DOWN_String() { return "DOWN"; }
        public System.Byte DOWN_ASCII() { return 40; }
        public PGMainMenu DOWN() { return this; }
        public PGMainMenu DOWN_Down() { return this.__Down(this.DOWN_ASCII()); }
        public PGMainMenu DOWN_Up() { return this.__Up(this.DOWN_ASCII()); }
        public bool DOWN_Is() { return this.__Is(this.DOWN_ASCII()); }
        //////////////////////////////////////////////////////
        //(45,"INSERT")
        public System.String INSERT_String() { return "INSERT"; }
        public System.Byte INSERT_ASCII() { return 45; }
        public PGMainMenu INSERT() { return this; }
        public PGMainMenu INSERT_Down() { return this.__Down(this.INSERT_ASCII()); }
        public PGMainMenu INSERT_Up() { return this.__Up(this.INSERT_ASCII()); }
        public bool INSERT_Is() { return this.__Is(this.INSERT_ASCII()); }
        //////////////////////////////////////////////////////
        //(46,"DELETE")
        public System.String DELETE_String() { return "DELETE"; }
        public System.Byte DELETE_ASCII() { return 46; }
        public PGMainMenu DELETE() { return this; }
        public PGMainMenu DELETE_Down() { return this.__Down(this.DELETE_ASCII()); }
        public PGMainMenu DELETE_Up() { return this.__Up(this.DELETE_ASCII()); }
        public bool DELETE_Is() { return this.__Is(this.DELETE_ASCII()); }
        //////////////////////////////////////////////////////
        //(91,"LWIN")
        public System.String LWIN_String() { return "LWIN"; }
        public System.Byte LWIN_ASCII() { return 91; }
        public PGMainMenu LWIN() { return this; }
        public PGMainMenu LWIN_Down() { return this.__Down(this.LWIN_ASCII()); }
        public PGMainMenu LWIN_Up() { return this.__Up(this.LWIN_ASCII()); }
        public bool LWIN_Is() { return this.__Is(this.LWIN_ASCII()); }
        //////////////////////////////////////////////////////
        //(92,"RWIN")
        public System.String RWIN_String() { return "RWIN"; }
        public System.Byte RWIN_ASCII() { return 92; }
        public PGMainMenu RWIN() { return this; }
        public PGMainMenu RWIN_Down() { return this.__Down(this.RWIN_ASCII()); }
        public PGMainMenu RWIN_Up() { return this.__Up(this.RWIN_ASCII()); }
        public bool RWIN_Is() { return this.__Is(this.RWIN_ASCII()); }
        //////////////////////////////////////////////////////
        //(145,"SCROLLLOCK")
        public System.String SCROLLLOCK_String() { return "SCROLLLOCK"; }
        public System.Byte SCROLLLOCK_ASCII() { return 145; }
        public PGMainMenu SCROLLLOCK() { return this; }
        public PGMainMenu SCROLLLOCK_Down() { return this.__Down(this.SCROLLLOCK_ASCII()); }
        public PGMainMenu SCROLLLOCK_Up() { return this.__Up(this.SCROLLLOCK_ASCII()); }
        public bool SCROLLLOCK_Is() { return this.__Is(this.SCROLLLOCK_ASCII()); }
        //////////////////////////////////////////////////////
        //(154,"PRINTSCREEN")
        public System.String PRINTSCREEN_String() { return "PRINTSCREEN"; }
        public System.Byte PRINTSCREEN_ASCII() { return 154; }
        public PGMainMenu PRINTSCREEN() { return this; }
        public PGMainMenu PRINTSCREEN_Down() { return this.__Down(this.PRINTSCREEN_ASCII()); }
        public PGMainMenu PRINTSCREEN_Up() { return this.__Up(this.PRINTSCREEN_ASCII()); }
        public bool PRINTSCREEN_Is() { return this.__Is(this.PRINTSCREEN_ASCII()); }
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
        private void Button_Click(object sender, RoutedEventArgs e){}
        private void btn_StopRec_Click(object sender, RoutedEventArgs e){}
        async private void btn_StartWork_Click(object sender, RoutedEventArgs e){}
        #region Переход на страницу настроек
        private void btn_Setings_Click(object sender, RoutedEventArgs e)
        {NavigationService.Navigate(new PGSetings());}
        private void Btn62_Click(object sender, RoutedEventArgs e){ }
        #endregion
        private void btn_AllDel_Click(object sender, RoutedEventArgs e){}
        private void btn_Read_Click(object sender, RoutedEventArgs e){}
        private void MouseBtnLeft_Click(object sender, RoutedEventArgs e){}
        async private void btn_Test_Click(object sender, RoutedEventArgs e){}

        private void Button_Click_1(object sender, RoutedEventArgs e){}
        private void Button_Click_2(object sender, RoutedEventArgs e){}
        private void Btn64_Click(object sender, RoutedEventArgs e){}
        private void Btn11_Click(object sender, RoutedEventArgs e) { }
        private void Btn12_Click(object sender, RoutedEventArgs e) { }
        private void Btn13_Click(object sender, RoutedEventArgs e) { }
        private void Btn14_Click(object sender, RoutedEventArgs e) { }
        private void Btn15_Click(object sender, RoutedEventArgs e) { }
        private void Btn16_Click(object sender, RoutedEventArgs e) { }
        private void Btn17_Click(object sender, RoutedEventArgs e) { }
        private void Btn18_Click(object sender, RoutedEventArgs e) { }
        private void Btn19_Click(object sender, RoutedEventArgs e) { }
        private void Btn110_Click(object sender, RoutedEventArgs e) { }
        private void Btn111_Click(object sender, RoutedEventArgs e) { }
        private void Btn112_Click(object sender, RoutedEventArgs e) { }
        private void Btn113_Click(object sender, RoutedEventArgs e) { }
        private void Btn114_Click(object sender, RoutedEventArgs e) { }
        private void Btn115_Click(object sender, RoutedEventArgs e) { }
        private void Btn116_Click(object sender, RoutedEventArgs e) { }
        private void Btn21_Click(object sender, RoutedEventArgs e) { }
        private void Btn22_Click(object sender, RoutedEventArgs e) { }
        private void Btn23_Click(object sender, RoutedEventArgs e) { }
        private void Btn24_Click(object sender, RoutedEventArgs e) { }
        private void Btn25_Click(object sender, RoutedEventArgs e) {}
        private void Btn26_Click(object sender, RoutedEventArgs e) {}
        private void Btn27_Click(object sender, RoutedEventArgs e){}
        private void Btn28_Click(object sender, RoutedEventArgs e){}
        private void Btn29_Click(object sender, RoutedEventArgs e){}
        private void Btn210_Click(object sender, RoutedEventArgs e){}
        private void Btn211_Click(object sender, RoutedEventArgs e){}
        private void Btn212_Click(object sender, RoutedEventArgs e){}
        private void Btn213_Click(object sender, RoutedEventArgs e){}
        private void Btn214_Click(object sender, RoutedEventArgs e){}
        private void Btn215_Click(object sender, RoutedEventArgs e){}
        private void Btn216_Click(object sender, RoutedEventArgs e){}
        private void Btn217_Click(object sender, RoutedEventArgs e){}
        private void Btn218_Click(object sender, RoutedEventArgs e){}
        private void Btn219_Click(object sender, RoutedEventArgs e){}
        private void Btn220_Click(object sender, RoutedEventArgs e){}
        private void Btn221_Click(object sender, RoutedEventArgs e){}
        private void Btn31_Click(object sender, RoutedEventArgs e) { }
        private void Btn32_Click(object sender, RoutedEventArgs e) { }
        private void Btn33_Click(object sender, RoutedEventArgs e) { }
        private void Btn34_Click(object sender, RoutedEventArgs e) { }
        private void Btn35_Click(object sender, RoutedEventArgs e) { }
        private void Btn36_Click(object sender, RoutedEventArgs e) { }
        private void Btn37_Click(object sender, RoutedEventArgs e) { }
        private void Btn38_Click(object sender, RoutedEventArgs e) { }
        private void Btn39_Click(object sender, RoutedEventArgs e) { }
        private void Btn310_Click(object sender, RoutedEventArgs e) { }
        private void Btn311_Click(object sender, RoutedEventArgs e) { }
        private void Btn312_Click(object sender, RoutedEventArgs e) { }
        private void Btn313_Click(object sender, RoutedEventArgs e) { }
        private void Btn314_Click(object sender, RoutedEventArgs e) { }
        private void Btn315_Click(object sender, RoutedEventArgs e) { }
        private void Btn316_Click(object sender, RoutedEventArgs e) { }
        private void Btn317_Click(object sender, RoutedEventArgs e) { }
        private void Btn318_Click(object sender, RoutedEventArgs e) { }
        private void Btn319_Click(object sender, RoutedEventArgs e) { }
        private void Btn320_Click(object sender, RoutedEventArgs e) { }
        private void Btn321_Click(object sender, RoutedEventArgs e) { }
        private void Btn41_Click(object sender, RoutedEventArgs e) { }
        private void Btn42_Click(object sender, RoutedEventArgs e) { }
        private void Btn43_Click(object sender, RoutedEventArgs e) { }
        private void Btn44_Click(object sender, RoutedEventArgs e) { }
        private void Btn45_Click(object sender, RoutedEventArgs e) { }
        private void Btn46_Click(object sender, RoutedEventArgs e) { }
        private void Btn47_Click(object sender, RoutedEventArgs e) { }
        private void Btn48_Click(object sender, RoutedEventArgs e) { }
        private void Btn49_Click(object sender, RoutedEventArgs e) { }
        private void Btn410_Click(object sender, RoutedEventArgs e) { }
        private void Btn411_Click(object sender, RoutedEventArgs e) { }
        private void Btn412_Click(object sender, RoutedEventArgs e) { }
        private void Btn413_Click(object sender, RoutedEventArgs e) { }
        private void Btn414_Click(object sender, RoutedEventArgs e) { }
        private void Btn415_Click(object sender, RoutedEventArgs e) { }
        private void Btn416_Click(object sender, RoutedEventArgs e) { }
        private void Btn51_Click(object sender, RoutedEventArgs e){}
        private void Btn52_Click(object sender, RoutedEventArgs e){}
        private void Btn53_Click(object sender, RoutedEventArgs e){}
        private void Btn54_Click(object sender, RoutedEventArgs e){}
        private void Btn55_Click(object sender, RoutedEventArgs e){}
        private void Btn56_Click(object sender, RoutedEventArgs e){}
        private void Btn57_Click(object sender, RoutedEventArgs e){}
        private void Btn58_Click(object sender, RoutedEventArgs e){}
        private void Btn59_Click(object sender, RoutedEventArgs e){}
        private void Btn510_Click(object sender, RoutedEventArgs e){}
        private void Btn511_Click(object sender, RoutedEventArgs e){}
        private void Btn512_Click(object sender, RoutedEventArgs e){}
        private void Btn513_Click(object sender, RoutedEventArgs e){}
        private void Btn514_Click(object sender, RoutedEventArgs e){}
        private void Btn515_Click(object sender, RoutedEventArgs e){}
        private void Btn516_Click(object sender, RoutedEventArgs e){}
        private void Btn517_Click(object sender, RoutedEventArgs e){}
        private void Btn61_Click(object sender, RoutedEventArgs e){}
        private void Btn63_Click(object sender, RoutedEventArgs e){}
        private void Btn65_Click(object sender, RoutedEventArgs e){}
        private void Btn66_Click(object sender, RoutedEventArgs e){}
        private void Btn67_Click(object sender, RoutedEventArgs e){}
        private void Btn68_Click(object sender, RoutedEventArgs e){}
        private void Btn69_Click(object sender, RoutedEventArgs e){}
        private void Btn610_Click(object sender, RoutedEventArgs e){}
        private void Btn611_Click(object sender, RoutedEventArgs e){}
        private void Btn612_Click(object sender, RoutedEventArgs e){}
    }
}