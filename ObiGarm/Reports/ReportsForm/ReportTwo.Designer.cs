
namespace ObiGarm.Reports.ReportsForm
{
    partial class ReportTwo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportTwo));
            this.panel_top = new System.Windows.Forms.Panel();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonAns = new System.Windows.Forms.Button();
            this.combo_country = new DevExpress.XtraEditors.LookUpEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.tableLayoutPanelFull = new System.Windows.Forms.TableLayoutPanel();
            this.panel_right = new System.Windows.Forms.Panel();
            this.gridControlProvince = new DevExpress.XtraGrid.GridControl();
            this.gridViewProvince = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.numberRow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Province = new DevExpress.XtraGrid.Columns.GridColumn();
            this.menCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.womanCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.allCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label_provice = new System.Windows.Forms.Label();
            this.panel_left = new System.Windows.Forms.Panel();
            this.gridControlCountry = new DevExpress.XtraGrid.GridControl();
            this.gridViewCountry = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.rowNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.country = new DevExpress.XtraGrid.Columns.GridColumn();
            this.countMen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.countWomen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.countAll = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label_country = new System.Windows.Forms.Label();
            this.messDilalog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.combo_country.Properties)).BeginInit();
            this.tableLayoutPanelFull.SuspendLayout();
            this.panel_right.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProvince)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProvince)).BeginInit();
            this.panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCountry)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.buttonPrint);
            this.panel_top.Controls.Add(this.buttonAns);
            this.panel_top.Controls.Add(this.combo_country);
            this.panel_top.Controls.Add(this.label1);
            this.panel_top.Controls.Add(this.dateTimePickerEnd);
            this.panel_top.Controls.Add(this.labelEndDate);
            this.panel_top.Controls.Add(this.dateTimePickerStart);
            this.panel_top.Controls.Add(this.labelStartTime);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(10, 10);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(998, 27);
            this.panel_top.TabIndex = 0;
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.Green;
            this.buttonPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonPrint.FlatAppearance.BorderSize = 0;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrint.ForeColor = System.Drawing.Color.White;
            this.buttonPrint.Location = new System.Drawing.Point(883, 0);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(115, 27);
            this.buttonPrint.TabIndex = 65;
            this.buttonPrint.Text = "Чопкуни";
            this.buttonPrint.UseVisualStyleBackColor = false;
            // 
            // buttonAns
            // 
            this.buttonAns.BackColor = System.Drawing.Color.Green;
            this.buttonAns.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAns.FlatAppearance.BorderSize = 0;
            this.buttonAns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAns.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAns.ForeColor = System.Drawing.Color.White;
            this.buttonAns.Location = new System.Drawing.Point(730, 0);
            this.buttonAns.Name = "buttonAns";
            this.buttonAns.Size = new System.Drawing.Size(118, 27);
            this.buttonAns.TabIndex = 64;
            this.buttonAns.Text = "Намош";
            this.buttonAns.UseVisualStyleBackColor = false;
            this.buttonAns.Click += new System.EventHandler(this.buttonAns_Click);
            // 
            // combo_country
            // 
            this.combo_country.Dock = System.Windows.Forms.DockStyle.Left;
            this.combo_country.Location = new System.Drawing.Point(506, 0);
            this.combo_country.Name = "combo_country";
            this.combo_country.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combo_country.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.combo_country.Properties.Appearance.Options.UseFont = true;
            this.combo_country.Properties.Appearance.Options.UseForeColor = true;
            this.combo_country.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combo_country.Properties.AppearanceDisabled.Options.UseFont = true;
            this.combo_country.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combo_country.Properties.AppearanceDropDown.Options.UseFont = true;
            this.combo_country.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combo_country.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.combo_country.Properties.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combo_country.Properties.AppearanceFocused.Options.UseFont = true;
            this.combo_country.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combo_country.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.combo_country.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.combo_country.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "Номи кишвар")});
            this.combo_country.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("combo_country.Properties.ContextImageOptions.Image")));
            this.combo_country.Properties.NullText = "Кишварро интихоб кунед!";
            this.combo_country.Size = new System.Drawing.Size(224, 26);
            this.combo_country.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(434, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 60;
            this.label1.Text = "Кишвар:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Checked = true;
            this.dateTimePickerEnd.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimePickerEnd.FillColor = System.Drawing.Color.White;
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerEnd.ForeColor = System.Drawing.Color.Black;
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(269, 0);
            this.dateTimePickerEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(165, 27);
            this.dateTimePickerEnd.TabIndex = 59;
            this.dateTimePickerEnd.Value = new System.DateTime(2023, 2, 22, 20, 18, 57, 255);
            // 
            // labelEndDate
            // 
            this.labelEndDate.BackColor = System.Drawing.Color.White;
            this.labelEndDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelEndDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEndDate.Location = new System.Drawing.Point(210, 0);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(59, 27);
            this.labelEndDate.TabIndex = 58;
            this.labelEndDate.Text = "то кай:";
            this.labelEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Checked = true;
            this.dateTimePickerStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateTimePickerStart.FillColor = System.Drawing.Color.White;
            this.dateTimePickerStart.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerStart.ForeColor = System.Drawing.Color.Black;
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerStart.Location = new System.Drawing.Point(49, 0);
            this.dateTimePickerStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(161, 27);
            this.dateTimePickerStart.TabIndex = 57;
            this.dateTimePickerStart.Value = new System.DateTime(2023, 2, 22, 20, 18, 57, 255);
            // 
            // labelStartTime
            // 
            this.labelStartTime.BackColor = System.Drawing.Color.White;
            this.labelStartTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelStartTime.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStartTime.Location = new System.Drawing.Point(0, 0);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(49, 27);
            this.labelStartTime.TabIndex = 56;
            this.labelStartTime.Text = "Аз кай:";
            this.labelStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanelFull
            // 
            this.tableLayoutPanelFull.ColumnCount = 2;
            this.tableLayoutPanelFull.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFull.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFull.Controls.Add(this.panel_right, 1, 0);
            this.tableLayoutPanelFull.Controls.Add(this.panel_left, 0, 0);
            this.tableLayoutPanelFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelFull.Location = new System.Drawing.Point(10, 37);
            this.tableLayoutPanelFull.Name = "tableLayoutPanelFull";
            this.tableLayoutPanelFull.RowCount = 1;
            this.tableLayoutPanelFull.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelFull.Size = new System.Drawing.Size(998, 556);
            this.tableLayoutPanelFull.TabIndex = 1;
            // 
            // panel_right
            // 
            this.panel_right.Controls.Add(this.gridControlProvince);
            this.panel_right.Controls.Add(this.label_provice);
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_right.Location = new System.Drawing.Point(502, 3);
            this.panel_right.Name = "panel_right";
            this.panel_right.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel_right.Size = new System.Drawing.Size(493, 550);
            this.panel_right.TabIndex = 1;
            // 
            // gridControlProvince
            // 
            this.gridControlProvince.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProvince.Location = new System.Drawing.Point(0, 29);
            this.gridControlProvince.MainView = this.gridViewProvince;
            this.gridControlProvince.Name = "gridControlProvince";
            this.gridControlProvince.Size = new System.Drawing.Size(493, 521);
            this.gridControlProvince.TabIndex = 2;
            this.gridControlProvince.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProvince});
            // 
            // gridViewProvince
            // 
            this.gridViewProvince.ColumnPanelRowHeight = 30;
            this.gridViewProvince.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.numberRow,
            this.Province,
            this.menCount,
            this.womanCount,
            this.allCount});
            this.gridViewProvince.GridControl = this.gridControlProvince;
            this.gridViewProvince.Name = "gridViewProvince";
            this.gridViewProvince.OptionsView.ShowGroupPanel = false;
            // 
            // numberRow
            // 
            this.numberRow.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberRow.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.numberRow.AppearanceCell.Options.UseFont = true;
            this.numberRow.AppearanceCell.Options.UseForeColor = true;
            this.numberRow.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberRow.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.numberRow.AppearanceHeader.Options.UseFont = true;
            this.numberRow.AppearanceHeader.Options.UseForeColor = true;
            this.numberRow.Caption = "№";
            this.numberRow.FieldName = "row_number";
            this.numberRow.MaxWidth = 50;
            this.numberRow.MinWidth = 40;
            this.numberRow.Name = "numberRow";
            this.numberRow.OptionsColumn.AllowEdit = false;
            this.numberRow.OptionsFilter.AllowAutoFilter = false;
            this.numberRow.Visible = true;
            this.numberRow.VisibleIndex = 0;
            this.numberRow.Width = 48;
            // 
            // Province
            // 
            this.Province.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Province.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.Province.AppearanceCell.Options.UseFont = true;
            this.Province.AppearanceCell.Options.UseForeColor = true;
            this.Province.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Province.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.Province.AppearanceHeader.Options.UseFont = true;
            this.Province.AppearanceHeader.Options.UseForeColor = true;
            this.Province.Caption = "Давлат";
            this.Province.FieldName = "province";
            this.Province.MinWidth = 40;
            this.Province.Name = "Province";
            this.Province.OptionsColumn.AllowEdit = false;
            this.Province.OptionsFilter.AllowAutoFilter = false;
            this.Province.Visible = true;
            this.Province.VisibleIndex = 1;
            this.Province.Width = 246;
            // 
            // menCount
            // 
            this.menCount.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menCount.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.menCount.AppearanceCell.Options.UseFont = true;
            this.menCount.AppearanceCell.Options.UseForeColor = true;
            this.menCount.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menCount.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.menCount.AppearanceHeader.Options.UseFont = true;
            this.menCount.AppearanceHeader.Options.UseForeColor = true;
            this.menCount.Caption = "Мард";
            this.menCount.FieldName = "count_men";
            this.menCount.MaxWidth = 80;
            this.menCount.MinWidth = 60;
            this.menCount.Name = "menCount";
            this.menCount.OptionsColumn.AllowEdit = false;
            this.menCount.OptionsFilter.AllowAutoFilter = false;
            this.menCount.Visible = true;
            this.menCount.VisibleIndex = 2;
            this.menCount.Width = 67;
            // 
            // womanCount
            // 
            this.womanCount.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.womanCount.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.womanCount.AppearanceCell.Options.UseFont = true;
            this.womanCount.AppearanceCell.Options.UseForeColor = true;
            this.womanCount.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.womanCount.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.womanCount.AppearanceHeader.Options.UseFont = true;
            this.womanCount.AppearanceHeader.Options.UseForeColor = true;
            this.womanCount.Caption = "Зан";
            this.womanCount.FieldName = "count_woman";
            this.womanCount.MaxWidth = 80;
            this.womanCount.MinWidth = 60;
            this.womanCount.Name = "womanCount";
            this.womanCount.OptionsColumn.AllowEdit = false;
            this.womanCount.OptionsFilter.AllowAutoFilter = false;
            this.womanCount.Visible = true;
            this.womanCount.VisibleIndex = 3;
            this.womanCount.Width = 66;
            // 
            // allCount
            // 
            this.allCount.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allCount.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.allCount.AppearanceCell.Options.UseFont = true;
            this.allCount.AppearanceCell.Options.UseForeColor = true;
            this.allCount.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allCount.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.allCount.AppearanceHeader.Options.UseFont = true;
            this.allCount.AppearanceHeader.Options.UseForeColor = true;
            this.allCount.Caption = "Ҳамагӣ";
            this.allCount.FieldName = "count_all";
            this.allCount.MaxWidth = 80;
            this.allCount.MinWidth = 60;
            this.allCount.Name = "allCount";
            this.allCount.OptionsColumn.AllowEdit = false;
            this.allCount.OptionsFilter.AllowAutoFilter = false;
            this.allCount.Visible = true;
            this.allCount.VisibleIndex = 4;
            this.allCount.Width = 70;
            // 
            // label_provice
            // 
            this.label_provice.AutoSize = true;
            this.label_provice.BackColor = System.Drawing.Color.Silver;
            this.label_provice.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_provice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_provice.ForeColor = System.Drawing.Color.Black;
            this.label_provice.Location = new System.Drawing.Point(0, 10);
            this.label_provice.Name = "label_provice";
            this.label_provice.Size = new System.Drawing.Size(79, 19);
            this.label_provice.TabIndex = 1;
            this.label_provice.Text = "Вилоятҳо";
            // 
            // panel_left
            // 
            this.panel_left.Controls.Add(this.gridControlCountry);
            this.panel_left.Controls.Add(this.label_country);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_left.Location = new System.Drawing.Point(3, 3);
            this.panel_left.Name = "panel_left";
            this.panel_left.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel_left.Size = new System.Drawing.Size(493, 550);
            this.panel_left.TabIndex = 0;
            // 
            // gridControlCountry
            // 
            this.gridControlCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCountry.Location = new System.Drawing.Point(0, 29);
            this.gridControlCountry.MainView = this.gridViewCountry;
            this.gridControlCountry.Name = "gridControlCountry";
            this.gridControlCountry.Size = new System.Drawing.Size(493, 521);
            this.gridControlCountry.TabIndex = 1;
            this.gridControlCountry.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCountry});
            // 
            // gridViewCountry
            // 
            this.gridViewCountry.ColumnPanelRowHeight = 30;
            this.gridViewCountry.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.rowNumber,
            this.country,
            this.countMen,
            this.countWomen,
            this.countAll});
            this.gridViewCountry.GridControl = this.gridControlCountry;
            this.gridViewCountry.Name = "gridViewCountry";
            this.gridViewCountry.OptionsView.ShowGroupPanel = false;
            // 
            // rowNumber
            // 
            this.rowNumber.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rowNumber.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.rowNumber.AppearanceCell.Options.UseFont = true;
            this.rowNumber.AppearanceCell.Options.UseForeColor = true;
            this.rowNumber.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rowNumber.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.rowNumber.AppearanceHeader.Options.UseFont = true;
            this.rowNumber.AppearanceHeader.Options.UseForeColor = true;
            this.rowNumber.Caption = "№";
            this.rowNumber.FieldName = "row_number";
            this.rowNumber.MaxWidth = 50;
            this.rowNumber.MinWidth = 40;
            this.rowNumber.Name = "rowNumber";
            this.rowNumber.OptionsColumn.AllowEdit = false;
            this.rowNumber.OptionsFilter.AllowAutoFilter = false;
            this.rowNumber.Visible = true;
            this.rowNumber.VisibleIndex = 0;
            this.rowNumber.Width = 48;
            // 
            // country
            // 
            this.country.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.country.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.country.AppearanceCell.Options.UseFont = true;
            this.country.AppearanceCell.Options.UseForeColor = true;
            this.country.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.country.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.country.AppearanceHeader.Options.UseFont = true;
            this.country.AppearanceHeader.Options.UseForeColor = true;
            this.country.Caption = "Давлат";
            this.country.FieldName = "country";
            this.country.MinWidth = 40;
            this.country.Name = "country";
            this.country.OptionsColumn.AllowEdit = false;
            this.country.OptionsFilter.AllowAutoFilter = false;
            this.country.Visible = true;
            this.country.VisibleIndex = 1;
            this.country.Width = 246;
            // 
            // countMen
            // 
            this.countMen.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countMen.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.countMen.AppearanceCell.Options.UseFont = true;
            this.countMen.AppearanceCell.Options.UseForeColor = true;
            this.countMen.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countMen.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.countMen.AppearanceHeader.Options.UseFont = true;
            this.countMen.AppearanceHeader.Options.UseForeColor = true;
            this.countMen.Caption = "Мард";
            this.countMen.FieldName = "count_men";
            this.countMen.MaxWidth = 80;
            this.countMen.MinWidth = 60;
            this.countMen.Name = "countMen";
            this.countMen.OptionsColumn.AllowEdit = false;
            this.countMen.OptionsFilter.AllowAutoFilter = false;
            this.countMen.Visible = true;
            this.countMen.VisibleIndex = 2;
            this.countMen.Width = 67;
            // 
            // countWomen
            // 
            this.countWomen.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countWomen.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.countWomen.AppearanceCell.Options.UseFont = true;
            this.countWomen.AppearanceCell.Options.UseForeColor = true;
            this.countWomen.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countWomen.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.countWomen.AppearanceHeader.Options.UseFont = true;
            this.countWomen.AppearanceHeader.Options.UseForeColor = true;
            this.countWomen.Caption = "Зан";
            this.countWomen.FieldName = "count_woman";
            this.countWomen.MaxWidth = 80;
            this.countWomen.MinWidth = 60;
            this.countWomen.Name = "countWomen";
            this.countWomen.OptionsColumn.AllowEdit = false;
            this.countWomen.OptionsFilter.AllowAutoFilter = false;
            this.countWomen.Visible = true;
            this.countWomen.VisibleIndex = 3;
            this.countWomen.Width = 66;
            // 
            // countAll
            // 
            this.countAll.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countAll.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.countAll.AppearanceCell.Options.UseFont = true;
            this.countAll.AppearanceCell.Options.UseForeColor = true;
            this.countAll.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countAll.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.countAll.AppearanceHeader.Options.UseFont = true;
            this.countAll.AppearanceHeader.Options.UseForeColor = true;
            this.countAll.Caption = "Ҳамагӣ";
            this.countAll.FieldName = "count_all";
            this.countAll.MaxWidth = 80;
            this.countAll.MinWidth = 60;
            this.countAll.Name = "countAll";
            this.countAll.OptionsColumn.AllowEdit = false;
            this.countAll.OptionsFilter.AllowAutoFilter = false;
            this.countAll.Visible = true;
            this.countAll.VisibleIndex = 4;
            this.countAll.Width = 70;
            // 
            // label_country
            // 
            this.label_country.AutoSize = true;
            this.label_country.BackColor = System.Drawing.Color.Silver;
            this.label_country.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_country.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_country.ForeColor = System.Drawing.Color.Black;
            this.label_country.Location = new System.Drawing.Point(0, 10);
            this.label_country.Name = "label_country";
            this.label_country.Size = new System.Drawing.Size(83, 19);
            this.label_country.TabIndex = 0;
            this.label_country.Text = "Кишварҳо";
            // 
            // messDilalog
            // 
            this.messDilalog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.messDilalog.Caption = "Хатоги";
            this.messDilalog.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.messDilalog.Parent = null;
            this.messDilalog.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.messDilalog.Text = null;
            // 
            // ReportTwo
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 603);
            this.Controls.Add(this.tableLayoutPanelFull);
            this.Controls.Add(this.panel_top);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportTwo";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "ReportTwo";
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.combo_country.Properties)).EndInit();
            this.tableLayoutPanelFull.ResumeLayout(false);
            this.panel_right.ResumeLayout(false);
            this.panel_right.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProvince)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProvince)).EndInit();
            this.panel_left.ResumeLayout(false);
            this.panel_left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCountry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelFull;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label labelEndDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label labelStartTime;
        private DevExpress.XtraEditors.LookUpEdit combo_country;
        private System.Windows.Forms.Button buttonAns;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.Label label_provice;
        private System.Windows.Forms.Panel panel_left;
        private DevExpress.XtraGrid.GridControl gridControlCountry;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCountry;
        private DevExpress.XtraGrid.Columns.GridColumn rowNumber;
        private DevExpress.XtraGrid.Columns.GridColumn country;
        private DevExpress.XtraGrid.Columns.GridColumn countMen;
        private DevExpress.XtraGrid.Columns.GridColumn countWomen;
        private DevExpress.XtraGrid.Columns.GridColumn countAll;
        private System.Windows.Forms.Label label_country;
        private DevExpress.XtraGrid.GridControl gridControlProvince;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProvince;
        private DevExpress.XtraGrid.Columns.GridColumn numberRow;
        private DevExpress.XtraGrid.Columns.GridColumn Province;
        private DevExpress.XtraGrid.Columns.GridColumn menCount;
        private DevExpress.XtraGrid.Columns.GridColumn womanCount;
        private DevExpress.XtraGrid.Columns.GridColumn allCount;
        private Guna.UI2.WinForms.Guna2MessageDialog messDilalog;
    }
}