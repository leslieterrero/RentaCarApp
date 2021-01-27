using RentaCar.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaCar.Views
{
    public partial class RentaView : Form
    {
        Renta_devolucion modelo = new Renta_devolucion();
        public RentaView()
        {
            InitializeComponent();
            gatClientes();
            gatEmpleados();
            gatMarcas();
            //gatModelos();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          /*  try
            {
                modelo. = txtCliente.Text.Trim();
                modelo.cedula = txtEmpleado.Text.Trim();
                modelo.no_tarjeta_cr = txtComent.Text.Trim();
                modelo.monto_dia = txtMonto.Text.
                modelo.fecha_devolucion = dtpRenta.Value;
                modelo.total_dias = numDias.Value.;
                if (txtEmpleado.Text == "")
                {
                    MessageBox.Show("Por favor, digite el empleado");
                }
                if (txtMonto.Text == "")
                {
                    MessageBox.Show("Por favor, digite el monto");
                }
                if (txtCliente.Text == "")
                {
                    MessageBox.Show("Por favor, digite el cliente");
                }
                if (numDias.Text == "")
                {
                    MessageBox.Show("Por favor, seleccione la cantidad de días");
                }
                else
                {
                    using (RentcarEntities DB = new RentcarEntities())
                    {
                        DB.Renta_devolucion.Add(modelo);
                        DB.SaveChanges();

                        DB.SaveChanges();
                    }
                    // Clean();
                    MessageBox.Show("La información ha sido guardada con éxito!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } */
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
            if(e.KeyChar == (char)13)
            {
                txtMonto.Text = string.Format(CultureInfo.CreateSpecificCulture("rd-DO"), "{0:C}", double.Parse(txtMonto.Text));
            }
        }

        public void gatEmpleados()
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                var emp = db.Empleados.Where(a => a.estado == "Activo").ToList();
                foreach (var a in emp)
                {
                    cmbE.Items.Add(a.nombre);
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


        public void gatMarcas()
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                var mar = db.Marcas.Where(a => a.estado == "Activo").ToList();
                //foreach (var a in mar)
                //{
                //    cmbMa.Items.Add(a.descripcion);
                //}
                cmbMa.DataSource = mar;
                cmbMa.DisplayMember = "descripcion";
                cmbMa.ValueMember = "id";
                cmbMa.SelectedIndex = -1;
            }
        }


        public void gatModelos(int marcaId)
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                var mo = db.Modelos.Where(a => a.id_marca == marcaId).ToList();
                //foreach (var a in mo)
                //{
                //    cmbMo.Items.Add(a.descripcion);
                //}
                cmbMo.DataSource = mo;
                cmbMo.DisplayMember = "descripcion";
                cmbMo.ValueMember = "id";
                cmbMo.SelectedIndex = -1;
            }
        }





        private void RentaView_Load(object sender, EventArgs e)
        {

        }

        private void dgvRenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpRenta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxPersona_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmbMa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbMa.SelectedIndex != -1)
                {
                    var marcaId = cmbMa.SelectedValue.ToString();
                    gatModelos(Int32.Parse(marcaId));

                }
            }
            catch (Exception error)
            {
            }
        }
    }
}
