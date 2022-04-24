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
    public partial class FrmSeleccionarPruebasLab : Form
    {
        private ServicioPruebasLab _servicio;
        private ServicioResultadosLab servicio;
        private ServiciosCitas __servicio;
        public int? Id = null;
        int ID_Paciente, ID_Cita, ID_Doctor;
        public FrmSeleccionarPruebasLab( int Id_Cita, int Id_Paciente, int Id_Doctor)
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            ID_Paciente = Id_Paciente;
            ID_Cita = Id_Cita;
            ID_Doctor = Id_Doctor;
            SqlConnection connection = new SqlConnection(connectionString);

            _servicio = new ServicioPruebasLab(connection);
            servicio = new ServicioResultadosLab(connection);
            __servicio = new ServiciosCitas(connection);
        }

        private void BtnRealizarPrueb_Click(object sender, EventArgs e)
        {
            Consultar();
            EditarCita();
        }

        private void Consultar()
        {
            ResultadoPrueba results = new ResultadoPrueba();
            results.Id_Pacientes = ID_Paciente;
            results.Id_Cita = ID_Cita;
            results.Id_PruebaLab = Id.Value;
            results.Id_Medico = ID_Doctor;
            results.Estadoresult = Convert.ToString(1);
            bool result = servicio.Add(results);
            if (result)
            {
                MessageBox.Show("Los datos se han agregado con exito", "Notificacion");
            }
            else
            {
                MessageBox.Show("Oopss ha ocurrido un error en agregar los datos.", "Notificacion");
            }
            FrmMantenimientoCitas newForm = new FrmMantenimientoCitas();
            newForm.Show();
            this.Hide();
        }

        private void EditarCita()
        {
            Cita citas = new Cita();
            citas.Estado = Convert.ToString(2);
            citas.id = ID_Cita;
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
        private void LoadData()
        {
            DGVPruebasLab.DataSource = _servicio.GetAll();
            DGVPruebasLab.ClearSelection();
        }

        private void FrmSeleccionarPruebasLab_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DGVPruebasLab_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Id = Convert.ToInt32(DGVPruebasLab.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}
