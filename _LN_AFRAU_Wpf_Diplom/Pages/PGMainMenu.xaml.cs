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
        //////////////////////////////////////////////////////
        //(96,"NumZero")
        public System.String NumZero_String() { return "NumZero"; }
        public System.Byte NumZero_ASCII() { return 96; }
        public PGMainMenu NumZero() { return this; }
        public PGMainMenu NumZero_Down() { return this.__Down(this.NumZero_ASCII()); }
        public PGMainMenu NumZero_Up() { return this.__Up(this.NumZero_ASCII()); }
        public bool NumZero_Is() { return this.__Is(this.NumZero_ASCII()); }
        private void Btn611_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn611_Click"); }
        //////////////////////////////////////////////////////
        //(97,"NumOne")
        public System.String NumOne_String() { return "NumOne"; }
        public System.Byte NumOne_ASCII() { return 97; }
        public PGMainMenu NumOne() { return this; }
        public PGMainMenu NumOne_Down() { return this.__Down(this.NumOne_ASCII()); }
        public PGMainMenu NumOne_Up() { return this.__Up(this.NumOne_ASCII()); }
        public bool NumOne_Is() { return this.__Is(this.NumOne_ASCII()); }
        private void Btn514_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn514_Click"); }
        //////////////////////////////////////////////////////
        //(98,"NumTwo")
        public System.String NumTwo_String() { return "NumTwo"; }
        public System.Byte NumTwo_ASCII() { return 98; }
        public PGMainMenu NumTwo() { return this; }
        public PGMainMenu NumTwo_Down() { return this.__Down(this.NumTwo_ASCII()); }
        public PGMainMenu NumTwo_Up() { return this.__Up(this.NumTwo_ASCII()); }
        public bool NumTwo_Is() { return this.__Is(this.NumTwo_ASCII()); }
        private void Btn515_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn515_Click"); }
        //////////////////////////////////////////////////////
        //(99,"NumThree")
        public System.String NumThree_String() { return "NumThree"; }
        public System.Byte NumThree_ASCII() { return 99; }
        public PGMainMenu NumThree() { return this; }
        public PGMainMenu NumThree_Down() { return this.__Down(this.NumThree_ASCII()); }
        public PGMainMenu NumThree_Up() { return this.__Up(this.NumThree_ASCII()); }
        public bool NumThree_Is() { return this.__Is(this.NumThree_ASCII()); }
        private void Btn516_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn516_Click"); }
        //////////////////////////////////////////////////////
        //(100,"NumFor")
        public System.String NumFor_String() { return "NumFor"; }
        public System.Byte NumFor_ASCII() { return 100; }
        public PGMainMenu NumFor() { return this; }
        public PGMainMenu NumFor_Down() { return this.__Down(this.NumFor_ASCII()); }
        public PGMainMenu NumFor_Up() { return this.__Up(this.NumFor_ASCII()); }
        public bool NumFor_Is() { return this.__Is(this.NumFor_ASCII()); }
        private void Btn414_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn414_Click"); }
        //////////////////////////////////////////////////////
        //(101,"NumFive")
        public System.String NumFive_String() { return "NumFive"; }
        public System.Byte NumFive_ASCII() { return 101; }
        public PGMainMenu NumFive() { return this; }
        public PGMainMenu NumFive_Down() { return this.__Down(this.NumFive_ASCII()); }
        public PGMainMenu NumFive_Up() { return this.__Up(this.NumFive_ASCII()); }
        public bool NumFive_Is() { return this.__Is(this.NumFive_ASCII()); }
        private void Btn415_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn415_Click"); }
        //////////////////////////////////////////////////////
        //(102,"NumSix")
        public System.String NumSix_String() { return "NumSix"; }
        public System.Byte NumSix_ASCII() { return 102; }
        public PGMainMenu NumSix() { return this; }
        public PGMainMenu NumSix_Down() { return this.__Down(this.NumSix_ASCII()); }
        public PGMainMenu NumSix_Up() { return this.__Up(this.NumSix_ASCII()); }
        public bool NumSix_Is() { return this.__Is(this.NumSix_ASCII()); }
        private void Btn416_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn416_Click"); }
        //////////////////////////////////////////////////////
        //(103,"NumSeven")
        public System.String NumSeven_String() { return "NumSeven"; }
        public System.Byte NumSeven_ASCII() { return 103; }
        public PGMainMenu NumSeven() { return this; }
        public PGMainMenu NumSeven_Down() { return this.__Down(this.NumSeven_ASCII()); }
        public PGMainMenu NumSeven_Up() { return this.__Up(this.NumSeven_ASCII()); }
        public bool NumSeven_Is() { return this.__Is(this.NumSeven_ASCII()); }
        private void Btn318_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn318_Click"); }
        //////////////////////////////////////////////////////
        //(104,"NumEight")
        public System.String NumEight_String() { return "NumEight"; }
        public System.Byte NumEight_ASCII() { return 104; }
        public PGMainMenu NumEight() { return this; }
        public PGMainMenu NumEight_Down() { return this.__Down(this.NumEight_ASCII()); }
        public PGMainMenu NumEight_Up() { return this.__Up(this.NumEight_ASCII()); }
        public bool NumEight_Is() { return this.__Is(this.NumEight_ASCII()); }
        private void Btn319_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn319_Click"); }
        //////////////////////////////////////////////////////
        //(105,"NumNine")
        public System.String NumNine_String() { return "NumNine"; }
        public System.Byte NumNine_ASCII() { return 105; }
        public PGMainMenu NumNine() { return this; }
        public PGMainMenu NumNine_Down() { return this.__Down(this.NumNine_ASCII()); }
        public PGMainMenu NumNine_Up() { return this.__Up(this.NumNine_ASCII()); }
        public bool NumNine_Is() { return this.__Is(this.NumNine_ASCII()); }
        private void Btn320_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn320_Click"); }
        //////////////////////////////////////////////////////
        //(106,"NumStar")
        public System.String NumStar_String() { return "NumStar"; }
        public System.Byte NumStar_ASCII() { return 106; }
        public PGMainMenu NumStar() { return this; }
        public PGMainMenu NumStar_Down() { return this.__Down(this.NumStar_ASCII()); }
        public PGMainMenu NumStar_Up() { return this.__Up(this.NumStar_ASCII()); }
        public bool NumStar_Is() { return this.__Is(this.NumStar_ASCII()); }
        private void Btn220_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn220_Click"); }
        //////////////////////////////////////////////////////
        //(107,"NumPlus")
        public System.String NumPlus_String() { return "NumPlus"; }
        public System.Byte NumPlus_ASCII() { return 107; }
        public PGMainMenu NumPlus() { return this; }
        public PGMainMenu NumPlus_Down() { return this.__Down(this.NumPlus_ASCII()); }
        public PGMainMenu NumPlus_Up() { return this.__Up(this.NumPlus_ASCII()); }
        public bool NumPlus_Is() { return this.__Is(this.NumPlus_ASCII()); }
        private void Btn321_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn321_Click"); }
        //////////////////////////////////////////////////////
        //(109,"NumMinus")
        public System.String NumMinus_String() { return "NumMinus"; }
        public System.Byte NumMinus_ASCII() { return 109; }
        public PGMainMenu NumMinus() { return this; }
        public PGMainMenu NumMinus_Down() { return this.__Down(this.NumMinus_ASCII()); }
        public PGMainMenu NumMinus_Up() { return this.__Up(this.NumMinus_ASCII()); }
        public bool NumMinus_Is() { return this.__Is(this.NumMinus_ASCII()); }
        private void Btn221_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn221_Click"); }
        //////////////////////////////////////////////////////
        //(110,"NumDot")
        public System.String NumDot_String() { return "NumDot"; }
        public System.Byte NumDot_ASCII() { return 110; }
        public PGMainMenu NumDot() { return this; }
        public PGMainMenu NumDot_Down() { return this.__Down(this.NumDot_ASCII()); }
        public PGMainMenu NumDot_Up() { return this.__Up(this.NumDot_ASCII()); }
        public bool NumDot_Is() { return this.__Is(this.NumDot_ASCII()); }
        private void Btn612_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn612_Click"); }
        //////////////////////////////////////////////////////
        //(111,"NumSlash")
        public System.String NumSlash_String() { return "NumSlash"; }
        public System.Byte NumSlash_ASCII() { return 111; }
        public PGMainMenu NumSlash() { return this; }
        public PGMainMenu NumSlash_Down() { return this.__Down(this.NumSlash_ASCII()); }
        public PGMainMenu NumSlash_Up() { return this.__Up(this.NumSlash_ASCII()); }
        public bool NumSlash_Is() { return this.__Is(this.NumSlash_ASCII()); }
        private void Btn219_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn219_Click"); }
        //////////////////////////////////////////////////////
        //(144,"NUMLOCK")
        public System.String NUMLOCK_String() { return "NUMLOCK"; }
        public System.Byte NUMLOCK_ASCII() { return 144; }
        public PGMainMenu NUMLOCK() { return this; }
        public PGMainMenu NUMLOCK_Down() { return this.__Down(this.NUMLOCK_ASCII()); }
        public PGMainMenu NUMLOCK_Up() { return this.__Up(this.NUMLOCK_ASCII()); }
        public bool NUMLOCK_Is() { return this.__Is(this.NUMLOCK_ASCII()); }
        private void Btn218_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn218_Click"); }
        //////////////////////////////////////////////////////
        //(191,"Slash")
        public System.String Slash_String() { return "Slash"; }
        public System.Byte Slash_ASCII() { return 191; }
        public PGMainMenu Slash() { return this; }
        public PGMainMenu Slash_Down() { return this.__Down(this.Slash_ASCII()); }
        public PGMainMenu Slash_Up() { return this.__Up(this.Slash_ASCII()); }        
        public bool Slash_Is() { return this.__Is(this.Slash_ASCII()); }
        private void Btn314_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn314_Click"); }
        //////////////////////////////////////////////////////
        //(32,"Space")
        public System.String Space_String() { return "Space"; }
        public System.Byte Space_ASCII() { return 32; }
        public PGMainMenu Space() { return this; }
        public PGMainMenu Space_Down() { return this.__Down(this.Space_ASCII()); }
        public PGMainMenu Space_Up() { return this.__Up(this.Space_ASCII()); }
        public bool Space_Is() { return this.__Is(this.Space_ASCII()); }
        private void Btn64_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn64_Click"); }
        //////////////////////////////////////////////////////
        //(13,"Enter")
        public System.String Enter_String() { return "Enter"; }
        public System.Byte Enter_ASCII() { return 13; }
        public PGMainMenu Enter() { return this; }
        public PGMainMenu Enter_Down() { return this.__Down(this.Enter_ASCII()); }
        public PGMainMenu Enter_Up() { return this.__Up(this.Enter_ASCII()); }
        public bool Enter_Is() { return this.__Is(this.Enter_ASCII()); }

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
//////////////////////////////////////////////////////////////
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
                    

                ;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Button_Click_1"); }
        private void Button_Click_2(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Button_Click_2"); }
        private void Btn21_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn21_Click"); }
        private void Btn11_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn11_Click"); }


        private void Btn31_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn31_Click"); }
        private void Btn41_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn41_Click"); }
        private void Btn51_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn51_Click"); }
        private void Btn59_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn59_Click"); }
        private void Btn61_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn61_Click"); }
        private void Btn63_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn63_Click"); }
        private void Btn65_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn65_Click"); }
        private void Btn66_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn66_Click"); }
        private void Btn67_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn67_Click"); }
        private void Btn68_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn68_Click"); }
        private void Btn69_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn69_Click"); }
        private void Btn114_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn114_Click"); }
        private void Btn115_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn115_Click"); }
        private void Btn116_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn116_Click"); }
        private void Btn212_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn212_Click"); }
        private void Btn213_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn213_Click"); }
        private void Btn214_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn214_Click"); }
        private void Btn215_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn215_Click"); }
        private void Btn216_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn216_Click"); }
        private void Btn217_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn217_Click"); }
        private void Btn312_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn312_Click"); }
        private void Btn313_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn313_Click"); }
        private void Btn315_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn315_Click"); }
        private void Btn316_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn316_Click"); }
        private void Btn317_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn317_Click"); }
        private void Btn411_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn411_Click"); }
        private void Btn412_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn412_Click"); }
        private void Btn413_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn413_Click"); }
        private void Btn510_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn510_Click"); }
        private void Btn511_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn511_Click"); }
        private void Btn512_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn512_Click"); }
        private void Btn513_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn513_Click"); }
        private void Btn517_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn517_Click"); }
        private void Btn610_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn610_Click"); }




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

     

        private void Grid_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {
            this.ExitFlag = false;
            System.Threading.Thread.Sleep(50);
            this.thread.Abort();
            //thread = null;
        }
    }
}