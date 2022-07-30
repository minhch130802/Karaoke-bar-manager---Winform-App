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
using DTO;
using BUS;
using System.IO;
using System.Text.RegularExpressions;

namespace karaoke.UI.Modules
{
    public partial class inforstaff : DevExpress.XtraEditors.XtraUserControl
    {
        public inforstaff()
        {
            InitializeComponent();
            load();
        }

        protected bool checkId()
        {
            bool check = false;
            Regex r = new Regex("^[a-zA-Z0-9]*$");
            if (!r.IsMatch(txtID.Text))
                errorProvider1.SetError(txtID, "Vui lòng nhập mã nhân viên chỉ số và chữ!");
            else
            {
                errorProvider1.SetError(txtID, "");
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

        protected bool checkUser()
        {
            bool check = false;
            Regex r = new Regex("^[a-zA-Z]*$");
            if (!r.IsMatch(txtUsername.Text) || txtUsername.Text == "")
                errorProvider1.SetError(txtUsername, "Vui lòng nhập đúng định dạng tài khoản!");
            else
            {
                errorProvider1.SetError(txtUsername, "");
                check = true;
            }
            return check;
        }
        protected bool checkNumberphoner()
        {
            bool check = false;
            Regex r = new Regex("^[0-9]*$");
            if (!r.IsMatch(txtSdt.Text) || txtSdt.Text == "")
                errorProvider1.SetError(txtSdt, "Vui lòng nhập đúng định dạng số điện thoại!");
            else
            {
                errorProvider1.SetError(txtSdt, "");
                check = true;
            }
            return check;
        }
        protected bool checkEmail()
        {
            bool check = false;
            Regex r = new Regex(@"^([\w\.\-]+)@((?!\.|\-)[\w\-]+)((\.(\w){2,3})+)$");
            if (!r.IsMatch(txtEmail.Text) || txtEmail.Text == "")
                errorProvider1.SetError(txtEmail, "Vui lòng nhập đúng định dạng email!");
            else
            {
                errorProvider1.SetError(txtEmail, "");
                check = true;
            }
            return check;
        }

        private void load()
        {
            data.DataSource = bus_inforstaff.Instance.FillInfoStaff();
            cboType.Properties.Items.Add("Nhân viên");
            cboType.Properties.Items.Add("Quản lý");
            cboType.Text = "Nhân viên";
            btnImport.Enabled = false;
            txtID.ReadOnly = true;
            txtName.ReadOnly = true;
            txtUsername.ReadOnly = true;
            txtPassword.ReadOnly = true;
            txtEmail.ReadOnly = true;
            cbxMale.ReadOnly = true;
            cbxFemale.ReadOnly = true;
            mmAdress.ReadOnly = true;
            cboType.ReadOnly = true;
            txtSdt.ReadOnly = true;
            btnSave.Enabled = false;
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            try
            {
                String test = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "gioitinh").ToString().Trim();
                if (test.Equals("Nam"))
                {
                    cbxMale.Checked = true;
                    cbxFemale.Checked = false;
                }
                else
                {
                    cbxMale.Checked = false;
                    cbxFemale.Checked = true;
                }
                txtID.DataBindings.Clear();
                txtID.DataBindings.Add("text", data.DataSource, "manhanvien");
                txtUsername.DataBindings.Clear();
                txtUsername.DataBindings.Add("text", data.DataSource, "tentaikhoan");
                txtPassword.DataBindings.Clear();
                txtPassword.DataBindings.Add("text", data.DataSource, "matkhau");
                txtEmail.DataBindings.Clear();
                txtEmail.DataBindings.Add("text", data.DataSource, "email");
                txtName.DataBindings.Clear();
                txtName.DataBindings.Add("text", data.DataSource, "hovaten");
                txtSdt.DataBindings.Clear();
                txtSdt.DataBindings.Add("text", data.DataSource, "sdt");
                cboType.DataBindings.Clear();
                cboType.DataBindings.Add("text", data.DataSource, "phanloai");
                mmAdress.DataBindings.Clear();
                mmAdress.DataBindings.Add("text", data.DataSource, "diachi");
                if (!gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "img").ToString().Trim().Equals(""))
                {
                    MemoryStream memoryStream = new MemoryStream((byte[])gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "img"));
                    ptrAvatar.Image = Image.FromStream(memoryStream);
                }
                else
                {
                    ptrAvatar.Image = null;
                }
                btnImport.Enabled = false;
                txtID.ReadOnly = true;
                txtName.ReadOnly = true;
                txtUsername.ReadOnly = true;
                txtPassword.ReadOnly = true;
                txtEmail.ReadOnly = true;
                cbxMale.ReadOnly = true;
                cbxFemale.ReadOnly = true;
                mmAdress.ReadOnly = true;
                cboType.ReadOnly = true;
                txtSdt.ReadOnly = true;
                btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ptrSeting_Click(object sender, EventArgs e)
        {
            if (txtPassword.Properties.PasswordChar == '*')
            {
                txtPassword.Properties.PasswordChar = '\0';
            }
            else
                txtPassword.Properties.PasswordChar = '*';
        }

        private byte[] ImgToByte(PictureEdit picture)
        {
            MemoryStream memoryStream = new MemoryStream();
            picture.Image.Save(memoryStream, picture.Image.RawFormat);
            return memoryStream.ToArray();
        }

        private bool getsex()
        {
            if (cbxFemale.Checked.Equals(true))
            {
                return false;
            }
            return true;
        }

        private void btnImport_Click(object sender, EventArgs e)
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
            btnImport.Enabled = true;
            txtID.ReadOnly = false;
            txtName.ReadOnly = false;
            txtUsername.ReadOnly = false;
            txtPassword.ReadOnly = false;
            txtEmail.ReadOnly = false;
            cbxMale.ReadOnly = false;
            cbxFemale.ReadOnly = false;
            mmAdress.ReadOnly = false;
            cboType.ReadOnly = false;
            txtSdt.ReadOnly = false;
            btnSave.Enabled = true;
            //emty 
            txtID.Text = String.Empty;
            txtName.Text = String.Empty;
            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;
            txtEmail.Text = String.Empty;
            cbxMale.Checked = false;
            cbxFemale.Checked = false;
            mmAdress.Text = String.Empty;
            cboType.Text = "Nhân viên";
            txtSdt.Text = String.Empty;
        }

        //button change
        private void btnChange_Click(object sender, EventArgs e)
        {
            btnImport.Enabled = true;
            txtID.ReadOnly = false;
            txtName.ReadOnly = false;
            txtUsername.ReadOnly = false;
            txtPassword.ReadOnly = false;
            txtEmail.ReadOnly = false;
            cbxMale.ReadOnly = false;
            cbxFemale.ReadOnly = false;
            mmAdress.ReadOnly = false;
            cboType.ReadOnly = false;
            txtSdt.ReadOnly = false;
            btnSave.Enabled = true;
        }

        //Save data
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if ( checkEmail().Equals(true) && checkId().Equals(true) && checkName().Equals(true) && checkNumberphoner().Equals(true) && checkUser().Equals(true))
                {
                    String manhanvien = txtID.Text;
                    String taikhoan = txtUsername.Text;
                    String matkhau = txtPassword.Text;
                    String email = txtEmail.Text;
                    String sdt = txtSdt.Text;
                    String hovaten = txtName.Text;
                    bool gt = getsex();
                    String pl = cboType.Text;
                    String dc = mmAdress.Text;
                    bool isNullOrEmpty = ptrAvatar == null || ptrAvatar.Image == null;
                    if (bus_inforstaff.Instance.checkid(manhanvien).Equals(true))
                    {
                        if (isNullOrEmpty.Equals(true))
                        {
                            if (bus_inforstaff.Instance.UpdateNoInforStaff(manhanvien, taikhoan, matkhau, email, sdt, hovaten, gt, pl, dc).Equals(true))
                            {
                                load();
                                MessageBox.Show("Cập nhật thành công!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            }
                        }
                        else
                        {
                            byte[] img = ImgToByte(ptrAvatar);
                            if (bus_inforstaff.Instance.UpdateInforStaff(manhanvien, taikhoan, matkhau, email, sdt, hovaten, gt, pl, dc, img).Equals(true))
                            {
                                load();
                                MessageBox.Show("Cập nhật thành công!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            }
                        }
                    }
                    else
                    {
                        if (isNullOrEmpty.Equals(true))
                        {
                            if (bus_inforstaff.Instance.AddNoInforStaff(manhanvien, taikhoan, matkhau, email, sdt, hovaten, gt, pl, dc).Equals(true))
                            {
                                load();
                                MessageBox.Show("Thêm thành công!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            }
                        }
                        else
                        {
                            byte[] img = ImgToByte(ptrAvatar);
                            if (bus_inforstaff.Instance.AddInforStaff(manhanvien, taikhoan, matkhau, email, sdt, hovaten, gt, pl, dc, img).Equals(true))
                            {
                                load();
                                MessageBox.Show("Thêm thành công!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            }
                        }
                    }
                    btnImport.Enabled = false;
                    txtID.ReadOnly = true;
                    txtName.ReadOnly = true;
                    txtUsername.ReadOnly = true;
                    txtPassword.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    cbxMale.ReadOnly = true;
                    cbxFemale.ReadOnly = true;
                    mmAdress.ReadOnly = true;
                    cboType.ReadOnly = true;
                    txtSdt.ReadOnly = true;
                    btnSave.Enabled = false;
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
                String manhanvien = txtID.Text;
                if (bus_inforstaff.Instance.DeleteInforStaff(manhanvien).Equals(true))
                {
                    load();
                    MessageBox.Show("Cập nhật thành công!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
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
