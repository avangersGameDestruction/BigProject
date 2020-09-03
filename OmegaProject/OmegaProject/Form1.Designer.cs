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
            this.aOBPatternFinderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoClickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cUI1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.base64EnDecodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreatorsStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreatorsStrip
            // 
            this.CreatorsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dutchyToolStripMenuItem,
            this.cUiToolStripMenuItem});
            this.CreatorsStrip.Location = new System.Drawing.Point(0, 0);
            this.CreatorsStrip.Name = "CreatorsStrip";
            this.CreatorsStrip.Size = new System.Drawing.Size(766, 24);
            this.CreatorsStrip.TabIndex = 0;
            this.CreatorsStrip.Text = "menuStrip1";
            // 
            // dutchyToolStripMenuItem
            // 
            this.dutchyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cheatEngineToolsToolStripMenuItem,
            this.autoClickerToolStripMenuItem,
            this.base64EnDecodeToolStripMenuItem});
            this.dutchyToolStripMenuItem.Name = "dutchyToolStripMenuItem";
            this.dutchyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.dutchyToolStripMenuItem.Text = "Dutchy";
            // 
            // cheatEngineToolsToolStripMenuItem
            // 
            this.cheatEngineToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrayOfBytesToolStripMenuItem,
            this.aOBPatternFinderToolStripMenuItem});
            this.cheatEngineToolsToolStripMenuItem.Name = "cheatEngineToolsToolStripMenuItem";
            this.cheatEngineToolsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cheatEngineToolsToolStripMenuItem.Text = "Cheat Engine Tools";
            // 
            // arrayOfBytesToolStripMenuItem
            // 
            this.arrayOfBytesToolStripMenuItem.Name = "arrayOfBytesToolStripMenuItem";
            this.arrayOfBytesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.arrayOfBytesToolStripMenuItem.Text = "Array of Bytes";
            this.arrayOfBytesToolStripMenuItem.Click += new System.EventHandler(this.arrayOfBytesToolStripMenuItem_Click);
            // 
            // aOBPatternFinderToolStripMenuItem
            // 
            this.aOBPatternFinderToolStripMenuItem.Name = "aOBPatternFinderToolStripMenuItem";
            this.aOBPatternFinderToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.aOBPatternFinderToolStripMenuItem.Text = "AOBPatternFinder";
            this.aOBPatternFinderToolStripMenuItem.Click += new System.EventHandler(this.aOBPatternFinderToolStripMenuItem_Click);
            // 
            // autoClickerToolStripMenuItem
            // 
            this.autoClickerToolStripMenuItem.Name = "autoClickerToolStripMenuItem";
            this.autoClickerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autoClickerToolStripMenuItem.Text = "auto clicker";
            this.autoClickerToolStripMenuItem.Click += new System.EventHandler(this.autoClickerToolStripMenuItem_Click);
            // 
            // cUiToolStripMenuItem
            // 
            this.cUiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cUI1ToolStripMenuItem});
            this.cUiToolStripMenuItem.Name = "cUiToolStripMenuItem";
            this.cUiToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.cUiToolStripMenuItem.Text = "C# ui";
            // 
            // cUI1ToolStripMenuItem
            // 
            this.cUI1ToolStripMenuItem.Name = "cUI1ToolStripMenuItem";
            this.cUI1ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.cUI1ToolStripMenuItem.Text = "C# UI 1";
            this.cUI1ToolStripMenuItem.Click += new System.EventHandler(this.cUI1ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 402);
            this.panel1.TabIndex = 1;
            // 
            // base64EnDecodeToolStripMenuItem
            // 
            this.base64EnDecodeToolStripMenuItem.Name = "base64EnDecodeToolStripMenuItem";
            this.base64EnDecodeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.base64EnDecodeToolStripMenuItem.Text = "Base64 En - Decode";
            this.base64EnDecodeToolStripMenuItem.Click += new System.EventHandler(this.base64EnDecodeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 426);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CreatorsStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.CreatorsStrip;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "OmegaProject";
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
        private System.Windows.Forms.ToolStripMenuItem aOBPatternFinderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoClickerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cUiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cUI1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem base64EnDecodeToolStripMenuItem;
    }
}

