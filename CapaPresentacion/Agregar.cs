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
    public partial class Agregar : Form
    {
        CN_Pacientes objetoCN = new CN_Pacientes();
        ListaDePacientes Formulario1 = new ListaDePacientes();

        public Agregar()
        {
            InitializeComponent();
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {

            TexboxFecha.Text = Date.Value.ToString();
            if (textBoxNombre.Text != "")
            {
                if (textBoxApellido.Text != "")
                {
                    if (textBoxNDA.Text != "")
                    {
                        if (textBoxTel.Text != "")
                        {
                            if (textBoxDNI.Text != "")
                            {
                                if (TexboxFecha.Text != "000")
                                {
                                    if (label6.Text == "Agregar")
                                    {
                                        try
                                        {
                                            objetoCN.insertarPa(textBoxNombre.Text, textBoxApellido.Text, ComboboxObraSocial.SelectedValue.ToString(), TexboxFecha.Text, textBoxNDA.Text, textBoxTel.Text, textBoxDNI.Text);
                                            MessageBox.Show("Guardado");
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("Error:" + ex);
                                        }
                                    }
                                    if (label6.Text == "Editar")
                                    {
                                        try
                                        {
                                            objetoCN.EditarPa(textBoxNombre.Text, textBoxApellido.Text, ComboboxObraSocial.SelectedValue.ToString(), TexboxFecha.Text, textBoxNDA.Text, textBoxTel.Text, textBoxDNI.Text, textBoxID.Text);
                                            MessageBox.Show("Editado");
                                            Limpiar();
                                            Formulario1.Editar = false;
                                        }
                                        catch(Exception ex)
                                        {
                                            MessageBox.Show("no se pudo editar los datos por:" + ex);
                                        }
                                    }
                                }
                                else
                                {
                                    msError("Colocar la fecha de nacimiento del paciente");
                                }
                            }
                            else
                            {
                                msError("Colocar el DNI del paciente");
                            }
                        }
                        else
                        {
                            msError("Colocar un numero de telefono");
                        }
                    }
                    else
                    {
                        msError("Colocar el numero de afiliado");
                    }
                }
                else
                {
                    msError("Colocar el apellido del paciente");
                }
            }
            else
            {
                msError("Colocar el nombre del paciente");
            }
        }

        private void msError(string Error)
        {
            LabelError.Visible = true;
            pictureBox2.Visible = true;
            LabelError.Text = Error;
        }

        private void ListaObrasSociales()
        {
            ComboboxObraSocial.DataSource = objetoCN.MostarObra();
            ComboboxObraSocial.DisplayMember = "ObrasSociales";
            ComboboxObraSocial.ValueMember = "IDObrasSociales";
        }

        private void Limpiar()
        {
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            TexboxFecha.Text = "";
            textBoxID.Text = "";
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer2.Start();
            Bunifu.Framework.Lib.Elipse.Apply(ComboboxObraSocial, 5);
            ListaObrasSociales();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label9.Text = this.Location.X.ToString();
            label8.Text = this.Location.Y.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int cont = 0;
            if (this.Opacity < 1) this.Opacity += 0.05;
            cont += 1;
            if (cont == 100)
            {
                timer1.Stop();
            }
        }

        private void BotonCrearFicha_Click(object sender, EventArgs e)
        {
            TexboxFecha.Text = Date.Value.ToString();
            textBoxNombreYApellido.Text = textBoxNombre.Text +" "+ textBoxApellido.Text;
            try
            {
                objetoCN.InsertarAdmi(textBoxNada.Text, textBoxNombreYApellido.Text, textBoxNada.Text, TexboxFecha.Text, textBoxNada.Text,
                textBoxDNI.Text, textBoxNada.Text, textBoxNada.Text, textBoxNada.Text, textBoxNada.Text, textBoxNada.Text,
                textBoxTel.Text, textBoxNada.Text, ComboboxObraSocial.SelectedValue.ToString(), textBoxNada.Text, textBoxNada.Text);
                MessageBox.Show("Ficha de Admision creada.\n Modifica los datos que aparecen con:000 ");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
        }
    }
}
