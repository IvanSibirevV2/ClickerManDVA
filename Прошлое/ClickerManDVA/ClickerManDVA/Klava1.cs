
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Linq;

namespace System
{
    public partial class Klava
    {    
        public VK VK_A=new VK().Set(_nVirtKey:65,_str:"A");
        public VK VK_B=new VK().Set(_nVirtKey:66,_str:"B");
        public VK VK_C=new VK().Set(_nVirtKey:67,_str:"C");
        public VK VK_D=new VK().Set(_nVirtKey:68,_str:"D");
        public VK VK_E=new VK().Set(_nVirtKey:69,_str:"E");
        public VK VK_F=new VK().Set(_nVirtKey:70,_str:"F");
        public VK VK_G=new VK().Set(_nVirtKey:71,_str:"G");
        public VK VK_H=new VK().Set(_nVirtKey:72,_str:"H");
        public VK VK_I=new VK().Set(_nVirtKey:73,_str:"I");
        public VK VK_J=new VK().Set(_nVirtKey:74,_str:"J");
        public VK VK_K=new VK().Set(_nVirtKey:75,_str:"K");
        public VK VK_L=new VK().Set(_nVirtKey:76,_str:"L");
        public VK VK_M=new VK().Set(_nVirtKey:77,_str:"M");
        public VK VK_N=new VK().Set(_nVirtKey:78,_str:"N");
        public VK VK_O=new VK().Set(_nVirtKey:79,_str:"O");
        public VK VK_P=new VK().Set(_nVirtKey:80,_str:"P");
        public VK VK_Q=new VK().Set(_nVirtKey:81,_str:"Q");
        public VK VK_R=new VK().Set(_nVirtKey:82,_str:"R");
        public VK VK_S=new VK().Set(_nVirtKey:83,_str:"S");
        public VK VK_T=new VK().Set(_nVirtKey:84,_str:"T");
        public VK VK_U=new VK().Set(_nVirtKey:85,_str:"U");
        public VK VK_V=new VK().Set(_nVirtKey:86,_str:"V");
        public VK VK_W=new VK().Set(_nVirtKey:87,_str:"W");
        public VK VK_X=new VK().Set(_nVirtKey:88,_str:"X");
        public VK VK_Y=new VK().Set(_nVirtKey:89,_str:"Y");
        public VK VK_Z=new VK().Set(_nVirtKey:90,_str:"Z");
        public VK VK_Slash=new VK().Set(_nVirtKey:191,_str:"Slash");
        public VK VK_Space=new VK().Set(_nVirtKey:32,_str:"Space");
        public VK VK__0=new VK().Set(_nVirtKey:48,_str:"_0");
        public VK VK__1=new VK().Set(_nVirtKey:49,_str:"_1");
        public VK VK__2=new VK().Set(_nVirtKey:50,_str:"_2");
        public VK VK__3=new VK().Set(_nVirtKey:51,_str:"_3");
        public VK VK__4=new VK().Set(_nVirtKey:52,_str:"_4");
        public VK VK__5=new VK().Set(_nVirtKey:53,_str:"_5");
        public VK VK__6=new VK().Set(_nVirtKey:54,_str:"_6");
        public VK VK__7=new VK().Set(_nVirtKey:55,_str:"_7");
        public VK VK__8=new VK().Set(_nVirtKey:56,_str:"_8");
        public VK VK__9=new VK().Set(_nVirtKey:57,_str:"_9");
        public VK VK_Enter=new VK().Set(_nVirtKey:13,_str:"Enter");
        public VK VK_Mark=new VK().Set(_nVirtKey:222,_str:"Mark");
        public VK VK_Shift=new VK().Set(_nVirtKey:16,_str:"Shift");
        public VK VK_MouseL=new VK().Set(_nVirtKey:1,_str:"MouseL");
        public VK VK_MouseR=new VK().Set(_nVirtKey:2,_str:"MouseR");
        public VK VK_MMouse=new VK().Set(_nVirtKey:4,_str:"MMouse");
        public VK VK_BACKSPACE=new VK().Set(_nVirtKey:8,_str:"BACKSPACE");
        public VK VK_TAB=new VK().Set(_nVirtKey:9,_str:"TAB");
        public VK VK_CTRL=new VK().Set(_nVirtKey:17,_str:"CTRL");
        public VK VK_ALT=new VK().Set(_nVirtKey:18,_str:"ALT");
        public VK VK_PAUSE=new VK().Set(_nVirtKey:19,_str:"PAUSE");
        public VK VK_CAPSLOCK=new VK().Set(_nVirtKey:20,_str:"CAPSLOCK");
        public VK VK_ESCAPE=new VK().Set(_nVirtKey:27,_str:"ESCAPE");
        public VK VK_PAGEUP=new VK().Set(_nVirtKey:33,_str:"PAGEUP");
        public VK VK_PAGEDOWN=new VK().Set(_nVirtKey:34,_str:"PAGEDOWN");
        public VK VK_END=new VK().Set(_nVirtKey:35,_str:"END");
        public VK VK_HOME=new VK().Set(_nVirtKey:36,_str:"HOME");
        public VK VK_LEFT=new VK().Set(_nVirtKey:37,_str:"LEFT");
        public VK VK_UP=new VK().Set(_nVirtKey:38,_str:"UP");
        public VK VK_RIGHT=new VK().Set(_nVirtKey:39,_str:"RIGHT");
        public VK VK_DOWN=new VK().Set(_nVirtKey:40,_str:"DOWN");
        public VK VK_INSERT=new VK().Set(_nVirtKey:45,_str:"INSERT");
        public VK VK_DELETE=new VK().Set(_nVirtKey:46,_str:"DELETE");
        public VK VK_LWIN=new VK().Set(_nVirtKey:91,_str:"LWIN");
        public VK VK_RWIN=new VK().Set(_nVirtKey:92,_str:"RWIN");
        public VK VK_NumZero=new VK().Set(_nVirtKey:96,_str:"NumZero");
        public VK VK_NumOne=new VK().Set(_nVirtKey:97,_str:"NumOne");
        public VK VK_NumTwo=new VK().Set(_nVirtKey:98,_str:"NumTwo");
        public VK VK_NumThree=new VK().Set(_nVirtKey:99,_str:"NumThree");
        public VK VK_NumFor=new VK().Set(_nVirtKey:100,_str:"NumFor");
        public VK VK_NumFive=new VK().Set(_nVirtKey:101,_str:"NumFive");
        public VK VK_NumSix=new VK().Set(_nVirtKey:102,_str:"NumSix");
        public VK VK_NumSeven=new VK().Set(_nVirtKey:103,_str:"NumSeven");
        public VK VK_NumEight=new VK().Set(_nVirtKey:104,_str:"NumEight");
        public VK VK_NumNine=new VK().Set(_nVirtKey:105,_str:"NumNine");
        public VK VK_NumStar=new VK().Set(_nVirtKey:106,_str:"NumStar");
        public VK VK_NumPlus=new VK().Set(_nVirtKey:107,_str:"NumPlus");
        public VK VK_NumMinus=new VK().Set(_nVirtKey:109,_str:"NumMinus");
        public VK VK_NumDot=new VK().Set(_nVirtKey:110,_str:"NumDot");
        public VK VK_NumSlash=new VK().Set(_nVirtKey:111,_str:"NumSlash");
        public VK VK_F1=new VK().Set(_nVirtKey:112,_str:"F1");
        public VK VK_F2=new VK().Set(_nVirtKey:113,_str:"F2");
        public VK VK_F3=new VK().Set(_nVirtKey:114,_str:"F3");
        public VK VK_F4=new VK().Set(_nVirtKey:115,_str:"F4");
        public VK VK_F5=new VK().Set(_nVirtKey:116,_str:"F5");
        public VK VK_F6=new VK().Set(_nVirtKey:117,_str:"F6");
        public VK VK_F7=new VK().Set(_nVirtKey:118,_str:"F7");
        public VK VK_F8=new VK().Set(_nVirtKey:119,_str:"F8");
        public VK VK_F9=new VK().Set(_nVirtKey:120,_str:"F9");
        public VK VK_F10=new VK().Set(_nVirtKey:121,_str:"F10");
        public VK VK_F11=new VK().Set(_nVirtKey:122,_str:"F11");
        public VK VK_F12=new VK().Set(_nVirtKey:123,_str:"F12");
        public VK VK_NUMLOCK=new VK().Set(_nVirtKey:144,_str:"NUMLOCK");
        public VK VK_SCROLLLOCK=new VK().Set(_nVirtKey:145,_str:"SCROLLLOCK");
        public VK VK_PRINTSCREEN=new VK().Set(_nVirtKey:154,_str:"PRINTSCREEN");
        public VK VK_PeriodComma=new VK().Set(_nVirtKey:186,_str:"PeriodComma");
        public VK VK_Equally=new VK().Set(_nVirtKey:187,_str:"Equally");
        public VK VK_Сomma=new VK().Set(_nVirtKey:188,_str:"Сomma");
        public VK VK_Minus=new VK().Set(_nVirtKey:189,_str:"Minus");
        public VK VK_Dot=new VK().Set(_nVirtKey:190,_str:"Dot");
        public VK VK_Tilda=new VK().Set(_nVirtKey:192,_str:"Tilda");
        public VK VK_SquScobOtk=new VK().Set(_nVirtKey:219,_str:"SquScobOtk");
        public VK VK_ObratSlash=new VK().Set(_nVirtKey:220,_str:"ObratSlash");
        public VK VK_SquScobZak=new VK().Set(_nVirtKey:221,_str:"SquScobZak");
        public List<VK> VKS = new List<VK>();
        public Klava()
        {
            this.VKS.Clear();
            this.VKS.Add(this.VK_A.Set(_Sender:this));
            this.VKS.Add(this.VK_B.Set(_Sender:this));
            this.VKS.Add(this.VK_C.Set(_Sender:this));
            this.VKS.Add(this.VK_D.Set(_Sender:this));
            this.VKS.Add(this.VK_E.Set(_Sender:this));
            this.VKS.Add(this.VK_F.Set(_Sender:this));
            this.VKS.Add(this.VK_G.Set(_Sender:this));
            this.VKS.Add(this.VK_H.Set(_Sender:this));
            this.VKS.Add(this.VK_I.Set(_Sender:this));
            this.VKS.Add(this.VK_J.Set(_Sender:this));
            this.VKS.Add(this.VK_K.Set(_Sender:this));
            this.VKS.Add(this.VK_L.Set(_Sender:this));
            this.VKS.Add(this.VK_M.Set(_Sender:this));
            this.VKS.Add(this.VK_N.Set(_Sender:this));
            this.VKS.Add(this.VK_O.Set(_Sender:this));
            this.VKS.Add(this.VK_P.Set(_Sender:this));
            this.VKS.Add(this.VK_Q.Set(_Sender:this));
            this.VKS.Add(this.VK_R.Set(_Sender:this));
            this.VKS.Add(this.VK_S.Set(_Sender:this));
            this.VKS.Add(this.VK_T.Set(_Sender:this));
            this.VKS.Add(this.VK_U.Set(_Sender:this));
            this.VKS.Add(this.VK_V.Set(_Sender:this));
            this.VKS.Add(this.VK_W.Set(_Sender:this));
            this.VKS.Add(this.VK_X.Set(_Sender:this));
            this.VKS.Add(this.VK_Y.Set(_Sender:this));
            this.VKS.Add(this.VK_Z.Set(_Sender:this));
            this.VKS.Add(this.VK_Slash.Set(_Sender:this));
            this.VKS.Add(this.VK_Space.Set(_Sender:this));
            this.VKS.Add(this.VK__0.Set(_Sender:this));
            this.VKS.Add(this.VK__1.Set(_Sender:this));
            this.VKS.Add(this.VK__2.Set(_Sender:this));
            this.VKS.Add(this.VK__3.Set(_Sender:this));
            this.VKS.Add(this.VK__4.Set(_Sender:this));
            this.VKS.Add(this.VK__5.Set(_Sender:this));
            this.VKS.Add(this.VK__6.Set(_Sender:this));
            this.VKS.Add(this.VK__7.Set(_Sender:this));
            this.VKS.Add(this.VK__8.Set(_Sender:this));
            this.VKS.Add(this.VK__9.Set(_Sender:this));
            this.VKS.Add(this.VK_Enter.Set(_Sender:this));
            this.VKS.Add(this.VK_Mark.Set(_Sender:this));
            this.VKS.Add(this.VK_Shift.Set(_Sender:this));
            this.VKS.Add(this.VK_MouseL.Set(_Sender:this));
            this.VKS.Add(this.VK_MouseR.Set(_Sender:this));
            this.VKS.Add(this.VK_MMouse.Set(_Sender:this));
            this.VKS.Add(this.VK_BACKSPACE.Set(_Sender:this));
            this.VKS.Add(this.VK_TAB.Set(_Sender:this));
            this.VKS.Add(this.VK_CTRL.Set(_Sender:this));
            this.VKS.Add(this.VK_ALT.Set(_Sender:this));
            this.VKS.Add(this.VK_PAUSE.Set(_Sender:this));
            this.VKS.Add(this.VK_CAPSLOCK.Set(_Sender:this));
            this.VKS.Add(this.VK_ESCAPE.Set(_Sender:this));
            this.VKS.Add(this.VK_PAGEUP.Set(_Sender:this));
            this.VKS.Add(this.VK_PAGEDOWN.Set(_Sender:this));
            this.VKS.Add(this.VK_END.Set(_Sender:this));
            this.VKS.Add(this.VK_HOME.Set(_Sender:this));
            this.VKS.Add(this.VK_LEFT.Set(_Sender:this));
            this.VKS.Add(this.VK_UP.Set(_Sender:this));
            this.VKS.Add(this.VK_RIGHT.Set(_Sender:this));
            this.VKS.Add(this.VK_DOWN.Set(_Sender:this));
            this.VKS.Add(this.VK_INSERT.Set(_Sender:this));
            this.VKS.Add(this.VK_DELETE.Set(_Sender:this));
            this.VKS.Add(this.VK_LWIN.Set(_Sender:this));
            this.VKS.Add(this.VK_RWIN.Set(_Sender:this));
            this.VKS.Add(this.VK_NumZero.Set(_Sender:this));
            this.VKS.Add(this.VK_NumOne.Set(_Sender:this));
            this.VKS.Add(this.VK_NumTwo.Set(_Sender:this));
            this.VKS.Add(this.VK_NumThree.Set(_Sender:this));
            this.VKS.Add(this.VK_NumFor.Set(_Sender:this));
            this.VKS.Add(this.VK_NumFive.Set(_Sender:this));
            this.VKS.Add(this.VK_NumSix.Set(_Sender:this));
            this.VKS.Add(this.VK_NumSeven.Set(_Sender:this));
            this.VKS.Add(this.VK_NumEight.Set(_Sender:this));
            this.VKS.Add(this.VK_NumNine.Set(_Sender:this));
            this.VKS.Add(this.VK_NumStar.Set(_Sender:this));
            this.VKS.Add(this.VK_NumPlus.Set(_Sender:this));
            this.VKS.Add(this.VK_NumMinus.Set(_Sender:this));
            this.VKS.Add(this.VK_NumDot.Set(_Sender:this));
            this.VKS.Add(this.VK_NumSlash.Set(_Sender:this));
            this.VKS.Add(this.VK_F1.Set(_Sender:this));
            this.VKS.Add(this.VK_F2.Set(_Sender:this));
            this.VKS.Add(this.VK_F3.Set(_Sender:this));
            this.VKS.Add(this.VK_F4.Set(_Sender:this));
            this.VKS.Add(this.VK_F5.Set(_Sender:this));
            this.VKS.Add(this.VK_F6.Set(_Sender:this));
            this.VKS.Add(this.VK_F7.Set(_Sender:this));
            this.VKS.Add(this.VK_F8.Set(_Sender:this));
            this.VKS.Add(this.VK_F9.Set(_Sender:this));
            this.VKS.Add(this.VK_F10.Set(_Sender:this));
            this.VKS.Add(this.VK_F11.Set(_Sender:this));
            this.VKS.Add(this.VK_F12.Set(_Sender:this));
            this.VKS.Add(this.VK_NUMLOCK.Set(_Sender:this));
            this.VKS.Add(this.VK_SCROLLLOCK.Set(_Sender:this));
            this.VKS.Add(this.VK_PRINTSCREEN.Set(_Sender:this));
            this.VKS.Add(this.VK_PeriodComma.Set(_Sender:this));
            this.VKS.Add(this.VK_Equally.Set(_Sender:this));
            this.VKS.Add(this.VK_Сomma.Set(_Sender:this));
            this.VKS.Add(this.VK_Minus.Set(_Sender:this));
            this.VKS.Add(this.VK_Dot.Set(_Sender:this));
            this.VKS.Add(this.VK_Tilda.Set(_Sender:this));
            this.VKS.Add(this.VK_SquScobOtk.Set(_Sender:this));
            this.VKS.Add(this.VK_ObratSlash.Set(_Sender:this));
            this.VKS.Add(this.VK_SquScobZak.Set(_Sender:this));
        }
        public Klava A{get{this.VK_A.Down().Sleep().Up(); return this;} }
        public Klava B{get{this.VK_B.Down().Sleep().Up(); return this;} }
        public Klava C{get{this.VK_C.Down().Sleep().Up(); return this;} }
        public Klava D{get{this.VK_D.Down().Sleep().Up(); return this;} }
        public Klava E{get{this.VK_E.Down().Sleep().Up(); return this;} }
        public Klava F{get{this.VK_F.Down().Sleep().Up(); return this;} }
        public Klava G{get{this.VK_G.Down().Sleep().Up(); return this;} }
        public Klava H{get{this.VK_H.Down().Sleep().Up(); return this;} }
        public Klava I{get{this.VK_I.Down().Sleep().Up(); return this;} }
        public Klava J{get{this.VK_J.Down().Sleep().Up(); return this;} }
        public Klava K{get{this.VK_K.Down().Sleep().Up(); return this;} }
        public Klava L{get{this.VK_L.Down().Sleep().Up(); return this;} }
        public Klava M{get{this.VK_M.Down().Sleep().Up(); return this;} }
        public Klava N{get{this.VK_N.Down().Sleep().Up(); return this;} }
        public Klava O{get{this.VK_O.Down().Sleep().Up(); return this;} }
        public Klava P{get{this.VK_P.Down().Sleep().Up(); return this;} }
        public Klava Q{get{this.VK_Q.Down().Sleep().Up(); return this;} }
        public Klava R{get{this.VK_R.Down().Sleep().Up(); return this;} }
        public Klava S{get{this.VK_S.Down().Sleep().Up(); return this;} }
        public Klava T{get{this.VK_T.Down().Sleep().Up(); return this;} }
        public Klava U{get{this.VK_U.Down().Sleep().Up(); return this;} }
        public Klava V{get{this.VK_V.Down().Sleep().Up(); return this;} }
        public Klava W{get{this.VK_W.Down().Sleep().Up(); return this;} }
        public Klava X{get{this.VK_X.Down().Sleep().Up(); return this;} }
        public Klava Y{get{this.VK_Y.Down().Sleep().Up(); return this;} }
        public Klava Z{get{this.VK_Z.Down().Sleep().Up(); return this;} }
        public Klava Slash{get{this.VK_Slash.Down().Sleep().Up(); return this;} }
        public Klava Space{get{this.VK_Space.Down().Sleep().Up(); return this;} }
        public Klava _0{get{this.VK__0.Down().Sleep().Up(); return this;} }
        public Klava _1{get{this.VK__1.Down().Sleep().Up(); return this;} }
        public Klava _2{get{this.VK__2.Down().Sleep().Up(); return this;} }
        public Klava _3{get{this.VK__3.Down().Sleep().Up(); return this;} }
        public Klava _4{get{this.VK__4.Down().Sleep().Up(); return this;} }
        public Klava _5{get{this.VK__5.Down().Sleep().Up(); return this;} }
        public Klava _6{get{this.VK__6.Down().Sleep().Up(); return this;} }
        public Klava _7{get{this.VK__7.Down().Sleep().Up(); return this;} }
        public Klava _8{get{this.VK__8.Down().Sleep().Up(); return this;} }
        public Klava _9{get{this.VK__9.Down().Sleep().Up(); return this;} }
        public Klava Enter{get{this.VK_Enter.Down().Sleep().Up(); return this;} }
        public Klava Mark{get{this.VK_Mark.Down().Sleep().Up(); return this;} }
        public Klava Shift{get{this.VK_Shift.Down().Sleep().Up(); return this;} }
        public Klava MouseL{get{this.VK_MouseL.Down().Sleep().Up(); return this;} }
        public Klava MouseR{get{this.VK_MouseR.Down().Sleep().Up(); return this;} }
        public Klava MMouse{get{this.VK_MMouse.Down().Sleep().Up(); return this;} }
        public Klava BACKSPACE{get{this.VK_BACKSPACE.Down().Sleep().Up(); return this;} }
        public Klava TAB{get{this.VK_TAB.Down().Sleep().Up(); return this;} }
        public Klava CTRL{get{this.VK_CTRL.Down().Sleep().Up(); return this;} }
        public Klava ALT{get{this.VK_ALT.Down().Sleep().Up(); return this;} }
        public Klava PAUSE{get{this.VK_PAUSE.Down().Sleep().Up(); return this;} }
        public Klava CAPSLOCK{get{this.VK_CAPSLOCK.Down().Sleep().Up(); return this;} }
        public Klava ESCAPE{get{this.VK_ESCAPE.Down().Sleep().Up(); return this;} }
        public Klava PAGEUP{get{this.VK_PAGEUP.Down().Sleep().Up(); return this;} }
        public Klava PAGEDOWN{get{this.VK_PAGEDOWN.Down().Sleep().Up(); return this;} }
        public Klava END{get{this.VK_END.Down().Sleep().Up(); return this;} }
        public Klava HOME{get{this.VK_HOME.Down().Sleep().Up(); return this;} }
        public Klava LEFT{get{this.VK_LEFT.Down().Sleep().Up(); return this;} }
        public Klava UP{get{this.VK_UP.Down().Sleep().Up(); return this;} }
        public Klava RIGHT{get{this.VK_RIGHT.Down().Sleep().Up(); return this;} }
        public Klava DOWN{get{this.VK_DOWN.Down().Sleep().Up(); return this;} }
        public Klava INSERT{get{this.VK_INSERT.Down().Sleep().Up(); return this;} }
        public Klava DELETE{get{this.VK_DELETE.Down().Sleep().Up(); return this;} }
        public Klava LWIN{get{this.VK_LWIN.Down().Sleep().Up(); return this;} }
        public Klava RWIN{get{this.VK_RWIN.Down().Sleep().Up(); return this;} }
        public Klava NumZero{get{this.VK_NumZero.Down().Sleep().Up(); return this;} }
        public Klava NumOne{get{this.VK_NumOne.Down().Sleep().Up(); return this;} }
        public Klava NumTwo{get{this.VK_NumTwo.Down().Sleep().Up(); return this;} }
        public Klava NumThree{get{this.VK_NumThree.Down().Sleep().Up(); return this;} }
        public Klava NumFor{get{this.VK_NumFor.Down().Sleep().Up(); return this;} }
        public Klava NumFive{get{this.VK_NumFive.Down().Sleep().Up(); return this;} }
        public Klava NumSix{get{this.VK_NumSix.Down().Sleep().Up(); return this;} }
        public Klava NumSeven{get{this.VK_NumSeven.Down().Sleep().Up(); return this;} }
        public Klava NumEight{get{this.VK_NumEight.Down().Sleep().Up(); return this;} }
        public Klava NumNine{get{this.VK_NumNine.Down().Sleep().Up(); return this;} }
        public Klava NumStar{get{this.VK_NumStar.Down().Sleep().Up(); return this;} }
        public Klava NumPlus{get{this.VK_NumPlus.Down().Sleep().Up(); return this;} }
        public Klava NumMinus{get{this.VK_NumMinus.Down().Sleep().Up(); return this;} }
        public Klava NumDot{get{this.VK_NumDot.Down().Sleep().Up(); return this;} }
        public Klava NumSlash{get{this.VK_NumSlash.Down().Sleep().Up(); return this;} }
        public Klava F1{get{this.VK_F1.Down().Sleep().Up(); return this;} }
        public Klava F2{get{this.VK_F2.Down().Sleep().Up(); return this;} }
        public Klava F3{get{this.VK_F3.Down().Sleep().Up(); return this;} }
        public Klava F4{get{this.VK_F4.Down().Sleep().Up(); return this;} }
        public Klava F5{get{this.VK_F5.Down().Sleep().Up(); return this;} }
        public Klava F6{get{this.VK_F6.Down().Sleep().Up(); return this;} }
        public Klava F7{get{this.VK_F7.Down().Sleep().Up(); return this;} }
        public Klava F8{get{this.VK_F8.Down().Sleep().Up(); return this;} }
        public Klava F9{get{this.VK_F9.Down().Sleep().Up(); return this;} }
        public Klava F10{get{this.VK_F10.Down().Sleep().Up(); return this;} }
        public Klava F11{get{this.VK_F11.Down().Sleep().Up(); return this;} }
        public Klava F12{get{this.VK_F12.Down().Sleep().Up(); return this;} }
        public Klava NUMLOCK{get{this.VK_NUMLOCK.Down().Sleep().Up(); return this;} }
        public Klava SCROLLLOCK{get{this.VK_SCROLLLOCK.Down().Sleep().Up(); return this;} }
        public Klava PRINTSCREEN{get{this.VK_PRINTSCREEN.Down().Sleep().Up(); return this;} }
        public Klava PeriodComma{get{this.VK_PeriodComma.Down().Sleep().Up(); return this;} }
        public Klava Equally{get{this.VK_Equally.Down().Sleep().Up(); return this;} }
        public Klava Сomma{get{this.VK_Сomma.Down().Sleep().Up(); return this;} }
        public Klava Minus{get{this.VK_Minus.Down().Sleep().Up(); return this;} }
        public Klava Dot{get{this.VK_Dot.Down().Sleep().Up(); return this;} }
        public Klava Tilda{get{this.VK_Tilda.Down().Sleep().Up(); return this;} }
        public Klava SquScobOtk{get{this.VK_SquScobOtk.Down().Sleep().Up(); return this;} }
        public Klava ObratSlash{get{this.VK_ObratSlash.Down().Sleep().Up(); return this;} }
        public Klava SquScobZak{get{this.VK_SquScobZak.Down().Sleep().Up(); return this;} }
    }
}

