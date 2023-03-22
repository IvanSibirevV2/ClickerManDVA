using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerManDVA_DVA
{
    public interface IVCommander: INewEable,ICloneable 
    {
        //INewEable
        //object New();
        //ICloneable
        //object Clone();
        string p_Str { get; set; }
        System.TimeSpan p_TimeSpan { get; set; }
        IVCommander Set_TimeSpan(System.TimeSpan _TimeSpan);
        System.Boolean Is();
        VKeyboard GetAsVKeyboard();
        VMouse GetAsVMouse();
    }
}
