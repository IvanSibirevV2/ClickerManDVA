
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Linq;

namespace System
{
    public partial class Klava
    {
        public Klava Init()
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
            this.VKS.Add(this.VK_Slash.Set(_Sender:this));
            this.VKS.Add(this.VK_Space.Set(_Sender:this));
            this.VKS.Add(this.VK_Enter.Set(_Sender:this));
            this.VKS.Add(this.VK_Mark.Set(_Sender:this));
            this.VKS.Add(this.VK_Shift.Set(_Sender:this));
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
            this.VKS.Add(this.VK_MouseL.Set(_Sender:this));
            this.VKS.Add(this.VK_MouseR.Set(_Sender:this));
            this.VKS.Add(this.VK_MMouse.Set(_Sender:this));
            return this;
        }
    }
}

