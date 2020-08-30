using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OmegaProject.usercontrols.ui_1
{
    public partial class ucHome : UserControl
    {
        public ucHome()
        {
            InitializeComponent();
        }

        // make the CsharpFirstUI calculate what uc is active and if the return arrow got clicked it replace the fame window to the home window
        private void button1_Click(object sender, EventArgs e)
        {
            if (!CsharpFirstUI.Instance.PnlContainer.Controls.ContainsKey("UCNext"))
            {
                UCNext un = new UCNext();
                un.Dock = DockStyle.Fill;
                CsharpFirstUI.Instance.PnlContainer.Controls.Add(un);
            }
            CsharpFirstUI.Instance.PnlContainer.Controls["UCNext"].BringToFront();
            CsharpFirstUI.Instance.BackButton.Visible = true;
        }
    }
}
