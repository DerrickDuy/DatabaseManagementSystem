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

            SqlParameter[] sqls =
            {
                new SqlParameter ("@MAGV",txt.Text),
                new SqlParameter ("@MADT", txt2.Text)
            };
            DataTable ok = DataProvider.Data.ExcuteToDataTable("N4_M54", CommandType.StoredProcedure,sqls);
            dgv.DataSource = ok;
        }
    }
}
