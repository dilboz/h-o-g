
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
            this.panel_top = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label_info_user = new System.Windows.Forms.Label();
            this.panel_button_ans = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_info_day = new DevExpress.XtraEditors.LabelControl();
            this.lbl_info_today = new DevExpress.XtraEditors.LabelControl();
            this.label_info = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_ansver = new DevExpress.XtraEditors.SimpleButton();
            this.panel_edit_sort = new System.Windows.Forms.Panel();
            this.txt_kort = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.grid_control_is_client = new DevExpress.XtraGrid.GridControl();
            this.grid_view_is_client = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.number_order = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.full_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.date_time_start = new DevExpress.XtraGrid.Columns.GridColumn();
            this.date_time_end = new DevExpress.XtraGrid.Columns.GridColumn();
            this.type_kort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer_select_picture = new System.Windows.Forms.Timer(this.components);
            this.panel_top.SuspendLayout();
            this.panel_button_ans.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_edit_sort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kort.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_control_is_client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_is_client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(143)))), ((int)(((byte)(78)))));
            this.panel_top.Controls.Add(this.simpleButton1);
            this.panel_top.Controls.Add(this.label_info_user);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Padding = new System.Windows.Forms.Padding(10);
            this.panel_top.Size = new System.Drawing.Size(1352, 38);
            this.panel_top.TabIndex = 7;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(143)))), ((int)(((byte)(78)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(1204, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(138, 28);
            this.simpleButton1.TabIndex = 14;
            this.simpleButton1.Text = "Аз нав дидан";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label_info_user
            // 
            this.label_info_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(143)))), ((int)(((byte)(78)))));
            this.label_info_user.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_info_user.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info_user.ForeColor = System.Drawing.Color.White;
            this.label_info_user.Location = new System.Drawing.Point(10, 10);
            this.label_info_user.Name = "label_info_user";
            this.label_info_user.Size = new System.Drawing.Size(1332, 18);
            this.label_info_user.TabIndex = 4;
            this.label_info_user.Text = "Истифодабаранда: ";
            // 
            // panel_button_ans
            // 
            this.panel_button_ans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(163)))), ((int)(((byte)(98)))));
            this.panel_button_ans.Controls.Add(this.panel3);
            this.panel_button_ans.Controls.Add(this.label_info);
            this.panel_button_ans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_button_ans.Location = new System.Drawing.Point(20, 10);
            this.panel_button_ans.Name = "panel_button_ans";
            this.panel_button_ans.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel_button_ans.Size = new System.Drawing.Size(1322, 68);
            this.panel_button_ans.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelControl3);
            this.panel3.Controls.Add(this.lbl_info_day);
            this.panel3.Controls.Add(this.lbl_info_today);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(863, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(459, 68);
            this.panel3.TabIndex = 16;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl3.Location = new System.Drawing.Point(0, 44);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.labelControl3.Size = new System.Drawing.Size(448, 22);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Миқдори одамони имруз қабул карда: 0 нафар";
            // 
            // lbl_info_day
            // 
            this.lbl_info_day.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_info_day.Appearance.ForeColor = System.Drawing.Color.White;
            this.lbl_info_day.Appearance.Options.UseFont = true;
            this.lbl_info_day.Appearance.Options.UseForeColor = true;
            this.lbl_info_day.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_info_day.Location = new System.Drawing.Point(0, 22);
            this.lbl_info_day.Name = "lbl_info_day";
            this.lbl_info_day.Size = new System.Drawing.Size(458, 22);
            this.lbl_info_day.TabIndex = 5;
            this.lbl_info_day.Text = "Миқдори одамони фардо меомада меомада: 0 нафар";
            // 
            // lbl_info_today
            // 
            this.lbl_info_today.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_info_today.Appearance.ForeColor = System.Drawing.Color.White;
            this.lbl_info_today.Appearance.Options.UseFont = true;
            this.lbl_info_today.Appearance.Options.UseForeColor = true;
            this.lbl_info_today.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_info_today.Location = new System.Drawing.Point(0, 0);
            this.lbl_info_today.Name = "lbl_info_today";
            this.lbl_info_today.Size = new System.Drawing.Size(376, 22);
            this.lbl_info_today.TabIndex = 4;
            this.lbl_info_today.Text = "Миқдори одамони имруз меомада: 0 нафар";
            // 
            // label_info
            // 
            this.label_info.Appearance.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_info.Appearance.ForeColor = System.Drawing.Color.White;
            this.label_info.Appearance.Options.UseFont = true;
            this.label_info.Appearance.Options.UseForeColor = true;
            this.label_info.Location = new System.Drawing.Point(10, 6);
            this.label_info.Name = "label_info";
            this.label_info.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.label_info.Size = new System.Drawing.Size(421, 55);
            this.label_info.TabIndex = 15;
            this.label_info.Text = "ХУШ ОМАДЕД!!";
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
            this.btn_ansver.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(143)))), ((int)(((byte)(78)))));
            this.btn_ansver.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ansver.Appearance.ForeColor = System.Drawing.Color.White;
            this.btn_ansver.Appearance.Options.UseBackColor = true;
            this.btn_ansver.Appearance.Options.UseFont = true;
            this.btn_ansver.Appearance.Options.UseForeColor = true;
            this.btn_ansver.Location = new System.Drawing.Point(512, 8);
            this.btn_ansver.Name = "btn_ansver";
            this.btn_ansver.Size = new System.Drawing.Size(155, 58);
            this.btn_ansver.TabIndex = 13;
            this.btn_ansver.Text = "Фаъол кардани \r\nкорт санҷ";
            this.btn_ansver.Click += new System.EventHandler(this.btn_ansver_Click);
            // 
            // panel_edit_sort
            // 
            this.panel_edit_sort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(163)))), ((int)(((byte)(98)))));
            this.panel_edit_sort.Controls.Add(this.panel_button_ans);
            this.panel_edit_sort.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_edit_sort.Location = new System.Drawing.Point(0, 38);
            this.panel_edit_sort.Name = "panel_edit_sort";
            this.panel_edit_sort.Padding = new System.Windows.Forms.Padding(20, 10, 10, 5);
            this.panel_edit_sort.Size = new System.Drawing.Size(1352, 83);
            this.panel_edit_sort.TabIndex = 12;
            // 
            // txt_kort
            // 
            this.txt_kort.Location = new System.Drawing.Point(8, 20);
            this.txt_kort.Name = "txt_kort";
            this.txt_kort.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_kort.Properties.Appearance.Options.UseFont = true;
            this.txt_kort.Size = new System.Drawing.Size(498, 32);
            this.txt_kort.TabIndex = 1;
            this.txt_kort.EditValueChanged += new System.EventHandler(this.txt_kort_EditValueChanged);
            this.txt_kort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_kort_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(163)))), ((int)(((byte)(98)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 121);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 10, 10, 5);
            this.panel1.Size = new System.Drawing.Size(1352, 86);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(163)))), ((int)(((byte)(98)))));
            this.panel2.Controls.Add(this.textEdit1);
            this.panel2.Controls.Add(this.txt_kort);
            this.panel2.Controls.Add(this.btn_ansver);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 10);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(1322, 71);
            this.panel2.TabIndex = 1;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(1031, 20);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(288, 32);
            this.textEdit1.TabIndex = 14;
            this.textEdit1.Visible = false;
            // 
            // grid_control_is_client
            // 
            this.grid_control_is_client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_control_is_client.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grid_control_is_client.Location = new System.Drawing.Point(0, 207);
            this.grid_control_is_client.MainView = this.grid_view_is_client;
            this.grid_control_is_client.Name = "grid_control_is_client";
            this.grid_control_is_client.Size = new System.Drawing.Size(1352, 445);
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
            this.type_kort});
            this.grid_view_is_client.GridControl = this.grid_control_is_client;
            this.grid_view_is_client.Name = "grid_view_is_client";
            this.grid_view_is_client.OptionsFind.AlwaysVisible = true;
            this.grid_view_is_client.OptionsView.ShowGroupPanel = false;
            // 
            // number_order
            // 
            this.number_order.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number_order.AppearanceCell.Options.UseFont = true;
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
            this.id.AppearanceCell.Options.UseFont = true;
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
            this.full_name.AppearanceCell.Options.UseFont = true;
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
            this.date_time_start.AppearanceCell.Options.UseFont = true;
            this.date_time_start.Caption = "Аз кай";
            this.date_time_start.DisplayFormat.FormatString = "D";
            this.date_time_start.FieldName = "date_time_start";
            this.date_time_start.MinWidth = 130;
            this.date_time_start.Name = "date_time_start";
            this.date_time_start.OptionsColumn.AllowEdit = false;
            this.date_time_start.Visible = true;
            this.date_time_start.VisibleIndex = 2;
            this.date_time_start.Width = 301;
            // 
            // date_time_end
            // 
            this.date_time_end.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_time_end.AppearanceCell.Options.UseFont = true;
            this.date_time_end.Caption = "То кай";
            this.date_time_end.DisplayFormat.FormatString = "D";
            this.date_time_end.FieldName = "date_time_end";
            this.date_time_end.MinWidth = 130;
            this.date_time_end.Name = "date_time_end";
            this.date_time_end.OptionsColumn.AllowEdit = false;
            this.date_time_end.Visible = true;
            this.date_time_end.VisibleIndex = 3;
            this.date_time_end.Width = 301;
            // 
            // type_kort
            // 
            this.type_kort.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.type_kort.AppearanceCell.Options.UseFont = true;
            this.type_kort.Caption = "Намуди корт";
            this.type_kort.FieldName = "type_kort";
            this.type_kort.MinWidth = 100;
            this.type_kort.Name = "type_kort";
            this.type_kort.OptionsColumn.AllowEdit = false;
            this.type_kort.Visible = true;
            this.type_kort.VisibleIndex = 4;
            this.type_kort.Width = 282;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::ObiGarm.Properties.Resources.yes;
            this.pictureBox1.Location = new System.Drawing.Point(1035, 324);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 316);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // timer_select_picture
            // 
            this.timer_select_picture.Tick += new System.EventHandler(this.timer_select_picture_Tick);
            // 
            // RestorantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 652);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grid_control_is_client);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_edit_sort);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panel_top);
            this.IconOptions.ShowIcon = false;
            this.Name = "RestorantForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restorant";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RestorantForm_FormClosed);
            this.Shown += new System.EventHandler(this.RestorantForm_Shown);
            this.panel_top.ResumeLayout(false);
            this.panel_button_ans.ResumeLayout(false);
            this.panel_button_ans.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel_edit_sort.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_kort.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_control_is_client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_is_client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label_info_user;
        private System.Windows.Forms.Panel panel_button_ans;
        private DevExpress.XtraEditors.SimpleButton btn_ansver;
        private DevExpress.XtraEditors.TextEdit txt_kort;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Panel panel_edit_sort;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraGrid.GridControl grid_control_is_client;
        private DevExpress.XtraGrid.Views.Grid.GridView grid_view_is_client;
        private DevExpress.XtraGrid.Columns.GridColumn number_order;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn full_name;
        private DevExpress.XtraGrid.Columns.GridColumn date_time_start;
        private DevExpress.XtraGrid.Columns.GridColumn date_time_end;
        private DevExpress.XtraGrid.Columns.GridColumn type_kort;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer_select_picture;
        private DevExpress.XtraEditors.LabelControl label_info;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.LabelControl lbl_info_day;
        private DevExpress.XtraEditors.LabelControl lbl_info_today;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}