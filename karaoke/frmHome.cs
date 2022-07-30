using DevExpress.DXperience.Demos;
using DevExpress.XtraBars;
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
using DevExpress.XtraEditors;
using karaoke.UI.Modules;

namespace karaoke
{
    public partial class frmHome : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmHome()
        {
            InitializeComponent();
        }

        //start add new form
        static frmHome _obj;

        public static frmHome Instance
        {
            get
            {
                if ( _obj == null )
                {
                    _obj = new frmHome();
                }
                return _obj;
            }
        }

        public PanelControl PnlContainer
        {
            get { return pnl; }
            set { pnl = value; }
        }

        public void addUserform(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        //end add new form

        //login
        private void frmMainhome_Load(object sender, EventArgs e)
        {
            _obj = this;
            home uc = new home();
            addUserform(uc);
            if (Login._type.Equals(false) )
            {
                aclManager.Visible = false;
            }
            else
            {
                aclManager.Visible = true;
            }
            lblName.Text = lblName.Text + Login._name.ToString();
        }

        private void accordionControlHomemain_Click(object sender, EventArgs e)
        {
            home uc = new home();
            addUserform(uc);
        }

        private void accordionControlLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accordionControlMenu_Click(object sender, EventArgs e)
        {
            pickroom uc = new pickroom();
            addUserform(uc);
        }

        //Sales
        private void accordionControlSale_Click(object sender, EventArgs e)
        {
            sales uc = new sales();
            addUserform(uc);
        }

        private void accordionControlPhòng_Click(object sender, EventArgs e)
        {
            inforroom uc = new inforroom();
            addUserform(uc);
        }

        //InforStaff
        private void accInforstaff_Click(object sender, EventArgs e)
        {
            inforstaff uc = new inforstaff();
            addUserform(uc);
        }

        private void accMeal_Click(object sender, EventArgs e)
        {
            inforitems uc = new inforitems();
            addUserform(uc);
        }

        private void accCustomers_Click(object sender, EventArgs e)
        {
            customers uc = new customers();
            addUserform(uc);
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất ứng dụng chứ!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                frmLogin form = new frmLogin();
                form.Show();
            }   
        }

        private void accReceipt_Click(object sender, EventArgs e)
        {
            menu uc = new menu();
            addUserform(uc);
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void accStore_Click(object sender, EventArgs e)
        {
            importstort uc = new importstort();
            addUserform(uc);
        }
    }
}
