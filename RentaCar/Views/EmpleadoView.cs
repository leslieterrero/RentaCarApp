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
    public partial class EmpleadoView : Form
    {
        Empleados modeloEdit = new Empleados();
        public EmpleadoView()
        {
            InitializeComponent();
            FillDataGrid();
            gatEstados();
        }

        public void gatEstados()
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                var marcas = db.Estados.Where(a => a.id == 3 | a.id == 4).ToList();
                foreach (var a in marcas)
                {
                    cmbEstado.Items.Add(a.nombre);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Empleados modelo = new Empleados();
            try
            {
                var cedula = txtCedula.Text.Trim();
                var respuesta = validaCedula(cedula);
                if (respuesta == false)
                {
                    MessageBox.Show("Cédula no válida");
                    return;
                }
                modelo.nombre = txtNombre.Text.Trim();
                modelo.cedula = cedula;
                modelo.porciento_comision = txtComision.Text.Trim();
                modelo.tanda_laboral = cmbTanda.Text.ToString();
                modelo.estado = cmbEstado.Text.ToString();
                modelo.fecha_ingreso = dtIngreso.Value;
                if (modeloEdit.id != 0)
                {
                    modeloEdit.nombre = txtNombre.Text.Trim();
                    modeloEdit.cedula = txtCedula.Text.Trim();
                    modeloEdit.porciento_comision = txtComision.Text.Trim();
                    modeloEdit.tanda_laboral = cmbTanda.Text.ToString();
                    modeloEdit.estado = cmbEstado.Text.ToString();
                    modeloEdit.fecha_ingreso = dtIngreso.Value;
                }

                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Por favor, digite el nombre");
                    return;
                }
                if (txtCedula.Text == "")
                {
                    MessageBox.Show("Por favor, digite la cédula");
                    return;
                }
                if (txtComision.Text == "")
                {
                    MessageBox.Show("Por favor, digite la comisión");
                    return;

                }
                if (cmbEstado.Text == "")
                {
                    MessageBox.Show("Por favor, seleccione un estado");
                    return;
                }
                if (cmbTanda.Text == "")
                {
                    MessageBox.Show("Por favor, seleccione una tanda");
                    return;
                }
                else
                {
                    using (RentcarEntities DB = new RentcarEntities())
                    {
                        if (modeloEdit.id == 0)
                        {
                            DB.Empleados.Add(modelo);
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
        private void FillDataGrid()
        {
            dgvEmpleados.AutoGenerateColumns = false;
            using (RentcarEntities db = new RentcarEntities())
            {
                dgvEmpleados.DataSource = db.Empleados.ToList<Empleados>();
            }
        }

        private void dgvEmpleados_DoubleClick(object sender, EventArgs e)
        {
            Empleados modelo = new Empleados();
            if (dgvEmpleados.CurrentRow.Index != -1)
            {
                modeloEdit.id = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells["id"].Value);
                using (RentcarEntities db = new RentcarEntities())
                {
                    modelo = db.Empleados.Where(x => x.id == modeloEdit.id).FirstOrDefault();
                    txtNombre.Text = modelo.nombre;
                    txtCedula.Text = modelo.cedula;
                    cmbTanda.Text = modelo.tanda_laboral;
                    txtComision.Text = modelo.porciento_comision;
                    cmbEstado.Text = modelo.estado;
                    dtIngreso.Value = modelo.fecha_ingreso;


                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clean()
        {
            txtNombre.Text = txtCedula.Text = txtComision.Text = "";
            cmbTanda.Text = null;
           
            cmbTanda.Text = null;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Empleados modelo = new Empleados();
            if (MessageBox.Show("Estás seguro que quieres eliminar esa información?", "Borrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (RentcarEntities db = new RentcarEntities())
                {
                    if (modeloEdit.id != 0)
                    {
                        var modeloFind = db.Empleados.FirstOrDefault(a => a.id == modeloEdit.id);

                        if (modeloFind != null)
                        {
                            db.Empleados.Remove(modeloFind);
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void EmpleadoView_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtComision_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtIngreso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTanda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
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

        public static bool validaCedula(string pCedula)

        {
            int vnTotal = 0;
            string vcCedula = pCedula.Replace("-", "");
            int pLongCed = vcCedula.Trim().Length;
            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };

            if (pLongCed < 11 || pLongCed > 11)
                return false;

            for (int vDig = 1; vDig <= pLongCed; vDig++)
            {
                int vCalculo = Int32.Parse(vcCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                if (vCalculo < 10)
                    vnTotal += vCalculo;
                else
                    vnTotal += Int32.Parse(vCalculo.ToString().Substring(0, 1)) + Int32.Parse(vCalculo.ToString().Substring(1, 1));
            }

            if (vnTotal % 10 == 0)
                return true;
            else
                return false;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
