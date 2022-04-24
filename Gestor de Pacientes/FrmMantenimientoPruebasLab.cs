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
    public partial class FrmMantenimientoPruebasLab : Form
    {
        private ServicioPruebasLab _servicio;
        public int? Id = null;
        public FrmMantenimientoPruebasLab()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

            SqlConnection connection = new SqlConnection(connectionString);

            _servicio = new ServicioPruebasLab(connection);
        }

        private void FrmMantenimientoPruebasLab_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            FrmAgregarPruebasLab newForm = new FrmAgregarPruebasLab(Id);
            newForm.Show();
            this.Hide();
        }

        private void DGVPruebasLab_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmAgregarPruebasLab newForm = new FrmAgregarPruebasLab(Id);
            Id = Convert.ToInt32(DGVPruebasLab.Rows[e.RowIndex].Cells[0].Value.ToString());
            newForm.Id = Convert.ToInt32(DGVPruebasLab.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DeletePruebaLab();
        }

        private void Editar()
        {
            FrmAgregarPruebasLab newForm = new FrmAgregarPruebasLab(Id);

            PruebasLab PruebaLab = new PruebasLab();

            PruebaLab = _servicio.GetById(Id.Value);

            newForm.TxtName.Text = PruebaLab.Nombre;

            newForm.Show();
        }
        private void LoadData()
        {
            DGVPruebasLab.DataSource = _servicio.GetAll();
            DGVPruebasLab.ClearSelection();
        }
        private void DeletePruebaLab()
        {
            if (Id == null)
            {
                MessageBox.Show("Debes seleccionar una Prueba", "Notificacion");
            }
            else
            {
                DialogResult response = MessageBox.Show("Esta seguro que desea eliminar esta Prueba?",
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
