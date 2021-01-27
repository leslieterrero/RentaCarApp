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
    public partial class ModelosView : Form
    {
        Modelos modeloEdit = new Modelos();
        int indexToUpdate = 0;
        public ModelosView()
        {
            InitializeComponent();
            gatMarcas();
            gatEstados();
        }

        public void gatMarcas() {
            using (RentcarEntities db = new RentcarEntities()) {
                var marcas = db.Marcas.ToList();
                foreach (var a in marcas) {
                    MarcaSelect.Items.Add(a.descripcion);
                }
            }

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modelos modelo = new Modelos();
            try
            {
                modelo.descripcion = txtdescripcion.Text.Trim();
                modelo.estado = cmbEstado.Text.ToString();
                var marcas = new List<Marcas>();
                var index = MarcaSelect.SelectedIndex;
                using (RentcarEntities db = new RentcarEntities())
                {
                    marcas = db.Marcas.ToList();
                }
                modelo.id_marca = marcas[index].id;
                if (modeloEdit.id != 0) {
                    modeloEdit.descripcion = txtdescripcion.Text.Trim();
                    modeloEdit.estado = cmbEstado.Text.ToString();
                    modeloEdit.id_marca = marcas[index].id;
                    modeloEdit.Marcas = null;
                    modeloEdit.Vehiculos = null;
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
                            DB.Modelos.Add(modelo);
                            DB.SaveChanges();
                        }
                        else
                        {
                            DB.Entry(modeloEdit).State = System.Data.Entity.EntityState.Modified;
                        }

                        DB.SaveChanges();
                    }
                    if (modeloEdit.id != 0) {
                        updateRow(modeloEdit.id);
                        modeloEdit.id = 0;
                    } else {
                        addToTable(modelo.id);
                    }
                    //FillDataGrid();
                    Clean();

                    MessageBox.Show("La información ha sido guardada con éxito!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        public void addToTable(int id) {
            using (RentcarEntities db = new RentcarEntities())
            {
                var mymodel = db.Modelos.FirstOrDefault(a => a.id == id);
                tabla.Rows.Add(mymodel.id, mymodel.Marcas.descripcion, mymodel.descripcion, mymodel.estado);
            }
        }

        public void updateRow(int id) {
            using (RentcarEntities db = new RentcarEntities())
            {
                var actualizado = db.Modelos.FirstOrDefault(a => a.id == id);
                DataGridViewRow newDataRow = tabla.Rows[indexToUpdate];
                newDataRow.Cells[1].Value = actualizado.Marcas.descripcion;
                newDataRow.Cells[2].Value = actualizado.descripcion;
                newDataRow.Cells[3].Value = actualizado.estado;

            }
        }
        private void FillDataGrid()
        {
            tabla.AutoGenerateColumns = false;
            using (RentcarEntities db = new RentcarEntities())
            {
                //if (tabla.Rows.Count > 0) {
                //    tabla.Rows.Clear();
                //}
                if (tabla.Columns.Count <= 0) {
                    tabla.Columns.Add("id", "id");
                    tabla.Columns.Add("Marca", "Marca");
                    tabla.Columns.Add("Descripcion", "Descripcion");
                    tabla.Columns.Add("Estado", "Estado");
                }
                var list = db.Modelos.ToList<Modelos>();
                foreach (var a in list) {
                    tabla.Rows.Add(a.id,a.Marcas.descripcion, a.descripcion, a.estado);
                }
                //tabla.Refresh();
                //dgvModelos.DataSource = db.Modelos.ToList<Modelos>();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ModelosView_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modelos modelo = new Modelos();
            if (MessageBox.Show("Estás seguro que quieres eliminar esa información?", "Borrar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (RentcarEntities db = new RentcarEntities())
                {
                    var entry = db.Entry(modelo);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                    {
                        db.Modelos.Attach(modelo);
                        db.Modelos.Remove(modelo);
                        db.SaveChanges(); /* no funciona*/
                        FillDataGrid();
                        Clean();
                        MessageBox.Show("Se ha eliminado la información correctamente");
                    }
                }

            }
        }

        private void Clean()
        {
            txtdescripcion.Text = "";
            cmbEstado.SelectedIndex = 0;
            MarcaSelect.SelectedIndex = 0;
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabla_DoubleClick(object sender, EventArgs e)
        {
            if (tabla.CurrentRow.Index != -1)
            {
                indexToUpdate = tabla.CurrentRow.Index;
                modeloEdit.id = Convert.ToInt32(tabla.CurrentRow.Cells["id"].Value);
                using (RentcarEntities db = new RentcarEntities())
                {
                    modeloEdit = db.Modelos.Where(x => x.id == modeloEdit.id).FirstOrDefault();
                    txtdescripcion.Text = modeloEdit.descripcion;
                    cmbEstado.Text = modeloEdit.estado;
                    var getMarca = db.Marcas.FirstOrDefault(a => a.id == modeloEdit.id_marca);
                    MarcaSelect.SelectedIndex = MarcaSelect.Items.IndexOf(getMarca.descripcion);

                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
