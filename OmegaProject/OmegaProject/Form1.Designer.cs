namespace OmegaProject
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
            this.CreatorsStrip = new System.Windows.Forms.MenuStrip();
            this.dutchyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cheatEngineToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrayOfBytesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CreatorsStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreatorsStrip
            // 
            this.CreatorsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dutchyToolStripMenuItem});
            this.CreatorsStrip.Location = new System.Drawing.Point(0, 0);
            this.CreatorsStrip.Name = "CreatorsStrip";
            this.CreatorsStrip.Size = new System.Drawing.Size(766, 24);
            this.CreatorsStrip.TabIndex = 0;
            this.CreatorsStrip.Text = "menuStrip1";
            // 
            // dutchyToolStripMenuItem
            // 
            this.dutchyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cheatEngineToolsToolStripMenuItem});
            this.dutchyToolStripMenuItem.Name = "dutchyToolStripMenuItem";
            this.dutchyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.dutchyToolStripMenuItem.Text = "Dutchy";
            // 
            // cheatEngineToolsToolStripMenuItem
            // 
            this.cheatEngineToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrayOfBytesToolStripMenuItem});
            this.cheatEngineToolsToolStripMenuItem.Name = "cheatEngineToolsToolStripMenuItem";
            this.cheatEngineToolsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cheatEngineToolsToolStripMenuItem.Text = "Cheat Engine Tools";
            // 
            // arrayOfBytesToolStripMenuItem
            // 
            this.arrayOfBytesToolStripMenuItem.Name = "arrayOfBytesToolStripMenuItem";
            this.arrayOfBytesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arrayOfBytesToolStripMenuItem.Text = "Array of Bytes";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 402);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 426);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CreatorsStrip);
            this.MainMenuStrip = this.CreatorsStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.CreatorsStrip.ResumeLayout(false);
            this.CreatorsStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip CreatorsStrip;
        private System.Windows.Forms.ToolStripMenuItem dutchyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cheatEngineToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrayOfBytesToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}

