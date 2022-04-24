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

namespace Gestor_de_Pacientes
{
    public partial class ResultadosDeLasPruebas : Form
    {
        private ServicioResultadosLab _servicio;
        public int? Id = null;
        public ResultadosDeLasPruebas()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _servicio = new ServicioResultadosLab(connection);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ResultadosDeLasPruebas_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DGVResult.DataSource = _servicio.GetAll();
        }
        private void DGVResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
