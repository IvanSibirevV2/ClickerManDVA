
















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
        public VK VK_Slash=new VK().Set(_nVirtKey:191,_str:"Slash");
        public VK VK_Space=new VK().Set(_nVirtKey:32,_str:"Space");
        public VK VK_Enter=new VK().Set(_nVirtKey:13,_str:"Enter");
        public VK VK_Mark=new VK().Set(_nVirtKey:222,_str:"Mark");
        public VK VK_Shift=new VK().Set(_nVirtKey:16,_str:"Shift");
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
        public VK VK_MouseL=new VK().Set(_nVirtKey:1,_str:"MouseL");
        public VK VK_MouseR=new VK().Set(_nVirtKey:2,_str:"MouseR");
        public VK VK_MMouse=new VK().Set(_nVirtKey:4,_str:"MMouse");

        public List<VK> VKS = new List<VK>();
    }
}
















