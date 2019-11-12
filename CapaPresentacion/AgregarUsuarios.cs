using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegosio;

namespace CapaPresentacion
{    
    public partial class AgregarUsuarios : Form
    {
        CN_Pacientes cn_pacientes = new CN_Pacientes();
        
        public AgregarUsuarios()
        {
            InitializeComponent();
        }

        int cont = 0;

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            cont += 1;
            if (cont == 100)
            {
                timer1.Stop();
            }
        }

        private void AgregarUsuarios_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer1.Start();
            textBoxContra.UseSystemPasswordChar = true;
            textBoxCContra.UseSystemPasswordChar = true;
        }

        private void BotonCrearCuenta_Click(object sender, EventArgs e)
        {
            textBoxFDN.Text = Date.Value.ToString();
            if (TextboxUsuario.Text != "")
            {
                if (TextboxNombre.Text != "")
                {
                    if (TextboxApellido.Text != "")
                    {
                        if (TextboxCorreo.Text != "")
                        {
                            if (textBoxContra.Text != "")
                            {
                                if (textBoxCContra.Text != "") 
                                {
                                    if (textBoxContra.Text == textBoxCContra.Text)
                                    {
                                        if (textBoxFDN.Text != "")
                                        {
                                            try
                                            {
                                                cn_pacientes.crearcuenta(TextboxUsuario.Text, TextboxNombre.Text, TextboxApellido.Text, TextboxCorreo.Text, textBoxFDN.Text, textBoxContra.Text);
                                                MessageBox.Show("Guardado");


                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show("Error:" + ex);
                                            }
                                        }
                                        else
                                        {
                                            msgError("Por favor coloque su Fecha de nacimiento");
                                        }
                                    }
                                    else
                                    {
                                        msgError("La contraseña no coincide");
                                    } 
                                }
                                else
                                {
                                    msgError("Por favor confirme su contraseña");
                                }
                            }
                            else
                            {
                                msgError("Por favor coloque una Contraseña");
                            }
                          
                        }
                        else
                        {
                            msgError("Por favor coloque su Correo electronico");
                        }
                    }
                    else
                    {
                        msgError("Por favor coloque su Apellido");
                    }
                }
                else
                {
                    msgError("Por favor coloque su Nombre");
                }
            }
            else
            {
                msgError("Por favor coloque un nombre de Usuario");
            }
        }

        private void msgError(string msg)
        {
            LabelError.Text = msg;
            LabelError.Visible = true;
            pictureBox2.Visible = true;
        }

        private void TextboxUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TextboxNombre.Focus();
            }
        }

        private void TextboxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TextboxApellido.Focus();
            }
        }

        private void TextboxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TextboxCorreo.Focus();
            }
        }

        private void TextboxCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBoxContra.Focus();
            }
        }

        private void textBoxContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBoxCContra.Focus();
            }
        }
    }
}
