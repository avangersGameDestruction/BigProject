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
        AOBPatternFinder AOBPatternFinder;
        autoclicker autoclicker;
        CsharpFirstUI CsharpFirstUI;

        private void ClearPanel()
        {
            if (ArrayOfBytes != null) ArrayOfBytes.Dispose();
            if (AOBPatternFinder != null) AOBPatternFinder.Dispose();
            if (autoclicker != null) autoclicker.Dispose();
            if (CsharpFirstUI != null) CsharpFirstUI.Dispose();

            panel1.Controls.Remove(ArrayOfBytes);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void arrayOfBytesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearPanel();
            panel1.Controls.Clear();
            ArrayOfBytesConvertion AoB = new ArrayOfBytesConvertion();
            AoB.Dock = DockStyle.Fill;
            panel1.Controls.Add(AoB);
        }

        private void aOBPatternFinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearPanel();
            panel1.Controls.Clear();
            AOBPatternFinder patternFinder = new AOBPatternFinder();
            patternFinder.Dock = DockStyle.Fill;
            panel1.Controls.Add(patternFinder);
        }

        private void autoClickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearPanel();
            panel1.Controls.Clear();
            autoclicker autoclicker = new autoclicker();
            autoclicker.Dock = DockStyle.Fill;
            panel1.Controls.Add(autoclicker);
        }

        private void cUI1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearPanel();
            panel1.Controls.Clear();
            CsharpFirstUI csharp = new CsharpFirstUI();
            csharp.Dock = DockStyle.Fill;
            panel1.Controls.Add(csharp);
        }
    }
}
