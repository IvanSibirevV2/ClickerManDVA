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
            int watWord = 0;
            string path = @"C:\D\test\";
            StreamReader sr = new StreamReader(path + "export.txt");
            string tempStr = sr.ReadToEnd();

            List<VK> tempVkList = new List<VK>();
            VK tempVk = new VK();

            Console.WriteLine(tempStr+'\n');

            string _tempStr = "";
            string tempNVirtKey = "";
            string tempTimeSpan = "";

            //this.HistoryVKS.Clear();
            

            for (int i = 0; i < tempStr.Length; i++)
            {
                if (watWord == 0)
                {
                    if (tempStr[i] != ' ')
                    {
                        _tempStr += tempStr[i];
                    }
                    else
                    {
                        i++;
                        watWord++;
                    }
                }
                if (watWord == 1)
                {
                    if(tempStr[i] != ' ')
                    {
                        tempNVirtKey+= tempStr[i];
                    }    
                    else
                    {
                        i++; watWord++;
                    }
                }
                if(watWord == 2)
                {
                    if (tempStr[i] != '\n')
                    {
                        tempTimeSpan += tempStr[i];
                    }
                    else
                    {
                        watWord=0;
                        //Console.WriteLine(_tempStr + " " + tempNVirtKey + " " + tempTimeSpan);

                        tempVk.Str = _tempStr;
                        Console.WriteLine(tempNVirtKey);
                        tempVk.nVirtKey = Convert.ToByte(tempNVirtKey);
                        tempVk.TimeSpan = TimeSpan.Parse(tempTimeSpan); 

                        tempVkList.Add(tempVk);
                        HistoryVKS.Add(tempVkList);

                        _tempStr = "";
                        tempNVirtKey = "";
                        tempTimeSpan = "";
                    }
                }
            }

            //Console.WriteLine(_tempStr + " " + tempNVirtKey + " " + tempTimeSpan);

            tempVk.Str = _tempStr;
            tempVk.nVirtKey = Convert.ToByte(tempNVirtKey);
            tempVk.TimeSpan = TimeSpan.Parse(tempTimeSpan);

            tempVkList.Add(tempVk);
            HistoryVKS.Add(tempVkList);

            (new Klava()).HistoryExecute();

            return null;
        }
    }
}