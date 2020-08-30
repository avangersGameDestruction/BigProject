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
        }

        private void ClearControlPanel()
        {
            ArrayOfBytesConvertion AoB = new ArrayOfBytesConvertion();
            AOBPatternFinder patternFinder = new AOBPatternFinder();
            autoclicker autoclicker = new autoclicker();
            CsharpFirstUI csharp = new CsharpFirstUI();

            panel1.Controls.Remove(AoB);
            panel1.Controls.Remove(patternFinder);
            panel1.Controls.Remove(autoclicker);
            panel1.Controls.Remove(csharp);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void arrayOfBytesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearPanel();
            ClearControlPanel();
            ArrayOfBytesConvertion AoB = new ArrayOfBytesConvertion();
            AoB.Dock = DockStyle.Fill;
            panel1.Controls.Add(AoB);
        }

        private void aOBPatternFinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearPanel();
            ClearControlPanel();
            AOBPatternFinder patternFinder = new AOBPatternFinder();
            patternFinder.Dock = DockStyle.Fill;
            panel1.Controls.Add(patternFinder);
        }

        private void autoClickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearPanel();
            ClearControlPanel();
            autoclicker autoclicker = new autoclicker();
            autoclicker.Dock = DockStyle.Fill;
            panel1.Controls.Add(autoclicker);
        }

        private void cUI1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearPanel();
            ClearControlPanel();
            CsharpFirstUI csharp = new CsharpFirstUI();
            csharp.Dock = DockStyle.Fill;
            panel1.Controls.Add(csharp);
        }
    }
}
