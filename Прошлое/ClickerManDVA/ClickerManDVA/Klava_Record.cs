using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.IO;

namespace System
{
    //Klava_Record
    public partial class Klava
    {
        public Klava Record(int _Seconds = 10)
        {

            System.Boolean _flag = false;
            this.HistoryVKS.Clear();
            this.HistoryVKS.Add(new List<VK>());
            this.DateTimeStart = System.DateTime.Now;
            System.DateTime _DateTime_pause = System.DateTime.Now;
            while (((System.TimeSpan)(System.DateTime.Now - DateTimeStart)).Seconds < _Seconds)
            {
                // System.Threading.Thread.Sleep(50);
                List<VK> _ls_VK = new List<VK>();
                this.VKS.ForEach(a => { if (a.Is()) _ls_VK.Add(new VK().Set(_this: a, _TimeSpan: System.DateTime.Now - DateTimeStart)); });
                if (_ls_VK.Count() != 0) this.HistoryVKS.Add(_ls_VK);
            }

            foreach (var el1 in HistoryVKS)
            {
                foreach (var el2 in el1)
                {
                    //Console.Write(el2.Str + " "+el2.nVirtKey.ToString()+" "+el2.Sender.ToString()+" "+el2.TimeSpan.ToString());
                    RecInFile(el2.Str + " " + el2.nVirtKey.ToString());
                    //el2.Act.ToString()+" "+
                }
                Console.WriteLine();

            }
            return this;
        }
        public Klava HistoryExecute()
        {
            /*
            this.HistoryVKS.Sort((a,b)=> {
                System.TimeSpan _TimeSpan = a.TimeSpan - b.TimeSpan;
                if (_TimeSpan > System.TimeSpan.Zero) return 1;
                if (_TimeSpan==System.TimeSpan.Zero) return 0;
                if (_TimeSpan < System.TimeSpan.Zero) return -1;
                return -1;
            });
            */

            //Дешифровка
            /*
                List<VK> temp = new List<VK>();
                VK _temp=new VK();
                _temp.Str = "G";
                temp.Add(_temp);
                HistoryVKS.Add(temp);
            */

            this.DateTimeStart = System.DateTime.Now;
            for (int i = 1; i < this.HistoryVKS.Count(); i++)
            {
                var qwe = this.HistoryVKS[i];
                var qwe_last = this.HistoryVKS[i - 1];

                foreach (var wer in this.VKS)
                {
                    System.Boolean _Flag_Now = false;
                    System.Boolean _Flag_pREVIOUSLY = false;

                    if (qwe.Where(a => a.Str == wer.Str).ToList().Count() == 0)
                    { _Flag_Now = false; }
                    else { _Flag_Now = true; }
                    if (qwe_last.Where(a => a.Str == wer.Str).ToList().Count() == 0)
                    { _Flag_pREVIOUSLY = false; }
                    else { _Flag_pREVIOUSLY = true; }
                    if (_Flag_Now & !_Flag_pREVIOUSLY)
                    {
                        System.TimeSpan TS_mashin = System.DateTime.Now - this.DateTimeStart;
                        System.TimeSpan TS_VK = qwe.Where(a => a.Str == wer.Str).First().TimeSpan;
                        if (TS_mashin <= TS_VK) System.Threading.Thread.Sleep(TS_VK - TS_mashin);
                        wer.Down();
                    }
                    if (!_Flag_Now & _Flag_pREVIOUSLY) wer.Up();
                }
            }
            return this;
        }
        /// <summary> System.Klava.Test_Record_HistoryExecute();</summary>
        public static void Test_Record_HistoryExecute()
        {
            (new Klava()).Record(10).HistoryExecute();
        }
    }
}
