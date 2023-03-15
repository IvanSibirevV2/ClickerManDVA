using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.IO;

namespace System
{
    //Klava_File
    public partial class Klava
    {
        public Klava RecInFile(String str)
        {
            string path = @"C:\D\test\";   // путь к файлу
            // запись в файл
            StreamWriter sw = new StreamWriter(path + "export.txt", append: true);
            sw.WriteLine(str);
            sw.Close();

            return null;
        }

        public static void StartIsFile()
        {
            (new Klava()).IsFile();
        }

        public Klava IsFile()
        {
            string path = @"C:\D\test\";
            StreamReader sr = new StreamReader(path + "export.txt");
            string tempStr = sr.ReadToEnd();

            List<VK> tempVkList = new List<VK>();
            VK tempVk = new VK();

            Console.WriteLine(tempStr);

            //tempVk.Str = _tempStr;
            //tempVk.nVirtKey = Convert.ToByte(tempNVirtKey);
            //tempVkList.Add(tempVk);
            //
            //HistoryVKS.Add(tempVkList);
            return null;
        }
    }
}