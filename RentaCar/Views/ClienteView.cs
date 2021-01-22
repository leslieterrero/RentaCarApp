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

    public partial class ClienteView : Form
    {
        Clientes modeloEdit = new Clientes();
   



        public ClienteView()
        {
            InitializeComponent();
            gatEstados();
        }


        public void gatEstados()
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                var marcas = db.Estados.Where(a => a.id == 3 | a.id == 4).ToList();
                foreach (var a in marcas)
                {
                    comboBoxEstado.Items.Add(a.nombre);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ClienteView_Load(object sender, EventArgs e)
        {
            
                FillDataGrid();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Clientes modelo = new Clientes();
            try {
                modelo.nombre = txtNombre.Text.Trim();
                modelo.cedula = txtCedula.Text.Trim();
                modelo.no_tarjeta_cr = txtNoCred.Text.Trim();
                modelo.limite_credito = txtLimCred.Text.Trim();
                modelo.tipo_persona = comboBoxPersona.Text.ToString();
                modelo.estado = comboBoxEstado.Text.ToString();
                if (modeloEdit.id != 0)
                {
                    modeloEdit.nombre = txtNombre.Text.Trim();
                    modeloEdit.cedula = txtCedula.Text.Trim();
                    modeloEdit.no_tarjeta_cr = txtNoCred.Text.Trim();
                    modeloEdit.limite_credito = txtLimCred.Text.Trim();
                    modeloEdit.tipo_persona = comboBoxPersona.Text.ToString();
                    modeloEdit.estado = comboBoxEstado.Text.ToString();
                }
                if (txtNombre.Text == "" )
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
                }
                else
                {

                    using (RentcarEntities DB = new RentcarEntities())
                    {
                        if (modeloEdit.id == 0)
                        {
                            DB.Clientes.Add(modelo);
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
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clean()
        {
            txtNombre.Text = txtCedula.Text = txtLimCred.Text = txtNoCred.Text = "";
            comboBoxPersona.SelectedItem = null;
            comboBoxEstado.SelectedItem = null;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Clean();
        }


        private void FillDataGrid()
        {
            dgvClientes.AutoGenerateColumns = false;
            using (RentcarEntities db = new RentcarEntities())
            {
                dgvClientes.DataSource = db.Clientes.ToList<Clientes>();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Clientes modelo = new Clientes();
            if (MessageBox.Show("Estás seguro que quieres eliminar esa información?", "Borrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (RentcarEntities db = new RentcarEntities())
                {
                    if (modeloEdit.id != 0) {
                        var modeloFind = db.Clientes.FirstOrDefault(a => a.id == modeloEdit.id);
                       
                        if (modeloFind != null)
                        {
                            db.Clientes.Remove(modeloFind);
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

        private void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
            Clientes modelo = new Clientes();
            if (dgvClientes.CurrentRow.Index != -1)
            {
                modeloEdit.id = Convert.ToInt32(dgvClientes.CurrentRow.Cells["id"].Value);
                using (RentcarEntities db = new RentcarEntities())
                {
                    modelo = db.Clientes.Where(x => x.id == modeloEdit.id).FirstOrDefault();
                    txtNombre.Text = modelo.nombre;
                    txtCedula.Text = modelo.cedula;
                    txtNoCred.Text = modelo.no_tarjeta_cr;
                    txtLimCred.Text = modelo.limite_credito;
                    comboBoxPersona.Text = modelo.tipo_persona;
                    comboBoxEstado.Text = modelo.estado;
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNoCred_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
