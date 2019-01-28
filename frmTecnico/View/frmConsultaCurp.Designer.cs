namespace frmTecnico.View
{
    partial class frmConsultaCurp
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
            this.layoutPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvTablaPersonas = new System.Windows.Forms.DataGridView();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.pnlEtiqueta = new System.Windows.Forms.Panel();
            this.etConsultaCurp = new System.Windows.Forms.Label();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.etTituloCurp = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.layoutPrincipal.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaPersonas)).BeginInit();
            this.pnlBusqueda.SuspendLayout();
            this.pnlEtiqueta.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutPrincipal
            // 
            this.layoutPrincipal.ColumnCount = 1;
            this.layoutPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPrincipal.Controls.Add(this.pnlGrid, 0, 2);
            this.layoutPrincipal.Controls.Add(this.pnlBusqueda, 0, 1);
            this.layoutPrincipal.Controls.Add(this.pnlEtiqueta, 0, 3);
            this.layoutPrincipal.Controls.Add(this.pnlTitulo, 0, 0);
            this.layoutPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPrincipal.Location = new System.Drawing.Point(0, 0);
            this.layoutPrincipal.Name = "layoutPrincipal";
            this.layoutPrincipal.RowCount = 4;
            this.layoutPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.layoutPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.layoutPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 243F));
            this.layoutPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.layoutPrincipal.Size = new System.Drawing.Size(523, 366);
            this.layoutPrincipal.TabIndex = 0;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.dgvTablaPersonas);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(3, 78);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(517, 237);
            this.pnlGrid.TabIndex = 0;
            // 
            // dgvTablaPersonas
            // 
            this.dgvTablaPersonas.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTablaPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaPersonas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTablaPersonas.Location = new System.Drawing.Point(0, 0);
            this.dgvTablaPersonas.Name = "dgvTablaPersonas";
            this.dgvTablaPersonas.ReadOnly = true;
            this.dgvTablaPersonas.Size = new System.Drawing.Size(517, 237);
            this.dgvTablaPersonas.TabIndex = 0;
            this.dgvTablaPersonas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTablaPersonas_CellDoubleClick);
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.Controls.Add(this.btnNuevo);
            this.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBusqueda.Location = new System.Drawing.Point(3, 39);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(517, 33);
            this.pnlBusqueda.TabIndex = 1;
            // 
            // pnlEtiqueta
            // 
            this.pnlEtiqueta.Controls.Add(this.etConsultaCurp);
            this.pnlEtiqueta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEtiqueta.Location = new System.Drawing.Point(3, 321);
            this.pnlEtiqueta.Name = "pnlEtiqueta";
            this.pnlEtiqueta.Size = new System.Drawing.Size(517, 42);
            this.pnlEtiqueta.TabIndex = 2;
            // 
            // etConsultaCurp
            // 
            this.etConsultaCurp.AutoSize = true;
            this.etConsultaCurp.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etConsultaCurp.Location = new System.Drawing.Point(159, 15);
            this.etConsultaCurp.Name = "etConsultaCurp";
            this.etConsultaCurp.Size = new System.Drawing.Size(0, 21);
            this.etConsultaCurp.TabIndex = 0;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.etTituloCurp);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTitulo.Location = new System.Drawing.Point(3, 3);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(517, 30);
            this.pnlTitulo.TabIndex = 3;
            // 
            // etTituloCurp
            // 
            this.etTituloCurp.AutoSize = true;
            this.etTituloCurp.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etTituloCurp.Location = new System.Drawing.Point(12, 6);
            this.etTituloCurp.Name = "etTituloCurp";
            this.etTituloCurp.Size = new System.Drawing.Size(208, 21);
            this.etTituloCurp.TabIndex = 0;
            this.etTituloCurp.Text = "Consulta de CURP individual";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(437, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Agregar Persona";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmConsultaCurp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(523, 366);
            this.Controls.Add(this.layoutPrincipal);
            this.MaximizeBox = false;
            this.Name = "frmConsultaCurp";
            this.Text = "Consulta de CURP";
            this.layoutPrincipal.ResumeLayout(false);
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaPersonas)).EndInit();
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlEtiqueta.ResumeLayout(false);
            this.pnlEtiqueta.PerformLayout();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutPrincipal;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvTablaPersonas;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.Panel pnlEtiqueta;
        private System.Windows.Forms.Label etConsultaCurp;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label etTituloCurp;
        private System.Windows.Forms.Button btnNuevo;
    }
}