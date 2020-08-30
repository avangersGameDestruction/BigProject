using System;
using System.Diagnostics;
using System.Windows.Forms;
using static OmegaProject.Helpers;

namespace OmegaProject.usercontrols
{
    public partial class ArrayOfBytesConvertion : UserControl
    {
        // calculates the bytes / bools / array of bytes and make it auto change when filled in
        public ArrayOfBytesConvertion()
        {
            InitializeComponent();
            textBox1.DataBindings.Add("Text", Converter, "FourByte", false, DataSourceUpdateMode.OnPropertyChanged);
            textBox2.DataBindings.Add("Text", Converter, "FourByte_x8", false, DataSourceUpdateMode.OnPropertyChanged);
            textBox3.DataBindings.Add("Text", Converter, "FourByte_x8_p6", false, DataSourceUpdateMode.OnPropertyChanged);
            textBox4.DataBindings.Add("Text", Converter, "Hex", true, DataSourceUpdateMode.OnPropertyChanged, 0, "X");
            textBox5.DataBindings.Add("Text", Converter, "U30", true, DataSourceUpdateMode.OnPropertyChanged, 0, "X");
            textBox6.DataBindings.Add("Text", Converter, "Ieeex32", true, DataSourceUpdateMode.OnPropertyChanged, 0, "X");
            textBox7.DataBindings.Add("Text", Converter, "Ieeex64", true, DataSourceUpdateMode.OnPropertyChanged, 0, "X");
            textBox8.DataBindings.Add("Text", Converter, "UnityFloatx32", true, DataSourceUpdateMode.OnPropertyChanged, 1, "X");
            ProcessList_GridView.DefaultCellStyle.SelectionBackColor = ProcessList_GridView.DefaultCellStyle.BackColor;
            ProcessList_GridView.DefaultCellStyle.SelectionForeColor = ProcessList_GridView.DefaultCellStyle.ForeColor;
            GetListProcesses();
        }

        // scanner for find all running processes in the background and foreground
        private void GetListProcesses()
        {
            Process[] processes = Process.GetProcesses();
            Array.Sort(processes, (x, y) => String.Compare(x.ToString(), y.ToString()));
            for (int i = 0; i < processes.Length; i++)
            {
                int ProcessListVieuwAdding = ProcessList_GridView.Rows.Add();
                ProcessList_GridView.Rows[ProcessListVieuwAdding].Cells[0].Value = processes[i].ProcessName;
                ProcessList_GridView.Rows[ProcessListVieuwAdding].Cells[1].Value = processes[i].Id;
                ProcessList_GridView.Rows[ProcessListVieuwAdding].Cells[2].Value = processes[i].Id.ToString("X");
            }
        }

        // makes you refresh the ProcessList_GridView_CellContent
        private void button1_Click(object sender, EventArgs e)
        {
            ProcessList_GridView.Rows.Clear();
            GetListProcesses();
            ProcessList_GridView.Focus();
        }

        // let you be able to copy the information of the ProcessList_GridView_CellContent
        private void ProcessList_GridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clipboard.SetText(ProcessList_GridView[e.ColumnIndex, e.RowIndex].Value.ToString());
            MessageBox.Show(Clipboard.GetText() + "Copied to Clipboard");
        }
    }
}
