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
    public partial class Base64EncodeDecode : UserControl
    {
        public Base64EncodeDecode()
        {
            InitializeComponent();
        }

        private static string Base64EncodingFunction(string EncodingText)
        {
            var encodingstring = Encoding.UTF8.GetBytes(EncodingText);
            return Convert.ToBase64String(encodingstring);
        }

        private static string Base64DecodeFunction(string DecodeText)
        {
            var EncodedText = Convert.FromBase64String(DecodeText);
            return Encoding.UTF8.GetString(EncodedText);
        }

        private void EncodeBtn_Click(object sender, EventArgs e)
        {
            EncodeStringPlacement.Text = Base64EncodingFunction(EncodeStringPlacement.Text);
        }

        private void DecodeBtn_Click(object sender, EventArgs e)
        {
            DecodeStringPlacement.Text = Base64DecodeFunction(DecodeStringPlacement.Text);
        }
    }
}
