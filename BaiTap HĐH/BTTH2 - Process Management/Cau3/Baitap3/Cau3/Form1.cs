using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTaiungdung_Click(object sender, EventArgs e)
        {
            Process[] processlist = Process.GetProcesses();
            listView1.Items.Clear();
            foreach (Process theprocess in processlist)
            {
                string[] arr = new string[2];
                arr[0] = theprocess.ProcessName;
                arr[1] = theprocess.Id.ToString();
                ListViewItem item = new ListViewItem(arr);
                listView1.Items.Add(item);
            }
        }

        private void btnDongungdung_Click(object sender, EventArgs e)
        {
            Process _proceses = Process.GetProcessById(Convert.ToInt32(listView1.SelectedItems[0].SubItems[1].Text));
            _proceses.Kill();
        }
    }
}
