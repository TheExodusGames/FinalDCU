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
    public partial class FrmAgregarCitas : Form
    {
        private readonly ServiciosCitas _servicio;
        public int _id;
        public int ID_Paciente;
        public int ID_Medico;
        public FrmAgregarCitas(int ID1, int ID2)
        {
            ID_Paciente = ID1;
            ID_Medico = ID2;
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);


            _servicio = new ServiciosCitas(connection);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            GuardarCita();
        }

        public void GuardarCita()
        {
            if (string.IsNullOrEmpty(txtPaciente.Text) || (string.IsNullOrEmpty(txtPaciente.Text)) || (string.IsNullOrEmpty(DTPCita.Text))  || (string.IsNullOrEmpty(txtRazonCita.Text)))
            {
                MessageBox.Show("Por favor, complete toda la informacion.", "Alerta!!!");
            }
            else
            {
                Cita citas = new Cita();
                citas.Id_Pacientes = ID_Paciente;
                citas.Id_Medico = ID_Medico;
                citas.FechayHora = DTPCita.Value;
                citas.Causa = txtRazonCita.Text;
                citas.Estado = Convert.ToString(1);
                bool result = _servicio.Add(citas);
                if (result)
                {
                    MessageBox.Show("Se ha agregado con exito", "Notificacion");
                }
                else
                {
                    MessageBox.Show("Oopss ha ocurrido un error", "Notificacion");
                }

            }
            FrmMantenimientoCitas newFrm = new FrmMantenimientoCitas();
            newFrm.Show();
            this.Hide();
        }

        public void EditarCita()
        {

        }

        private void FrmAgregarCitas_Load(object sender, EventArgs e)
        {

        }
    }
}
