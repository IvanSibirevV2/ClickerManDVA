using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerManDVA_DVA
{
    public class Sleep_50 : IVCommander, INewEable, ICloneable
    {   //////////////////////////////////////////////////////////////////////////////////////////
        public System.Byte p_nVirtKey { get { return 0; } set {; } }
        private System.String p__Str = "Sleep_50";
        public System.String p_Str { get { return this.p__Str; } set { this.p__Str = value; } }
        private System.TimeSpan p__TimeSpan;
        public System.TimeSpan p_TimeSpan { get { return this.p__TimeSpan; } set { this.p__TimeSpan = value; } }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        public Sleep_50() { }
        public Sleep_50 Set(
            Sleep_50 _this = null,
            System.String _Str = null,
            System.Nullable<System.TimeSpan> _TimeSpan = null
            )
        {
            if (_this != null) this.Set(_this: null, _Str: this.p__Str, _TimeSpan: this.p__TimeSpan);
            if (_Str != null) this.p__Str = _Str;
            if (_TimeSpan != null) this.p__TimeSpan = _TimeSpan.Value;
            if (false) ;
            return this;
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        public Sleep_50 Up() { System.Threading.Thread.Sleep(50); return this; }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        public Sleep_50 New() { return new Sleep_50(); }
        System.Object INewEable.New() { return new Sleep_50(); }
        public Sleep_50 Clone() { return this.New().Set(_this: this); }
        System.Object ICloneable.Clone() { return this.New().Set(_this: this); }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}