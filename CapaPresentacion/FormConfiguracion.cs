using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using CapaNegosio;

namespace CapaPresentacion
{
    public partial class FormConfiguracion : Form
    {
        public FormConfiguracion()
        {
            InitializeComponent();
        }

        string ID;
        CN_Pacientes objetoCN = new CN_Pacientes();

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormConfiguracion_Load(object sender, EventArgs e)
        {
            MostarObraSocial();
            textBoxContra.UseSystemPasswordChar = true;
            textBoxCContra.UseSystemPasswordChar = true;
            TextboxNombre.Text = CacheUsuarios.Usuario;
            labelNA.Text = CacheUsuarios.Nombre + " " + CacheUsuarios.Apellido;
            labelMail.Text = CacheUsuarios.Mail;
            labelFDN.Text = CacheUsuarios.FDN;
            ID = CacheUsuarios.Id.ToString();
        }

        private void MostarObraSocial()
        {
            CN_Pacientes cn_pacientes = new CN_Pacientes();
            bunifuCustomDataGrid1.DataSource = cn_pacientes.MostarObrasocial1();
        }

        private void BotonCrearCuenta_Click(object sender, EventArgs e)
        {
            if (TextboxNombre.Text != "")
            {
                if (textBoxContra.Text != "")
                {
                    if (textBoxCContra.Text != "")
                    {
                        if (textBoxContra.Text == textBoxCContra.Text)
                        {
                            try
                            {
                                objetoCN.EditarPerfil(TextboxNombre.Text,textBoxContra.Text,ID);
                                MessageBox.Show("Editado");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("no se pudo editar los datos por:" + ex);
                            }
                        }
                        else
                        {
                            msgError("Una de las Contraseñas es \n incorrecta");
                        }
                    }
                    else
                    {
                        msgError("Confirme su Contraseña");
                    }
                }
                else
                {
                    msgError("Coloque una Contraseña");
                }
            }
            else
            {
                msgError("Colocar un nombre de Usuario");
            }
        }

        private void msgError(string msg)
        {
            LabelError.Text = msg;
            LabelError.Visible = true;
            pictureBox2.Visible = true;
        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            if (TextboxAgregarObra.Text != "")
            {
                try
                {
                    objetoCN.insertarObra(TextboxAgregarObra.Text);
                    MessageBox.Show("Guardado");
                    MostarObraSocial();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex);
                }
                labelError2.Visible = false;
                pictureBoxErro2.Visible = false;
            }
            else
            {
                labelError2.Visible = true;
                pictureBoxErro2.Visible = true;
                labelError2.Text = "Colocar el nombre de la Obra social";
            }
      
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            if (bunifuCustomDataGrid1.SelectedRows.Count > 0)
            {
                try
                {
                    string IDObra = bunifuCustomDataGrid1.CurrentRow.Cells["Id"].Value.ToString();
                    objetoCN.EliminarObra(IDObra);
                    MessageBox.Show("Eliminado");
                    MostarObraSocial();
                
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex);
                }
                labelError2.Visible = false;
                pictureBoxErro2.Visible = false;
            }
            else
            {
                pictureBoxErro2.Visible = true;
                labelError2.Visible = true;
                labelError2.Text = "Seleccione una fila por favor";
            }

        }
    }
}
