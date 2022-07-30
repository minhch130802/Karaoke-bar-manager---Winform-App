
namespace karaoke.UI.Modules
{
    partial class menu
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.data = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mahoadon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.maphong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.thoigiansudung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tienphong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mamathang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenphong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenmathang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.soluonghang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tienhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.lblMahoadon = new DevExpress.XtraEditors.LabelControl();
            this.cboRoom = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtCustomer = new DevExpress.XtraEditors.TextEdit();
            this.cboSales = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lblRoom = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblCustomer = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblSales = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lblTitle = new DevExpress.XtraLayout.SimpleLabelItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboRoom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSales.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.data);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 191);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1046, 404);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(12, 12);
            this.data.MainView = this.gridView1;
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(1022, 380);
            this.data.TabIndex = 4;
            this.data.UseEmbeddedNavigator = true;
            this.data.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.data.Click += new System.EventHandler(this.data_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.mahoadon,
            this.maphong,
            this.thoigiansudung,
            this.tienphong,
            this.mamathang,
            this.tenphong,
            this.tenmathang,
            this.soluonghang,
            this.tienhang});
            this.gridView1.GridControl = this.data;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.RowAutoHeight = true;
            // 
            // mahoadon
            // 
            this.mahoadon.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mahoadon.AppearanceCell.Options.UseFont = true;
            this.mahoadon.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mahoadon.AppearanceHeader.Options.UseFont = true;
            this.mahoadon.AppearanceHeader.Options.UseTextOptions = true;
            this.mahoadon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.mahoadon.Caption = "Mã hóa đơn";
            this.mahoadon.FieldName = "mahoadon";
            this.mahoadon.MinWidth = 25;
            this.mahoadon.Name = "mahoadon";
            this.mahoadon.OptionsColumn.AllowEdit = false;
            this.mahoadon.Visible = true;
            this.mahoadon.VisibleIndex = 0;
            this.mahoadon.Width = 94;
            // 
            // maphong
            // 
            this.maphong.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maphong.AppearanceCell.Options.UseFont = true;
            this.maphong.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maphong.AppearanceHeader.Options.UseFont = true;
            this.maphong.AppearanceHeader.Options.UseTextOptions = true;
            this.maphong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.maphong.Caption = "Mã phòng";
            this.maphong.FieldName = "maphong";
            this.maphong.MinWidth = 25;
            this.maphong.Name = "maphong";
            this.maphong.OptionsColumn.AllowEdit = false;
            this.maphong.Visible = true;
            this.maphong.VisibleIndex = 1;
            this.maphong.Width = 94;
            // 
            // thoigiansudung
            // 
            this.thoigiansudung.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoigiansudung.AppearanceCell.Options.UseFont = true;
            this.thoigiansudung.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoigiansudung.AppearanceHeader.Options.UseFont = true;
            this.thoigiansudung.AppearanceHeader.Options.UseTextOptions = true;
            this.thoigiansudung.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.thoigiansudung.Caption = "Thời gian sử dụng";
            this.thoigiansudung.FieldName = "thoigiansudung";
            this.thoigiansudung.MinWidth = 25;
            this.thoigiansudung.Name = "thoigiansudung";
            this.thoigiansudung.OptionsColumn.AllowEdit = false;
            this.thoigiansudung.Visible = true;
            this.thoigiansudung.VisibleIndex = 3;
            this.thoigiansudung.Width = 94;
            // 
            // tienphong
            // 
            this.tienphong.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tienphong.AppearanceCell.Options.UseFont = true;
            this.tienphong.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tienphong.AppearanceHeader.Options.UseFont = true;
            this.tienphong.AppearanceHeader.Options.UseTextOptions = true;
            this.tienphong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tienphong.Caption = "Tiền phòng (x60p)";
            this.tienphong.FieldName = "tienphong";
            this.tienphong.MinWidth = 25;
            this.tienphong.Name = "tienphong";
            this.tienphong.OptionsColumn.AllowEdit = false;
            this.tienphong.Visible = true;
            this.tienphong.VisibleIndex = 4;
            this.tienphong.Width = 94;
            // 
            // mamathang
            // 
            this.mamathang.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mamathang.AppearanceCell.Options.UseFont = true;
            this.mamathang.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mamathang.AppearanceHeader.Options.UseFont = true;
            this.mamathang.AppearanceHeader.Options.UseTextOptions = true;
            this.mamathang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.mamathang.Caption = "Mã mặt hàng";
            this.mamathang.FieldName = "mamathang";
            this.mamathang.MinWidth = 25;
            this.mamathang.Name = "mamathang";
            this.mamathang.OptionsColumn.AllowEdit = false;
            this.mamathang.Visible = true;
            this.mamathang.VisibleIndex = 5;
            this.mamathang.Width = 94;
            // 
            // tenphong
            // 
            this.tenphong.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenphong.AppearanceCell.Options.UseFont = true;
            this.tenphong.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenphong.AppearanceHeader.Options.UseFont = true;
            this.tenphong.AppearanceHeader.Options.UseTextOptions = true;
            this.tenphong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tenphong.Caption = "Tên phòng";
            this.tenphong.FieldName = "tenphong";
            this.tenphong.MinWidth = 25;
            this.tenphong.Name = "tenphong";
            this.tenphong.OptionsColumn.AllowEdit = false;
            this.tenphong.Visible = true;
            this.tenphong.VisibleIndex = 2;
            this.tenphong.Width = 94;
            // 
            // tenmathang
            // 
            this.tenmathang.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenmathang.AppearanceCell.Options.UseFont = true;
            this.tenmathang.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenmathang.AppearanceHeader.Options.UseFont = true;
            this.tenmathang.AppearanceHeader.Options.UseTextOptions = true;
            this.tenmathang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tenmathang.Caption = "Tên mặt hàng";
            this.tenmathang.FieldName = "tenmathang";
            this.tenmathang.MinWidth = 25;
            this.tenmathang.Name = "tenmathang";
            this.tenmathang.OptionsColumn.AllowEdit = false;
            this.tenmathang.Visible = true;
            this.tenmathang.VisibleIndex = 6;
            this.tenmathang.Width = 94;
            // 
            // soluonghang
            // 
            this.soluonghang.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soluonghang.AppearanceCell.Options.UseFont = true;
            this.soluonghang.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soluonghang.AppearanceHeader.Options.UseFont = true;
            this.soluonghang.AppearanceHeader.Options.UseTextOptions = true;
            this.soluonghang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.soluonghang.Caption = "Số lượng ";
            this.soluonghang.FieldName = "soluonghang";
            this.soluonghang.MinWidth = 25;
            this.soluonghang.Name = "soluonghang";
            this.soluonghang.OptionsColumn.AllowEdit = false;
            this.soluonghang.Visible = true;
            this.soluonghang.VisibleIndex = 7;
            this.soluonghang.Width = 94;
            // 
            // tienhang
            // 
            this.tienhang.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tienhang.AppearanceCell.Options.UseFont = true;
            this.tienhang.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tienhang.AppearanceHeader.Options.UseFont = true;
            this.tienhang.AppearanceHeader.Options.UseTextOptions = true;
            this.tienhang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tienhang.Caption = "Tiền mặt hàng (x1)";
            this.tienhang.FieldName = "tienhang";
            this.tienhang.MinWidth = 25;
            this.tienhang.Name = "tienhang";
            this.tienhang.OptionsColumn.AllowEdit = false;
            this.tienhang.Visible = true;
            this.tienhang.VisibleIndex = 8;
            this.tienhang.Width = 94;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1046, 404);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.data;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1026, 384);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.lblMahoadon);
            this.layoutControl2.Controls.Add(this.cboRoom);
            this.layoutControl2.Controls.Add(this.txtCustomer);
            this.layoutControl2.Controls.Add(this.cboSales);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(1046, 154);
            this.layoutControl2.TabIndex = 1;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // lblMahoadon
            // 
            this.lblMahoadon.Location = new System.Drawing.Point(525, 42);
            this.lblMahoadon.Name = "lblMahoadon";
            this.lblMahoadon.Size = new System.Drawing.Size(75, 16);
            this.lblMahoadon.StyleController = this.layoutControl2;
            this.lblMahoadon.TabIndex = 8;
            this.lblMahoadon.Text = "labelControl1";
            this.lblMahoadon.Visible = false;
            // 
            // cboRoom
            // 
            this.cboRoom.Location = new System.Drawing.Point(172, 42);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRoom.Properties.Appearance.Options.UseFont = true;
            this.cboRoom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboRoom.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboRoom.Size = new System.Drawing.Size(116, 28);
            this.cboRoom.StyleController = this.layoutControl2;
            this.cboRoom.TabIndex = 4;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(172, 74);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.Properties.Appearance.Options.UseFont = true;
            this.txtCustomer.Size = new System.Drawing.Size(116, 28);
            this.txtCustomer.StyleController = this.layoutControl2;
            this.txtCustomer.TabIndex = 6;
            // 
            // cboSales
            // 
            this.cboSales.Location = new System.Drawing.Point(489, 74);
            this.cboSales.Name = "cboSales";
            this.cboSales.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSales.Properties.Appearance.Options.UseFont = true;
            this.cboSales.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboSales.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cboSales.Size = new System.Drawing.Size(132, 28);
            this.cboSales.StyleController = this.layoutControl2;
            this.cboSales.TabIndex = 7;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lblRoom,
            this.lblCustomer,
            this.lblSales,
            this.emptySpaceItem1,
            this.lblTitle,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.emptySpaceItem4,
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1046, 154);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lblRoom
            // 
            this.lblRoom.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoom.AppearanceItemCaption.Options.UseFont = true;
            this.lblRoom.Control = this.cboRoom;
            this.lblRoom.Location = new System.Drawing.Point(0, 30);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(280, 32);
            this.lblRoom.Text = "Mã phòng:";
            this.lblRoom.TextSize = new System.Drawing.Size(156, 26);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.AppearanceItemCaption.Options.UseFont = true;
            this.lblCustomer.Control = this.txtCustomer;
            this.lblCustomer.Location = new System.Drawing.Point(0, 62);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(280, 72);
            this.lblCustomer.Text = "Mã khách hàng";
            this.lblCustomer.TextSize = new System.Drawing.Size(156, 26);
            // 
            // lblSales
            // 
            this.lblSales.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSales.AppearanceItemCaption.Options.UseFont = true;
            this.lblSales.Control = this.cboSales;
            this.lblSales.Location = new System.Drawing.Point(317, 62);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(296, 72);
            this.lblSales.Text = "Mã khuyến mãi:";
            this.lblSales.TextSize = new System.Drawing.Size(156, 27);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(613, 62);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(413, 72);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lblTitle
            // 
            this.lblTitle.AllowHotTrack = false;
            this.lblTitle.AppearanceItemCaption.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.AppearanceItemCaption.Options.UseFont = true;
            this.lblTitle.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lblTitle.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1026, 30);
            this.lblTitle.Text = "Xuất hóa đơn";
            this.lblTitle.TextSize = new System.Drawing.Size(156, 26);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(592, 30);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(434, 32);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(280, 30);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(233, 32);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(280, 62);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(37, 72);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lblMahoadon;
            this.layoutControlItem2.Location = new System.Drawing.Point(513, 30);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(79, 32);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.btnAdd);
            this.panelControl1.Controls.Add(this.btnImport);
            this.panelControl1.Controls.Add(this.btnDelete);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 154);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1046, 37);
            this.panelControl1.TabIndex = 2;
            // 
            // btnImport
            // 
            this.btnImport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnImport.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Appearance.Options.UseFont = true;
            this.btnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnImport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.ImageOptions.Image")));
            this.btnImport.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnImport.Location = new System.Drawing.Point(264, 6);
            this.btnImport.Name = "btnImport";
            this.btnImport.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnImport.Size = new System.Drawing.Size(142, 29);
            this.btnImport.TabIndex = 9;
            this.btnImport.Text = "Xuất hóa đơn";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDelete.Location = new System.Drawing.Point(170, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnDelete.Size = new System.Drawing.Size(83, 29);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnAdd.Location = new System.Drawing.Point(11, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAdd.Size = new System.Drawing.Size(148, 29);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Lưu giảm giá";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.layoutControl2);
            this.Name = "menu";
            this.Size = new System.Drawing.Size(1046, 595);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboRoom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSales.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl data;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn mahoadon;
        private DevExpress.XtraGrid.Columns.GridColumn maphong;
        private DevExpress.XtraGrid.Columns.GridColumn thoigiansudung;
        private DevExpress.XtraGrid.Columns.GridColumn tienphong;
        private DevExpress.XtraGrid.Columns.GridColumn mamathang;
        private DevExpress.XtraGrid.Columns.GridColumn tenphong;
        private DevExpress.XtraGrid.Columns.GridColumn tenmathang;
        private DevExpress.XtraGrid.Columns.GridColumn soluonghang;
        private DevExpress.XtraGrid.Columns.GridColumn tienhang;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.ComboBoxEdit cboRoom;
        private DevExpress.XtraEditors.TextEdit txtCustomer;
        private DevExpress.XtraEditors.ComboBoxEdit cboSales;
        private DevExpress.XtraLayout.LayoutControlItem lblRoom;
        private DevExpress.XtraLayout.LayoutControlItem lblCustomer;
        private DevExpress.XtraLayout.LayoutControlItem lblSales;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.SimpleLabelItem lblTitle;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.LabelControl lblMahoadon;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
    }
}
