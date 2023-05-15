using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClickerManDVA_DVA
{
    public class VMouseMove_ : IVCommander, INewEable, ICloneable
    {   //////////////////////////////////////////////////////////////////////////////////////////
        private System.Int32 p__MoveX = 00;
        public System.Int32 p_MoveX { get { return this.p__MoveX; } set { this.p__MoveX = value; } }
        private System.Int32 p__MoveY = 00;
        public System.Int32 p_MoveY { get { return this.p__MoveY; } set { this.p__MoveY = value; } }
        public System.Byte p_nVirtKey { get { return 0; } set { } }
        private System.String p__Str = "VMouseMove_";
        public System.String p_Str { get { return this.p__Str; } set { this.p__Str = value; } }
        private System.TimeSpan p__TimeSpan;
        public System.TimeSpan p_TimeSpan { get { return this.p__TimeSpan; } set { this.p__TimeSpan = value; } }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        [DllImport("User32.Dll")]
        private static extern long SetCursorPos(int x, int y);
        public VMouseMove_ Set_CursorPos(XY _XY) { SetCursorPos(_XY.X, _XY.Y); return this; }
        public delegate My_Set_CursorPos My_Set_CursorPos(int _X, int _Y);
        public My_Set_CursorPos Set_CursorPosM(int _X = 0, int _Y = 0) { SetCursorPos(_X, _Y); return Set_CursorPosM; }
        public VMouseMove_ Set_CursorPos(int _X = 0, int _Y = 0) { SetCursorPos(_X, _Y); return this; }
        /// <summary> System.Mouse.Test_Set_CursorPos(); /// </summary>
        public static void Test_Set_CursorPos()
        {
            new VMouseMove_().Set_CursorPosM(50, 50)(100, 100)(150, 150)(200, 200);
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        [StructLayout(LayoutKind.Sequential)]
        public struct XY { public int X; public int Y; }
        [DllImport("User32.Dll")]
        private static extern bool GetCursorPos(out XY lpPoint);
        public XY Get_CursorPos { get { XY _PointInter = new XY(); GetCursorPos(out _PointInter); return _PointInter; } }
        /// <summary> System.Mouse.Test_GetCursorPos(); /// </summary>
        public static void Test_GetCursorPos()
        {
            XY _PointInter = new VMouseMove_().Get_CursorPos;
            System.Console.WriteLine(_PointInter.X.ToString() + ";" + _PointInter.Y.ToString());
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////
        public VMouseMove_ Move(XY _DXY) { this.Set_CursorPos(new XY() { X = this.Get_CursorPos.X + _DXY.X, Y = this.Get_CursorPos.Y + _DXY.Y }); return this; }
        public delegate My_Move My_Move(int _X, int _Y);
        public My_Move MoveM(int DX = 0, int DY = 0) { this.Set_CursorPos(this.Get_CursorPos.X + DX, this.Get_CursorPos.Y + DY); return MoveM; }
        public VMouseMove_ Move(int DX = 0, int DY = 0) { this.Set_CursorPos(this.Get_CursorPos.X + DX, this.Get_CursorPos.Y + DY); return this; }
        /// <summary> ClickerManDVA_DVA.VMouseMove_.Test_Move(); /// </summary>
        public static void Test_Move()
        {
            new VMouseMove_()
               .MoveM
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
               (+50, 0)(0, +50)(-50, 0)(0, -50)
           ;
        }

        //////////////////////////////////////////////////////////////////////////////////////////////////////////
        public VMouseMove_() { }
        public VMouseMove_ Set(
            VMouseMove_ _this = null,
            System.Nullable<System.Int32> _MoveX = null,
            System.Nullable<System.Int32> _MoveY = null,
            System.String _Str = null,
            System.Nullable<System.TimeSpan> _TimeSpan = null
            )
        {
            if (_this != null) this.Set(_this:null,_MoveX:_this.p_MoveX,_MoveY:_this.p__MoveY,_Str:_this.p__Str,_TimeSpan:_this.p__TimeSpan);
            if (_MoveX != null) this.p__MoveX=_MoveX.Value;
            if (_MoveY != null) this.p__MoveY = _MoveY.Value;
            if (_Str != null) this.p__Str = _Str;
            if (_TimeSpan != null) this.p_TimeSpan = _TimeSpan.Value; 
            if (false) ;
            ;
            return this;
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        public VMouseMove_ Down()
        {
            this.MoveM
               (this.p_MoveX, this.p_MoveY);
            return this; }
        public VMouseMove_ Up() { return this; }
        public static void Test_Down_Up() 
        {
            new VKeyboard().Set(_nVirtKey: 65, _Str: "A").Down().Up();
            "".ReadLine();
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        public VMouseMove_ New() { return new VMouseMove_(); }
        System.Object INewEable.New() { return this.New(); }
        public VMouseMove_ Clone() {; return this.New().Set(_this: this); }
        System.Object ICloneable.Clone() { return this.Clone(); }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}