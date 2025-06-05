namespace ProiectPAW
{
    partial class FormClienti
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
            this.dgvClienti = new System.Windows.Forms.DataGridView();
            this.btnAdaugaClient = new System.Windows.Forms.Button();
            this.btnModificaClient = new System.Windows.Forms.Button();
            this.btnStergeClient = new System.Windows.Forms.Button();
            this.btnActualizeazaListaClienti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).BeginInit();
            this.SuspendLayout();
           
            this.dgvClienti.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClienti.Location = new System.Drawing.Point(12, 12);
            this.dgvClienti.Name = "dgvClienti";
            this.dgvClienti.Size = new System.Drawing.Size(760, 300);
            this.dgvClienti.TabIndex = 0;
           
            this.btnAdaugaClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdaugaClient.Location = new System.Drawing.Point(12, 320);
            this.btnAdaugaClient.Name = "btnAdaugaClient";
            this.btnAdaugaClient.Size = new System.Drawing.Size(120, 30);
            this.btnAdaugaClient.TabIndex = 1;
            this.btnAdaugaClient.Text = "Adauga Client";
            this.btnAdaugaClient.UseVisualStyleBackColor = true;
            this.btnAdaugaClient.Click += new System.EventHandler(this.btnAdaugaClient_Click);
            
            this.btnModificaClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificaClient.Location = new System.Drawing.Point(140, 320);
            this.btnModificaClient.Name = "btnModificaClient";
            this.btnModificaClient.Size = new System.Drawing.Size(120, 30);
            this.btnModificaClient.TabIndex = 2;
            this.btnModificaClient.Text = "Modifica Client";
            this.btnModificaClient.UseVisualStyleBackColor = true;
            this.btnModificaClient.Click += new System.EventHandler(this.btnModificaClient_Click);
           
            this.btnStergeClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStergeClient.Location = new System.Drawing.Point(268, 320);
            this.btnStergeClient.Name = "btnStergeClient";
            this.btnStergeClient.Size = new System.Drawing.Size(120, 30);
            this.btnStergeClient.TabIndex = 3;
            this.btnStergeClient.Text = "Sterge Client";
            this.btnStergeClient.UseVisualStyleBackColor = true;
            this.btnStergeClient.Click += new System.EventHandler(this.btnStergeClient_Click);
             
            this.btnActualizeazaListaClienti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizeazaListaClienti.Location = new System.Drawing.Point(622, 320); 
            this.btnActualizeazaListaClienti.Name = "btnActualizeazaListaClienti";
            this.btnActualizeazaListaClienti.Size = new System.Drawing.Size(150, 30); 
            this.btnActualizeazaListaClienti.TabIndex = 4;
            this.btnActualizeazaListaClienti.Text = "Actualizeaza Lista";
            this.btnActualizeazaListaClienti.UseVisualStyleBackColor = true;
            this.btnActualizeazaListaClienti.Click += new System.EventHandler(this.btnActualizeazaListaClienti_Click);
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.btnActualizeazaListaClienti);
            this.Controls.Add(this.btnStergeClient);
            this.Controls.Add(this.btnModificaClient);
            this.Controls.Add(this.btnAdaugaClient);
            this.Controls.Add(this.dgvClienti);
            this.Name = "FormClienti";
            this.Text = "Gestiune Clienti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dgvClienti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClienti;
        private System.Windows.Forms.Button btnAdaugaClient;
        private System.Windows.Forms.Button btnModificaClient;
        private System.Windows.Forms.Button btnStergeClient;
        private System.Windows.Forms.Button btnActualizeazaListaClienti;
    }
}