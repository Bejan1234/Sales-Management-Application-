namespace ProiectPAW
{
    partial class FormGraficStocValoare
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
            this.chartValoareStoc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartValoareStoc)).BeginInit();
            this.SuspendLayout();
          
            this.chartValoareStoc.Location = new System.Drawing.Point(20, 20);
            this.chartValoareStoc.Name = "chartValoareStoc";
            this.chartValoareStoc.Size = new System.Drawing.Size(600, 400);
            this.chartValoareStoc.TabIndex = 0;
            this.chartValoareStoc.Text = "chart1";
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.chartValoareStoc);
            this.Name = "FormGraficStocValoare";
            this.Text = "Top Valoare Stoc Produse";
            ((System.ComponentModel.ISupportInitialize)(this.chartValoareStoc)).EndInit();
            this.ResumeLayout(false);
        }




        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartValoareStoc;
    }
}