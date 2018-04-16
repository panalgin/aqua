namespace Aqua
{
    partial class MainForm
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
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.araçlarToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 24);
            this.menuStrip1.TabIndex = 0;
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // araçlarToolStripMenuItem
            // 
            this.araçlarToolStripMenuItem.Name = "araçlarToolStripMenuItem";
            this.araçlarToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.araçlarToolStripMenuItem.Text = "Araçlar";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkındaToolStripMenuItem});
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 573);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aqua - v0.1.8";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
    }
}

