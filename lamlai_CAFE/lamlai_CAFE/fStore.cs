using lamlai_CAFE.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lamlai_CAFE
{
    public partial class fStore : Form
    {
        public fStore()
        {
            InitializeComponent();
            Load_dtgv();

        }

        int rowIndex;

        #region method
        //hàm load dtgv

        public void Load_dtgv()
        {
            dtgvStore.Columns.Add("MA_NGUYEN_LIEU", "MA_NGUYEN_LIEU");
            dtgvStore.Columns.Add("TEN_NL", "TEN_NL");
            dtgvStore.Columns.Add("NGAY_NHAP", "NGAY_NHAP");
            dtgvStore.Columns.Add("GIA_NHAP", "GIA_NHAP");
            dtgvStore.Columns.Add("DVT", "DVT");
            dtgvStore.Columns.Add("SO_LUONG", "SOLUONG");

            dtgvStore.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            // đặt kích thước lại cho cột đầu 
            dtgvStore.Columns["MA_NGUYEN_LIEU"].Width = 110;
        }

        //hàm lấy dữ liệu biding từ List<STORE>
        public void BindGrid_dtgvStore (List<STORE> Stores)
        {
           
            dtgvStore.Rows.Clear();

            foreach(var item in Stores)
            {
                int index = dtgvStore.Rows.Add();
                dtgvStore.Rows[index].Cells[0].Value = item.MaterialID;
                dtgvStore.Rows[index].Cells[1].Value = item.NameMaterial;
                dtgvStore.Rows[index].Cells[2].Value = item.RecivedDate;
                dtgvStore.Rows[index].Cells[3].Value = item.SupplierPrice;
                dtgvStore.Rows[index].Cells[4].Value = item.Unit;
                dtgvStore.Rows[index].Cells[5].Value = item.Quantity;
            }
        }

        public void BindGrid_dtgvStore_dtpk()
        {

            dtgvStore.Rows.Clear();

            using (var dbContext = new StoreContextDB())
            {
                using (var command = dbContext.Database.Connection.CreateCommand())
                {
                    command.CommandText = "GetStoreByDate";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@FROMDAY", dtpkFrom.Value));
                    command.Parameters.Add(new SqlParameter("@TODAY", dtpkTo.Value));

                    dbContext.Database.Connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        var STORES = new List<STORE>();

                        while (reader.Read())
                        {
                            var store = new STORE
                            {
                                MaterialID = reader["MaterialID"].ToString(),
                                NameMaterial = reader["NameMaterial"].ToString(),
                                RecivedDate = Convert.ToDateTime(reader["RecivedDate"]),
                                SupplierPrice = Convert.ToInt32(reader["SupplierPrice"]),
                                Unit = reader["Unit"].ToString(),
                                Quantity = Convert.ToInt32(reader["Quantity"])
                            };

                            STORES.Add(store);
                        }

                        foreach (var item in STORES)
                        {
                            dtgvStore.Rows.Add(item.MaterialID, item.NameMaterial, item.RecivedDate, item.SupplierPrice, item.Unit,item.Quantity);
                        }
                    }
                }
            }

        }



        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void fStore_Load(object sender, EventArgs e)
        {
                StoreContextDB context = new StoreContextDB();
                List<STORE> lS = context.STOREs.ToList();

                BindGrid_dtgvStore(lS);
        }

        private void dtgvStore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (cbViewFull.Checked == true)
            {
                StoreContextDB context = new StoreContextDB();
                List<STORE> lS = context.STOREs.ToList();

                BindGrid_dtgvStore(lS);
            }
            else
            {
                BindGrid_dtgvStore_dtpk();
            }
            cbViewFull.Checked = false;
        }

        private void dtgvStore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;

            if (rowIndex > -1 && rowIndex < (dtgvStore.Rows.Count - 1))
            {
                DataGridViewRow selectedRow = dtgvStore.Rows[rowIndex];
                txbMaNL.Text = selectedRow.Cells[0].Value.ToString();
                txbTenNL.Text = selectedRow.Cells[1].Value.ToString();
                txbNgayNhap.Text = selectedRow.Cells[2].Value.ToString();
                txbGiaNhap.Text = selectedRow.Cells[3].Value.ToString();
                txbDVT.Text = selectedRow.Cells[4].Value.ToString();
                txbSoLuong.Text = selectedRow.Cells[5].Value.ToString();
            }
            else
            {
                MessageBox.Show("Vùng trống !");
                txbMaNL.Text = "";
                txbTenNL.Text = "";
                txbNgayNhap.Text = "";
                txbGiaNhap.Text = "";
                txbDVT.Text = "";
                txbSoLuong.Text = "";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StoreContextDB context = new StoreContextDB();
            STORE s = new STORE()
            {
                MaterialID = txbMaNL.Text.ToString(),
                NameMaterial = txbTenNL.Text.ToString(),
                RecivedDate = DateTime.Parse(txbNgayNhap.Text),
                SupplierPrice = int.Parse(txbGiaNhap.Text),
                Unit = txbDVT.Text.ToString(),
                Quantity = int.Parse(txbSoLuong.Text),
            };
            context.STOREs.Add(s);
            context.SaveChanges();
            List<STORE> lS = context.STOREs.ToList();
            BindGrid_dtgvStore(lS);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            StoreContextDB context = new StoreContextDB();
            STORE dbUpdate = context.STOREs.FirstOrDefault(p => p.MaterialID.ToString() == txbMaNL.Text.ToString());
            if (dbUpdate != null)
            {
                dbUpdate.NameMaterial = txbTenNL.Text.ToString();
                dbUpdate.RecivedDate = DateTime.Parse(txbNgayNhap.Text);
                dbUpdate.SupplierPrice = int.Parse(txbGiaNhap.Text);
                dbUpdate.Unit = txbDVT.Text.ToString();
                dbUpdate.Quantity = int.Parse(txbSoLuong.Text);

                context.SaveChanges();
                List<STORE> lS = context.STOREs.ToList();
                BindGrid_dtgvStore(lS);
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            StoreContextDB context = new StoreContextDB();
            STORE dbDelete = context.STOREs.FirstOrDefault(p => p.MaterialID.ToString() == txbMaNL.Text.ToString());
            if (dbDelete != null)
            {
                context.STOREs.Remove(dbDelete);
                context.SaveChanges();
                List<STORE> lS = context.STOREs.ToList();
                BindGrid_dtgvStore(lS);
            }
        }
    }
}
