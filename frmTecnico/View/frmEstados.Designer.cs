namespace frmTecnico.View
{
    partial class frmEstados
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
            this.ContEstados = new System.Windows.Forms.SplitContainer();
            this.gboxNEstado = new System.Windows.Forms.GroupBox();
            this.etNEstado = new System.Windows.Forms.Label();
            this.txtNEstado = new System.Windows.Forms.TextBox();
            this.gboxListaEstados = new System.Windows.Forms.GroupBox();
            this.dgvEstados = new System.Windows.Forms.DataGridView();
            this.pnlBotonEstados = new System.Windows.Forms.Panel();
            this.btnGuardarEstado = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContEstados)).BeginInit();
            this.ContEstados.Panel1.SuspendLayout();
            this.ContEstados.Panel2.SuspendLayout();
            this.ContEstados.SuspendLayout();
            this.gboxNEstado.SuspendLayout();
            this.gboxListaEstados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstados)).BeginInit();
            this.pnlBotonEstados.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ContEstados, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnlBotonEstados, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.60606F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.39394F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(487, 330);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ContEstados
            // 
            this.ContEstados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContEstados.Location = new System.Drawing.Point(3, 57);
            this.ContEstados.Name = "ContEstados";
            // 
            // ContEstados.Panel1
            // 
            this.ContEstados.Panel1.Controls.Add(this.gboxNEstado);
            // 
            // ContEstados.Panel2
            // 
            this.ContEstados.Panel2.Controls.Add(this.gboxListaEstados);
            this.ContEstados.Size = new System.Drawing.Size(481, 203);
            this.ContEstados.SplitterDistance = 160;
            this.ContEstados.TabIndex = 0;
            // 
            // gboxNEstado
            // 
            this.gboxNEstado.Controls.Add(this.txtNEstado);
            this.gboxNEstado.Controls.Add(this.etNEstado);
            this.gboxNEstado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxNEstado.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxNEstado.Location = new System.Drawing.Point(0, 0);
            this.gboxNEstado.Name = "gboxNEstado";
            this.gboxNEstado.Size = new System.Drawing.Size(160, 203);
            this.gboxNEstado.TabIndex = 0;
            this.gboxNEstado.TabStop = false;
            this.gboxNEstado.Text = "Nuevo Estado";
            // 
            // etNEstado
            // 
            this.etNEstado.AutoSize = true;
            this.etNEstado.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etNEstado.Location = new System.Drawing.Point(9, 27);
            this.etNEstado.Name = "etNEstado";
            this.etNEstado.Size = new System.Drawing.Size(48, 16);
            this.etNEstado.TabIndex = 0;
            this.etNEstado.Text = "Estado";
            // 
            // txtNEstado
            // 
            this.txtNEstado.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNEstado.Location = new System.Drawing.Point(26, 46);
            this.txtNEstado.Name = "txtNEstado";
            this.txtNEstado.Size = new System.Drawing.Size(100, 24);
            this.txtNEstado.TabIndex = 1;
            // 
            // gboxListaEstados
            // 
            this.gboxListaEstados.Controls.Add(this.dgvEstados);
            this.gboxListaEstados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gboxListaEstados.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxListaEstados.Location = new System.Drawing.Point(0, 0);
            this.gboxListaEstados.Name = "gboxListaEstados";
            this.gboxListaEstados.Size = new System.Drawing.Size(317, 203);
            this.gboxListaEstados.TabIndex = 0;
            this.gboxListaEstados.TabStop = false;
            this.gboxListaEstados.Text = "Lista de Estados";
            // 
            // dgvEstados
            // 
            this.dgvEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEstados.Location = new System.Drawing.Point(3, 24);
            this.dgvEstados.Name = "dgvEstados";
            this.dgvEstados.Size = new System.Drawing.Size(311, 176);
            this.dgvEstados.TabIndex = 0;
            // 
            // pnlBotonEstados
            // 
            this.pnlBotonEstados.Controls.Add(this.btnGuardarEstado);
            this.pnlBotonEstados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotonEstados.Location = new System.Drawing.Point(3, 266);
            this.pnlBotonEstados.Name = "pnlBotonEstados";
            this.pnlBotonEstados.Size = new System.Drawing.Size(481, 61);
            this.pnlBotonEstados.TabIndex = 1;
            // 
            // btnGuardarEstado
            // 
            this.btnGuardarEstado.Location = new System.Drawing.Point(197, 10);
            this.btnGuardarEstado.Name = "btnGuardarEstado";
            this.btnGuardarEstado.Size = new System.Drawing.Size(75, 42);
            this.btnGuardarEstado.TabIndex = 0;
            this.btnGuardarEstado.Text = "Guardar Estado";
            this.btnGuardarEstado.UseVisualStyleBackColor = true;
            this.btnGuardarEstado.Click += new System.EventHandler(this.btnGuardarEstado_Click);
            // 
            // frmEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 330);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmEstados";
            this.Text = "Registro de Estados";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ContEstados.Panel1.ResumeLayout(false);
            this.ContEstados.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContEstados)).EndInit();
            this.ContEstados.ResumeLayout(false);
            this.gboxNEstado.ResumeLayout(false);
            this.gboxNEstado.PerformLayout();
            this.gboxListaEstados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstados)).EndInit();
            this.pnlBotonEstados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer ContEstados;
        private System.Windows.Forms.GroupBox gboxNEstado;
        private System.Windows.Forms.TextBox txtNEstado;
        private System.Windows.Forms.Label etNEstado;
        private System.Windows.Forms.GroupBox gboxListaEstados;
        private System.Windows.Forms.DataGridView dgvEstados;
        private System.Windows.Forms.Panel pnlBotonEstados;
        private System.Windows.Forms.Button btnGuardarEstado;
    }
}