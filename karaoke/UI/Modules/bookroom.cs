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

namespace karaoke.UI.Modules
{
    public partial class bookroom : DevExpress.XtraEditors.XtraUserControl
    {
        public bookroom()
        {
            InitializeComponent();
            LoadRoom("Thường");
        }

        void LoadRoom(String type)
        {
            List<listbookroom> listroom = bus_bookroom.Instance.loadroom(type);
            foreach (listbookroom item in listroom)
            {
                Button btn = new Button() { Width = bus_bookroom.Instance.TableWidth, Height = bus_bookroom.Instance.TableHeight };
                btn.Text = item.tenphong;
                btn.Image = Image.FromFile(Application.StartupPath + "\\resource\\room.png");
                btn.BackgroundImageLayout = ImageLayout.Zoom;
                btn.ImageAlign = ContentAlignment.MiddleCenter;
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.Padding = new Padding(0, 0, 0, 8);
                btn.Margin = new Padding(15, 15, 15, 15);
                btn.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                btn.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
                switch (item.trangthai)
                {
                    case "Trống":
                        btn.BackColor = Color.LightBlue;
                        break;
                    case "Đầy":
                        btn.BackColor = Color.LightPink;
                        break;
                }    
                flpContainer.Controls.Add(btn);
                btn.Click += Btn_Click;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
