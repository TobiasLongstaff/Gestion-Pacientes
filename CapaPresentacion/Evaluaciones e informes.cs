using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using CapaNegosio;

namespace CapaPresentacion
{
    public partial class Evaluaciones_e_informes : Form
    {
        public Evaluaciones_e_informes()
        {
            InitializeComponent();
        }



        CN_Pacientes cn_pacientes = new CN_Pacientes();

        private void Evaluaciones_e_informes_Load(object sender, EventArgs e)
        {
            MostrarArchivosEvaluaciones();
            MostrarArchivosInformes();
            Transition2.ShowSync(panelFondo);

        }

        private void MostrarArchivosEvaluaciones()
        {
            listView1.Items.Clear();
            var di = new DirectoryInfo(Application.StartupPath + @"\Evaluaciones");
            foreach (FileInfo fi in di.GetFiles())
            {
                string ext = fi.Extension;
                if (!imageList1.Images.Keys.Contains(ext))
                {
                    imageList1.Images.Add(ext, Icon.ExtractAssociatedIcon(fi.FullName));
                }
                int index = imageList1.Images.Keys.IndexOf(ext);
                ListViewItem item = new ListViewItem();
                item.Text = fi.Name;
                item.ImageIndex = index;
                listView1.Items.Add(item);
            }
        }

        private void MostrarArchivosInformes()
        {
            listView2.Items.Clear();
            var di = new DirectoryInfo(Application.StartupPath + @"\Informes");
            foreach (FileInfo fi in di.GetFiles())
            {
                string ext = fi.Extension;
                if (!imageList1.Images.Keys.Contains(ext))
                {
                    imageList1.Images.Add(ext, Icon.ExtractAssociatedIcon(fi.FullName));
                }
                int index = imageList1.Images.Keys.IndexOf(ext);
                ListViewItem item = new ListViewItem();
                item.Text = fi.Name;
                item.ImageIndex = index;
                listView2.Items.Add(item);
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxArchivoDireccion.Text = openFileDialog1.FileName;
                textBoxNombreDelArchivo.Text = openFileDialog1.SafeFileName;
            }
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombreDelArchivo.Text;
            string Archivo = textBoxArchivoDireccion.Text;
            string Direccion1 = Application.StartupPath + @"\Evaluaciones\" + nombre;
            string Direccion2 = Application.StartupPath + @"\Informes\" + nombre;
            if (textBoxNombreDelArchivo.Text != "")
            {
                if (textBoxArchivoDireccion.Text != "")
                {
                    if (DropdownTipoDeArchivo.selectedIndex != -1)
                    {
                        try
                        {
                            if (DropdownTipoDeArchivo.selectedIndex == 0)
                            {
                                File.Move(Archivo , Direccion1);
                            }
                            if (DropdownTipoDeArchivo.selectedIndex == 1)
                            {
                                File.Move(Archivo, Direccion2);
                            }
                            cn_pacientes.InsertarEvalua(textBoxNombreDelArchivo.Text, textBoxArchivoDireccion.Text, DropdownTipoDeArchivo.selectedValue);
                            MostrarArchivosEvaluaciones();
                            MostrarArchivosInformes();
                            MessageBox.Show("Guardado");

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex);
                        }
                    }
                    else
                    {
                        msError("Seleccionar si es un informe o una evaluacion");
                    }
                }
                else
                {
                    msError("Selecciona el archivo que\nquieres guardar");
                }
            }
            else
            {
                msError("Colocar el nombre del archivo");
            }
        }

        private void msError(string Error)
        {
            LabelError.Text = Error;
            LabelError.Visible = true;
            pictureBoxError.Visible = true;
        }

        private void TextboxBuscar_OnTextChange(object sender, EventArgs e)
        {
            if (TextboxBuscar.text != "Buscar evaluacion o informe")
            {
                if (TextboxBuscar.text == "")
                {
                    paneldatagrid.Visible = false;
                }
                else
                {
                    CN_Pacientes cn_pacientes = new CN_Pacientes();
                    bunifuCustomDataGrid1.DataSource = cn_pacientes.BuscarEvaluacion(TextboxBuscar.text);
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
            if (TextboxBuscar.text == "Buscar evaluacion o informe")
            {
                TextboxBuscar.text = "";
            }
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNombre.Text = bunifuCustomDataGrid1.CurrentRow.Cells["NombreDelArchivo"].Value.ToString();
            textBoxNombreDelArchivo.Text = bunifuCustomDataGrid1.CurrentRow.Cells["NombreDelArchivo"].Value.ToString();
            textBoxArchivoDireccion.Text = bunifuCustomDataGrid1.CurrentRow.Cells["DireccionDelArchivo"].Value.ToString();
            string InfO = bunifuCustomDataGrid1.CurrentRow.Cells["TipoDeArchivo"].Value.ToString();
            if (InfO == "Informe")
            {
                DropdownTipoDeArchivo.selectedIndex = 1;
            }
            if (InfO == "Evaluacion")
            {
                DropdownTipoDeArchivo.selectedIndex = 0;
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (DropdownTipoDeArchivo.selectedIndex == 0)
            {
                Process.Start(Application.StartupPath + @"\Evaluaciones\" + textBoxNombre.Text);
            }
            if (DropdownTipoDeArchivo.selectedIndex == 1)
            {
                Process.Start(Application.StartupPath + @"\Informes\" + textBoxNombre.Text);
            }

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            DropdownTipoDeArchivo.selectedIndex = 0;
            textBoxNombre.Text = listView1.SelectedItems[0].Text;
        }

        private void listView2_MouseClick(object sender, MouseEventArgs e)
        {
            DropdownTipoDeArchivo.selectedIndex = 1;
            textBoxNombre.Text = listView2.SelectedItems[0].Text;
        }

        private void BotonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
