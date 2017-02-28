namespace Parcial1Ap1_SeatielY.UI.Reportes
{
    partial class ReporteEmpleados
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
            this.EmpleadosreportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // EmpleadosreportViewer
            // 
            this.EmpleadosreportViewer.Location = new System.Drawing.Point(0, 1);
            this.EmpleadosreportViewer.Name = "EmpleadosreportViewer";
            this.EmpleadosreportViewer.Size = new System.Drawing.Size(855, 498);
            this.EmpleadosreportViewer.TabIndex = 0;
            // 
            // ReporteEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 499);
            this.Controls.Add(this.EmpleadosreportViewer);
            this.Name = "ReporteEmpleados";
            this.Text = "ReporteEmpleados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReporteEmpleados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer EmpleadosreportViewer;
    }
}