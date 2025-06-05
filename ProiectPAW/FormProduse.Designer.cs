using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.ComponentModel.Design;
using System.Drawing;
using System.IO;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Threading;
using System.Windows.Forms;

namespace ProiectPAW
{
    partial class FormProduse
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
                this.dgvProduse = new System.Windows.Forms.DataGridView();
                this.btnAdauga = new System.Windows.Forms.Button();
                this.btnModifica = new System.Windows.Forms.Button();
                this.btnStergeProdus = new System.Windows.Forms.Button();
                this.btnActualizeaza = new System.Windows.Forms.Button();
                ((System.ComponentModel.ISupportInitialize)(this.dgvProduse)).BeginInit();
                this.SuspendLayout();
            this.contextMenuProduse = new System.Windows.Forms.ContextMenuStrip();
            this.modificaProdusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeProdusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detaliiProdusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

           
            this.contextMenuProduse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
    this.modificaProdusToolStripMenuItem,
    this.stergeProdusToolStripMenuItem,
    this.detaliiProdusToolStripMenuItem});
            this.contextMenuProduse.Name = "contextMenuProduse";
            this.contextMenuProduse.Size = new System.Drawing.Size(170, 70);

           
            this.modificaProdusToolStripMenuItem.Name = "modificaProdusToolStripMenuItem";
            this.modificaProdusToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.modificaProdusToolStripMenuItem.Text = "🔧 Modifică produs";
            this.modificaProdusToolStripMenuItem.Click += new System.EventHandler(this.modificaProdusToolStripMenuItem_Click);

          
            this.stergeProdusToolStripMenuItem.Name = "stergeProdusToolStripMenuItem";
            this.stergeProdusToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.stergeProdusToolStripMenuItem.Text = "❌ Șterge produs";
            this.stergeProdusToolStripMenuItem.Click += new System.EventHandler(this.stergeProdusToolStripMenuItem_Click);

         
            this.detaliiProdusToolStripMenuItem.Name = "detaliiProdusToolStripMenuItem";
            this.detaliiProdusToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.detaliiProdusToolStripMenuItem.Text = "🔍 Detalii produs";
            this.detaliiProdusToolStripMenuItem.Click += new System.EventHandler(this.detaliiProdusToolStripMenuItem_Click);

         
            this.dgvProduse.ContextMenuStrip = this.contextMenuProduse;

          
            this.dgvProduse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                this.dgvProduse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                this.dgvProduse.Location = new System.Drawing.Point(12, 12);
                this.dgvProduse.Name = "dgvProduse";
               
                this.dgvProduse.ReadOnly = true;
                this.dgvProduse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                this.dgvProduse.MultiSelect = false;
                this.dgvProduse.AllowUserToAddRows = false;
                this.dgvProduse.AllowUserToDeleteRows = false;
                this.dgvProduse.Size = new System.Drawing.Size(760, 300); 
                this.dgvProduse.TabIndex = 0;
               
                this.btnAdauga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                this.btnAdauga.Location = new System.Drawing.Point(12, 320); 
                this.btnAdauga.Name = "btnAdauga";
                this.btnAdauga.Size = new System.Drawing.Size(120, 30); 
                this.btnAdauga.TabIndex = 1;
                this.btnAdauga.Text = "Adauga";
                this.btnAdauga.UseVisualStyleBackColor = true;
                this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
               
                this.btnModifica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                this.btnModifica.Location = new System.Drawing.Point(140, 320); 
                this.btnModifica.Name = "btnModifica";
                this.btnModifica.Size = new System.Drawing.Size(120, 30); 
                this.btnModifica.TabIndex = 2;
                this.btnModifica.Text = "Modifica";
                this.btnModifica.UseVisualStyleBackColor = true;
                this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
                
                this.btnStergeProdus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
                this.btnStergeProdus.Location = new System.Drawing.Point(268, 320); 
                this.btnStergeProdus.Name = "btnStergeProdus";
                this.btnStergeProdus.Size = new System.Drawing.Size(120, 30); 
                this.btnStergeProdus.TabIndex = 3;
                this.btnStergeProdus.Text = "Sterge Produs";
                this.btnStergeProdus.UseVisualStyleBackColor = true;
                this.btnStergeProdus.Click += new System.EventHandler(this.btnStergeProdus_Click);
              
                this.btnActualizeaza.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
                this.btnActualizeaza.Location = new System.Drawing.Point(652, 320); 
                this.btnActualizeaza.Name = "btnActualizeaza";
                this.btnActualizeaza.Size = new System.Drawing.Size(120, 30); 
                this.btnActualizeaza.TabIndex = 4;
                this.btnActualizeaza.Text = "Actualizeaza";
                this.btnActualizeaza.UseVisualStyleBackColor = true;
                this.btnActualizeaza.Click += new System.EventHandler(this.btnActualizeaza_Click);
                 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); 
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(784, 361); 
                this.Controls.Add(this.btnActualizeaza);
                this.Controls.Add(this.btnStergeProdus);
                this.Controls.Add(this.btnModifica);
                this.Controls.Add(this.btnAdauga);
                this.Controls.Add(this.dgvProduse);
                this.Name = "FormProduse";
                this.Text = "Gestiune Produse"; 
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen; 
                ((System.ComponentModel.ISupportInitialize)(this.dgvProduse)).EndInit();
                this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.DataGridView dgvProduse;
            private System.Windows.Forms.Button btnAdauga;
            private System.Windows.Forms.Button btnModifica;
            private System.Windows.Forms.Button btnStergeProdus;
            private System.Windows.Forms.Button btnActualizeaza;
            private System.Windows.Forms.ContextMenuStrip contextMenuProduse;
            private System.Windows.Forms.ToolStripMenuItem modificaProdusToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem stergeProdusToolStripMenuItem;
            private System.Windows.Forms.ToolStripMenuItem detaliiProdusToolStripMenuItem;

    }
}