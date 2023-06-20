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
        //IVCommander Set(IVCommander _this = null
        //    , System.Nullable<System.Byte> _nVirtKey = null
        //    , System.String _Str = null
        //    , System.Nullable<System.TimeSpan> _TimeSpan = null
        //);
        //System.Boolean Is();
    }
}
