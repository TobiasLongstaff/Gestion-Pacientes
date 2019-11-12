using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FichasDeAdmision : Form
    {
        public FichasDeAdmision()
        {
            InitializeComponent();
        }

        private void FichasDeAdmision_Load(object sender, EventArgs e)
        {
            Transition1.ShowSync(panelFondo);
            Transition1.ShowSync(panelBotones);
        }
    }
}
