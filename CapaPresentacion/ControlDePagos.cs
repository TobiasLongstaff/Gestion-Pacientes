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
    public partial class ControlDePagos : Form
    {
        public ControlDePagos()
        {
            InitializeComponent();
        }

        CN_Pacientes cn_pacientes = new CN_Pacientes();

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ControlDePagos_Load(object sender, EventArgs e)
        {
            ListaObrasSociales();
            //this.Grafico.Series["Series1"].Points.AddXY(bunifuCustomDataGrid1.CurrentRow.Cells["TotalPagado"].Value.ToString(), bunifuCustomDataGrid1.CurrentRow.Cells["FechaDePago"].Value.ToString());
            //this.Grafico.Series["Series1"].Points.AddXY(4, 5);
            //this.Grafico.Series["Series1"].Points.AddXY(5, 8);
            //this.Grafico.Series["Series1"].Points.AddXY(8, 3);
            Bunifu.Framework.Lib.Elipse.Apply(PanelOsede, 10);
            Bunifu.Framework.Lib.Elipse.Apply(PanelIoma, 10);
            Bunifu.Framework.Lib.Elipse.Apply(PanelOsprera, 10);
            Bunifu.Framework.Lib.Elipse.Apply(PaneOtros, 10);
            Transition1.ShowSync(panelFondo);
            Transition1.ShowSync(panelBotones);
        }

        private void ListaObrasSociales()
        {
            ComboboxObraSocial.DataSource = cn_pacientes.MostarObra();
            ComboboxObraSocial.DisplayMember = "ObrasSociales";
            ComboboxObraSocial.ValueMember = "IDObrasSociales";
        }

        private void ComboboxObraSocial_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                CN_Pacientes cn_pacientes = new CN_Pacientes();
                bunifuCustomDataGrid1.DataSource = cn_pacientes.SelcionarObra(ComboboxObraSocial.SelectedValue.ToString());
                labelUltimoOsde.Text = bunifuCustomDataGrid1.CurrentRow.Cells["TotalPagado"].Value.ToString();
                this.Grafico.Series["Series1"].Points.AddXY(bunifuCustomDataGrid1.CurrentRow.Cells["TotalPagado"].Value.ToString(), bunifuCustomDataGrid1.CurrentRow.Cells["FechaDePago"].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
        }
    }
}
