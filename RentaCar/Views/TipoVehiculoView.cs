
using RentaCar.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaCar.Views
{
    public partial class TipoVehiculoView : Form
    {

        Tipo_vehiculos modeloEdit = new Tipo_vehiculos();
        public TipoVehiculoView()
        {
            InitializeComponent();
            gatEstados();
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

        private void button1_Click(object sender, EventArgs e)
        {  
            Tipo_vehiculos modelo = new Tipo_vehiculos();
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
                    MessageBox.Show("Por favor, introduzca una descripción");
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
                             DB.Tipo_vehiculos.Add(modelo);
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void TipoVehiculoView_Load(object sender, EventArgs e)
        {
            FillDataGrid();
        }

        private void FillDataGrid()
        {
            dgvTipoVehiculo.AutoGenerateColumns = false;
            using (RentcarEntities db = new RentcarEntities())
            {
                dgvTipoVehiculo.DataSource = db.Tipo_vehiculos.ToList<Tipo_vehiculos>();
            }
        }

       
        private void dgvTipoVehiculo_DoubleClick(object sender, EventArgs e)
        {
            Tipo_vehiculos modelo = new Tipo_vehiculos();
            if(dgvTipoVehiculo.CurrentRow.Index != -1)
            {
                modeloEdit.id = Convert.ToInt32(dgvTipoVehiculo.CurrentRow.Cells["id"].Value);
                using(RentcarEntities db = new RentcarEntities())
                {
                    modelo = db.Tipo_vehiculos.Where(x => x.id == modeloEdit.id).FirstOrDefault();
                    txtDescripcion.Text = modelo.descripcion;
                    comboEstado.Text = modelo.estado;
                }
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
                        var modeloFind = db.Tipo_vehiculos.FirstOrDefault(a => a.id == modeloEdit.id);

                        if (modeloFind != null)
                        {
                            db.Tipo_vehiculos.Remove(modeloFind);
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

        private void Clean()
        {
            txtDescripcion.Text = "";
            comboEstado.Text = null;
        }
    }
}
