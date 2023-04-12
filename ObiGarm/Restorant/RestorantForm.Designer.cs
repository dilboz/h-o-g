
namespace ObiGarm.Restorant
{
    partial class RestorantForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestorantForm));
            this.panel_top = new System.Windows.Forms.Panel();
            this.labelCountToDay = new System.Windows.Forms.Label();
            this.label_info_user = new System.Windows.Forms.Label();
            this.reflashInfo = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_ansver = new DevExpress.XtraEditors.SimpleButton();
            this.grid_control_is_client = new DevExpress.XtraGrid.GridControl();
            this.grid_view_is_client = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.number_order = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.full_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.date_time_start = new DevExpress.XtraGrid.Columns.GridColumn();
            this.date_time_end = new DevExpress.XtraGrid.Columns.GridColumn();
            this.type_kort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.breakfast = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lunch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dinner = new DevExpress.XtraGrid.Columns.GridColumn();
            this.timer_select_picture = new System.Windows.Forms.Timer(this.components);
            this.lbl_infoTomorrow = new System.Windows.Forms.Label();
            this.lbl_info_today = new System.Windows.Forms.Label();
            this.panelInfoKort = new System.Windows.Forms.Panel();
            this.pictureInfoKort = new System.Windows.Forms.PictureBox();
            this.txt_kort = new DevExpress.XtraEditors.TextEdit();
            this.label_info = new System.Windows.Forms.Label();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_control_is_client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_is_client)).BeginInit();
            this.panelInfoKort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfoKort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kort.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(143)))), ((int)(((byte)(78)))));
            this.panel_top.Controls.Add(this.labelCountToDay);
            this.panel_top.Controls.Add(this.label_info_user);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Padding = new System.Windows.Forms.Padding(10);
            this.panel_top.Size = new System.Drawing.Size(1402, 38);
            this.panel_top.TabIndex = 7;
            // 
            // labelCountToDay
            // 
            this.labelCountToDay.AutoSize = true;
            this.labelCountToDay.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelCountToDay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountToDay.ForeColor = System.Drawing.Color.White;
            this.labelCountToDay.Location = new System.Drawing.Point(1151, 10);
            this.labelCountToDay.Name = "labelCountToDay";
            this.labelCountToDay.Size = new System.Drawing.Size(241, 19);
            this.labelCountToDay.TabIndex = 18;
            this.labelCountToDay.Text = "Одамони ируз меомада: 0 нафар";
            // 
            // label_info_user
            // 
            this.label_info_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(143)))), ((int)(((byte)(78)))));
            this.label_info_user.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_info_user.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info_user.ForeColor = System.Drawing.Color.White;
            this.label_info_user.Location = new System.Drawing.Point(10, 10);
            this.label_info_user.Name = "label_info_user";
            this.label_info_user.Size = new System.Drawing.Size(814, 18);
            this.label_info_user.TabIndex = 4;
            this.label_info_user.Text = "Истифодабаранда: ";
            // 
            // reflashInfo
            // 
            this.reflashInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reflashInfo.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(143)))), ((int)(((byte)(78)))));
            this.reflashInfo.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reflashInfo.Appearance.ForeColor = System.Drawing.Color.White;
            this.reflashInfo.Appearance.Options.UseBackColor = true;
            this.reflashInfo.Appearance.Options.UseFont = true;
            this.reflashInfo.Appearance.Options.UseForeColor = true;
            this.reflashInfo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("reflashInfo.ImageOptions.Image")));
            this.reflashInfo.Location = new System.Drawing.Point(1228, 44);
            this.reflashInfo.Name = "reflashInfo";
            this.reflashInfo.Size = new System.Drawing.Size(162, 36);
            this.reflashInfo.TabIndex = 14;
            this.reflashInfo.Text = "Аз нав дидан";
            this.reflashInfo.Click += new System.EventHandler(this.reflashInfo_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(487, 181);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Рамзи корт:";
            // 
            // btn_ansver
            // 
            this.btn_ansver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ansver.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(143)))), ((int)(((byte)(78)))));
            this.btn_ansver.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ansver.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_ansver.Appearance.Options.UseBackColor = true;
            this.btn_ansver.Appearance.Options.UseFont = true;
            this.btn_ansver.Appearance.Options.UseForeColor = true;
            this.btn_ansver.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ansver.ImageOptions.Image")));
            this.btn_ansver.Location = new System.Drawing.Point(992, 43);
            this.btn_ansver.Name = "btn_ansver";
            this.btn_ansver.Size = new System.Drawing.Size(230, 37);
            this.btn_ansver.TabIndex = 13;
            this.btn_ansver.Text = "Фаъол кардани корт санҷ";
            this.btn_ansver.Click += new System.EventHandler(this.btn_ansver_Click);
            // 
            // grid_control_is_client
            // 
            this.grid_control_is_client.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_control_is_client.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grid_control_is_client.Location = new System.Drawing.Point(13, 86);
            this.grid_control_is_client.MainView = this.grid_view_is_client;
            this.grid_control_is_client.Name = "grid_control_is_client";
            this.grid_control_is_client.Size = new System.Drawing.Size(1377, 603);
            this.grid_control_is_client.TabIndex = 16;
            this.grid_control_is_client.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grid_view_is_client});
            // 
            // grid_view_is_client
            // 
            this.grid_view_is_client.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.number_order,
            this.id,
            this.full_name,
            this.date_time_start,
            this.date_time_end,
            this.type_kort,
            this.breakfast,
            this.lunch,
            this.dinner});
            this.grid_view_is_client.GridControl = this.grid_control_is_client;
            this.grid_view_is_client.Name = "grid_view_is_client";
            this.grid_view_is_client.OptionsFind.AlwaysVisible = true;
            this.grid_view_is_client.OptionsView.ShowGroupPanel = false;
            // 
            // number_order
            // 
            this.number_order.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_order.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.number_order.AppearanceCell.Options.UseFont = true;
            this.number_order.AppearanceCell.Options.UseForeColor = true;
            this.number_order.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_order.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.number_order.AppearanceHeader.Options.UseFont = true;
            this.number_order.AppearanceHeader.Options.UseForeColor = true;
            this.number_order.Caption = "ОРДЕР";
            this.number_order.FieldName = "number_order";
            this.number_order.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.number_order.MaxWidth = 150;
            this.number_order.MinWidth = 80;
            this.number_order.Name = "number_order";
            this.number_order.OptionsColumn.AllowEdit = false;
            this.number_order.Visible = true;
            this.number_order.VisibleIndex = 0;
            this.number_order.Width = 80;
            // 
            // id
            // 
            this.id.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.id.AppearanceCell.Options.UseFont = true;
            this.id.AppearanceCell.Options.UseForeColor = true;
            this.id.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.id.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.id.AppearanceHeader.Options.UseFont = true;
            this.id.AppearanceHeader.Options.UseForeColor = true;
            this.id.Caption = "ID";
            this.id.FieldName = "id";
            this.id.MinWidth = 25;
            this.id.Name = "id";
            this.id.OptionsColumn.AllowEdit = false;
            this.id.Width = 25;
            // 
            // full_name
            // 
            this.full_name.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.full_name.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.full_name.AppearanceCell.Options.UseFont = true;
            this.full_name.AppearanceCell.Options.UseForeColor = true;
            this.full_name.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.full_name.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.full_name.AppearanceHeader.Options.UseFont = true;
            this.full_name.AppearanceHeader.Options.UseForeColor = true;
            this.full_name.Caption = "Номи пурра";
            this.full_name.FieldName = "full_name";
            this.full_name.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.full_name.MinWidth = 10;
            this.full_name.Name = "full_name";
            this.full_name.OptionsColumn.AllowEdit = false;
            this.full_name.Visible = true;
            this.full_name.VisibleIndex = 1;
            this.full_name.Width = 300;
            // 
            // date_time_start
            // 
            this.date_time_start.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_time_start.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.date_time_start.AppearanceCell.Options.UseFont = true;
            this.date_time_start.AppearanceCell.Options.UseForeColor = true;
            this.date_time_start.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_time_start.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.date_time_start.AppearanceHeader.Options.UseFont = true;
            this.date_time_start.AppearanceHeader.Options.UseForeColor = true;
            this.date_time_start.Caption = "Аз кай";
            this.date_time_start.DisplayFormat.FormatString = "D";
            this.date_time_start.FieldName = "start_date";
            this.date_time_start.MaxWidth = 150;
            this.date_time_start.MinWidth = 130;
            this.date_time_start.Name = "date_time_start";
            this.date_time_start.OptionsColumn.AllowEdit = false;
            this.date_time_start.Visible = true;
            this.date_time_start.VisibleIndex = 2;
            this.date_time_start.Width = 130;
            // 
            // date_time_end
            // 
            this.date_time_end.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_time_end.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.date_time_end.AppearanceCell.Options.UseFont = true;
            this.date_time_end.AppearanceCell.Options.UseForeColor = true;
            this.date_time_end.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_time_end.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.date_time_end.AppearanceHeader.Options.UseFont = true;
            this.date_time_end.AppearanceHeader.Options.UseForeColor = true;
            this.date_time_end.Caption = "То кай";
            this.date_time_end.DisplayFormat.FormatString = "D";
            this.date_time_end.FieldName = "end_date";
            this.date_time_end.MaxWidth = 150;
            this.date_time_end.MinWidth = 130;
            this.date_time_end.Name = "date_time_end";
            this.date_time_end.OptionsColumn.AllowEdit = false;
            this.date_time_end.Visible = true;
            this.date_time_end.VisibleIndex = 3;
            this.date_time_end.Width = 130;
            // 
            // type_kort
            // 
            this.type_kort.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_kort.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.type_kort.AppearanceCell.Options.UseFont = true;
            this.type_kort.AppearanceCell.Options.UseForeColor = true;
            this.type_kort.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_kort.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.type_kort.AppearanceHeader.Options.UseFont = true;
            this.type_kort.AppearanceHeader.Options.UseForeColor = true;
            this.type_kort.Caption = "Намуди корт";
            this.type_kort.FieldName = "type_kort";
            this.type_kort.MaxWidth = 150;
            this.type_kort.MinWidth = 130;
            this.type_kort.Name = "type_kort";
            this.type_kort.OptionsColumn.AllowEdit = false;
            this.type_kort.Visible = true;
            this.type_kort.VisibleIndex = 4;
            this.type_kort.Width = 140;
            // 
            // breakfast
            // 
            this.breakfast.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.breakfast.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.breakfast.AppearanceCell.Options.UseFont = true;
            this.breakfast.AppearanceCell.Options.UseForeColor = true;
            this.breakfast.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.breakfast.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.breakfast.AppearanceHeader.Options.UseFont = true;
            this.breakfast.AppearanceHeader.Options.UseForeColor = true;
            this.breakfast.Caption = "Наҳорӣ";
            this.breakfast.FieldName = "breakfast";
            this.breakfast.MaxWidth = 200;
            this.breakfast.MinWidth = 190;
            this.breakfast.Name = "breakfast";
            this.breakfast.OptionsColumn.AllowEdit = false;
            this.breakfast.Visible = true;
            this.breakfast.VisibleIndex = 5;
            this.breakfast.Width = 190;
            // 
            // lunch
            // 
            this.lunch.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lunch.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.lunch.AppearanceCell.Options.UseFont = true;
            this.lunch.AppearanceCell.Options.UseForeColor = true;
            this.lunch.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lunch.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.lunch.AppearanceHeader.Options.UseFont = true;
            this.lunch.AppearanceHeader.Options.UseForeColor = true;
            this.lunch.Caption = "Хуроки нисфирузи";
            this.lunch.FieldName = "lunch";
            this.lunch.MaxWidth = 200;
            this.lunch.MinWidth = 190;
            this.lunch.Name = "lunch";
            this.lunch.OptionsColumn.AllowEdit = false;
            this.lunch.Visible = true;
            this.lunch.VisibleIndex = 6;
            this.lunch.Width = 190;
            // 
            // dinner
            // 
            this.dinner.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dinner.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.dinner.AppearanceCell.Options.UseFont = true;
            this.dinner.AppearanceCell.Options.UseForeColor = true;
            this.dinner.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dinner.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.dinner.AppearanceHeader.Options.UseFont = true;
            this.dinner.AppearanceHeader.Options.UseForeColor = true;
            this.dinner.Caption = "Хуроки бегоҳрузӣ";
            this.dinner.FieldName = "dinner";
            this.dinner.MaxWidth = 200;
            this.dinner.MinWidth = 190;
            this.dinner.Name = "dinner";
            this.dinner.OptionsColumn.AllowEdit = false;
            this.dinner.Visible = true;
            this.dinner.VisibleIndex = 7;
            this.dinner.Width = 190;
            // 
            // timer_select_picture
            // 
            this.timer_select_picture.Tick += new System.EventHandler(this.timer_select_picture_Tick);
            // 
            // lbl_infoTomorrow
            // 
            this.lbl_infoTomorrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_infoTomorrow.AutoSize = true;
            this.lbl_infoTomorrow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_infoTomorrow.ForeColor = System.Drawing.Color.Black;
            this.lbl_infoTomorrow.Location = new System.Drawing.Point(1093, 109);
            this.lbl_infoTomorrow.Name = "lbl_infoTomorrow";
            this.lbl_infoTomorrow.Size = new System.Drawing.Size(254, 19);
            this.lbl_infoTomorrow.TabIndex = 19;
            this.lbl_infoTomorrow.Text = "Одамони фардо меомада: 0 нафар";
            // 
            // lbl_info_today
            // 
            this.lbl_info_today.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_info_today.AutoSize = true;
            this.lbl_info_today.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_info_today.ForeColor = System.Drawing.Color.Black;
            this.lbl_info_today.Location = new System.Drawing.Point(1105, 89);
            this.lbl_info_today.Name = "lbl_info_today";
            this.lbl_info_today.Size = new System.Drawing.Size(242, 19);
            this.lbl_info_today.TabIndex = 20;
            this.lbl_info_today.Text = "Одамони имруз омадан: 0 нафар";
            // 
            // panelInfoKort
            // 
            this.panelInfoKort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInfoKort.Controls.Add(this.pictureInfoKort);
            this.panelInfoKort.Location = new System.Drawing.Point(1005, 333);
            this.panelInfoKort.Name = "panelInfoKort";
            this.panelInfoKort.Padding = new System.Windows.Forms.Padding(10);
            this.panelInfoKort.Size = new System.Drawing.Size(385, 356);
            this.panelInfoKort.TabIndex = 21;
            this.panelInfoKort.Visible = false;
            // 
            // pictureInfoKort
            // 
            this.pictureInfoKort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureInfoKort.Image = global::ObiGarm.Properties.Resources.isEat;
            this.pictureInfoKort.Location = new System.Drawing.Point(10, 10);
            this.pictureInfoKort.Name = "pictureInfoKort";
            this.pictureInfoKort.Size = new System.Drawing.Size(365, 336);
            this.pictureInfoKort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureInfoKort.TabIndex = 20;
            this.pictureInfoKort.TabStop = false;
            // 
            // txt_kort
            // 
            this.txt_kort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_kort.Location = new System.Drawing.Point(1015, 44);
            this.txt_kort.Name = "txt_kort";
            this.txt_kort.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_kort.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txt_kort.Properties.Appearance.Options.UseFont = true;
            this.txt_kort.Properties.Appearance.Options.UseForeColor = true;
            this.txt_kort.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txt_kort.Properties.ContextImageOptions.Image")));
            this.txt_kort.Properties.Mask.BeepOnError = true;
            this.txt_kort.Properties.Mask.EditMask = "0000000000";
            this.txt_kort.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt_kort.Properties.Mask.PlaceHolder = '0';
            this.txt_kort.Size = new System.Drawing.Size(186, 26);
            this.txt_kort.TabIndex = 85;
            this.txt_kort.EditValueChanged += new System.EventHandler(this.txt_kort_EditValueChanged_1);
            // 
            // label_info
            // 
            this.label_info.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_info.ForeColor = System.Drawing.Color.Black;
            this.label_info.Location = new System.Drawing.Point(12, 41);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(959, 42);
            this.label_info.TabIndex = 86;
            this.label_info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RestorantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 701);
            this.Controls.Add(this.btn_ansver);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.panelInfoKort);
            this.Controls.Add(this.lbl_info_today);
            this.Controls.Add(this.lbl_infoTomorrow);
            this.Controls.Add(this.reflashInfo);
            this.Controls.Add(this.grid_control_is_client);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.txt_kort);
            this.IconOptions.ShowIcon = false;
            this.Name = "RestorantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restorant";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RestorantForm_FormClosed);
            this.Shown += new System.EventHandler(this.RestorantForm_Shown);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_control_is_client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_is_client)).EndInit();
            this.panelInfoKort.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureInfoKort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kort.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label_info_user;
        private DevExpress.XtraEditors.SimpleButton btn_ansver;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton reflashInfo;
        private DevExpress.XtraGrid.GridControl grid_control_is_client;
        private DevExpress.XtraGrid.Views.Grid.GridView grid_view_is_client;
        private DevExpress.XtraGrid.Columns.GridColumn number_order;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn full_name;
        private DevExpress.XtraGrid.Columns.GridColumn date_time_start;
        private DevExpress.XtraGrid.Columns.GridColumn date_time_end;
        private DevExpress.XtraGrid.Columns.GridColumn type_kort;
        private System.Windows.Forms.Timer timer_select_picture;
        private System.Windows.Forms.Label labelCountToDay;
        private System.Windows.Forms.Label lbl_infoTomorrow;
        private System.Windows.Forms.Label lbl_info_today;
        private System.Windows.Forms.Panel panelInfoKort;
        private System.Windows.Forms.PictureBox pictureInfoKort;
        private DevExpress.XtraGrid.Columns.GridColumn breakfast;
        private DevExpress.XtraGrid.Columns.GridColumn lunch;
        private DevExpress.XtraGrid.Columns.GridColumn dinner;
        private DevExpress.XtraEditors.TextEdit txt_kort;
        private System.Windows.Forms.Label label_info;
    }
}