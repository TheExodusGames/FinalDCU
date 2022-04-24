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
    public partial class FrmMantenimientoMedicos : Form
    {
        private ServicioMedicos _servicio;
        public int? Id = null;
        public int ID;
        public FrmMantenimientoMedicos()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _servicio = new ServicioMedicos(connection);
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarMedico newForm = new FrmAgregarMedico(ID = Convert.ToInt32(Id));
            newForm.Show();
            this.Hide();
        }

        private void DGVMedicos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmAgregarMedico newForm = new FrmAgregarMedico(ID = Convert.ToInt32(Id));
            Id = Convert.ToInt32(DGVMedicos.Rows[e.RowIndex].Cells[0].Value.ToString());
            newForm._id = Convert.ToInt32(DGVMedicos.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void Editar()
        {
            FrmAgregarMedico newForm = new FrmAgregarMedico(ID = Convert.ToInt32(Id));

            Medico medic = new Medico();

            medic = _servicio.GetById(Id.Value);

            newForm.txtName.Text = medic.Nombre;
            newForm.txtApellido.Text = medic.Apellido;
            newForm.txtCorreo.Text = medic.Correo;
            newForm.txtTelefono.Text = medic.Telefono;
            newForm.txtCedula.Text = medic.Cedula;
            newForm.PBPerfil.ImageLocation = medic.Foto;
            newForm.Show();
            this.Hide();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                MessageBox.Show("Debe seleccionar un medico", "Notificacion");
            }
            else
            {

                DialogResult respuesta = MessageBox.Show("Esta seguro que desea eliminar este medico?", "Advertencia",
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
                    //Deselect();
                }

            }

        }
        /*
        private void Deselect()
        {
            DGVMedicos.ClearSelection();
            _id = 0;
            Btnd.Visible = false;
            ClearData();
        }
        */
        private void FrmMantenimientoMedicos_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            DGVMedicos.DataSource = _servicio.GetAll();
            DGVMedicos.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
