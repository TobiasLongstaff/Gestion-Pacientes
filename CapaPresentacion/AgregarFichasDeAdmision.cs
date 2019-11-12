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
    public partial class AgregarFichasDeAdmision : Form
    {
        public AgregarFichasDeAdmision()
        {
            InitializeComponent();
        }

        CN_Pacientes cn_pacientes = new CN_Pacientes();
        bool Edit = false;

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AgregarFichasDeAdmision_Load(object sender, EventArgs e)
        {
            Transition1.ShowSync(panelFondo);
            Transition1.ShowSync(panelBotones);
            Bunifu.Framework.Lib.Elipse.Apply(ComboboxObraSocial, 5);
            ListaObrasSociales();
            TexboxFecha.Text = Date.Value.ToString();
        }

        private void ListaObrasSociales()
        {
            ComboboxObraSocial.DataSource = cn_pacientes.MostarObra();
            ComboboxObraSocial.DisplayMember = "ObrasSociales";
            ComboboxObraSocial.ValueMember = "IDObrasSociales";
        }

        private void BotonGuardad_Click(object sender, EventArgs e)
        {
            if (textBoxHCN.Text != "")
            {
                if (textBoxNombreYApellido.Text != "")
                {
                    if (textBoxEdad.Text != "")
                    {
                        if (TexboxFecha.Text != "")
                        {
                            if (textBoxNacionalidad.Text != "")
                            {
                                if (textBoxTipoYNDocumento.Text != "")
                                {
                                    if (ComboboxEstadoCivil.selectedIndex != -1)
                                    {
                                        if (textBoxOcupacion.Text != "")
                                        {
                                            if (textBoxColegio.Text != "")
                                            {
                                                if (textBoxDomicilio.Text != "")
                                                {
                                                    if (textBoxLocalidad.Text != "")
                                                    {
                                                        if (textBoxTelefono.Text != "")
                                                        {
                                                            if (textBoxTelAux.Text != "")
                                                            {
                                                                if (textBoxDerivadoPor.Text != "")
                                                                {
                                                                    if (textBoxAcompañadoPor.Text != "")
                                                                    {
                                                                        if (Edit == false)
                                                                        {
                                                                            TexboxFecha.Text = Date.Value.ToString();
                                                                            try
                                                                            {
                                                                                cn_pacientes.InsertarAdmi(textBoxHCN.Text, textBoxNombreYApellido.Text, textBoxEdad.Text, TexboxFecha.Text, textBoxNacionalidad.Text,
                                                                                textBoxTipoYNDocumento.Text, ComboboxEstadoCivil.selectedValue, textBoxOcupacion.Text, textBoxColegio.Text, textBoxDomicilio.Text, textBoxLocalidad.Text,
                                                                                textBoxTelefono.Text, textBoxTelAux.Text, ComboboxObraSocial.SelectedValue.ToString(), textBoxDerivadoPor.Text, textBoxAcompañadoPor.Text);
                                                                                MessageBox.Show("Guardado");
                                                                            }
                                                                            catch (Exception ex)
                                                                            {
                                                                                MessageBox.Show("Error:" + ex);
                                                                            }
                                                                        }
                                                                        if (Edit == true)
                                                                        {
                                                                            try
                                                                            {
                                                                                cn_pacientes.EditarAdmi(textBoxHCN.Text, textBoxNombreYApellido.Text, textBoxEdad.Text, TexboxFecha.Text, textBoxNacionalidad.Text,
                                                                                textBoxTipoYNDocumento.Text, ComboboxEstadoCivil.selectedValue, textBoxOcupacion.Text, textBoxColegio.Text, textBoxDomicilio.Text, textBoxLocalidad.Text,
                                                                                textBoxTelefono.Text, textBoxTelAux.Text, ComboboxObraSocial.SelectedValue.ToString(), textBoxDerivadoPor.Text, textBoxAcompañadoPor.Text,textBoxFichaDEAdmision.Text);
                                                                                MessageBox.Show("Editado");
                                                                                Edit = false;
                                                                            }
                                                                            catch (Exception ex)
                                                                            {
                                                                                MessageBox.Show("Error:" + ex);                    
                                                                            }
                                                                        }
                                                                    }
                                                                    else
                                                                    {
                                                                        msError("Colocar acompañado por");
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    msError("Colocar derivado por");
                                                                }
                                                            }
                                                            else
                                                            {
                                                                msError("Colocar otro numero de telefono");
                                                            }
                                                        }
                                                        else
                                                        {
                                                            msError("Colocar un numero de telefono");
                                                        }
                                                    }
                                                    else
                                                    {
                                                        msError("Colocar la localidad del paciente");
                                                    }
                                                }
                                                else
                                                {
                                                    msError("Colocar domicilio del paciente");
                                                }
                                            }
                                            else
                                            {
                                                msError("Colocar colegio del paciente");
                                            } 
                                        }
                                        else
                                        {
                                            msError("Coloque la ocupacion/escolaridad del paciente");
                                        }
                                    }
                                    else
                                    {
                                        msError("Selecione un estado civil");
                                    }
                                }
                                else
                                {
                                    msError("Colocar DNI del paciente");
                                }
                            }
                            else
                            {
                                msError("Colocar la nacionalidad del paciente");
                            }
                        }
                        else
                        {
                            msError("Colocar la fecha de nacimiento del paciente");
                        }
                    }
                    else
                    {
                        msError("Colocar la edad del paciente");
                    }
                }
                else
                {
                    msError("Colocar nombre y apellido del paciente");
                }
            }
            else
            {
                msError("Colocar HCN°");
            }
        }

        private void msError(string Error)
        {
            LabelError.Text = Error; 
            LabelError.Visible = true;
            pictureBoxError.Visible = true;
        }

        private void TextboxEnabled(bool FV)
        {
            textBoxHCN.Enabled = FV;
            textBoxNombreYApellido.Enabled = FV;
            textBoxEdad.Enabled = FV;
            textBoxNacionalidad.Enabled = FV;
            textBoxTipoYNDocumento.Enabled = FV;
            ComboboxEstadoCivil.Enabled = FV;
            textBoxOcupacion.Enabled = FV;
            textBoxColegio.Enabled = FV;
            textBoxDomicilio.Enabled = FV;
            textBoxLocalidad.Enabled = FV;
            textBoxTelefono.Enabled = FV;
            textBoxTelAux.Enabled = FV;
            textBoxDerivadoPor.Enabled = FV;
            textBoxAcompañadoPor.Enabled = FV;
            Date.Enabled = FV;
        }

        private void BotonEditar_Click(object sender, EventArgs e)
        {
            Edit = true;
            TextboxEnabled(true);
        }

        private void TextboxBuscar_Enter(object sender, EventArgs e)
        {
            if (TextboxBuscar.text == "Buscar Paciente")
            {
                TextboxBuscar.text = "";
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
                    bunifuCustomDataGrid1.DataSource = cn_pacientes.BarraDeBusquedaAdmision(TextboxBuscar.text);
                    Transition2.ShowSync(paneldatagrid);
                }
            }
            else
            {
                paneldatagrid.Visible = false;
            }
        }

        private void bunifuCustomDataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextboxEnabled(false);
            textBoxFichaDEAdmision.Text = bunifuCustomDataGrid1.CurrentRow.Cells["ID"].Value.ToString();
            textBoxHCN.Text = bunifuCustomDataGrid1.CurrentRow.Cells["HCN"].Value.ToString();
            textBoxNombreYApellido.Text = bunifuCustomDataGrid1.CurrentRow.Cells["NombreYApellido"].Value.ToString();
            textBoxEdad.Text = bunifuCustomDataGrid1.CurrentRow.Cells["Edad"].Value.ToString();
            TexboxFecha.Text = bunifuCustomDataGrid1.CurrentRow.Cells["FechaDeNacimiento"].Value.ToString();
            textBoxNacionalidad.Text = bunifuCustomDataGrid1.CurrentRow.Cells["Nacionalidad"].Value.ToString();
            textBoxTipoYNDocumento.Text = bunifuCustomDataGrid1.CurrentRow.Cells["TipoYNDocumento"].Value.ToString();
            ComboboxEstadoCivil.selectedIndex = 1;
            textBoxOcupacion.Text = bunifuCustomDataGrid1.CurrentRow.Cells["Ocupacion"].Value.ToString();
            textBoxColegio.Text = bunifuCustomDataGrid1.CurrentRow.Cells["Colegio"].Value.ToString();
            textBoxDomicilio.Text = bunifuCustomDataGrid1.CurrentRow.Cells["Domicilio"].Value.ToString();
            textBoxLocalidad.Text = bunifuCustomDataGrid1.CurrentRow.Cells["Localidad"].Value.ToString();
            textBoxTelefono.Text = bunifuCustomDataGrid1.CurrentRow.Cells["Telefono"].Value.ToString();
            textBoxTelAux.Text = bunifuCustomDataGrid1.CurrentRow.Cells["TelefonoAux"].Value.ToString();
            ComboboxObraSocial.SelectedValue = bunifuCustomDataGrid1.CurrentRow.Cells["IDObraSocial"].Value.ToString();
            textBoxDerivadoPor.Text = bunifuCustomDataGrid1.CurrentRow.Cells["DerivadoPor"].Value.ToString();
            textBoxAcompañadoPor.Text = bunifuCustomDataGrid1.CurrentRow.Cells["AcompañadoPor"].Value.ToString();
            if (TextboxBuscar.text == "")
            {
                TextboxBuscar.text = "Buscar Paciente";
            }
        }

        private void paneldatagrid_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
