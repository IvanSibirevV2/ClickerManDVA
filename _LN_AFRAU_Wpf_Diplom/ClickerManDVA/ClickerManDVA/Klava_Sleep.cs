using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.IO;

namespace System
{
    //Klava_Sleep
    public partial class Klava
    {
        public Klava Sleep(int _Sleep = 50) { System.Threading.Thread.Sleep(_Sleep); return this; }
    }
}
