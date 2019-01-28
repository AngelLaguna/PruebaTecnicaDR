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

        /// <summary>
        /// Metodo para registrar el estado en a base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardarEstado_Click(object sender, EventArgs e)
        {
            if (txtNEstado.Text.Equals("") && txtClave.Text.Equals(""))
            {
                MessageBox.Show("Los campos son obligatorios");
            }
            else
            {
                Estados est = new Estados();
                est.Estado = txtNEstado.Text;
                est.Clave = txtClave.Text;
                if (est.Estado.Equals("") && est.Clave.Equals(""))
                {
                    MessageBox.Show("Es necesario escribir un estado");
                }
                else
                {
                    if (cont.AddEstado(est).Equals(true))
                    {
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

        private void txtNEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
