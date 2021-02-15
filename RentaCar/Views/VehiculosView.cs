using RentaCar.Model;
using RentaCar.Views;
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
            FillDataGrid();

        }
        public void addComboboxes(){

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
                modelo.id_marca = Int32.Parse(cmbMarca.SelectedValue.ToString());
                modelo.id_modelo = Int32.Parse(cmbModelo.SelectedValue.ToString());
                modelo.id_tipo_combustible = Int32.Parse(cmbCombustible.SelectedValue.ToString());
                modelo.id_tipo_vehiculo = Int32.Parse(cmbTipo.SelectedValue.ToString());
                modelo.estado = cmbEstado.Text.ToString();
                if (modeloEdit.id != 0)
                {
                    modeloEdit.descripcion = txtDescripcion.Text.Trim();
                    modeloEdit.no_chasis = txtChasis.Text.Trim();
                    modeloEdit.no_motor = txtMotor.Text.Trim();
                    modeloEdit.no_placa = txtPlaca.Text.Trim();
                    modeloEdit.id_marca = Int32.Parse(cmbMarca.SelectedValue.ToString());
                    modeloEdit.id_modelo = Int32.Parse(cmbModelo.SelectedValue.ToString());
                    modeloEdit.id_tipo_combustible = Int32.Parse(cmbCombustible.SelectedValue.ToString());
                    modeloEdit.id_tipo_vehiculo = Int32.Parse(cmbTipo.SelectedValue.ToString());
                    modeloEdit.estado = cmbEstado.Text.ToString();
                }
                if (txtDescripcion.Text == "")
                {
                    MessageBox.Show("Por favor, digite la descripción");
                    return;
                }
                if (txtChasis.Text == "")
                {
                   MessageBox.Show("Por favor, digite el número de Chasis");
                   return;
                }
                if (txtMotor.Text == "")
                {
                    MessageBox.Show("Por favor, digite el número de motor");
                    return;
                }
                if (txtPlaca.Text == "")
                {
                    MessageBox.Show("Por favor, digite el número de placa");
                    return;
                }
                if (cmbMarca.Text == "")
                {
                    MessageBox.Show("Por favor, seleccione una marca");
                    return;
                }
                if (cmbModelo.Text == "")
                {
                    MessageBox.Show("Por favor, seleccione un modelo");
                    return;
                }
                if (cmbCombustible.Text == "")
                {
                    MessageBox.Show("Por favor, seleccione un tipo de combustible");
                    return;
                }
                if (cmbTipo.Text == "")
                {
                    MessageBox.Show("Por favor, seleccione un tipo de vehículo");
                    return;
                }
                if (cmbEstado.Text == "")
                {
                    MessageBox.Show("Por favor, seleccione un estado");
                    return;
                }
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

        public void gatModelos(int marcaId)
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                var mo = db.Modelos.Where(a => a.id_marca == marcaId).ToList();
                cmbModelo.DataSource = mo;
                cmbModelo.DisplayMember = "descripcion";
                cmbModelo.ValueMember = "id";
                cmbModelo.SelectedIndex = -1;
            }
        }

        private void VehiculosView_Load(object sender, EventArgs e)
        {

        }

        private void FillDataGrid()
        {
            dgvVehiculos.AutoGenerateColumns = false;
            using (RentcarEntities db = new RentcarEntities())
            {
                //dgvVehiculos.DataSource = db.Vehiculos.ToList<Vehiculos>();
                var list = db.Vehiculos.ToList<Vehiculos>();
                if (dgvVehiculos.Columns.Count <= 0)
                {
                    dgvVehiculos.Columns.Add("id", "id");
                    dgvVehiculos.Columns.Add("descripcion", "Descripcion");
                    dgvVehiculos.Columns.Add("Chasis", "Chasis");
                    dgvVehiculos.Columns.Add("Motor", "Motor");
                    dgvVehiculos.Columns.Add("Placa", "Placa");
                    dgvVehiculos.Columns.Add("Tipo", "Tipo");
                    dgvVehiculos.Columns.Add("Marca", "Marca");
                    dgvVehiculos.Columns.Add("Modelo", "Modelo");
                    dgvVehiculos.Columns.Add("Combustible", "Combustible");
                    dgvVehiculos.Columns.Add("Estado", "Estado");
                    dgvVehiculos.Columns.Add("GomaDerDelantera", "Goma Der. Delantera");
                }
                if (dgvVehiculos.Columns.Count > 0)
                {
                    dgvVehiculos.Rows.Clear();
                    dgvVehiculos.Refresh();
                }
                foreach (var a in list)
                {
                    dgvVehiculos.Rows.Add(a.id, a.descripcion, a.no_chasis, a.no_motor,
                        a.no_placa, a.Tipo_vehiculos.descripcion, a.Marcas.descripcion, a.Modelos.descripcion, a.Tipos_combustible.descripcion,
                        a.estado);
                }
            }
        }


        public void gatCombustible()
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                var combustible = db.Tipos_combustible.Where(a => a.estado == "Activo").ToList();
                cmbCombustible.DataSource = combustible;
                cmbCombustible.DisplayMember = "descripcion";
                cmbCombustible.ValueMember = "id";
                cmbCombustible.SelectedIndex = -1;
                //foreach (var a in combustible)
                //{
                //    cmbCombustible.Items.Add(a.descripcion);
                //}
            }
        }

        private void Clean()
        {
            modeloEdit.id = 0;
            txtDescripcion.Text = txtChasis.Text = txtMotor.Text = txtPlaca.Text = "";
            cmbCombustible.SelectedIndex = -1; 
            cmbEstado.SelectedIndex = -1;
            cmbMarca.SelectedIndex = -1;
            cmbModelo.SelectedIndex = -1;
            cmbTipo.SelectedIndex = -1;

        }

        public void gatTipoVehiculo()
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                var carro = db.Tipo_vehiculos.Where(a => a.estado == "Activo").ToList();
                //foreach (var a in carro)
                //{
                //    cmbTipo.Items.Add(a.descripcion);
                //}
                cmbTipo.DataSource = carro;
                cmbTipo.DisplayMember = "descripcion";
                cmbTipo.ValueMember = "id";
                cmbTipo.SelectedIndex = -1;
            }
        }

        public void gatEstado()
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                var carro = db.Estados.Where(a => a.id == 1 ).ToList();
                cmbEstado.DataSource = carro;
                cmbEstado.DisplayMember = "nombre";
                cmbEstado.ValueMember = "id";
                cmbEstado.SelectedIndex = -1;
                //foreach (var a in carro)
                //{
                //    cmbEstado.Items.Add(a.nombre);
                //}
            }
        }

        public void gatMarca()
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                var marca = db.Marcas.ToList();
                cmbMarca.DataSource = marca;
                cmbMarca.DisplayMember = "descripcion";
                cmbMarca.ValueMember = "id";
                cmbMarca.SelectedIndex = -1;
                //foreach (var a in marca)
                //{
                //    cmbMarca.Items.Add(a.descripcion);
                //}
            }
        }

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
            try
            {
                if (cmbMarca.SelectedIndex != -1)
                {
                    var marcaId = cmbMarca.SelectedValue.ToString();
                    gatModelos(Int32.Parse(marcaId));

                }
            }
            catch (Exception error)
            {
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            MantenimientosView frm = new MantenimientosView();

            frm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();

            InicioView frm = new InicioView();

            frm.Show();
        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvVehiculos_DoubleClick(object sender, EventArgs e)
        {
            modeloEdit.id = Convert.ToInt32(dgvVehiculos.CurrentRow.Cells["id"].Value);
            using (RentcarEntities db = new RentcarEntities())
            {
                var modelo = db.Vehiculos.Where(x => x.id == modeloEdit.id).FirstOrDefault();

                txtDescripcion.Text = modelo.descripcion;
                txtChasis.Text = modelo.no_chasis;
                txtMotor.Text = modelo.no_motor;
                txtPlaca.Text = modelo.no_placa;
                cmbMarca.SelectedValue = Int32.Parse(modelo.id_marca.ToString());
                cmbModelo.SelectedValue = Int32.Parse(modelo.id_modelo.ToString());
                cmbCombustible.SelectedValue = Int32.Parse(modelo.id_tipo_combustible.ToString());
                cmbTipo.SelectedValue = Int32.Parse(modelo.id_tipo_vehiculo.ToString());
                cmbEstado.SelectedIndex = cmbEstado.FindStringExact(modelo.estado.ToString()); 

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vehiculos modelo = new Vehiculos();
            if (MessageBox.Show("Estás seguro que quieres eliminar esa información?", "Borrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (RentcarEntities db = new RentcarEntities())
                {
                    if (modeloEdit.id != 0)
                    {
                        var modeloFind = db.Vehiculos.FirstOrDefault(a => a.id == modeloEdit.id);

                        if (modeloFind != null)
                        {
                            db.Vehiculos.Remove(modeloFind);
                            db.SaveChanges();
                            FillDataGrid();
                            Clean();
                            modeloEdit.id = 0;
                            MessageBox.Show("Se ha eliminado la información correctamente");
                        }
                    }
                }

            }
        }
    }
}
