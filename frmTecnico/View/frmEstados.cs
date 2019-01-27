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
    public partial class frmEstados : Form
    {
        EstadoController cont = new EstadoController();
        public frmEstados()
        {
            InitializeComponent();
            dgvEstados.DataSource = cont.GetAllEstados();
        }

        private void btnGuardarEstado_Click(object sender, EventArgs e)
        {
            Estados est = new Estados();
            est.Estado = txtNEstado.Text;
            if (est.Estado.Equals(""))
            {
                MessageBox.Show("Es necesario escribir un estado");
            }else
            {
                if (cont.AddEstado(est).Equals(true)){
                    MessageBox.Show("Estado almacenado correctamente");
                    dgvEstados.DataSource = cont.GetAllEstados();
                    txtNEstado.Text = "";
                }
                else
                {
                    MessageBox.Show("Ocurrio un problema al guardar");
                }
            }
        }
    }
}
