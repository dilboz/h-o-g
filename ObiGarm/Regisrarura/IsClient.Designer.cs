namespace ObiGarm.Regisrarura
{
    partial class IsClient
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.grid_yet_not_client = new DevExpress.XtraGrid.GridControl();
            this.grid_view_yet_no_client = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.full_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.birthday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.date_time_start = new DevExpress.XtraGrid.Columns.GridColumn();
            this.date_time_end = new DevExpress.XtraGrid.Columns.GridColumn();
            this.number_money = new DevExpress.XtraGrid.Columns.GridColumn();
            this.comment_money = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vrach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.room = new DevExpress.XtraGrid.Columns.GridColumn();
            this.type_kort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.edit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_edit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.delete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btn_delete = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_yet_not_client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_yet_no_client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_yet_not_client
            // 
            this.grid_yet_not_client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_yet_not_client.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grid_yet_not_client.Location = new System.Drawing.Point(20, 20);
            this.grid_yet_not_client.MainView = this.grid_view_yet_no_client;
            this.grid_yet_not_client.Name = "grid_yet_not_client";
            this.grid_yet_not_client.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btn_edit,
            this.btn_delete});
            this.grid_yet_not_client.Size = new System.Drawing.Size(1377, 453);
            this.grid_yet_not_client.TabIndex = 1;
            this.grid_yet_not_client.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grid_view_yet_no_client});
            // 
            // grid_view_yet_no_client
            // 
            this.grid_view_yet_no_client.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.full_name,
            this.birthday,
            this.sex,
            this.date_time_start,
            this.date_time_end,
            this.number_money,
            this.comment_money,
            this.vrach,
            this.room,
            this.type_kort,
            this.edit,
            this.delete});
            this.grid_view_yet_no_client.GridControl = this.grid_yet_not_client;
            this.grid_view_yet_no_client.Name = "grid_view_yet_no_client";
            this.grid_view_yet_no_client.OptionsFind.AlwaysVisible = true;
            // 
            // id
            // 
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
            this.full_name.Caption = "Номи пурра";
            this.full_name.FieldName = "full_name";
            this.full_name.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.full_name.MinWidth = 200;
            this.full_name.Name = "full_name";
            this.full_name.OptionsColumn.AllowEdit = false;
            this.full_name.Visible = true;
            this.full_name.VisibleIndex = 0;
            this.full_name.Width = 250;
            // 
            // birthday
            // 
            this.birthday.Caption = "Соли таввалуд";
            this.birthday.FieldName = "birthday";
            this.birthday.MinWidth = 85;
            this.birthday.Name = "birthday";
            this.birthday.OptionsColumn.AllowEdit = false;
            this.birthday.Visible = true;
            this.birthday.VisibleIndex = 1;
            this.birthday.Width = 85;
            // 
            // sex
            // 
            this.sex.Caption = "Ҷинс";
            this.sex.FieldName = "sex";
            this.sex.MinWidth = 50;
            this.sex.Name = "sex";
            this.sex.OptionsColumn.AllowEdit = false;
            this.sex.Visible = true;
            this.sex.VisibleIndex = 2;
            this.sex.Width = 50;
            // 
            // date_time_start
            // 
            this.date_time_start.Caption = "Аз кай";
            this.date_time_start.DisplayFormat.FormatString = "D";
            this.date_time_start.FieldName = "date_time_start";
            this.date_time_start.MinWidth = 130;
            this.date_time_start.Name = "date_time_start";
            this.date_time_start.OptionsColumn.AllowEdit = false;
            this.date_time_start.Visible = true;
            this.date_time_start.VisibleIndex = 3;
            this.date_time_start.Width = 130;
            // 
            // date_time_end
            // 
            this.date_time_end.Caption = "То кай";
            this.date_time_end.DisplayFormat.FormatString = "D";
            this.date_time_end.FieldName = "date_time_end";
            this.date_time_end.MinWidth = 130;
            this.date_time_end.Name = "date_time_end";
            this.date_time_end.OptionsColumn.AllowEdit = false;
            this.date_time_end.Visible = true;
            this.date_time_end.VisibleIndex = 4;
            this.date_time_end.Width = 130;
            // 
            // number_money
            // 
            this.number_money.Caption = "Маблағ";
            this.number_money.FieldName = "nuber_money";
            this.number_money.MinWidth = 80;
            this.number_money.Name = "number_money";
            this.number_money.OptionsColumn.AllowEdit = false;
            this.number_money.Visible = true;
            this.number_money.VisibleIndex = 5;
            this.number_money.Width = 80;
            // 
            // comment_money
            // 
            this.comment_money.Caption = "Шарҳи маблағ";
            this.comment_money.FieldName = "comment_money";
            this.comment_money.MinWidth = 150;
            this.comment_money.Name = "comment_money";
            this.comment_money.OptionsColumn.AllowEdit = false;
            this.comment_money.Visible = true;
            this.comment_money.VisibleIndex = 6;
            this.comment_money.Width = 150;
            // 
            // vrach
            // 
            this.vrach.Caption = "Табиб";
            this.vrach.FieldName = "vrach";
            this.vrach.MinWidth = 150;
            this.vrach.Name = "vrach";
            this.vrach.OptionsColumn.AllowEdit = false;
            this.vrach.Visible = true;
            this.vrach.VisibleIndex = 7;
            this.vrach.Width = 164;
            // 
            // room
            // 
            this.room.Caption = "Ҳуҷра";
            this.room.FieldName = "room";
            this.room.MinWidth = 100;
            this.room.Name = "room";
            this.room.OptionsColumn.AllowEdit = false;
            this.room.Visible = true;
            this.room.VisibleIndex = 8;
            this.room.Width = 111;
            // 
            // type_kort
            // 
            this.type_kort.Caption = "Намуди корт";
            this.type_kort.FieldName = "type_kort";
            this.type_kort.MinWidth = 100;
            this.type_kort.Name = "type_kort";
            this.type_kort.OptionsColumn.AllowEdit = false;
            this.type_kort.Visible = true;
            this.type_kort.VisibleIndex = 9;
            this.type_kort.Width = 120;
            // 
            // edit
            // 
            this.edit.ColumnEdit = this.btn_edit;
            this.edit.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.edit.MaxWidth = 30;
            this.edit.MinWidth = 30;
            this.edit.Name = "edit";
            this.edit.Visible = true;
            this.edit.VisibleIndex = 11;
            this.edit.Width = 30;
            // 
            // btn_edit
            // 
            this.btn_edit.AutoHeight = false;
            editorButtonImageOptions1.Image = global::ObiGarm.Properties.Resources.edit_for_grid_view;
            this.btn_edit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btn_edit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_edit_ButtonClick);
            // 
            // delete
            // 
            this.delete.ColumnEdit = this.btn_delete;
            this.delete.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
            this.delete.MaxWidth = 30;
            this.delete.MinWidth = 30;
            this.delete.Name = "delete";
            this.delete.Visible = true;
            this.delete.VisibleIndex = 10;
            this.delete.Width = 30;
            // 
            // btn_delete
            // 
            this.btn_delete.AutoHeight = false;
            editorButtonImageOptions2.Image = global::ObiGarm.Properties.Resources.delete_for_grid;
            this.btn_delete.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btn_delete.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btn_delete_ButtonClick);
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions3.Image = global::ObiGarm.Properties.Resources.edit_for_grid;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick);
            // 
            // IsClient
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 493);
            this.Controls.Add(this.grid_yet_not_client);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "IsClient";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IsClient";
            this.Shown += new System.EventHandler(this.IsClient_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grid_yet_not_client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_yet_no_client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.XtraGrid.GridControl grid_yet_not_client;
        private DevExpress.XtraGrid.Views.Grid.GridView grid_view_yet_no_client;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn full_name;
        private DevExpress.XtraGrid.Columns.GridColumn birthday;
        private DevExpress.XtraGrid.Columns.GridColumn sex;
        private DevExpress.XtraGrid.Columns.GridColumn date_time_start;
        private DevExpress.XtraGrid.Columns.GridColumn date_time_end;
        private DevExpress.XtraGrid.Columns.GridColumn number_money;
        private DevExpress.XtraGrid.Columns.GridColumn comment_money;
        private DevExpress.XtraGrid.Columns.GridColumn vrach;
        private DevExpress.XtraGrid.Columns.GridColumn room;
        private DevExpress.XtraGrid.Columns.GridColumn type_kort;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btn_delete;
        private DevExpress.XtraGrid.Columns.GridColumn edit;
        private DevExpress.XtraGrid.Columns.GridColumn delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}