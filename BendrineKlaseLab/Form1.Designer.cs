
namespace BendrineKlaseLab
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.failasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ivestiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spausdintiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salinimasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daugiausiaiTurintisModuliuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duomenys1 = new System.Windows.Forms.RichTextBox();
            this.duomenys2 = new System.Windows.Forms.RichTextBox();
            this.rezultatai = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.failasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // failasToolStripMenuItem
            // 
            this.failasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ivestiToolStripMenuItem,
            this.spausdintiToolStripMenuItem,
            this.salinimasToolStripMenuItem,
            this.daugiausiaiTurintisModuliuToolStripMenuItem});
            this.failasToolStripMenuItem.Name = "failasToolStripMenuItem";
            this.failasToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.failasToolStripMenuItem.Text = "Failas";
            // 
            // ivestiToolStripMenuItem
            // 
            this.ivestiToolStripMenuItem.Name = "ivestiToolStripMenuItem";
            this.ivestiToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.ivestiToolStripMenuItem.Text = "Ivesti";
            this.ivestiToolStripMenuItem.Click += new System.EventHandler(this.ivestiToolStripMenuItem_Click);
            // 
            // spausdintiToolStripMenuItem
            // 
            this.spausdintiToolStripMenuItem.Name = "spausdintiToolStripMenuItem";
            this.spausdintiToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.spausdintiToolStripMenuItem.Text = "Spausdinti destytoju sarasas";
            this.spausdintiToolStripMenuItem.Click += new System.EventHandler(this.spausdintiToolStripMenuItem_Click);
            // 
            // salinimasToolStripMenuItem
            // 
            this.salinimasToolStripMenuItem.Name = "salinimasToolStripMenuItem";
            this.salinimasToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.salinimasToolStripMenuItem.Text = "Salinimas";
            this.salinimasToolStripMenuItem.Click += new System.EventHandler(this.salinimasToolStripMenuItem_Click);
            // 
            // daugiausiaiTurintisModuliuToolStripMenuItem
            // 
            this.daugiausiaiTurintisModuliuToolStripMenuItem.Name = "daugiausiaiTurintisModuliuToolStripMenuItem";
            this.daugiausiaiTurintisModuliuToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.daugiausiaiTurintisModuliuToolStripMenuItem.Text = "Daugiausiai turintis moduliu";
            this.daugiausiaiTurintisModuliuToolStripMenuItem.Click += new System.EventHandler(this.daugiausiaiTurintisModuliuToolStripMenuItem_Click);
            // 
            // duomenys1
            // 
            this.duomenys1.Location = new System.Drawing.Point(0, 31);
            this.duomenys1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.duomenys1.Name = "duomenys1";
            this.duomenys1.Size = new System.Drawing.Size(553, 239);
            this.duomenys1.TabIndex = 1;
            this.duomenys1.Text = "";
            
            // 
            // duomenys2
            // 
            this.duomenys2.Location = new System.Drawing.Point(559, 31);
            this.duomenys2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.duomenys2.Name = "duomenys2";
            this.duomenys2.Size = new System.Drawing.Size(508, 239);
            this.duomenys2.TabIndex = 2;
            this.duomenys2.Text = "";
            // 
            // rezultatai
            // 
            this.rezultatai.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.rezultatai.Location = new System.Drawing.Point(0, 276);
            this.rezultatai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rezultatai.Name = "rezultatai";
            this.rezultatai.Size = new System.Drawing.Size(1067, 255);
            this.rezultatai.TabIndex = 3;
            this.rezultatai.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.rezultatai);
            this.Controls.Add(this.duomenys2);
            this.Controls.Add(this.duomenys1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem failasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ivestiToolStripMenuItem;
        private System.Windows.Forms.RichTextBox duomenys1;
        private System.Windows.Forms.RichTextBox duomenys2;
        private System.Windows.Forms.RichTextBox rezultatai;
        private System.Windows.Forms.ToolStripMenuItem spausdintiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salinimasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daugiausiaiTurintisModuliuToolStripMenuItem;
    }
}

