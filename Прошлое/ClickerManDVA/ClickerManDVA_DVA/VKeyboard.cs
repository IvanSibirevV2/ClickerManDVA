using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClickerManDVA_DVA
{
    public class VKeyboard : IVCommander, INewEable, ICloneable
    {
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);
        [DllImport("user32.dll")]
        private static extern short GetKeyState(int nVirtKey);
        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
        //////////////////////////////////////////////////////////////////////////////////////////
        private System.Byte p__nVirtKey = 65;//A
        public System.Byte p_nVirtKey { get { return this.p__nVirtKey; } set { this.p__nVirtKey = value; } }
        private System.String p__Str = "A";
        public System.String p_Str { get { return this.p__Str; } set { this.p__Str = value; } }
        private System.TimeSpan p__TimeSpan;
        public System.TimeSpan p_TimeSpan { get { return this.p__TimeSpan; } set { this.p__TimeSpan = value; } }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        public VKeyboard() { }
        public VKeyboard(System.Byte _nVirtKey, System.String _Str){this.p__nVirtKey = _nVirtKey;this.p__Str = _Str;}

        public VKeyboard Set(
            VKeyboard _this = null,
            System.Nullable<System.Byte> _nVirtKey = null,
            System.String _Str = null,
            System.Nullable<System.TimeSpan> _TimeSpan = null
            )
        {
            if (_this != null) this.Set(_this: null, _nVirtKey: _this.p__nVirtKey, _Str: _this.p__Str, _TimeSpan: _this.p__TimeSpan);
            if (_nVirtKey != null) this.p__nVirtKey = _nVirtKey.Value;
            if (_Str != null) this.p__Str = _Str;
            if (_TimeSpan != null) this.p__TimeSpan = _TimeSpan.Value;
            if (false) ;
            return this;
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        public VKeyboard Down() { keybd_event(this.p_nVirtKey, 0, 0, 0); return this; }
        public VKeyboard Up() { keybd_event(this.p_nVirtKey, 0, 2, 0); return this; }
        public static void Test_Down_Up() 
        {
            new VKeyboard().Set(_nVirtKey: 65, _Str: "A").Down().Up();
            "".ReadLine();
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        public VKeyboard New() { return new VKeyboard(); }
        System.Object INewEable.New() { return this.New(); }
        public VKeyboard Clone() {; return this.New().Set(_this: this); }
        System.Object ICloneable.Clone() { return this.Clone(); }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}