using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Windows.Forms;

namespace ThucHanh01
{
    public partial class FHocSinh : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public FHocSinh()
        {
            InitializeComponent();
        }

       
        

      
    }
}
