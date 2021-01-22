﻿namespace RentaCar.Views
{
    partial class RentaView
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.numDias = new System.Windows.Forms.NumericUpDown();
            this.dtpRenta = new System.Windows.Forms.DateTimePicker();
            this.dgvRenta = new System.Windows.Forms.DataGridView();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbE = new System.Windows.Forms.ComboBox();
            this.cmbC = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbMa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenta)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(321, 55);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 39);
            this.label7.TabIndex = 86;
            this.label7.Text = "Renta de vehículos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 215);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 97;
            this.label6.Text = "Monto por día";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 258);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 96;
            this.label5.Text = "Fecha de renta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 95;
            this.label4.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 280);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 94;
            this.label3.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 93;
            this.label2.Text = "Empleado ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(432, 159);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 20);
            this.label13.TabIndex = 98;
            this.label13.Text = " Cantidad de días";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(578, 212);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(138, 26);
            this.txtMonto.TabIndex = 106;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // numDias
            // 
            this.numDias.Location = new System.Drawing.Point(578, 157);
            this.numDias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numDias.Name = "numDias";
            this.numDias.Size = new System.Drawing.Size(66, 26);
            this.numDias.TabIndex = 111;
            // 
            // dtpRenta
            // 
            this.dtpRenta.Location = new System.Drawing.Point(578, 258);
            this.dtpRenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpRenta.Name = "dtpRenta";
            this.dtpRenta.Size = new System.Drawing.Size(268, 26);
            this.dtpRenta.TabIndex = 112;
            this.dtpRenta.ValueChanged += new System.EventHandler(this.dtpRenta_ValueChanged);
            // 
            // dgvRenta
            // 
            this.dgvRenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRenta.Location = new System.Drawing.Point(176, 526);
            this.dgvRenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvRenta.Name = "dgvRenta";
            this.dgvRenta.RowHeadersWidth = 62;
            this.dgvRenta.Size = new System.Drawing.Size(614, 231);
            this.dgvRenta.TabIndex = 113;
            this.dgvRenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRenta_CellContentClick);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(452, 332);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 35);
            this.btnAceptar.TabIndex = 115;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(578, 332);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 35);
            this.btnCancelar.TabIndex = 116;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // cmbE
            // 
            this.cmbE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbE.FormattingEnabled = true;
            this.cmbE.Location = new System.Drawing.Point(240, 218);
            this.cmbE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbE.Name = "cmbE";
            this.cmbE.Size = new System.Drawing.Size(138, 28);
            this.cmbE.TabIndex = 118;
            // 
            // cmbC
            // 
            this.cmbC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbC.FormattingEnabled = true;
            this.cmbC.Location = new System.Drawing.Point(240, 163);
            this.cmbC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbC.Name = "cmbC";
            this.cmbC.Size = new System.Drawing.Size(138, 28);
            this.cmbC.TabIndex = 119;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(242, 465);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 26);
            this.textBox1.TabIndex = 120;
            // 
            // cmbMa
            // 
            this.cmbMa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMa.FormattingEnabled = true;
            this.cmbMa.Location = new System.Drawing.Point(242, 277);
            this.cmbMa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMa.Name = "cmbMa";
            this.cmbMa.Size = new System.Drawing.Size(138, 28);
            this.cmbMa.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 332);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 122;
            this.label1.Text = "Modelo";
            // 
            // cmbMo
            // 
            this.cmbMo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMo.FormattingEnabled = true;
            this.cmbMo.Location = new System.Drawing.Point(240, 332);
            this.cmbMo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMo.Name = "cmbMo";
            this.cmbMo.Size = new System.Drawing.Size(138, 28);
            this.cmbMo.TabIndex = 123;
            // 
            // RentaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 799);
            this.Controls.Add(this.cmbMo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMa);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbC);
            this.Controls.Add(this.cmbE);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvRenta);
            this.Controls.Add(this.dtpRenta);
            this.Controls.Add(this.numDias);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RentaView";
            this.Text = "RentaView";
            this.Load += new System.EventHandler(this.RentaView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.NumericUpDown numDias;
        private System.Windows.Forms.DateTimePicker dtpRenta;
        private System.Windows.Forms.DataGridView dgvRenta;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbE;
        private System.Windows.Forms.ComboBox cmbC;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMo;
    }
}