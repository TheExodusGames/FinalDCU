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
    public partial class FrmAgregarPruebasLab : Form
    {
        private ServicioPruebasLab _servicio;
        public int? Id = null;
        public FrmAgregarPruebasLab(int? ID)
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            Id = ID;
            SqlConnection connection = new SqlConnection(connectionString);

            _servicio = new ServicioPruebasLab(connection);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Id == null)
            {
                AddPruebasLab();
            }
            else
            {
                EditPruebasLab();
            }
        }

        private void AddPruebasLab()
        {
            if (string.IsNullOrEmpty(TxtName.Text))
            {
                MessageBox.Show("Escriba un Nombre", "Alerta!!!");
            }
            else
            {
                PruebasLab PruebasLab = new PruebasLab();
                PruebasLab.Nombre = TxtName.Text;
                bool result = _servicio.Add(PruebasLab);
                if (result)
                {
                    MessageBox.Show("Se ha agregado con exito", "Notificacion");
                }
                else
                {
                    MessageBox.Show("Oopss ha ocurrido un error", "Notificacion");
                }

            }
            FrmMantenimientoPruebasLab newForm = new FrmMantenimientoPruebasLab();
            newForm.Show();
            this.Hide();

        }

        private void EditPruebasLab()
        {
            if (string.IsNullOrEmpty(TxtName.Text))
            {
                MessageBox.Show("Escriba un Nombre", "Alerta!!!");
            }
            else
            {
                PruebasLab pruebasLab = new PruebasLab();
                pruebasLab.Nombre = TxtName.Text;
                pruebasLab.id = Id.Value;

                bool result = _servicio.Edit(pruebasLab);
                if (result)
                {
                    MessageBox.Show("Se ha editado con exito", "Notificacion");
                }
                else
                {
                    MessageBox.Show("Oopss ha ocurrido un error", "Notificacion");
                }
            }
            FrmMantenimientoPruebasLab NewFrm = new FrmMantenimientoPruebasLab();
            NewFrm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMantenimientoPruebasLab form = new FrmMantenimientoPruebasLab();
            form.Show();
            this.Close();
        }
    }
}
