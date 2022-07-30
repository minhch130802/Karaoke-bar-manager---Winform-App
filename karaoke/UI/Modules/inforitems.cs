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
    public partial class inforitems : DevExpress.XtraEditors.XtraUserControl
    {
        public inforitems()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            data.DataSource = bus_inforitems.Instance.FillItems();
            cbotype.Properties.Items.Add("Đồ ăn");
            cbotype.Properties.Items.Add("Nước uống");
            cbotype.Text = "Đồ ăn";
            txtId.ReadOnly = true;
            txtName.ReadOnly = true;
            sAmount.ReadOnly = true;
            sPrice.ReadOnly = true;
            cbotype.ReadOnly = true;
            btnSave.Enabled = false;
        }

        private byte[] ImgToByte(PictureEdit picture)
        {
            MemoryStream memoryStream = new MemoryStream();
            picture.Image.Save(memoryStream, picture.Image.RawFormat);
            return memoryStream.ToArray();
        }

        private void btnBro_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Chọn ảnh";
            file.Filter = "image Files(*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *png) | *.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *png";
            if (file.ShowDialog() == DialogResult.OK)
            {
                ptrAvatar.Image = Image.FromFile(file.FileName);
            }
        }

        //Add data
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtId.ReadOnly = false;
            txtName.ReadOnly = false;
            sAmount.ReadOnly = false;
            sPrice.ReadOnly = false;
            cbotype.ReadOnly = false;
            btnSave.Enabled = true;
            //emty
            cbotype.Text = "Đồ ăn";
            txtId.Text = String.Empty;
            txtName.Text = String.Empty;
            sAmount.Text = String.Empty;
            sPrice.Text = String.Empty;
        }

        //Save data
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                String mmt = txtId.Text;
                String tmh = txtName.Text;
                int sl = Int32.Parse(sAmount.Text);
                int gia = Int32.Parse(sPrice.Text);
                String loai = cbotype.Text;
                bool isNullOrEmpty = ptrAvatar == null || ptrAvatar.Image == null;
                if (bus_inforitems.Instance.checkid(mmt).Equals(true))
                {
                    if ( !isNullOrEmpty.Equals(true))
                    {
                        byte[] img = ImgToByte(ptrAvatar);
                        if (bus_inforitems.Instance.UpdateItems(mmt, tmh, sl, gia, loai, img).Equals(true))
                        {
                            load();
                            MessageBox.Show("Lưu thành công!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                    }
                    else
                    {
                        if (bus_inforitems.Instance.UpdateNoItems(mmt, tmh, sl, gia, loai).Equals(true))
                        {
                            load();
                            MessageBox.Show("Lưu thành công!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                    }
                }
                else
                {
                    if (!isNullOrEmpty.Equals(true))
                    {
                        byte[] img = ImgToByte(ptrAvatar);
                        if (bus_inforitems.Instance.InsertItems(mmt, tmh, sl, gia, loai, img).Equals(true))
                        {
                            load();
                            MessageBox.Show("Thêm thành công!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                    }
                    else
                    {
                        if (bus_inforitems.Instance.InsertNoItems(mmt, tmh, sl, gia, loai).Equals(true))
                        {
                            load();
                            MessageBox.Show("Thêm thành công!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                    }    
                }
                txtId.ReadOnly = true;
                txtName.ReadOnly = true;
                sAmount.ReadOnly = true;
                cbotype.ReadOnly = true;
                sPrice.ReadOnly = true;
                btnSave.Enabled = false;
            }
            catch ( Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        //Delete data
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                String mmt = txtId.Text;
                if (bus_inforitems.Instance.DeleteItems(mmt).Equals(true))
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
            sAmount.ReadOnly = false;
            sPrice.ReadOnly = false;
            cbotype.ReadOnly = false;
            btnSave.Enabled = true;
        }

        private void data_Click(object sender, EventArgs e)
        {
            txtId.DataBindings.Clear();
            txtId.DataBindings.Add("text", data.DataSource, "mamathang");
            txtName.DataBindings.Clear();
            txtName.DataBindings.Add("text", data.DataSource, "tenmathang");
            sAmount.DataBindings.Clear();
            sAmount.DataBindings.Add("text", data.DataSource, "soluong");
            sPrice.DataBindings.Clear();
            sPrice.DataBindings.Add("text", data.DataSource, "gia");
            cbotype.DataBindings.Clear();
            cbotype.DataBindings.Add("text", data.DataSource, "loai");
            if (!gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "img").ToString().Trim().Equals(""))
            {
                MemoryStream memoryStream = new MemoryStream((byte[])gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "img"));
                ptrAvatar.Image = Image.FromStream(memoryStream);
            }
            else
            {
                ptrAvatar.Image = null;
            }
            txtId.ReadOnly = true;
            txtName.ReadOnly = true;
            sAmount.ReadOnly = true;
            cbotype.ReadOnly = true;
            sPrice.ReadOnly = true;
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
    }
}
