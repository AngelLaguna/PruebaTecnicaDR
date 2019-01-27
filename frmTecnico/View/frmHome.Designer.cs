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
            this.btnPersona = new System.Windows.Forms.Button();
            this.btnEstados = new System.Windows.Forms.Button();
            this.btnCurp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPersona
            // 
            this.btnPersona.Location = new System.Drawing.Point(34, 80);
            this.btnPersona.Name = "btnPersona";
            this.btnPersona.Size = new System.Drawing.Size(75, 38);
            this.btnPersona.TabIndex = 0;
            this.btnPersona.Text = "Crear Persona";
            this.btnPersona.UseVisualStyleBackColor = true;
            this.btnPersona.Click += new System.EventHandler(this.btnPersona_Click);
            // 
            // btnEstados
            // 
            this.btnEstados.Location = new System.Drawing.Point(166, 80);
            this.btnEstados.Name = "btnEstados";
            this.btnEstados.Size = new System.Drawing.Size(75, 38);
            this.btnEstados.TabIndex = 1;
            this.btnEstados.Text = "Estados";
            this.btnEstados.UseVisualStyleBackColor = true;
            this.btnEstados.Click += new System.EventHandler(this.btnEstados_Click);
            // 
            // btnCurp
            // 
            this.btnCurp.Location = new System.Drawing.Point(330, 80);
            this.btnCurp.Name = "btnCurp";
            this.btnCurp.Size = new System.Drawing.Size(75, 38);
            this.btnCurp.TabIndex = 2;
            this.btnCurp.Text = "Curp";
            this.btnCurp.UseVisualStyleBackColor = true;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 261);
            this.Controls.Add(this.btnCurp);
            this.Controls.Add(this.btnEstados);
            this.Controls.Add(this.btnPersona);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersona;
        private System.Windows.Forms.Button btnEstados;
        private System.Windows.Forms.Button btnCurp;
    }
}