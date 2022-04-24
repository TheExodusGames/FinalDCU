
namespace Gestor_de_Pacientes.FrmCitas
{
    partial class FrmSeleccionarMedico
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
            this.DGVMedicos = new System.Windows.Forms.DataGridView();
            this.BtnSiguientePaso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.24306F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.75694F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Controls.Add(this.DGVMedicos, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnSiguientePaso, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.85366F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.14634F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(596, 349);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DGVMedicos
            // 
            this.DGVMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMedicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVMedicos.Location = new System.Drawing.Point(58, 50);
            this.DGVMedicos.Name = "DGVMedicos";
            this.DGVMedicos.RowTemplate.Height = 25;
            this.DGVMedicos.Size = new System.Drawing.Size(480, 246);
            this.DGVMedicos.TabIndex = 0;
            this.DGVMedicos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVMedicos_CellClick);
            // 
            // BtnSiguientePaso
            // 
            this.BtnSiguientePaso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSiguientePaso.Location = new System.Drawing.Point(58, 302);
            this.BtnSiguientePaso.Name = "BtnSiguientePaso";
            this.BtnSiguientePaso.Size = new System.Drawing.Size(480, 44);
            this.BtnSiguientePaso.TabIndex = 1;
            this.BtnSiguientePaso.Text = "Siguiente Paso";
            this.BtnSiguientePaso.UseVisualStyleBackColor = true;
            this.BtnSiguientePaso.Visible = false;
            this.BtnSiguientePaso.Click += new System.EventHandler(this.BtnSiguientePaso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(58, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione un Medico:";
            // 
            // FrmSeleccionarMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 349);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmSeleccionarMedico";
            this.Text = "FrmSeleccionarMedico";
            this.Load += new System.EventHandler(this.FrmSeleccionarMedico_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMedicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DGVMedicos;
        private System.Windows.Forms.Button BtnSiguientePaso;
        private System.Windows.Forms.Label label1;
    }
}