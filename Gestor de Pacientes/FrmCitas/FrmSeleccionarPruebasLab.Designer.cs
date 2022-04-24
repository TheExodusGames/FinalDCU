
namespace Gestor_de_Pacientes.FrmCitas
{
    partial class FrmSeleccionarPruebasLab
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
            this.DGVPruebasLab = new System.Windows.Forms.DataGridView();
            this.BtnRealizarPrueb = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPruebasLab)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.97917F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.02084F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.Controls.Add(this.DGVPruebasLab, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BtnRealizarPrueb, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.66077F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.33923F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(596, 339);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DGVPruebasLab
            // 
            this.DGVPruebasLab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVPruebasLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVPruebasLab.Location = new System.Drawing.Point(67, 3);
            this.DGVPruebasLab.Name = "DGVPruebasLab";
            this.DGVPruebasLab.RowTemplate.Height = 25;
            this.DGVPruebasLab.Size = new System.Drawing.Size(467, 281);
            this.DGVPruebasLab.TabIndex = 0;
            this.DGVPruebasLab.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVPruebasLab_CellClick);
            // 
            // BtnRealizarPrueb
            // 
            this.BtnRealizarPrueb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnRealizarPrueb.Location = new System.Drawing.Point(67, 290);
            this.BtnRealizarPrueb.Name = "BtnRealizarPrueb";
            this.BtnRealizarPrueb.Size = new System.Drawing.Size(467, 46);
            this.BtnRealizarPrueb.TabIndex = 1;
            this.BtnRealizarPrueb.Text = "Realizar Pruebas";
            this.BtnRealizarPrueb.UseVisualStyleBackColor = true;
            this.BtnRealizarPrueb.Click += new System.EventHandler(this.BtnRealizarPrueb_Click);
            // 
            // FrmSeleccionarPruebasLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 339);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmSeleccionarPruebasLab";
            this.Text = "FrmSeleccionarPruebasLab";
            this.Load += new System.EventHandler(this.FrmSeleccionarPruebasLab_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPruebasLab)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView DGVPruebasLab;
        private System.Windows.Forms.Button BtnRealizarPrueb;
    }
}