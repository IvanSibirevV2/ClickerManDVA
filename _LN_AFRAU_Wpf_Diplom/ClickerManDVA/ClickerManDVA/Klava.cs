using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.IO;
using static System.Mouse;

namespace System
{
    
    public partial class Klava
    {
        ///////////////////////////////////////////////////////////////////////////////////////////////////////
        public System.Boolean IsOllVK() { return this.VKS.Select(a => a.Is()).Aggregate((a, b) => a || b); }
        public Klava ClearHistoryOfKeyPres() 
        {
        //    this.VKS.ForEach(a => a.HistoryOfKeyPres.Clear());
            return this;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////
        
        public List<List<VK>> HistoryVKS = new List<List<VK>>();
        public System.DateTime DateTimeStart;
        public Klava()
        {
            this.Init();
        }
    }
}