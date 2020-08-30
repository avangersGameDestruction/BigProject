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
        /* for you to do is make a second panel if you need so not then not need to */


        static CsharpFirstUI UI;

        public static CsharpFirstUI Instance
        {
            get
            {
                if (UI == null)
                {
                    UI = new CsharpFirstUI();
                }
                return UI;
            }
        }

        public Panel PnlContainer
        {
            get { return panel5; }
            set { panel5 = value; }
        }

        public Button BackButton
        {
            get { return btnBack; }
            set { btnBack = value; }
        }

        public CsharpFirstUI()
        {
            InitializeComponent();
        }

        private void CsharpFirstUI_Load(object sender, EventArgs e)
        {
            btnBack.Visible = false;
            UI = this;

            ucHome home = new ucHome();
            home.Dock = DockStyle.Fill;
            panel5.Controls.Add(home);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panel5.Controls["UCHome"].BringToFront();
            btnBack.Visible = false;
        }
    }
}
