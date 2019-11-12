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
    public partial class AgregarPagoObra : Form
    {
        public AgregarPagoObra()
        {
            InitializeComponent();
        }

        CN_Pacientes cn_pacientes = new CN_Pacientes();

        private void AgregarPagoObra_Load(object sender, EventArgs e)
        {
            ListaObrasSociales();
            this.Opacity = 0.0;
            timer1.Start();
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

        private void ListaObrasSociales()
        {
            ComboboxObraSocial.DataSource = cn_pacientes.MostarObra();
            ComboboxObraSocial.DisplayMember = "ObrasSociales";
            ComboboxObraSocial.ValueMember = "IDObrasSociales";
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
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

        private void GuardarRegistro()
        {
            try
            {
                cn_pacientes.insertarPagoObra(TexboxFecha.Text, ComboboxObraSocial.SelectedValue.ToString(), textBoxTotal.Text);
                MessageBox.Show("Guardado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
        }

    }
}
