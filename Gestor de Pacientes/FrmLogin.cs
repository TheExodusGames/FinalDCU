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
    public partial class FrmLogin : Form
    {
        private ServiciosLogin _servicio;
        private SqlConnection _connection;
        public FrmLogin()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);
            _connection = connection;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Logear(this.TxtUser.Text, this.TxtClave.Text);
        }

        public void Logear(string usuario, string clave)
        {
            Menu newForm = new Menu();
            try
            {
                _connection.Open(); ;
                SqlCommand cmd = new SqlCommand("Select Nombre, TipoUsuario from Usuarios where Usuario = @usuario and Clave = @pas", _connection);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pas", clave);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if(dt.Rows[0][1].ToString() == "1") 
                    {
                        newForm.resultadosPruebasLaboratorioToolStripMenuItem.Enabled = false;
                        newForm.citasToolStripMenuItem.Enabled = false;
                        newForm.pacientesToolStripMenuItem.Enabled = false;
                        newForm.pruebasDeLaboratorioToolStripMenuItem.Enabled = false;
                        newForm.Show();
                        this.Hide();
                    }
                    else if (dt.Rows[0][1].ToString() == "2")
                    {
                        newForm.mantenimientoUsuarioToolStripMenuItem.Enabled = false;
                        newForm.mantenimientoDeToolStripMenuItem.Enabled = false;
                        newForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña Incorrecta", "Alerta!!!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                _connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu newForm = new Menu();
            newForm.Show();
            this.Hide();
        }
    }
}
