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
        Renta_devolucion modeloEdit = new Renta_devolucion();
        public RentaView()
        {
            InitializeComponent();
            gatClientes();
            gatEmpleados();
            getVehiculos();
            getRentaAndDevolucion();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Renta_devolucion modelo = new Renta_devolucion();

                if (modeloEdit.id == 0)
                {
                    modelo.id_empleado = Int32.Parse(cmbE.SelectedValue.ToString());
                    modelo.id_cliente = Int32.Parse(cmbC.SelectedValue.ToString());
                    modelo.id_vehiculo = Int32.Parse(cmbV.SelectedValue.ToString());
                    modelo.fecha_devolucion = null;
                    modelo.fecha_renta = dtpRenta.Value;
                    modelo.monto_dia = Int32.Parse(txtMonto.Text);
                    modelo.total_dias = Int32.Parse(textBox2.Text);
                    modelo.comentario = null;
                    modelo.estado = "Rentado";
                }
                else {
                    modeloEdit.id_empleado = Int32.Parse(cmbE.SelectedValue.ToString());
                    modeloEdit.id_vehiculo = Int32.Parse(cmbV.SelectedValue.ToString());
                    modeloEdit.id_cliente = Int32.Parse(cmbC.SelectedValue.ToString());
                    modeloEdit.fecha_devolucion = null;
                    modeloEdit.fecha_renta = dtpRenta.Value;
                    modeloEdit.monto_dia = Int32.Parse(txtMonto.Text);
                    modeloEdit.total_dias = Int32.Parse(textBox2.Text);
                    modeloEdit.comentario = null;
                    modeloEdit.estado = "Rentado";
                }

                if (modelo.id_empleado <= 0)
                {
                    MessageBox.Show("Por favor, seleccione el empleado");
                    return;
                }
                if (txtMonto.Text == "")
                {
                    MessageBox.Show("Por favor, digite el monto");
                    return;
                }
                if (modelo.id_cliente <= 0)
                {
                    MessageBox.Show("Por favor, seleccione el cliente");
                    return;
                }
                if (modelo.total_dias <= 0)
                {
                    MessageBox.Show("Por favor, digite la cantidad de días");
                    return;
                }
                else
                {
                    using (RentcarEntities DB = new RentcarEntities())
                    {

                        var findVehiculo = DB.Vehiculos.FirstOrDefault(a => a.id == modelo.id_vehiculo);
                        if (modeloEdit.id == 0)
                        {
                            DB.Renta_devolucion.Add(modelo);
                            findVehiculo.estado = "Rentado";
                            DB.Entry(findVehiculo).State = System.Data.Entity.EntityState.Modified;
                        
                        }
                        else {
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

        public void getVehiculos() {
            using (RentcarEntities db = new RentcarEntities())
            {
                var vehiculos = db.Vehiculos.Where(a => a.estado != "Rentado").ToList();
                cmbV.DataSource = vehiculos;
                cmbV.DisplayMember = "descripcion";
                cmbV.ValueMember = "id";
                cmbV.SelectedIndex = -1;
                
            }
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
                cmbE.DataSource = emp;
                cmbE.DisplayMember = "nombre";
                cmbE.ValueMember = "id";
                cmbE.SelectedIndex = -1;
                
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


      



        private void RentaView_Load(object sender, EventArgs e)
        {

        }

        private void dgvRenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpRenta_ValueChanged(object sender, EventArgs e)
        {

        }

        public void getRentaAndDevolucion() {
            using (RentcarEntities db = new RentcarEntities())
            {
                var list = db.Renta_devolucion.ToList();
                if (dgvRenta.Columns.Count <= 0)
                {
                    dgvRenta.Columns.Add("id", "Id");
                    dgvRenta.Columns.Add("Empleado", "Empleado");
                    dgvRenta.Columns.Add("Vehiculo", "Vehiculo");
                    dgvRenta.Columns.Add("Cliente", "Cliente");
                    dgvRenta.Columns.Add("FechaRenta", "Fecha renta");
                    dgvRenta.Columns.Add("MontoDia", "Monto por dia");
                    dgvRenta.Columns.Add("totaldias", "Total por dias");
                }
                if (dgvRenta.Columns.Count > 0)
                {
                    dgvRenta.Rows.Clear();
                    dgvRenta.Refresh();
                }
                foreach (var a in list)
                {
                    dgvRenta.Rows.Add(a.id, a.Empleados.nombre, a.Vehiculos.descripcion, a.Clientes.nombre,
                        a.fecha_renta,a.monto_dia,a.total_dias);
                }
                
            }
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
            using (RentcarEntities DB = new RentcarEntities()){
                var find = DB.Renta_devolucion.FirstOrDefault(a => a.id == modeloEdit.id);
                DB.Renta_devolucion.Remove(find);
                DB.SaveChanges();
                getRentaAndDevolucion();
                Limpiar();
                MessageBox.Show("Se ha eliminado la información correctamente");
            }
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

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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
                textBox2.Text = modelo.total_dias.ToString();
                txtMonto.Text = modelo.monto_dia.ToString();
                dtpRenta.Text = modelo.fecha_renta.ToString();

            }
        }

        private void cmbE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Limpiar() {
            modeloEdit.id = 0;
            cmbE.SelectedIndex = -1;
            cmbV.SelectedIndex = -1;
            cmbC.SelectedIndex = -1;
            dtpRenta = new DateTimePicker();
            txtMonto.Text = "";
            textBox2.Text = "";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
