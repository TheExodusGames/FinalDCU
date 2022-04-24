using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Gestor_de_Pacientes
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void mantenimientoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantenimientoUsuarios newForm = new FrmMantenimientoUsuarios();
            newForm.Show();
            this.Hide();
        }

        private void mantenimientoDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantenimientoMedicos newForm = new FrmMantenimientoMedicos();
            newForm.Show();
            this.Hide();
        }

        private void pruebasDeLaboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantenimientoPruebasLab newForm = new FrmMantenimientoPruebasLab();
            newForm.Show();
            this.Hide();
        }

        private void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantenimientoPacientes newForm = new FrmMantenimientoPacientes();
            newForm.Show();
            this.Hide();
        }

        private void citasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMantenimientoCitas newForm = new FrmMantenimientoCitas();
            newForm.Show();
            this.Hide();
        }

        private void resultadosPruebasLaboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ResultadosDeLasPruebas newForm = new ResultadosDeLasPruebas();
            newForm.Show();
            this.Hide();
           
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin newForm = new FrmLogin();
            newForm.Show();
            this.Hide();
        }
    }
}
