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
using System.IO;

namespace karaoke.UI.Modules
{
    public partial class importstort : DevExpress.XtraEditors.XtraUserControl
    {
        public importstort()
        {
            InitializeComponent();
            load();
            txtId.ReadOnly = true;
            txtName.ReadOnly = true;
            txtIditem.ReadOnly = true;
            txtNameitem.ReadOnly = true;
            sAmount.ReadOnly = true;
            sPrice.ReadOnly = true;
            dDate.ReadOnly = true;
            txtCompany.ReadOnly = true;
            mmAdress.ReadOnly = true;
            btnSave.Enabled = false;
        }

        public void load()
        {
            txtId.ReadOnly = true;
            txtName.ReadOnly = true;
            txtIditem.ReadOnly = true;
            txtNameitem.ReadOnly = true;
            sAmount.ReadOnly = true;
            sPrice.ReadOnly = true;
            dDate.ReadOnly = true;
            txtCompany.ReadOnly = true;
            mmAdress.ReadOnly = true;
            btnSave.Enabled = false;
            txtId.Text = String.Empty;
            txtName.Text = String.Empty;
            txtIditem.Text = String.Empty;
            txtNameitem.Text = String.Empty;
            sAmount.Text = String.Empty;
            sPrice.Text = String.Empty;
            dDate.Text = String.Empty;
            txtCompany.Text = String.Empty;
            mmAdress.Text = String.Empty;
            data.DataSource = bus_importitem.Instance.FillImportItmes();
            checkstatus = 0;
        }

        private int checkstatus = 0;

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

        private void data_Click(object sender, EventArgs e)
        {
            txtId.DataBindings.Clear();
            txtId.DataBindings.Add("text", data.DataSource, "mahoadon");
            txtName.DataBindings.Clear();
            txtName.DataBindings.Add("text", data.DataSource, "tenhoadon");
            txtIditem.DataBindings.Clear();
            txtIditem.DataBindings.Add("text", data.DataSource, "mamathang");
            txtNameitem.DataBindings.Clear();
            txtNameitem.DataBindings.Add("text", data.DataSource, "tenmathang");
            sAmount.DataBindings.Clear();
            sAmount.DataBindings.Add("text", data.DataSource, "soluong");
            sPrice.DataBindings.Clear();
            sPrice.DataBindings.Add("text", data.DataSource, "gia");
            dDate.DataBindings.Clear();
            dDate.DataBindings.Add("text", data.DataSource, "ngaynhap");
            txtCompany.DataBindings.Clear();
            txtCompany.DataBindings.Add("text", data.DataSource, "congty");
            mmAdress.DataBindings.Clear();
            mmAdress.DataBindings.Add("text", data.DataSource, "diachi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (bus_importitem.Instance.DeleteImportItems(txtId.Text).Equals(true))
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            load();
            txtId.ReadOnly = false;
            txtName.ReadOnly = false;
            txtIditem.ReadOnly = false;
            txtNameitem.ReadOnly = false;
            sAmount.ReadOnly = false;
            sPrice.ReadOnly = false;
            dDate.ReadOnly = false;
            txtCompany.ReadOnly = false;
            mmAdress.ReadOnly = false;
            btnSave.Enabled = true;
            txtId.Focus();
            checkstatus = 1;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            checkstatus = 0;
            btnSave.Enabled = true;
            txtId.ReadOnly = true;
            txtName.ReadOnly = true;
            txtIditem.ReadOnly = true;
            txtNameitem.ReadOnly = true;
            sAmount.ReadOnly = true;
            sPrice.ReadOnly = true;
            dDate.ReadOnly = true;
            txtCompany.ReadOnly = true;
            mmAdress.ReadOnly = true;
            txtId.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                String mhd = txtId.Text;
                String thd = txtName.Text;
                String mhh = txtIditem.Text;
                String thh = txtNameitem.Text;
                int sl = Int32.Parse(sAmount.Text);
                int gia = Int32.Parse(sPrice.Text);
                DateTime d = DateTime.Parse(dDate.Text);
                String tct = txtCompany.Text;
                String dc = mmAdress.Text;
                if (checkstatus == 1)
                {
                    if (bus_importitem.Instance.InsertImportItem(mhd, thd, mhh, thh, sl, gia, d, tct, dc).Equals(true))
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (bus_importitem.Instance.UpdateImportItems(mhd, thd, mhh, thh, sl, gia, d, tct, dc).Equals(true))
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                if (checkstatus == 1)
                {
                    MessageBox.Show("Lưu ý mã nhân viên không được trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}

