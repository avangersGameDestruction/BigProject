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
        // calls of differend usercontrols
        ArrayOfBytesConvertion ArrayOfBytes;
        AOBPatternFinder AOBPatternFinder;
        autoclicker autoclicker;
        CsharpFirstUI CsharpFirstUI;
        Base64EncodeDecode Base64EncodeDecode;

        // private function to scan if any uc is open and close it if new go open
        private void ClearPanel()
        {
            if (ArrayOfBytes != null) ArrayOfBytes.Dispose();
            if (AOBPatternFinder != null) AOBPatternFinder.Dispose();
            if (autoclicker != null) autoclicker.Dispose();
            if (CsharpFirstUI != null) CsharpFirstUI.Dispose();
            if (Base64EncodeDecode != null) Base64EncodeDecode.Dispose();

            panel1.Controls.Remove(ArrayOfBytes);
        }

        public Form1()
        {
            InitializeComponent();
        }

        // opens arrayOfBytes uc
        private void arrayOfBytesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearPanel();
            panel1.Controls.Clear();
            ArrayOfBytesConvertion AoB = new ArrayOfBytesConvertion();
            AoB.Dock = DockStyle.Fill;
            panel1.Controls.Add(AoB);
        }

        // opens AOBPatternFinder
        private void aOBPatternFinderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearPanel();
            panel1.Controls.Clear();
            AOBPatternFinder patternFinder = new AOBPatternFinder();
            patternFinder.Dock = DockStyle.Fill;
            panel1.Controls.Add(patternFinder);
        }

        // opens auto clicker
        private void autoClickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearPanel();
            panel1.Controls.Clear();
            autoclicker autoclicker = new autoclicker();
            autoclicker.Dock = DockStyle.Fill;
            panel1.Controls.Add(autoclicker);
        }

        // opens Csharp ui design 1
        private void cUI1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearPanel();
            panel1.Controls.Clear();
            CsharpFirstUI csharp = new CsharpFirstUI();
            csharp.Dock = DockStyle.Fill;
            panel1.Controls.Add(csharp);
        }

        private void base64EnDecodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearPanel();
            panel1.Controls.Clear();
            Base64EncodeDecode base64 = new Base64EncodeDecode();
            base64.Dock = DockStyle.Fill;
            panel1.Controls.Add(base64);
        }
    }
}
