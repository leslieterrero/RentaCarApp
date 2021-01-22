using RentaCar.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaCar.Views
{
    public partial class InspeccionView : Form
    {
        public InspeccionView()
        {
            InitializeComponent();
            gatEstados();
            gatEmpleados();
            gatClientes();
            getNameAndmarca();
           // FillDataGrid();
        }

        String goma;
        String defecto;
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void getNameAndmarca() {
            using (RentcarEntities db = new RentcarEntities()) {
                var getElement = db.Vehiculos.Where(a => a.estado == "Rentado").ToList();
                foreach (var a in getElement) {
                    a.descripcion = a.Marcas.descripcion + " " + a.Modelos.descripcion;
                }
                cmbV.DataSource = getElement;
                cmbV.DisplayMember = "descripcion";
                cmbV.ValueMember = "id";
                cmbV.SelectedIndex = -1;
            }
        }
        public void gatEstados()
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                var marcas = db.Estados.Where(a => a.id == 1 | a.id == 5).ToList();
                foreach (var a in marcas)
                {
                    cmbEstado.Items.Add(a.nombre);
                }
            }
        }

        public void gatEmpleados()
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                var emp = db.Empleados.Where(a => a.estado == "Activo").ToList();
                foreach (var a in emp)
                {
                    cmbEmp.Items.Add(a.nombre);
                }
            }
        }

        public void gatClientes()
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                var cli = db.Clientes.Where(a => a.estado == "Activo").ToList();
                foreach (var a in cli)
                {
                    cmbC.Items.Add(a.nombre);
                }
            }
        }


        private void InspeccionView_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

      /*  private void FillDataGrid()
        {
            dgvInspeccion.AutoGenerateColumns = false;
            using (RentcarEntities db = new RentcarEntities())
            {
                dgvInspeccion.DataSource = db.Vehiculos.Where(a => a.estado == "Rentado").ToList();
            }
        }
      */
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            goma = "Defectuosa";

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            goma = "Defectuosa";
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            goma = "Defectuosa";
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            goma = "Defectuosa";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void cmbV_SelectedValueChanged(object sender, EventArgs e)
        {
            using (RentcarEntities db = new RentcarEntities())
            {
               

                    try
                    {
                        if (cmbV.SelectedIndex != -1)
                        {
                            var id = cmbV.SelectedValue.ToString();
                            var number = Int64.Parse(id);

                            var inspecciones = db.Inspeccion.Where(a => a.id_vehiculo == number).FirstOrDefault();

                        }
                    }
                    catch (Exception error)
                    {
                    }
            
            }
        }

        private void cmbV_ValueMemberChanged(object sender, EventArgs e)
        {

        }
    }
}
