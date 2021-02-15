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
    public partial class ServiciosView : Form
    {
        public ServiciosView()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();

            InicioView frm = new InicioView();

            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();

            RentaView frm = new RentaView();

            frm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();

            DevolucionView frm = new DevolucionView();

            frm.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();

            InspeccionView frm = new InspeccionView();

            frm.Show();
        }

        private void ServiciosView_Load(object sender, EventArgs e)
        {

        }
    }
}
