using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerManDVA_DVA
{
    public interface IVCommander : INewEable, ICloneable
    {
        System.Byte p_nVirtKey { get; set; }
        System.String p_Str { get; set; }
        System.TimeSpan p_TimeSpan { get; set; }
        //INewEable
        //object New();
        //ICloneable
        //object Clone();
        IVCommander Set(IVCommander _this = null
            , System.Nullable<System.Byte> _nVirtKey = null
            , System.String _Str = null
            , System.Nullable<System.TimeSpan> _TimeSpan = null
        );
        System.Boolean Is();
    }
    public class VCommander : IVCommander
    {
        private System.Byte p__nVirtKey = 65;//A
        public System.Byte p_nVirtKey { get { return this.p__nVirtKey; } set { this.p__nVirtKey = value; } }
        private System.String p__Str = "A";
        public System.String p_Str { get { return this.p__Str; } set { this.p__Str = value; } }
        private System.TimeSpan p__TimeSpan;
        public System.TimeSpan p_TimeSpan { get {  return this.p__TimeSpan; } set { this.p__TimeSpan = value; } }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        public VCommander() { }
        public VCommander Set(VCommander _this =null
            , System.Nullable<System.Byte> _nVirtKey =null
            , System.String _Str=null
            , System.Nullable<System.TimeSpan> _TimeSpan=null
        ) 
        {
            if (_this != null) _this.Set(_this: null, _nVirtKey: _this.p__nVirtKey, _Str: _this.p__Str, _TimeSpan: _this.p__TimeSpan);
            if (_nVirtKey != null) this.p__nVirtKey = _nVirtKey.Value;
            if(_Str!=null) this.p__Str= _Str;
            if (_TimeSpan != null) this.p__TimeSpan = _TimeSpan.Value;
            return this;
        }
        IVCommander IVCommander.Set(IVCommander _this = null
            , System.Nullable<System.Byte> _nVirtKey = null
            , System.String _Str = null
            , System.Nullable<System.TimeSpan> _TimeSpan = null
        )
        {
            if (_this != null) _this.Set(_this: null, _nVirtKey: _this.p_nVirtKey, _Str: _this.p_Str, _TimeSpan: _this.p_TimeSpan);
            if (_nVirtKey != null) this.p__nVirtKey = _nVirtKey.Value;
            if (_Str != null) this.p__Str = _Str;
            if (_TimeSpan != null) this.p__TimeSpan = _TimeSpan.Value;
            return this;
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        public VCommander New() { return new VCommander(); }
        System.Object INewEable.New() { return new VCommander(); }
        public VCommander Clone() { return this.New().Set(_this:this); }
        System.Object ICloneable.Clone() { return this.New().Set(_this: this); }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        System.Boolean IVCommander.Is()
        { return this.Is(); }
        public System.Func<System.Boolean> Is = () =>{ return false; };
    }
}
