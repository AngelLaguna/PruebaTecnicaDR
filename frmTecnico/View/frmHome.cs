using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmTecnico.View
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.Show();
        }

        private void btnEstados_Click(object sender, EventArgs e)
        {
            frmEstados frmE = new frmEstados();
            frmE.Show();
        }
    }
}
