namespace ProiectPAW
{
    partial class Form1
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiuneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tranzactiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapoarteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficStocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.contextMenuForm1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salveazaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contextMenuForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 30);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iesireToolStripMenuItem,
            this.gestiuneToolStripMenuItem,
            this.rapoarteToolStripMenuItem,
            this.ajutorToolStripMenuItem});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(57, 26);
            this.fisierToolStripMenuItem.Text = "Fisier";
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // gestiuneToolStripMenuItem
            // 
            this.gestiuneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produseToolStripMenuItem,
            this.clientiToolStripMenuItem,
            this.tranzactiiToolStripMenuItem});
            this.gestiuneToolStripMenuItem.Name = "gestiuneToolStripMenuItem";
            this.gestiuneToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.gestiuneToolStripMenuItem.Text = "Gestiune";
            // 
            // produseToolStripMenuItem
            // 
            this.produseToolStripMenuItem.Name = "produseToolStripMenuItem";
            this.produseToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.produseToolStripMenuItem.Text = "Produse";
            this.produseToolStripMenuItem.Click += new System.EventHandler(this.produseToolStripMenuItem_Click);
            // 
            // clientiToolStripMenuItem
            // 
            this.clientiToolStripMenuItem.Name = "clientiToolStripMenuItem";
            this.clientiToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.clientiToolStripMenuItem.Text = "Clienti";
            this.clientiToolStripMenuItem.Click += new System.EventHandler(this.clientiToolStripMenuItem_Click);
            // 
            // tranzactiiToolStripMenuItem
            // 
            this.tranzactiiToolStripMenuItem.Name = "tranzactiiToolStripMenuItem";
            this.tranzactiiToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.tranzactiiToolStripMenuItem.Text = "Tranzactii";
            this.tranzactiiToolStripMenuItem.Click += new System.EventHandler(this.tranzactiiToolStripMenuItem_Click);
            // 
            // rapoarteToolStripMenuItem
            // 
            this.rapoarteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graficStocToolStripMenuItem});
            this.rapoarteToolStripMenuItem.Name = "rapoarteToolStripMenuItem";
            this.rapoarteToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.rapoarteToolStripMenuItem.Text = "Grafic Val.Stoc";
            // 
            // graficStocToolStripMenuItem
            // 
            this.graficStocToolStripMenuItem.Name = "graficStocToolStripMenuItem";
            this.graficStocToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.graficStocToolStripMenuItem.Text = "Grafic valoare stoc";
            this.graficStocToolStripMenuItem.Click += new System.EventHandler(this.graficStocToolStripMenuItem_Click);
            // 
            // ajutorToolStripMenuItem
            // 
            this.ajutorToolStripMenuItem.Name = "ajutorToolStripMenuItem";
            this.ajutorToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.ajutorToolStripMenuItem.Text = "🖨️ Imprimă produse";
            this.ajutorToolStripMenuItem.Click += new System.EventHandler(this.imprimareProduseToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 420);
            this.panel1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.Location = new System.Drawing.Point(561, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 62);
            this.button3.TabIndex = 3;
            this.button3.Text = "Tranzactii";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.tranzactiiToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Cyan;
            this.button2.Location = new System.Drawing.Point(308, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 62);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clienti";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.clientiToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(45, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "Produse";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.produseToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 398);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // contextMenuForm1
            // 
            this.contextMenuForm1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuForm1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salveazaToolStripMenuItem,
            this.incarcaToolStripMenuItem});
            this.contextMenuForm1.Name = "contextMenuForm1";
            this.contextMenuForm1.Size = new System.Drawing.Size(246, 52);
            // 
            // salveazaToolStripMenuItem
            // 
            this.salveazaToolStripMenuItem.Name = "salveazaToolStripMenuItem";
            this.salveazaToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.salveazaToolStripMenuItem.Text = "💾 Salvează toate datele";
            this.salveazaToolStripMenuItem.Click += new System.EventHandler(this.salveazaToolStripMenuItem_Click);
            // 
            // incarcaToolStripMenuItem
            // 
            this.incarcaToolStripMenuItem.Name = "incarcaToolStripMenuItem";
            this.incarcaToolStripMenuItem.Size = new System.Drawing.Size(245, 24);
            this.incarcaToolStripMenuItem.Text = "📂 Încarcă toate datele";
            this.incarcaToolStripMenuItem.Click += new System.EventHandler(this.incarcaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuForm1;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuForm1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiuneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tranzactiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapoarteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajutorToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuForm1;
        private System.Windows.Forms.ToolStripMenuItem salveazaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficStocToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}