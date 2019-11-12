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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int cont = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer1.Start();
            this.bunifuElipse1.ApplyElipse(BotonLogin);
            this.bunifuElipse1.ApplyElipse(BotonCrear);
            TextboxContraseña.UseSystemPasswordChar = true;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void BotonLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            if (TextboxNombre.Text != "")
            {
                if (TextboxContraseña.Text != "")
                {
                    CN_Usuarios user = new CN_Usuarios();
                    var validLogin = user.LoginUser(TextboxNombre.Text, TextboxContraseña.Text);
                    if (validLogin == true)
                    {
                        this.Hide();
                        Menu Formulario1 = new Menu();
                        Formulario1.Show();
                        Formulario1.FormClosed += Logout;

                    }
                    else
                    {
                        msgError("Usuario y Contraseña incorrecto");
                    }
                }
                else
                {
                    msgError("Por favor coloque su Contraseña");
                }
            }
            else
            {
                msgError("Por favor coloque su Usuario");
            }
        }

        private void msgError(string msg)
        {
            LabelError.Text = msg;
            LabelError.Visible = true;
            pictureBox2.Visible = true;
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            TextboxContraseña.Text = "";
            TextboxNombre.Text = "";
            LabelError.Visible = false;
            this.Show();
            TextboxNombre.Focus();
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                Application.Exit();    
            }
        }

        private void BotonCrear_Click(object sender, EventArgs e)
        {
            AgregarUsuarios agregarusuarios = new AgregarUsuarios();
            agregarusuarios.Show();
            this.Hide();
        }

        private void TextboxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TextboxContraseña.Focus();
            }
        }

        private void TextboxContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Login();
            }
        }
    }
}
