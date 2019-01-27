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
    public partial class frmPersona : Form
    {
        EstadoController contEst = new EstadoController();
        PersonaController contPers = new PersonaController(); 
        PruebaTecnicaEntities entities = new PruebaTecnicaEntities();
        /// <summary>
        /// Constructor para iniciar los combo box con valores.
        /// </summary>
        public frmPersona()
        {
            InitializeComponent();
            List<Estados> est = contEst.GetAllEstados();
            var estados = from campos in est orderby campos.Estado ascending
                          select new
                          {
                              Estado = campos.Estado
                          };
            cboxEstados.ValueMember = "Estado";
            cboxEstados.DisplayMember = "Estado";
            cboxEstados.DataSource = estados.ToList();
            cboxNacimiento.ValueMember = "Estado";
            cboxNacimiento.DisplayMember = "Estado";
            cboxNacimiento.DataSource = estados.ToList();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space)){
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtDelegacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtColonia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona pr = new Persona();
            string sexo = rbtnMasculino.Checked ? "M" : "F";
            pr.Nombre = txtNombre.Text;
            pr.ApPaterno = txtApPaterno.Text;
            pr.ApMaterno = txtApMaterno.Text;
            pr.FNacimiento = DateTime.Parse(dtpFNacimiento.Text);
            pr.Sexo = sexo;
            pr.IdEstadoN = 1;
            pr.IdEstado = 4;
            pr.Delegacion = txtDelegacion.Text;
            pr.Colonia = txtColonia.Text;
            pr.Calle = txtCalle.Text;
            pr.Numero = txtNumero.Text;
            //pr.Telefono = int.Parse(txtTelefono.Text);
            pr.Telefono = txtTelefono.Text;
            bool respuesta = contPers.AddPersona(pr);
            if (respuesta.Equals(true))
            {
                MessageBox.Show("Persona registrada");
            }
            else
            {
                MessageBox.Show("Persona No registrada");
            }
            
        }
    }
}
