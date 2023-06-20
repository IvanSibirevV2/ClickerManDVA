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


        


    }
}
 