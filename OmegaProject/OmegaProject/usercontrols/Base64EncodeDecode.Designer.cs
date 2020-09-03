namespace OmegaProject.usercontrols
{
    partial class Base64EncodeDecode
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EncodeStringPlacement = new MetroFramework.Controls.MetroTextBox();
            this.DecodeStringPlacement = new MetroFramework.Controls.MetroTextBox();
            this.EncodeBtn = new MetroFramework.Controls.MetroButton();
            this.DecodeBtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // EncodeStringPlacement
            // 
            this.EncodeStringPlacement.Location = new System.Drawing.Point(3, 47);
            this.EncodeStringPlacement.Name = "EncodeStringPlacement";
            this.EncodeStringPlacement.Size = new System.Drawing.Size(760, 23);
            this.EncodeStringPlacement.TabIndex = 0;
            // 
            // DecodeStringPlacement
            // 
            this.DecodeStringPlacement.Location = new System.Drawing.Point(3, 178);
            this.DecodeStringPlacement.Name = "DecodeStringPlacement";
            this.DecodeStringPlacement.Size = new System.Drawing.Size(760, 23);
            this.DecodeStringPlacement.TabIndex = 1;
            // 
            // EncodeBtn
            // 
            this.EncodeBtn.Location = new System.Drawing.Point(3, 76);
            this.EncodeBtn.Name = "EncodeBtn";
            this.EncodeBtn.Size = new System.Drawing.Size(760, 23);
            this.EncodeBtn.TabIndex = 2;
            this.EncodeBtn.Text = "Encode the string you did input";
            this.EncodeBtn.Click += new System.EventHandler(this.EncodeBtn_Click);
            // 
            // DecodeBtn
            // 
            this.DecodeBtn.Location = new System.Drawing.Point(3, 207);
            this.DecodeBtn.Name = "DecodeBtn";
            this.DecodeBtn.Size = new System.Drawing.Size(760, 23);
            this.DecodeBtn.TabIndex = 3;
            this.DecodeBtn.Text = "Decode the Encoded string you did input";
            this.DecodeBtn.Click += new System.EventHandler(this.DecodeBtn_Click);
            // 
            // Base64EncodeDecode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DecodeBtn);
            this.Controls.Add(this.EncodeBtn);
            this.Controls.Add(this.DecodeStringPlacement);
            this.Controls.Add(this.EncodeStringPlacement);
            this.Name = "Base64EncodeDecode";
            this.Size = new System.Drawing.Size(766, 402);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox EncodeStringPlacement;
        private MetroFramework.Controls.MetroTextBox DecodeStringPlacement;
        private MetroFramework.Controls.MetroButton EncodeBtn;
        private MetroFramework.Controls.MetroButton DecodeBtn;
    }
}
