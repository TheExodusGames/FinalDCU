
namespace Gestor_de_Pacientes.FrmCitas
{
    partial class FrmSeleccionarPacientes
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
            this.DGVSelecPaciente = new System.Windows.Forms.DataGridView();
            this.BtnSiguientePaso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSelecPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.958477F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.04152F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Controls.Add(this.DGVSelecPaciente, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BtnSiguientePaso, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.66666F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(599, 321);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DGVSelecPaciente
            // 
            this.DGVSelecPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSelecPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVSelecPaciente.Location = new System.Drawing.Point(47, 45);
            this.DGVSelecPaciente.Name = "DGVSelecPaciente";
            this.DGVSelecPaciente.RowTemplate.Height = 25;
            this.DGVSelecPaciente.Size = new System.Drawing.Size(510, 228);
            this.DGVSelecPaciente.TabIndex = 0;
            this.DGVSelecPaciente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVSelecPaciente_CellClick);
            // 
            // BtnSiguientePaso
            // 
            this.BtnSiguientePaso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSiguientePaso.Location = new System.Drawing.Point(47, 279);
            this.BtnSiguientePaso.Name = "BtnSiguientePaso";
            this.BtnSiguientePaso.Size = new System.Drawing.Size(510, 39);
            this.BtnSiguientePaso.TabIndex = 1;
            this.BtnSiguientePaso.Text = "Siguiente Paso";
            this.BtnSiguientePaso.UseVisualStyleBackColor = true;
            this.BtnSiguientePaso.Click += new System.EventHandler(this.BtnSiguientePaso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(47, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione un paciente:";
            // 
            // FrmSeleccionarPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 321);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmSeleccionarPacientes";
            this.Text = "FrmSeleccionarPacientes";
            this.Load += new System.EventHandler(this.FrmSeleccionarPacientes_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSelecPaciente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DGVSelecPaciente;
        private System.Windows.Forms.Button BtnSiguientePaso;
        private System.Windows.Forms.Label label1;
    }
}