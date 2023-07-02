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
        private PGMainMenu ForKeyIs() 
        {
            if (this.ArrowLeft_Is()) { this.ArrowLeft_Set_Background_Green(); } else { this.ArrowLeft_Set_Background_Gray(); }
            if (this.ArrowRight_Is()) { this.ArrowRight_Set_Background_Green(); } else { this.ArrowRight_Set_Background_Gray(); }
            thread = new Thread(A => {
                while (WpfDiplom.ThreadKran._Flag)
                {
                    System.Boolean _Rec = false;Dispatcher.InvokeAsync(() => _Rec = this.p_Record);List<System.String> LS_Rec = new List<System.String>();
                    System.Threading.Thread.Sleep(50);
                    #region qweqwe
if (this.A_Is()) { this.A_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.A_String()); } else { this.A_Set_Background_Gray(); }
if (this.B_Is()) { this.B_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.B_String()); } else { this.B_Set_Background_Gray(); }
if (this.C_Is()) { this.C_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.C_String()); } else { this.C_Set_Background_Gray(); }
if (this.D_Is()) { this.D_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.D_String()); } else { this.D_Set_Background_Gray(); }
if (this.E_Is()) { this.E_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.E_String()); } else { this.E_Set_Background_Gray(); }
if (this.F_Is()) { this.F_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.F_String()); } else { this.F_Set_Background_Gray(); }
if (this.G_Is()) { this.G_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.G_String()); } else { this.G_Set_Background_Gray(); }
if (this.H_Is()) { this.H_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.H_String()); } else { this.H_Set_Background_Gray(); }
if (this.I_Is()) { this.I_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.I_String()); } else { this.I_Set_Background_Gray(); }
if (this.J_Is()) { this.J_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.J_String()); } else { this.J_Set_Background_Gray(); }
if (this.K_Is()) { this.K_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.K_String()); } else { this.K_Set_Background_Gray(); }
if (this.L_Is()) { this.L_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.L_String()); } else { this.L_Set_Background_Gray(); }
if (this.M_Is()) { this.M_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.M_String()); } else { this.M_Set_Background_Gray(); }
if (this.N_Is()) { this.N_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.N_String()); } else { this.N_Set_Background_Gray(); }
if (this.O_Is()) { this.O_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.O_String()); } else { this.O_Set_Background_Gray(); }
if (this.P_Is()) { this.P_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.P_String()); } else { this.P_Set_Background_Gray(); }
if (this.Q_Is()) { this.Q_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.Q_String()); } else { this.Q_Set_Background_Gray(); }
if (this.R_Is()) { this.R_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.R_String()); } else { this.R_Set_Background_Gray(); }
if (this.S_Is()) { this.S_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.S_String()); } else { this.S_Set_Background_Gray(); }
if (this.T_Is()) { this.T_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.T_String()); } else { this.T_Set_Background_Gray(); }
if (this.U_Is()) { this.U_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.U_String()); } else { this.U_Set_Background_Gray(); }
if (this.V_Is()) { this.V_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.V_String()); } else { this.V_Set_Background_Gray(); }
if (this.W_Is()) { this.W_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.W_String()); } else { this.W_Set_Background_Gray(); }
if (this.X_Is()) { this.X_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.X_String()); } else { this.X_Set_Background_Gray(); }
if (this.Y_Is()) { this.Y_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.Y_String()); } else { this.Y_Set_Background_Gray(); }
if (this.Z_Is()) { this.Z_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.Z_String()); } else { this.Z_Set_Background_Gray(); }
if (this._0_Is()) { this._0_Set_Background_Green(); if (_Rec) LS_Rec.Add(this._0_String()); } else { this._0_Set_Background_Gray(); }
if (this._1_Is()) { this._1_Set_Background_Green(); if (_Rec) LS_Rec.Add(this._1_String()); } else { this._1_Set_Background_Gray(); }
if (this._2_Is()) { this._2_Set_Background_Green(); if (_Rec) LS_Rec.Add(this._2_String()); } else { this._2_Set_Background_Gray(); }
if (this._3_Is()) { this._3_Set_Background_Green(); if (_Rec) LS_Rec.Add(this._3_String()); } else { this._3_Set_Background_Gray(); }
if (this._4_Is()) { this._4_Set_Background_Green(); if (_Rec) LS_Rec.Add(this._4_String()); } else { this._4_Set_Background_Gray(); }
if (this._5_Is()) { this._5_Set_Background_Green(); if (_Rec) LS_Rec.Add(this._5_String()); } else { this._5_Set_Background_Gray(); }
if (this._6_Is()) { this._6_Set_Background_Green(); if (_Rec) LS_Rec.Add(this._6_String()); } else { this._6_Set_Background_Gray(); }
if (this._7_Is()) { this._7_Set_Background_Green(); if (_Rec) LS_Rec.Add(this._7_String()); } else { this._7_Set_Background_Gray(); }
if (this._8_Is()) { this._8_Set_Background_Green(); if (_Rec) LS_Rec.Add(this._8_String()); } else { this._8_Set_Background_Gray(); }
if (this._9_Is()) { this._9_Set_Background_Green(); if (_Rec) LS_Rec.Add(this._9_String()); } else { this._9_Set_Background_Gray(); }
if (this.F1_Is()) { this.F1_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.F1_String()); } else { this.F1_Set_Background_Gray(); }
if (this.F2_Is()) { this.F2_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.F2_String()); } else { this.F2_Set_Background_Gray(); }
if (this.F3_Is()) { this.F3_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.F3_String()); } else { this.F3_Set_Background_Gray(); }
if (this.F4_Is()) { this.F4_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.F4_String()); } else { this.F4_Set_Background_Gray(); }
if (this.F5_Is()) { this.F5_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.F5_String()); } else { this.F5_Set_Background_Gray(); }
if (this.F6_Is()) { this.F6_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.F6_String()); } else { this.F6_Set_Background_Gray(); }
if (this.F7_Is()) { this.F7_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.F7_String()); } else { this.F7_Set_Background_Gray(); }
if (this.F8_Is()) { this.F8_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.F8_String()); } else { this.F8_Set_Background_Gray(); }
if (this.F9_Is()) { this.F9_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.F9_String()); } else { this.F9_Set_Background_Gray(); }
if (this.F10_Is()) { this.F10_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.F10_String()); } else { this.F10_Set_Background_Gray(); }
if (this.F11_Is()) { this.F11_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.F11_String()); } else { this.F11_Set_Background_Gray(); }
if (this.F12_Is()) { this.F12_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.F12_String()); } else { this.F12_Set_Background_Gray(); }
if (this.NumZero_Is()) { this.NumZero_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.NumZero_String()); } else { this.NumZero_Set_Background_Gray(); }
if (this.NumOne_Is()) { this.NumOne_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.NumOne_String()); } else { this.NumOne_Set_Background_Gray(); }
if (this.NumTwo_Is()) { this.NumTwo_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.NumTwo_String()); } else { this.NumTwo_Set_Background_Gray(); }
if (this.NumThree_Is()) { this.NumThree_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.NumThree_String()); } else { this.NumThree_Set_Background_Gray(); }
if (this.NumFor_Is()) { this.NumFor_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.NumFor_String()); } else { this.NumFor_Set_Background_Gray(); }
if (this.NumFive_Is()) { this.NumFive_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.NumFive_String()); } else { this.NumFive_Set_Background_Gray(); }
if (this.NumSix_Is()) { this.NumSix_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.NumSix_String()); } else { this.NumSix_Set_Background_Gray(); }
if (this.NumSeven_Is()) { this.NumSeven_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.NumSeven_String()); } else { this.NumSeven_Set_Background_Gray(); }
if (this.NumEight_Is()) { this.NumEight_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.NumEight_String()); } else { this.NumEight_Set_Background_Gray(); }
if (this.NumNine_Is()) { this.NumNine_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.NumNine_String()); } else { this.NumNine_Set_Background_Gray(); }
if (this.NumStar_Is()) { this.NumStar_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.NumStar_String()); } else { this.NumStar_Set_Background_Gray(); }
if (this.NumPlus_Is()) { this.NumPlus_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.NumPlus_String()); } else { this.NumPlus_Set_Background_Gray(); }
if (this.NumMinus_Is()) { this.NumMinus_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.NumMinus_String()); } else { this.NumMinus_Set_Background_Gray(); }
if (this.NumDot_Is()) { this.NumDot_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.NumDot_String()); } else { this.NumDot_Set_Background_Gray(); }
if (this.NumSlash_Is()) { this.NumSlash_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.NumSlash_String()); } else { this.NumSlash_Set_Background_Gray(); }
if (this.NumEnter_Is()) { this.NumEnter_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.NumEnter_String()); } else { this.NumEnter_Set_Background_Gray(); }
if (this.NUMLOCK_Is()) { this.NUMLOCK_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.NUMLOCK_String()); } else { this.NUMLOCK_Set_Background_Gray(); }
if (this.Space_Is()) { this.Space_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.Space_String()); } else { this.Space_Set_Background_Gray(); }
if (this.Enter_Is()) { this.Enter_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.Enter_String()); } else { this.Enter_Set_Background_Gray(); }
if (this.Escape_Is()) { this.Escape_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.Escape_String()); } else { this.Escape_Set_Background_Gray(); }
if (this.LShift_Is()) { this.LShift_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.LShift_String()); } else { this.LShift_Set_Background_Gray(); }
if (this.RShift_Is()) { this.RShift_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.RShift_String()); } else { this.RShift_Set_Background_Gray(); }
if (this.BackSpace_Is()) { this.BackSpace_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.BackSpace_String()); } else { this.BackSpace_Set_Background_Gray(); }
if (this.Tab_Is()) { this.Tab_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.Tab_String()); } else { this.Tab_Set_Background_Gray(); }
if (this.LeftCTRL_Is()) { this.LeftCTRL_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.LeftCTRL_String()); } else { this.LeftCTRL_Set_Background_Gray(); }
if (this.RightCTRL_Is()) { this.RightCTRL_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.RightCTRL_String()); } else { this.RightCTRL_Set_Background_Gray(); }
if (this.LeftAlt_Is()) { this.LeftAlt_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.LeftAlt_String()); } else { this.LeftAlt_Set_Background_Gray(); }
if (this.RightAlt_Is()) { this.RightAlt_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.RightAlt_String()); } else { this.RightAlt_Set_Background_Gray(); }
if (this.Pause_Is()) { this.Pause_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.Pause_String()); } else { this.Pause_Set_Background_Gray(); }
if (this.CapsLock_Is()) { this.CapsLock_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.CapsLock_String()); } else { this.CapsLock_Set_Background_Gray(); }
if (this.PageUp_Is()) { this.PageUp_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.PageUp_String()); } else { this.PageUp_Set_Background_Gray(); }
if (this.PageDown_Is()) { this.PageDown_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.PageDown_String()); } else { this.PageDown_Set_Background_Gray(); }
if (this.End_Is()) { this.End_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.End_String()); } else { this.End_Set_Background_Gray(); }
if (this.Home_Is()) { this.Home_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.Home_String()); } else { this.Home_Set_Background_Gray(); }
if (this.ArrowUp_Is()) { this.ArrowUp_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.ArrowUp_String()); } else { this.ArrowUp_Set_Background_Gray(); }
if (this.ArrowLeft_Is()) { this.ArrowLeft_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.ArrowLeft_String()); } else { this.ArrowLeft_Set_Background_Gray(); }
if (this.ArrowRight_Is()) { this.ArrowRight_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.ArrowRight_String()); } else { this.ArrowRight_Set_Background_Gray(); }
if (this.ArrowDown_Is()) { this.ArrowDown_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.ArrowDown_String()); } else { this.ArrowDown_Set_Background_Gray(); }
if (this.Insert_Is()) { this.Insert_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.Insert_String()); } else { this.Insert_Set_Background_Gray(); }
if (this.Delete_Is()) { this.Delete_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.Delete_String()); } else { this.Delete_Set_Background_Gray(); }
if (this.LeftWin_Is()) { this.LeftWin_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.LeftWin_String()); } else { this.LeftWin_Set_Background_Gray(); }
if (this.RightWin_Is()) { this.RightWin_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.RightWin_String()); } else { this.RightWin_Set_Background_Gray(); }
if (this.PrintScreen_Is()) { this.PrintScreen_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.PrintScreen_String()); } else { this.PrintScreen_Set_Background_Gray(); }
if (this.ScrollLock_Is()) { this.ScrollLock_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.ScrollLock_String()); } else { this.ScrollLock_Set_Background_Gray(); }
if (this.LeftMouse_Is()) { this.LeftMouse_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.LeftMouse_String()); } else { this.LeftMouse_Set_Background_Gray(); }
if (this.RightMouse_Is()) { this.RightMouse_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.RightMouse_String()); } else { this.RightMouse_Set_Background_Gray(); }
if (this.Equally_Is()) { this.Equally_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.Equally_String()); } else { this.Equally_Set_Background_Gray(); }
if (this.Minus_Is()) { this.Minus_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.Minus_String()); } else { this.Minus_Set_Background_Gray(); }
if (this.Сomma_Is()) { this.Сomma_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.Сomma_String()); } else { this.Сomma_Set_Background_Gray(); }
if (this.Dot_Is()) { this.Dot_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.Dot_String()); } else { this.Dot_Set_Background_Gray(); }
if (this.PeriodComma_Is()) { this.PeriodComma_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.PeriodComma_String()); } else { this.PeriodComma_Set_Background_Gray(); }
if (this.Tilda_Is()) { this.Tilda_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.Tilda_String()); } else { this.Tilda_Set_Background_Gray(); }
if (this.SquScobOtk_Is()) { this.SquScobOtk_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.SquScobOtk_String()); } else { this.SquScobOtk_Set_Background_Gray(); }
if (this.SquScobZak_Is()) { this.SquScobZak_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.SquScobZak_String()); } else { this.SquScobZak_Set_Background_Gray(); }
if (this.Slash_Is()) { this.Slash_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.Slash_String()); } else { this.Slash_Set_Background_Gray(); }
if (this.ObratSlash_Is()) { this.ObratSlash_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.ObratSlash_String()); } else { this.ObratSlash_Set_Background_Gray(); }
if (this.Mark_Is()) { this.Mark_Set_Background_Green(); if (_Rec) LS_Rec.Add(this.Mark_String()); } else { this.Mark_Set_Background_Gray(); }
                    #endregion
                    //////////////////////////////////////////////////////
                    this.GetCursorPos();
                    if (this.MouseMoveX_Is()) { this.MouseMoveX_Set_Background_Green();
                        if (_Rec) LS_Rec.Add(this.MouseMoveX_String()+"_"+(this.p_Now_XY.X).ToString());
                    } else { this.MouseMoveX_Set_Background_Gray(); }
                    if (this.MouseMoveNX_Is()) { this.MouseMoveNX_Set_Background_Green();
                        if (_Rec) LS_Rec.Add(this.MouseMoveNX_String() + "_" + (this.p_Last_XY.X).ToString());
                    } else { this.MouseMoveNX_Set_Background_Gray(); }
                    if (this.MouseMoveY_Is()) { this.MouseMoveY_Set_Background_Green();
                        if (_Rec) LS_Rec.Add(this.MouseMoveY_String() + "_" + (this.p_Now_XY.Y).ToString());
                    } else { this.MouseMoveY_Set_Background_Gray(); }
                    if (this.MouseMoveNY_Is()) { this.MouseMoveNY_Set_Background_Green();
                        if (_Rec) LS_Rec.Add(this.MouseMoveNY_String() + "_" + (this.p_Last_XY.Y).ToString());
                    } else { this.MouseMoveNY_Set_Background_Gray(); }
                    Dispatcher.InvokeAsync(() => {this.lblXCoord.Content = this.p_Now_XY.X; this.lblYCoord.Content = this.p_Now_XY.Y; });

                    //Во время воспроизведения происходит задержка в 50 милисекунд по дефолту
                    if (LS_Rec.Count != 0){ Dispatcher.InvokeAsync(() => { this.p_LLS_Record.Add(LS_Rec); }); }else
                    {
                        Dispatcher.InvokeAsync(() => { if (this.p_LLS_Record.Count == 0) this.p_LLS_Record.Add(new List<string>()); ; });
                        Dispatcher.InvokeAsync(() => { this.p_LLS_Record[this.p_LLS_Record.Count - 1].Add("Sleep50"); }); 
                    }
                }
            });
            thread.Start();
            //пОДСВЕТИТЬ ПОДДЕРЖИВАЕМЫЕ КЛАВИШИ

            return this;
        }


    }
}

