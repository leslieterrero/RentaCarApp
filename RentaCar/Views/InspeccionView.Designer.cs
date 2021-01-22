namespace RentaCar.Views
{
    partial class InspeccionView
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbRalladura = new System.Windows.Forms.CheckBox();
            this.cbGomaRep = new System.Windows.Forms.CheckBox();
            this.cbGato = new System.Windows.Forms.CheckBox();
            this.cbCristal = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbCombustible = new System.Windows.Forms.ComboBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvInspeccion = new System.Windows.Forms.DataGridView();
            this.cmbEmp = new System.Windows.Forms.ComboBox();
            this.cmbC = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbV = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspeccion)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(404, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(365, 39);
            this.label7.TabIndex = 85;
            this.label7.Text = "Inspección de vehículos";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 88;
            this.label3.Text = "Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 337);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 20);
            this.label5.TabIndex = 90;
            this.label5.Text = "Cantidad de combustible";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(642, 111);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(140, 20);
            this.label10.TabIndex = 94;
            this.label10.Text = "Defecto de gomas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(87, 394);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 20);
            this.label11.TabIndex = 95;
            this.label11.Text = "Fecha de inspección";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(167, 279);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 20);
            this.label12.TabIndex = 96;
            this.label12.Text = "Empleado";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(182, 451);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 20);
            this.label13.TabIndex = 97;
            this.label13.Text = "Estado";
            // 
            // cbRalladura
            // 
            this.cbRalladura.AutoSize = true;
            this.cbRalladura.Location = new System.Drawing.Point(645, 308);
            this.cbRalladura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbRalladura.Name = "cbRalladura";
            this.cbRalladura.Size = new System.Drawing.Size(111, 24);
            this.cbRalladura.TabIndex = 98;
            this.cbRalladura.Text = "Ralladuras";
            this.cbRalladura.UseVisualStyleBackColor = true;
            // 
            // cbGomaRep
            // 
            this.cbGomaRep.AutoSize = true;
            this.cbGomaRep.Location = new System.Drawing.Point(645, 358);
            this.cbGomaRep.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbGomaRep.Name = "cbGomaRep";
            this.cbGomaRep.Size = new System.Drawing.Size(168, 24);
            this.cbGomaRep.TabIndex = 99;
            this.cbGomaRep.Text = "Goma de repuesto";
            this.cbGomaRep.UseVisualStyleBackColor = true;
            // 
            // cbGato
            // 
            this.cbGato.AutoSize = true;
            this.cbGato.Location = new System.Drawing.Point(824, 362);
            this.cbGato.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbGato.Name = "cbGato";
            this.cbGato.Size = new System.Drawing.Size(71, 24);
            this.cbGato.TabIndex = 100;
            this.cbGato.Text = "Gato";
            this.cbGato.UseVisualStyleBackColor = true;
            // 
            // cbCristal
            // 
            this.cbCristal.AutoSize = true;
            this.cbCristal.Location = new System.Drawing.Point(824, 308);
            this.cbCristal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbCristal.Name = "cbCristal";
            this.cbCristal.Size = new System.Drawing.Size(111, 24);
            this.cbCristal.TabIndex = 101;
            this.cbCristal.Text = "Cristal roto";
            this.cbCristal.UseVisualStyleBackColor = true;
            this.cbCristal.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(256, 388);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(267, 26);
            this.dateTimePicker1.TabIndex = 102;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(256, 443);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(148, 28);
            this.cmbEstado.TabIndex = 104;
            // 
            // cmbCombustible
            // 
            this.cmbCombustible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCombustible.FormattingEnabled = true;
            this.cmbCombustible.Items.AddRange(new object[] {
            "1/4",
            "2/4",
            "3/4",
            "lleno"});
            this.cmbCombustible.Location = new System.Drawing.Point(256, 329);
            this.cmbCombustible.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCombustible.Name = "cmbCombustible";
            this.cmbCombustible.Size = new System.Drawing.Size(148, 28);
            this.cmbCombustible.TabIndex = 105;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(646, 157);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(167, 24);
            this.checkBox5.TabIndex = 106;
            this.checkBox5.Text = "Delantera derecha";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(826, 157);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(173, 24);
            this.checkBox6.TabIndex = 107;
            this.checkBox6.Text = "Delantera izquierda";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(646, 200);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(151, 24);
            this.checkBox7.TabIndex = 108;
            this.checkBox7.Text = "Trasera derecha";
            this.checkBox7.UseVisualStyleBackColor = true;
            this.checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(826, 200);
            this.checkBox8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(157, 24);
            this.checkBox8.TabIndex = 109;
            this.checkBox8.Text = "Trasera izquierda";
            this.checkBox8.UseVisualStyleBackColor = true;
            this.checkBox8.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(644, 257);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 112;
            this.label4.Text = "Defectos";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dgvInspeccion
            // 
            this.dgvInspeccion.AllowUserToDeleteRows = false;
            this.dgvInspeccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInspeccion.Location = new System.Drawing.Point(645, 429);
            this.dgvInspeccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvInspeccion.Name = "dgvInspeccion";
            this.dgvInspeccion.ReadOnly = true;
            this.dgvInspeccion.RowHeadersWidth = 62;
            this.dgvInspeccion.Size = new System.Drawing.Size(380, 231);
            this.dgvInspeccion.TabIndex = 113;
            this.dgvInspeccion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cmbEmp
            // 
            this.cmbEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmp.FormattingEnabled = true;
            this.cmbEmp.Location = new System.Drawing.Point(256, 271);
            this.cmbEmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbEmp.Name = "cmbEmp";
            this.cmbEmp.Size = new System.Drawing.Size(148, 28);
            this.cmbEmp.TabIndex = 114;
            // 
            // cmbC
            // 
            this.cmbC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbC.FormattingEnabled = true;
            this.cmbC.Location = new System.Drawing.Point(256, 155);
            this.cmbC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbC.Name = "cmbC";
            this.cmbC.Size = new System.Drawing.Size(148, 28);
            this.cmbC.TabIndex = 115;
            this.cmbC.SelectedIndexChanged += new System.EventHandler(this.cmbC_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 216);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 116;
            this.label1.Text = "Vehiculo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbV
            // 
            this.cmbV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbV.FormattingEnabled = true;
            this.cmbV.Location = new System.Drawing.Point(256, 216);
            this.cmbV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbV.Name = "cmbV";
            this.cmbV.Size = new System.Drawing.Size(148, 28);
            this.cmbV.TabIndex = 117;
            this.cmbV.ValueMemberChanged += new System.EventHandler(this.cmbV_ValueMemberChanged);
            this.cmbV.SelectedValueChanged += new System.EventHandler(this.cmbV_SelectedValueChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(411, 536);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(112, 35);
            this.btnLimpiar.TabIndex = 120;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(270, 536);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 35);
            this.btnEliminar.TabIndex = 119;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(130, 536);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 35);
            this.btnAgregar.TabIndex = 118;
            this.btnAgregar.Text = "GUARDAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // InspeccionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 883);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cmbV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbC);
            this.Controls.Add(this.cmbEmp);
            this.Controls.Add(this.dgvInspeccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.cmbCombustible);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbCristal);
            this.Controls.Add(this.cbGato);
            this.Controls.Add(this.cbGomaRep);
            this.Controls.Add(this.cbRalladura);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InspeccionView";
            this.Text = "InspeccionView";
            this.Load += new System.EventHandler(this.InspeccionView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInspeccion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox cbRalladura;
        private System.Windows.Forms.CheckBox cbGomaRep;
        private System.Windows.Forms.CheckBox cbGato;
        private System.Windows.Forms.CheckBox cbCristal;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbCombustible;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvInspeccion;
        private System.Windows.Forms.ComboBox cmbEmp;
        private System.Windows.Forms.ComboBox cmbC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbV;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
    }
}