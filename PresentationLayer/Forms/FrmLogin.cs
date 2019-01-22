using BunifuAnimatorNS;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessLayer;
using Entities;

namespace PresentationLayer
{
    public partial class FrmLogin : Form
    {
        private int FocusedTxt;

        //private BunifuAnimatorNS.AnimationType AnimationTypeAct = (AnimationType)8;
        public FrmLogin()
        {
            //this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            //this.BackColor = Color.FromArgb(0, 0, 0, 0);
            Functions.ConfigurarMaterialSkinManagerInicio();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.BlanchedAlmond;
            this.BackColor = Color.BlanchedAlmond;
            TxtBx_Password.Top -= 6;
            TxtBx_UserID.Top -= 6;
        }

        private void Bttn_Login_Click(object sender, EventArgs e)
        {
            if (VerificarCampos())
            {
                DataTable dtUserInfo = UsuarioBL.VerificarRutPass(TxtBx_UserID.Text.Trim(), TxtBx_Password.Text.Trim());
                FrmPrincipalPanel frmParentForm = (FrmPrincipalPanel)Application.OpenForms["FrmPrincipalPanel"];

                if (dtUserInfo.Rows.Count > 0) // Verificacion de RUT
                {
                    if (dtUserInfo.Rows[0].Field<string>("Acceso") == "Y") // Verificacion de Pass correcto
                    {
                        switch (dtUserInfo.Rows[0].Field<int>("IdAtributo"))
                        {
                            case 96000: // Verificacion del Acceso 9600 MINDUMAS ADMINISTRADOR
                                Usuario.Instance().UserId = dtUserInfo.Rows[0].Field<int>("IdUsuario");
                                Usuario.Instance().UserName = dtUserInfo.Rows[0].Field<string>("Nombre");
                                Usuario.Instance().UserRut = dtUserInfo.Rows[0].Field<string>("rut");
                                frmParentForm.AsignarNombreUsuario(Usuario.Instance().UserName);
                                frmParentForm.TipoAcceso = "ADMIN";
                                frmParentForm.AccesoActual = dtUserInfo.Rows[0].Field<int>("IdAtributo").ToString();
                                frmParentForm.ConfigurarMenuAcceso();
                                ClosedFadeOutAsync();
                                break;
                            default:
                            case 96001: // Verificacion del Acceso 9600 LECTURA
                                Usuario.Instance().UserId = dtUserInfo.Rows[0].Field<int>("IdUsuario");
                                Usuario.Instance().UserName = dtUserInfo.Rows[0].Field<string>("Nombre");
                                Usuario.Instance().UserRut = dtUserInfo.Rows[0].Field<string>("rut");
                                frmParentForm.AsignarNombreUsuario(Usuario.Instance().UserName);
                                frmParentForm.TipoAcceso = "LECTURA";
                                frmParentForm.AccesoActual = dtUserInfo.Rows[0].Field<int>("IdAtributo").ToString();
                                frmParentForm.ConfigurarMenuAcceso();
                                ClosedFadeOutAsync();
                                break;
                            case 96002: // Verificacion del Acceso 9600 VENTAS
                                Usuario.Instance().UserId = dtUserInfo.Rows[0].Field<int>("IdUsuario");
                                Usuario.Instance().UserName = dtUserInfo.Rows[0].Field<string>("Nombre");
                                Usuario.Instance().UserRut = dtUserInfo.Rows[0].Field<string>("rut");
                                frmParentForm.AsignarNombreUsuario(Usuario.Instance().UserName);
                                frmParentForm.TipoAcceso = "VENTAS";
                                frmParentForm.AccesoActual = dtUserInfo.Rows[0].Field<int>("IdAtributo").ToString();
                                frmParentForm.ConfigurarMenuAcceso();
                                ClosedFadeOutAsync();
                                break;
                                MetroFramework.MetroMessageBox.Show(frmParentForm, "No Posee la Autorizacion en MinduMas para Acceder al Sistema",
                                          "Acceso No Habilitado",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Information,
                                          370);
                                break;

                        }
                           
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(frmParentForm, "La Contraseña no Coincide",
                                            "Contraseña Incorrecta",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information,
                                            370);
                        TxtBx_Password.Focus();
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(frmParentForm, "Numero de RUT No Registrado en la Base de Datos",
                                                "RUT Sin Coincidencia",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Information,
                                                370);
                    TxtBx_UserID.Focus();
                }
            }
        }

        private bool VerificarCampos()
        {
            bool Valido = true;
            if (TxtBx_UserID.Text.Trim().Length == 0)
                Valido = false;
            else if (TxtBx_UserID.Text.Trim().Length == 0)
                Valido = false;
            return Valido;
        }

        private async Task ClosedFadeOutAsync()
        {
            Functions.ConfigurarMaterialSkinManager();
            FrmPrincipalPanel frmParentForm = (FrmPrincipalPanel)Application.OpenForms["FrmPrincipalPanel"];
            frmParentForm.SetBackGroundImage();

            Fader.FadeOutAndClose(this, Fader.FadeSpeed.Slower);
            //this.FadeOut();

            await Task.Delay(80);
            frmParentForm.Animate_BackLogo();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void TxtBx_UserID_Enter(object sender, EventArgs e)
        {
            FocusedTxt = 1;
            if (TxtBx_UserID.Text.Trim() == "")
                UsernameLabel.Visible = true;
        }

        private void TxtBx_UserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tbtmp = sender as TextBox;

            if (e.KeyChar == Convert.ToChar(Keys.Back) ||
                e.KeyChar == Convert.ToChar(Keys.Delete) ||
                e.KeyChar == Convert.ToChar(Keys.Left) ||
                e.KeyChar == Convert.ToChar(Keys.Right) ||
                e.KeyChar.ToString().ToUpper() == Convert.ToChar("K").ToString() ||
                (e.KeyChar.ToString().IsNumber()))
            {
                if ((tbtmp.Text.CountChars('K') == 1 || tbtmp.Text.CountChars('k') == 1) &&
                  e.KeyChar.ToString().ToUpper() == Convert.ToChar("K").ToString())
                    e.Handled = true;
                else if (tbtmp.Text.CountChars('-') == 1 && e.KeyChar == Convert.ToChar("-"))
                    e.Handled = true;
                else if (e.KeyChar == Convert.ToChar("."))
                    e.Handled = true;
                else
                    e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void TxtBx_UserID_TextChanged(object sender, EventArgs e)
        {
            if (UsernameLabel.Visible)
                UsernameLabel.Visible = false;
            else if (!UsernameLabel.Visible && TxtBx_UserID.Text.Trim().Length == 0)
                UsernameLabel.Visible = true;
        }

        private void EnterKeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }

        private void TxtBx_UserID_Validated(object sender, EventArgs e)
        {
            TxtBx_UserID.Text = TxtBx_UserID.Text.FormatearRut();
        }

        private void FrmLogin_Shown(object sender, EventArgs e)
        {
            Fader.FadeIn(this, Fader.FadeSpeed.Slower);
        }

        private void TxtBx_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.Handled = e.SuppressKeyPress = true;
                e.Handled = true;
                e.SuppressKeyPress = true;
                SendKeys.Send("{ENTER}");
            }
        }
    }
}
