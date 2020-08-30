using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OmegaProject.usercontrols.ui_1;

namespace OmegaProject.usercontrols
{
    public partial class CsharpFirstUI : UserControl
    {
        public CsharpFirstUI()
        {
            InitializeComponent();
        }

        private void CsharpFirstUI_Load(object sender, EventArgs e)
        {
            ucHome home = new ucHome();
            home.Dock = DockStyle.Fill;
            panel5.Controls.Add(home);
        }
    }
}
