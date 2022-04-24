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
    public partial class FrmMantenimientoUsuarios : Form
    {
            private ServiciosLogin _servicio;
            private ServicioTipoUsers _TipoUsuario;
        public int? Id = null;
        public FrmMantenimientoUsuarios()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _servicio = new ServiciosLogin(connection);
            _TipoUsuario = new ServicioTipoUsers(connection);
        }

        private void FrmMantenimientoUsuarios_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DGVUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmAgregarUsuario newForm = new FrmAgregarUsuario(Id);
            Id = Convert.ToInt32(DGVUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString());
            newForm.Id = Convert.ToInt32(DGVUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void Editar()
        {
            FrmAgregarUsuario newForm = new FrmAgregarUsuario(Id);

            Login users = new Login();

            users = _servicio.GetById(Id.Value);

            newForm.TxtNombre.Text = users.Nombre;
            newForm.TxtApellido.Text = users.Apellido;
            newForm.TxtCorreo.Text = users.Correo;
            newForm.TxtClave.Text = users.Clave;
            newForm.TxtUser.Text = users.User;
            if (string.IsNullOrEmpty(users.TipoUsuario))
            {
                newForm.CbxTipoUsuario.SelectedIndex = 0;
            }
            else
            {
                newForm.CbxTipoUsuario.SelectedIndex = newForm.CbxTipoUsuario.FindStringExact(users.TipoUsuario);
            }
            newForm.Show();
            this.Hide();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuario newForm = new FrmAgregarUsuario(Id);
            newForm.Show();
            this.Hide();
        }

        private void LoadData()
        {
            DGVUsuarios.DataSource = _servicio.GetAll();
            DGVUsuarios.ClearSelection();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DeleteUsuario();
        }
        private void DeleteUsuario()
        {
            if (Id == null)
            {
                MessageBox.Show("Debes seleccionar un contacto", "Notificacion");
            }
            else
            {
                DialogResult response = MessageBox.Show("Esta seguro que desea eliminar este Usuario",
                    "Advertencia", MessageBoxButtons.OKCancel);

                if (response == DialogResult.OK)
                {
                    bool result = _servicio.Delete(Id.Value);

                    if (result)
                    {
                        MessageBox.Show("Se ha eliminado con exito", "Notificacion");
                    }
                    else
                    {
                        MessageBox.Show("Oopss ha ocurrido un error", "Notificacion");
                    }
                    LoadData();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
