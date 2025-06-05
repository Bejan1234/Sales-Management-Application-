namespace ProiectPAW
{
    partial class FormDetaliiClient
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblClientId = new System.Windows.Forms.Label();
            this.tbClientId = new System.Windows.Forms.TextBox();
            this.lblNumeClient = new System.Windows.Forms.Label();
            this.tbNumeClient = new System.Windows.Forms.TextBox();
            this.lblNumarTelefon = new System.Windows.Forms.Label();
            this.tbNumarTelefon = new System.Windows.Forms.TextBox();
            this.lblAdresaEmail = new System.Windows.Forms.Label();
            this.tbAdresaEmail = new System.Windows.Forms.TextBox();
            this.lblCodFiscal = new System.Windows.Forms.Label();
            this.tbCodFiscal = new System.Windows.Forms.TextBox();
            this.btnSalveazaClient = new System.Windows.Forms.Button();
            this.btnAnuleazaClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
           
            this.lblClientId.AutoSize = true;
            this.lblClientId.Location = new System.Drawing.Point(33, 37);
            this.lblClientId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(59, 16);
            this.lblClientId.TabIndex = 0;
            this.lblClientId.Text = "ID Client:";
            this.lblClientId.Click += new System.EventHandler(this.lblClientId_Click);
             
            this.tbClientId.Location = new System.Drawing.Point(173, 33);
            this.tbClientId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbClientId.Name = "tbClientId";
            this.tbClientId.ReadOnly = true;
            this.tbClientId.Size = new System.Drawing.Size(199, 22);
            this.tbClientId.TabIndex = 1;
           
            this.lblNumeClient.AutoSize = true;
            this.lblNumeClient.Location = new System.Drawing.Point(33, 74);
            this.lblNumeClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeClient.Name = "lblNumeClient";
            this.lblNumeClient.Size = new System.Drawing.Size(82, 16);
            this.lblNumeClient.TabIndex = 2;
            this.lblNumeClient.Text = "Nume Client:";
           
            this.tbNumeClient.Location = new System.Drawing.Point(173, 70);
            this.tbNumeClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNumeClient.Name = "tbNumeClient";
            this.tbNumeClient.Size = new System.Drawing.Size(199, 22);
            this.tbNumeClient.TabIndex = 3;
             
            this.lblNumarTelefon.AutoSize = true;
            this.lblNumarTelefon.Location = new System.Drawing.Point(33, 111);
            this.lblNumarTelefon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumarTelefon.Name = "lblNumarTelefon";
            this.lblNumarTelefon.Size = new System.Drawing.Size(99, 16);
            this.lblNumarTelefon.TabIndex = 4;
            this.lblNumarTelefon.Text = "Numar Telefon:";
           
            this.tbNumarTelefon.Location = new System.Drawing.Point(173, 107);
            this.tbNumarTelefon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNumarTelefon.Name = "tbNumarTelefon";
            this.tbNumarTelefon.Size = new System.Drawing.Size(199, 22);
            this.tbNumarTelefon.TabIndex = 5;
           
            this.lblAdresaEmail.AutoSize = true;
            this.lblAdresaEmail.Location = new System.Drawing.Point(33, 148);
            this.lblAdresaEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdresaEmail.Name = "lblAdresaEmail";
            this.lblAdresaEmail.Size = new System.Drawing.Size(91, 16);
            this.lblAdresaEmail.TabIndex = 6;
            this.lblAdresaEmail.Text = "Adresa Email:";
             
            this.tbAdresaEmail.Location = new System.Drawing.Point(173, 144);
            this.tbAdresaEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAdresaEmail.Name = "tbAdresaEmail";
            this.tbAdresaEmail.Size = new System.Drawing.Size(199, 22);
            this.tbAdresaEmail.TabIndex = 7;
             
            this.lblCodFiscal.AutoSize = true;
            this.lblCodFiscal.Location = new System.Drawing.Point(33, 185);
            this.lblCodFiscal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodFiscal.Name = "lblCodFiscal";
            this.lblCodFiscal.Size = new System.Drawing.Size(74, 16);
            this.lblCodFiscal.TabIndex = 8;
            this.lblCodFiscal.Text = "Cod Fiscal:";
            
            this.tbCodFiscal.Location = new System.Drawing.Point(173, 181);
            this.tbCodFiscal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCodFiscal.Name = "tbCodFiscal";
            this.tbCodFiscal.Size = new System.Drawing.Size(199, 22);
            this.tbCodFiscal.TabIndex = 9;
           
            this.btnSalveazaClient.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalveazaClient.Location = new System.Drawing.Point(144, 234);
            this.btnSalveazaClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalveazaClient.Name = "btnSalveazaClient";
            this.btnSalveazaClient.Size = new System.Drawing.Size(120, 31);
            this.btnSalveazaClient.TabIndex = 10;
            this.btnSalveazaClient.Text = "Salveaza";
            this.btnSalveazaClient.UseVisualStyleBackColor = true;
            this.btnSalveazaClient.Click += new System.EventHandler(this.btnSalveazaClient_Click);
            
            this.btnAnuleazaClient.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnuleazaClient.Location = new System.Drawing.Point(289, 234);
            this.btnAnuleazaClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnuleazaClient.Name = "btnAnuleazaClient";
            this.btnAnuleazaClient.Size = new System.Drawing.Size(120, 31);
            this.btnAnuleazaClient.TabIndex = 11;
            this.btnAnuleazaClient.Text = "Anuleaza";
            this.btnAnuleazaClient.UseVisualStyleBackColor = true;
          
            this.AcceptButton = this.btnSalveazaClient;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAnuleazaClient;
            this.ClientSize = new System.Drawing.Size(512, 284);
            this.Controls.Add(this.btnAnuleazaClient);
            this.Controls.Add(this.btnSalveazaClient);
            this.Controls.Add(this.tbCodFiscal);
            this.Controls.Add(this.lblCodFiscal);
            this.Controls.Add(this.tbAdresaEmail);
            this.Controls.Add(this.lblAdresaEmail);
            this.Controls.Add(this.tbNumarTelefon);
            this.Controls.Add(this.lblNumarTelefon);
            this.Controls.Add(this.tbNumeClient);
            this.Controls.Add(this.lblNumeClient);
            this.Controls.Add(this.tbClientId);
            this.Controls.Add(this.lblClientId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDetaliiClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalii Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.TextBox tbClientId;
        private System.Windows.Forms.Label lblNumeClient;
        private System.Windows.Forms.TextBox tbNumeClient;
        private System.Windows.Forms.Label lblNumarTelefon;
        private System.Windows.Forms.TextBox tbNumarTelefon;
        private System.Windows.Forms.Label lblAdresaEmail;
        private System.Windows.Forms.TextBox tbAdresaEmail;
        private System.Windows.Forms.Label lblCodFiscal;
        private System.Windows.Forms.TextBox tbCodFiscal;
        private System.Windows.Forms.Button btnSalveazaClient;
        private System.Windows.Forms.Button btnAnuleazaClient;
    }
}