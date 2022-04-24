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
using System.IO;
using System.Data.SqlClient;
using Database.Modelos;
using System.Configuration;

namespace Gestor_de_Pacientes
{
    public partial class FrmMantenimientoResultLabs : Form
    {
        private ServicioResultadosLab servicio;
        private ServiciosCitas __servicio;
        int Parametro;
        public FrmMantenimientoResultLabs(int ID_Cita)
        {

            Parametro = ID_Cita;
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            servicio = new ServicioResultadosLab(connection);
            __servicio = new ServiciosCitas(connection);
        }

        private void DGVResultLab_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmMantenimientoResultLabs_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            DGVResultLab.DataSource = servicio.GetAll();
            DGVResultLab.ClearSelection();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnCompletar_Click(object sender, EventArgs e)
        {
            EditarCita();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            FrmMantenimientoCitas newForm = new FrmMantenimientoCitas();
            newForm.Show();
            this.Close();
        }

        private void EditarCita()
        {
            Cita citas = new Cita();
            citas.Estado = Convert.ToString(3);
            citas.id = Parametro;
            bool result = __servicio.Edit(citas);
            if (result)
            {
                MessageBox.Show("Se ha editado el estado de la cita", "Notificacion");
            }
            else
            {
                MessageBox.Show("Oopss ha ocurrido un error en editar el estado de la cita.", "Notificacion");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
