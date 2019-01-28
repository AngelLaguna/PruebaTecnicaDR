namespace frmTecnico.View
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.btnPersona = new System.Windows.Forms.Button();
            this.btnEstados = new System.Windows.Forms.Button();
            this.btnCurp = new System.Windows.Forms.Button();
            this.etTitulo = new System.Windows.Forms.Label();
            this.etTituloDos = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPersona
            // 
            this.btnPersona.Image = ((System.Drawing.Image)(resources.GetObject("btnPersona.Image")));
            this.btnPersona.Location = new System.Drawing.Point(18, 88);
            this.btnPersona.Name = "btnPersona";
            this.btnPersona.Size = new System.Drawing.Size(111, 109);
            this.btnPersona.TabIndex = 0;
            this.btnPersona.Text = "Registrar Persona";
            this.btnPersona.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPersona.UseVisualStyleBackColor = true;
            this.btnPersona.Click += new System.EventHandler(this.btnPersona_Click);
            // 
            // btnEstados
            // 
            this.btnEstados.Image = ((System.Drawing.Image)(resources.GetObject("btnEstados.Image")));
            this.btnEstados.Location = new System.Drawing.Point(146, 88);
            this.btnEstados.Name = "btnEstados";
            this.btnEstados.Size = new System.Drawing.Size(111, 109);
            this.btnEstados.TabIndex = 1;
            this.btnEstados.Text = "Registrar Estados";
            this.btnEstados.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEstados.UseVisualStyleBackColor = true;
            this.btnEstados.Click += new System.EventHandler(this.btnEstados_Click);
            // 
            // btnCurp
            // 
            this.btnCurp.Image = ((System.Drawing.Image)(resources.GetObject("btnCurp.Image")));
            this.btnCurp.Location = new System.Drawing.Point(277, 88);
            this.btnCurp.Name = "btnCurp";
            this.btnCurp.Size = new System.Drawing.Size(111, 109);
            this.btnCurp.TabIndex = 2;
            this.btnCurp.Text = "Generar CURP";
            this.btnCurp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCurp.UseVisualStyleBackColor = true;
            this.btnCurp.Click += new System.EventHandler(this.btnCurp_Click);
            // 
            // etTitulo
            // 
            this.etTitulo.AutoSize = true;
            this.etTitulo.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etTitulo.Location = new System.Drawing.Point(12, 9);
            this.etTitulo.Name = "etTitulo";
            this.etTitulo.Size = new System.Drawing.Size(158, 35);
            this.etTitulo.TabIndex = 3;
            this.etTitulo.Text = "Bienvenido";
            // 
            // etTituloDos
            // 
            this.etTituloDos.AutoSize = true;
            this.etTituloDos.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etTituloDos.Location = new System.Drawing.Point(29, 44);
            this.etTituloDos.Name = "etTituloDos";
            this.etTituloDos.Size = new System.Drawing.Size(323, 21);
            this.etTituloDos.TabIndex = 4;
            this.etTituloDos.Text = "Registro de personal y Consulta de CURP";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(163, 232);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(405, 267);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.etTituloDos);
            this.Controls.Add(this.etTitulo);
            this.Controls.Add(this.btnCurp);
            this.Controls.Add(this.btnEstados);
            this.Controls.Add(this.btnPersona);
            this.MaximizeBox = false;
            this.Name = "frmHome";
            this.Text = "Menu principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPersona;
        private System.Windows.Forms.Button btnEstados;
        private System.Windows.Forms.Button btnCurp;
        private System.Windows.Forms.Label etTitulo;
        private System.Windows.Forms.Label etTituloDos;
        private System.Windows.Forms.Button btnSalir;
    }
}