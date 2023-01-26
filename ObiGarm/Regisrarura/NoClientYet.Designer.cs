namespace ObiGarm.Regisrarura
{
    partial class NoClientYet
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.grid_yet_not_client = new DevExpress.XtraGrid.GridControl();
            this.grid_view_yet_no_client = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.full_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.room = new DevExpress.XtraGrid.Columns.GridColumn();
            this.type_kort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.to_vrach_column = new DevExpress.XtraGrid.Columns.GridColumn();
            this.to_vrach = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.sex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vrach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.date_time_end = new DevExpress.XtraGrid.Columns.GridColumn();
            this.date_time_start = new DevExpress.XtraGrid.Columns.GridColumn();
            this.year_birthday = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_yet_not_client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_yet_no_client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.to_vrach)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_yet_not_client
            // 
            this.grid_yet_not_client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_yet_not_client.Location = new System.Drawing.Point(10, 10);
            this.grid_yet_not_client.MainView = this.grid_view_yet_no_client;
            this.grid_yet_not_client.Name = "grid_yet_not_client";
            this.grid_yet_not_client.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.to_vrach});
            this.grid_yet_not_client.Size = new System.Drawing.Size(1185, 472);
            this.grid_yet_not_client.TabIndex = 0;
            this.grid_yet_not_client.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grid_view_yet_no_client});
            // 
            // grid_view_yet_no_client
            // 
            this.grid_view_yet_no_client.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.full_name,
            this.room,
            this.type_kort,
            this.to_vrach_column});
            this.grid_view_yet_no_client.GridControl = this.grid_yet_not_client;
            this.grid_view_yet_no_client.Name = "grid_view_yet_no_client";
            this.grid_view_yet_no_client.OptionsFind.AlwaysVisible = true;
            this.grid_view_yet_no_client.OptionsView.ShowGroupPanel = false;
            // 
            // id
            // 
            this.id.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.AppearanceCell.Options.UseFont = true;
            this.id.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.id.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.id.AppearanceHeader.Options.UseBackColor = true;
            this.id.AppearanceHeader.Options.UseFont = true;
            this.id.AppearanceHeader.Options.UseForeColor = true;
            this.id.Caption = "ID";
            this.id.FieldName = "id";
            this.id.MaxWidth = 25;
            this.id.MinWidth = 25;
            this.id.Name = "id";
            this.id.OptionsColumn.AllowEdit = false;
            this.id.Width = 25;
            // 
            // full_name
            // 
            this.full_name.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.full_name.AppearanceCell.Options.UseFont = true;
            this.full_name.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.full_name.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.full_name.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.full_name.AppearanceHeader.Options.UseBackColor = true;
            this.full_name.AppearanceHeader.Options.UseFont = true;
            this.full_name.AppearanceHeader.Options.UseForeColor = true;
            this.full_name.Caption = "Номи пурра";
            this.full_name.FieldName = "full_name";
            this.full_name.Name = "full_name";
            this.full_name.OptionsColumn.AllowEdit = false;
            this.full_name.Visible = true;
            this.full_name.VisibleIndex = 0;
            // 
            // room
            // 
            this.room.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room.AppearanceCell.Options.UseFont = true;
            this.room.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.room.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.room.AppearanceHeader.Options.UseBackColor = true;
            this.room.AppearanceHeader.Options.UseFont = true;
            this.room.AppearanceHeader.Options.UseForeColor = true;
            this.room.Caption = "Ҳуҷра";
            this.room.FieldName = "room";
            this.room.MaxWidth = 250;
            this.room.MinWidth = 230;
            this.room.Name = "room";
            this.room.OptionsColumn.AllowEdit = false;
            this.room.Visible = true;
            this.room.VisibleIndex = 1;
            this.room.Width = 250;
            // 
            // type_kort
            // 
            this.type_kort.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_kort.AppearanceCell.Options.UseFont = true;
            this.type_kort.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.type_kort.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_kort.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.type_kort.AppearanceHeader.Options.UseBackColor = true;
            this.type_kort.AppearanceHeader.Options.UseFont = true;
            this.type_kort.AppearanceHeader.Options.UseForeColor = true;
            this.type_kort.Caption = "Намуди корт";
            this.type_kort.FieldName = "type_kort";
            this.type_kort.MaxWidth = 200;
            this.type_kort.MinWidth = 250;
            this.type_kort.Name = "type_kort";
            this.type_kort.OptionsColumn.AllowEdit = false;
            this.type_kort.Visible = true;
            this.type_kort.VisibleIndex = 2;
            this.type_kort.Width = 250;
            // 
            // to_vrach_column
            // 
            this.to_vrach_column.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_vrach_column.AppearanceCell.Options.UseFont = true;
            this.to_vrach_column.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.to_vrach_column.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_vrach_column.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.to_vrach_column.AppearanceHeader.Options.UseBackColor = true;
            this.to_vrach_column.AppearanceHeader.Options.UseFont = true;
            this.to_vrach_column.AppearanceHeader.Options.UseForeColor = true;
            this.to_vrach_column.ColumnEdit = this.to_vrach;
            this.to_vrach_column.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.to_vrach_column.MaxWidth = 32;
            this.to_vrach_column.MinWidth = 32;
            this.to_vrach_column.Name = "to_vrach_column";
            this.to_vrach_column.OptionsFilter.AllowAutoFilter = false;
            this.to_vrach_column.Visible = true;
            this.to_vrach_column.VisibleIndex = 3;
            this.to_vrach_column.Width = 32;
            // 
            // to_vrach
            // 
            this.to_vrach.AutoHeight = false;
            editorButtonImageOptions1.Image = global::ObiGarm.Properties.Resources.order24x24;
            this.to_vrach.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.to_vrach.Name = "to_vrach";
            this.to_vrach.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.to_vrach.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.to_vrach_ButtonClick_1);
            // 
            // sex
            // 
            this.sex.Caption = "Ҷинс";
            this.sex.FieldName = "sex";
            this.sex.MinWidth = 50;
            this.sex.Name = "sex";
            this.sex.OptionsColumn.AllowEdit = false;
            this.sex.Width = 50;
            // 
            // vrach
            // 
            this.vrach.Caption = "Табиб";
            this.vrach.FieldName = "vrach";
            this.vrach.MinWidth = 150;
            this.vrach.Name = "vrach";
            this.vrach.OptionsColumn.AllowEdit = false;
            this.vrach.Width = 164;
            // 
            // date_time_end
            // 
            this.date_time_end.Caption = "То кай";
            this.date_time_end.DisplayFormat.FormatString = "D";
            this.date_time_end.FieldName = "date_time_end";
            this.date_time_end.MinWidth = 130;
            this.date_time_end.Name = "date_time_end";
            this.date_time_end.OptionsColumn.AllowEdit = false;
            this.date_time_end.Width = 130;
            // 
            // date_time_start
            // 
            this.date_time_start.Caption = "Аз кай";
            this.date_time_start.DisplayFormat.FormatString = "D";
            this.date_time_start.FieldName = "date_time_start";
            this.date_time_start.MinWidth = 130;
            this.date_time_start.Name = "date_time_start";
            this.date_time_start.OptionsColumn.AllowEdit = false;
            this.date_time_start.Width = 130;
            // 
            // year_birthday
            // 
            this.year_birthday.Caption = "Соли таввалуд";
            this.year_birthday.FieldName = "year_birthday";
            this.year_birthday.MinWidth = 85;
            this.year_birthday.Name = "year_birthday";
            this.year_birthday.OptionsColumn.AllowEdit = false;
            this.year_birthday.Width = 85;
            // 
            // NoClientYet
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 492);
            this.Controls.Add(this.grid_yet_not_client);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.ShowIcon = false;
            this.Name = "NoClientYet";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowInTaskbar = false;
            this.Text = "NoClientYet";
            this.Shown += new System.EventHandler(this.NoClientYet_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grid_yet_not_client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_yet_no_client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.to_vrach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.XtraGrid.GridControl grid_yet_not_client;
        private DevExpress.XtraGrid.Views.Grid.GridView grid_view_yet_no_client;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn full_name;
        private DevExpress.XtraGrid.Columns.GridColumn birthday;
        private DevExpress.XtraGrid.Columns.GridColumn room;
        private DevExpress.XtraGrid.Columns.GridColumn type_kort;
        private DevExpress.XtraGrid.Columns.GridColumn to_vrach_column;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit to_vrach;
        private DevExpress.XtraGrid.Columns.GridColumn sex;
        private DevExpress.XtraGrid.Columns.GridColumn vrach;
        private DevExpress.XtraGrid.Columns.GridColumn date_time_end;
        private DevExpress.XtraGrid.Columns.GridColumn date_time_start;
        private DevExpress.XtraGrid.Columns.GridColumn year_birthday;
    }
}