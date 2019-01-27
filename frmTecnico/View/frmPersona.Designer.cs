namespace frmTecnico.View
{
    partial class frmPersona
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gboxPrincipales = new System.Windows.Forms.GroupBox();
            this.dtpFNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cboxNacimiento = new System.Windows.Forms.ComboBox();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.txtApMaterno = new System.Windows.Forms.TextBox();
            this.txtApPaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.etEstadoNac = new System.Windows.Forms.Label();
            this.etSexo = new System.Windows.Forms.Label();
            this.etFNacimiento = new System.Windows.Forms.Label();
            this.etApMaterno = new System.Windows.Forms.Label();
            this.etApPaterno = new System.Windows.Forms.Label();
            this.etNombre = new System.Windows.Forms.Label();
            this.fboxDomicilio = new System.Windows.Forms.GroupBox();
            this.cboxEstados = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDelegacion = new System.Windows.Forms.TextBox();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.etTelefono = new System.Windows.Forms.Label();
            this.etNumero = new System.Windows.Forms.Label();
            this.etCalle = new System.Windows.Forms.Label();
            this.etColonia = new System.Windows.Forms.Label();
            this.etDelegacion = new System.Windows.Forms.Label();
            this.etEstado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gboxPrincipales.SuspendLayout();
            this.fboxDomicilio.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(649, 454);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 119);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gboxPrincipales);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.fboxDomicilio);
            this.splitContainer1.Size = new System.Drawing.Size(643, 293);
            this.splitContainer1.SplitterDistance = 297;
            this.splitContainer1.TabIndex = 0;
            // 
            // gboxPrincipales
            // 
            this.gboxPrincipales.Controls.Add(this.dtpFNacimiento);
            this.gboxPrincipales.Controls.Add(this.cboxNacimiento);
            this.gboxPrincipales.Controls.Add(this.rbtnFemenino);
            this.gboxPrincipales.Controls.Add(this.rbtnMasculino);
            this.gboxPrincipales.Controls.Add(this.txtApMaterno);
            this.gboxPrincipales.Controls.Add(this.txtApPaterno);
            this.gboxPrincipales.Controls.Add(this.txtNombre);
            this.gboxPrincipales.Controls.Add(this.etEstadoNac);
            this.gboxPrincipales.Controls.Add(this.etSexo);
            this.gboxPrincipales.Controls.Add(this.etFNacimiento);
            this.gboxPrincipales.Controls.Add(this.etApMaterno);
            this.gboxPrincipales.Controls.Add(this.etApPaterno);
            this.gboxPrincipales.Controls.Add(this.etNombre);
            this.gboxPrincipales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxPrincipales.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxPrincipales.Location = new System.Drawing.Point(0, 0);
            this.gboxPrincipales.Name = "gboxPrincipales";
            this.gboxPrincipales.Size = new System.Drawing.Size(297, 293);
            this.gboxPrincipales.TabIndex = 0;
            this.gboxPrincipales.TabStop = false;
            this.gboxPrincipales.Text = "Datos personales";
            // 
            // dtpFNacimiento
            // 
            this.dtpFNacimiento.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFNacimiento.Location = new System.Drawing.Point(167, 134);
            this.dtpFNacimiento.Name = "dtpFNacimiento";
            this.dtpFNacimiento.Size = new System.Drawing.Size(108, 24);
            this.dtpFNacimiento.TabIndex = 12;
            // 
            // cboxNacimiento
            // 
            this.cboxNacimiento.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxNacimiento.FormattingEnabled = true;
            this.cboxNacimiento.Location = new System.Drawing.Point(167, 214);
            this.cboxNacimiento.Name = "cboxNacimiento";
            this.cboxNacimiento.Size = new System.Drawing.Size(121, 24);
            this.cboxNacimiento.TabIndex = 11;
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Location = new System.Drawing.Point(167, 187);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(97, 25);
            this.rbtnFemenino.TabIndex = 10;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Femenino";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(167, 163);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(99, 25);
            this.rbtnMasculino.TabIndex = 9;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApMaterno.Location = new System.Drawing.Point(167, 90);
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.Size = new System.Drawing.Size(100, 24);
            this.txtApMaterno.TabIndex = 8;
            this.txtApMaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApMaterno_KeyPress);
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApPaterno.Location = new System.Drawing.Point(167, 56);
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.Size = new System.Drawing.Size(100, 24);
            this.txtApPaterno.TabIndex = 7;
            this.txtApPaterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApPaterno_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(167, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 24);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // etEstadoNac
            // 
            this.etEstadoNac.AutoSize = true;
            this.etEstadoNac.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etEstadoNac.Location = new System.Drawing.Point(24, 222);
            this.etEstadoNac.Name = "etEstadoNac";
            this.etEstadoNac.Size = new System.Drawing.Size(137, 16);
            this.etEstadoNac.TabIndex = 5;
            this.etEstadoNac.Text = "Estado de Nacimiento";
            // 
            // etSexo
            // 
            this.etSexo.AutoSize = true;
            this.etSexo.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etSexo.Location = new System.Drawing.Point(24, 168);
            this.etSexo.Name = "etSexo";
            this.etSexo.Size = new System.Drawing.Size(36, 16);
            this.etSexo.TabIndex = 4;
            this.etSexo.Text = "Sexo";
            // 
            // etFNacimiento
            // 
            this.etFNacimiento.AutoSize = true;
            this.etFNacimiento.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etFNacimiento.Location = new System.Drawing.Point(24, 134);
            this.etFNacimiento.Name = "etFNacimiento";
            this.etFNacimiento.Size = new System.Drawing.Size(130, 16);
            this.etFNacimiento.TabIndex = 3;
            this.etFNacimiento.Text = "Fecha de Nacimiento";
            // 
            // etApMaterno
            // 
            this.etApMaterno.AutoSize = true;
            this.etApMaterno.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etApMaterno.Location = new System.Drawing.Point(24, 98);
            this.etApMaterno.Name = "etApMaterno";
            this.etApMaterno.Size = new System.Drawing.Size(110, 16);
            this.etApMaterno.TabIndex = 2;
            this.etApMaterno.Text = "Apellido Materno";
            // 
            // etApPaterno
            // 
            this.etApPaterno.AutoSize = true;
            this.etApPaterno.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etApPaterno.Location = new System.Drawing.Point(24, 63);
            this.etApPaterno.Name = "etApPaterno";
            this.etApPaterno.Size = new System.Drawing.Size(105, 16);
            this.etApPaterno.TabIndex = 1;
            this.etApPaterno.Text = "Apellido Paterno";
            // 
            // etNombre
            // 
            this.etNombre.AutoSize = true;
            this.etNombre.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etNombre.Location = new System.Drawing.Point(24, 29);
            this.etNombre.Name = "etNombre";
            this.etNombre.Size = new System.Drawing.Size(57, 16);
            this.etNombre.TabIndex = 0;
            this.etNombre.Text = "Nombre";
            // 
            // fboxDomicilio
            // 
            this.fboxDomicilio.Controls.Add(this.cboxEstados);
            this.fboxDomicilio.Controls.Add(this.txtTelefono);
            this.fboxDomicilio.Controls.Add(this.txtDelegacion);
            this.fboxDomicilio.Controls.Add(this.txtColonia);
            this.fboxDomicilio.Controls.Add(this.txtCalle);
            this.fboxDomicilio.Controls.Add(this.txtNumero);
            this.fboxDomicilio.Controls.Add(this.etTelefono);
            this.fboxDomicilio.Controls.Add(this.etNumero);
            this.fboxDomicilio.Controls.Add(this.etCalle);
            this.fboxDomicilio.Controls.Add(this.etColonia);
            this.fboxDomicilio.Controls.Add(this.etDelegacion);
            this.fboxDomicilio.Controls.Add(this.etEstado);
            this.fboxDomicilio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fboxDomicilio.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fboxDomicilio.Location = new System.Drawing.Point(0, 0);
            this.fboxDomicilio.Name = "fboxDomicilio";
            this.fboxDomicilio.Size = new System.Drawing.Size(342, 293);
            this.fboxDomicilio.TabIndex = 0;
            this.fboxDomicilio.TabStop = false;
            this.fboxDomicilio.Text = "Domicilio Actual";
            // 
            // cboxEstados
            // 
            this.cboxEstados.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxEstados.FormattingEnabled = true;
            this.cboxEstados.Location = new System.Drawing.Point(188, 21);
            this.cboxEstados.Name = "cboxEstados";
            this.cboxEstados.Size = new System.Drawing.Size(121, 24);
            this.cboxEstados.TabIndex = 13;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(188, 202);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 24);
            this.txtTelefono.TabIndex = 10;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtDelegacion
            // 
            this.txtDelegacion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDelegacion.Location = new System.Drawing.Point(188, 51);
            this.txtDelegacion.Name = "txtDelegacion";
            this.txtDelegacion.Size = new System.Drawing.Size(100, 24);
            this.txtDelegacion.TabIndex = 9;
            this.txtDelegacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDelegacion_KeyPress);
            // 
            // txtColonia
            // 
            this.txtColonia.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColonia.Location = new System.Drawing.Point(188, 93);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(100, 24);
            this.txtColonia.TabIndex = 8;
            this.txtColonia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColonia_KeyPress);
            // 
            // txtCalle
            // 
            this.txtCalle.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalle.Location = new System.Drawing.Point(188, 129);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(100, 24);
            this.txtCalle.TabIndex = 7;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(188, 167);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 24);
            this.txtNumero.TabIndex = 6;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // etTelefono
            // 
            this.etTelefono.AutoSize = true;
            this.etTelefono.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etTelefono.Location = new System.Drawing.Point(25, 205);
            this.etTelefono.Name = "etTelefono";
            this.etTelefono.Size = new System.Drawing.Size(59, 16);
            this.etTelefono.TabIndex = 5;
            this.etTelefono.Text = "Telefono";
            // 
            // etNumero
            // 
            this.etNumero.AutoSize = true;
            this.etNumero.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etNumero.Location = new System.Drawing.Point(25, 168);
            this.etNumero.Name = "etNumero";
            this.etNumero.Size = new System.Drawing.Size(56, 16);
            this.etNumero.TabIndex = 4;
            this.etNumero.Text = "Numero";
            // 
            // etCalle
            // 
            this.etCalle.AutoSize = true;
            this.etCalle.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etCalle.Location = new System.Drawing.Point(25, 134);
            this.etCalle.Name = "etCalle";
            this.etCalle.Size = new System.Drawing.Size(36, 16);
            this.etCalle.TabIndex = 3;
            this.etCalle.Text = "Calle";
            // 
            // etColonia
            // 
            this.etColonia.AutoSize = true;
            this.etColonia.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etColonia.Location = new System.Drawing.Point(25, 98);
            this.etColonia.Name = "etColonia";
            this.etColonia.Size = new System.Drawing.Size(52, 16);
            this.etColonia.TabIndex = 2;
            this.etColonia.Text = "Colonia";
            // 
            // etDelegacion
            // 
            this.etDelegacion.AutoSize = true;
            this.etDelegacion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etDelegacion.Location = new System.Drawing.Point(25, 63);
            this.etDelegacion.Name = "etDelegacion";
            this.etDelegacion.Size = new System.Drawing.Size(145, 16);
            this.etDelegacion.TabIndex = 1;
            this.etDelegacion.Text = "Delegación o municipio";
            // 
            // etEstado
            // 
            this.etEstado.AutoSize = true;
            this.etEstado.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etEstado.Location = new System.Drawing.Point(25, 31);
            this.etEstado.Name = "etEstado";
            this.etEstado.Size = new System.Drawing.Size(105, 16);
            this.etEstado.TabIndex = 0;
            this.etEstado.Text = "Estado o Ciudad";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 33);
            this.panel1.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(244, 1);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 32);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 454);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmPersona";
            this.Text = "Registro de Personal";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gboxPrincipales.ResumeLayout(false);
            this.gboxPrincipales.PerformLayout();
            this.fboxDomicilio.ResumeLayout(false);
            this.fboxDomicilio.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gboxPrincipales;
        private System.Windows.Forms.Label etEstadoNac;
        private System.Windows.Forms.Label etSexo;
        private System.Windows.Forms.Label etFNacimiento;
        private System.Windows.Forms.Label etApMaterno;
        private System.Windows.Forms.Label etApPaterno;
        private System.Windows.Forms.Label etNombre;
        private System.Windows.Forms.GroupBox fboxDomicilio;
        private System.Windows.Forms.ComboBox cboxNacimiento;
        private System.Windows.Forms.RadioButton rbtnFemenino;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.TextBox txtApMaterno;
        private System.Windows.Forms.TextBox txtApPaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dtpFNacimiento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cboxEstados;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDelegacion;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label etTelefono;
        private System.Windows.Forms.Label etNumero;
        private System.Windows.Forms.Label etCalle;
        private System.Windows.Forms.Label etColonia;
        private System.Windows.Forms.Label etDelegacion;
        private System.Windows.Forms.Label etEstado;
    }
}