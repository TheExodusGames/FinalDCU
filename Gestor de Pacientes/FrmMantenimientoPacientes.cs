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
    public partial class FrmMantenimientoPacientes : Form
    {
        private ServicioPacientes _servicio;
        public int? Id = null;
        public int ID;
        public FrmMantenimientoPacientes()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _servicio = new ServicioPacientes(connection);
        }

        private void BtnNuevoPaciente_Click(object sender, EventArgs e)
        {
            FrmAgregarPaciente newForm = new FrmAgregarPaciente(ID = Convert.ToInt32(Id));
            newForm.Show();
            this.Hide();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            FrmAgregarPaciente newForm = new FrmAgregarPaciente(ID = Convert.ToInt32(Id));

            Paciente pacient = new Paciente();

            pacient = _servicio.GetById(Id.Value);

            newForm.txtName.Text = pacient.Nombre;
            newForm.txtApellido.Text = pacient.Apellido;
            newForm.txtTel.Text = pacient.Telefono;
            newForm.txtDireccion.Text = pacient.Direccion;
            newForm.txtCedula.Text = pacient.Cedula;
            newForm.DTPPacientes.Value = pacient.FechaNacimiento;
            if(pacient.Fumador == true)
            {
                newForm.CBFumador.Checked = true;
            }
            else
            {
                newForm.CBFumador.Checked = false;
            }
            newForm.txtAlergias.Text = pacient.Alergias;
            newForm.PBPacientes.ImageLocation = pacient.Foto;
            newForm.Show();
            this.Hide();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("Debe seleccionar un paciente", "Notificacion");
            }
            else
            {

                DialogResult respuesta = MessageBox.Show("Esta seguro que desea eliminar este paciente?", "Advertencia",
                    MessageBoxButtons.OKCancel);

                if (respuesta == DialogResult.OK)
                {
                    bool result = _servicio.Delete(ID);

                    if (result)
                    {
                        MessageBox.Show("Se ha eliminado con exito", "Notificacion");
                    }
                    else
                    {
                        MessageBox.Show("Ha sucedido un error", "Error");
                    }

                    LoadData();
                    Deselect();
                }

            }
        }
        private void Deselect()
        {
            DGVPacientes.ClearSelection();
            Id = 0;
            BtnDeseleccionar.Visible = false;
        }

        private void BtnDeseleccionar_Click(object sender, EventArgs e)
        {

        }

        private void FrmMantenimientoPacientes_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void LoadData()
        {
            DGVPacientes.DataSource = _servicio.GetAll();
            DGVPacientes.ClearSelection();
        }

        private void DGVPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmAgregarPaciente newForm = new FrmAgregarPaciente(ID = Convert.ToInt32(Id));
            Id = Convert.ToInt32(DGVPacientes.Rows[e.RowIndex].Cells[0].Value.ToString());
            newForm._id = Convert.ToInt32(DGVPacientes.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
    }
}
