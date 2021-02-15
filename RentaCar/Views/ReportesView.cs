using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentaCar.Views;
namespace RentaCar.Views
{
    public partial class ReportesView : Form
    {
        public ReportesView()
        {
            InitializeComponent();
        }

        private void ReportesView_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();

            InicioView frm = new InicioView();

            frm.Show();
        }

        private void btnMant_Click(object sender, EventArgs e)
        {
            this.Hide();

            ReporteEmpleadosView frm = new ReporteEmpleadosView();

            frm.Show();
        }

        private void btnServ_Click(object sender, EventArgs e)
        {
            this.Hide();

            ReporteClientes frm = new ReporteClientes();

            frm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Hide();

            ReporteRentaView frm = new ReporteRentaView();

            frm.Show();
        }
    }
}
