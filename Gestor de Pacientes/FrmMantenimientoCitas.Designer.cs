
namespace Gestor_de_Pacientes
{
    partial class FrmMantenimientoCitas
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
            this.atrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DGVCitas = new System.Windows.Forms.DataGridView();
            this.BtnDeselect = new System.Windows.Forms.Button();
            this.BtnNueva = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnConsultarResultados = new System.Windows.Forms.Button();
            this.BtnResultados = new System.Windows.Forms.Button();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.btnprueba = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCitas)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atrasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(785, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // atrasToolStripMenuItem
            // 
            this.atrasToolStripMenuItem.Name = "atrasToolStripMenuItem";
            this.atrasToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.atrasToolStripMenuItem.Text = "Atras";
            this.atrasToolStripMenuItem.Click += new System.EventHandler(this.atrasToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.733766F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.26624F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel1.Controls.Add(this.btnprueba, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.DGVCitas, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnDeselect, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnNueva, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(785, 471);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // DGVCitas
            // 
            this.DGVCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCitas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCitas.Location = new System.Drawing.Point(27, 56);
            this.DGVCitas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGVCitas.Name = "DGVCitas";
            this.DGVCitas.RowHeadersWidth = 51;
            this.DGVCitas.RowTemplate.Height = 25;
            this.DGVCitas.Size = new System.Drawing.Size(633, 358);
            this.DGVCitas.TabIndex = 0;
            this.DGVCitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCitas_CellClick);
            // 
            // BtnDeselect
            // 
            this.BtnDeselect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDeselect.Location = new System.Drawing.Point(666, 56);
            this.BtnDeselect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnDeselect.Name = "BtnDeselect";
            this.BtnDeselect.Size = new System.Drawing.Size(116, 358);
            this.BtnDeselect.TabIndex = 1;
            this.BtnDeselect.Text = "Deseleccionar";
            this.BtnDeselect.UseVisualStyleBackColor = true;
            // 
            // BtnNueva
            // 
            this.BtnNueva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnNueva.Location = new System.Drawing.Point(27, 4);
            this.BtnNueva.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnNueva.Name = "BtnNueva";
            this.BtnNueva.Size = new System.Drawing.Size(633, 44);
            this.BtnNueva.TabIndex = 2;
            this.BtnNueva.Text = "Nueva Cita";
            this.BtnNueva.UseVisualStyleBackColor = true;
            this.BtnNueva.Click += new System.EventHandler(this.BtnNueva_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.7594F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.2406F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 153F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel2.Controls.Add(this.BtnDelete, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnConsultarResultados, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnResultados, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnConsultar, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(27, 422);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(633, 45);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnDelete.Location = new System.Drawing.Point(3, 4);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(167, 37);
            this.BtnDelete.TabIndex = 0;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnConsultarResultados
            // 
            this.BtnConsultarResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnConsultarResultados.Location = new System.Drawing.Point(324, 4);
            this.BtnConsultarResultados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnConsultarResultados.Name = "BtnConsultarResultados";
            this.BtnConsultarResultados.Size = new System.Drawing.Size(147, 37);
            this.BtnConsultarResultados.TabIndex = 1;
            this.BtnConsultarResultados.Text = "Consultar Resultados";
            this.BtnConsultarResultados.UseVisualStyleBackColor = true;
            this.BtnConsultarResultados.Visible = false;
            this.BtnConsultarResultados.Click += new System.EventHandler(this.BtnConsultarResultados_Click);
            // 
            // BtnResultados
            // 
            this.BtnResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnResultados.Location = new System.Drawing.Point(477, 4);
            this.BtnResultados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnResultados.Name = "BtnResultados";
            this.BtnResultados.Size = new System.Drawing.Size(153, 37);
            this.BtnResultados.TabIndex = 2;
            this.BtnResultados.Text = "Resultados";
            this.BtnResultados.UseVisualStyleBackColor = true;
            this.BtnResultados.Visible = false;
            this.BtnResultados.Click += new System.EventHandler(this.BtnResultados_Click);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnConsultar.Location = new System.Drawing.Point(176, 4);
            this.BtnConsultar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(142, 37);
            this.BtnConsultar.TabIndex = 3;
            this.BtnConsultar.Text = "Consultar";
            this.BtnConsultar.UseVisualStyleBackColor = true;
            this.BtnConsultar.Visible = false;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // btnprueba
            // 
            this.btnprueba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnprueba.Location = new System.Drawing.Point(3, 422);
            this.btnprueba.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnprueba.Name = "btnprueba";
            this.btnprueba.Size = new System.Drawing.Size(18, 45);
            this.btnprueba.TabIndex = 4;
            this.btnprueba.Text = "Resultados";
            this.btnprueba.UseVisualStyleBackColor = true;
            this.btnprueba.Visible = false;
            // 
            // FrmMantenimientoCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 501);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMantenimientoCitas";
            this.Text = "FrmMantenimientoCitas";
            this.Load += new System.EventHandler(this.FrmMantenimientoCitas_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCitas)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem atrasToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DGVCitas;
        private System.Windows.Forms.Button BtnDeselect;
        private System.Windows.Forms.Button BtnNueva;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnConsultarResultados;
        private System.Windows.Forms.Button BtnResultados;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.Button btnprueba;
    }
}