using ClickerManDVA_DVA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClickerManDVA_DVA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            "Привет мир".WriteLine();
            ClickerManDVA_DVA.DataContext.Test();
            "".ReadLine();
        }
    }
     
    public class DataContext
    {
        private List<IVCommander> p_L_IVCommander=new List<IVCommander>();
        public List<List<IVCommander>> p_LL_IVCommandErS = new List<List<IVCommander>>() {new List<IVCommander>() };
        ///////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////
        public DataContext Init() 
        {
            // A-Z
            this.p_L_IVCommander.AddRange(new List<IVCommander>(){
                new VKeyboard().Set(_nVirtKey: 65,_Str: "A")
                ,new VKeyboard().Set(_nVirtKey:66, _Str:"B")
                ,new VKeyboard().Set(_nVirtKey:67, _Str:"C")
                ,new VKeyboard().Set(_nVirtKey:68, _Str:"D")
                ,new VKeyboard().Set(_nVirtKey:69, _Str:"E")
                ,new VKeyboard().Set(_nVirtKey:70, _Str:"F")
                ,new VKeyboard().Set(_nVirtKey:71, _Str:"G")
                ,new VKeyboard().Set(_nVirtKey:72, _Str:"H")
                ,new VKeyboard().Set(_nVirtKey:73, _Str:"I")
                ,new VKeyboard().Set(_nVirtKey:74, _Str:"J")
                ,new VKeyboard().Set(_nVirtKey:75, _Str:"K")
                ,new VKeyboard().Set(_nVirtKey:76, _Str:"L")
                ,new VKeyboard().Set(_nVirtKey:77, _Str:"M")
                ,new VKeyboard().Set(_nVirtKey:78, _Str:"N")
                ,new VKeyboard().Set(_nVirtKey:79, _Str:"O")
                ,new VKeyboard().Set(_nVirtKey:80, _Str:"P")
                ,new VKeyboard().Set(_nVirtKey:81, _Str:"Q")
                ,new VKeyboard().Set(_nVirtKey:82, _Str:"R")
                ,new VKeyboard().Set(_nVirtKey:83, _Str:"S")
                ,new VKeyboard().Set(_nVirtKey:84, _Str:"T")
                ,new VKeyboard().Set(_nVirtKey:85, _Str:"U")
                ,new VKeyboard().Set(_nVirtKey:86, _Str:"V")
                ,new VKeyboard().Set(_nVirtKey:87, _Str:"W")
                ,new VKeyboard().Set(_nVirtKey:88, _Str:"X")
                ,new VKeyboard().Set(_nVirtKey:89, _Str:"Y")
                ,new VKeyboard().Set(_nVirtKey:90, _Str:"Z")
            });
            //_0-_9
            this.p_L_IVCommander.AddRange(new List<IVCommander>(){
                new VKeyboard().Set(_nVirtKey:48, _Str:"_0")
                ,new VKeyboard().Set(_nVirtKey:49, _Str:"_1")
                ,new VKeyboard().Set(_nVirtKey:50, _Str:"_2")
                ,new VKeyboard().Set(_nVirtKey:51, _Str:"_3")
                ,new VKeyboard().Set(_nVirtKey:52, _Str:"_4")
                ,new VKeyboard().Set(_nVirtKey:53, _Str:"_5")
                ,new VKeyboard().Set(_nVirtKey:54, _Str:"_6")
                ,new VKeyboard().Set(_nVirtKey:55, _Str:"_7")
                ,new VKeyboard().Set(_nVirtKey:56, _Str:"_8")
                ,new VKeyboard().Set(_nVirtKey:57, _Str:"_9")
            });
            //F1-F12
            this.p_L_IVCommander.AddRange(new List<IVCommander>(){
                new VKeyboard().Set(_nVirtKey:112, _Str:"F1")
                ,new VKeyboard().Set(_nVirtKey:113, _Str: "F2")
                ,new VKeyboard().Set(_nVirtKey:114, _Str: "F3")
                ,new VKeyboard().Set(_nVirtKey:115, _Str: "F4")
                ,new VKeyboard().Set(_nVirtKey:116, _Str: "F5")
                ,new VKeyboard().Set(_nVirtKey:117, _Str: "F6")
                ,new VKeyboard().Set(_nVirtKey:118, _Str: "F7")
                ,new VKeyboard().Set(_nVirtKey:119, _Str: "F8")
                ,new VKeyboard().Set(_nVirtKey:120, _Str: "F9")
                ,new VKeyboard().Set(_nVirtKey:121, _Str: "F10")
                ,new VKeyboard().Set(_nVirtKey:122, _Str: "F11")
                ,new VKeyboard().Set(_nVirtKey:123, _Str: "F12")
            });
            //Num ...
            this.p_L_IVCommander.AddRange(new List<IVCommander>(){   
                new VKeyboard().Set(_nVirtKey:96, _Str:"NumZero")
                ,new VKeyboard().Set(_nVirtKey:97, _Str:"NumOne")
                ,new VKeyboard().Set(_nVirtKey:98, _Str:"NumTwo")
                ,new VKeyboard().Set(_nVirtKey:99, _Str:"NumThree")
                ,new VKeyboard().Set(_nVirtKey:100, _Str:"NumFor")
                ,new VKeyboard().Set(_nVirtKey:101, _Str:"NumFive")
                ,new VKeyboard().Set(_nVirtKey:102, _Str:"NumSix")
                ,new VKeyboard().Set(_nVirtKey:103, _Str:"NumSeven")
                ,new VKeyboard().Set(_nVirtKey:104, _Str:"NumEight")
                ,new VKeyboard().Set(_nVirtKey:105, _Str:"NumNine")
                ,new VKeyboard().Set(_nVirtKey:106, _Str:"NumStar")
                ,new VKeyboard().Set(_nVirtKey:107, _Str:"NumPlus")
                ,new VKeyboard().Set(_nVirtKey:109, _Str:"NumMinus")
                ,new VKeyboard().Set(_nVirtKey:110, _Str:"NumDot")
                ,new VKeyboard().Set(_nVirtKey:111, _Str:"NumSlash")
                ,new VKeyboard().Set(_nVirtKey:144, _Str:"NUMLOCK")
            });
            // ...
            this.p_L_IVCommander.AddRange(new List<IVCommander>(){
                new VKeyboard().Set(_nVirtKey:191, _Str:"Slash")
                ,new VKeyboard().Set(_nVirtKey:32, _Str:"Space")
                ,new VKeyboard().Set(_nVirtKey:13, _Str:"Enter")
                ,new VKeyboard().Set(_nVirtKey:222, _Str:"Mark")
                ,new VKeyboard().Set(_nVirtKey:16, _Str : "Shift")
                ,new VKeyboard().Set(_nVirtKey:8, _Str : "BACKSPACE")
                ,new VKeyboard().Set(_nVirtKey:9, _Str : "TAB")
                ,new VKeyboard().Set(_nVirtKey:17, _Str : "CTRL")
                ,new VKeyboard().Set(_nVirtKey:18, _Str : "ALT")
                ,new VKeyboard().Set(_nVirtKey:19, _Str : "PAUSE")
                ,new VKeyboard().Set(_nVirtKey:20, _Str : "CAPSLOCK")
                ,new VKeyboard().Set(_nVirtKey:27, _Str : "ESCAPE")
                ,new VKeyboard().Set(_nVirtKey:33, _Str : "PAGEUP")
                ,new VKeyboard().Set(_nVirtKey:34, _Str : "PAGEDOWN")
                ,new VKeyboard().Set(_nVirtKey:35, _Str : "END")
                ,new VKeyboard().Set(_nVirtKey:36, _Str : "HOME")
                ,new VKeyboard().Set(_nVirtKey:37, _Str : "LEFT")
                ,new VKeyboard().Set(_nVirtKey:38, _Str : "UP")
                ,new VKeyboard().Set(_nVirtKey:39, _Str : "RIGHT")
                ,new VKeyboard().Set(_nVirtKey:40, _Str : "DOWN")
                ,new VKeyboard().Set(_nVirtKey:45, _Str : "INSERT")
                ,new VKeyboard().Set(_nVirtKey:46, _Str : "DELETE")
                ,new VKeyboard().Set(_nVirtKey:91, _Str : "LWIN")
                ,new VKeyboard().Set(_nVirtKey:92, _Str : "RWIN")
                ,new VKeyboard().Set(_nVirtKey:145, _Str : "SCROLLLOCK")
                ,new VKeyboard().Set(_nVirtKey:154, _Str : "PRINTSCREEN")
                ,new VKeyboard().Set(_nVirtKey:186, _Str : "PeriodComma")
                ,new VKeyboard().Set(_nVirtKey:187, _Str : "Equally")
                ,new VKeyboard().Set(_nVirtKey:188, _Str : "Сomma")
                ,new VKeyboard().Set(_nVirtKey:189, _Str : "Minus")
                ,new VKeyboard().Set(_nVirtKey:190, _Str : "Dot")
                ,new VKeyboard().Set(_nVirtKey:192, _Str : "Tilda")
                ,new VKeyboard().Set(_nVirtKey:219, _Str : "SquScobOtk")
                ,new VKeyboard().Set(_nVirtKey:220, _Str : "ObratSlash")
                ,new VKeyboard().Set(_nVirtKey:221, _Str : "SquScobZak")
                ,new VKeyboard().Set(_nVirtKey:1, _Str : "MouseL")
                ,new VKeyboard().Set(_nVirtKey:2, _Str : "MouseR")
                ,new VKeyboard().Set(_nVirtKey:4, _Str : "MMouse")
            });
            //Tech
            this.p_L_IVCommander.AddRange(new List<IVCommander>(){
                new Sleep_50().Set( _Str:"Sleep_50")
            });

            return this;
        }
        public DataContext() { this.Init(); }
        public DataContext Set()
        {
            return this;
        }
        public DataContext Set_NextRow() { this.p_LL_IVCommandErS.Add(new List<IVCommander>()); return this; }
        public DataContext Set_Add(IVCommander _IVCommander) { this.p_LL_IVCommandErS[this.p_LL_IVCommandErS.Count - 1].Add(_IVCommander); return this; }
        ////////////////////////////////////////////////////////////
        #region // A-Z
        public DataContext A(){this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "A").First().Clone().Cast_As<IVCommander>()).Set_NextRow();return this;}
        public DataContext B() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "B").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext C() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "C").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext D() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "D").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext E() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "E").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext F() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "F").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext G() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "G").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext H() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "H").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext I() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "I").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext J() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "J").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext K() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "K").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext L() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "L").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext M() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "M").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext N() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "N").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext O() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "O").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext P() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "P").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext Q() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "Q").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext R() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "R").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext S() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "S").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext T() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "T").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext U() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "U").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext V() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "V").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext W() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "W").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext X() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "X").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext Y() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "Y").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext Z() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "Z").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        #endregion
        #region //_0-_9
        public DataContext _0() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "_0").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext _1() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "_1").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext _2() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "_2").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext _3() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "_3").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext _4() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "_4").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext _5() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "_5").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext _6() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "_6").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext _7() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "_7").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext _8() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "_8").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext _9() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "_9").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        #endregion
        #region //F1-F12
        public DataContext F1() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "F1").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext F2() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "F2").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext F3() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "F3").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext F4() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "F4").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext F5() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "F5").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext F6() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "F6").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext F7() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "F7").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext F8() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "F8").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext F9() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "F9").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext F10() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "F10").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext F11() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "F11").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext F12() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "F12").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        #endregion
        #region //Num ...
        public DataContext NumZero() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "NumZero").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext NumOne() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "NumOne").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext NumTwo() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "NumTwo").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext NumThree() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "NumThree").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext NumFor() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "NumFor").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext NumFive() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "NumFive").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext NumSix() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "NumSix").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext NumSeven() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "NumSeven").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext NumEight() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "NumEight").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext NumNine() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "NumNine").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext NumStar() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "NumStar").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext NumPlus() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "NumPlus").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext NumMinus() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "NumMinus").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext NumDot() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "NumDot").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext NumSlash() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "NumSlash").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext NUMLOCK() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "NUMLOCK").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        #endregion
        #region // ...
        public DataContext Slash() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "Slash").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext Space() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "Space").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext Enter() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "Enter").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext Mark() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "Mark").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext Shift() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "Shift").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext BACKSPACE() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "BACKSPACE").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext TAB() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "TAB").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext CTRL() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "CTRL").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext ALT() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "ALT").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext PAUSE() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "PAUSE").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext CAPSLOCK() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "CAPSLOCK").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext ESCAPE() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "ESCAPE").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext PAGEUP() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "PAGEUP").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext PAGEDOWN() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "PAGEDOWN").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext END() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "END").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext HOME() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "HOME").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext LEFT() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "LEFT").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext UP() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "UP").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext RIGHT() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "RIGHT").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext DOWN() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "DOWN").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext INSERT() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "INSERT").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext DELETE() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "DELETE").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext LWIN() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "LWIN").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext RWIN() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "RWIN").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext SCROLLLOCK() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "SCROLLLOCK").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext PRINTSCREEN() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "PRINTSCREEN").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext PeriodComma() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "PeriodComma").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext Equally() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "Equally").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext Сomma() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "Сomma").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext Minus() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "Minus").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext Dot() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "Dot").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext Tilda() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "Tilda").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext SquScobOtk() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "SquScobOtk").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext ObratSlash() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "ObratSlash").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext SquScobZak() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "SquScobZak").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext MouseL() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "MouseL").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext MouseR() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "MouseR").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        public DataContext MMouse() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "MMouse").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        #endregion
        #region//Tech
        public DataContext Sleep_50() { this.Set_Add(this.p_L_IVCommander.Where(a => a.p_Str == "Sleep_50").First().Clone().Cast_As<IVCommander>()).Set_NextRow(); return this; }
        #endregion
        ////////////////////////////////////////////////////////
        public void Execute() 
        {
            for (int i = 1; i < this.p_LL_IVCommandErS.Count(); i++)
            {
                var __Last = this.p_LL_IVCommandErS[i - 1];
                var __Now = this.p_LL_IVCommandErS[i];
                // смотрим предыдущий тик-строку
                //обрабатываем на Up только клавишу
                __Last.Where(_Last => __Now.Where(_Now => _Now.p_Str == _Last.p_Str).ToList().Count() == 0).ToList()
                    .ForEach(_Last => { if (_Last is VKeyboard) { _Last.Cast_As<VKeyboard>().Up(); } });
                
                __Now.Select(_Now => {
                    //Обрабатываем спячки в порядке поступления
                    if (_Now is Sleep_50) { _Now.Cast_As<Sleep_50>().Up(); }
                    //Обрабатываем движения мыши
                    //...
                    else {if (__Last.Where(_Last => _Now.p_Str == _Last.p_Str).ToList().Count() == 0)
                            if(_Now is VKeyboard) _Now.Cast_As<VKeyboard>().Down();
                    }
                    
                        return _Now; 
                }).ToList();

                //, тут неверно подумать нужно
                __Now.Where(_Now => { System.Boolean _flag = false; if (_Now is Sleep_50) _flag = true; return true; })
                    .Select(_Now => _Now.Cast_As<Sleep_50>().).ToList();
            }
        }
        public static void Test() 
        {
            DataContext _DataContext = new DataContext();
            _DataContext.Sleep_50().Sleep_50().Execute();
            "потестили".WriteLine();
        }
        ////////////////////////////////////////////////////////

    }
    // сделать класс для клавиатуры клавиши под интерфейс
    // сделать тест 
    // сделать класс для мыши под интерфейс
    // сделать морду для быстрого набора 
    // сделать морду для записи
}