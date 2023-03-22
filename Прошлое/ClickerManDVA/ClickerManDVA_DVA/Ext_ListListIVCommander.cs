using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClickerManDVA_DVA
{
    public static class Ext_ListListIVCommander
    {
        public static List<List<IVCommander>> Record(this List<List<IVCommander>> _this, int _Seconds = 10) 
        {
            System.DateTime _DateTime_start = System.DateTime.Now;
            System.DateTime _DateTime_pause = System.DateTime.Now;
            while ((System.DateTime.Now - _DateTime_start).Cast_As<System.TimeSpan>().Seconds < _Seconds)
            {
                System.TimeSpan _LocalTimeSpan = System.DateTime.Now - _DateTime_start;
                _this.Add(Ext_ListIVCommander._LIVCommander.AsParallel().Where(a=> a.Is())
                    .Select(a=> a.Clone().Cast_As<IVCommander>().Set_TimeSpan(_LocalTimeSpan))
                    .ToList()
                )
                ;
            }
            return _this;
        }
        public static List<List<IVCommander>> HistoryExecute(this List<List<IVCommander>> _this)
        {
            System.DateTime _DateTime_start = System.DateTime.Now;
            for (int i = 1; i < _this.Count(); i++)
            {
                var qwe = _this[i];
                var qwe_last = _this[i - 1];

                foreach (var wer in qwe)
                {
                    System.TimeSpan TS_mashin = System.DateTime.Now - _DateTime_start;
                    //System.TimeSpan TS_VK = qwe.Where(a => a.Str == wer.Str).First().TimeSpan;
                    if (TS_mashin <= wer.p_TimeSpan) System.Threading.Thread.Sleep(wer.p_TimeSpan - TS_mashin);
                    
                    //if (wer.Act != null) wer.Act(wer);
                    System.Boolean _Flag_Now = false;
                    System.Boolean _Flag_pREVIOUSLY = false;

                    if (qwe.Where(a => a.p_Str == wer.p_Str).ToList().Count() == 0)
                    { _Flag_Now = false; }
                    else { _Flag_Now = true; }
                    if (qwe_last.Where(a => a.p_Str == wer.p_Str).ToList().Count() == 0)
                    { _Flag_pREVIOUSLY = false; }
                    else { _Flag_pREVIOUSLY = true; }
                    if (_Flag_Now & !_Flag_pREVIOUSLY)
                    {

                        ;//wer.Down();
                    }
                    if (!_Flag_Now & _Flag_pREVIOUSLY) ;//wer.Up();

                }

            }
            return _this;
        }

    }
}