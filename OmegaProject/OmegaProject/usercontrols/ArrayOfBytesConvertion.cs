using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace OmegaProject.usercontrols
{
    public partial class ArrayOfBytesConvertion : UserControl
    {
        public ArrayOfBytesConvertion()
        {
            InitializeComponent();
        }

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

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessList_GridView.Rows.Clear();
            GetListProcesses();
            ProcessList_GridView.Focus();
        }

        private void ProcessList_GridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
