using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClickerManDVA_DVA
{
    public class VKeyboard: IVCommander
    {
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);
        [DllImport("user32.dll")]
        private static extern short GetKeyState(int nVirtKey);
        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
        //////////////////////////////////////////////////////////////////////////////////////////
        public byte p_nVirtKey = 65;//A
        public string p__Str = "A";
        public string p_Str { get { return this.p__Str; } set { this.p__Str = value; } }
        public System.TimeSpan p__TimeSpan;
        public System.TimeSpan p_TimeSpan { get { return this.p__TimeSpan; } set { this.p__TimeSpan = value; } }
        //////////////////////////////////////////////////////////////////////////////////////////
        public VKeyboard() {}
        public VKeyboard Set(
            VKeyboard _this=null
            , System.Nullable<System.Byte> _nVirtKey = null
            , System.String _Str = null
            , System.Nullable<System.TimeSpan> _TimeSpan = null
            )
        {
            if (_this != null) this.Set(_this:null, _nVirtKey:_this.p_nVirtKey,_Str:_this.p__Str,_TimeSpan:_this.p_TimeSpan);
            if (_nVirtKey!=null) this.p_nVirtKey = _nVirtKey.Value;
            if (_Str != null) this.p__Str = _Str;
            if (_TimeSpan!=null) this.p_TimeSpan = _TimeSpan.Value;
            return this;
        }
        //////////////////////////////////////////////////////////////////////////////////////////
        IVCommander IVCommander.Set_TimeSpan(System.TimeSpan _TimeSpan) { return this.Set(_TimeSpan:_TimeSpan);}
        public VKeyboard Set_TimeSpan(System.TimeSpan _TimeSpan){return this.Set(_TimeSpan: _TimeSpan);}
        System.Object INewEable.New() { return this.New(); }
        public VKeyboard New() { return new VKeyboard(); }
        System.Object ICloneable.Clone() { return this.Clone(); }
        public VKeyboard Clone() {return this.New().Set(_this:this);}
        //////////////////////////////////////////////////////////////////////////////////////////
        System.Boolean IVCommander.Is()
        { switch (GetKeyState(this.p_nVirtKey)) { case -127: case -128: return true; break; default: return false; break; } return false; }
        public System.Boolean Is()
        { switch (GetKeyState(this.p_nVirtKey)){ case -127: case -128: return true; break; default: return false; break; } return false; }
        //////////////////////////////////////////////////////////////////////////////////////////
        VKeyboard IVCommander.GetAsVKeyboard() {return this;}
        public VKeyboard GetAsVCommander() { return this; }
        VMouse IVCommander.GetAsVMouse() { return null; }
        public VMouse GetAsVMouse() { return null; }
    }
}