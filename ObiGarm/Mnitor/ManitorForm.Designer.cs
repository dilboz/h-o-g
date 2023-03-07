namespace ObiGarm.Mnitor
{
    partial class ManitorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManitorForm));
            this.timer_select = new System.Windows.Forms.Timer(this.components);
            this.timer_select_time_now = new System.Windows.Forms.Timer(this.components);
            this.panel__top = new System.Windows.Forms.Panel();
            this.label_info_top = new System.Windows.Forms.Label();
            this.gridViewQueryClient = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.nameClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameDoctor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.timeServices = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.idServices = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.pictureBoxTatusIp = new System.Windows.Forms.PictureBox();
            this.panel__top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQueryClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTatusIp)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_select
            // 
            this.timer_select.Enabled = true;
            this.timer_select.Interval = 2000;
            this.timer_select.Tick += new System.EventHandler(this.timer_select_Tick);
            // 
            // timer_select_time_now
            // 
            this.timer_select_time_now.Enabled = true;
            this.timer_select_time_now.Interval = 500;
            this.timer_select_time_now.Tick += new System.EventHandler(this.timer_select_time_now_Tick);
            // 
            // panel__top
            // 
            this.panel__top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(108)))), ((int)(((byte)(59)))));
            this.panel__top.Controls.Add(this.label_info_top);
            this.panel__top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel__top.Location = new System.Drawing.Point(0, 0);
            this.panel__top.Name = "panel__top";
            this.panel__top.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.panel__top.Size = new System.Drawing.Size(1484, 52);
            this.panel__top.TabIndex = 4;
            // 
            // label_info_top
            // 
            this.label_info_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_info_top.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info_top.ForeColor = System.Drawing.Color.White;
            this.label_info_top.Location = new System.Drawing.Point(9, 8);
            this.label_info_top.Name = "label_info_top";
            this.label_info_top.Size = new System.Drawing.Size(1466, 36);
            this.label_info_top.TabIndex = 0;
            this.label_info_top.Text = "ИМРУЗ 12:12:2022 соат 12:00:00";
            this.label_info_top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridViewQueryClient
            // 
            this.gridViewQueryClient.AppearancePrint.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridViewQueryClient.AppearancePrint.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridViewQueryClient.AppearancePrint.HeaderPanel.BorderColor = System.Drawing.Color.Lime;
            this.gridViewQueryClient.AppearancePrint.HeaderPanel.Options.UseBackColor = true;
            this.gridViewQueryClient.AppearancePrint.HeaderPanel.Options.UseBorderColor = true;
            this.gridViewQueryClient.ColumnPanelRowHeight = 45;
            this.gridViewQueryClient.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.nameClient,
            this.nameDoctor,
            this.timeServices,
            this.id,
            this.idServices});
            this.gridViewQueryClient.FooterPanelHeight = 40;
            this.gridViewQueryClient.GridControl = this.gridControl;
            this.gridViewQueryClient.GroupRowHeight = 40;
            this.gridViewQueryClient.Name = "gridViewQueryClient";
            this.gridViewQueryClient.OptionsView.ShowGroupPanel = false;
            this.gridViewQueryClient.RowHeight = 35;
            this.gridViewQueryClient.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewQueryClient_RowStyle);
            // 
            // nameClient
            // 
            this.nameClient.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameClient.AppearanceCell.Options.UseFont = true;
            this.nameClient.AppearanceHeader.BackColor = System.Drawing.Color.Green;
            this.nameClient.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.nameClient.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameClient.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.nameClient.AppearanceHeader.Options.UseBackColor = true;
            this.nameClient.AppearanceHeader.Options.UseFont = true;
            this.nameClient.AppearanceHeader.Options.UseForeColor = true;
            this.nameClient.Caption = "ИСТИРОҲАТКУНАНДА";
            this.nameClient.FieldName = "name_clients";
            this.nameClient.Name = "nameClient";
            this.nameClient.OptionsColumn.AllowEdit = false;
            this.nameClient.OptionsFilter.AllowAutoFilter = false;
            this.nameClient.Visible = true;
            this.nameClient.VisibleIndex = 0;
            this.nameClient.Width = 479;
            // 
            // nameDoctor
            // 
            this.nameDoctor.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameDoctor.AppearanceCell.Options.UseFont = true;
            this.nameDoctor.AppearanceHeader.BackColor = System.Drawing.Color.Green;
            this.nameDoctor.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.nameDoctor.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameDoctor.AppearanceHeader.ForeColor = System.Drawing.Color.White;
            this.nameDoctor.AppearanceHeader.Options.UseBackColor = true;
            this.nameDoctor.AppearanceHeader.Options.UseFont = true;
            this.nameDoctor.AppearanceHeader.Options.UseForeColor = true;
            this.nameDoctor.Caption = "ХИЗМАТРАСОНӢ ВА ТАБИБ";
            this.nameDoctor.FieldName = "users";
            this.nameDoctor.Name = "nameDoctor";
            this.nameDoctor.OptionsColumn.AllowEdit = false;
            this.nameDoctor.OptionsFilter.AllowAutoFilter = false;
            this.nameDoctor.Visible = true;
            this.nameDoctor.VisibleIndex = 1;
            this.nameDoctor.Width = 780;
            // 
            // timeServices
            // 
            this.timeServices.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeServices.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.timeServices.AppearanceCell.Options.UseFont = true;
            this.timeServices.AppearanceCell.Options.UseForeColor = true;
            this.timeServices.AppearanceHeader.BackColor = System.Drawing.Color.Red;
            this.timeServices.AppearanceHeader.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.timeServices.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeServices.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.timeServices.AppearanceHeader.Options.UseBackColor = true;
            this.timeServices.AppearanceHeader.Options.UseFont = true;
            this.timeServices.AppearanceHeader.Options.UseForeColor = true;
            this.timeServices.Caption = "ВАҚТ";
            this.timeServices.FieldName = "time_services_clirnts";
            this.timeServices.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("timeServices.ImageOptions.Image")));
            this.timeServices.MaxWidth = 200;
            this.timeServices.MinWidth = 150;
            this.timeServices.Name = "timeServices";
            this.timeServices.OptionsColumn.AllowEdit = false;
            this.timeServices.OptionsFilter.AllowAutoFilter = false;
            this.timeServices.Visible = true;
            this.timeServices.VisibleIndex = 2;
            this.timeServices.Width = 200;
            // 
            // id
            // 
            this.id.Caption = "id";
            this.id.FieldName = "id";
            this.id.Name = "id";
            this.id.OptionsColumn.AllowEdit = false;
            this.id.OptionsFilter.AllowAutoFilter = false;
            // 
            // idServices
            // 
            this.idServices.Caption = "id_services";
            this.idServices.FieldName = "id_services";
            this.idServices.Name = "idServices";
            this.idServices.OptionsColumn.AllowEdit = false;
            this.idServices.OptionsFilter.AllowAutoFilter = false;
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridControl.Location = new System.Drawing.Point(0, 52);
            this.gridControl.MainView = this.gridViewQueryClient;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1484, 702);
            this.gridControl.TabIndex = 5;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewQueryClient});
            // 
            // pictureBoxTatusIp
            // 
            this.pictureBoxTatusIp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTatusIp.Image = global::ObiGarm.Properties.Resources._77124_nointernet;
            this.pictureBoxTatusIp.Location = new System.Drawing.Point(0, 52);
            this.pictureBoxTatusIp.Name = "pictureBoxTatusIp";
            this.pictureBoxTatusIp.Size = new System.Drawing.Size(1484, 702);
            this.pictureBoxTatusIp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTatusIp.TabIndex = 6;
            this.pictureBoxTatusIp.TabStop = false;
            this.pictureBoxTatusIp.Visible = false;
            // 
            // ManitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 754);
            this.Controls.Add(this.pictureBoxTatusIp);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.panel__top);
            this.IconOptions.ShowIcon = false;
            this.MinimizeBox = false;
            this.Name = "ManitorForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManitorForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ManitorForm_KeyDown);
            this.panel__top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewQueryClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTatusIp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer_select;
        private System.Windows.Forms.Timer timer_select_time_now;
        private System.Windows.Forms.Panel panel__top;
        private System.Windows.Forms.Label label_info_top;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewQueryClient;
        private DevExpress.XtraGrid.Columns.GridColumn nameClient;
        private DevExpress.XtraGrid.Columns.GridColumn nameDoctor;
        private DevExpress.XtraGrid.Columns.GridColumn timeServices;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn idServices;
        private System.Windows.Forms.PictureBox pictureBoxTatusIp;
    }
}