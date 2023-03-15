
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.IO;
using static System.Mouse;

namespace System
{
    [StructLayout(LayoutKind.Sequential)]
    public struct XY { public int X; public int Y; }
    //Klava_Mouse
    public partial class Klava
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////////
        public XY p_Mouse_XY = new XY() { X = 0, Y = 0 };
        public XY p_Mouse_Last_XY = new XY() { X = 0, Y = 0 };
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport("User32.Dll")]
        private static extern long SetCursorPos(int x, int y);
        public Klava Set_Mouse_CursorPos(int _X, int _Y) { SetCursorPos(_X, _Y); return this; }
        public Klava Set_Mouse_CursorPos(XY _XY) { SetCursorPos(_XY.X, _XY.Y); return this; }
        public Klava Set_Mouse_CursorPos() { SetCursorPos(this.p_Mouse_XY.X, this.p_Mouse_XY.Y); return this; }
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport("User32.Dll")]
        private static extern bool GetCursorPos(out XY lpPoint);
        public Klava Get_Mouse_CursorPos() { this.p_Mouse_Last_XY = this.p_Mouse_XY; GetCursorPos(out this.p_Mouse_XY); return this; }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////
        public Klava Set_Mouse_DeMove(int DX = 0, int DY = 0)
        {
            this.p_Mouse_XY.X += DX; this.p_Mouse_XY.Y += DY;
            this.Set_Mouse_CursorPos(this.p_Mouse_XY);
            return this;
        }
    }
}