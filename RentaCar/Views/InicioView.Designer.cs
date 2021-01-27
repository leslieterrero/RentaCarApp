
namespace RentaCar.Views
{
    partial class InicioView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMant = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.btnServ = new System.Windows.Forms.Button();
            this.pnlServ = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.pnlMant = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlServ.SuspendLayout();
            this.pnlMant.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMant
            // 
            this.btnMant.Location = new System.Drawing.Point(0, 0);
            this.btnMant.Name = "btnMant";
            this.btnMant.Size = new System.Drawing.Size(216, 43);
            this.btnMant.TabIndex = 0;
            this.btnMant.Text = "Manteniemtos";
            this.btnMant.UseVisualStyleBackColor = true;
            this.btnMant.Click += new System.EventHandler(this.btnMant_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.btnServ);
            this.panel1.Controls.Add(this.pnlServ);
            this.panel1.Controls.Add(this.btnMant);
            this.panel1.Controls.Add(this.pnlMant);
            this.panel1.Location = new System.Drawing.Point(0, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 504);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(0, 461);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(216, 43);
            this.button13.TabIndex = 5;
            this.button13.Text = "Reportes";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // btnServ
            // 
            this.btnServ.Location = new System.Drawing.Point(0, 306);
            this.btnServ.Name = "btnServ";
            this.btnServ.Size = new System.Drawing.Size(216, 43);
            this.btnServ.TabIndex = 3;
            this.btnServ.Text = "Servicios";
            this.btnServ.UseVisualStyleBackColor = true;
            this.btnServ.Click += new System.EventHandler(this.btnServ_Click);
            // 
            // pnlServ
            // 
            this.pnlServ.Controls.Add(this.button12);
            this.pnlServ.Controls.Add(this.button10);
            this.pnlServ.Controls.Add(this.button11);
            this.pnlServ.Location = new System.Drawing.Point(4, 346);
            this.pnlServ.Name = "pnlServ";
            this.pnlServ.Size = new System.Drawing.Size(212, 116);
            this.pnlServ.TabIndex = 4;
            this.pnlServ.Visible = false;
            this.pnlServ.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(-4, 76);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(216, 43);
            this.button12.TabIndex = 3;
            this.button12.Text = "Inspección de vehículos";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(-4, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(216, 43);
            this.button10.TabIndex = 1;
            this.button10.Text = "Renta de vehículos";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(-4, 40);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(216, 43);
            this.button11.TabIndex = 2;
            this.button11.Text = "Devolución de vehículos";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // pnlMant
            // 
            this.pnlMant.Controls.Add(this.button8);
            this.pnlMant.Controls.Add(this.button2);
            this.pnlMant.Controls.Add(this.button7);
            this.pnlMant.Controls.Add(this.button6);
            this.pnlMant.Controls.Add(this.button5);
            this.pnlMant.Controls.Add(this.button4);
            this.pnlMant.Controls.Add(this.button3);
            this.pnlMant.Location = new System.Drawing.Point(3, 39);
            this.pnlMant.Name = "pnlMant";
            this.pnlMant.Size = new System.Drawing.Size(213, 268);
            this.pnlMant.TabIndex = 2;
            this.pnlMant.Visible = false;
            this.pnlMant.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(-3, 229);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(216, 43);
            this.button8.TabIndex = 7;
            this.button8.Text = "Tipos de combustible";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-3, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Clientes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(-3, 190);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(216, 43);
            this.button7.TabIndex = 6;
            this.button7.Text = "Tipos de vehículos";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(-3, 150);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(216, 43);
            this.button6.TabIndex = 5;
            this.button6.Text = "Modelos";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(-3, 111);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(216, 43);
            this.button5.TabIndex = 4;
            this.button5.Text = "Marcas";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(-3, 73);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(216, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "Vehículos";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(-3, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(216, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "Empleados";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // InicioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 703);
            this.Controls.Add(this.panel1);
            this.Name = "InicioView";
            this.Text = "InicioView";
            this.Load += new System.EventHandler(this.InicioView_Load);
            this.panel1.ResumeLayout(false);
            this.pnlServ.ResumeLayout(false);
            this.pnlMant.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMant;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMant;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnServ;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Panel pnlServ;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
    }
}