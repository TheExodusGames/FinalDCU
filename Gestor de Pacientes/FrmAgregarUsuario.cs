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
using Gestor_de_Pacientes.CustomControlItem;

namespace Gestor_de_Pacientes
{
    public partial class FrmAgregarUsuario : Form
    {
        private ServiciosLogin _servicio;
        private ServicioTipoUsers _TipoUsuario;
        public int? Id = null;
        public FrmAgregarUsuario(int? ID)
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            Id = ID;
            SqlConnection connection = new SqlConnection(connectionString);

            _servicio = new ServiciosLogin(connection);
            _TipoUsuario = new ServicioTipoUsers(connection);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            AddUsuarios();

        }

        private void FrmRegistrarUsuarios_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {

        }

        private void DGVUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #region Funciones
        private void AddUsuarios()
        {
            ComboBoxItem TipoUser = CbxTipoUsuario.SelectedItem as ComboBoxItem;
            if (string.IsNullOrEmpty(TxtNombre.Text))
            {
                MessageBox.Show("Escriba un Nombre", "Alerta!!!");
            }
            else if (string.IsNullOrEmpty(TxtApellido.Text))
            {
                MessageBox.Show("Escriba un Apellido", "Alerta!!!");
            }
            else if (string.IsNullOrEmpty(TxtCorreo.Text))
            {
                MessageBox.Show("Escriba un Correo", "Alerta!!!");
            }
            else if (string.IsNullOrEmpty(TxtClave.Text))
            {
                MessageBox.Show("Escriba una Clave", "Alerta!!!");
            }
            else if (string.IsNullOrEmpty(TxtConfClave.Text))
            {
                MessageBox.Show("Confirme la Clave", "Alerta!!!");
            }
            else if (TxtClave.Text != TxtConfClave.Text)
            {
                MessageBox.Show("Las claves deben ser iguales", "Alerta!!!");
            }
            else if (string.IsNullOrEmpty(TxtUser.Text))
            {
                MessageBox.Show("Escriba un Usuario", "Alerta!!!");
            }
            else
            {
                Login users = new Login();
                users.Nombre = TxtNombre.Text;
                users.Apellido = TxtApellido.Text;
                users.Correo = TxtCorreo.Text;
                users.Clave = TxtConfClave.Text;
                users.User = TxtUser.Text;
                users.TipoUsuario = Convert.ToString(TipoUser.Value);
                bool result = _servicio.Add(users);
                if (result)
                {
                    MessageBox.Show("Se ha agregado con exito", "Notificacion");
                }
                else
                {
                    MessageBox.Show("Oopss ha ocurrido un error", "Notificacion");
                }

            }
            FrmMantenimientoUsuarios newForm = new FrmMantenimientoUsuarios();
            newForm.Show();
            this.Hide();

        }


        #endregion


        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {
            if (Id == null)
            {
                AddUsuarios();
            }
            else
            {
                EditUsuarios();
            }
        }

        private void LoadComboBox()
        {
            ComboBoxItem opcionPorDefecto = new ComboBoxItem
            {
                Text = "Selecciona una opcion",
                Value = null
            };

            CbxTipoUsuario.Items.Add(opcionPorDefecto);

            List<TipoUsuario> listType = _TipoUsuario.GetList();

            foreach (TipoUsuario item in listType)
            {
                ComboBoxItem comboItem = new ComboBoxItem
                {
                    Text = item.Name,
                    Value = item.Id
                };
                CbxTipoUsuario.Items.Add(comboItem);

            }

            CbxTipoUsuario.SelectedItem = opcionPorDefecto;
        }

        private void EditUsuarios()
        {
            ComboBoxItem TipoUser = CbxTipoUsuario.SelectedItem as ComboBoxItem;
            if (string.IsNullOrEmpty(TxtNombre.Text))
            {
                MessageBox.Show("Escriba un Nombre", "Alerta!!!");
            }
            else if (string.IsNullOrEmpty(TxtCorreo.Text))
            {
                MessageBox.Show("Escriba un Apellido", "Alerta!!!");
            }
            else if (string.IsNullOrEmpty(TxtUser.Text))
            {
                MessageBox.Show("Escriba un Correo", "Alerta!!!");
            }
            else if (string.IsNullOrEmpty(TxtConfClave.Text))
            {
                MessageBox.Show("Escriba una Clave", "Alerta!!!");
            }
            else if (string.IsNullOrEmpty(TxtConfClave.Text))
            {
                MessageBox.Show("Confirme la Clave", "Alerta!!!");
            }
            else if (TxtConfClave.Text != TxtConfClave.Text)
            {
                MessageBox.Show("Las claves deben ser iguales", "Alerta!!!");
            }
            else if (string.IsNullOrEmpty(TxtClave.Text))
            {
                MessageBox.Show("Escriba un Usuario", "Alerta!!!");
            }
            else
            {
                Login users = new Login();
                users.Nombre = TxtNombre.Text;
                users.Apellido = TxtCorreo.Text;
                users.Correo = TxtUser.Text;
                users.Clave = TxtConfClave.Text;
                users.User = TxtClave.Text;
                users.TipoUsuario = Convert.ToString(TipoUser.Value);
                users.id = Id.Value;

                bool result = _servicio.Edit(users);
                if (result)
                {
                    MessageBox.Show("Se ha editado con exito", "Notificacion");
                }
                else
                {
                    MessageBox.Show("Oopss ha ocurrido un error", "Notificacion");
                }
            }
            FrmMantenimientoUsuarios newForm = new FrmMantenimientoUsuarios();
            newForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMantenimientoUsuarios form = new FrmMantenimientoUsuarios();
            form.Show();
            this.Close();
        }
    }
}
