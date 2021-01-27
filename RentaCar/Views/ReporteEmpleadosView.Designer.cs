
namespace RentaCar.Views
{
    partial class ReporteEmpleadosView
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dataSetEmpleadossBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetEmpleadoss = new RentaCar.DataSetEmpleadoss();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosTableAdapter = new RentaCar.DataSetEmpleadossTableAdapters.EmpleadosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEmpleadossBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEmpleadoss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSetEmpleadossBindingSource
            // 
            this.dataSetEmpleadossBindingSource.DataSource = this.dataSetEmpleadoss;
            this.dataSetEmpleadossBindingSource.Position = 0;
            this.dataSetEmpleadossBindingSource.CurrentChanged += new System.EventHandler(this.dataSetEmpleadossBindingSource_CurrentChanged);
            // 
            // dataSetEmpleadoss
            // 
            this.dataSetEmpleadoss.DataSetName = "DataSetEmpleadoss";
            this.dataSetEmpleadoss.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EmpleadosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RentaCar.ReportEmpleadoss.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1132, 530);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // EmpleadosBindingSource
            // 
            this.EmpleadosBindingSource.DataMember = "Empleados";
            this.EmpleadosBindingSource.DataSource = this.dataSetEmpleadoss;
            // 
            // empleadosBindingSource1
            // 
            this.empleadosBindingSource1.DataMember = "Empleados";
            this.empleadosBindingSource1.DataSource = this.dataSetEmpleadossBindingSource;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteEmpleadosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 530);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteEmpleadosView";
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEmpleadossBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEmpleadoss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetEmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dataSetEmpleadosBindingSource;
        private System.Windows.Forms.BindingSource dataSetEmpleadossBindingSource;
        private DataSetEmpleadoss dataSetEmpleadoss;
        private System.Windows.Forms.BindingSource EmpleadosBindingSource;
        private System.Windows.Forms.BindingSource empleadosBindingSource1;
        private DataSetEmpleadossTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
    }
}