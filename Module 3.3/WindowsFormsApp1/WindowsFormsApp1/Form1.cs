using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string st = "";
            DataTable ok = DataProvider.Data.ExcuteToDataTable("SELECT N4_GV_PB_DT_NCKH.MAGV, N4_GV_PB_DT_NCKH.MADT FROM N4_GV_PB_DT_NCKH", CommandType.Text);
            dgv.DataSource = ok;
            for (int i = 0; i < ok.Rows.Count; i++)
            {
                string a = dgv.Rows[i].Cells[0].Value.ToString();
                if (a == st)
                { 
                    txt.Text = txt.Text + dgv.Rows[i].Cells[1].Value.ToString() + " ";
                }
                else
                {
                    st = a;
                    txt.Text = txt.Text + "\r\n" + a + ": " + dgv.Rows[i].Cells[1].Value.ToString() +" ";
                }
        }
        }
    }
}
