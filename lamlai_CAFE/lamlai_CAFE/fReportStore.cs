using lamlai_CAFE.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lamlai_CAFE
{
    public partial class fReportStore : Form
    {
        public fReportStore()
        {
            InitializeComponent();
        }

        private void fReportStore_Load(object sender, EventArgs e)
        {
            StoreContextDB context = new StoreContextDB();
            List<STORE> listSTORE = context.STOREs.ToList();
            List<StoreReport> lSR = new List<StoreReport>();

            foreach(STORE i in listSTORE)
            {
                StoreReport temp = new StoreReport();
                temp.MaterialID = i.MaterialID;
                temp.NameMaterial = i.NameMaterial;
                temp.RecivedDate = i.RecivedDate;
                temp.SupplierPrice = i.SupplierPrice;
                temp.Unit = i.Unit;
                temp.Quantity = i.Quantity;

                lSR.Add(temp);
            }
            this.reportViewer1.LocalReport.ReportPath= "C:\\Users\\Admin\\Desktop\\DOAN\\lamlai_CAFE\\lamlai_CAFE\\StoreReport.rdlc";
            var RDataSource = new ReportDataSource("StoreDataSet", lSR);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(RDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
