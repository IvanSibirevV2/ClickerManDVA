using ClickerManDVA_DVA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
            ;
            new DataContext()
                .H().E().L().L().O().W().W().O().R().D()
            .WriteThis()
            ;

            "".ReadLine();
        }
    }
     
    public class DataContext
    {
        private List<IVCommander> p_L_IVCommander=new List<IVCommander>();
        public List<List<IVCommander>> p_LL_IVCommandErS = new List<List<IVCommander>>().Set_Add(new List<IVCommander>());
        ///////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////
        public delegate AddComDel AddComDel(System.Byte _nVirtKey, System.String _Str);
        public AddComDel AddCom(System.Byte _nVirtKey, System.String _Str) 
        {
            this.p_L_IVCommander.Add(new VKeyboard(_nVirtKey, _Str));
            return AddCom; 
        }
        public DataContext Init() 
        {

            // A-Z
            this.AddCom(65, "A")(66, "B")(67, "C")(68, "D")(69, "E")(70, "F")(71, "G")(72, "H")(73, "I")(74, "J")(75, "K")(76,"L")
                (77,"M")(78,"N")(79,"O")(80,"P")(81,"Q")(82,"R")(83,"S")(84,"T")(85,"U")(86,"V")(87,"W")(88,"X")(89,"Y")(90,"Z")
            //_0-_9
                (48,"_0")(49,"_1")(50,"_2")(51,"_3")(52,"_4")(53,"_5")(54,"_6")(55,"_7")(56,"_8")(57,"_9")
            //F1-F12
                (112,"F1")(113,"F2")(114,"F3")(115,"F4")(116,"F5")(117,"F6")(118,"F7")(119,"F8")(120,"F9")(121,"F10")(122,"F11")(123,"F12")
            //Num ...
                (96,"NumZero")(97,"NumOne")(98,"NumTwo")(99,"NumThree")(100,"NumFor")(101,"NumFive")(102,"NumSix")(103,"NumSeven")
                (104,"NumEight")(105,"NumNine")(106,"NumStar")(107,"NumPlus")(109,"NumMinus")(110,"NumDot")(111,"NumSlash")(144,"NUMLOCK")
            //...
                (191,"Slash")(32,"Space")(13,"Enter")(222,"Mark")(16,"Shift")(8,"BACKSPACE")(9,"TAB")(17,"CTRL")
                (18,"ALT")(19,"PAUSE")(20,"CAPSLOCK")(27,"ESCAPE")(33,"PAGEUP")(34,"PAGEDOWN")(35,"END")(36,"HOME")
                (37,"LEFT")(38,"UP")(39,"RIGHT")(40,"DOWN")(45,"INSERT")(46,"DELETE")(91,"LWIN")(92,"RWIN")
                (145,"SCROLLLOCK")(154,"PRINTSCREEN")(186,"PeriodComma")(187,"Equally")(188,"Сomma")(189,"Minus")(190,"Dot")
                (192,"Tilda")(219,"SquScobOtk")(220,"ObratSlash")(221,"SquScobZak")(1,"MouseL")(2,"MouseR")(4,"MMouse")
            ;
            //Tech
            this.p_L_IVCommander.Set_Add(new Sleep_(50, "Sleep_50")).Set_Add(new Sleep_(500,"Sleep_500")).Set_Add(new Sleep_(5000,"Sleep_5000"));

            return this;
        }
        public DataContext() {this.Init();}
        public DataContext WriteThis()
        {
            foreach (var items in this.p_LL_IVCommandErS)
            {
                foreach (var item in items)(item.p_Str+";").Write();
                "".WriteLine();
            }
            return this;
        }
        public DataContext Set_NextRow() { this.p_LL_IVCommandErS.Add(new List<IVCommander>()); return this; }
        ////////////////////////////////////////////////////////////
        #region // A-Z
        public DataContext A() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "A").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext B() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "B").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext C() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "C").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext D() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "D").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext E() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "E").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext F() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "F").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext G() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "G").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext H() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "H").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext I() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "I").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext J() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "J").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext K() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "K").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext L() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "L").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext M() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "M").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext N() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "A").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext O() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "O").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext P() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "P").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext Q() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str =="Q").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext R() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str =="R").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext S() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str =="S").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext T() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str =="T").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext U() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str =="U").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext V() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str =="V").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext W() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str =="W").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext X() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str =="X").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext Y() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str =="Y").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext Z() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str =="Z").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        #endregion
        #region //_0-_9
        public DataContext _0() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "_0").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext _1() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "_1").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext _2() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "_2").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext _3() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "_3").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext _4() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "_4").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext _5() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "_5").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext _6() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "_6").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext _7() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "_7").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext _8() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "_8").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext _9() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "_9").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        #endregion
        #region //F1-F12
        public DataContext F1() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "F1").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext F2() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "F2").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext F3() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "F3").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext F4() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "F4").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext F5() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "F5").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext F6() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "F6").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext F7() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "F7").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext F8() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "F8").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext F9() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "F9").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext F10() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "F10").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext F11() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "F11").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext F12() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "F12").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        #endregion
        #region //Num ...
        public DataContext NumZero() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "NumZero").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext NumOne() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "NumOne").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext NumTwo() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "NumTwo").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext NumThree() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "NumThree").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext NumFor() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "NumFor").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext NumFive() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "NumFive").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext NumSix() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "NumSix").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext NumSeven() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "NumSeven").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext NumEight() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "NumEight").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext NumNine() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "NumNine").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext NumStar() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "NumStar").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext NumPlus() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "NumPlus").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext NumMinus() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "NumMinus").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext NumDot() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "NumDot").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext NumSlash() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "NumSlash").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext NUMLOCK() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "NUMLOCK").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        #endregion
        #region // ...
        public DataContext Slash() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "Slash").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext Space() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "Space").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext Enter() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "Enter").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext Mark() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "Mark").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext Shift() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "Shift").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext BACKSPACE() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "BACKSPACE").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext TAB() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "TAB").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext CTRL() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "CTRL").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext ALT() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "ALT").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext PAUSE() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "PAUSE").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext CAPSLOCK() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "CAPSLOCK").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext ESCAPE() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "ESCAPE").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext PAGEUP() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "PAGEUP").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext PAGEDOWN() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "PAGEDOWN").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext END() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "END").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext HOME() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "HOME").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext LEFT() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "LEFT").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext UP() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "UP").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext RIGHT() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "RIGHT").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext DOWN() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "DOWN").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext INSERT() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "INSERT").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext DELETE() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "DELETE").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext LWIN() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "LWIN").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext RWIN() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "RWIN").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext SCROLLLOCK() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "SCROLLLOCK").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext PRINTSCREEN() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "PRINTSCREEN").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext PeriodComma() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "PeriodComma").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext Equally() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "Equally").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext Сomma() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "Сomma").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext Minus() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "Minus").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext Dot() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "Dot").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext Tilda() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "Tilda").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext SquScobOtk() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "SquScobOtk").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext ObratSlash() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "ObratSlash").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext SquScobZak() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "SquScobZak").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext MouseL() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "MouseL").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext MouseR() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "MouseR").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext MMouse() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "MMouse").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        #endregion
        #region//Tech
        public DataContext Sleep_50() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "Sleep_50").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext Sleep_500() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "Sleep_500").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }
        public DataContext Sleep_5000() { this.p_LL_IVCommandErS.Set(a => a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == "Sleep_5000").First().Clone().Cast_As<IVCommander>())).Add(new List<IVCommander>()); return this; }

        #endregion
        ////////////////////////////////////////////////////////
        public void Execute() 
        {
            ;
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
                    if (_Now is Sleep_) { _Now.Cast_As<Sleep_>().Up(); }
                    //Обрабатываем движения мыши
                    //...
                    else {if (__Last.Where(_Last => _Now.p_Str == _Last.p_Str).ToList().Count() == 0)
                            if(_Now is VKeyboard) _Now.Cast_As<VKeyboard>().Down();
                    }
                    
                        return _Now; 
                }).ToList();

                //, тут неверно подумать нужно

               // __Now.Where(_Now => { System.Boolean _flag = false; if (_Now is Sleep_50) _flag = true; return true; })
               //     .Select(_Now => _Now.Cast_As<Sleep_50>().).ToList();
            }
        }
        public static void Test() 
        {
            new DataContext()
                .H().E().L().L().O().W().W().O().R().D()
            .WriteThis()
            ;
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