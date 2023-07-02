#region Юзинги
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WindowsInput.Native;
using WindowsInput;
using static WpfDiplom.Pages.PGSetings;
using System.Reflection.Emit;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Windows.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using Microsoft.Win32;
using System.Runtime.CompilerServices;
//using ClickerManDVA_DVA;
using System.Threading;
#endregion
namespace WpfDiplom.Pages
{
    public partial class PGMainMenu : System.Windows.Controls.Page
    {
        private PGMainMenu Runn()
        {
            List<List<String>> _LLS = this.p_LLS_Record.Get__Copy();
        _LLS.Add(new List<System.String>());
            for (int i = 1; i < _LLS.Count(); i++)
            {
                            System.Threading.Thread.Sleep(50);
                var __Last = _LLS[i - 1];
                var __Now = _LLS[i];
# region Сначала обрабатываем отжатие клавишь                

                // смотрим предыдущий тик-строку
                //обрабатываем на Up только клавишу
                __Last.Where(_Last => __Now.Where(_Now => _Now == _Last).ToList().Count() == 0).ToList()
                    .ForEach(_Last => {
                //Страшное отжаьтие      
if (A_String() == _Last) A_Up();
if (B_String() == _Last) B_Up();
if (C_String() == _Last) C_Up();
if (D_String() == _Last) D_Up();
if (E_String() == _Last) E_Up();
if (F_String() == _Last) F_Up();
if (G_String() == _Last) G_Up();
if (H_String() == _Last) H_Up();
if (I_String() == _Last) I_Up();
if (J_String() == _Last) J_Up();
if (K_String() == _Last) K_Up();
if (L_String() == _Last) L_Up();
if (M_String() == _Last) M_Up();
if (N_String() == _Last) N_Up();
if (O_String() == _Last) O_Up();
if (P_String() == _Last) P_Up();
if (Q_String() == _Last) Q_Up();
if (R_String() == _Last) R_Up();
if (S_String() == _Last) S_Up();
if (T_String() == _Last) T_Up();
if (U_String() == _Last) U_Up();
if (V_String() == _Last) V_Up();
if (W_String() == _Last) W_Up();
if (X_String() == _Last) X_Up();
if (Y_String() == _Last) Y_Up();
if (Z_String() == _Last) Z_Up();
if (_0_String() == _Last) _0_Up();
if (_1_String() == _Last) _1_Up();
if (_2_String() == _Last) _2_Up();
if (_3_String() == _Last) _3_Up();
if (_4_String() == _Last) _4_Up();
if (_5_String() == _Last) _5_Up();
if (_6_String() == _Last) _6_Up();
if (_7_String() == _Last) _7_Up();
if (_8_String() == _Last) _8_Up();
if (_9_String() == _Last) _9_Up();
if (F1_String() == _Last) F1_Up();
if (F2_String() == _Last) F2_Up();
if (F3_String() == _Last) F3_Up();
if (F4_String() == _Last) F4_Up();
if (F5_String() == _Last) F5_Up();
if (F6_String() == _Last) F6_Up();
if (F7_String() == _Last) F7_Up();
if (F8_String() == _Last) F8_Up();
if (F9_String() == _Last) F9_Up();
if (F10_String() == _Last) F10_Up();
if (F11_String() == _Last) F11_Up();
if (F12_String() == _Last) F12_Up();
if (NumZero_String() == _Last) NumZero_Up();
if (NumOne_String() == _Last) NumOne_Up();
if (NumTwo_String() == _Last) NumTwo_Up();
if (NumThree_String() == _Last) NumThree_Up();
if (NumFor_String() == _Last) NumFor_Up();
if (NumFive_String() == _Last) NumFive_Up();
if (NumSix_String() == _Last) NumSix_Up();
if (NumSeven_String() == _Last) NumSeven_Up();
if (NumEight_String() == _Last) NumEight_Up();
if (NumNine_String() == _Last) NumNine_Up();
if (NumStar_String() == _Last) NumStar_Up();
if (NumPlus_String() == _Last) NumPlus_Up();
if (NumMinus_String() == _Last) NumMinus_Up();
if (NumDot_String() == _Last) NumDot_Up();
if (NumSlash_String() == _Last) NumSlash_Up();
if (NumEnter_String() == _Last) NumEnter_Up();
if (NUMLOCK_String() == _Last) NUMLOCK_Up();
if (Space_String() == _Last) Space_Up();
if (Enter_String() == _Last) Enter_Up();
if (Escape_String() == _Last) Escape_Up();
if (LShift_String() == _Last) LShift_Up();
if (RShift_String() == _Last) RShift_Up();
if (BackSpace_String() == _Last) BackSpace_Up();
if (Tab_String() == _Last) Tab_Up();
if (LeftCTRL_String() == _Last) LeftCTRL_Up();
if (RightCTRL_String() == _Last) RightCTRL_Up();
if (LeftAlt_String() == _Last) LeftAlt_Up();
if (RightAlt_String() == _Last) RightAlt_Up();
if (Pause_String() == _Last) Pause_Up();
if (CapsLock_String() == _Last) CapsLock_Up();
if (PageUp_String() == _Last) PageUp_Up();
if (PageDown_String() == _Last) PageDown_Up();
if (End_String() == _Last) End_Up();
if (Home_String() == _Last) Home_Up();
if (ArrowUp_String() == _Last) ArrowUp_Up();
if (ArrowLeft_String() == _Last) ArrowLeft_Up();
if (ArrowRight_String() == _Last) ArrowRight_Up();
if (ArrowDown_String() == _Last) ArrowDown_Up();
if (Insert_String() == _Last) Insert_Up();
if (Delete_String() == _Last) Delete_Up();
if (LeftWin_String() == _Last) LeftWin_Up();
if (RightWin_String() == _Last) RightWin_Up();
if (PrintScreen_String() == _Last) PrintScreen_Up();
if (ScrollLock_String() == _Last) ScrollLock_Up();
if (LeftMouse_String() == _Last) LeftMouse_Up();
if (RightMouse_String() == _Last) RightMouse_Up();
if (Equally_String() == _Last) Equally_Up();
if (Minus_String() == _Last) Minus_Up();
if (Сomma_String() == _Last) Сomma_Up();
if (Dot_String() == _Last) Dot_Up();
if (PeriodComma_String() == _Last) PeriodComma_Up();
if (Tilda_String() == _Last) Tilda_Up();
if (SquScobOtk_String() == _Last) SquScobOtk_Up();
if (SquScobZak_String() == _Last) SquScobZak_Up();
if (Slash_String() == _Last) Slash_Up();
if (ObratSlash_String() == _Last) ObratSlash_Up();
if (Mark_String() == _Last) Mark_Up();

                    });
                    #endregion
 __Now.Get__Copy().ForEach(_Now => 
 {
                    //Обрабатываем спячки в порядке поступления
                    if (_Now == "Sleep50") { System.Threading.Thread.Sleep(50); }
                    //оБРАБАТЫВАЕМ ДВИЖЕНИЕ МЫШИ
                       try
                    {
                        System.String _IfMouseStr = _Now.Split('_')[0];
                        System.String _IfMouseStr_Value = _Now.Split('_')[1];
                        int QWE = 0;
                        System.Int32.TryParse(_IfMouseStr_Value,out QWE);
                        this.GetCursorPos();
                        if (_IfMouseStr == "MouseMoveX"){Set_CursorPos(new XY() { X=QWE, Y=this.p_Now_XY.Y });}
                        if (_IfMouseStr == "MouseMoveNX") { Set_CursorPos(new XY() { X = QWE, Y = this.p_Now_XY.Y }); }
                        if (_IfMouseStr == "MouseMoveY") { Set_CursorPos(new XY() { X = this.p_Now_XY.X, Y =QWE }); }
                        if (_IfMouseStr == "MouseMoveNY") { Set_CursorPos(new XY() { X = this.p_Now_XY.X, Y =QWE }); }
                    }
                    catch { }
                    //оБРАБАТЫВАЕМ КЛАВИШИ
                    if (__Last.Where(_Last => _Now == _Last).ToList().Count() == 0)
                    {
if (A_String() == _Now) A_Down();
if (B_String() == _Now) B_Down();
if (C_String() == _Now) C_Down();
if (D_String() == _Now) D_Down();
if (E_String() == _Now) E_Down();
if (F_String() == _Now) F_Down();
if (G_String() == _Now) G_Down();
if (H_String() == _Now) H_Down();
if (I_String() == _Now) I_Down();
if (J_String() == _Now) J_Down();
if (K_String() == _Now) K_Down();
if (L_String() == _Now) L_Down();
if (M_String() == _Now) M_Down();
if (N_String() == _Now) N_Down();
if (O_String() == _Now) O_Down();
if (P_String() == _Now) P_Down();
if (Q_String() == _Now) Q_Down();
if (R_String() == _Now) R_Down();
if (S_String() == _Now) S_Down();
if (T_String() == _Now) T_Down();
if (U_String() == _Now) U_Down();
if (V_String() == _Now) V_Down();
if (W_String() == _Now) W_Down();
if (X_String() == _Now) X_Down();
if (Y_String() == _Now) Y_Down();
if (Z_String() == _Now) Z_Down();
if (_0_String() == _Now) _0_Down();
if (_1_String() == _Now) _1_Down();
if (_2_String() == _Now) _2_Down();
if (_3_String() == _Now) _3_Down();
if (_4_String() == _Now) _4_Down();
if (_5_String() == _Now) _5_Down();
if (_6_String() == _Now) _6_Down();
if (_7_String() == _Now) _7_Down();
if (_8_String() == _Now) _8_Down();
if (_9_String() == _Now) _9_Down();
if (F1_String() == _Now) F1_Down();
if (F2_String() == _Now) F2_Down();
if (F3_String() == _Now) F3_Down();
if (F4_String() == _Now) F4_Down();
if (F5_String() == _Now) F5_Down();
if (F6_String() == _Now) F6_Down();
if (F7_String() == _Now) F7_Down();
if (F8_String() == _Now) F8_Down();
if (F9_String() == _Now) F9_Down();
if (F10_String() == _Now) F10_Down();
if (F11_String() == _Now) F11_Down();
if (F12_String() == _Now) F12_Down();
if (NumZero_String() == _Now) NumZero_Down();
if (NumOne_String() == _Now) NumOne_Down();
if (NumTwo_String() == _Now) NumTwo_Down();
if (NumThree_String() == _Now) NumThree_Down();
if (NumFor_String() == _Now) NumFor_Down();
if (NumFive_String() == _Now) NumFive_Down();
if (NumSix_String() == _Now) NumSix_Down();
if (NumSeven_String() == _Now) NumSeven_Down();
if (NumEight_String() == _Now) NumEight_Down();
if (NumNine_String() == _Now) NumNine_Down();
if (NumStar_String() == _Now) NumStar_Down();
if (NumPlus_String() == _Now) NumPlus_Down();
if (NumMinus_String() == _Now) NumMinus_Down();
if (NumDot_String() == _Now) NumDot_Down();
if (NumSlash_String() == _Now) NumSlash_Down();
if (NumEnter_String() == _Now) NumEnter_Down();
if (NUMLOCK_String() == _Now) NUMLOCK_Down();
if (Space_String() == _Now) Space_Down();
if (Enter_String() == _Now) Enter_Down();
if (Escape_String() == _Now) Escape_Down();
if (LShift_String() == _Now) LShift_Down();
if (RShift_String() == _Now) RShift_Down();
if (BackSpace_String() == _Now) BackSpace_Down();
if (Tab_String() == _Now) Tab_Down();
if (LeftCTRL_String() == _Now) LeftCTRL_Down();
if (RightCTRL_String() == _Now) RightCTRL_Down();
if (LeftAlt_String() == _Now) LeftAlt_Down();
if (RightAlt_String() == _Now) RightAlt_Down();
if (Pause_String() == _Now) Pause_Down();
if (CapsLock_String() == _Now) CapsLock_Down();
if (PageUp_String() == _Now) PageUp_Down();
if (PageDown_String() == _Now) PageDown_Down();
if (End_String() == _Now) End_Down();
if (Home_String() == _Now) Home_Down();
if (ArrowUp_String() == _Now) ArrowUp_Down();
if (ArrowLeft_String() == _Now) ArrowLeft_Down();
if (ArrowRight_String() == _Now) ArrowRight_Down();
if (ArrowDown_String() == _Now) ArrowDown_Down();
if (Insert_String() == _Now) Insert_Down();
if (Delete_String() == _Now) Delete_Down();
if (LeftWin_String() == _Now) LeftWin_Down();
if (RightWin_String() == _Now) RightWin_Down();
if (PrintScreen_String() == _Now) PrintScreen_Down();
if (ScrollLock_String() == _Now) ScrollLock_Down();
if (LeftMouse_String() == _Now) LeftMouse_Down();
if (RightMouse_String() == _Now) RightMouse_Down();
if (Equally_String() == _Now) Equally_Down();
if (Minus_String() == _Now) Minus_Down();
if (Сomma_String() == _Now) Сomma_Down();
if (Dot_String() == _Now) Dot_Down();
if (PeriodComma_String() == _Now) PeriodComma_Down();
if (Tilda_String() == _Now) Tilda_Down();
if (SquScobOtk_String() == _Now) SquScobOtk_Down();
if (SquScobZak_String() == _Now) SquScobZak_Down();
if (Slash_String() == _Now) Slash_Down();
if (ObratSlash_String() == _Now) ObratSlash_Down();
if (Mark_String() == _Now) Mark_Down();
                    }
                 });

            }
                    #region qweqwe
                    #endregion
            return this;
        }


    }
}

