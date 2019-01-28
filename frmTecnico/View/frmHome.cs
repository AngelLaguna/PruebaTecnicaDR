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

        /// <summary>
        /// Boton para acceder al formularo "frmPersona" : Registra una persona y muestra el CURP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPersona_Click(object sender, EventArgs e)
        {
            frmPersona frm = new frmPersona();
            frm.Show();
        }

        /// <summary>
        /// Boton para acceder al formulario "frmEstados" : Registro de Estados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEstados_Click(object sender, EventArgs e)
        {
            frmEstados frmE = new frmEstados();
            frmE.Show();
        }

        /// <summary>
        /// Boton para acceder al formulario "frmConsultaCurp" : Se muestran los registros de personas
        /// al dar doble clic en el registro se muestra el CURP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCurp_Click(object sender, EventArgs e)
        {
            frmConsultaCurp frmCurp = new frmConsultaCurp();
            frmCurp.Show();
        }
    }
}
