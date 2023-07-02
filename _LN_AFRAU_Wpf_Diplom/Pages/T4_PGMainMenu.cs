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
#endregion
namespace WpfDiplom.Pages
{
    public partial class PGMainMenu : System.Windows.Controls.Page
    {
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(A, 65, Btn42)
        public System.String A_String() { return "A"; }
        public System.Byte A_ASCII() { return 65; }
        public PGMainMenu A() { return this; }
        public PGMainMenu A_Down() { return this.__Down(this.A_ASCII()); }
        public PGMainMenu A_Up() { return this.__Up(this.A_ASCII()); }
        public bool A_Is() { return this.__Is(this.A_ASCII()); }
        public PGMainMenu A_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn42.Background = Brushes.White); return this; }
        public PGMainMenu A_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn42.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu A_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn42.Background = Brushes.Green); return this; }
        private void Btn42_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn42"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(B, 66, Btn56)
        public System.String B_String() { return "B"; }
        public System.Byte B_ASCII() { return 66; }
        public PGMainMenu B() { return this; }
        public PGMainMenu B_Down() { return this.__Down(this.B_ASCII()); }
        public PGMainMenu B_Up() { return this.__Up(this.B_ASCII()); }
        public bool B_Is() { return this.__Is(this.B_ASCII()); }
        public PGMainMenu B_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn56.Background = Brushes.White); return this; }
        public PGMainMenu B_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn56.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu B_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn56.Background = Brushes.Green); return this; }
        private void Btn56_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn56"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(C, 67, Btn54)
        public System.String C_String() { return "C"; }
        public System.Byte C_ASCII() { return 67; }
        public PGMainMenu C() { return this; }
        public PGMainMenu C_Down() { return this.__Down(this.C_ASCII()); }
        public PGMainMenu C_Up() { return this.__Up(this.C_ASCII()); }
        public bool C_Is() { return this.__Is(this.C_ASCII()); }
        public PGMainMenu C_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn54.Background = Brushes.White); return this; }
        public PGMainMenu C_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn54.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu C_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn54.Background = Brushes.Green); return this; }
        private void Btn54_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn54"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(D, 68, Btn44)
        public System.String D_String() { return "D"; }
        public System.Byte D_ASCII() { return 68; }
        public PGMainMenu D() { return this; }
        public PGMainMenu D_Down() { return this.__Down(this.D_ASCII()); }
        public PGMainMenu D_Up() { return this.__Up(this.D_ASCII()); }
        public bool D_Is() { return this.__Is(this.D_ASCII()); }
        public PGMainMenu D_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn44.Background = Brushes.White); return this; }
        public PGMainMenu D_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn44.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu D_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn44.Background = Brushes.Green); return this; }
        private void Btn44_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn44"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(E, 69, Btn34)
        public System.String E_String() { return "E"; }
        public System.Byte E_ASCII() { return 69; }
        public PGMainMenu E() { return this; }
        public PGMainMenu E_Down() { return this.__Down(this.E_ASCII()); }
        public PGMainMenu E_Up() { return this.__Up(this.E_ASCII()); }
        public bool E_Is() { return this.__Is(this.E_ASCII()); }
        public PGMainMenu E_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn34.Background = Brushes.White); return this; }
        public PGMainMenu E_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn34.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu E_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn34.Background = Brushes.Green); return this; }
        private void Btn34_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn34"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(F, 70, Btn45)
        public System.String F_String() { return "F"; }
        public System.Byte F_ASCII() { return 70; }
        public PGMainMenu F() { return this; }
        public PGMainMenu F_Down() { return this.__Down(this.F_ASCII()); }
        public PGMainMenu F_Up() { return this.__Up(this.F_ASCII()); }
        public bool F_Is() { return this.__Is(this.F_ASCII()); }
        public PGMainMenu F_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn45.Background = Brushes.White); return this; }
        public PGMainMenu F_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn45.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu F_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn45.Background = Brushes.Green); return this; }
        private void Btn45_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn45"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(G, 71, Btn46)
        public System.String G_String() { return "G"; }
        public System.Byte G_ASCII() { return 71; }
        public PGMainMenu G() { return this; }
        public PGMainMenu G_Down() { return this.__Down(this.G_ASCII()); }
        public PGMainMenu G_Up() { return this.__Up(this.G_ASCII()); }
        public bool G_Is() { return this.__Is(this.G_ASCII()); }
        public PGMainMenu G_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn46.Background = Brushes.White); return this; }
        public PGMainMenu G_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn46.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu G_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn46.Background = Brushes.Green); return this; }
        private void Btn46_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn46"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(H, 72, Btn47)
        public System.String H_String() { return "H"; }
        public System.Byte H_ASCII() { return 72; }
        public PGMainMenu H() { return this; }
        public PGMainMenu H_Down() { return this.__Down(this.H_ASCII()); }
        public PGMainMenu H_Up() { return this.__Up(this.H_ASCII()); }
        public bool H_Is() { return this.__Is(this.H_ASCII()); }
        public PGMainMenu H_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn47.Background = Brushes.White); return this; }
        public PGMainMenu H_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn47.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu H_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn47.Background = Brushes.Green); return this; }
        private void Btn47_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn47"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(I, 73, Btn39)
        public System.String I_String() { return "I"; }
        public System.Byte I_ASCII() { return 73; }
        public PGMainMenu I() { return this; }
        public PGMainMenu I_Down() { return this.__Down(this.I_ASCII()); }
        public PGMainMenu I_Up() { return this.__Up(this.I_ASCII()); }
        public bool I_Is() { return this.__Is(this.I_ASCII()); }
        public PGMainMenu I_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn39.Background = Brushes.White); return this; }
        public PGMainMenu I_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn39.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu I_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn39.Background = Brushes.Green); return this; }
        private void Btn39_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn39"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(J, 74, Btn48)
        public System.String J_String() { return "J"; }
        public System.Byte J_ASCII() { return 74; }
        public PGMainMenu J() { return this; }
        public PGMainMenu J_Down() { return this.__Down(this.J_ASCII()); }
        public PGMainMenu J_Up() { return this.__Up(this.J_ASCII()); }
        public bool J_Is() { return this.__Is(this.J_ASCII()); }
        public PGMainMenu J_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn48.Background = Brushes.White); return this; }
        public PGMainMenu J_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn48.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu J_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn48.Background = Brushes.Green); return this; }
        private void Btn48_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn48"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(K, 75, Btn49)
        public System.String K_String() { return "K"; }
        public System.Byte K_ASCII() { return 75; }
        public PGMainMenu K() { return this; }
        public PGMainMenu K_Down() { return this.__Down(this.K_ASCII()); }
        public PGMainMenu K_Up() { return this.__Up(this.K_ASCII()); }
        public bool K_Is() { return this.__Is(this.K_ASCII()); }
        public PGMainMenu K_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn49.Background = Brushes.White); return this; }
        public PGMainMenu K_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn49.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu K_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn49.Background = Brushes.Green); return this; }
        private void Btn49_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn49"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(L, 76, Btn410)
        public System.String L_String() { return "L"; }
        public System.Byte L_ASCII() { return 76; }
        public PGMainMenu L() { return this; }
        public PGMainMenu L_Down() { return this.__Down(this.L_ASCII()); }
        public PGMainMenu L_Up() { return this.__Up(this.L_ASCII()); }
        public bool L_Is() { return this.__Is(this.L_ASCII()); }
        public PGMainMenu L_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn410.Background = Brushes.White); return this; }
        public PGMainMenu L_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn410.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu L_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn410.Background = Brushes.Green); return this; }
        private void Btn410_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn410"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(M, 77, Btn58)
        public System.String M_String() { return "M"; }
        public System.Byte M_ASCII() { return 77; }
        public PGMainMenu M() { return this; }
        public PGMainMenu M_Down() { return this.__Down(this.M_ASCII()); }
        public PGMainMenu M_Up() { return this.__Up(this.M_ASCII()); }
        public bool M_Is() { return this.__Is(this.M_ASCII()); }
        public PGMainMenu M_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn58.Background = Brushes.White); return this; }
        public PGMainMenu M_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn58.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu M_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn58.Background = Brushes.Green); return this; }
        private void Btn58_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn58"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(N, 78, Btn57)
        public System.String N_String() { return "N"; }
        public System.Byte N_ASCII() { return 78; }
        public PGMainMenu N() { return this; }
        public PGMainMenu N_Down() { return this.__Down(this.N_ASCII()); }
        public PGMainMenu N_Up() { return this.__Up(this.N_ASCII()); }
        public bool N_Is() { return this.__Is(this.N_ASCII()); }
        public PGMainMenu N_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn57.Background = Brushes.White); return this; }
        public PGMainMenu N_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn57.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu N_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn57.Background = Brushes.Green); return this; }
        private void Btn57_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn57"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(O, 79, Btn310)
        public System.String O_String() { return "O"; }
        public System.Byte O_ASCII() { return 79; }
        public PGMainMenu O() { return this; }
        public PGMainMenu O_Down() { return this.__Down(this.O_ASCII()); }
        public PGMainMenu O_Up() { return this.__Up(this.O_ASCII()); }
        public bool O_Is() { return this.__Is(this.O_ASCII()); }
        public PGMainMenu O_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn310.Background = Brushes.White); return this; }
        public PGMainMenu O_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn310.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu O_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn310.Background = Brushes.Green); return this; }
        private void Btn310_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn310"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(P, 80, Btn311)
        public System.String P_String() { return "P"; }
        public System.Byte P_ASCII() { return 80; }
        public PGMainMenu P() { return this; }
        public PGMainMenu P_Down() { return this.__Down(this.P_ASCII()); }
        public PGMainMenu P_Up() { return this.__Up(this.P_ASCII()); }
        public bool P_Is() { return this.__Is(this.P_ASCII()); }
        public PGMainMenu P_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn311.Background = Brushes.White); return this; }
        public PGMainMenu P_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn311.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu P_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn311.Background = Brushes.Green); return this; }
        private void Btn311_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn311"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(Q, 81, Btn32)
        public System.String Q_String() { return "Q"; }
        public System.Byte Q_ASCII() { return 81; }
        public PGMainMenu Q() { return this; }
        public PGMainMenu Q_Down() { return this.__Down(this.Q_ASCII()); }
        public PGMainMenu Q_Up() { return this.__Up(this.Q_ASCII()); }
        public bool Q_Is() { return this.__Is(this.Q_ASCII()); }
        public PGMainMenu Q_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn32.Background = Brushes.White); return this; }
        public PGMainMenu Q_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn32.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu Q_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn32.Background = Brushes.Green); return this; }
        private void Btn32_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn32"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(R, 82, Btn35)
        public System.String R_String() { return "R"; }
        public System.Byte R_ASCII() { return 82; }
        public PGMainMenu R() { return this; }
        public PGMainMenu R_Down() { return this.__Down(this.R_ASCII()); }
        public PGMainMenu R_Up() { return this.__Up(this.R_ASCII()); }
        public bool R_Is() { return this.__Is(this.R_ASCII()); }
        public PGMainMenu R_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn35.Background = Brushes.White); return this; }
        public PGMainMenu R_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn35.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu R_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn35.Background = Brushes.Green); return this; }
        private void Btn35_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn35"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(S, 83, Btn43)
        public System.String S_String() { return "S"; }
        public System.Byte S_ASCII() { return 83; }
        public PGMainMenu S() { return this; }
        public PGMainMenu S_Down() { return this.__Down(this.S_ASCII()); }
        public PGMainMenu S_Up() { return this.__Up(this.S_ASCII()); }
        public bool S_Is() { return this.__Is(this.S_ASCII()); }
        public PGMainMenu S_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn43.Background = Brushes.White); return this; }
        public PGMainMenu S_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn43.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu S_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn43.Background = Brushes.Green); return this; }
        private void Btn43_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn43"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(T, 84, Btn36)
        public System.String T_String() { return "T"; }
        public System.Byte T_ASCII() { return 84; }
        public PGMainMenu T() { return this; }
        public PGMainMenu T_Down() { return this.__Down(this.T_ASCII()); }
        public PGMainMenu T_Up() { return this.__Up(this.T_ASCII()); }
        public bool T_Is() { return this.__Is(this.T_ASCII()); }
        public PGMainMenu T_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn36.Background = Brushes.White); return this; }
        public PGMainMenu T_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn36.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu T_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn36.Background = Brushes.Green); return this; }
        private void Btn36_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn36"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(U, 85, Btn38)
        public System.String U_String() { return "U"; }
        public System.Byte U_ASCII() { return 85; }
        public PGMainMenu U() { return this; }
        public PGMainMenu U_Down() { return this.__Down(this.U_ASCII()); }
        public PGMainMenu U_Up() { return this.__Up(this.U_ASCII()); }
        public bool U_Is() { return this.__Is(this.U_ASCII()); }
        public PGMainMenu U_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn38.Background = Brushes.White); return this; }
        public PGMainMenu U_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn38.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu U_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn38.Background = Brushes.Green); return this; }
        private void Btn38_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn38"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(V, 86, Btn55)
        public System.String V_String() { return "V"; }
        public System.Byte V_ASCII() { return 86; }
        public PGMainMenu V() { return this; }
        public PGMainMenu V_Down() { return this.__Down(this.V_ASCII()); }
        public PGMainMenu V_Up() { return this.__Up(this.V_ASCII()); }
        public bool V_Is() { return this.__Is(this.V_ASCII()); }
        public PGMainMenu V_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn55.Background = Brushes.White); return this; }
        public PGMainMenu V_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn55.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu V_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn55.Background = Brushes.Green); return this; }
        private void Btn55_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn55"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(W, 87, Btn33)
        public System.String W_String() { return "W"; }
        public System.Byte W_ASCII() { return 87; }
        public PGMainMenu W() { return this; }
        public PGMainMenu W_Down() { return this.__Down(this.W_ASCII()); }
        public PGMainMenu W_Up() { return this.__Up(this.W_ASCII()); }
        public bool W_Is() { return this.__Is(this.W_ASCII()); }
        public PGMainMenu W_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn33.Background = Brushes.White); return this; }
        public PGMainMenu W_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn33.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu W_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn33.Background = Brushes.Green); return this; }
        private void Btn33_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn33"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(X, 88, Btn53)
        public System.String X_String() { return "X"; }
        public System.Byte X_ASCII() { return 88; }
        public PGMainMenu X() { return this; }
        public PGMainMenu X_Down() { return this.__Down(this.X_ASCII()); }
        public PGMainMenu X_Up() { return this.__Up(this.X_ASCII()); }
        public bool X_Is() { return this.__Is(this.X_ASCII()); }
        public PGMainMenu X_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn53.Background = Brushes.White); return this; }
        public PGMainMenu X_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn53.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu X_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn53.Background = Brushes.Green); return this; }
        private void Btn53_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn53"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(Y, 89, Btn37)
        public System.String Y_String() { return "Y"; }
        public System.Byte Y_ASCII() { return 89; }
        public PGMainMenu Y() { return this; }
        public PGMainMenu Y_Down() { return this.__Down(this.Y_ASCII()); }
        public PGMainMenu Y_Up() { return this.__Up(this.Y_ASCII()); }
        public bool Y_Is() { return this.__Is(this.Y_ASCII()); }
        public PGMainMenu Y_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn37.Background = Brushes.White); return this; }
        public PGMainMenu Y_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn37.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu Y_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn37.Background = Brushes.Green); return this; }
        private void Btn37_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn37"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(Z, 90, Btn52)
        public System.String Z_String() { return "Z"; }
        public System.Byte Z_ASCII() { return 90; }
        public PGMainMenu Z() { return this; }
        public PGMainMenu Z_Down() { return this.__Down(this.Z_ASCII()); }
        public PGMainMenu Z_Up() { return this.__Up(this.Z_ASCII()); }
        public bool Z_Is() { return this.__Is(this.Z_ASCII()); }
        public PGMainMenu Z_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn52.Background = Brushes.White); return this; }
        public PGMainMenu Z_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn52.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu Z_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn52.Background = Brushes.Green); return this; }
        private void Btn52_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn52"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(_0, 48, Btn211)
        public System.String _0_String() { return "_0"; }
        public System.Byte _0_ASCII() { return 48; }
        public PGMainMenu _0() { return this; }
        public PGMainMenu _0_Down() { return this.__Down(this._0_ASCII()); }
        public PGMainMenu _0_Up() { return this.__Up(this._0_ASCII()); }
        public bool _0_Is() { return this.__Is(this._0_ASCII()); }
        public PGMainMenu _0_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn211.Background = Brushes.White); return this; }
        public PGMainMenu _0_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn211.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu _0_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn211.Background = Brushes.Green); return this; }
        private void Btn211_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn211"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(_1, 49, Btn22)
        public System.String _1_String() { return "_1"; }
        public System.Byte _1_ASCII() { return 49; }
        public PGMainMenu _1() { return this; }
        public PGMainMenu _1_Down() { return this.__Down(this._1_ASCII()); }
        public PGMainMenu _1_Up() { return this.__Up(this._1_ASCII()); }
        public bool _1_Is() { return this.__Is(this._1_ASCII()); }
        public PGMainMenu _1_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn22.Background = Brushes.White); return this; }
        public PGMainMenu _1_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn22.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu _1_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn22.Background = Brushes.Green); return this; }
        private void Btn22_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn22"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(_2, 50, Btn23)
        public System.String _2_String() { return "_2"; }
        public System.Byte _2_ASCII() { return 50; }
        public PGMainMenu _2() { return this; }
        public PGMainMenu _2_Down() { return this.__Down(this._2_ASCII()); }
        public PGMainMenu _2_Up() { return this.__Up(this._2_ASCII()); }
        public bool _2_Is() { return this.__Is(this._2_ASCII()); }
        public PGMainMenu _2_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn23.Background = Brushes.White); return this; }
        public PGMainMenu _2_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn23.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu _2_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn23.Background = Brushes.Green); return this; }
        private void Btn23_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn23"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(_3, 51, Btn24)
        public System.String _3_String() { return "_3"; }
        public System.Byte _3_ASCII() { return 51; }
        public PGMainMenu _3() { return this; }
        public PGMainMenu _3_Down() { return this.__Down(this._3_ASCII()); }
        public PGMainMenu _3_Up() { return this.__Up(this._3_ASCII()); }
        public bool _3_Is() { return this.__Is(this._3_ASCII()); }
        public PGMainMenu _3_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn24.Background = Brushes.White); return this; }
        public PGMainMenu _3_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn24.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu _3_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn24.Background = Brushes.Green); return this; }
        private void Btn24_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn24"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(_4, 52, Btn25)
        public System.String _4_String() { return "_4"; }
        public System.Byte _4_ASCII() { return 52; }
        public PGMainMenu _4() { return this; }
        public PGMainMenu _4_Down() { return this.__Down(this._4_ASCII()); }
        public PGMainMenu _4_Up() { return this.__Up(this._4_ASCII()); }
        public bool _4_Is() { return this.__Is(this._4_ASCII()); }
        public PGMainMenu _4_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn25.Background = Brushes.White); return this; }
        public PGMainMenu _4_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn25.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu _4_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn25.Background = Brushes.Green); return this; }
        private void Btn25_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn25"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(_5, 53, Btn26)
        public System.String _5_String() { return "_5"; }
        public System.Byte _5_ASCII() { return 53; }
        public PGMainMenu _5() { return this; }
        public PGMainMenu _5_Down() { return this.__Down(this._5_ASCII()); }
        public PGMainMenu _5_Up() { return this.__Up(this._5_ASCII()); }
        public bool _5_Is() { return this.__Is(this._5_ASCII()); }
        public PGMainMenu _5_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn26.Background = Brushes.White); return this; }
        public PGMainMenu _5_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn26.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu _5_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn26.Background = Brushes.Green); return this; }
        private void Btn26_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn26"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(_6, 54, Btn27)
        public System.String _6_String() { return "_6"; }
        public System.Byte _6_ASCII() { return 54; }
        public PGMainMenu _6() { return this; }
        public PGMainMenu _6_Down() { return this.__Down(this._6_ASCII()); }
        public PGMainMenu _6_Up() { return this.__Up(this._6_ASCII()); }
        public bool _6_Is() { return this.__Is(this._6_ASCII()); }
        public PGMainMenu _6_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn27.Background = Brushes.White); return this; }
        public PGMainMenu _6_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn27.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu _6_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn27.Background = Brushes.Green); return this; }
        private void Btn27_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn27"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(_7, 55, Btn28)
        public System.String _7_String() { return "_7"; }
        public System.Byte _7_ASCII() { return 55; }
        public PGMainMenu _7() { return this; }
        public PGMainMenu _7_Down() { return this.__Down(this._7_ASCII()); }
        public PGMainMenu _7_Up() { return this.__Up(this._7_ASCII()); }
        public bool _7_Is() { return this.__Is(this._7_ASCII()); }
        public PGMainMenu _7_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn28.Background = Brushes.White); return this; }
        public PGMainMenu _7_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn28.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu _7_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn28.Background = Brushes.Green); return this; }
        private void Btn28_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn28"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(_8, 56, Btn29)
        public System.String _8_String() { return "_8"; }
        public System.Byte _8_ASCII() { return 56; }
        public PGMainMenu _8() { return this; }
        public PGMainMenu _8_Down() { return this.__Down(this._8_ASCII()); }
        public PGMainMenu _8_Up() { return this.__Up(this._8_ASCII()); }
        public bool _8_Is() { return this.__Is(this._8_ASCII()); }
        public PGMainMenu _8_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn29.Background = Brushes.White); return this; }
        public PGMainMenu _8_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn29.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu _8_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn29.Background = Brushes.Green); return this; }
        private void Btn29_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn29"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(_9, 57, Btn210)
        public System.String _9_String() { return "_9"; }
        public System.Byte _9_ASCII() { return 57; }
        public PGMainMenu _9() { return this; }
        public PGMainMenu _9_Down() { return this.__Down(this._9_ASCII()); }
        public PGMainMenu _9_Up() { return this.__Up(this._9_ASCII()); }
        public bool _9_Is() { return this.__Is(this._9_ASCII()); }
        public PGMainMenu _9_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn210.Background = Brushes.White); return this; }
        public PGMainMenu _9_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn210.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu _9_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn210.Background = Brushes.Green); return this; }
        private void Btn210_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn210"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(F1, 112, Btn12)
        public System.String F1_String() { return "F1"; }
        public System.Byte F1_ASCII() { return 112; }
        public PGMainMenu F1() { return this; }
        public PGMainMenu F1_Down() { return this.__Down(this.F1_ASCII()); }
        public PGMainMenu F1_Up() { return this.__Up(this.F1_ASCII()); }
        public bool F1_Is() { return this.__Is(this.F1_ASCII()); }
        public PGMainMenu F1_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn12.Background = Brushes.White); return this; }
        public PGMainMenu F1_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn12.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu F1_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn12.Background = Brushes.Green); return this; }
        private void Btn12_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn12"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(F2, 113, Btn13)
        public System.String F2_String() { return "F2"; }
        public System.Byte F2_ASCII() { return 113; }
        public PGMainMenu F2() { return this; }
        public PGMainMenu F2_Down() { return this.__Down(this.F2_ASCII()); }
        public PGMainMenu F2_Up() { return this.__Up(this.F2_ASCII()); }
        public bool F2_Is() { return this.__Is(this.F2_ASCII()); }
        public PGMainMenu F2_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn13.Background = Brushes.White); return this; }
        public PGMainMenu F2_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn13.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu F2_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn13.Background = Brushes.Green); return this; }
        private void Btn13_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn13"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(F3, 114, Btn14)
        public System.String F3_String() { return "F3"; }
        public System.Byte F3_ASCII() { return 114; }
        public PGMainMenu F3() { return this; }
        public PGMainMenu F3_Down() { return this.__Down(this.F3_ASCII()); }
        public PGMainMenu F3_Up() { return this.__Up(this.F3_ASCII()); }
        public bool F3_Is() { return this.__Is(this.F3_ASCII()); }
        public PGMainMenu F3_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn14.Background = Brushes.White); return this; }
        public PGMainMenu F3_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn14.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu F3_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn14.Background = Brushes.Green); return this; }
        private void Btn14_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn14"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(F4, 115, Btn15)
        public System.String F4_String() { return "F4"; }
        public System.Byte F4_ASCII() { return 115; }
        public PGMainMenu F4() { return this; }
        public PGMainMenu F4_Down() { return this.__Down(this.F4_ASCII()); }
        public PGMainMenu F4_Up() { return this.__Up(this.F4_ASCII()); }
        public bool F4_Is() { return this.__Is(this.F4_ASCII()); }
        public PGMainMenu F4_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn15.Background = Brushes.White); return this; }
        public PGMainMenu F4_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn15.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu F4_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn15.Background = Brushes.Green); return this; }
        private void Btn15_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn15"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(F5, 116, Btn16)
        public System.String F5_String() { return "F5"; }
        public System.Byte F5_ASCII() { return 116; }
        public PGMainMenu F5() { return this; }
        public PGMainMenu F5_Down() { return this.__Down(this.F5_ASCII()); }
        public PGMainMenu F5_Up() { return this.__Up(this.F5_ASCII()); }
        public bool F5_Is() { return this.__Is(this.F5_ASCII()); }
        public PGMainMenu F5_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn16.Background = Brushes.White); return this; }
        public PGMainMenu F5_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn16.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu F5_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn16.Background = Brushes.Green); return this; }
        private void Btn16_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn16"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(F6, 117, Btn17)
        public System.String F6_String() { return "F6"; }
        public System.Byte F6_ASCII() { return 117; }
        public PGMainMenu F6() { return this; }
        public PGMainMenu F6_Down() { return this.__Down(this.F6_ASCII()); }
        public PGMainMenu F6_Up() { return this.__Up(this.F6_ASCII()); }
        public bool F6_Is() { return this.__Is(this.F6_ASCII()); }
        public PGMainMenu F6_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn17.Background = Brushes.White); return this; }
        public PGMainMenu F6_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn17.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu F6_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn17.Background = Brushes.Green); return this; }
        private void Btn17_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn17"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(F7, 118, Btn18)
        public System.String F7_String() { return "F7"; }
        public System.Byte F7_ASCII() { return 118; }
        public PGMainMenu F7() { return this; }
        public PGMainMenu F7_Down() { return this.__Down(this.F7_ASCII()); }
        public PGMainMenu F7_Up() { return this.__Up(this.F7_ASCII()); }
        public bool F7_Is() { return this.__Is(this.F7_ASCII()); }
        public PGMainMenu F7_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn18.Background = Brushes.White); return this; }
        public PGMainMenu F7_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn18.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu F7_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn18.Background = Brushes.Green); return this; }
        private void Btn18_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn18"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(F8, 119, Btn19)
        public System.String F8_String() { return "F8"; }
        public System.Byte F8_ASCII() { return 119; }
        public PGMainMenu F8() { return this; }
        public PGMainMenu F8_Down() { return this.__Down(this.F8_ASCII()); }
        public PGMainMenu F8_Up() { return this.__Up(this.F8_ASCII()); }
        public bool F8_Is() { return this.__Is(this.F8_ASCII()); }
        public PGMainMenu F8_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn19.Background = Brushes.White); return this; }
        public PGMainMenu F8_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn19.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu F8_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn19.Background = Brushes.Green); return this; }
        private void Btn19_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn19"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(F9, 120, Btn110)
        public System.String F9_String() { return "F9"; }
        public System.Byte F9_ASCII() { return 120; }
        public PGMainMenu F9() { return this; }
        public PGMainMenu F9_Down() { return this.__Down(this.F9_ASCII()); }
        public PGMainMenu F9_Up() { return this.__Up(this.F9_ASCII()); }
        public bool F9_Is() { return this.__Is(this.F9_ASCII()); }
        public PGMainMenu F9_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn110.Background = Brushes.White); return this; }
        public PGMainMenu F9_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn110.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu F9_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn110.Background = Brushes.Green); return this; }
        private void Btn110_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn110"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(F10, 121, Btn111)
        public System.String F10_String() { return "F10"; }
        public System.Byte F10_ASCII() { return 121; }
        public PGMainMenu F10() { return this; }
        public PGMainMenu F10_Down() { return this.__Down(this.F10_ASCII()); }
        public PGMainMenu F10_Up() { return this.__Up(this.F10_ASCII()); }
        public bool F10_Is() { return this.__Is(this.F10_ASCII()); }
        public PGMainMenu F10_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn111.Background = Brushes.White); return this; }
        public PGMainMenu F10_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn111.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu F10_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn111.Background = Brushes.Green); return this; }
        private void Btn111_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn111"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(F11, 122, Btn112)
        public System.String F11_String() { return "F11"; }
        public System.Byte F11_ASCII() { return 122; }
        public PGMainMenu F11() { return this; }
        public PGMainMenu F11_Down() { return this.__Down(this.F11_ASCII()); }
        public PGMainMenu F11_Up() { return this.__Up(this.F11_ASCII()); }
        public bool F11_Is() { return this.__Is(this.F11_ASCII()); }
        public PGMainMenu F11_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn112.Background = Brushes.White); return this; }
        public PGMainMenu F11_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn112.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu F11_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn112.Background = Brushes.Green); return this; }
        private void Btn112_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn112"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(F12, 123, Btn113)
        public System.String F12_String() { return "F12"; }
        public System.Byte F12_ASCII() { return 123; }
        public PGMainMenu F12() { return this; }
        public PGMainMenu F12_Down() { return this.__Down(this.F12_ASCII()); }
        public PGMainMenu F12_Up() { return this.__Up(this.F12_ASCII()); }
        public bool F12_Is() { return this.__Is(this.F12_ASCII()); }
        public PGMainMenu F12_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn113.Background = Brushes.White); return this; }
        public PGMainMenu F12_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn113.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu F12_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn113.Background = Brushes.Green); return this; }
        private void Btn113_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn113"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(NumZero, 96, Btn611)
        public System.String NumZero_String() { return "NumZero"; }
        public System.Byte NumZero_ASCII() { return 96; }
        public PGMainMenu NumZero() { return this; }
        public PGMainMenu NumZero_Down() { return this.__Down(this.NumZero_ASCII()); }
        public PGMainMenu NumZero_Up() { return this.__Up(this.NumZero_ASCII()); }
        public bool NumZero_Is() { return this.__Is(this.NumZero_ASCII()); }
        public PGMainMenu NumZero_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn611.Background = Brushes.White); return this; }
        public PGMainMenu NumZero_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn611.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu NumZero_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn611.Background = Brushes.Green); return this; }
        private void Btn611_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn611"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(NumOne, 97, Btn514)
        public System.String NumOne_String() { return "NumOne"; }
        public System.Byte NumOne_ASCII() { return 97; }
        public PGMainMenu NumOne() { return this; }
        public PGMainMenu NumOne_Down() { return this.__Down(this.NumOne_ASCII()); }
        public PGMainMenu NumOne_Up() { return this.__Up(this.NumOne_ASCII()); }
        public bool NumOne_Is() { return this.__Is(this.NumOne_ASCII()); }
        public PGMainMenu NumOne_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn514.Background = Brushes.White); return this; }
        public PGMainMenu NumOne_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn514.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu NumOne_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn514.Background = Brushes.Green); return this; }
        private void Btn514_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn514"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(NumTwo, 98, Btn515)
        public System.String NumTwo_String() { return "NumTwo"; }
        public System.Byte NumTwo_ASCII() { return 98; }
        public PGMainMenu NumTwo() { return this; }
        public PGMainMenu NumTwo_Down() { return this.__Down(this.NumTwo_ASCII()); }
        public PGMainMenu NumTwo_Up() { return this.__Up(this.NumTwo_ASCII()); }
        public bool NumTwo_Is() { return this.__Is(this.NumTwo_ASCII()); }
        public PGMainMenu NumTwo_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn515.Background = Brushes.White); return this; }
        public PGMainMenu NumTwo_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn515.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu NumTwo_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn515.Background = Brushes.Green); return this; }
        private void Btn515_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn515"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(NumThree, 99, Btn516)
        public System.String NumThree_String() { return "NumThree"; }
        public System.Byte NumThree_ASCII() { return 99; }
        public PGMainMenu NumThree() { return this; }
        public PGMainMenu NumThree_Down() { return this.__Down(this.NumThree_ASCII()); }
        public PGMainMenu NumThree_Up() { return this.__Up(this.NumThree_ASCII()); }
        public bool NumThree_Is() { return this.__Is(this.NumThree_ASCII()); }
        public PGMainMenu NumThree_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn516.Background = Brushes.White); return this; }
        public PGMainMenu NumThree_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn516.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu NumThree_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn516.Background = Brushes.Green); return this; }
        private void Btn516_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn516"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(NumFor, 100, Btn414)
        public System.String NumFor_String() { return "NumFor"; }
        public System.Byte NumFor_ASCII() { return 100; }
        public PGMainMenu NumFor() { return this; }
        public PGMainMenu NumFor_Down() { return this.__Down(this.NumFor_ASCII()); }
        public PGMainMenu NumFor_Up() { return this.__Up(this.NumFor_ASCII()); }
        public bool NumFor_Is() { return this.__Is(this.NumFor_ASCII()); }
        public PGMainMenu NumFor_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn414.Background = Brushes.White); return this; }
        public PGMainMenu NumFor_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn414.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu NumFor_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn414.Background = Brushes.Green); return this; }
        private void Btn414_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn414"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(NumFive, 101, Btn415)
        public System.String NumFive_String() { return "NumFive"; }
        public System.Byte NumFive_ASCII() { return 101; }
        public PGMainMenu NumFive() { return this; }
        public PGMainMenu NumFive_Down() { return this.__Down(this.NumFive_ASCII()); }
        public PGMainMenu NumFive_Up() { return this.__Up(this.NumFive_ASCII()); }
        public bool NumFive_Is() { return this.__Is(this.NumFive_ASCII()); }
        public PGMainMenu NumFive_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn415.Background = Brushes.White); return this; }
        public PGMainMenu NumFive_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn415.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu NumFive_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn415.Background = Brushes.Green); return this; }
        private void Btn415_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn415"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(NumSix, 102, Btn416)
        public System.String NumSix_String() { return "NumSix"; }
        public System.Byte NumSix_ASCII() { return 102; }
        public PGMainMenu NumSix() { return this; }
        public PGMainMenu NumSix_Down() { return this.__Down(this.NumSix_ASCII()); }
        public PGMainMenu NumSix_Up() { return this.__Up(this.NumSix_ASCII()); }
        public bool NumSix_Is() { return this.__Is(this.NumSix_ASCII()); }
        public PGMainMenu NumSix_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn416.Background = Brushes.White); return this; }
        public PGMainMenu NumSix_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn416.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu NumSix_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn416.Background = Brushes.Green); return this; }
        private void Btn416_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn416"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(NumSeven, 103, Btn318)
        public System.String NumSeven_String() { return "NumSeven"; }
        public System.Byte NumSeven_ASCII() { return 103; }
        public PGMainMenu NumSeven() { return this; }
        public PGMainMenu NumSeven_Down() { return this.__Down(this.NumSeven_ASCII()); }
        public PGMainMenu NumSeven_Up() { return this.__Up(this.NumSeven_ASCII()); }
        public bool NumSeven_Is() { return this.__Is(this.NumSeven_ASCII()); }
        public PGMainMenu NumSeven_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn318.Background = Brushes.White); return this; }
        public PGMainMenu NumSeven_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn318.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu NumSeven_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn318.Background = Brushes.Green); return this; }
        private void Btn318_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn318"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(NumEight, 104, Btn319)
        public System.String NumEight_String() { return "NumEight"; }
        public System.Byte NumEight_ASCII() { return 104; }
        public PGMainMenu NumEight() { return this; }
        public PGMainMenu NumEight_Down() { return this.__Down(this.NumEight_ASCII()); }
        public PGMainMenu NumEight_Up() { return this.__Up(this.NumEight_ASCII()); }
        public bool NumEight_Is() { return this.__Is(this.NumEight_ASCII()); }
        public PGMainMenu NumEight_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn319.Background = Brushes.White); return this; }
        public PGMainMenu NumEight_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn319.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu NumEight_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn319.Background = Brushes.Green); return this; }
        private void Btn319_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn319"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(NumNine, 105, Btn320)
        public System.String NumNine_String() { return "NumNine"; }
        public System.Byte NumNine_ASCII() { return 105; }
        public PGMainMenu NumNine() { return this; }
        public PGMainMenu NumNine_Down() { return this.__Down(this.NumNine_ASCII()); }
        public PGMainMenu NumNine_Up() { return this.__Up(this.NumNine_ASCII()); }
        public bool NumNine_Is() { return this.__Is(this.NumNine_ASCII()); }
        public PGMainMenu NumNine_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn320.Background = Brushes.White); return this; }
        public PGMainMenu NumNine_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn320.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu NumNine_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn320.Background = Brushes.Green); return this; }
        private void Btn320_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn320"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(NumStar, 106, Btn220)
        public System.String NumStar_String() { return "NumStar"; }
        public System.Byte NumStar_ASCII() { return 106; }
        public PGMainMenu NumStar() { return this; }
        public PGMainMenu NumStar_Down() { return this.__Down(this.NumStar_ASCII()); }
        public PGMainMenu NumStar_Up() { return this.__Up(this.NumStar_ASCII()); }
        public bool NumStar_Is() { return this.__Is(this.NumStar_ASCII()); }
        public PGMainMenu NumStar_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn220.Background = Brushes.White); return this; }
        public PGMainMenu NumStar_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn220.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu NumStar_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn220.Background = Brushes.Green); return this; }
        private void Btn220_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn220"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(NumPlus, 107, Btn321)
        public System.String NumPlus_String() { return "NumPlus"; }
        public System.Byte NumPlus_ASCII() { return 107; }
        public PGMainMenu NumPlus() { return this; }
        public PGMainMenu NumPlus_Down() { return this.__Down(this.NumPlus_ASCII()); }
        public PGMainMenu NumPlus_Up() { return this.__Up(this.NumPlus_ASCII()); }
        public bool NumPlus_Is() { return this.__Is(this.NumPlus_ASCII()); }
        public PGMainMenu NumPlus_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn321.Background = Brushes.White); return this; }
        public PGMainMenu NumPlus_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn321.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu NumPlus_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn321.Background = Brushes.Green); return this; }
        private void Btn321_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn321"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(NumMinus, 109, Btn221)
        public System.String NumMinus_String() { return "NumMinus"; }
        public System.Byte NumMinus_ASCII() { return 109; }
        public PGMainMenu NumMinus() { return this; }
        public PGMainMenu NumMinus_Down() { return this.__Down(this.NumMinus_ASCII()); }
        public PGMainMenu NumMinus_Up() { return this.__Up(this.NumMinus_ASCII()); }
        public bool NumMinus_Is() { return this.__Is(this.NumMinus_ASCII()); }
        public PGMainMenu NumMinus_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn221.Background = Brushes.White); return this; }
        public PGMainMenu NumMinus_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn221.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu NumMinus_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn221.Background = Brushes.Green); return this; }
        private void Btn221_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn221"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(NumDot, 110, Btn612)
        public System.String NumDot_String() { return "NumDot"; }
        public System.Byte NumDot_ASCII() { return 110; }
        public PGMainMenu NumDot() { return this; }
        public PGMainMenu NumDot_Down() { return this.__Down(this.NumDot_ASCII()); }
        public PGMainMenu NumDot_Up() { return this.__Up(this.NumDot_ASCII()); }
        public bool NumDot_Is() { return this.__Is(this.NumDot_ASCII()); }
        public PGMainMenu NumDot_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn612.Background = Brushes.White); return this; }
        public PGMainMenu NumDot_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn612.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu NumDot_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn612.Background = Brushes.Green); return this; }
        private void Btn612_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn612"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(NumSlash, 111, Btn219)
        public System.String NumSlash_String() { return "NumSlash"; }
        public System.Byte NumSlash_ASCII() { return 111; }
        public PGMainMenu NumSlash() { return this; }
        public PGMainMenu NumSlash_Down() { return this.__Down(this.NumSlash_ASCII()); }
        public PGMainMenu NumSlash_Up() { return this.__Up(this.NumSlash_ASCII()); }
        public bool NumSlash_Is() { return this.__Is(this.NumSlash_ASCII()); }
        public PGMainMenu NumSlash_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn219.Background = Brushes.White); return this; }
        public PGMainMenu NumSlash_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn219.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu NumSlash_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn219.Background = Brushes.Green); return this; }
        private void Btn219_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn219"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(NumEnter, 13, Btn517)
        public System.String NumEnter_String() { return "NumEnter"; }
        public System.Byte NumEnter_ASCII() { return 13; }
        public PGMainMenu NumEnter() { return this; }
        public PGMainMenu NumEnter_Down() { return this.__Down(this.NumEnter_ASCII()); }
        public PGMainMenu NumEnter_Up() { return this.__Up(this.NumEnter_ASCII()); }
        public bool NumEnter_Is() { return this.__Is(this.NumEnter_ASCII()); }
        public PGMainMenu NumEnter_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn517.Background = Brushes.White); return this; }
        public PGMainMenu NumEnter_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn517.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu NumEnter_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn517.Background = Brushes.Green); return this; }
        private void Btn517_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn517"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(NUMLOCK, 144, Btn218)
        public System.String NUMLOCK_String() { return "NUMLOCK"; }
        public System.Byte NUMLOCK_ASCII() { return 144; }
        public PGMainMenu NUMLOCK() { return this; }
        public PGMainMenu NUMLOCK_Down() { return this.__Down(this.NUMLOCK_ASCII()); }
        public PGMainMenu NUMLOCK_Up() { return this.__Up(this.NUMLOCK_ASCII()); }
        public bool NUMLOCK_Is() { return this.__Is(this.NUMLOCK_ASCII()); }
        public PGMainMenu NUMLOCK_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn218.Background = Brushes.White); return this; }
        public PGMainMenu NUMLOCK_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn218.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu NUMLOCK_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn218.Background = Brushes.Green); return this; }
        private void Btn218_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn218"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(Space, 32, Btn64)
        public System.String Space_String() { return "Space"; }
        public System.Byte Space_ASCII() { return 32; }
        public PGMainMenu Space() { return this; }
        public PGMainMenu Space_Down() { return this.__Down(this.Space_ASCII()); }
        public PGMainMenu Space_Up() { return this.__Up(this.Space_ASCII()); }
        public bool Space_Is() { return this.__Is(this.Space_ASCII()); }
        public PGMainMenu Space_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn64.Background = Brushes.White); return this; }
        public PGMainMenu Space_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn64.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu Space_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn64.Background = Brushes.Green); return this; }
        private void Btn64_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn64"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(Enter, 13, Btn413)
        public System.String Enter_String() { return "Enter"; }
        public System.Byte Enter_ASCII() { return 13; }
        public PGMainMenu Enter() { return this; }
        public PGMainMenu Enter_Down() { return this.__Down(this.Enter_ASCII()); }
        public PGMainMenu Enter_Up() { return this.__Up(this.Enter_ASCII()); }
        public bool Enter_Is() { return this.__Is(this.Enter_ASCII()); }
        public PGMainMenu Enter_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn413.Background = Brushes.White); return this; }
        public PGMainMenu Enter_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn413.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu Enter_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn413.Background = Brushes.Green); return this; }
        private void Btn413_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn413"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(Escape, 27, Btn11)
        public System.String Escape_String() { return "Escape"; }
        public System.Byte Escape_ASCII() { return 27; }
        public PGMainMenu Escape() { return this; }
        public PGMainMenu Escape_Down() { return this.__Down(this.Escape_ASCII()); }
        public PGMainMenu Escape_Up() { return this.__Up(this.Escape_ASCII()); }
        public bool Escape_Is() { return this.__Is(this.Escape_ASCII()); }
        public PGMainMenu Escape_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn11.Background = Brushes.White); return this; }
        public PGMainMenu Escape_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn11.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu Escape_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn11.Background = Brushes.Green); return this; }
        private void Btn11_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn11"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(LShift, 16, Btn51)
        public System.String LShift_String() { return "LShift"; }
        public System.Byte LShift_ASCII() { return 16; }
        public PGMainMenu LShift() { return this; }
        public PGMainMenu LShift_Down() { return this.__Down(this.LShift_ASCII()); }
        public PGMainMenu LShift_Up() { return this.__Up(this.LShift_ASCII()); }
        public bool LShift_Is() { return this.__Is(this.LShift_ASCII()); }
        public PGMainMenu LShift_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn51.Background = Brushes.White); return this; }
        public PGMainMenu LShift_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn51.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu LShift_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn51.Background = Brushes.Green); return this; }
        private void Btn51_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn51"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(RShift, 16, Btn512)
        public System.String RShift_String() { return "RShift"; }
        public System.Byte RShift_ASCII() { return 16; }
        public PGMainMenu RShift() { return this; }
        public PGMainMenu RShift_Down() { return this.__Down(this.RShift_ASCII()); }
        public PGMainMenu RShift_Up() { return this.__Up(this.RShift_ASCII()); }
        public bool RShift_Is() { return this.__Is(this.RShift_ASCII()); }
        public PGMainMenu RShift_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn512.Background = Brushes.White); return this; }
        public PGMainMenu RShift_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn512.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu RShift_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn512.Background = Brushes.Green); return this; }
        private void Btn512_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn512"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(BackSpace, 8, Btn214)
        public System.String BackSpace_String() { return "BackSpace"; }
        public System.Byte BackSpace_ASCII() { return 8; }
        public PGMainMenu BackSpace() { return this; }
        public PGMainMenu BackSpace_Down() { return this.__Down(this.BackSpace_ASCII()); }
        public PGMainMenu BackSpace_Up() { return this.__Up(this.BackSpace_ASCII()); }
        public bool BackSpace_Is() { return this.__Is(this.BackSpace_ASCII()); }
        public PGMainMenu BackSpace_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn214.Background = Brushes.White); return this; }
        public PGMainMenu BackSpace_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn214.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu BackSpace_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn214.Background = Brushes.Green); return this; }
        private void Btn214_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn214"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(Tab, 9, Btn31)
        public System.String Tab_String() { return "Tab"; }
        public System.Byte Tab_ASCII() { return 9; }
        public PGMainMenu Tab() { return this; }
        public PGMainMenu Tab_Down() { return this.__Down(this.Tab_ASCII()); }
        public PGMainMenu Tab_Up() { return this.__Up(this.Tab_ASCII()); }
        public bool Tab_Is() { return this.__Is(this.Tab_ASCII()); }
        public PGMainMenu Tab_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn31.Background = Brushes.White); return this; }
        public PGMainMenu Tab_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn31.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu Tab_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn31.Background = Brushes.Green); return this; }
        private void Btn31_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn31"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(LeftCTRL, 162, Btn61)
        public System.String LeftCTRL_String() { return "LeftCTRL"; }
        public System.Byte LeftCTRL_ASCII() { return 162; }
        public PGMainMenu LeftCTRL() { return this; }
        public PGMainMenu LeftCTRL_Down() { return this.__Down(this.LeftCTRL_ASCII()); }
        public PGMainMenu LeftCTRL_Up() { return this.__Up(this.LeftCTRL_ASCII()); }
        public bool LeftCTRL_Is() { return this.__Is(this.LeftCTRL_ASCII()); }
        public PGMainMenu LeftCTRL_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn61.Background = Brushes.White); return this; }
        public PGMainMenu LeftCTRL_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn61.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu LeftCTRL_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn61.Background = Brushes.Green); return this; }
        private void Btn61_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn61"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(RightCTRL, 163, Btn67)
        public System.String RightCTRL_String() { return "RightCTRL"; }
        public System.Byte RightCTRL_ASCII() { return 163; }
        public PGMainMenu RightCTRL() { return this; }
        public PGMainMenu RightCTRL_Down() { return this.__Down(this.RightCTRL_ASCII()); }
        public PGMainMenu RightCTRL_Up() { return this.__Up(this.RightCTRL_ASCII()); }
        public bool RightCTRL_Is() { return this.__Is(this.RightCTRL_ASCII()); }
        public PGMainMenu RightCTRL_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn67.Background = Brushes.White); return this; }
        public PGMainMenu RightCTRL_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn67.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu RightCTRL_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn67.Background = Brushes.Green); return this; }
        private void Btn67_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn67"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(LeftAlt, 164, Btn63)
        public System.String LeftAlt_String() { return "LeftAlt"; }
        public System.Byte LeftAlt_ASCII() { return 164; }
        public PGMainMenu LeftAlt() { return this; }
        public PGMainMenu LeftAlt_Down() { return this.__Down(this.LeftAlt_ASCII()); }
        public PGMainMenu LeftAlt_Up() { return this.__Up(this.LeftAlt_ASCII()); }
        public bool LeftAlt_Is() { return this.__Is(this.LeftAlt_ASCII()); }
        public PGMainMenu LeftAlt_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn63.Background = Brushes.White); return this; }
        public PGMainMenu LeftAlt_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn63.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu LeftAlt_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn63.Background = Brushes.Green); return this; }
        private void Btn63_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn63"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(RightAlt, 165, Btn65)
        public System.String RightAlt_String() { return "RightAlt"; }
        public System.Byte RightAlt_ASCII() { return 165; }
        public PGMainMenu RightAlt() { return this; }
        public PGMainMenu RightAlt_Down() { return this.__Down(this.RightAlt_ASCII()); }
        public PGMainMenu RightAlt_Up() { return this.__Up(this.RightAlt_ASCII()); }
        public bool RightAlt_Is() { return this.__Is(this.RightAlt_ASCII()); }
        public PGMainMenu RightAlt_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn65.Background = Brushes.White); return this; }
        public PGMainMenu RightAlt_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn65.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu RightAlt_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn65.Background = Brushes.Green); return this; }
        private void Btn65_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn65"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(Pause, 19, Btn116)
        public System.String Pause_String() { return "Pause"; }
        public System.Byte Pause_ASCII() { return 19; }
        public PGMainMenu Pause() { return this; }
        public PGMainMenu Pause_Down() { return this.__Down(this.Pause_ASCII()); }
        public PGMainMenu Pause_Up() { return this.__Up(this.Pause_ASCII()); }
        public bool Pause_Is() { return this.__Is(this.Pause_ASCII()); }
        public PGMainMenu Pause_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn116.Background = Brushes.White); return this; }
        public PGMainMenu Pause_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn116.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu Pause_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn116.Background = Brushes.Green); return this; }
        private void Btn116_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn116"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(CapsLock, 20, Btn41)
        public System.String CapsLock_String() { return "CapsLock"; }
        public System.Byte CapsLock_ASCII() { return 20; }
        public PGMainMenu CapsLock() { return this; }
        public PGMainMenu CapsLock_Down() { return this.__Down(this.CapsLock_ASCII()); }
        public PGMainMenu CapsLock_Up() { return this.__Up(this.CapsLock_ASCII()); }
        public bool CapsLock_Is() { return this.__Is(this.CapsLock_ASCII()); }
        public PGMainMenu CapsLock_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn41.Background = Brushes.White); return this; }
        public PGMainMenu CapsLock_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn41.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu CapsLock_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn41.Background = Brushes.Green); return this; }
        private void Btn41_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn41"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(PageUp, 33, Btn217)
        public System.String PageUp_String() { return "PageUp"; }
        public System.Byte PageUp_ASCII() { return 33; }
        public PGMainMenu PageUp() { return this; }
        public PGMainMenu PageUp_Down() { return this.__Down(this.PageUp_ASCII()); }
        public PGMainMenu PageUp_Up() { return this.__Up(this.PageUp_ASCII()); }
        public bool PageUp_Is() { return this.__Is(this.PageUp_ASCII()); }
        public PGMainMenu PageUp_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn217.Background = Brushes.White); return this; }
        public PGMainMenu PageUp_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn217.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu PageUp_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn217.Background = Brushes.Green); return this; }
        private void Btn217_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn217"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(PageDown, 34, Btn317)
        public System.String PageDown_String() { return "PageDown"; }
        public System.Byte PageDown_ASCII() { return 34; }
        public PGMainMenu PageDown() { return this; }
        public PGMainMenu PageDown_Down() { return this.__Down(this.PageDown_ASCII()); }
        public PGMainMenu PageDown_Up() { return this.__Up(this.PageDown_ASCII()); }
        public bool PageDown_Is() { return this.__Is(this.PageDown_ASCII()); }
        public PGMainMenu PageDown_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn317.Background = Brushes.White); return this; }
        public PGMainMenu PageDown_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn317.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu PageDown_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn317.Background = Brushes.Green); return this; }
        private void Btn317_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn317"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(End, 35, Btn316)
        public System.String End_String() { return "End"; }
        public System.Byte End_ASCII() { return 35; }
        public PGMainMenu End() { return this; }
        public PGMainMenu End_Down() { return this.__Down(this.End_ASCII()); }
        public PGMainMenu End_Up() { return this.__Up(this.End_ASCII()); }
        public bool End_Is() { return this.__Is(this.End_ASCII()); }
        public PGMainMenu End_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn316.Background = Brushes.White); return this; }
        public PGMainMenu End_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn316.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu End_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn316.Background = Brushes.Green); return this; }
        private void Btn316_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn316"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(Home, 36, Btn216)
        public System.String Home_String() { return "Home"; }
        public System.Byte Home_ASCII() { return 36; }
        public PGMainMenu Home() { return this; }
        public PGMainMenu Home_Down() { return this.__Down(this.Home_ASCII()); }
        public PGMainMenu Home_Up() { return this.__Up(this.Home_ASCII()); }
        public bool Home_Is() { return this.__Is(this.Home_ASCII()); }
        public PGMainMenu Home_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn216.Background = Brushes.White); return this; }
        public PGMainMenu Home_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn216.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu Home_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn216.Background = Brushes.Green); return this; }
        private void Btn216_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn216"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(ArrowUp, 38, Btn513)
        public System.String ArrowUp_String() { return "ArrowUp"; }
        public System.Byte ArrowUp_ASCII() { return 38; }
        public PGMainMenu ArrowUp() { return this; }
        public PGMainMenu ArrowUp_Down() { return this.__Down(this.ArrowUp_ASCII()); }
        public PGMainMenu ArrowUp_Up() { return this.__Up(this.ArrowUp_ASCII()); }
        public bool ArrowUp_Is() { return this.__Is(this.ArrowUp_ASCII()); }
        public PGMainMenu ArrowUp_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn513.Background = Brushes.White); return this; }
        public PGMainMenu ArrowUp_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn513.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu ArrowUp_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn513.Background = Brushes.Green); return this; }
        private void Btn513_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn513"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(ArrowLeft, 37, Btn68)
        public System.String ArrowLeft_String() { return "ArrowLeft"; }
        public System.Byte ArrowLeft_ASCII() { return 37; }
        public PGMainMenu ArrowLeft() { return this; }
        public PGMainMenu ArrowLeft_Down() { return this.__Down(this.ArrowLeft_ASCII()); }
        public PGMainMenu ArrowLeft_Up() { return this.__Up(this.ArrowLeft_ASCII()); }
        public bool ArrowLeft_Is() { return this.__Is(this.ArrowLeft_ASCII()); }
        public PGMainMenu ArrowLeft_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn68.Background = Brushes.White); return this; }
        public PGMainMenu ArrowLeft_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn68.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu ArrowLeft_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn68.Background = Brushes.Green); return this; }
        private void Btn68_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn68"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(ArrowRight, 39, Btn610)
        public System.String ArrowRight_String() { return "ArrowRight"; }
        public System.Byte ArrowRight_ASCII() { return 39; }
        public PGMainMenu ArrowRight() { return this; }
        public PGMainMenu ArrowRight_Down() { return this.__Down(this.ArrowRight_ASCII()); }
        public PGMainMenu ArrowRight_Up() { return this.__Up(this.ArrowRight_ASCII()); }
        public bool ArrowRight_Is() { return this.__Is(this.ArrowRight_ASCII()); }
        public PGMainMenu ArrowRight_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn610.Background = Brushes.White); return this; }
        public PGMainMenu ArrowRight_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn610.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu ArrowRight_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn610.Background = Brushes.Green); return this; }
        private void Btn610_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn610"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(ArrowDown, 40, Btn69)
        public System.String ArrowDown_String() { return "ArrowDown"; }
        public System.Byte ArrowDown_ASCII() { return 40; }
        public PGMainMenu ArrowDown() { return this; }
        public PGMainMenu ArrowDown_Down() { return this.__Down(this.ArrowDown_ASCII()); }
        public PGMainMenu ArrowDown_Up() { return this.__Up(this.ArrowDown_ASCII()); }
        public bool ArrowDown_Is() { return this.__Is(this.ArrowDown_ASCII()); }
        public PGMainMenu ArrowDown_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn69.Background = Brushes.White); return this; }
        public PGMainMenu ArrowDown_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn69.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu ArrowDown_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn69.Background = Brushes.Green); return this; }
        private void Btn69_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn69"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(Insert, 45, Btn215)
        public System.String Insert_String() { return "Insert"; }
        public System.Byte Insert_ASCII() { return 45; }
        public PGMainMenu Insert() { return this; }
        public PGMainMenu Insert_Down() { return this.__Down(this.Insert_ASCII()); }
        public PGMainMenu Insert_Up() { return this.__Up(this.Insert_ASCII()); }
        public bool Insert_Is() { return this.__Is(this.Insert_ASCII()); }
        public PGMainMenu Insert_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn215.Background = Brushes.White); return this; }
        public PGMainMenu Insert_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn215.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu Insert_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn215.Background = Brushes.Green); return this; }
        private void Btn215_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn215"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(Delete, 46, Btn315)
        public System.String Delete_String() { return "Delete"; }
        public System.Byte Delete_ASCII() { return 46; }
        public PGMainMenu Delete() { return this; }
        public PGMainMenu Delete_Down() { return this.__Down(this.Delete_ASCII()); }
        public PGMainMenu Delete_Up() { return this.__Up(this.Delete_ASCII()); }
        public bool Delete_Is() { return this.__Is(this.Delete_ASCII()); }
        public PGMainMenu Delete_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn315.Background = Brushes.White); return this; }
        public PGMainMenu Delete_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn315.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu Delete_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn315.Background = Brushes.Green); return this; }
        private void Btn315_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn315"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(LeftWin, 91, Btn62)
        public System.String LeftWin_String() { return "LeftWin"; }
        public System.Byte LeftWin_ASCII() { return 91; }
        public PGMainMenu LeftWin() { return this; }
        public PGMainMenu LeftWin_Down() { return this.__Down(this.LeftWin_ASCII()); }
        public PGMainMenu LeftWin_Up() { return this.__Up(this.LeftWin_ASCII()); }
        public bool LeftWin_Is() { return this.__Is(this.LeftWin_ASCII()); }
        public PGMainMenu LeftWin_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn62.Background = Brushes.White); return this; }
        public PGMainMenu LeftWin_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn62.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu LeftWin_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn62.Background = Brushes.Green); return this; }
        private void Btn62_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn62"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(RightWin, 92, Btn66)
        public System.String RightWin_String() { return "RightWin"; }
        public System.Byte RightWin_ASCII() { return 92; }
        public PGMainMenu RightWin() { return this; }
        public PGMainMenu RightWin_Down() { return this.__Down(this.RightWin_ASCII()); }
        public PGMainMenu RightWin_Up() { return this.__Up(this.RightWin_ASCII()); }
        public bool RightWin_Is() { return this.__Is(this.RightWin_ASCII()); }
        public PGMainMenu RightWin_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn66.Background = Brushes.White); return this; }
        public PGMainMenu RightWin_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn66.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu RightWin_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn66.Background = Brushes.Green); return this; }
        private void Btn66_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn66"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(PrintScreen, 154, Btn114)
        public System.String PrintScreen_String() { return "PrintScreen"; }
        public System.Byte PrintScreen_ASCII() { return 154; }
        public PGMainMenu PrintScreen() { return this; }
        public PGMainMenu PrintScreen_Down() { return this.__Down(this.PrintScreen_ASCII()); }
        public PGMainMenu PrintScreen_Up() { return this.__Up(this.PrintScreen_ASCII()); }
        public bool PrintScreen_Is() { return this.__Is(this.PrintScreen_ASCII()); }
        public PGMainMenu PrintScreen_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn114.Background = Brushes.White); return this; }
        public PGMainMenu PrintScreen_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn114.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu PrintScreen_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn114.Background = Brushes.Green); return this; }
        private void Btn114_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn114"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(ScrollLock, 145, Btn115)
        public System.String ScrollLock_String() { return "ScrollLock"; }
        public System.Byte ScrollLock_ASCII() { return 145; }
        public PGMainMenu ScrollLock() { return this; }
        public PGMainMenu ScrollLock_Down() { return this.__Down(this.ScrollLock_ASCII()); }
        public PGMainMenu ScrollLock_Up() { return this.__Up(this.ScrollLock_ASCII()); }
        public bool ScrollLock_Is() { return this.__Is(this.ScrollLock_ASCII()); }
        public PGMainMenu ScrollLock_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn115.Background = Brushes.White); return this; }
        public PGMainMenu ScrollLock_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn115.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu ScrollLock_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn115.Background = Brushes.Green); return this; }
        private void Btn115_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn115"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(LeftMouse, 1, MouseBtnLeft)
        public System.String LeftMouse_String() { return "LeftMouse"; }
        public System.Byte LeftMouse_ASCII() { return 1; }
        public PGMainMenu LeftMouse() { return this; }
        public PGMainMenu LeftMouse_Down() { return this.__Down(this.LeftMouse_ASCII()); }
        public PGMainMenu LeftMouse_Up() { return this.__Up(this.LeftMouse_ASCII()); }
        public bool LeftMouse_Is() { return this.__Is(this.LeftMouse_ASCII()); }
        public PGMainMenu LeftMouse_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.MouseBtnLeft.Background = Brushes.White); return this; }
        public PGMainMenu LeftMouse_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.MouseBtnLeft.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu LeftMouse_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.MouseBtnLeft.Background = Brushes.Green); return this; }
        private void MouseBtnLeft_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("MouseBtnLeft"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(RightMouse, 2, MouseBtnRight)
        public System.String RightMouse_String() { return "RightMouse"; }
        public System.Byte RightMouse_ASCII() { return 2; }
        public PGMainMenu RightMouse() { return this; }
        public PGMainMenu RightMouse_Down() { return this.__Down(this.RightMouse_ASCII()); }
        public PGMainMenu RightMouse_Up() { return this.__Up(this.RightMouse_ASCII()); }
        public bool RightMouse_Is() { return this.__Is(this.RightMouse_ASCII()); }
        public PGMainMenu RightMouse_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.MouseBtnRight.Background = Brushes.White); return this; }
        public PGMainMenu RightMouse_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.MouseBtnRight.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu RightMouse_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.MouseBtnRight.Background = Brushes.Green); return this; }
        private void MouseBtnRight_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("MouseBtnRight"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(Equally, 187, Btn213)
        public System.String Equally_String() { return "Equally"; }
        public System.Byte Equally_ASCII() { return 187; }
        public PGMainMenu Equally() { return this; }
        public PGMainMenu Equally_Down() { return this.__Down(this.Equally_ASCII()); }
        public PGMainMenu Equally_Up() { return this.__Up(this.Equally_ASCII()); }
        public bool Equally_Is() { return this.__Is(this.Equally_ASCII()); }
        public PGMainMenu Equally_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn213.Background = Brushes.White); return this; }
        public PGMainMenu Equally_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn213.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu Equally_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn213.Background = Brushes.Green); return this; }
        private void Btn213_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn213"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(Minus, 189, Btn212)
        public System.String Minus_String() { return "Minus"; }
        public System.Byte Minus_ASCII() { return 189; }
        public PGMainMenu Minus() { return this; }
        public PGMainMenu Minus_Down() { return this.__Down(this.Minus_ASCII()); }
        public PGMainMenu Minus_Up() { return this.__Up(this.Minus_ASCII()); }
        public bool Minus_Is() { return this.__Is(this.Minus_ASCII()); }
        public PGMainMenu Minus_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn212.Background = Brushes.White); return this; }
        public PGMainMenu Minus_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn212.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu Minus_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn212.Background = Brushes.Green); return this; }
        private void Btn212_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn212"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(Сomma, 188, Btn59)
        public System.String Сomma_String() { return "Сomma"; }
        public System.Byte Сomma_ASCII() { return 188; }
        public PGMainMenu Сomma() { return this; }
        public PGMainMenu Сomma_Down() { return this.__Down(this.Сomma_ASCII()); }
        public PGMainMenu Сomma_Up() { return this.__Up(this.Сomma_ASCII()); }
        public bool Сomma_Is() { return this.__Is(this.Сomma_ASCII()); }
        public PGMainMenu Сomma_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn59.Background = Brushes.White); return this; }
        public PGMainMenu Сomma_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn59.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu Сomma_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn59.Background = Brushes.Green); return this; }
        private void Btn59_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn59"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(Dot, 190, Btn510)
        public System.String Dot_String() { return "Dot"; }
        public System.Byte Dot_ASCII() { return 190; }
        public PGMainMenu Dot() { return this; }
        public PGMainMenu Dot_Down() { return this.__Down(this.Dot_ASCII()); }
        public PGMainMenu Dot_Up() { return this.__Up(this.Dot_ASCII()); }
        public bool Dot_Is() { return this.__Is(this.Dot_ASCII()); }
        public PGMainMenu Dot_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn510.Background = Brushes.White); return this; }
        public PGMainMenu Dot_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn510.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu Dot_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn510.Background = Brushes.Green); return this; }
        private void Btn510_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn510"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(PeriodComma, 186, Btn411)
        public System.String PeriodComma_String() { return "PeriodComma"; }
        public System.Byte PeriodComma_ASCII() { return 186; }
        public PGMainMenu PeriodComma() { return this; }
        public PGMainMenu PeriodComma_Down() { return this.__Down(this.PeriodComma_ASCII()); }
        public PGMainMenu PeriodComma_Up() { return this.__Up(this.PeriodComma_ASCII()); }
        public bool PeriodComma_Is() { return this.__Is(this.PeriodComma_ASCII()); }
        public PGMainMenu PeriodComma_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn411.Background = Brushes.White); return this; }
        public PGMainMenu PeriodComma_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn411.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu PeriodComma_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn411.Background = Brushes.Green); return this; }
        private void Btn411_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn411"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(Tilda, 192, Btn21)
        public System.String Tilda_String() { return "Tilda"; }
        public System.Byte Tilda_ASCII() { return 192; }
        public PGMainMenu Tilda() { return this; }
        public PGMainMenu Tilda_Down() { return this.__Down(this.Tilda_ASCII()); }
        public PGMainMenu Tilda_Up() { return this.__Up(this.Tilda_ASCII()); }
        public bool Tilda_Is() { return this.__Is(this.Tilda_ASCII()); }
        public PGMainMenu Tilda_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn21.Background = Brushes.White); return this; }
        public PGMainMenu Tilda_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn21.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu Tilda_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn21.Background = Brushes.Green); return this; }
        private void Btn21_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn21"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(SquScobOtk, 219, Btn312)
        public System.String SquScobOtk_String() { return "SquScobOtk"; }
        public System.Byte SquScobOtk_ASCII() { return 219; }
        public PGMainMenu SquScobOtk() { return this; }
        public PGMainMenu SquScobOtk_Down() { return this.__Down(this.SquScobOtk_ASCII()); }
        public PGMainMenu SquScobOtk_Up() { return this.__Up(this.SquScobOtk_ASCII()); }
        public bool SquScobOtk_Is() { return this.__Is(this.SquScobOtk_ASCII()); }
        public PGMainMenu SquScobOtk_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn312.Background = Brushes.White); return this; }
        public PGMainMenu SquScobOtk_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn312.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu SquScobOtk_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn312.Background = Brushes.Green); return this; }
        private void Btn312_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn312"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(SquScobZak, 221, Btn313)
        public System.String SquScobZak_String() { return "SquScobZak"; }
        public System.Byte SquScobZak_ASCII() { return 221; }
        public PGMainMenu SquScobZak() { return this; }
        public PGMainMenu SquScobZak_Down() { return this.__Down(this.SquScobZak_ASCII()); }
        public PGMainMenu SquScobZak_Up() { return this.__Up(this.SquScobZak_ASCII()); }
        public bool SquScobZak_Is() { return this.__Is(this.SquScobZak_ASCII()); }
        public PGMainMenu SquScobZak_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn313.Background = Brushes.White); return this; }
        public PGMainMenu SquScobZak_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn313.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu SquScobZak_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn313.Background = Brushes.Green); return this; }
        private void Btn313_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn313"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(Slash, 191, Btn511)
        public System.String Slash_String() { return "Slash"; }
        public System.Byte Slash_ASCII() { return 191; }
        public PGMainMenu Slash() { return this; }
        public PGMainMenu Slash_Down() { return this.__Down(this.Slash_ASCII()); }
        public PGMainMenu Slash_Up() { return this.__Up(this.Slash_ASCII()); }
        public bool Slash_Is() { return this.__Is(this.Slash_ASCII()); }
        public PGMainMenu Slash_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn511.Background = Brushes.White); return this; }
        public PGMainMenu Slash_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn511.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu Slash_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn511.Background = Brushes.Green); return this; }
        private void Btn511_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn511"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(ObratSlash, 220, Btn314)
        public System.String ObratSlash_String() { return "ObratSlash"; }
        public System.Byte ObratSlash_ASCII() { return 220; }
        public PGMainMenu ObratSlash() { return this; }
        public PGMainMenu ObratSlash_Down() { return this.__Down(this.ObratSlash_ASCII()); }
        public PGMainMenu ObratSlash_Up() { return this.__Up(this.ObratSlash_ASCII()); }
        public bool ObratSlash_Is() { return this.__Is(this.ObratSlash_ASCII()); }
        public PGMainMenu ObratSlash_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn314.Background = Brushes.White); return this; }
        public PGMainMenu ObratSlash_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn314.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu ObratSlash_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn314.Background = Brushes.Green); return this; }
        private void Btn314_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn314"); }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //(Mark, 222, Btn412)
        public System.String Mark_String() { return "Mark"; }
        public System.Byte Mark_ASCII() { return 222; }
        public PGMainMenu Mark() { return this; }
        public PGMainMenu Mark_Down() { return this.__Down(this.Mark_ASCII()); }
        public PGMainMenu Mark_Up() { return this.__Up(this.Mark_ASCII()); }
        public bool Mark_Is() { return this.__Is(this.Mark_ASCII()); }
        public PGMainMenu Mark_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn412.Background = Brushes.White); return this; }
        public PGMainMenu Mark_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn412.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu Mark_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn412.Background = Brushes.Green); return this; }
        private void Btn412_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn412"); }
   
        
        

        
    }
}
