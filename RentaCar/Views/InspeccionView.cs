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
        Inspeccion modeloEdit = new Inspeccion();
        public InspeccionView()
        {
            InitializeComponent();
            //gatEstados();
            gatEmpleados();
            gatClientes();
             getNameAndmarca();
            //getDespVehiculos();
            FillDataGrid();
        }

        
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void getNameAndmarca() {
            using (RentcarEntities db = new RentcarEntities()) {
                var getElement = db.Vehiculos.Where(a => a.estado == "Disponible").ToList();
                if (getElement.Count > 0) {
                    //foreach (var a in getElement)
                    //{
                    //    a.descripcion = a.Marcas.descripcion + " " + a.Modelos.descripcion;
                    //}
                    cmbV.DataSource = getElement;
                    cmbV.DisplayMember = "descripcion";
                    cmbV.ValueMember = "id";
                    cmbV.SelectedIndex = -1;
                }
            }
        }
      
        //Descripcion de vehiculos cmbV
        public void getDespVehiculos()
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                var veh = db.Vehiculos.Where(a => a.estado == "Disponible").ToList();

                foreach (var a in veh)
                {
                    cmbV.Items.Add(a.descripcion);
                }
            }
        }

       /* public void gatEstados()
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                var marcas = db.Estados.Where(a => a.id == 1 | a.id == 5).ToList();

                foreach (var a in marcas)
                {
                    cmbEstado.Items.Add(a.nombre);
                }
            }
        } */

        public void gatEmpleados()
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                var emp = db.Empleados.Where(a => a.estado == "Activo").ToList();
                cmbEmp.DataSource = emp;
                cmbEmp.DisplayMember = "nombre";
                cmbEmp.ValueMember = "id";
                cmbEmp.SelectedIndex = -1;
                
            }
        }

        public void gatClientes()
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                var cli = db.Clientes.Where(a => a.estado == "Activo").ToList();
                cmbC.DataSource = cli;
                cmbC.DisplayMember = "nombre";
                cmbC.ValueMember = "id";
                cmbC.SelectedIndex = -1;
                
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

        private void FillDataGrid()
        {
            dgvInspeccion.AutoGenerateColumns = false;
            using (RentcarEntities db = new RentcarEntities())
            {
                var list = db.Inspeccion.ToList();
                if (dgvInspeccion.Columns.Count <= 0)
                {
                    dgvInspeccion.Columns.Add("id", "id");
                    dgvInspeccion.Columns.Add("Vehiculo", "Vehiculo Descripcion");
                    dgvInspeccion.Columns.Add("Vehiculo", "Vehiculo");
                    dgvInspeccion.Columns.Add("Cliente", "Cliente");
                    dgvInspeccion.Columns.Add("Ralladura", "Ralladura");
                    dgvInspeccion.Columns.Add("Combustible", "Combustible");
                    dgvInspeccion.Columns.Add("GomaRepuesto", "Gomga repuesto");
                    dgvInspeccion.Columns.Add("Gato", "Gato");
                    dgvInspeccion.Columns.Add("Roturasa", "Roturas cristal");
                    dgvInspeccion.Columns.Add("GomaIzDelantera", "Goma Izq. Delantera");
                    dgvInspeccion.Columns.Add("GomaDerDelantera", "Goma Der. Delantera");
                    dgvInspeccion.Columns.Add("GomaTrasIzqu", "Goma Trasera Izqu.");
                    dgvInspeccion.Columns.Add("GomaTrasDer", "Goma Trasera Derecha.");
                    dgvInspeccion.Columns.Add("Fecha", "Fecha");
                    dgvInspeccion.Columns.Add("Empleado", "Empleado");
                   // dgvInspeccion.Columns.Add("Estado", "Estado");
                }
                if (dgvInspeccion.Columns.Count > 0) {
                    dgvInspeccion.Rows.Clear();
                    dgvInspeccion.Refresh();
                }
                foreach (var a in list)
                {
                    dgvInspeccion.Rows.Add(a.id, a.Vehiculos.descripcion,a.Vehiculos.Marcas.descripcion +" "+ a.Vehiculos.Modelos.descripcion, a.Clientes.nombre, a.ralladuras,
                        a.cantidad_combustible, a.goma_repuesto, a.gato, a.roturas_cristal,a.goma_delantera_izquierda,
                        a.goma_delantera_derecha, a.goma_trasera_izquierda, a.goma_trasera_derecha, a.fecha,
                        a.Empleados.nombre/*a.estado*/);
                }
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            
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
            Inspeccion modelo = new Inspeccion();
            try
            {
                modelo.id_cliente = Int32.Parse(cmbC.SelectedValue.ToString());
                modelo.id_vehiculo = Int32.Parse(cmbV.SelectedValue.ToString());
                modelo.id_empleado = Int32.Parse(cmbEmp.SelectedValue.ToString());
               // modelo.estado = cmbEstado.Text.ToString();
                modelo.cantidad_combustible = cmbCombustible.Text.ToString();
                modelo.fecha = dateTimePicker1.Value;
                modelo.gato = rdb1.Checked ? "Si" : "No";
                modelo.goma_repuesto = rdb2.Checked ? "Si" : "No";
                modelo.goma_delantera_derecha = rdb3.Checked ? "Si" : "No";
                modelo.goma_delantera_izquierda = rdb4.Checked ? "Si" : "No";
                modelo.goma_trasera_derecha = rdb5.Checked ? "Si" : "No";
                modelo.goma_trasera_izquierda = rdb6.Checked ? "Si" : "No";
                modelo.ralladuras = rdb7.Checked ? "Si" : "No";
                modelo.roturas_cristal = rdb8.Checked ? "Si" : "No";
                if (modeloEdit.id != 0)
                {
                    modelo.id = modeloEdit.id;
                    modeloEdit = modelo;
                }
              //  else
               // {

                    using (RentcarEntities DB = new RentcarEntities())
                    {
                        if (modeloEdit.id == 0)
                        {
                            DB.Inspeccion.Add(modelo);
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
             //   }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cbGomaRep_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbRalladura_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbGato_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();

            InicioView frm = new InicioView();

            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();

            ServiciosView frm = new ServiciosView();

            frm.Show();
        }

        private void radioButton17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCombustible_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvInspeccion_DoubleClick(object sender, EventArgs e)
        {
            modeloEdit.id = Convert.ToInt32(dgvInspeccion.CurrentRow.Cells["id"].Value);
            if (modeloEdit.id != 0)
            {
                using (RentcarEntities db = new RentcarEntities())
                {
                    var modelo = db.Inspeccion.Where(x => x.id == modeloEdit.id).FirstOrDefault();
                    cmbC.SelectedIndex = cmbC.FindStringExact(modelo.Clientes.nombre);
                    cmbV.SelectedIndex = cmbV.FindStringExact( modelo.Vehiculos.descripcion);
                    cmbEmp.SelectedIndex = cmbEmp.FindStringExact(modelo.Empleados.nombre);
                   // cmbEstado.Text = modelo.estado;
                    cmbCombustible.Text = modelo.cantidad_combustible;
                    dateTimePicker1.Text = modelo.fecha.ToString();
                    if (modelo.gato == "Si") { rdb1.Checked = true; } else { rdb11.Checked = true; }
                    if (modelo.goma_repuesto == "Si") { rdb2.Checked = true; } else { rdb22.Checked = true; }
                    if (modelo.goma_delantera_derecha == "Si") { rdb3.Checked = true; } else { rdb33.Checked = true; }
                    if (modelo.goma_delantera_izquierda == "Si") { rdb4.Checked = true; } else { rdb44.Checked = true; }
                    if (modelo.goma_trasera_derecha == "Si") { rdb5.Checked = true; } else { rdb55.Checked = true; }
                    if (modelo.goma_trasera_izquierda == "Si") { rdb6.Checked = true; } else { rdb66.Checked = true; }
                    if (modelo.ralladuras == "Si") { rdb7.Checked = true; } else { rdb77.Checked = true; }
                    if (modelo.roturas_cristal == "Si") { rdb8.Checked = true; } else { rdb88.Checked = true; }
                }
            }
        }
        private void Clean()
        {
            modeloEdit.id = 0;
            cmbC.SelectedIndex = -1;
            cmbV.SelectedIndex = -1;
            cmbEmp.SelectedIndex = -1;
            dateTimePicker1.Text = /*cmbEstado.Text*/  cmbCombustible.Text = "";
           // cmbEstado.SelectedIndex = -1;
            cmbCombustible.SelectedIndex = -1; 
            rdb11.Checked =  true;
            rdb22.Checked = true;
            rdb33.Checked = true;
            rdb44.Checked = true;
            rdb55.Checked = true;
            rdb66.Checked = true;
            rdb77.Checked = true;
            rdb88.Checked = true;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Inspeccion modelo = new Inspeccion();
            if (MessageBox.Show("Estás seguro que quieres eliminar esa información?", "Borrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (RentcarEntities db = new RentcarEntities())
                {
                    if (modeloEdit.id != 0)
                    {
                        var modeloFind = db.Inspeccion.FirstOrDefault(a => a.id == modeloEdit.id);

                        if (modeloFind != null)
                        {
                            db.Inspeccion.Remove(modeloFind);
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
