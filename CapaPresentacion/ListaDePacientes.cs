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
    public partial class ListaDePacientes : Form
    {
        CN_Pacientes ObjetoCN = new CN_Pacientes();
        public bool Editar = false;
        private string IdPacientes = null;
        public ListaDePacientes()
        {
            InitializeComponent();
        }

        private void BotonEditar_Click(object sender, EventArgs e)
        {
            Editar = true;
            Agregar Formulario3 = new Agregar();
            Formulario3.label6.Text = "Editar";
            Formulario3.textBoxNombre.Text = bunifuCustomDataGrid1.CurrentRow.Cells["Nombre"].Value.ToString();
            Formulario3.textBoxApellido.Text = bunifuCustomDataGrid1.CurrentRow.Cells["Apellido"].Value.ToString();
            Formulario3.ComboboxObraSocial.SelectedValue = bunifuCustomDataGrid1.CurrentRow.Cells["Obra_social"].Value.ToString();
            Formulario3.TexboxFecha.Text = bunifuCustomDataGrid1.CurrentRow.Cells["Fecha_de_Nacimiento"].Value.ToString();
            Formulario3.textBoxNDA.Text = bunifuCustomDataGrid1.CurrentRow.Cells["Numero_De_Afiliado"].Value.ToString();
            Formulario3.textBoxTel.Text = bunifuCustomDataGrid1.CurrentRow.Cells["Telefono"].Value.ToString();
            Formulario3.textBoxDNI.Text = bunifuCustomDataGrid1.CurrentRow.Cells["DNI"].Value.ToString();
            Formulario3.textBoxID.Text = bunifuCustomDataGrid1.CurrentRow.Cells["Id"].Value.ToString();
            Formulario3.Show();
        }


        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            MostrarPacientes();
        }

        private void MostrarPacientes()
        {
            CN_Pacientes Objeto = new CN_Pacientes();
            bunifuCustomDataGrid1.DataSource = Objeto.MostrarPa();
        }

        private void ControlDePagos_Load(object sender, EventArgs e)
        {
            Bunifu.Framework.Lib.Elipse.Apply(bunifuCustomDataGrid1, 7);
            MostrarPacientes();
            Transition1.ShowSync(panelAnima);
            Transition1.ShowSync(panelBotones);
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            if (bunifuCustomDataGrid1.SelectedRows.Count > 0)
            {
                IdPacientes = bunifuCustomDataGrid1.CurrentRow.Cells["Id"].Value.ToString();
                ObjetoCN.EliminarPa(IdPacientes);
                MessageBox.Show("Eliminado");
                MostrarPacientes();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void TextboxBuscar_OnTextChange(object sender, EventArgs e)
        {
            if (TextboxBuscar.text != "Buscar Pacientes")
            {
                CN_Pacientes Objeto = new CN_Pacientes();
                bunifuCustomDataGrid1.DataSource = Objeto.BarraDeBusquedaPaciente(TextboxBuscar.text);
            }
            else
            {
                MostrarPacientes();
            }
        }

        private void TextboxBuscar_Click(object sender, EventArgs e)
        {
            if (TextboxBuscar.text == "Buscar Pacientes")
            {
                TextboxBuscar.text = "";
            }
        }

        private void TextboxBuscar_Leave(object sender, EventArgs e)
        {
            if (TextboxBuscar.text == "")
            {
                TextboxBuscar.text = "Buscar Pacientes";
            }
        }
    }
}
