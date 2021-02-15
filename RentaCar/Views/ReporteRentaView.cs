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
    public partial class ReporteRentaView : Form
    {
        public ReporteRentaView()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

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

            ReportesView frm = new ReportesView();

            frm.Show();
        }

        private void ReporteRentaView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetRentas.RentaDatos' table. You can move, or remove it, as needed.
            this.rentaDatosTableAdapter.Fill(this.dataSetRentas.RentaDatos);
            // TODO: This line of code loads data into the 'dataSetRentas.Renta_devolucion' table. You can move, or remove it, as needed.
            //this.renta_devolucionTableAdapter.Fill(this.dataSetRentas.Renta_devolucion);

            this.reportViewer1.RefreshReport();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.rentaDatosTableAdapter.FillBy1(this.dataSetRentas.RentaDatos, clienteNombre.Text.ToString());
            this.reportViewer1.RefreshReport();
            //using (RentcarEntities db = new RentcarEntities())
            //{

            //    this.rentaDatosTableAdapter.Fill(this.dataSetRentas.RentaDatos);
            //    this.reportViewer1.RefreshReport();
            //}
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rentaDatosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rentaDatosTableAdapter.FillBy(this.dataSetRentas.RentaDatos, nombreToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rentaDatosTableAdapter.FillBy1(this.dataSetRentas.RentaDatos, nameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fillByFechaToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.rentaDatosTableAdapter.FillByFecha(this.dataSetRentas.RentaDatos, fecha1ToolStripTextBox.Text, fecha2ToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByFechaToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.rentaDatosTableAdapter.FillByFecha(this.dataSetRentas.RentaDatos, fecha1.Text.ToString(),fecha2.Text.ToString());
            this.reportViewer1.RefreshReport();
        }
    }
}
