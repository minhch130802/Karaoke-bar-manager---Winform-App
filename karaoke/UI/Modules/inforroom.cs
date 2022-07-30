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
using System.IO;

namespace karaoke.UI.Modules
{
    public partial class inforroom : DevExpress.XtraEditors.XtraUserControl
    {
        public inforroom()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            data.DataSource = bus_inforroom.Instance.FillRoom();
            cboType.Properties.Items.Add("Thường");
            cboType.Properties.Items.Add("Vip");
            cboType.Text = "Thường";
            cboStatus.Properties.Items.Add("Bình thường");
            cboStatus.Properties.Items.Add("Đang sửa chữa");
            cboStatus.Text = "Bình thường";
            cboStament.Properties.Items.Add("Trống");
            cboStament.Properties.Items.Add("Đầy");
            cboStament.Text = "Trống";
            txtId.ReadOnly = true;
            txtName.ReadOnly = true;
            cboType.ReadOnly = true;
            cboStament.ReadOnly = true;
            sPrice.ReadOnly = true;
            cboStatus.ReadOnly = true;
            dStartday.ReadOnly = true;
            dEndday.ReadOnly = true;
            btnSave.Enabled = false;
        }

        protected bool checkDayEnd()
        {
            bool check = false;
            int result = DateTime.Compare(DateTime.Parse(dEndday.Text), DateTime.Parse(dStartday.Text));
            if (result <= 0)
            {
                errorProvider1.SetError(dEndday, "Ngày kết thúc phải sau ngày bắt đầu");
            }
            else
            {
                errorProvider1.SetError(dEndday, "");
                check = true;
            }
            return check;
        }

        protected bool checkPrice()
        {
            bool check = false;
            if (Int32.Parse(sPrice.Text) < 0)
            {
                errorProvider1.SetError(sPrice, "Yêu cầu nhập giá là một số nguyên dương");
            }
            else
            {
                errorProvider1.SetError(dEndday, "");
                check = true;
            }
            return check;
        }

        protected bool checkId()
        {
            bool check = false;
            Regex r = new Regex("^[a-zA-Z0-9]*$");
            if (!r.IsMatch(txtId.Text) || txtId.Text == "")
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

        protected bool checkName()
        {
            bool check = false;
            Regex r = new Regex("^[0-9]*$");
            if (r.IsMatch(txtName.Text) || txtName.Text == "")
                errorProvider1.SetError(txtName, "Vui lòng nhập đúng định dạng tên nhân viên!");
            else
            {
                errorProvider1.SetError(txtName, "");
                check = true;
            }
            return check;
        }

        //Add data
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtId.ReadOnly = false;
            txtName.ReadOnly = false;
            cboType.ReadOnly = false;
            cboStament.ReadOnly = false;
            sPrice.ReadOnly = false;
            cboStatus.ReadOnly = false;
            dStartday.ReadOnly = false;
            dEndday.ReadOnly = false;
            btnSave.Enabled = true;
            //emty
            txtId.Text = String.Empty;
            txtName.Text = String.Empty;
            cboType.Text = "Thường";
            cboStament.Text = "Trống";
            sPrice.Text = String.Empty;
            cboStatus.Text = "Bình thường";
            dStartday.Text = String.Empty;
            dEndday.Text = String.Empty;
        }

        //Save data
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if( checkName().Equals(true) && checkId().Equals(true) && checkDayEnd().Equals(true) && checkPrice().Equals(true))
                {
                    String mp = txtId.Text;
                    String tp = txtName.Text;
                    String lp = cboType.Text;
                    String tt = cboStament.Text;
                    int gp = Int32.Parse(sPrice.Text);
                    String sc = cboStatus.Text;
                    DateTime ts = dStartday.DateTime;
                    DateTime te = dEndday.DateTime;
                    if (bus_inforroom.instance.CheckIdInforRoom(mp).Equals(true))
                    {
                        if (bus_inforroom.Instance.UpdateRoom(mp, tp, lp, tt, gp, sc, ts, te).Equals(true))
                        {
                            load();
                            MessageBox.Show("Lưu thành công!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                    }
                    else
                    {
                        if (bus_inforroom.Instance.InsertRoom(mp, tp, lp, tt, gp, sc, ts, te).Equals(true))
                        {
                            load();
                            MessageBox.Show("Thêm thành công!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                    }
                    txtId.ReadOnly = true;
                    txtName.ReadOnly = true;
                    cboType.ReadOnly = true;
                    cboStament.ReadOnly = true;
                    sPrice.ReadOnly = true;
                    cboStatus.ReadOnly = true;
                    dStartday.ReadOnly = true;
                    dEndday.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        //Delete data
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String mp = txtId.Text;
                if (bus_inforroom.Instance.DeleteRoom(mp).Equals(true))
                {
                    load();
                    MessageBox.Show("Xóa thành công!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            
        }

        //button change
        private void btnChange_Click(object sender, EventArgs e)
        {
            txtId.ReadOnly = false;
            txtName.ReadOnly = false;
            cboType.ReadOnly = false;
            cboStament.ReadOnly = false;
            sPrice.ReadOnly = false;
            cboStatus.ReadOnly = false;
            dStartday.ReadOnly = false;
            dEndday.ReadOnly = false;
            btnSave.Enabled = true;
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            txtId.DataBindings.Clear();
            txtId.DataBindings.Add("text", data.DataSource, "maphong");
            txtName.DataBindings.Clear();
            txtName.DataBindings.Add("text", data.DataSource, "tenphong");
            cboType.DataBindings.Clear();
            cboType.DataBindings.Add("text", data.DataSource, "loaiphong");
            sPrice.DataBindings.Clear();
            sPrice.DataBindings.Add("text", data.DataSource, "giaphong");
            cboStament.DataBindings.Clear();
            cboStament.DataBindings.Add("text", data.DataSource, "trangthai");
            cboStatus.DataBindings.Clear();
            cboStatus.DataBindings.Add("text", data.DataSource, "suachua");
            dStartday.DataBindings.Clear();
            dStartday.DataBindings.Add("text", data.DataSource, "ngaybatdat");
            dEndday.DataBindings.Clear();
            dEndday.DataBindings.Add("text", data.DataSource, "ngayketthuc");
            txtId.ReadOnly = true;
            txtName.ReadOnly = true;
            cboType.ReadOnly = true;
            cboStament.ReadOnly = true;
            sPrice.ReadOnly = true;
            cboStatus.ReadOnly = true;
            dStartday.ReadOnly = true;
            dEndday.ReadOnly = true;
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
