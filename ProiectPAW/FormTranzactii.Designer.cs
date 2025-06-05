namespace ProiectPAW
{
    partial class FormTranzactii
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
            this.lblDataTranzactie = new System.Windows.Forms.Label();
            this.dtpDataTranzactie = new System.Windows.Forms.DateTimePicker();
            this.lblClient = new System.Windows.Forms.Label();
            this.cmbClienti = new System.Windows.Forms.ComboBox();
            this.gbDetaliiProdus = new System.Windows.Forms.GroupBox();
            this.btnAdaugaProdusInCos = new System.Windows.Forms.Button();
            this.tbCantitateProdus = new System.Windows.Forms.TextBox();
            this.lblCantitate = new System.Windows.Forms.Label();
            this.cmbProduseTranzactie = new System.Windows.Forms.ComboBox();
            this.lblProdus = new System.Windows.Forms.Label();
            this.dgvProduseTranzactie = new System.Windows.Forms.DataGridView();
            this.lblValoareTotala = new System.Windows.Forms.Label();
            this.tbValoareTotalaTranzactie = new System.Windows.Forms.TextBox();
            this.btnSalveazaTranzactie = new System.Windows.Forms.Button();
            this.btnAnuleazaTranzactie = new System.Windows.Forms.Button();
            this.gbDetaliiProdus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduseTranzactie)).BeginInit();
            this.SuspendLayout();
             
            this.lblDataTranzactie.AutoSize = true;
            this.lblDataTranzactie.Location = new System.Drawing.Point(12, 18);
            this.lblDataTranzactie.Name = "lblDataTranzactie";
            this.lblDataTranzactie.Size = new System.Drawing.Size(88, 13);
            this.lblDataTranzactie.TabIndex = 0;
            this.lblDataTranzactie.Text = "Data Tranzactie:";
           
            this.dtpDataTranzactie.Location = new System.Drawing.Point(106, 15);
            this.dtpDataTranzactie.Name = "dtpDataTranzactie";
            this.dtpDataTranzactie.Size = new System.Drawing.Size(200, 20);
            this.dtpDataTranzactie.TabIndex = 1;
            
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(12, 45);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(36, 13);
            this.lblClient.TabIndex = 2;
            this.lblClient.Text = "Client:";
           
            this.cmbClienti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClienti.FormattingEnabled = true;
            this.cmbClienti.Location = new System.Drawing.Point(106, 42);
            this.cmbClienti.Name = "cmbClienti";
            this.cmbClienti.Size = new System.Drawing.Size(260, 21);
            this.cmbClienti.TabIndex = 3;
            
            this.gbDetaliiProdus.Controls.Add(this.btnAdaugaProdusInCos);
            this.gbDetaliiProdus.Controls.Add(this.tbCantitateProdus);
            this.gbDetaliiProdus.Controls.Add(this.lblCantitate);
            this.gbDetaliiProdus.Controls.Add(this.cmbProduseTranzactie);
            this.gbDetaliiProdus.Controls.Add(this.lblProdus);
            this.gbDetaliiProdus.Location = new System.Drawing.Point(15, 80);
            this.gbDetaliiProdus.Name = "gbDetaliiProdus";
            this.gbDetaliiProdus.Size = new System.Drawing.Size(757, 70);
            this.gbDetaliiProdus.TabIndex = 4;
            this.gbDetaliiProdus.TabStop = false;
            this.gbDetaliiProdus.Text = "Adauga Produs";
           
            this.btnAdaugaProdusInCos.Location = new System.Drawing.Point(610, 25);
            this.btnAdaugaProdusInCos.Name = "btnAdaugaProdusInCos";
            this.btnAdaugaProdusInCos.Size = new System.Drawing.Size(130, 23);
            this.btnAdaugaProdusInCos.TabIndex = 4;
            this.btnAdaugaProdusInCos.Text = "Adauga in Cos";
            this.btnAdaugaProdusInCos.UseVisualStyleBackColor = true;
            this.btnAdaugaProdusInCos.Click += new System.EventHandler(this.btnAdaugaProdusInCos_Click);
            
            this.tbCantitateProdus.Location = new System.Drawing.Point(450, 27);
            this.tbCantitateProdus.Name = "tbCantitateProdus";
            this.tbCantitateProdus.Size = new System.Drawing.Size(100, 20);
            this.tbCantitateProdus.TabIndex = 3;
           
            this.lblCantitate.AutoSize = true;
            this.lblCantitate.Location = new System.Drawing.Point(390, 30);
            this.lblCantitate.Name = "lblCantitate";
            this.lblCantitate.Size = new System.Drawing.Size(52, 13);
            this.lblCantitate.TabIndex = 2;
            this.lblCantitate.Text = "Cantitate:";
            
            this.cmbProduseTranzactie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduseTranzactie.FormattingEnabled = true;
            this.cmbProduseTranzactie.Location = new System.Drawing.Point(60, 27);
            this.cmbProduseTranzactie.Name = "cmbProduseTranzactie";
            this.cmbProduseTranzactie.Size = new System.Drawing.Size(280, 21);
            this.cmbProduseTranzactie.TabIndex = 1;
           
            this.lblProdus.AutoSize = true;
            this.lblProdus.Location = new System.Drawing.Point(10, 30);
            this.lblProdus.Name = "lblProdus";
            this.lblProdus.Size = new System.Drawing.Size(43, 13);
            this.lblProdus.TabIndex = 0;
            this.lblProdus.Text = "Produs:";
            
            this.dgvProduseTranzactie.AllowUserToAddRows = false;
            this.dgvProduseTranzactie.AllowUserToDeleteRows = false;
            this.dgvProduseTranzactie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduseTranzactie.Location = new System.Drawing.Point(15, 165);
            this.dgvProduseTranzactie.Name = "dgvProduseTranzactie";
            this.dgvProduseTranzactie.ReadOnly = true;
            this.dgvProduseTranzactie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduseTranzactie.Size = new System.Drawing.Size(757, 180);
            this.dgvProduseTranzactie.TabIndex = 5;
            
            this.lblValoareTotala.AutoSize = true;
            this.lblValoareTotala.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValoareTotala.Location = new System.Drawing.Point(550, 358);
            this.lblValoareTotala.Name = "lblValoareTotala";
            this.lblValoareTotala.Size = new System.Drawing.Size(91, 13);
            this.lblValoareTotala.TabIndex = 6;
            this.lblValoareTotala.Text = "Valoare Totala:";
            
            this.tbValoareTotalaTranzactie.Location = new System.Drawing.Point(647, 355);
            this.tbValoareTotalaTranzactie.Name = "tbValoareTotalaTranzactie";
            this.tbValoareTotalaTranzactie.ReadOnly = true;
            this.tbValoareTotalaTranzactie.Size = new System.Drawing.Size(125, 20);
            this.tbValoareTotalaTranzactie.TabIndex = 7;
            this.tbValoareTotalaTranzactie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         
            this.btnSalveazaTranzactie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalveazaTranzactie.Location = new System.Drawing.Point(553, 390);
            this.btnSalveazaTranzactie.Name = "btnSalveazaTranzactie";
            this.btnSalveazaTranzactie.Size = new System.Drawing.Size(150, 25);
            this.btnSalveazaTranzactie.TabIndex = 8;
            this.btnSalveazaTranzactie.Text = "Salveaza Tranzactie";
            this.btnSalveazaTranzactie.UseVisualStyleBackColor = true;
            this.btnSalveazaTranzactie.Click += new System.EventHandler(this.btnSalveazaTranzactie_Click);
             
            this.btnAnuleazaTranzactie.Location = new System.Drawing.Point(709, 390);
            this.btnAnuleazaTranzactie.Name = "btnAnuleazaTranzactie";
            this.btnAnuleazaTranzactie.Size = new System.Drawing.Size(63, 25);
            this.btnAnuleazaTranzactie.TabIndex = 9;
            this.btnAnuleazaTranzactie.Text = "Anuleaza";
            this.btnAnuleazaTranzactie.UseVisualStyleBackColor = true;
            this.btnAnuleazaTranzactie.Click += new System.EventHandler(this.btnAnuleazaTranzactie_Click);
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 431);
            this.Controls.Add(this.btnAnuleazaTranzactie);
            this.Controls.Add(this.btnSalveazaTranzactie);
            this.Controls.Add(this.tbValoareTotalaTranzactie);
            this.Controls.Add(this.lblValoareTotala);
            this.Controls.Add(this.dgvProduseTranzactie);
            this.Controls.Add(this.gbDetaliiProdus);
            this.Controls.Add(this.cmbClienti);
            this.Controls.Add(this.lblClient);
            this.Controls.Add(this.dtpDataTranzactie);
            this.Controls.Add(this.lblDataTranzactie);
            this.Name = "FormTranzactii";
            this.Text = "Inregistrare Tranzactie Noua";
            this.Load += new System.EventHandler(this.FormTranzactii_Load);
            this.gbDetaliiProdus.ResumeLayout(false);
            this.gbDetaliiProdus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduseTranzactie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblDataTranzactie;
        private System.Windows.Forms.DateTimePicker dtpDataTranzactie;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.ComboBox cmbClienti;
        private System.Windows.Forms.GroupBox gbDetaliiProdus;
        private System.Windows.Forms.Button btnAdaugaProdusInCos;
        private System.Windows.Forms.TextBox tbCantitateProdus;
        private System.Windows.Forms.Label lblCantitate;
        private System.Windows.Forms.ComboBox cmbProduseTranzactie;
        private System.Windows.Forms.Label lblProdus;
        private System.Windows.Forms.DataGridView dgvProduseTranzactie;
        private System.Windows.Forms.Label lblValoareTotala;
        private System.Windows.Forms.TextBox tbValoareTotalaTranzactie;
        private System.Windows.Forms.Button btnSalveazaTranzactie;
        private System.Windows.Forms.Button btnAnuleazaTranzactie;
    }
}