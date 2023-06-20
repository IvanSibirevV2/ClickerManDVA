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


    }
}
