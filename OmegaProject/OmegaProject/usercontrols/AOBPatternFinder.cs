using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
