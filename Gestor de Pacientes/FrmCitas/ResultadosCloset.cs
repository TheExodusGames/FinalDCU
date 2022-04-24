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


namespace Gestor_de_Pacientes.FrmCitas
{
    public partial class ResultadosCloset : Form
    {
        public int _id;
        int ID_Cita;
        private ServicioResultadosLab servicio;
        public ResultadosCloset(int Id_Cita)
        {
            _id = Id_Cita;

            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            servicio = new ServicioResultadosLab(connection);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResultadosCloset_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            GuardarResultado();
        }

        public void GuardarResultado()
        {
                ResultadoPrueba resultprueb = new ResultadoPrueba();

                resultprueb.Resultados = txtRazonCita.Text;
                resultprueb.id = _id;
                bool result = servicio.Edit(resultprueb);
                if (result)
                {
                    MessageBox.Show("Se ha editado el resultado de la cita", "Notificacion");
                }
                else
                {
                    MessageBox.Show("Oopss ha ocurrido un error en editar el resultado de la cita.", "Notificacion");

                }
                FrmMantenimientoCitas newFrm = new FrmMantenimientoCitas();
                newFrm.Show();
                this.Hide();
        }
    }
}
