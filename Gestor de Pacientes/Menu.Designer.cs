
namespace Gestor_de_Pacientes
{
    partial class Menu
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
            this.mantenimientoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeMedicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pruebasDeLaboratorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadosPruebasLaboratorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoUsuarioToolStripMenuItem,
            this.mantenimientoDeToolStripMenuItem,
            this.pruebasDeLaboratorioToolStripMenuItem,
            this.pacientesToolStripMenuItem,
            this.citasToolStripMenuItem,
            this.resultadosPruebasLaboratorioToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(314, 450);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoUsuarioToolStripMenuItem
            // 
            this.mantenimientoUsuarioToolStripMenuItem.Name = "mantenimientoUsuarioToolStripMenuItem";
            this.mantenimientoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(301, 29);
            this.mantenimientoUsuarioToolStripMenuItem.Text = "Mantenimiento Usuario";
            this.mantenimientoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoUsuarioToolStripMenuItem_Click);
            // 
            // mantenimientoDeToolStripMenuItem
            // 
            this.mantenimientoDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoDeMedicosToolStripMenuItem});
            this.mantenimientoDeToolStripMenuItem.Name = "mantenimientoDeToolStripMenuItem";
            this.mantenimientoDeToolStripMenuItem.Size = new System.Drawing.Size(301, 29);
            this.mantenimientoDeToolStripMenuItem.Text = "Mantenimiento de Medicos";
            this.mantenimientoDeToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeToolStripMenuItem_Click);
            // 
            // mantenimientoDeMedicosToolStripMenuItem
            // 
            this.mantenimientoDeMedicosToolStripMenuItem.Name = "mantenimientoDeMedicosToolStripMenuItem";
            this.mantenimientoDeMedicosToolStripMenuItem.Size = new System.Drawing.Size(327, 30);
            this.mantenimientoDeMedicosToolStripMenuItem.Text = "Mantenimiento de Medicos";
            // 
            // pruebasDeLaboratorioToolStripMenuItem
            // 
            this.pruebasDeLaboratorioToolStripMenuItem.Name = "pruebasDeLaboratorioToolStripMenuItem";
            this.pruebasDeLaboratorioToolStripMenuItem.Size = new System.Drawing.Size(301, 29);
            this.pruebasDeLaboratorioToolStripMenuItem.Text = "Pruebas de Laboratorio";
            this.pruebasDeLaboratorioToolStripMenuItem.Click += new System.EventHandler(this.pruebasDeLaboratorioToolStripMenuItem_Click);
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(301, 29);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            this.pacientesToolStripMenuItem.Click += new System.EventHandler(this.pacientesToolStripMenuItem_Click);
            // 
            // citasToolStripMenuItem
            // 
            this.citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            this.citasToolStripMenuItem.Size = new System.Drawing.Size(301, 29);
            this.citasToolStripMenuItem.Text = "Citas";
            this.citasToolStripMenuItem.Click += new System.EventHandler(this.citasToolStripMenuItem_Click);
            // 
            // resultadosPruebasLaboratorioToolStripMenuItem
            // 
            this.resultadosPruebasLaboratorioToolStripMenuItem.Name = "resultadosPruebasLaboratorioToolStripMenuItem";
            this.resultadosPruebasLaboratorioToolStripMenuItem.Size = new System.Drawing.Size(301, 29);
            this.resultadosPruebasLaboratorioToolStripMenuItem.Text = "Resultados Pruebas Laboratorio";
            this.resultadosPruebasLaboratorioToolStripMenuItem.Click += new System.EventHandler(this.resultadosPruebasLaboratorioToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(301, 29);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeMedicosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mantenimientoUsuarioToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem mantenimientoDeToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem pruebasDeLaboratorioToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem resultadosPruebasLaboratorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
    }
}