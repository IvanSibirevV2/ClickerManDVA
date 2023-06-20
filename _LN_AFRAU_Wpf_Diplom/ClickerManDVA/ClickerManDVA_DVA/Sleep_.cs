using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerManDVA_DVA
{
    public class Sleep_: IVCommander, INewEable, ICloneable
    {   //////////////////////////////////////////////////////////////////////////////////////////
        private System.Int32 p__SleepTime = 50;
        public System.Int32 p_SleepTime { get { return this.p__SleepTime; } set { this.p__SleepTime = value; } }
        public System.Byte p_nVirtKey { get { return 0; } set {; } }
        private System.String p__Str = "Sleep_50";
        public System.String p_Str { get { return this.p__Str; } set { this.p__Str = value; } }
        private System.TimeSpan p__TimeSpan;
        public System.TimeSpan p_TimeSpan { get { return this.p__TimeSpan; } set { this.p__TimeSpan = value; } }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        public Sleep_() { }
        public Sleep_(System.Int32 _SleepTime,System.String _Str){this.p__SleepTime = _SleepTime;this.p__Str = _Str;}
        public Sleep_ Set(
            Sleep_ _this = null,
            System.Nullable<System.Int32> _SleepTime = null,
            System.String _Str = null,
            System.Nullable<System.TimeSpan> _TimeSpan = null
            )
        {
            if (_this != null) this.Set(_this: null, _SleepTime: this.p__SleepTime, _Str: this.p__Str, _TimeSpan: this.p__TimeSpan);
            if (_SleepTime != null) this.p__SleepTime = _SleepTime.Value;
            if (_Str != null) this.p__Str = _Str;
            if (_TimeSpan != null) this.p__TimeSpan = _TimeSpan.Value;
            return this;
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        public Sleep_ Up() { System.Threading.Thread.Sleep(this.p_SleepTime); return this; }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        public Sleep_ New() { return new Sleep_(); }
        System.Object INewEable.New() { return new Sleep_(); }
        public Sleep_ Clone() { return this.New().Set(_this: this); }
        System.Object ICloneable.Clone() { return this.New().Set(_this: this); }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}