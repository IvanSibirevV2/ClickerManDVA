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

using System.Threading;
using System.Windows.Media.Media3D;
#endregion

namespace WpfDiplom.Pages
{
    public partial class PGMainMenu : System.Windows.Controls.Page
    {
        [DllImport("User32.Dll")]
        private static extern long SetCursorPos(int x, int y);
        public PGMainMenu Set_CursorPos(XY _XY) { SetCursorPos(_XY.X, _XY.Y); return this; }
        [StructLayout(LayoutKind.Sequential)]
        public struct XY { public int X; public int Y; }
        [DllImport("User32.Dll")]
        private static extern bool GetCursorPos(out XY lpPoint);
        private PGMainMenu GetCursorPos() {this.p_Last_XY = this.p_Now_XY;GetCursorPos(out this.p_Now_XY);return this;}
        private XY p_Last_XY = new XY();
        private XY p_Now_XY = new XY();
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //("MouseMoveX", XXX, MouseArrowRight)
        public System.String MouseMoveX_String() { return "MouseMoveX"; }
        public PGMainMenu MouseMoveX() { return this; }
        public PGMainMenu MouseMoveX_Down() { return this; }
        public PGMainMenu MouseMoveX_Up() { return this; }
        public bool MouseMoveX_Is() {return this.p_Last_XY.X < this.p_Now_XY.X; }
        public PGMainMenu MouseMoveX_Set_Background_White() { Dispatcher.InvokeAsync(() => this.MouseArrowRight.Background = Brushes.White); return this; }
        public PGMainMenu MouseMoveX_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.MouseArrowRight.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu MouseMoveX_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.MouseArrowRight.Background = Brushes.Green); return this; }
        private void MouseArrowRight_Click(object sender, RoutedEventArgs e) { }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //("MouseMoveNX", XXX, MouseArrowLeft)
        public System.String MouseMoveNX_String() { return "MouseMoveNX"; }
        public PGMainMenu MouseMoveNX() { return this; }
        public PGMainMenu MouseMoveNX_Down() { return this; }
        public PGMainMenu MouseMoveNX_Up() { return this; }
        public bool MouseMoveNX_Is() { return this.p_Last_XY.X > this.p_Now_XY.X; }
        public PGMainMenu MouseMoveNX_Set_Background_White() { Dispatcher.InvokeAsync(() => this.MouseArrowLeft.Background = Brushes.White); return this; }
        public PGMainMenu MouseMoveNX_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.MouseArrowLeft.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu MouseMoveNX_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.MouseArrowLeft.Background = Brushes.Green); return this; }
        private void MouseArrowLeft_Click(object sender, RoutedEventArgs e) { }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //("MouseMoveY", XXX, MouseArrowDown_Click)
        public System.String MouseMoveY_String() { return "MouseMoveY"; }
        public PGMainMenu MouseMoveY() { return this; }
        public PGMainMenu MouseMoveY_Down() { return this; }
        public PGMainMenu MouseMoveY_Up() { return this; }
        public bool MouseMoveY_Is() { return this.p_Last_XY.Y < this.p_Now_XY.Y; }
        public PGMainMenu MouseMoveY_Set_Background_White() { Dispatcher.InvokeAsync(() => this.MouseArrowDown.Background = Brushes.White); return this; }
        public PGMainMenu MouseMoveY_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.MouseArrowDown.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu MouseMoveY_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.MouseArrowDown.Background = Brushes.Green); return this; }
        private void MouseArrowDown_Click(object sender, RoutedEventArgs e) { }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //("MouseMoveNY", XXX, MouseArrowUp_Click)
        public System.String MouseMoveNY_String() { return "MouseMoveNY"; }
        public PGMainMenu MouseMoveNY() { return this; }
        public PGMainMenu MouseMoveNY_Down() { return this; }
        public PGMainMenu MouseMoveNY_Up() { return this; }
        public bool MouseMoveNY_Is() { return this.p_Last_XY.Y > this.p_Now_XY.Y; }
        public PGMainMenu MouseMoveNY_Set_Background_White() { Dispatcher.InvokeAsync(() => this.MouseArrowUp.Background = Brushes.White); return this; }
        public PGMainMenu MouseMoveNY_Set_Background_Gray() { Dispatcher.InvokeAsync(() => this.MouseArrowUp.Background = Brushes.Yellow/*LightGray*/); return this; }
        public PGMainMenu MouseMoveNY_Set_Background_Green() { Dispatcher.InvokeAsync(() => this.MouseArrowUp.Background = Brushes.Green); return this; }
        private void MouseArrowUp_Click(object sender, RoutedEventArgs e) { }
    }
}
