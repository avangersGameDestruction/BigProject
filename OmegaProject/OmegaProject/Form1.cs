using OmegaProject.usercontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OmegaProject
{
    public partial class Form1 : Form
    {

        ArrayOfBytesConvertion ArrayOfBytes;

        private void ClearPanel()
        {
            if (ArrayOfBytes != null) ArrayOfBytes.Dispose();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void arrayOfBytesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearPanel();
            ArrayOfBytesConvertion AoB = new ArrayOfBytesConvertion();
            AoB.Dock = DockStyle.Fill;
            panel1.Controls.Add(AoB);
        }
    }
}
