using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace OmegaProject.usercontrols
{
    public partial class autoclicker : UserControl
    {
        int Type = 0;

        // Dll imports
        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        public autoclicker()
        {
            InitializeComponent();
        }

        // starts the auto clicker + give information about click limit
        private void button1_Click(object sender, EventArgs e)
        {
            if ((int)numericUpDown1.Value < 300)
            {
                MessageBox.Show("Minimum Value is 300");
                return;
            }
            Type = comboBox2.SelectedIndex;
            timer1.Interval = (int)numericUpDown1.Value;
            timer1.Start();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        // stops the auto clicker
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button2.Enabled = false;
            button1.Enabled = true;
        }

        // implementing timer by scanning mouse clicks
        private void timer1_Tick(object sender, EventArgs e)
        {
            int cpt = 0;
            switch (Type)
            {
                case 0:
                    sendMouseUp(); 
                    sendMouseDown();
                    break;

                case 1:
                    sendMouseDoubleClick();
                    break;

                default:
                    break;
            }
        }

        void sendMouseRightclick()
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN | MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
        }

        void sendMouseDoubleClick()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        // scans down click
        void sendMouseDown()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
        }

        // scans when mouse got pressed and clicker did go back up
        void sendMouseUp()
        {
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        // call function for GlobalKeyBoardHook
        GlobalKeyBoardHook gHook;

        // GlobalKeyBoardHook gets loaded + scans for keys who get presses
        private void autoclicker_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 0;
            button2.Enabled = false;

            gHook = new GlobalKeyBoardHook();
            gHook.KeyDown += new KeyEventHandler(gHook_KeyDown);
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
            {
                gHook.HookedKeys.Add(key);
            }
            
            gHook.hook();
        }

        // short cut handler
        public void gHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                if ((int)numericUpDown1.Value < 300)
                {
                    MessageBox.Show("Minimum Value is 300");
                    return;
                }
                Type = comboBox2.SelectedIndex;
                timer1.Interval = Type == 0 ? (int)numericUpDown1.Value : 200;
                timer1.Start();
                button1.Enabled = false;
                button2.Enabled = true;
            }
            if (e.KeyCode == Keys.F3)
            {
                timer1.Stop();

                button2.Enabled = false;
                button1.Enabled = true;
            }
        }
    }
}
