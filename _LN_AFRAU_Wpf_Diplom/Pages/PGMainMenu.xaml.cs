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
        }
        //////////////////////////////////////////////////////
        public PGMainMenu _Down(byte _bVk) { keybd_event(_bVk, 0, 0, 0); return this; }
        public PGMainMenu _Up(byte _bVk) { keybd_event(_bVk, 0, 2, 0); return this; }
        public System.Boolean _Is(byte _bVk) { switch (GetKeyState(_bVk)){ case -127: case -128: return true; break;default: return false; break;} return false; }
        //////////////////////////////////////////////////////
        #region (65, "A")
        public System.String A_String() { return "A"; }
        public System.Byte A_ASCII() { return 65; }
        public PGMainMenu A() { return this; }
        public PGMainMenu A_Down() { return this._Down(this.A_ASCII()); }
        public PGMainMenu A_Up() { return this._Up(this.A_ASCII()); }
        public bool A_Is() { return this._Is(this.A_ASCII()); }
        # endregion
        //////////////////////////////////////////////////////
        //(66, "B")
        public System.String B_String() { return "B"; }
        public System.Byte B_ASCII() { return 66; }
        public PGMainMenu B() { return this; }
        public PGMainMenu B_Down() { return this._Down(this.B_ASCII()); }
        public PGMainMenu B_Up() { return this._Up(this.B_ASCII()); }
        public bool B_Is() { return this._Is(this.B_ASCII()); }
        //////////////////////////////////////////////////////
        //(67, "C")
        public System.String C_String() { return "C"; }
        public System.Byte C_ASCII() { return 67; }
        public PGMainMenu C() { return this; }
        public PGMainMenu C_Down() { return this._Down(this.C_ASCII()); }
        public PGMainMenu C_Up() { return this._Up(this.C_ASCII()); }
        public bool C_Is() { return this._Is(this.C_ASCII()); }
        //////////////////////////////////////////////////////
        //(68, "D")
        public System.String D_String() { return "D"; }
        public System.Byte D_ASCII() { return 68; }
        public PGMainMenu D() { return this; }
        public PGMainMenu D_Down() { return this._Down(this.D_ASCII()); }
        public PGMainMenu D_Up() { return this._Up(this.D_ASCII()); }
        public bool D_Is() { return this._Is(this.D_ASCII()); }
        //////////////////////////////////////////////////////
        //(69, "E")
        public System.String E_String() { return "E"; }
        public System.Byte E_ASCII() { return 69; }
        public PGMainMenu E() { return this; }
        public PGMainMenu E_Down() { return this._Down(this.E_ASCII()); }
        public PGMainMenu E_Up() { return this._Up(this.E_ASCII()); }
        public bool E_Is() { return this._Is(this.E_ASCII()); }
        //////////////////////////////////////////////////////
        //(70, "F")
        public System.String F_String() { return "F"; }
        public System.Byte F_ASCII() { return 70; }
        public PGMainMenu F() { return this; }
        public PGMainMenu F_Down() { return this._Down(this.F_ASCII()); }
        public PGMainMenu F_Up() { return this._Up(this.F_ASCII()); }
        public bool F_Is() { return this._Is(this.F_ASCII()); }
        //////////////////////////////////////////////////////
        //(71, "G")
        public System.String G_String() { return "G"; }
        public System.Byte G_ASCII() { return 71; }
        public PGMainMenu G() { return this; }
        public PGMainMenu G_Down() { return this._Down(this.G_ASCII()); }
        public PGMainMenu G_Up() { return this._Up(this.G_ASCII()); }
        public bool G_Is() { return this._Is(this.G_ASCII()); }
        //////////////////////////////////////////////////////
        //(72, "H")
        public System.String H_String() { return "H"; }
        public System.Byte H_ASCII() { return 72; }
        public PGMainMenu H() { return this; }
        public PGMainMenu H_Down() { return this._Down(this.H_ASCII()); }
        public PGMainMenu H_Up() { return this._Up(this.H_ASCII()); }
        public bool H_Is() { return this._Is(this.H_ASCII()); }
        //////////////////////////////////////////////////////
        //(73, "I")
        public System.String I_String() { return "I"; }
        public System.Byte I_ASCII() { return 73; }
        public PGMainMenu I() { return this; }
        public PGMainMenu I_Down() { return this._Down(this.I_ASCII()); }
        public PGMainMenu I_Up() { return this._Up(this.I_ASCII()); }
        public bool I_Is() { return this._Is(this.I_ASCII()); }
        //////////////////////////////////////////////////////
        //(74, "J")
        public System.String J_String() { return "J"; }
        public System.Byte J_ASCII() { return 74; }
        public PGMainMenu J() { return this; }
        public PGMainMenu J_Down() { return this._Down(this.J_ASCII()); }
        public PGMainMenu J_Up() { return this._Up(this.J_ASCII()); }
        public bool J_Is() { return this._Is(this.J_ASCII()); }
        //////////////////////////////////////////////////////
        //(75, "K")
        public System.String K_String() { return "K"; }
        public System.Byte K_ASCII() { return 75; }
        public PGMainMenu K() { return this; }
        public PGMainMenu K_Down() { return this._Down(this.K_ASCII()); }
        public PGMainMenu K_Up() { return this._Up(this.K_ASCII()); }
        public bool K_Is() { return this._Is(this.K_ASCII()); }
        //////////////////////////////////////////////////////
        //(76,"L")
        public System.String L_String() { return "L"; }
        public System.Byte L_ASCII() { return 76; }
        public PGMainMenu L() { return this; }
        public PGMainMenu L_Down() { return this._Down(this.L_ASCII()); }
        public PGMainMenu L_Up() { return this._Up(this.L_ASCII()); }
        public bool L_Is() { return this._Is(this.L_ASCII()); }
        //////////////////////////////////////////////////////
        //(77,"M")
        public System.String M_String() { return "M"; }
        public System.Byte M_ASCII() { return 77; }
        public PGMainMenu M() { return this; }
        public PGMainMenu M_Down() { return this._Down(this.M_ASCII()); }
        public PGMainMenu M_Up() { return this._Up(this.M_ASCII()); }
        public bool M_Is() { return this._Is(this.M_ASCII()); }
        //////////////////////////////////////////////////////
        //(78,"N")
        public System.String N_String() { return "N"; }
        public System.Byte N_ASCII() { return 78; }
        public PGMainMenu N() { return this; }
        public PGMainMenu N_Down() { return this._Down(this.N_ASCII()); }
        public PGMainMenu N_Up() { return this._Up(this.N_ASCII()); }
        public bool N_Is() { return this._Is(this.N_ASCII()); }
        //////////////////////////////////////////////////////
        //(79,"O")
        public System.String O_String() { return "O"; }
        public System.Byte O_ASCII() { return 79; }
        public PGMainMenu O() { return this; }
        public PGMainMenu O_Down() { return this._Down(this.O_ASCII()); }
        public PGMainMenu O_Up() { return this._Up(this.O_ASCII()); }
        public bool O_Is() { return this._Is(this.O_ASCII()); }
        //////////////////////////////////////////////////////
        //(80,"P")
        public System.String P_String() { return "P"; }
        public System.Byte P_ASCII() { return 80; }
        public PGMainMenu P() { return this; }
        public PGMainMenu P_Down() { return this._Down(this.P_ASCII()); }
        public PGMainMenu P_Up() { return this._Up(this.P_ASCII()); }
        public bool P_Is() { return this._Is(this.P_ASCII()); }
        //////////////////////////////////////////////////////
        //(81,"Q")
        public System.String Q_String() { return "Q"; }
        public System.Byte Q_ASCII() { return 81; }
        public PGMainMenu Q() { return this; }
        public PGMainMenu Q_Down() { return this._Down(this.Q_ASCII()); }
        public PGMainMenu Q_Up() { return this._Up(this.Q_ASCII()); }
        public bool Q_Is() { return this._Is(this.Q_ASCII()); }
        //////////////////////////////////////////////////////
        //(82,"R")
        public System.String R_String() { return "R"; }
        public System.Byte R_ASCII() { return 82; }
        public PGMainMenu R() { return this; }
        public PGMainMenu R_Down() { return this._Down(this.R_ASCII()); }
        public PGMainMenu R_Up() { return this._Up(this.R_ASCII()); }
        public bool R_Is() { return this._Is(this.R_ASCII()); }
        //////////////////////////////////////////////////////
        //(83,"S")
        public System.String S_String() { return "S"; }
        public System.Byte S_ASCII() { return 83; }
        public PGMainMenu S() { return this; }
        public PGMainMenu S_Down() { return this._Down(this.S_ASCII()); }
        public PGMainMenu S_Up() { return this._Up(this.S_ASCII()); }
        public bool S_Is() { return this._Is(this.S_ASCII()); }
        //////////////////////////////////////////////////////
        //(84,"T")
        public System.String T_String() { return "T"; }
        public System.Byte T_ASCII() { return 84; }
        public PGMainMenu T() { return this; }
        public PGMainMenu T_Down() { return this._Down(this.T_ASCII()); }
        public PGMainMenu T_Up() { return this._Up(this.T_ASCII()); }
        public bool T_Is() { return this._Is(this.T_ASCII()); }
        //////////////////////////////////////////////////////
        //(85,"U")
        public System.String U_String() { return "U"; }
        public System.Byte U_ASCII() { return 85; }
        public PGMainMenu U() { return this; }
        public PGMainMenu U_Down() { return this._Down(this.U_ASCII()); }
        public PGMainMenu U_Up() { return this._Up(this.U_ASCII()); }
        public bool U_Is() { return this._Is(this.U_ASCII()); }
        //////////////////////////////////////////////////////
        //(86,"V")
        public System.String V_String() { return "V"; }
        public System.Byte V_ASCII() { return 86; }
        public PGMainMenu V() { return this; }
        public PGMainMenu V_Down() { return this._Down(this.V_ASCII()); }
        public PGMainMenu V_Up() { return this._Up(this.V_ASCII()); }
        public bool V_Is() { return this._Is(this.V_ASCII()); }
        //////////////////////////////////////////////////////
        //(87,"W")
        public System.String W_String() { return "W"; }
        public System.Byte W_ASCII() { return 87; }
        public PGMainMenu W() { return this; }
        public PGMainMenu W_Down() { return this._Down(this.W_ASCII()); }
        public PGMainMenu W_Up() { return this._Up(this.W_ASCII()); }
        public bool W_Is() { return this._Is(this.W_ASCII()); }
        //////////////////////////////////////////////////////

        (88,"X")
            //(73, "I")
        public System.String I_String() { return "I"; }
        public System.Byte I_ASCII() { return 73; }
        public PGMainMenu I() { return this; }
        public PGMainMenu I_Down() { return this._Down(this.I_ASCII()); }
        public PGMainMenu I_Up() { return this._Up(this.I_ASCII()); }
        public bool I_Is() { return this._Is(this.I_ASCII()); }
        //////////////////////////////////////////////////////

        (89,"Y")
            //(73, "I")
        public System.String I_String() { return "I"; }
        public System.Byte I_ASCII() { return 73; }
        public PGMainMenu I() { return this; }
        public PGMainMenu I_Down() { return this._Down(this.I_ASCII()); }
        public PGMainMenu I_Up() { return this._Up(this.I_ASCII()); }
        public bool I_Is() { return this._Is(this.I_ASCII()); }
        //////////////////////////////////////////////////////

        (90,"Z")
            //(73, "I")
        public System.String I_String() { return "I"; }
        public System.Byte I_ASCII() { return 73; }
        public PGMainMenu I() { return this; }
        public PGMainMenu I_Down() { return this._Down(this.I_ASCII()); }
        public PGMainMenu I_Up() { return this._Up(this.I_ASCII()); }
        public bool I_Is() { return this._Is(this.I_ASCII()); }
        //////////////////////////////////////////////////////

        //_0-_9
        (48,"_0")(49,"_1")(50,"_2")(51,"_3")(52,"_4")(53,"_5")(54,"_6")(55,"_7")(56,"_8")(57,"_9")
            //F1-F12
                (112,"F1")(113,"F2")(114,"F3")(115,"F4")(116,"F5")(117,"F6")(118,"F7")(119,"F8")(120,"F9")(121,"F10")(122,"F11")(123,"F12")
            //Num ...
                (96,"NumZero")(97,"NumOne")(98,"NumTwo")(99,"NumThree")(100,"NumFor")(101,"NumFive")(102,"NumSix")(103,"NumSeven")
                (104,"NumEight")(105,"NumNine")(106,"NumStar")(107,"NumPlus")(109,"NumMinus")(110,"NumDot")(111,"NumSlash")(144,"NUMLOCK")
            //...
                (191,"Slash")(32,"Space")(13,"Enter")(222,"Mark")(16,"Shift")(8,"BACKSPACE")(9,"TAB")(17,"CTRL")
                (18,"ALT")(19,"PAUSE")(20,"CAPSLOCK")(27,"ESCAPE")(33,"PAGEUP")(34,"PAGEDOWN")(35,"END")(36,"HOME")
                (37,"LEFT")(38,"UP")(39,"RIGHT")(40,"DOWN")(45,"INSERT")(46,"DELETE")(91,"LWIN")(92,"RWIN")
                (145,"SCROLLLOCK")(154,"PRINTSCREEN")(186,"PeriodComma")(187,"Equally")(188,"Сomma")(189,"Minus")(190,"Dot")
                (192,"Tilda")(219,"SquScobOtk")(220,"ObratSlash")(221,"SquScobZak")(1,"MouseL")(2,"MouseR")(4,"MMouse")
        //(65, "A")
        //Опустить
        // поднять 
        // проверить
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
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
        }

        private void Btn64_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
