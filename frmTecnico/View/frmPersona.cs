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

        /// <summary>
        /// Metodo para validacion del campo nombre, solo debe aceptar letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space)){
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Metodo para validacion del campo apellido paterno, solo debe aceptar letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtApPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Metodo para validacoin del campo apellido Materno, solo debe aceptar letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtApMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Metodo para validacion del campo delegacion, solo debe aceptar letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDelegacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Metodo para validacion del campo Colonia, solo debe aceptar letras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtColonia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Metodo para validacion del campo Numero, debe de ser alfanumerico
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Metodo para valicaion del campo Telefono, debe aceptar solo numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        /// <summary>
        /// Metodo para instanciar el controlador persona y registrar
        /// en la base de datos a una persona
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validaciones().Equals(true))
            {
                Persona pr = new Persona();
                Estados es = new Estados();
                Estados es2 = new Estados();
                es.Estado = cboxNacimiento.Text;
                es2.Estado = cboxEstados.Text;
                string sexo = rbtnMasculino.Checked ? "M" : "F";
                pr.Nombre = txtNombre.Text;
                pr.ApPaterno = txtApPaterno.Text;
                pr.ApMaterno = txtApMaterno.Text;
                pr.FNacimiento = DateTime.Parse(dtpFNacimiento.Text);
                pr.Sexo = sexo;
                es.Estado = cboxNacimiento.Text;
                es2.Estado = cboxEstados.Text;
                pr.Delegacion = txtDelegacion.Text;
                pr.Colonia = txtColonia.Text;
                pr.Calle = txtCalle.Text;
                pr.Numero = txtNumero.Text;
                pr.Telefono = txtTelefono.Text;
                bool respuesta = contPers.AddPersona(pr, es, es2);
                if (respuesta.Equals(true))
                {
                    MessageBox.Show("Persona registrada");
                    pruebaCURP(pr, es);
                }
                else
                {
                    MessageBox.Show("Persona No registrada");
                }
            }else
            {
                MessageBox.Show("Por favor de llenar todos los campos obligatorios");
            }
            
        }

        /// <summary>
        /// Metodo para obtener el CURP de la persona registrada
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
        }

        /// <summary>
        /// Metodo para validar los campos obligatorios
        /// </summary>
        /// <returns></returns>
        public bool validaciones()
        {
            if(txtNombre.Text.Equals("") && txtApPaterno.Text.Equals("") && 
                txtApMaterno.Text.Equals("") && txtDelegacion.Text.Equals("") && 
                txtColonia.Text.Equals("") && txtCalle.Text.Equals("") && txtNumero.Text.Equals(""))
            {
                return false;
            }else
            {
                return true;
            }
        }

        public bool validarCampos()
        {
            foreach (Control item in this.Controls)
            {
                try
                {
                    if (item is TextBox)
                    {
                        if (item.Text.Equals(""))
                        {
                            MessageBox.Show("Existen campos vacios");
                            item.Focus();
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }
            return true;
        }


    }
}
