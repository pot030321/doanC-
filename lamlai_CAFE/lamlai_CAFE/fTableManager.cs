using DevExpress.XtraEditors;
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
    public partial class fTableManager : DevExpress.XtraEditors.XtraForm
    {
        public fTableManager()
        {
            InitializeComponent();
        }

        private void báoCáoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thoongTinTaiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile F = new fAccountProfile();
            //this.Hide();
            F.ShowDialog();
            //this.Show();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }
    }
}