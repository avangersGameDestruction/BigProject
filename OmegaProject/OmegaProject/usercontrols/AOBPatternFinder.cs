using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using System.Text.RegularExpressions;

namespace OmegaProject.usercontrols
{
    public partial class AOBPatternFinder : UserControl
    {
        private readonly List<char> Whitelist = new List<char>() { '?', '*', 'x', 'X' };
        private List<string> AOBS = new List<string>();
        private int OmegaProject = 0;
        public AOBPatternFinder()
        {
            InitializeComponent();
        }

        private bool OnWhitelist(char c) => Whitelist.Contains(c);

        private string ReplaceAt(string Input, int Index, char NewChar)
        {
            StringBuilder builder = new StringBuilder(Input);
            builder[Index] = NewChar;
            return builder.ToString();
        }

        private void WildcardString(ref string original, string others)
        {
            for(int i = 1; i < original.Length; i++)
            {
                try
                {
                    char originalChar = Convert.ToChar(original.Substring(i, 1));
                    char otherChar = Convert.ToChar(others.Substring(i, 1));

                    if (!OnWhitelist(originalChar))
                    {
                        if (originalChar != otherChar)
                        {
                            original = ReplaceAt(original, i, '?');
                        }
                    }
                } catch { Console.WriteLine("ok"); }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AOBS.Clear();

            AOBS.Add(textBox1.Text);
            AOBS.Add(textBox2.Text);
            AOBS.Add(textBox3.Text);
            AOBS.Add(textBox4.Text);
            AOBS.Add(textBox5.Text);

            string wc = AOBS[0];

            foreach(string AOB in AOBS) { WildcardString(ref wc, AOB); }
            textBox6.Text = wc;
            ProtectionSource();
        }

        private void ProtectionSource()
        {
            if (OmegaProject == 0)
            {
                button2.Enabled = true;
                textBox6.Enabled = false;
                OmegaProject = 1;
            }

            else
            {
                button2.Enabled = false;
                textBox6.Enabled = true;
                OmegaProject = 0;
            }
        }

        private static int SpaceCount(string Project)
        {
            int a = 0;
            string s;
            for (int i = 0; i < Project.Length; i++)
            {
                s = Project.Substring(i, 1);
                if (s == " ") { a++; }
            }
            return a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control TextBoxes in Controls) 
            {
                if(TextBoxes is MetroTextBox)
                {
                    string RemoveSpaces = Regex.Replace(TextBoxes.Text, @" ", "");
                    string AddSpaces = Regex.Replace(RemoveSpaces, ".{2}", "$0 ");
                    TextBoxes.Text = AddSpaces.Trim();
                }

                label1.Text = (textBox1.Text.Length - SpaceCount(textBox1.Text)) / 2 + " bytes";
                label2.Text = (textBox2.Text.Length - SpaceCount(textBox2.Text)) / 2 + " bytes";
                label3.Text = (textBox3.Text.Length - SpaceCount(textBox3.Text)) / 2 + " bytes";
                label4.Text = (textBox4.Text.Length - SpaceCount(textBox4.Text)) / 2 + " bytes";
                label5.Text = (textBox5.Text.Length - SpaceCount(textBox5.Text)) / 2 + " bytes";
                ProtectionSource();
            }
        }
    }
}
