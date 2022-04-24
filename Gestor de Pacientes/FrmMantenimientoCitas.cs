using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using Database;
using System.Data.SqlClient;
using Database.Modelos;
using System.Configuration;
using Gestor_de_Pacientes.FrmCitas;

namespace Gestor_de_Pacientes
{
    public partial class FrmMantenimientoCitas : Form
    {
        private ServiciosCitas _servicio;
        public int? Id = null;
        public int ID;
        public int ID_Paciente, ID_Doctor;
        public FrmMantenimientoCitas()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _servicio = new ServiciosCitas(connection);
        }

        private void BtnNueva_Click(object sender, EventArgs e)
        {
            FrmSeleccionarPacientes newForm = new FrmSeleccionarPacientes();
            newForm.Show();
        }
        private void LoadData()
        {
            DGVCitas.DataSource = _servicio.GetAll();
            DGVCitas.ClearSelection();
        }

        private void FrmMantenimientoCitas_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void EvaluarEstado()
        {
            int estado = _servicio.EstadodeCita(Id.Value);
            if(estado == 1)
            {
                BtnConsultar.Visible = true;
            }  
            else if (estado == 2)
            {
                BtnConsultarResultados.Visible = true;
            }
            else
            {
                BtnResultados.Visible = true;
            }
        }

        private void DGVCitas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Id = Convert.ToInt32(DGVCitas.Rows[e.RowIndex].Cells[0].Value.ToString());
                EvaluarEstado();
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione una Cita Valida");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
        }

        private void BtnConsultarResultados_Click(object sender, EventArgs e)
        {
            FrmMantenimientoResultLabs newForm = new FrmMantenimientoResultLabs(Id.Value);
            newForm.Show();
            this.Close();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void BtnResultados_Click(object sender, EventArgs e)
        {
            Cita citas = new Cita();

            citas = _servicio.GetById(Id.Value);

            FrmCitas.ResultadosCloset newForm = new FrmCitas.ResultadosCloset(Convert.ToInt32(Id));
            newForm.Show();
            this.Close();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            Cita citas = new Cita();

            citas = _servicio.GetById(Id.Value);
            ID_Paciente = Convert.ToInt32(citas.Id_Pacientes);
            ID_Doctor = Convert.ToInt32(citas.Id_Medico);

            FrmSeleccionarPruebasLab newForm = new FrmSeleccionarPruebasLab(Convert.ToInt32(Id), ID_Paciente, ID_Doctor);
            newForm.Show();
            this.Close();
        }
    }
}
