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
    public partial class TipoCombustibleView : Form
    {
        Tipos_combustible modeloEdit = new Tipos_combustible();
        public TipoCombustibleView()
        {
            InitializeComponent();
            FillDataGrid();
            gatEstados();

        }

        private void TipoCombustibleView_Load(object sender, EventArgs e)
        {

        }

        public void gatEstados()
        {
            using (RentcarEntities db = new RentcarEntities())
            {
                var est = db.Estados.Where(a => a.id == 3 | a.id == 4).ToList();
                foreach (var a in est)
                {
                    comboEstado.Items.Add(a.nombre);
                }
            }
        }

        private void dgvTipoCombustible_DoubleClick(object sender, EventArgs e)
        {
            Tipos_combustible modelo = new Tipos_combustible();
            if (dgvTipoCombustible.CurrentRow.Index != -1)
            {
                modeloEdit.id = Convert.ToInt32(dgvTipoCombustible.CurrentRow.Cells["id"].Value);
                using (RentcarEntities db = new RentcarEntities())
                {
                    modelo = db.Tipos_combustible.Where(x => x.id == modeloEdit.id).FirstOrDefault();
                    txtDescripcion.Text = modelo.descripcion;
                    comboEstado.Text = modelo.estado;
                }
            }
        }
        private void FillDataGrid()
        {
            dgvTipoCombustible.AutoGenerateColumns = false;
            using (RentcarEntities db = new RentcarEntities())
            {
                dgvTipoCombustible.DataSource = db.Tipos_combustible.ToList<Tipos_combustible>();
            }
        }

        private void Clean()
        {
            txtDescripcion.Text = "";
            comboEstado.Text = null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Tipos_combustible modelo = new Tipos_combustible();
            try
            {
                modelo.descripcion = txtDescripcion.Text.Trim();
                modelo.estado = comboEstado.Text.ToString();
                if (modeloEdit.id != 0)
                {
                    modeloEdit.descripcion = txtDescripcion.Text.Trim();
                    modeloEdit.estado = comboEstado.Text.ToString();
                }


                if (txtDescripcion.Text == "")
                {
                    MessageBox.Show("Por favor, especifique una descripción");
                }
                if (comboEstado.Text == "")
                {
                    MessageBox.Show("Por favor, introduzca un estado");
                }

                else
                {
                    using (RentcarEntities DB = new RentcarEntities())
                    {
                        if (modeloEdit.id == 0)
                        {
                            DB.Tipos_combustible.Add(modelo);
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estás seguro que quieres eliminar esa información?", "Borrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (RentcarEntities db = new RentcarEntities())
                {

                    if (modeloEdit.id != 0)
                    {
                        var modeloFind = db.Tipos_combustible.FirstOrDefault(a => a.id == modeloEdit.id);

                        if (modeloFind != null)
                        {
                            db.Tipos_combustible.Remove(modeloFind);
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dgvTipoCombustible_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void label8_Click(object sender, EventArgs e)
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
    }
}
