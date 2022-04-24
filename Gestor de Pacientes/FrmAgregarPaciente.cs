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
    public partial class FrmAgregarPaciente : Form
    {
        private readonly ServicioPacientes _servicio;
        public int _id;
        private string _filename;
        public FrmAgregarPaciente(int ID)
        {
            _id = ID;
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);


            _servicio = new ServicioPacientes(connection);
            _filename = "";
        }

        private void BtnFotoPerfil_Click(object sender, EventArgs e)
        {
            AddPhoto();
        }

        private void FrmAgregarPaciente_Load(object sender, EventArgs e)
        {
        }
        private void AddPaciente()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Escriba un Nombre", "Alerta!!!");
            }
            else if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Escriba un Apellido", "Alerta!!!");
            }
            else if (string.IsNullOrEmpty(txtTel.Text))
            {
                MessageBox.Show("Escriba un Telefono", "Alerta!!!");
            }
            else if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("Escriba un Correo", "Alerta!!!");
            }
            else if (string.IsNullOrEmpty(txtCedula.Text))
            {
                MessageBox.Show("Escriba una Cedula", "Alerta!!!");
            }
            else if (string.IsNullOrEmpty(txtAlergias.Text))
            {
                MessageBox.Show("Describa sus alergias", "Alerta!!!");
            }
            else
            {
                Paciente pacient = new Paciente();
                pacient.Nombre = txtName.Text;
                pacient.Apellido = txtApellido.Text;
                pacient.Direccion = txtDireccion.Text;
                pacient.Telefono = txtTel.Text;
                pacient.Cedula = txtCedula.Text;
                pacient.FechaNacimiento = DTPPacientes.Value;
                if (CBFumador.Checked == true)
                {
                    pacient.Fumador = true;
                }
                else
                {
                    pacient.Fumador = false;
                }
                pacient.Alergias = txtAlergias.Text;

                bool result = _servicio.Add(pacient);
                SavePhoto();
                if (result)
                {
                    MessageBox.Show("Se ha agregado con exito", "Notificacion");
                }
                else
                {
                    MessageBox.Show("Oopss ha ocurrido un error", "Notificacion");
                }

            }
            FrmMantenimientoPacientes newFrm = new FrmMantenimientoPacientes();
            newFrm.Show();
            this.Hide();

        }

        private void EditarPaciente()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Escriba un Nombre", "Alerta!!!");
            }
            else if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Escriba un Apellido", "Alerta!!!");
            }
            else if (string.IsNullOrEmpty(txtTel.Text))
            {
                MessageBox.Show("Escriba un Telefono", "Alerta!!!");
            }
            else if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("Escriba un Correo", "Alerta!!!");
            }
            else if (string.IsNullOrEmpty(txtCedula.Text))
            {
                MessageBox.Show("Escriba una Cedula", "Alerta!!!");
            }
            else if (string.IsNullOrEmpty(txtAlergias.Text))
            {
                MessageBox.Show("Describa sus alergias", "Alerta!!!");
            }
            else
            {
                Paciente pacient = new Paciente();
                pacient.Nombre = txtName.Text;
                pacient.Apellido = txtApellido.Text;
                pacient.Direccion = txtDireccion.Text;
                pacient.Telefono = txtTel.Text;
                pacient.Cedula = txtCedula.Text;
                pacient.FechaNacimiento = DTPPacientes.Value;
                if(CBFumador.Text == "Si")
                {
                    pacient.Fumador = Convert.ToBoolean(1);
                }
                else
                {
                    pacient.Fumador = Convert.ToBoolean(2);
                }
                pacient.Alergias = txtAlergias.Text;
                pacient.id = _id;

                bool result = _servicio.Edit(pacient);
                SavePhoto();

                if (result)
                {
                    MessageBox.Show("Se ha editado con exito", "Notificacion");
                }
                else
                {
                    MessageBox.Show("Oopss ha ocurrido un error", "Notificacion");
                }

            }
            FrmMantenimientoPacientes newFrm = new FrmMantenimientoPacientes();
            newFrm.Show();
            this.Hide();

        }

        private void AddPhoto()
        {
            DialogResult result = PictureDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string file = PictureDialog.FileName;

                _filename = file;

                PBPacientes.ImageLocation = file;
            }
        }
        private void SavePhoto()
        {

            int id = _id == 0 ? _servicio.GetLastId() : _id;


            string directory = @"Images\Pacientes\" + id + "\\";

            string[] fileNameSplit = _filename.Split('\\');
            string filename = fileNameSplit[(fileNameSplit.Length - 1)];

            CreateDirectory(directory);

            string destination = directory + filename;

            File.Copy(_filename, destination, true);

            _servicio.SavePhoto(id, destination);
        }
        private void CreateDirectory(string directory)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (_id == 0)
            {
                AddPaciente();
            }
            else
            {
                EditarPaciente();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMantenimientoPacientes form = new FrmMantenimientoPacientes();
            form.Show();
            this.Close();
        }
    }
}
