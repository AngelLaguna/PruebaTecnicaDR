using frmTecnico.Controller;
using frmTecnico.Model;
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
    public partial class frmConsultaCurp : Form
    {
        PersonaController prs = new PersonaController();
        public frmConsultaCurp()
        {
            InitializeComponent();
            dgvTablaPersonas.DataSource = prs.GetAllPersonas();
        }

        /// <summary>
        /// Accion para generar el CURP de la persona Seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvTablaPersonas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Persona p = new Persona();
            Estados es = new Estados();
            p.Nombre = dgvTablaPersonas.CurrentRow.Cells["Nombre"].Value.ToString();
            p.ApPaterno = dgvTablaPersonas.CurrentRow.Cells["ApPaterno"].Value.ToString();
            p.ApMaterno = dgvTablaPersonas.CurrentRow.Cells["ApMaterno"].Value.ToString();
            p.Sexo = dgvTablaPersonas.CurrentRow.Cells["Sexo"].Value.ToString();
            p.FNacimiento = DateTime.Parse(dgvTablaPersonas.CurrentRow.Cells["FNacimiento"].Value.ToString());
            es.Estado = dgvTablaPersonas.CurrentRow.Cells["Clave"].Value.ToString();
            pruebaCURP(p, es);
        }

        /// <summary>
        /// Metodo para visualizar el curp de la persona seleccionada en el gridview
        /// </summary>
        /// <param name="pr"></param>
        /// <param name="es"></param>
        public void pruebaCURP(Persona pr, Estados es)
        {
            CURP curp = new CURP();
            char se = char.Parse(pr.Sexo);
            string fe = Convert.ToString(pr.FNacimiento);
            string resultado = curp.ObtenCurp(pr.Nombre, pr.ApPaterno, pr.ApMaterno, se, fe, es.Estado);
            MessageBox.Show(resultado);
            etConsultaCurp.Text = resultado;
        }

        /// <summary>
        /// Metodo para dirigirse al formulario frmPersona : registrar una nueva persona
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmPersona per = new frmPersona();
            per.Show();
        }
    }
}
