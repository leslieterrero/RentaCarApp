
namespace RentaCar.Views
{
    partial class ReporteRentaView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteRentaView));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rentaDatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRentas = new RentaCar.DataSetRentas();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.fecha1 = new System.Windows.Forms.DateTimePicker();
            this.clienteNombre = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.fecha2 = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rentadevolucionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.renta_devolucionTableAdapter = new RentaCar.DataSetRentasTableAdapters.Renta_devolucionTableAdapter();
            this.rentaDatosTableAdapter = new RentaCar.DataSetRentasTableAdapters.RentaDatosTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.nombreToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nombreToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.nameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.nameToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByFechaToolStrip = new System.Windows.Forms.ToolStrip();
            this.fecha1ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.fecha1ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fecha2ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.fecha2ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByFechaToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.rentaDatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentas)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentadevolucionBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.fillBy1ToolStrip.SuspendLayout();
            this.fillByFechaToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // rentaDatosBindingSource
            // 
            this.rentaDatosBindingSource.DataMember = "RentaDatos";
            this.rentaDatosBindingSource.DataSource = this.dataSetRentasBindingSource;
            this.rentaDatosBindingSource.CurrentChanged += new System.EventHandler(this.rentaDatosBindingSource_CurrentChanged);
            // 
            // dataSetRentasBindingSource
            // 
            this.dataSetRentasBindingSource.DataSource = this.dataSetRentas;
            this.dataSetRentasBindingSource.Position = 0;
            // 
            // dataSetRentas
            // 
            this.dataSetRentas.DataSetName = "DataSetRentas";
            this.dataSetRentas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(931, 100);
            this.panel2.TabIndex = 147;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(825, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 55);
            this.pictureBox2.TabIndex = 113;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 55);
            this.pictureBox1.TabIndex = 112;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SeaShell;
            this.label7.Location = new System.Drawing.Point(356, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 47);
            this.label7.TabIndex = 111;
            this.label7.Text = "RENTAS";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetRent";
            reportDataSource1.Value = this.rentaDatosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RentaCar.ReportRentas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(48, 300);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(815, 385);
            this.reportViewer1.TabIndex = 148;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // fecha1
            // 
            this.fecha1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.fecha1.Location = new System.Drawing.Point(133, 211);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(273, 26);
            this.fecha1.TabIndex = 149;
            this.fecha1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // clienteNombre
            // 
            this.clienteNombre.Location = new System.Drawing.Point(133, 148);
            this.clienteNombre.Name = "clienteNombre";
            this.clienteNombre.Size = new System.Drawing.Size(273, 26);
            this.clienteNombre.TabIndex = 151;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.button2.Location = new System.Drawing.Point(425, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 33);
            this.button2.TabIndex = 154;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fecha2
            // 
            this.fecha2.Location = new System.Drawing.Point(509, 210);
            this.fecha2.Name = "fecha2";
            this.fecha2.Size = new System.Drawing.Size(273, 26);
            this.fecha2.TabIndex = 155;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.button3.Location = new System.Drawing.Point(799, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 31);
            this.button3.TabIndex = 156;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 157;
            this.label1.Text = "Cliente";
            // 
            // rentadevolucionBindingSource
            // 
            this.rentadevolucionBindingSource.DataMember = "Renta_devolucion";
            this.rentadevolucionBindingSource.DataSource = this.dataSetRentasBindingSource;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(52, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 159;
            this.label3.Text = "Desde:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(430, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 160;
            this.label4.Text = "Hasta:";
            // 
            // renta_devolucionTableAdapter
            // 
            this.renta_devolucionTableAdapter.ClearBeforeFill = true;
            // 
            // rentaDatosTableAdapter
            // 
            this.rentaDatosTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fillByToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreToolStripLabel,
            this.nombreToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(443, 407);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(243, 34);
            this.fillByToolStrip.TabIndex = 161;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fillByToolStrip_ItemClicked);
            // 
            // nombreToolStripLabel
            // 
            this.nombreToolStripLabel.Enabled = false;
            this.nombreToolStripLabel.Name = "nombreToolStripLabel";
            this.nombreToolStripLabel.Size = new System.Drawing.Size(79, 29);
            this.nombreToolStripLabel.Text = "nombre:";
            // 
            // nombreToolStripTextBox
            // 
            this.nombreToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nombreToolStripTextBox.Name = "nombreToolStripTextBox";
            this.nombreToolStripTextBox.Size = new System.Drawing.Size(100, 34);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(56, 29);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // nameToolStripLabel
            // 
            this.nameToolStripLabel.Name = "nameToolStripLabel";
            this.nameToolStripLabel.Size = new System.Drawing.Size(60, 29);
            this.nameToolStripLabel.Text = "name:";
            // 
            // nameToolStripTextBox
            // 
            this.nameToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nameToolStripTextBox.Name = "nameToolStripTextBox";
            this.nameToolStripTextBox.Size = new System.Drawing.Size(100, 34);
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(66, 29);
            this.fillBy1ToolStripButton.Text = "FillBy1";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click);
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillBy1ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fillBy1ToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameToolStripLabel,
            this.nameToolStripTextBox,
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(425, 441);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(234, 34);
            this.fillBy1ToolStrip.TabIndex = 162;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fillBy1ToolStrip_ItemClicked);
            // 
            // fillByFechaToolStrip
            // 
            this.fillByFechaToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.fillByFechaToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.fillByFechaToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.fillByFechaToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fecha1ToolStripLabel,
            this.fecha1ToolStripTextBox,
            this.fecha2ToolStripLabel,
            this.fecha2ToolStripTextBox,
            this.fillByFechaToolStripButton});
            this.fillByFechaToolStrip.Location = new System.Drawing.Point(338, 369);
            this.fillByFechaToolStrip.Name = "fillByFechaToolStrip";
            this.fillByFechaToolStrip.Size = new System.Drawing.Size(449, 34);
            this.fillByFechaToolStrip.TabIndex = 163;
            this.fillByFechaToolStrip.Text = "fillByFechaToolStrip";
            this.fillByFechaToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fillByFechaToolStrip_ItemClicked);
            // 
            // fecha1ToolStripLabel
            // 
            this.fecha1ToolStripLabel.Name = "fecha1ToolStripLabel";
            this.fecha1ToolStripLabel.Size = new System.Drawing.Size(68, 29);
            this.fecha1ToolStripLabel.Text = "fecha1:";
            // 
            // fecha1ToolStripTextBox
            // 
            this.fecha1ToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fecha1ToolStripTextBox.Name = "fecha1ToolStripTextBox";
            this.fecha1ToolStripTextBox.Size = new System.Drawing.Size(100, 34);
            // 
            // fecha2ToolStripLabel
            // 
            this.fecha2ToolStripLabel.Name = "fecha2ToolStripLabel";
            this.fecha2ToolStripLabel.Size = new System.Drawing.Size(68, 29);
            this.fecha2ToolStripLabel.Text = "fecha2:";
            // 
            // fecha2ToolStripTextBox
            // 
            this.fecha2ToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fecha2ToolStripTextBox.Name = "fecha2ToolStripTextBox";
            this.fecha2ToolStripTextBox.Size = new System.Drawing.Size(100, 34);
            // 
            // fillByFechaToolStripButton
            // 
            this.fillByFechaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByFechaToolStripButton.Name = "fillByFechaToolStripButton";
            this.fillByFechaToolStripButton.Size = new System.Drawing.Size(101, 29);
            this.fillByFechaToolStripButton.Text = "FillByFecha";
            this.fillByFechaToolStripButton.Click += new System.EventHandler(this.fillByFechaToolStripButton_Click);
            // 
            // ReporteRentaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(931, 717);
            this.Controls.Add(this.clienteNombre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.fecha2);
            this.Controls.Add(this.fecha1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.fillByFechaToolStrip);
            this.Name = "ReporteRentaView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de rentas";
            this.Load += new System.EventHandler(this.ReporteRentaView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentaDatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRentas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentadevolucionBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            this.fillByFechaToolStrip.ResumeLayout(false);
            this.fillByFechaToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSetRentasBindingSource;
        private DataSetRentas dataSetRentas;
        private System.Windows.Forms.DateTimePicker fecha1;
        private System.Windows.Forms.TextBox clienteNombre;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker fecha2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource rentadevolucionBindingSource;
        private DataSetRentasTableAdapters.Renta_devolucionTableAdapter renta_devolucionTableAdapter;
        private System.Windows.Forms.BindingSource rentaDatosBindingSource;
        private DataSetRentasTableAdapters.RentaDatosTableAdapter rentaDatosTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel nameToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nameToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripLabel nombreToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox nombreToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ToolStrip fillByFechaToolStrip;
        private System.Windows.Forms.ToolStripLabel fecha1ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox fecha1ToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel fecha2ToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox fecha2ToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByFechaToolStripButton;
    }
}