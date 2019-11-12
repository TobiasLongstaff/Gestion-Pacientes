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
    public partial class Menu : Form
    {
        CN_Pacientes objetoCN = new CN_Pacientes();
        public bool Editar = false;
        int cont = 0;
        public string X;
        public string Y;
        public bool MenuOpen;
        int heightB = 63;
        int heightI = 72;
        public Menu()
        {
            InitializeComponent();
            PanelesNoVisibles();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer1.Start();
            BotonListaDePacientes.Location = new Point(0, heightB);
            pictureBoxLP.Location = new Point(22, heightI);
            BotonAdmision.Location = new Point(0, heightB + 50);
            pictureBoxFDA.Location = new Point(22, heightI + 50);
            BotonRegistroDiario.Location = new Point(0, heightB + 100);
            pictureBoxRD.Location = new Point(22, heightI + 100);
            BotonControlDePagos.Location = new Point(0, heightB + 150);
            pictureBoxCDP.Location = new Point(22, heightI + 150);
            BotonEvaEInfo.Location = new Point(0, heightB + 150);
            pictureBoxEEI.Location = new Point(22, heightI + 150);
            MostrarPacientes();
            CargarCache();
        }

        private void PanelesNoVisibles()
        {
            panelListaDePacientes.Visible = false;
            panelControlDePagos.Visible = false;
            panelRegistroDiario.Visible = false;
        }

        private void HideSubMenu()
        {
            if (panelListaDePacientes.Visible == true)
            {
                panelBarra.Visible = true;
                panelControlDePagos.Visible = false;
                panelRegistroDiario.Visible = false;
                BotonAdmision.Location = new Point(0, heightB + 100);
                pictureBoxFDA.Location = new Point(22, heightI + 100);
                BotonRegistroDiario.Location = new Point(0, heightB + 150);
                pictureBoxRD.Location = new Point(22, heightI + 150);
                BotonControlDePagos.Location = new Point(0, heightB + 200);
                pictureBoxCDP.Location = new Point(22, heightI + 200);
                BotonEvaEInfo.Location = new Point(0, heightB + 200);
                pictureBoxEEI.Location = new Point(22, heightI + 200);
            }
            if (panelControlDePagos.Visible == true)
            {
                panelBarra.Visible = true;
                panelListaDePacientes.Visible = false;
                panelRegistroDiario.Visible = false;
                BotonAdmision.Location = new Point(0, heightB + 50);
                pictureBoxFDA.Location = new Point(22, heightI + 50);
                BotonRegistroDiario.Location = new Point(0, heightB + 100);
                pictureBoxRD.Location = new Point(22, heightI + 100);
                BotonControlDePagos.Location = new Point(0, heightB + 150);
                pictureBoxCDP.Location = new Point(22, heightI + 150);
                BotonEvaEInfo.Location = new Point(0, heightB + 150);
                pictureBoxEEI.Location = new Point(22, heightI + 150);
                panelControlDePagos.Location = new Point(0, heightI + 200);
            }
            if (panelRegistroDiario.Visible == true)
            {
                panelBarra.Visible = true;
                panelListaDePacientes.Visible = false;
                panelControlDePagos.Visible = false;
                BotonAdmision.Location = new Point(0, heightB + 50);
                pictureBoxFDA.Location = new Point(22, heightI + 50);
                BotonRegistroDiario.Location = new Point(0, heightB + 100);
                pictureBoxRD.Location = new Point(22, heightI + 100);
                panelRegistroDiario.Location = new Point(0, heightB + 150);
                BotonControlDePagos.Location = new Point(0, heightB + 200);
                pictureBoxCDP.Location = new Point(22, heightI + 200);
                BotonEvaEInfo.Location = new Point(0, heightB + 200);
                pictureBoxEEI.Location = new Point(22, heightI + 200);
            }
        }

        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
                panelBarra.Visible = false;
                BotonListaDePacientes.Location = new Point(0, heightB);
                pictureBoxLP.Location = new Point(22, heightI);
                BotonAdmision.Location = new Point(0, heightB + 50);
                pictureBoxFDA.Location = new Point(22, heightI + 50);
                BotonRegistroDiario.Location = new Point(0, heightB + 100);
                pictureBoxRD.Location = new Point(22, heightI + 100);
                BotonControlDePagos.Location = new Point(0, heightB + 150);
                pictureBoxCDP.Location = new Point(22, heightI + 150);
                BotonEvaEInfo.Location = new Point(0, heightB + 150);
                pictureBoxEEI.Location = new Point(22, heightI + 150);
            }
        }

        private void MostrarPacientes()
        {
            //CN_Usuarios objeto = new CN_Usuarios();
            //dataGridView1.DataSource = objeto.MostrarPa();
        }
        
        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            MoverForm();
            Agregar Formulario2 = new Agregar();
            Formulario2.label6.Text = "Agregar";
            Formulario2.Show();
        }

        private void MoverForm()
        {
            Screen respantalla = Screen.PrimaryScreen;
            int whidth = respantalla.Bounds.Width;
            int height = respantalla.Bounds.Height;
            int posX = whidth - 1697;
            int posY = height - 933;
            this.Location = new Point(posX, posY);
        }

        private void MoverBotones()
        {
            BotonAdmision.Location = new Point(0, 110);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de que quieres salir de la aplicacion?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                timer2.Enabled = true;
            }
        }

        private void BotonActualizar_Click(object sender, EventArgs e)
        {
            MostrarPacientes();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void button6_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelListaDePacientes);
            HideSubMenu();
            labelInd.Text = "Lista de pacientes";
            panelLabel.Visible = false;
            Transition1.ShowSync(panelLabel);
            ListaDePacientes CDP = new ListaDePacientes();
            AddOwnedForm(CDP);
            AbrirFormularioHijo(new ListaDePacientes());
        }

        private Form activeForm = null;
        public void AbrirFormularioHijo(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None; 
            panelBarra.Controls.Add(childForm);
            panelBarra.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BotonControlDePagos_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelControlDePagos);
            HideSubMenu();
            labelInd.Text = "Control de pagos";
            panelLabel.Visible = false;
            Transition1.ShowSync(panelLabel);
            ControlDePagos controldepago = new ControlDePagos();
            AbrirFormularioHijo(controldepago);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            MoverForm();
            AgregarPagoObra agregarpagoobre = new AgregarPagoObra();
            agregarpagoobre.Show();
        }

        private void BotonCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de que quiere cerrar sesion?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                timer2.Enabled = true;
                Form1 form1 = new Form1();
                form1.Show();
            }
        }

        private void BotonConfigurar_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FormConfiguracion());
        }

        private void CargarCache()
        {
            LabelUsuario.Text = CacheUsuarios.Nombre;
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

        private void BotonAdmision_Click(object sender, EventArgs e)
        {
            panelBarra.Visible = true;
            panelLabel.Visible = false;
            labelInd.Text = "Fichas de admision";
            Transition1.ShowSync(panelLabel);
            AgregarFichasDeAdmision fichasDeAdmision = new AgregarFichasDeAdmision();
            AbrirFormularioHijo(fichasDeAdmision);

        }

        private void BotonFichaDePacientes_Click(object sender, EventArgs e)
        {
            labelInd.Text = "Fichas de pacientes";
        }

        private void BotonRegistroDiario_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelRegistroDiario);
            HideSubMenu();
            labelInd.Text = "Registro diario";
            panelLabel.Visible = false;
            Transition1.ShowSync(panelLabel);
            RegistroDiario registrodiario = new RegistroDiario();
            AbrirFormularioHijo(registrodiario);
        }

        private void BotonDiasDeAsistencia_Click(object sender, EventArgs e)
        {
            labelInd.Text = "Dias de asistencia";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MoverForm();
            AgregarRegistroDiario agregarregistro = new AgregarRegistroDiario();
            agregarregistro.Show();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label1.Text = this.Location.X.ToString();
            label2.Text = this.Location.Y.ToString();
            X = label1.Text;
            Y = label2.Text;
        }

        private void BotonMesesPagos_Click(object sender, EventArgs e)
        {

        }

        private void BotonMenu_Click(object sender, EventArgs e)
        {
            ListaDePacientes listadepacientes = new ListaDePacientes();
            if (panelLeft.Width == 72)
            {
                panelLeft.Visible = false;
                panelLeft.Width = 244;
                panel1.Width = 990;
                panel1.Location = new Point(243, 0);
                pictureBox7.Width = 1010;
                pictureBox7.Location = new Point(0, 0);
                panelBarra.Width = 1010;
                panelBarra.Location = new Point(244, 62);
                Transition1.ShowSync(panelLeft);
            }
            else
            {
                panelLeft.Visible = false;
                panelLeft.Width = 72;
                panel1.Width = 1160;
                panel1.Location = new Point(72, 0);
                pictureBox7.Width = 1160;
                pictureBox7.Location = new Point(0, 0);
                panelBarra.Width = 1160;
                panelBarra.Location = new Point(72, 62);
                Transition1.ShowSync(panelLeft);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelBarra.Visible = true;
            labelInd.Text = "Evaluaciones e informes";
            panelLabel.Visible = false;
            Transition1.ShowSync(panelLabel);
            Evaluaciones_e_informes evaluacioneseinformes = new Evaluaciones_e_informes();
            AbrirFormularioHijo(evaluacioneseinformes);
        }

        private void BotonListaDePacientes_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxLP.BackColor = Color.FromArgb(127, 133, 212);
        }

        private void BotonListaDePacientes_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxLP.BackColor = Color.FromArgb(92, 121, 203);
        }

        private void BotonAdmision_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxFDA.BackColor = Color.FromArgb(127, 133, 212);
        }

        private void BotonAdmision_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxFDA.BackColor = Color.FromArgb(92, 121, 203);
        }

        private void BotonRegistroDiario_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxRD.BackColor = Color.FromArgb(127, 133, 212);
        }

        private void BotonRegistroDiario_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxRD.BackColor = Color.FromArgb(92, 121, 203);
        }

        private void BotonEvaEInfo_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxEEI.BackColor = Color.FromArgb(127, 133, 212);
        }

        private void BotonEvaEInfo_MouseEnter(object sender, EventArgs e)
        {
            pictureBoxEEI.BackColor = Color.FromArgb(92, 121, 203);
        }
    }
}
