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
    public partial class InicioView : Form
    {
        public InicioView()
        {
            InitializeComponent();
        }

        private void HideSubMenu()
        {
            if(pnlMant.Visible == true)
            {
                pnlMant.Visible = false;
            }
            if (pnlServ.Visible == true)
            {
                pnlServ.Visible = false;
            }
        } 

        private void ShowSubMenu(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void InicioView_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // code
            HideSubMenu();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            // code
            HideSubMenu();
        }

        private void btnMant_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlMant);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // code
            HideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // code
            HideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // code
            HideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // code
            HideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // code
            HideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // code
            HideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // code
            HideSubMenu();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // code
            HideSubMenu();
        }

        private void btnServ_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlServ);
        }
    }
}
