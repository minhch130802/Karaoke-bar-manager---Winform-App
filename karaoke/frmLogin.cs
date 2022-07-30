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

namespace karaoke
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //Close
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát chứ!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
            {
                e.Cancel = true;
            } 
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            timer1.Start();
            btnLogin.Enabled = false;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!txtUsername.Text.Equals(String.Empty) && !txtPassword.Text.Equals(String.Empty))
            {
                btnLogin.Enabled = true;
            }
            else
                btnLogin.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;
            if (bus_login.Instance.login(username, password).Equals(false))
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                frmHome form = new frmHome();
                form.Show();
                this.Hide();
            }
        }

        private void cbxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxShow.Checked.Equals(true))
                txtPassword.Properties.PasswordChar = '\0';
            else
                txtPassword.Properties.PasswordChar = '*';
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}