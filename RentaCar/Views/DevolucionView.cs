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
    public partial class DevolucionView : Form
    {
        Renta_devolucion modeloEdit = new Renta_devolucion();
        public DevolucionView()
        {
            InitializeComponent();
            gatClientes();
            gatEmpleados();
            getVehiculos();
            getRentaAndDevolucion();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void DevolucionView_Load(object sender, EventArgs e)
        {

        }

        private void cmbC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numDias_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpRenta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvRenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
             try
            {
                Renta_devolucion modelo = new Renta_devolucion();

                
               
                    modeloEdit.id_empleado = Int32.Parse(cmbE.SelectedValue.ToString());
                    modeloEdit.id_vehiculo = Int32.Parse(cmbV.SelectedValue.ToString());
                    modeloEdit.id_cliente = Int32.Parse(cmbC.SelectedValue.ToString());
                    modeloEdit.fecha_devolucion = dtpDevolucion.Value;
                    modeloEdit.fecha_renta = dtpRenta.Value;
                    modeloEdit.monto_dia = Int32.Parse(txtMonto.Text);
                    modeloEdit.total_dias = Int32.Parse(txtDia.Text);
                    modeloEdit.comentario = txtCom.Text;
                    modeloEdit.estado = "Disponible";
                

                
                if (txtCom.Text == "")
                {
                    MessageBox.Show("Por favor, escriba un comentario");
                    
                }
          
                else
                {
                    using (RentcarEntities DB = new RentcarEntities())
                    {

                        var findVehiculo = DB.Vehiculos.FirstOrDefault(a => a.id == modeloEdit.id_vehiculo);
                        if (modeloEdit.id == 0)
                        {
                            DB.Renta_devolucion.Add(modelo);
                        
                        }
                        else {
                            findVehiculo.estado = "Disponible";
                            DB.Entry(findVehiculo).State = System.Data.Entity.EntityState.Modified;
                            DB.Entry(modeloEdit).State = System.Data.Entity.EntityState.Modified;
                        }
                        DB.SaveChanges();
                        modeloEdit.id = 0;
                        
                    }
                    
                    getRentaAndDevolucion();
                    Limpiar();
                    getVehiculos();
                    
                    MessageBox.Show("La información ha sido guardada con éxito!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        public void getRentaAndDevolucion()
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                var list = db.Renta_devolucion.Where(a => a.Vehiculos.estado == "Rentado").ToList();
                if (dgvRenta.Columns.Count <= 0)
                {
                    dgvRenta.Columns.Add("id", "Id");
                    dgvRenta.Columns.Add("Empleado", "Empleado");
                    dgvRenta.Columns.Add("Vehiculo", "Vehiculo");
                    dgvRenta.Columns.Add("Cliente", "Cliente");
                    dgvRenta.Columns.Add("FechaRenta", "Fecha renta");
                    dgvRenta.Columns.Add("MontoDia", "Monto por dia");
                    dgvRenta.Columns.Add("totaldias", "Total por dias");
                    dgvRenta.Columns.Add("comentario", "Comentario");
                    dgvRenta.Columns.Add("FechaDevolucion", "Devolucion");
                }
                if (dgvRenta.Columns.Count > 0)
                {
                    dgvRenta.Rows.Clear();
                    dgvRenta.Refresh();
                }
                foreach (var a in list)
                {
                    dgvRenta.Rows.Add(a.id, a.Empleados.nombre, a.Vehiculos.descripcion, a.Clientes.nombre,
                        a.fecha_renta, a.monto_dia, a.total_dias, a.comentario, a.fecha_devolucion);
                }
               
            }
        }


        public void Limpiar()
        {
            modeloEdit.id = 0;
            cmbC.SelectedIndex = -1;
            cmbE.SelectedIndex = -1;
            cmbV.SelectedIndex = -1;
            dtpRenta = new DateTimePicker();
            dtpDevolucion = new DateTimePicker();
            txtMonto.Text = "";
            txtCom.Text = "";
            txtDia.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvRenta_DoubleClick(object sender, EventArgs e)
        {
            modeloEdit.id = Convert.ToInt32(dgvRenta.CurrentRow.Cells["id"].Value);
            using (RentcarEntities db = new RentcarEntities())
            {
                var modelo = db.Renta_devolucion.Where(x => x.id == modeloEdit.id).FirstOrDefault();
                cmbC.SelectedIndex = cmbC.FindStringExact(modelo.Clientes.nombre);
                cmbE.SelectedIndex = cmbE.FindStringExact(modelo.Empleados.nombre);
                cmbV.SelectedIndex = cmbV.FindStringExact(modelo.Vehiculos.descripcion);
                txtDia.Text = modelo.total_dias.ToString();
                txtMonto.Text = modelo.monto_dia.ToString();
                dtpRenta.Text = modelo.fecha_renta.ToString();
               // txtCom.Text = modelo.comentario.ToString();

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

        public void getVehiculos()
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                var vehiculos = db.Vehiculos.Where(a => a.estado == "Rentado").ToList();
                cmbV.DataSource = vehiculos;
                cmbV.DisplayMember = "descripcion";
                cmbV.ValueMember = "id";
                cmbV.SelectedIndex = -1;
               
            }
        }
        public void gatEmpleados()
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                var emp = db.Empleados.Where(a => a.estado == "Activo").ToList();
                cmbE.DataSource = emp;
                cmbE.DisplayMember = "nombre";
                cmbE.ValueMember = "id";
                cmbE.SelectedIndex = -1;
               
            }
        }
        private void cmbC_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            using (RentcarEntities DB = new RentcarEntities())
            {
                var find = DB.Renta_devolucion.FirstOrDefault(a => a.id == modeloEdit.id);
                DB.Renta_devolucion.Remove(find);
                DB.SaveChanges();
                getRentaAndDevolucion();
                Limpiar();
            }
        }
    }
}
