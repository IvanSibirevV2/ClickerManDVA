using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClickerManDVA_DVA
{
    public class VKeyboard : VCommander, IVCommander
    {
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);
        [DllImport("user32.dll")]
        private static extern short GetKeyState(int nVirtKey);
        [DllImport("user32.dll")]
        private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);
        //////////////////////////////////////////////////////////////////////////////////////////
        public VKeyboard() 
        {
            this.Is = () => {
                switch (GetKeyState(this.p_nVirtKey)) { case -127:case -128:return true; break; default:return false; break;}
                return false;
            };
        }
        public VKeyboard Set(
            VKeyboard _this = null
            , System.Nullable<System.Byte> _nVirtKey = null
            , System.String _Str = null
            , System.Nullable<System.TimeSpan> _TimeSpan = null
            )
        {
            if (_this != null) this.Set(_this: null, _nVirtKey: _this.p_nVirtKey, _Str: _this.p_Str, _TimeSpan: _this.p_TimeSpan);
            if (_nVirtKey != null) this.p_nVirtKey = _nVirtKey.Value;
            if (_Str != null) this.p_Str = _Str;
            if (_TimeSpan != null) this.p_TimeSpan = _TimeSpan.Value;
            return this;
        }
        //////////////////////////////////////////////////////////////////////////////////////////
        System.Object INewEable.New() { return this.New(); }
        public VKeyboard New() { return new VKeyboard(); }
        System.Object ICloneable.Clone() { return this.Clone(); }
        public VKeyboard Clone() { return this.New().Set(_this: this); }
        //////////////////////////////////////////////////////////////////////////////////////////
    }
}