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
    public partial class MantenimientosView : Form
    {
        public MantenimientosView()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MantenimientosView_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            ClienteView frm = new ClienteView();

            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            EmpleadoView frm = new EmpleadoView();

            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            VehiculosView frm = new VehiculosView();

            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            MarcasView frm = new MarcasView();

            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();

            ModelosView frm = new ModelosView();

            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();

            TipoVehiculoView frm = new TipoVehiculoView();

            frm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();

            TipoCombustibleView frm = new TipoCombustibleView();

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
