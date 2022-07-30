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
    public partial class customers : DevExpress.XtraEditors.XtraUserControl
    {
        public customers()
        {
            InitializeComponent();
            load();
        }

        private void load()
        {
            data.DataSource = bus_customers.Instance.FillCustomer();
            txtId.ReadOnly = true;
            txtName.ReadOnly = true;
            txtEmail.ReadOnly = true;
            mmAdress.ReadOnly = true;
            txtNumberphone.ReadOnly = true;
            sRate.ReadOnly = true;
            btnSave.Enabled = false;
        }

        protected bool checkId()
        {
            bool check = false;
            Regex r = new Regex("^[a-zA-Z0-9]*$");
            if (!r.IsMatch(txtId.Text))
            {
                errorProvider1.SetError(txtId, "Vui lòng nhập đúng định dạng!");
            }
            else
            {
                errorProvider1.SetError(txtId, "");
                check = true;
            } 
            return check;
        }

        protected bool checksdt()
        {
            bool check = false;
            Regex r = new Regex("^[0-9]*$");
            if (!r.IsMatch(txtNumberphone.Text))
            {
                errorProvider1.SetError(txtNumberphone, "Vui lòng nhập đúng định dạng của số điện thoại!");
            }
            else
            {
                errorProvider1.SetError(txtNumberphone, "");
                check = true;
            }
            return check;
        }

        protected bool checkName()
        {
            bool check = false;
            Regex r = new Regex("^[0-9]*$");
            if (r.IsMatch(txtName.Text) || txtNumberphone.Text == "")
            {
                errorProvider1.SetError(txtName, "Vui lòng nhập ký tư là chữ cái!");
            }
            else
            {
                errorProvider1.SetError(txtName, "");
                check = true;
            }
            return check;
        }

        protected bool checkRate()
        {
            bool check = false;
            if (!(double.Parse(sRate.Text) >= 0))
                errorProvider1.SetError(sRate, "Tỷ lệ giảm giá là số không âm!");
            else
            {
                errorProvider1.SetError(sRate, "");
                check = true;
            }
            return check;
        }

        protected bool checkEmail()
        {
            bool check = false;
            Regex r = new Regex(@"^([\w\.\-]+)@((?!\.|\-)[\w\-]+)((\.(\w){2,3})+)$");
            if (!r.IsMatch(txtEmail.Text))
                errorProvider1.SetError(txtEmail, "Vui lòng nhập đúng định dạng email");
            else
            {
                errorProvider1.SetError(txtEmail, "");
                check = true;
            }
            return check;
        }

        //Add data
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtId.ReadOnly = false;
            txtName.ReadOnly = false;
            txtEmail.ReadOnly = false;
            mmAdress.ReadOnly = false;
            txtNumberphone.ReadOnly = false;
            sRate.ReadOnly = false;
            btnSave.Enabled = true;
            //emty
            txtId.Text = String.Empty;
            txtName.Text = String.Empty;
            txtEmail.Text = String.Empty;
            mmAdress.Text = String.Empty;
            txtNumberphone.Text = String.Empty;
            sRate.Text = String.Empty;
        }

        //Save data
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkId().Equals(true) && checkName().Equals(true) && checksdt().Equals(true) && checkRate().Equals(true) && checkEmail().Equals(true)) 
                {
                    String id = txtId.Text;
                    String hvt = txtName.Text;
                    String email = txtEmail.Text;
                    String dc = mmAdress.Text;
                    String sdt = txtNumberphone.Text;
                    int tlgt = Int32.Parse(sRate.Text);
                    if (bus_customers.Instance.CheckIdCustomer(id).Equals(true))
                    {
                        if (bus_customers.Instance.UpdateCustomer(id, hvt, email, dc, sdt, tlgt).Equals(true))
                        {
                            MessageBox.Show("Lưu thành công!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            load();
                        }
                    }
                    else
                    {
                        if (bus_customers.Instance.InsertCustomer(id, hvt, email, dc, sdt, tlgt).Equals(true))
                        {
                            MessageBox.Show("Thêm thành công!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
                            load();
                        }
                    }
                    txtId.ReadOnly = true;
                    txtName.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    mmAdress.ReadOnly = true;
                    txtNumberphone.ReadOnly = true;
                    sRate.ReadOnly = true;
                    btnSave.Enabled = false;
                }
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
                String id = txtId.Text;
                if (bus_customers.Instance.DeleteCustomer(id).Equals(true))
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
            txtEmail.ReadOnly = false;
            mmAdress.ReadOnly = false;
            txtNumberphone.ReadOnly = false;
            sRate.ReadOnly = false;
            btnSave.Enabled = true;
        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            txtId.DataBindings.Clear();
            txtId.DataBindings.Add("Text", data.DataSource, "makhachhang");
            txtName.DataBindings.Clear();
            txtName.DataBindings.Add("text", data.DataSource, "hovaten");
            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("text", data.DataSource, "email");
            mmAdress.DataBindings.Clear();
            mmAdress.DataBindings.Add("text", data.DataSource, "diachi");
            txtNumberphone.DataBindings.Clear();
            txtNumberphone.DataBindings.Add("text", data.DataSource, "sdt");
            sRate.DataBindings.Clear();
            sRate.DataBindings.Add("text", data.DataSource, "tilegiamgia");
            txtId.ReadOnly = true;
            txtName.ReadOnly = true;
            txtEmail.ReadOnly = true;
            mmAdress.ReadOnly = true;
            txtNumberphone.ReadOnly = true;
            sRate.ReadOnly = true;
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
