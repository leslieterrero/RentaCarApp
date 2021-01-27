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
    public partial class MarcasView : Form
    {
        Marcas modeloEdit = new Marcas();
        
        public MarcasView()
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
                    cmbEstado.Items.Add(a.nombre);
                }
            }
        }
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Marcas modelo = new Marcas();
            try
            {
                modelo.descripcion = txtdescripcion.Text.Trim();
                modelo.estado = cmbEstado.Text.ToString();
                if (modeloEdit.id != 0)
                {
                    modeloEdit.descripcion = txtdescripcion.Text.Trim();
                    modeloEdit.estado = cmbEstado.Text.ToString();
                }

                if (txtdescripcion.Text == "")
                {
                    MessageBox.Show("Por favor, especifique una descripción");
                }
                if (cmbEstado.Text == "")
                {
                    MessageBox.Show("Por favor, introduzca un estado");
                }

                else
                {
                    using (RentcarEntities DB = new RentcarEntities())
                    {
                        if (modeloEdit.id == 0)
                        {
                            DB.Marcas.Add(modelo);
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

        private void Clean()
        {
            txtdescripcion.Text = "";
            cmbEstado.Text = null;
        }

        private void FillDataGrid()
        {
            dgvMarcas.AutoGenerateColumns = false;
            using (RentcarEntities db = new RentcarEntities())
            {
                dgvMarcas.DataSource = db.Marcas.ToList<Marcas>();
            }
        }

        
        private void dgvMarcas_DoubleClick(object sender, EventArgs e)
        {
            Marcas modelo = new Marcas();
            if (dgvMarcas.CurrentRow.Index != -1)
            {
                modeloEdit.id = Convert.ToInt32(dgvMarcas.CurrentRow.Cells["id"].Value);
                using (RentcarEntities db = new RentcarEntities())
                {
                    modelo = db.Marcas.Where(x => x.id == modeloEdit.id).FirstOrDefault();
                    txtdescripcion.Text = modelo.descripcion;
                    cmbEstado.Text = modelo.estado;

                }
            }
        }

        private void MarcasView_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Marcas modelo = new Marcas();
            if (MessageBox.Show("Estás seguro que quieres eliminar esa información?", "Borrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (RentcarEntities db = new RentcarEntities())
                {
                    if (modeloEdit.id != 0)
                    {
                        var modeloFind = db.Marcas.FirstOrDefault(a => a.id == modeloEdit.id);

                        if (modeloFind != null)
                        {
                            db.Marcas.Remove(modeloFind);
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
       
        private void button3_Click(object sender, EventArgs e)
        {
            Clean();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
