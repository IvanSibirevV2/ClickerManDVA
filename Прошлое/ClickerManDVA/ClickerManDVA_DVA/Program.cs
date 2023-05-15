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
            /*
            var _DataContext = new DataContext()
                .Sleep_500().MMove_X_50().Sleep_500().MMove_Y_50().Sleep_500().MMove_X_M50().Sleep_500().MMove_Y_M50()
                .WriteThis()
                .Execute();
            */
            new DataContext()
                .MMove_X_50()
                .Space().Space().Space()
                .H().E().L().L().O().W().Space().W().O().R().D()
                .Sleep_500().MMove_X_50().Sleep_500().MMove_Y_50().Sleep_500().MMove_X_M50().Sleep_500().MMove_Y_M50()
                .Sleep_500().MMove_X_50().Sleep_500().MMove_Y_50().Sleep_500().MMove_X_M50().Sleep_500().MMove_Y_M50()
                .Sleep_500().MMove_X_50().Sleep_500().MMove_Y_50().Sleep_500().MMove_X_M50().Sleep_500().MMove_Y_M50()
                .Sleep_500().MMove_X_50().Sleep_500().MMove_Y_50().Sleep_500().MMove_X_M50().Sleep_500().MMove_Y_M50()
                .Execute()
                .WriteThis()
            ;
            //ClickerManDVA_DVA.VMouseMove_.Test_Move();
            /*
            new DataContext()
                //.Space().Space().Space()
                //.H().E().L().L().O().W().Space().W().O().R().D()
                .Sleep_500().MMove_X_50().Sleep_500().MMove_Y_50().Sleep_500().MMove_X_M50().Sleep_500().MMove_Y_M50()

                .Sleep_500().MMove_X_50().Sleep_500().MMove_Y_50().Sleep_500().MMove_X_M50().Sleep_500().MMove_Y_M50()

                .Sleep_500().MMove_X_50().Sleep_500().MMove_Y_50().Sleep_500().MMove_X_M50().Sleep_500().MMove_Y_M50()

                .Sleep_500().MMove_X_50().Sleep_500().MMove_Y_50().Sleep_500().MMove_X_M50().Sleep_500().MMove_Y_M50()
            .Execute()
            ;*/

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
            this.p_L_IVCommander.Set_Add(new VMouseMove_().Set(_this:null, _MoveX: 50, _MoveY: 0, _Str: "MMove_X_50"));
            this.p_L_IVCommander.Set_Add(new VMouseMove_().Set(_this: null, _MoveX: -50, _MoveY: 0, _Str: "MMove_X_M50"));
            this.p_L_IVCommander.Set_Add(new VMouseMove_().Set(_this: null, _MoveX: 0, _MoveY: 50, _Str: "MMove_Y_50"));
            this.p_L_IVCommander.Set_Add(new VMouseMove_().Set(_this: null, _MoveX: 0, _MoveY: -50, _Str: "MMove_Y_M50"));
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
        private DataContext SetCommand(System.String _Str) 
        {
            this.p_LL_IVCommandErS.Set(a =>
                a.Last().Add(this.p_L_IVCommander.Where(b => b.p_Str == _Str).First().Clone().Cast_As<IVCommander>())
            ).Set_Add(new List<IVCommander>());
            return this;
        }
        #region // A-Z
        public DataContext A() {  return this.SetCommand("A"); }
        public DataContext B() { return this.SetCommand("B"); }
        public DataContext C() { return this.SetCommand("C"); }
        public DataContext D() { return this.SetCommand("D"); }
        public DataContext E() { return this.SetCommand("E"); }
        public DataContext F() { return this.SetCommand("F"); }
        public DataContext G() { return this.SetCommand("G"); }
        public DataContext H() { return this.SetCommand("H"); }
        public DataContext I() { return this.SetCommand("I"); }
        public DataContext J() { return this.SetCommand("J"); }
        public DataContext K() { return this.SetCommand("K"); }
        public DataContext L() { return this.SetCommand("L"); }
        public DataContext M() { return this.SetCommand("M"); }
        public DataContext N() { return this.SetCommand("N"); }
        public DataContext O() { return this.SetCommand("O"); }
        public DataContext P() { return this.SetCommand("P"); }
        public DataContext Q() { return this.SetCommand("Q"); }
        public DataContext R() { return this.SetCommand("R"); }
        public DataContext S() { return this.SetCommand("S"); }
        public DataContext T() { return this.SetCommand("T"); }
        public DataContext U() { return this.SetCommand("U"); }
        public DataContext V() { return this.SetCommand("V"); }
        public DataContext W() { return this.SetCommand("W"); }
        public DataContext X() { return this.SetCommand("X"); }
        public DataContext Y() { return this.SetCommand("Y"); }
        public DataContext Z() { return this.SetCommand("Z"); }
        #endregion
        #region //_0-_9
        public DataContext _0() { return this.SetCommand("_0"); }
        public DataContext _1() { return this.SetCommand("_1"); }
        public DataContext _2() { return this.SetCommand("_2"); }
        public DataContext _3() { return this.SetCommand("_3"); }
        public DataContext _4() { return this.SetCommand("_4"); }
        public DataContext _5() { return this.SetCommand("_5"); }
        public DataContext _6() { return this.SetCommand("_6"); }
        public DataContext _7() { return this.SetCommand("_7"); }
        public DataContext _8() { return this.SetCommand("_8"); }
        public DataContext _9() { return this.SetCommand("_9"); }
        #endregion
        #region //F1-F12
        public DataContext F1() { return this.SetCommand("F1"); }
        public DataContext F2() { return this.SetCommand("F2"); }
        public DataContext F3() { return this.SetCommand("F3"); }
        public DataContext F4() { return this.SetCommand("F4"); }
        public DataContext F5() { return this.SetCommand("F5"); }
        public DataContext F6() { return this.SetCommand("F6"); }
        public DataContext F7() { return this.SetCommand("F7"); }
        public DataContext F8() { return this.SetCommand("F8"); }
        public DataContext F9() { return this.SetCommand("F9"); }
        public DataContext F10() { return this.SetCommand("F10"); }
        public DataContext F11() { return this.SetCommand("F11"); }
        public DataContext F12() { return this.SetCommand("F12"); }
        #endregion
        #region //Num ...
        public DataContext NumZero() { return this.SetCommand("NumZero"); }
        public DataContext NumOne() { return this.SetCommand("NumOne"); }
        public DataContext NumTwo() { return this.SetCommand("NumTwo"); }
        public DataContext NumThree() { return this.SetCommand("NumThree"); }
        public DataContext NumFor() { return this.SetCommand("NumFor"); }
        public DataContext NumFive() { return this.SetCommand("NumFive"); }
        public DataContext NumSix() { return this.SetCommand("NumSix"); }
        public DataContext NumSeven() { return this.SetCommand("NumSeven"); }
        public DataContext NumEight() { return this.SetCommand("NumEight"); }
        public DataContext NumNine() { return this.SetCommand("NumNine"); }
        public DataContext NumStar() { return this.SetCommand("NumStar"); }
        public DataContext NumPlus() { return this.SetCommand("NumPlus"); }
        public DataContext NumMinus() { return this.SetCommand("NumMinus"); }
        public DataContext NumDot() { return this.SetCommand("NumDot"); }
        public DataContext NumSlash() { return this.SetCommand("NumSlash"); }
        public DataContext NUMLOCK()  { return this.SetCommand("NUMLOCK"); }
        #endregion
        #region // ...
        public DataContext Slash() { return this.SetCommand("Slash"); }
        public DataContext Space() { return this.SetCommand("Space"); }
        public DataContext Enter() { return this.SetCommand("Enter"); }
        public DataContext Mark() { return this.SetCommand("Mark"); }
        public DataContext Shift() { return this.SetCommand("Shift"); }
        public DataContext BACKSPACE() { return this.SetCommand("BACKSPACE"); }
        public DataContext TAB() { return this.SetCommand("TAB"); }
        public DataContext CTRL() { return this.SetCommand("CTRL"); }
        public DataContext ALT() { return this.SetCommand("ALT"); }
        public DataContext PAUSE() { return this.SetCommand("PAUSE"); }
        public DataContext CAPSLOCK() { return this.SetCommand("CAPSLOCK"); }
        public DataContext ESCAPE() { return this.SetCommand("ESCAPE"); }
        public DataContext PAGEUP() { return this.SetCommand("PAGEUP"); }
        public DataContext PAGEDOWN() { return this.SetCommand("PAGEDOWN"); }
        public DataContext END() { return this.SetCommand("END"); }
        public DataContext HOME() { return this.SetCommand("HOME"); }
        public DataContext LEFT() { return this.SetCommand("LEFT"); }
        public DataContext UP() { return this.SetCommand("UP"); }
        public DataContext RIGHT() { return this.SetCommand("RIGHT"); }
        public DataContext DOWN() { return this.SetCommand("DOWN"); }
        public DataContext INSERT() { return this.SetCommand("INSERT"); }
        public DataContext DELETE() { return this.SetCommand("DELETE"); }
        public DataContext LWIN() { return this.SetCommand("LWIN"); }
        public DataContext RWIN() { return this.SetCommand("RWIN"); }
        public DataContext SCROLLLOCK() { return this.SetCommand("SCROLLLOCK"); }
        public DataContext PRINTSCREEN() { return this.SetCommand("PRINTSCREEN"); }
        public DataContext PeriodComma() { return this.SetCommand("PeriodComma"); }
        public DataContext Equally() { return this.SetCommand("Equally"); }
        public DataContext Сomma() { return this.SetCommand("Сomma"); }
        public DataContext Minus() { return this.SetCommand("Minus"); }
        public DataContext Dot() { return this.SetCommand("Dot"); }
        public DataContext Tilda() { return this.SetCommand("Tilda"); }
        public DataContext SquScobOtk() { return this.SetCommand("SquScobOtk"); }
        public DataContext ObratSlash() { return this.SetCommand("ObratSlash"); }
        public DataContext SquScobZak() { return this.SetCommand("SquScobZak"); }
        public DataContext MouseL() { return this.SetCommand("MouseL"); }
        public DataContext MouseR() { return this.SetCommand("MouseR"); }
        public DataContext MMouse() { return this.SetCommand("MMouse"); }
        #endregion
        #region//Tech
        public DataContext Sleep_50() { return this.SetCommand("Sleep_50"); }
        public DataContext Sleep_500() { return this.SetCommand("Sleep_500"); }
        public DataContext Sleep_5000() { return this.SetCommand("Sleep_5000"); }
        public DataContext MMove_X_50()  { return this.SetCommand("MMove_X_50"); }
        public DataContext MMove_X_M50() { return this.SetCommand("MMove_X_M50"); }
        public DataContext MMove_Y_50() { return this.SetCommand("MMove_Y_50"); }
        public DataContext MMove_Y_M50() { return this.SetCommand("MMove_Y_M50"); }
        #endregion
        ////////////////////////////////////////////////////////
        //осталось запись написать
        public DataContext Execute() 
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
                    if (_Now is Sleep_) { _Now.Cast_As<Sleep_>().Up(); }
                    //Обрабатываем движения мыши
                    if (_Now is VMouseMove_) {; _Now.Cast_As<VMouseMove_>().Down(); }
                    //...
                    else {if (__Last.Where(_Last => _Now.p_Str == _Last.p_Str).ToList().Count() == 0)
                            if(_Now is VKeyboard) _Now.Cast_As<VKeyboard>().Down();
                    }
                        return _Now; 
                }).ToList();
            }
            return this;
        }
        public static void Test() 
        {
            new DataContext()
                .H().E().L().L().O().W().W().O().R().D()
            .WriteThis()
            ;
            "потестили".WriteLine();
        }
        public static void Test2()
        {
            new DataContext()
                .MMove_X_50()
                .Space().Space().Space()//пробелы
                .H().E().L().L().O().W().Space().W().O().R().D()//привет мир 
                //яростно вращаем мышкой
                .Sleep_500().MMove_X_50().Sleep_500().MMove_Y_50().Sleep_500().MMove_X_M50().Sleep_500().MMove_Y_M50()
                .Sleep_500().MMove_X_50().Sleep_500().MMove_Y_50().Sleep_500().MMove_X_M50().Sleep_500().MMove_Y_M50()
                .Sleep_500().MMove_X_50().Sleep_500().MMove_Y_50().Sleep_500().MMove_X_M50().Sleep_500().MMove_Y_M50()
                .Sleep_500().MMove_X_50().Sleep_500().MMove_Y_50().Sleep_500().MMove_X_M50().Sleep_500().MMove_Y_M50()
                .Execute()
                .WriteThis()
            ; ;
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