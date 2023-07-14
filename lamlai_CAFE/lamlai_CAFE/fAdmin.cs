using DevExpress.XtraEditors;
using lamlai_CAFE.DAO;
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

namespace lamlai_CAFE
{
    public partial class fAdmin : DevExpress.XtraEditors.XtraForm
    {
        public fAdmin()
        {
            InitializeComponent();
            //LoadAccountList();
        }

        void LoadAccountList ()
        {
            #region noneDataProvider
            /*
            string connectionSTR = " Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyQuanCafe;Integrated Security=True ";
            SqlConnection connection =  new SqlConnection(connectionSTR);

            string query = "SELECT DISPLAYNAME AS [TÊN HIỂN THỊ] FROM ACCOUNT";

            connection.Open ();

            SqlCommand command = new SqlCommand(query, connection);

            DataTable data = new DataTable();

            SqlDataAdapter adapter= new SqlDataAdapter(command);

            adapter.Fill (data);

            connection.Close ();

            dtgvAccount.DataSource = data; // đưa datasource tự động hiển thị lên
            */

            #endregion

            string query = "EXEC USP_GetAccountByUserName @userName  ";

            /* khi không xài singleton
            DataProvider provider= new DataProvider();

            dtgvAccount.DataSource = provider.ExecuteQuery(query,new object[] { "staff" });
            */

            dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { "A1"});
        }

        void LoadFoodList()
        {
            string query = "SELECT * FROM FOOD";
            dtgvFood.DataSource = DataProvLL.Instance.ExecuteQuery(query);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tpBill_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AccountPage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fAdmin_Load(object sender, EventArgs e)
        {

        }

        private void dtgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}