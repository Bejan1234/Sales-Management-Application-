

namespace ProiectPAW 
{
    partial class FormDetaliiProdus
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
            this.lblIdProdus = new System.Windows.Forms.Label();
            this.tbIdProdus = new System.Windows.Forms.TextBox();
            this.lblDenumire = new System.Windows.Forms.Label();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.lblPret = new System.Windows.Forms.Label();
            this.tbPretUnitar = new System.Windows.Forms.TextBox();
            this.lblStoc = new System.Windows.Forms.Label();
            this.tbCantitateStoc = new System.Windows.Forms.TextBox();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
           
            this.lblIdProdus.AutoSize = true;
            this.lblIdProdus.Location = new System.Drawing.Point(33, 37);
            this.lblIdProdus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdProdus.Name = "lblIdProdus";
            this.lblIdProdus.Size = new System.Drawing.Size(69, 16);
            this.lblIdProdus.TabIndex = 0;
            this.lblIdProdus.Text = "ID Produs:";
           
            this.tbIdProdus.Location = new System.Drawing.Point(160, 33);
            this.tbIdProdus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbIdProdus.Name = "tbIdProdus";
            this.tbIdProdus.ReadOnly = true;
            this.tbIdProdus.Size = new System.Drawing.Size(199, 22);
            this.tbIdProdus.TabIndex = 1;
            
            this.lblDenumire.AutoSize = true;
            this.lblDenumire.Location = new System.Drawing.Point(33, 74);
            this.lblDenumire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDenumire.Name = "lblDenumire";
            this.lblDenumire.Size = new System.Drawing.Size(68, 16);
            this.lblDenumire.TabIndex = 2;
            this.lblDenumire.Text = "Denumire:";
             
            this.tbDenumire.Location = new System.Drawing.Point(160, 70);
            this.tbDenumire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(199, 22);
            this.tbDenumire.TabIndex = 3;
            
            this.lblPret.AutoSize = true;
            this.lblPret.Location = new System.Drawing.Point(33, 111);
            this.lblPret.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(72, 16);
            this.lblPret.TabIndex = 4;
            this.lblPret.Text = "Preț Unitar:";
            
            this.tbPretUnitar.Location = new System.Drawing.Point(160, 107);
            this.tbPretUnitar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPretUnitar.Name = "tbPretUnitar";
            this.tbPretUnitar.Size = new System.Drawing.Size(199, 22);
            this.tbPretUnitar.TabIndex = 5;
            
            this.lblStoc.AutoSize = true;
            this.lblStoc.Location = new System.Drawing.Point(33, 148);
            this.lblStoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStoc.Name = "lblStoc";
            this.lblStoc.Size = new System.Drawing.Size(92, 16);
            this.lblStoc.TabIndex = 6;
            this.lblStoc.Text = "Cantitate Stoc:";
           
            this.tbCantitateStoc.Location = new System.Drawing.Point(160, 144);
            this.tbCantitateStoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCantitateStoc.Name = "tbCantitateStoc";
            this.tbCantitateStoc.Size = new System.Drawing.Size(199, 22);
            this.tbCantitateStoc.TabIndex = 7;
          
            this.btnSalveaza.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalveaza.Location = new System.Drawing.Point(160, 197);
            this.btnSalveaza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(100, 28);
            this.btnSalveaza.TabIndex = 8;
            this.btnSalveaza.Text = "Salvează";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
           
            this.btnAnuleaza.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnuleaza.Location = new System.Drawing.Point(273, 197);
            this.btnAnuleaza.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(100, 28);
            this.btnAnuleaza.TabIndex = 9;
            this.btnAnuleaza.Text = "Anulează";
            this.btnAnuleaza.UseVisualStyleBackColor = true;
            
            this.AcceptButton = this.btnSalveaza;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnuleaza;
            this.ClientSize = new System.Drawing.Size(533, 258);
            this.Controls.Add(this.btnAnuleaza);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.tbCantitateStoc);
            this.Controls.Add(this.lblStoc);
            this.Controls.Add(this.tbPretUnitar);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.lblDenumire);
            this.Controls.Add(this.tbIdProdus);
            this.Controls.Add(this.lblIdProdus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDetaliiProdus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalii Produs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdProdus;
        private System.Windows.Forms.TextBox tbIdProdus;
        private System.Windows.Forms.Label lblDenumire;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.TextBox tbPretUnitar;
        private System.Windows.Forms.Label lblStoc;
        private System.Windows.Forms.TextBox tbCantitateStoc;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnAnuleaza;
    }
}