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
using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
using System.IO;

namespace karaoke.UI.Modules
{
    public partial class sales : DevExpress.XtraEditors.XtraUserControl
    {
        public sales()
        {
            InitializeComponent();
            load();
        }

        //Check infor
        protected bool checkId()
        {
            bool check = false;
            Regex r = new Regex("^[a-zA-Z0-9]*$");
            if (!r.IsMatch(txtId.Text) || txtId.Text == "" )
            {
                errorProvider1.SetError(txtId, "Vui lòng nhập đúng định dạng mã khuyến mãi!");
            }
            else
            {
                errorProvider1.SetError(txtId, "");
                check = true;
            }
            return check;
        }

        protected bool checkDayStart()
        {
            bool check = false;
            if ( dTimestart.Text == "")
            {
                errorProvider1.SetError(dTimestart, "Vui lòng chọn ngày bắt đầu!");
            }
            else
            {
                errorProvider1.SetError(dTimestart, "");
                check = true;
            }       
            return check;
        }

        protected bool checkSpin( SpinEdit btn )
        {
            bool check = false;
            if ( Int32.Parse(btn.Text) < 1 )
            {
                errorProvider1.SetError(btn, "Yêu cầu nhập đúng số lượng");
            }
            else
            {
                errorProvider1.SetError(btn, "");
                check = true;
            }    
            return check;
        }

        protected bool checkDayEnd()
        {
            bool check = false;
            int result = DateTime.Compare(DateTime.Parse(dTimeend.Text), DateTime.Parse(dTimestart.Text));
            if ( result <= 0 )
            {
                errorProvider1.SetError(dTimeend, "Ngày kết thúc phải sau ngày bắt đầu");
            }    
            else
            {
                errorProvider1.SetError(dTimeend, "");
                check = true;
            }    
            return check;
        }

        private void load()
        {
            data.DataSource = bus_sales.Instance.FillSales();
            txtId.ReadOnly = true;
            dTimestart.ReadOnly = true;
            dTimeend.ReadOnly = true;
            sRate.ReadOnly = true;
            sAmount.ReadOnly = true;
            btnSave.Enabled = false;
        }
        
        //Insertdata
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtId.ReadOnly = false;
            dTimestart.ReadOnly = false;
            dTimeend.ReadOnly = false;
            sRate.ReadOnly = false;
            sAmount.ReadOnly = false;
            btnSave.Enabled = true;
            //emty
            txtId.Text = String.Empty;
            dTimestart.Text = String.Empty;
            dTimeend.Text = String.Empty;
            sRate.Text = String.Empty;
            sAmount.Text = String.Empty;
        }

        //Save data
        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                if (checkId().Equals(true) && checkDayStart().Equals(true) && checkDayEnd().Equals(true) && checkSpin(sAmount).Equals(true) && checkSpin(sRate).Equals(true))
                {
                    String mkm = txtId.Text;
                    DateTime ts = dTimestart.DateTime;
                    DateTime te = dTimeend.DateTime;
                    int tlgg = Int32.Parse(sRate.Text);
                    int sl = Int32.Parse(sAmount.Text);
                    if (bus_sales.Instance.CheckIdSales(mkm).Equals(true))
                    {
                        if (bus_sales.Instance.UpdatetSales(mkm, ts, te, tlgg, sl).Equals(true))
                        {
                            load();
                            MessageBox.Show("Lưu thành công!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                    }
                    else
                    {
                        if (bus_sales.Instance.InsertSales(mkm, ts, te, tlgg, sl).Equals(true))
                        {
                            load();
                            MessageBox.Show("Thêm thành công!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                    }
                    txtId.ReadOnly = true;
                    dTimestart.ReadOnly = true;
                    dTimeend.ReadOnly = true;
                    sRate.ReadOnly = true;
                    sAmount.ReadOnly = true;
                    btnSave.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        //Buttton change
        private void btnChange_Click(object sender, EventArgs e)
        {
            txtId.ReadOnly = false;
            dTimestart.ReadOnly = false;
            dTimeend.ReadOnly = false;
            sRate.ReadOnly = false;
            sAmount.ReadOnly = false;
            btnSave.Enabled = true;
        }

        //Delete data
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String mkm = txtId.Text;
                if (bus_sales.Instance.DeleteSales(mkm).Equals(true))
                {
                    load();
                    MessageBox.Show("Xóa thành công!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            txtId.DataBindings.Clear();
            txtId.DataBindings.Add("text", data.DataSource, "makhuyenmai");
            dTimestart.DataBindings.Clear();
            dTimestart.DataBindings.Add("text", data.DataSource, "timestart");
            dTimeend.DataBindings.Clear();
            dTimeend.DataBindings.Add("text", data.DataSource, "timeend");
            sRate.DataBindings.Clear();
            sRate.DataBindings.Add("text", data.DataSource, "tilegiamgia");
            sAmount.DataBindings.Clear();
            sAmount.DataBindings.Add("text", data.DataSource, "soluong");
            txtId.ReadOnly = true;
            dTimestart.ReadOnly = true;
            dTimeend.ReadOnly = true;
            sRate.ReadOnly = true;
            sAmount.ReadOnly = true;
            btnSave.Enabled = false;
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
                saveDialog.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx |RichText File (.rtf)|*.rtf |Pdf File (.pdf)|*.pdf |Html File (.html)|*.html";
                if (saveDialog.ShowDialog() != DialogResult.Cancel)
                {
                    string exportFilePath = saveDialog.FileName;
                    string fileExtenstion = new FileInfo(exportFilePath).Extension;

                    switch (fileExtenstion)
                    {
                        case ".xls":
                            data.ExportToXls(exportFilePath);
                            break;
                        case ".xlsx":
                            data.ExportToXlsx(exportFilePath);
                            break;
                        case ".rtf":
                            data.ExportToRtf(exportFilePath);
                            break;
                        case ".pdf":
                            data.ExportToPdf(exportFilePath);
                            break;
                        case ".html":
                            data.ExportToHtml(exportFilePath);
                            break;
                        case ".mht":
                            data.ExportToMht(exportFilePath);
                            break;
                        default:
                            break;
                    }

                    if (File.Exists(exportFilePath))
                    {
                        try
                        {
                            //Try to open the file and let windows decide how to open it.
                            System.Diagnostics.Process.Start(exportFilePath);
                        }
                        catch
                        {
                            String msg = "The file could not be opened." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                            MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        String msg = "The file could not be saved." + Environment.NewLine + Environment.NewLine + "Path: " + exportFilePath;
                        MessageBox.Show(msg, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                if (e.RowHandle % 2 == 0)
                {
                    e.Appearance.BackColor = Color.LightGray;
                }
            }
        }
    }
}
