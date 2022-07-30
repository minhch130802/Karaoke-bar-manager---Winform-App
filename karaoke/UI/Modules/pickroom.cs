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

namespace karaoke.UI.Modules
{
    public partial class pickroom : DevExpress.XtraEditors.XtraUserControl
    {
        public pickroom()
        {
            InitializeComponent();
            load();
            cbxType1.Checked = true;
            cbxType2.Checked = false;
            dTimeend.ReadOnly = true;
            btnCancel.Enabled = false;
            cboTypeitems.Properties.Items.Add("Nước uống");
            cboTypeitems.Properties.Items.Add("Thức ăn");
            cboTypeitems.Text = "Thức ăn";
        }

        private void load()
        {
            flpContainer.Controls.Clear();
            if (cbxType1.Checked.Equals(true))
            {
                LoadRoom("Thường");
            }
            else if ( cbxType2.Checked.Equals(true))
            {
                LoadRoom("Vip");
            }
            flpItems.Controls.Clear();
            LoadItems("Thức ăn");
        }

        private void loadlistview()
        {
            listView1.Columns.Add("Mã mặt hàng");
            listView1.Columns.Add("SỐ lượng");
            ListViewItem item = new ListViewItem();
            item.Text = txtName.Text;
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = sAmount.Text });
        }

        void LoadRoom(String type)
        {
            List<listbookroom> listroom = bus_pickroom.Instance.loadroom(type);
            foreach (listbookroom item in listroom)
            {
                Button btn = new Button() { Width = bus_pickroom.Instance.TableWidth, Height = bus_pickroom.Instance.TableHeight };
                btn.Text = item.tenphong;
                btn.Image = Image.FromFile(Application.StartupPath + "\\resource\\room.png");
                btn.BackgroundImageLayout = ImageLayout.Zoom;
                btn.ImageAlign = ContentAlignment.MiddleCenter;
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.Padding = new Padding(0, 0, 0, 8);
                btn.Margin = new Padding(15, 15, 15, 15);
                btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                btn.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                btn.Tag = item;
                switch ( item.trangthai)
                {
                    case "Trống":
                        btn.BackColor = Color.WhiteSmoke;
                        break;
                    case "Đầy":
                        btn.BackColor = Color.LightPink;
                        break;
                }
                btn.Click += Btn_Click;
                flpContainer.Controls.Add(btn);
            }

        }

        void LoadItems( String type )
        {
            List<Items> listitem = bus_pickroom.Instance.loaditems(type);
            foreach (Items item in listitem)
            {
                Button btnItems = new Button() { Width = bus_pickroom.Instance.ItemsWith, Height = bus_pickroom.Instance.ItemsHeight };
                btnItems.Text = item.tenmathang + '\n' + '(' + item.gia + "VNĐ" + ')' + '\n' + '(' + "Còn: " + item.soluong + ')';
                if ( item.img != null)
                {
                    MemoryStream memoryStream = new MemoryStream(item.img);
                    btnItems.Image = Image.FromStream(memoryStream);
                }
                btnItems.BackgroundImageLayout = ImageLayout.Zoom;
                btnItems.ImageAlign = ContentAlignment.MiddleCenter;
                btnItems.TextAlign = ContentAlignment.BottomCenter;
                btnItems.Padding = new Padding(0, 0, 0, 8);
                btnItems.Margin = new Padding(15, 15, 15, 15);
                btnItems.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                btnItems.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                btnItems.Tag = item;
                btnItems.Click += BtnItems_Click;
                flpItems.Controls.Add(btnItems);
            }
        }

        private void BtnItems_Click(object sender, EventArgs e)
        {
            txtName.Text = ((sender as Button).Tag as Items).mamathang;
            sAmount.Text = "0";
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            String tableid = ((sender as Button).Tag as listbookroom).maphong;
            cboRoom.Text = ((sender as Button).Tag as listbookroom).tenphong;
            idroom.Text = tableid;
            if (bus_pickroom.Instance.CheckRoom(tableid).Equals(true) )
            {
                DataTable data = bus_pickroom.Instance.FillPickRoom(tableid);
                txtName.DataBindings.Clear();
                txtName.DataBindings.Add("text", data, "mahanghoa");
                sAmount.DataBindings.Clear();
                sAmount.DataBindings.Add("text", data, "sl");
                dTimestart.DataBindings.Clear();
                dTimestart.DataBindings.Add("text", data, "timestar");
                btnAdd.Enabled = true;
                btnEnd.Enabled = true;
                btnStar.Enabled = false;
                dTimestart.ReadOnly = true;
                dTimeend.ReadOnly = false;
                btnCancel.Enabled = true;
            }    
            else
            {
                txtName.Text = String.Empty;
                dTimestart.Text = String.Empty;
                sAmount.Text = String.Empty;
                btnStar.Enabled = true;
                btnAdd.Enabled = false;
                btnEnd.Enabled = false;
                dTimestart.ReadOnly = false;
                btnCancel.Enabled = false;
            }    
        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            try
            {
                if ( checkdate().Equals(true) && checksl().Equals(true))
                {
                    btnAdd.Enabled = true;
                    btnEnd.Enabled = true;
                    btnStar.Enabled = false;
                    dTimestart.ReadOnly = true;
                    dTimeend.ReadOnly = false;
                    String mp = idroom.Text;
                    DateTime ts = DateTime.Parse(dTimestart.Text);
                    String tmh = txtName.Text;
                    int sl = Int32.Parse(sAmount.Text);
                    if (bus_pickroom.Instance.CheckEmtyRoom(mp).Equals(true))
                    {
                        if (bus_pickroom.Instance.InsertNewOrder(mp, ts, tmh, sl).Equals(true))
                            MessageBox.Show("Mở phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    btnCancel.Enabled = true;
                    load();
                }
                loadlistview();
            }
            catch ( Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (checksl().Equals(true))
                {
                    String mp = idroom.Text;
                    DateTime ts= DateTime.Parse(dTimestart.Text);
                    String tmh = txtName.Text;
                    int sl = Int32.Parse(sAmount.Text);
                    if (bus_pickroom.Instance.CheckRoom(mp).Equals(true))
                    {
                        if (bus_pickroom.Instance.InsertNewOrder(mp, ts, tmh, sl).Equals(true))
                            MessageBox.Show("Thêm hoặc lưu món thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    flpItems.Controls.Clear();
                    LoadItems(cboTypeitems.Text);
                    loadlistview();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            try
            {
                dTimestart.ReadOnly = false;
                String mp = idroom.Text;
                DateTime te;
                if (dTimeend.Text != String.Empty)
                {
                    te = DateTime.Parse(dTimeend.Text);
                }
                te = DateTime.Now;
                if (bus_pickroom.Instance.CheckRoom(mp).Equals(true))
                {
                    if (bus_pickroom.Instance.UpdateNewTimeendOrder(mp, te).Equals(true))
                        MessageBox.Show("lưu vào hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtName.Text = String.Empty;
                sAmount.Text = "0";
                dTimestart.Text = String.Empty;
                dTimeend.Text = String.Empty;
                btnCancel.Enabled = false;
                load();
            }
            catch ( Exception ex)
            {
                MessageBox.Show("Cần phải thanh toán hóa đơn trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //check
        private void cbxType1_CheckedChanged(object sender, EventArgs e)
        {
            cbxType2.Checked = false;
            flpContainer.Controls.Clear();
            load();
        }

        private void cbxType2_CheckedChanged(object sender, EventArgs e)
        {
            cbxType1.Checked = false;
            flpContainer.Controls.Clear();
            load();
        }

        private void cboTypeitems_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpItems.Controls.Clear();
            LoadItems(cboTypeitems.Text);
        }

        protected bool checksl() 
        {
            bool checksl = false;

            List<Items> listitem = bus_pickroom.Instance.loaditems(cboTypeitems.Text);

            foreach (Items items in listitem)
            {
                if (items.mamathang.Equals(txtName.Text))
                {
                    if ( Int32.Parse(sAmount.Text) > items.soluong)
                    {
                        errorProvider1.SetError(sAmount, "Số lượng hàng cần đặt lớn hơn số lượng hàng tồn!");
                        break;
                    }
                    else
                    {
                        checksl = true;
                        errorProvider1.SetError(sAmount, "");
                        break;
                    }    
                }
            }
            return checksl;
        }
        
        protected bool checkdate()
        {
            bool checkdate = false;
            int result = DateTime.Compare(DateTime.Now, DateTime.Parse(dTimestart.Text));
            if (DateTime.Parse(dTimestart.Text) == null)
            {
                errorProvider1.SetError(dTimestart, "Cần chọn thời gian bắt đầu");
            }
            else if (result > 0)
            {
                checkdate = false;
                errorProvider1.SetError(dTimestart, "Thời gian không hợp lệ");
            }
            else
            {
                checkdate = true;
                errorProvider1.SetError(dTimestart, "");
            }    
            return checkdate;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                String mp = idroom.Text;
                if (bus_pickroom.Instance.CheckRoom(mp).Equals(true))
                {
                    if (bus_pickroom.Instance.DeletRoomOrder(mp).Equals(true))
                        MessageBox.Show("Xóa menu của phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                txtName.Text = String.Empty;
                sAmount.Text = "0";
                dTimestart.Text = String.Empty;
                dTimeend.Text = String.Empty;
                btnCancel.Enabled = false;
                load();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: ", ex.Message);
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {

        }
    }
}
