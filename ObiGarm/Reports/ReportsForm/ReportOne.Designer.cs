
namespace ObiGarm.Reports.ReportsForm
{
    partial class ReportOne
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
            this.panelBotton = new System.Windows.Forms.Panel();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.labelCountClent = new System.Windows.Forms.Label();
            this.panelFull = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonAns = new System.Windows.Forms.Button();
            this.txtEge = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.labelStartTime = new System.Windows.Forms.Label();
            this.gridControlReportOne = new DevExpress.XtraGrid.GridControl();
            this.gridViewReportOne = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.numberRow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.order = new DevExpress.XtraGrid.Columns.GridColumn();
            this.frimeAndRoom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.burzday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.startDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DateEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.countDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.numberPhon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelBotton.SuspendLayout();
            this.panelFull.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlReportOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReportOne)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBotton
            // 
            this.panelBotton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBotton.Controls.Add(this.buttonPrint);
            this.panelBotton.Controls.Add(this.labelCountClent);
            this.panelBotton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotton.Location = new System.Drawing.Point(10, 543);
            this.panelBotton.Name = "panelBotton";
            this.panelBotton.Padding = new System.Windows.Forms.Padding(0, 5, 10, 0);
            this.panelBotton.Size = new System.Drawing.Size(1224, 36);
            this.panelBotton.TabIndex = 2;
            // 
            // buttonPrint
            // 
            this.buttonPrint.BackColor = System.Drawing.Color.Green;
            this.buttonPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonPrint.FlatAppearance.BorderSize = 0;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrint.ForeColor = System.Drawing.Color.White;
            this.buttonPrint.Location = new System.Drawing.Point(1052, 5);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(162, 31);
            this.buttonPrint.TabIndex = 6;
            this.buttonPrint.Text = "Чопкуни";
            this.buttonPrint.UseVisualStyleBackColor = false;
            this.buttonPrint.Visible = false;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // labelCountClent
            // 
            this.labelCountClent.BackColor = System.Drawing.Color.LightGray;
            this.labelCountClent.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelCountClent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountClent.Location = new System.Drawing.Point(0, 5);
            this.labelCountClent.Name = "labelCountClent";
            this.labelCountClent.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.labelCountClent.Size = new System.Drawing.Size(170, 31);
            this.labelCountClent.TabIndex = 5;
            this.labelCountClent.Text = "Ҳамагӣ: 0 нафар";
            this.labelCountClent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelFull
            // 
            this.panelFull.Controls.Add(this.panelTop);
            this.panelFull.Controls.Add(this.gridControlReportOne);
            this.panelFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFull.Location = new System.Drawing.Point(10, 10);
            this.panelFull.Name = "panelFull";
            this.panelFull.Size = new System.Drawing.Size(1224, 533);
            this.panelFull.TabIndex = 4;
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.Controls.Add(this.buttonAns);
            this.panelTop.Controls.Add(this.txtEge);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.dateTimePickerEnd);
            this.panelTop.Controls.Add(this.labelEndDate);
            this.panelTop.Controls.Add(this.dateTimePickerStart);
            this.panelTop.Controls.Add(this.labelStartTime);
            this.panelTop.Location = new System.Drawing.Point(501, 9);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(720, 26);
            this.panelTop.TabIndex = 5;
            // 
            // buttonAns
            // 
            this.buttonAns.BackColor = System.Drawing.Color.Green;
            this.buttonAns.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonAns.FlatAppearance.BorderSize = 0;
            this.buttonAns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAns.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAns.ForeColor = System.Drawing.Color.White;
            this.buttonAns.Location = new System.Drawing.Point(602, 0);
            this.buttonAns.Name = "buttonAns";
            this.buttonAns.Size = new System.Drawing.Size(118, 26);
            this.buttonAns.TabIndex = 55;
            this.buttonAns.Text = "Намош";
            this.buttonAns.UseVisualStyleBackColor = false;
            this.buttonAns.Click += new System.EventHandler(this.buttonAns_Click);
            // 
            // txtEge
            // 
            this.txtEge.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtEge.EditValue = "0";
            this.txtEge.Location = new System.Drawing.Point(496, 0);
            this.txtEge.MaximumSize = new System.Drawing.Size(100, 35);
            this.txtEge.MinimumSize = new System.Drawing.Size(100, 25);
            this.txtEge.Name = "txtEge";
            this.txtEge.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEge.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEge.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtEge.Properties.Appearance.Options.UseBackColor = true;
            this.txtEge.Properties.Appearance.Options.UseFont = true;
            this.txtEge.Properties.Appearance.Options.UseForeColor = true;
            this.txtEge.Properties.Mask.BeepOnError = true;
            this.txtEge.Properties.Mask.EditMask = "00";
            this.txtEge.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtEge.Size = new System.Drawing.Size(100, 22);
            this.txtEge.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(434, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Сину сол:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.dateTimePickerEnd.Size = new System.Drawing.Size(165, 26);
            this.dateTimePickerEnd.TabIndex = 3;
            this.dateTimePickerEnd.Value = new System.DateTime(2023, 2, 22, 20, 18, 57, 255);
            // 
            // labelEndDate
            // 
            this.labelEndDate.BackColor = System.Drawing.Color.White;
            this.labelEndDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelEndDate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEndDate.Location = new System.Drawing.Point(210, 0);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(59, 26);
            this.labelEndDate.TabIndex = 2;
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
            this.dateTimePickerStart.Size = new System.Drawing.Size(161, 26);
            this.dateTimePickerStart.TabIndex = 1;
            this.dateTimePickerStart.Value = new System.DateTime(2023, 2, 22, 20, 18, 57, 255);
            // 
            // labelStartTime
            // 
            this.labelStartTime.BackColor = System.Drawing.Color.White;
            this.labelStartTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelStartTime.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStartTime.Location = new System.Drawing.Point(0, 0);
            this.labelStartTime.Name = "labelStartTime";
            this.labelStartTime.Size = new System.Drawing.Size(49, 26);
            this.labelStartTime.TabIndex = 0;
            this.labelStartTime.Text = "Аз кай:";
            this.labelStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gridControlReportOne
            // 
            this.gridControlReportOne.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlReportOne.Location = new System.Drawing.Point(0, 0);
            this.gridControlReportOne.MainView = this.gridViewReportOne;
            this.gridControlReportOne.Name = "gridControlReportOne";
            this.gridControlReportOne.Size = new System.Drawing.Size(1224, 533);
            this.gridControlReportOne.TabIndex = 1;
            this.gridControlReportOne.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewReportOne});
            // 
            // gridViewReportOne
            // 
            this.gridViewReportOne.ColumnPanelRowHeight = 30;
            this.gridViewReportOne.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.numberRow,
            this.order,
            this.frimeAndRoom,
            this.fullName,
            this.burzday,
            this.startDate,
            this.DateEnd,
            this.countDay,
            this.numberPhon});
            this.gridViewReportOne.GridControl = this.gridControlReportOne;
            this.gridViewReportOne.Name = "gridViewReportOne";
            this.gridViewReportOne.OptionsFind.AlwaysVisible = true;
            this.gridViewReportOne.OptionsView.ShowGroupPanel = false;
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
            this.numberRow.FieldName = "number_row";
            this.numberRow.Name = "numberRow";
            this.numberRow.Visible = true;
            this.numberRow.VisibleIndex = 0;
            this.numberRow.Width = 46;
            // 
            // order
            // 
            this.order.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.order.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.order.AppearanceCell.Options.UseFont = true;
            this.order.AppearanceCell.Options.UseForeColor = true;
            this.order.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.order.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.order.AppearanceHeader.Options.UseFont = true;
            this.order.AppearanceHeader.Options.UseForeColor = true;
            this.order.Caption = "Ордер";
            this.order.FieldName = "order";
            this.order.Name = "order";
            this.order.Visible = true;
            this.order.VisibleIndex = 1;
            this.order.Width = 98;
            // 
            // frimeAndRoom
            // 
            this.frimeAndRoom.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frimeAndRoom.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.frimeAndRoom.AppearanceCell.Options.UseFont = true;
            this.frimeAndRoom.AppearanceCell.Options.UseForeColor = true;
            this.frimeAndRoom.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.frimeAndRoom.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.frimeAndRoom.AppearanceHeader.Options.UseFont = true;
            this.frimeAndRoom.AppearanceHeader.Options.UseForeColor = true;
            this.frimeAndRoom.Caption = "Бино, ҳуҷра";
            this.frimeAndRoom.FieldName = "frime_and_room";
            this.frimeAndRoom.Name = "frimeAndRoom";
            this.frimeAndRoom.Visible = true;
            this.frimeAndRoom.VisibleIndex = 2;
            this.frimeAndRoom.Width = 162;
            // 
            // fullName
            // 
            this.fullName.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullName.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.fullName.AppearanceCell.Options.UseFont = true;
            this.fullName.AppearanceCell.Options.UseForeColor = true;
            this.fullName.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullName.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.fullName.AppearanceHeader.Options.UseFont = true;
            this.fullName.AppearanceHeader.Options.UseForeColor = true;
            this.fullName.Caption = "Ном ва насаб";
            this.fullName.FieldName = "full_name";
            this.fullName.Name = "fullName";
            this.fullName.Visible = true;
            this.fullName.VisibleIndex = 3;
            this.fullName.Width = 162;
            // 
            // burzday
            // 
            this.burzday.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.burzday.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.burzday.AppearanceCell.Options.UseFont = true;
            this.burzday.AppearanceCell.Options.UseForeColor = true;
            this.burzday.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.burzday.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.burzday.AppearanceHeader.Options.UseFont = true;
            this.burzday.AppearanceHeader.Options.UseForeColor = true;
            this.burzday.Caption = "Соли таввалуд";
            this.burzday.FieldName = "burzday";
            this.burzday.Name = "burzday";
            this.burzday.Visible = true;
            this.burzday.VisibleIndex = 4;
            this.burzday.Width = 162;
            // 
            // startDate
            // 
            this.startDate.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startDate.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.startDate.AppearanceCell.Options.UseFont = true;
            this.startDate.AppearanceCell.Options.UseForeColor = true;
            this.startDate.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startDate.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.startDate.AppearanceHeader.Options.UseFont = true;
            this.startDate.AppearanceHeader.Options.UseForeColor = true;
            this.startDate.Caption = "Аз кай";
            this.startDate.FieldName = "start_date";
            this.startDate.Name = "startDate";
            this.startDate.Visible = true;
            this.startDate.VisibleIndex = 5;
            this.startDate.Width = 162;
            // 
            // DateEnd
            // 
            this.DateEnd.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateEnd.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.DateEnd.AppearanceCell.Options.UseFont = true;
            this.DateEnd.AppearanceCell.Options.UseForeColor = true;
            this.DateEnd.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateEnd.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.DateEnd.AppearanceHeader.Options.UseFont = true;
            this.DateEnd.AppearanceHeader.Options.UseForeColor = true;
            this.DateEnd.Caption = "То кай";
            this.DateEnd.FieldName = "enb_date";
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Visible = true;
            this.DateEnd.VisibleIndex = 6;
            this.DateEnd.Width = 162;
            // 
            // countDay
            // 
            this.countDay.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countDay.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.countDay.AppearanceCell.Options.UseFont = true;
            this.countDay.AppearanceCell.Options.UseForeColor = true;
            this.countDay.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countDay.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.countDay.AppearanceHeader.Options.UseFont = true;
            this.countDay.AppearanceHeader.Options.UseForeColor = true;
            this.countDay.Caption = "М/Р";
            this.countDay.FieldName = "count_day";
            this.countDay.Name = "countDay";
            this.countDay.Visible = true;
            this.countDay.VisibleIndex = 7;
            this.countDay.Width = 162;
            // 
            // numberPhon
            // 
            this.numberPhon.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberPhon.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.numberPhon.AppearanceCell.Options.UseFont = true;
            this.numberPhon.AppearanceCell.Options.UseForeColor = true;
            this.numberPhon.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberPhon.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.numberPhon.AppearanceHeader.Options.UseFont = true;
            this.numberPhon.AppearanceHeader.Options.UseForeColor = true;
            this.numberPhon.Caption = "Рақами телефон";
            this.numberPhon.FieldName = "number_phon";
            this.numberPhon.Name = "numberPhon";
            this.numberPhon.Visible = true;
            this.numberPhon.VisibleIndex = 8;
            this.numberPhon.Width = 162;
            // 
            // ReportOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 589);
            this.Controls.Add(this.panelFull);
            this.Controls.Add(this.panelBotton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportOne";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "ReportOne";
            this.panelBotton.ResumeLayout(false);
            this.panelFull.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtEge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlReportOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewReportOne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBotton;
        private System.Windows.Forms.Panel panelFull;
        private DevExpress.XtraGrid.GridControl gridControlReportOne;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewReportOne;
        private DevExpress.XtraGrid.Columns.GridColumn numberRow;
        private DevExpress.XtraGrid.Columns.GridColumn order;
        private DevExpress.XtraGrid.Columns.GridColumn frimeAndRoom;
        private DevExpress.XtraGrid.Columns.GridColumn fullName;
        private DevExpress.XtraGrid.Columns.GridColumn burzday;
        private DevExpress.XtraGrid.Columns.GridColumn startDate;
        private DevExpress.XtraGrid.Columns.GridColumn DateEnd;
        private DevExpress.XtraGrid.Columns.GridColumn countDay;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Label labelCountClent;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button buttonAns;
        private DevExpress.XtraEditors.TextEdit txtEge;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label labelEndDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label labelStartTime;
        private DevExpress.XtraGrid.Columns.GridColumn numberPhon;
    }
}