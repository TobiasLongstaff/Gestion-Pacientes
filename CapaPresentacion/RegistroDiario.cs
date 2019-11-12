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
    public partial class RegistroDiario : Form
    {
        public RegistroDiario()
        {
            InitializeComponent();
        }

        CN_Pacientes cn_pacientes = new CN_Pacientes();
        private string IdRegistro = null;

        private void BotonEditar_Click(object sender, EventArgs e)
        {

        }

        private void MostarRegistroDiario()
        {
            CN_Pacientes cn_pacientesmostrar = new CN_Pacientes();
            bunifuCustomDataGrid1.DataSource = cn_pacientesmostrar.MostrarRegistroDia();
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (bunifuCustomDataGrid1.SelectedRows.Count > 0)
                {
                    IdRegistro = bunifuCustomDataGrid1.CurrentRow.Cells["Id"].Value.ToString();
                    cn_pacientes.EliminarRegistroDia(IdRegistro);
                    MessageBox.Show("Eliminado");
                    MostarRegistroDiario();
                }
                else
                {
                    MessageBox.Show("Seleccione una fila por favor");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
        }

        private void RegistroDiario_Load(object sender, EventArgs e)
        {
            Bunifu.Framework.Lib.Elipse.Apply(bunifuCustomDataGrid1, 7);
            MostarRegistroDiario();
            Transition1.ShowSync(panelFondo);
            Transition1.ShowSync(panelBotones);
        }

        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            MostarRegistroDiario();
            
        }

        private void TextboxBuscar_OnTextChange(object sender, EventArgs e)
        {
            if (TextboxBuscar.text != "Buscar Pacientes")
            {
                CN_Pacientes Objeto = new CN_Pacientes();
                bunifuCustomDataGrid1.DataSource = Objeto.BarraDeBusquedaRegistro(TextboxBuscar.text);
            }
            else
            {
                MostarRegistroDiario();
            }
        }

        private void TextboxBuscar_Enter(object sender, EventArgs e)
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

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
