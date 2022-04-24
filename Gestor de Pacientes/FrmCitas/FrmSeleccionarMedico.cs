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
    public partial class FrmSeleccionarMedico : Form
    {
        private ServicioMedicos _servicio;
        public int? Id = null;
        public int ID;
        public string Pacientess;
        public int ID1;
        public int ID2;
        public FrmSeleccionarMedico(string Pacientes, int ID)
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            Pacientess = Pacientes;
            ID1 = ID;
            SqlConnection connection = new SqlConnection(connectionString);

            _servicio = new ServicioMedicos(connection);
        }

        private void DGVMedicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(DGVMedicos.Rows[e.RowIndex].Cells[0].Value.ToString());
            BtnSiguientePaso.Visible = true;
        }

        private void BtnSiguientePaso_Click(object sender, EventArgs e)
        {
            FrmAgregarCitas newForm2 = new FrmAgregarCitas(ID1, Convert.ToInt32(Id));

            Medico medic = new Medico();

            medic = _servicio.GetById(Id.Value);
            newForm2.txtMedico.Text = medic.Nombre;
            newForm2.txtPaciente.Text = Pacientess;
            newForm2.Show();
            this.Hide();
        }

        private void FrmSeleccionarMedico_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            DGVMedicos.DataSource = _servicio.GetAll();
            DGVMedicos.ClearSelection();
        }
    }
}
