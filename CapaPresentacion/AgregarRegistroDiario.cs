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
using Common.Cache;

namespace CapaPresentacion
{
    public partial class AgregarRegistroDiario : Form
    {
        public AgregarRegistroDiario()
        {
            InitializeComponent();
        }

        CN_Pacientes cn_pacientes = new CN_Pacientes();

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListaNombreYApellido()
        {
            //comboBoxBuscar.DataSource = cn_pacientes.MostarlistaNYA();
            //comboBoxBuscar.DisplayMember = "NombreYApellido";
        }

        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text != "")
            {
                if (textBoxApellido.Text != "")
                {
                    if (TexboxFecha.Text != "")
                    {
                        if (textBoxHora.Text != "")
                        {
                            if (ComboboxAsistencia.selectedIndex != -1)
                            {
                                if (CheckboxFechaDeHoy.Checked == true)
                                {
                                    TexboxFecha.Text = DateTime.Now.ToShortDateString();
                                    GuardarRegistro();
                                }
                                else
                                {
                                    TexboxFecha.Text = Date.Value.ToString();
                                    GuardarRegistro();
                                }
                            }
                            else
                            {
                                msError("Colocar Asistencia");
                            }
                        }
                        else
                        {
                            msError("Colocar hora de registro");
                        }
                    }
                    else
                    {
                        msError("Colocar fecha de registro");
                    }
                }
                else
                {
                    msError("Colocar apellido del paciente");
                }
            }
            else
            {
                msError("Colocar nombre del paciente");
            }
        }

        private void msError(string Error)
        {
            LabelError.Text = Error;
            LabelError.Visible = true;
            pictureBoxError.Visible = true;
        }

        private void GuardarRegistro()
        {
            try
            {
                string NombreYApellido = textBoxNombre.Text + " " + textBoxApellido.Text;
                cn_pacientes.insertarRegistro(TexboxFecha.Text, textBoxHora.Text, NombreYApellido, textBoxID.Text, ComboboxAsistencia.selectedValue.ToString());
                MessageBox.Show("Guardado");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:"+ ex);
            } 
        }

        private void MenFrechaDeHoy()
        {

        }

        private void CheckboxFechaDeHoy_Click(object sender, EventArgs e)
        {
        }

        private void AgregarRegistroDiario_Load(object sender, EventArgs e)
        {
            textBoxHora.Text = LabelHora.Text;
            this.Opacity = 0.0;
            timer1.Start();
            ListaNombreYApellido();
        }

        private void FechaYhora_Tick(object sender, EventArgs e)
        {
            if (HoraCheckbox.Checked == true)
            {
                textBoxHora.Enabled = false;
                labelHoratext.Enabled = false;
                textBoxHora.Text = DateTime.Now.ToString("HH:mm:ss");
            }
            else
            {
                labelHoratext.Enabled = true;
                textBoxHora.Enabled = true;
            }
            LabelHora.Text = DateTime.Now.ToString("HH:mm:ss");
            labelFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int cont = 0;
            if (this.Opacity < 1) this.Opacity += 0.05;
            cont += 1;
            if (cont == 100)
            {
                timer1.Stop();
            }
        }

        private void TextboxBuscar_OnTextChange(object sender, EventArgs e)
        {
            if (TextboxBuscar.text != "Buscar Paciente")
            {
                if (TextboxBuscar.text == "")
                {
                    paneldatagrid.Visible = false;
                }
                else
                {
                    CN_Pacientes cn_pacientes = new CN_Pacientes();
                    bunifuCustomDataGrid1.DataSource = cn_pacientes.BarraDeBusquedaPaciente(TextboxBuscar.text);
                    Transition1.ShowSync(paneldatagrid);
                }
            }
            else
            {
                paneldatagrid.Visible = false;
            }
        }

        private void TextboxBuscar_Enter(object sender, EventArgs e)
        {
            if (TextboxBuscar.text == "Buscar Paciente")
            {
                TextboxBuscar.text = "";
            }
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = bunifuCustomDataGrid1.CurrentRow.Cells["ID"].Value.ToString();
            textBoxNombre.Text = bunifuCustomDataGrid1.CurrentRow.Cells["Nombre"].Value.ToString();
            textBoxApellido.Text = bunifuCustomDataGrid1.CurrentRow.Cells["Apellido"].Value.ToString();
            
        }
    }
}
