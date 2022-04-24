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

namespace Gestor_de_Pacientes.FrmCitas
{
    public partial class FrmSeleccionarPacientes : Form
    {
        private ServicioPacientes _servicio;
        public int? Id = null;
        public int ID;
        public string Paciente;
        public FrmSeleccionarPacientes()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _servicio = new ServicioPacientes(connection);
        }

        private void FrmSeleccionarPacientes_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnSiguientePaso_Click(object sender, EventArgs e)
        {

            Paciente pacient = new Paciente();

            pacient = _servicio.GetById(Id.Value);
            Paciente = pacient.Nombre;
            FrmSeleccionarMedico newForm = new FrmSeleccionarMedico(Paciente, Convert.ToInt32(Id));
            newForm.Show();
            this.Hide();
        }

        private void DGVSelecPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(DGVSelecPaciente.Rows[e.RowIndex].Cells[0].Value.ToString());
            BtnSiguientePaso.Visible = true;
        }

        private void LoadData()
        {
            DGVSelecPaciente.DataSource = _servicio.GetAll();
            DGVSelecPaciente.ClearSelection();
        }

    }
}
