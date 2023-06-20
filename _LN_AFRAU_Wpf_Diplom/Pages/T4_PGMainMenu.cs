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
        //(Slash, 191, Btn314)
        public System.String Slash_String() { return "Slash"; }
        public System.Byte Slash_ASCII() { return 191; }
        public PGMainMenu Slash() { return this; }
        public PGMainMenu Slash_Down() { return this.__Down(this.Slash_ASCII()); }
        public PGMainMenu Slash_Up() { return this.__Up(this.Slash_ASCII()); }
        public bool Slash_Is() { return this.__Is(this.Slash_ASCII()); }
        public PGMainMenu Slash_Set_Background_White() {Dispatcher.InvokeAsync(() =>this.Btn314.Background = Brushes.White); return this; }
        public PGMainMenu Slash_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.Btn314.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu Slash_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.Btn314.Background = Brushes.Green); return this; }
        private void Btn314_Click(object sender, RoutedEventArgs e) { if (this.p_TestMod_1) System.Windows.MessageBox.Show("Btn314"); }
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
      
        
        
        //////////////////////////////////////////////////////
        
        //////////////////////////////////////////////////////

        



    }
}
