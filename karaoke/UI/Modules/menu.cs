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
using BUS;
using DTO;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;

namespace karaoke.UI.Modules
{
    public partial class menu : DevExpress.XtraEditors.XtraUserControl
    {
        public menu()
        {
            InitializeComponent();
            load();
            loadroom();
            txtCustomer.Enabled = true;
            cboSales.Enabled = true;
        }

        public void load()
        {
            data.DataSource = bus_menu.Instance.FillReceipt();
        }

        public void loadroom()
        {
            cboRoom.Properties.Items.Clear();
            DataTable listreceipts = bus_menu.Instance.FillReceipt();
            foreach ( DataRow Items in listreceipts.Rows)
            {
                cboRoom.Properties.Items.Add(Items["maphong"]);
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if ( bus_menu.Instance.DeleteReceipt(lblMahoadon.Text).Equals(true))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load();
                }    
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
                
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                if (bus_menu.Instance.FillInserReceipt(cboRoom.Text).Equals(true))
                {
                    report rpt = new report();
                    rpt.CreateDocument();
                    rpt.ShowPreviewDialog();
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void data_Click(object sender, EventArgs e)
        {
            lblMahoadon.DataBindings.Clear();
            lblMahoadon.DataBindings.Add("text", data.DataSource, "mahoadon");
        }
    }
}
