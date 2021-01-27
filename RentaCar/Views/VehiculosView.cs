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

namespace RentaCar
{
    public partial class VehiculosView : Form
    {
        Vehiculos modeloEdit = new Vehiculos();
        public VehiculosView()
        {
            InitializeComponent();
            gatCombustible();
            gatTipoVehiculo();
            gatMarca();
            gatEstado();
           // gatModelo();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vehiculos modelo = new Vehiculos();
            try
            {
                modelo.descripcion = txtDescripcion.Text.Trim();
                modelo.no_chasis = txtChasis.Text.Trim();
                modelo.no_motor = txtMotor.Text.Trim();
                modelo.no_placa = txtPlaca.Text.Trim();
              //  modelo.Tipo_vehiculos = txtPlaca.Text.Trim();
               // modelo.id_tipo_combustible = cmbMarca.Text.ToString()
              //  modelo.id
                modelo.estado = cmbEstado.Text.ToString();
                if (modeloEdit.id != 0)
                {
                    modeloEdit.descripcion = txtDescripcion.Text.Trim();
                    modeloEdit.no_chasis = txtChasis.Text.Trim();
                    modeloEdit.no_motor = txtMotor.Text.Trim();
                    modeloEdit.no_placa = txtPlaca.Text.Trim();
                //    modeloEdit.tipo_persona = comboBoxPersona.Text.ToString();
                    modeloEdit.estado = cmbEstado.Text.ToString();
                }
             /*   if (txtNombre.Text == "")
                {
                    MessageBox.Show("Por favor, digite el nombre");
                }
                if (txtCedula.Text == "")
                {
                    MessageBox.Show("Por favor, digite la cédula");
                }
                if (txtNoCred.Text == "")
                {
                    MessageBox.Show("Por favor, digite el número de tarjeta de crédito");
                }
                if (txtLimCred.Text == "")
                {
                    MessageBox.Show("Por favor, digite el límite de crédito");
                }
                if (comboBoxEstado.Text == "")
                {
                    MessageBox.Show("Por favor, seleccione un estado");
                }
                if (comboBoxPersona.Text == "")
                {
                    MessageBox.Show("Por favor, seleccione un tipo de persona");
                } */
                else
                {

                    using (RentcarEntities DB = new RentcarEntities())
                    {
                        if (modeloEdit.id == 0)
                        {
                            DB.Vehiculos.Add(modelo);
                            DB.SaveChanges();
                        }
                        else
                        {
                            DB.Entry(modeloEdit).State = System.Data.Entity.EntityState.Modified;
                        }

                        DB.SaveChanges();
                        modeloEdit.id = 0;
                    }


                    FillDataGrid();
                    Clean();

                    MessageBox.Show("La información ha sido guardada con éxito!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void VehiculosView_Load(object sender, EventArgs e)
        {

        }

        private void FillDataGrid()
        {
            dgvVehiculos.AutoGenerateColumns = false;
            using (RentcarEntities db = new RentcarEntities())
            {
                dgvVehiculos.DataSource = db.Vehiculos.ToList<Vehiculos>();
            }
        }


        public void gatCombustible()
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                var combustible = db.Tipos_combustible.Where(a => a.estado == "Activo").ToList();
                foreach (var a in combustible)
                {
                    cmbCombustible.Items.Add(a.descripcion);
                }
            }
        }

        private void Clean()
        {
            txtDescripcion.Text = txtChasis.Text = txtMotor.Text = txtPlaca.Text = "";
            cmbCombustible.SelectedItem = cmbEstado.SelectedItem = cmbMarca = cmbModelo = cmbTipo = null;

        }

        public void gatTipoVehiculo()
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                var carro = db.Tipo_vehiculos.Where(a => a.estado == "Activo").ToList();
                foreach (var a in carro)
                {
                    cmbTipo.Items.Add(a.descripcion);
                }
            }
        }

        public void gatEstado()
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                var carro = db.Estados.Where(a => a.id == 1 ).ToList();
                foreach (var a in carro)
                {
                    cmbEstado.Items.Add(a.nombre);
                }
            }
        }

        public void gatMarca()
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                var marca = db.Marcas.ToList();
                foreach (var a in marca)
                {
                    cmbMarca.Items.Add(a.descripcion);
                }
            }
        }

     /*   public void gatModelo()
        {
            var index = cmbMarca.SelectedIndex;
            using (RentcarEntities db = new RentcarEntities())
            {
               var modmarcas = db.Marcas.ToList();
            }
            var idMarca= modmarcas[index].id;
            var posicionMarca = db.Modelos.FirstOrDefault(a => a.id_Marca == idMarca);
        } */

        private void dgvVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbModelo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void cmbCombustible_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
