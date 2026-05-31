namespace SistemaGestionEmpleados.Formularios
{
    partial class frmConsultas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cONSULTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosPorDepartamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promedioDeSalariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salarioMenorAlPromedioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mejorPagadoPorDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteCompletoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cONSULTASToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(926, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(902, 445);
            this.dataGridView1.TabIndex = 1;
            // 
            // cONSULTASToolStripMenuItem
            // 
            this.cONSULTASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosPorDepartamentosToolStripMenuItem,
            this.promedioDeSalariosToolStripMenuItem,
            this.salarioMenorAlPromedioToolStripMenuItem,
            this.mejorPagadoPorDepartamentoToolStripMenuItem,
            this.reporteCompletoToolStripMenuItem});
            this.cONSULTASToolStripMenuItem.Name = "cONSULTASToolStripMenuItem";
            this.cONSULTASToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.cONSULTASToolStripMenuItem.Text = "CONSULTAS";
            // 
            // empleadosPorDepartamentosToolStripMenuItem
            // 
            this.empleadosPorDepartamentosToolStripMenuItem.Name = "empleadosPorDepartamentosToolStripMenuItem";
            this.empleadosPorDepartamentosToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.empleadosPorDepartamentosToolStripMenuItem.Text = "Empleados por Departamentos";
            this.empleadosPorDepartamentosToolStripMenuItem.Click += new System.EventHandler(this.empleadosPorDepartamentosToolStripMenuItem_Click);
            // 
            // promedioDeSalariosToolStripMenuItem
            // 
            this.promedioDeSalariosToolStripMenuItem.Name = "promedioDeSalariosToolStripMenuItem";
            this.promedioDeSalariosToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.promedioDeSalariosToolStripMenuItem.Text = "Promedio de Salarios";
            this.promedioDeSalariosToolStripMenuItem.Click += new System.EventHandler(this.promedioDeSalariosToolStripMenuItem_Click);
            // 
            // salarioMenorAlPromedioToolStripMenuItem
            // 
            this.salarioMenorAlPromedioToolStripMenuItem.Name = "salarioMenorAlPromedioToolStripMenuItem";
            this.salarioMenorAlPromedioToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.salarioMenorAlPromedioToolStripMenuItem.Text = "Salario Menor al promedio";
            this.salarioMenorAlPromedioToolStripMenuItem.Click += new System.EventHandler(this.salarioMenorAlPromedioToolStripMenuItem_Click);
            // 
            // mejorPagadoPorDepartamentoToolStripMenuItem
            // 
            this.mejorPagadoPorDepartamentoToolStripMenuItem.Name = "mejorPagadoPorDepartamentoToolStripMenuItem";
            this.mejorPagadoPorDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.mejorPagadoPorDepartamentoToolStripMenuItem.Text = "Mejor pagado por Departamento";
            this.mejorPagadoPorDepartamentoToolStripMenuItem.Click += new System.EventHandler(this.mejorPagadoPorDepartamentoToolStripMenuItem_Click);
            // 
            // reporteCompletoToolStripMenuItem
            // 
            this.reporteCompletoToolStripMenuItem.Name = "reporteCompletoToolStripMenuItem";
            this.reporteCompletoToolStripMenuItem.Size = new System.Drawing.Size(315, 26);
            this.reporteCompletoToolStripMenuItem.Text = "Reporte Completo";
            this.reporteCompletoToolStripMenuItem.Click += new System.EventHandler(this.reporteCompletoToolStripMenuItem_Click);
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 510);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmConsultas";
            this.Text = "frmConsultas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cONSULTASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosPorDepartamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promedioDeSalariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salarioMenorAlPromedioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mejorPagadoPorDepartamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteCompletoToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}