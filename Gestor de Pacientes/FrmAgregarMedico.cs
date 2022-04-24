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
    public partial class FrmAgregarMedico : Form
    {
        private readonly ServicioMedicos _servicio;
        public int _id;
        private string _filename;
        public FrmAgregarMedico(int ID)
        {
            _id = ID;
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);


            _servicio = new ServicioMedicos(connection);
            _filename = "";
        }

        private void AgregarMedico_Load(object sender, EventArgs e)
        {

        }
        private void AddMedico()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Escriba un Nombre", "Alerta!!!");
            }
            else if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Escriba un Apellido", "Alerta!!!");
            }
            else if (string.IsNullOrEmpty(txtCorreo.Text))
            {
                MessageBox.Show("Escriba un Correo", "Alerta!!!");
            }
            else if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Escriba un Telefono", "Alerta!!!");
            }
            else if (string.IsNullOrEmpty(txtCedula.Text))
            {
                MessageBox.Show("Escriba una Cedula", "Alerta!!!");
            }
            else
            {
                Medico medic = new Medico();
                medic.Nombre = txtName.Text;
                medic.Apellido = txtApellido.Text;
                medic.Correo = txtCorreo.Text;
                medic.Telefono = txtTelefono.Text;
                medic.Cedula = txtCedula.Text;
                bool result = _servicio.Add(medic);
                if (result)
                {
                    MessageBox.Show("Se ha agregado con exito", "Notificacion");
                                        SavePhoto();
                }
                else
                {
                    MessageBox.Show("Oopss ha ocurrido un error", "Notificacion");
                }

            }
            FrmMantenimientoMedicos newFrm = new FrmMantenimientoMedicos();
            newFrm.Show();
            this.Hide();

        }

        private void EditarMedico()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Escriba un Nombre", "Alerta!!!");
            }
            else if (string.IsNullOrEmpty(txtApellido.Text))
            {
                MessageBox.Show("Escriba un Apellido", "Alerta!!!");
            }
            else if (string.IsNullOrEmpty(txtCorreo.Text))
            {
                MessageBox.Show("Escriba un Correo", "Alerta!!!");
            }
            else if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Escriba un Telefono", "Alerta!!!");
            }
            else if (string.IsNullOrEmpty(txtCedula.Text))
            {
                MessageBox.Show("Escriba una Cedula", "Alerta!!!");
            }
            else
            {
                Medico medic = new Medico();
                medic.Nombre = txtName.Text;
                medic.Apellido = txtApellido.Text;
                medic.Correo = txtCorreo.Text;
                medic.Telefono = txtTelefono.Text;
                medic.Cedula = txtCedula.Text;
                medic.id = _id;


                bool result = _servicio.Edit(medic);
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
            FrmMantenimientoMedicos newFrm = new FrmMantenimientoMedicos();
            newFrm.Show();
            this.Hide();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddPhoto();
        }
        private void AddPhoto()
        {
           DialogResult result = PictureDialog.ShowDialog();

           if (result == DialogResult.OK)
           {
               string file = PictureDialog.FileName;

               _filename = file;

               PBPerfil.ImageLocation = file;
           }
        }
        private void SavePhoto()
        {
            
          int id = _id == 0 ? _servicio.GetLastId() : _id;


           string directory = @"Images\Medicos\" + id + "\\";

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
                AddMedico();
                SavePhoto();
            }
            else
            {
                EditarMedico();
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmMantenimientoMedicos form = new FrmMantenimientoMedicos();
            form.Show();
            this.Close();
        }
    }
}
