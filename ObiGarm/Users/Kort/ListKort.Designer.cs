namespace ObiGarm.Users.Kort
{
    partial class ListKort
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions4 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject13 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject14 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject15 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject16 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grid_gontrol_list_kort = new DevExpress.XtraGrid.GridControl();
            this.grid_view = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.kod_kort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.type_kort = new DevExpress.XtraGrid.Columns.GridColumn();
            this.edit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.edit_button = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.delete = new DevExpress.XtraGrid.Columns.GridColumn();
            this.delete_button = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_gontrol_list_kort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_button)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.grid_gontrol_list_kort);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 54);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.panel2.Size = new System.Drawing.Size(905, 383);
            this.panel2.TabIndex = 3;
            // 
            // grid_gontrol_list_kort
            // 
            this.grid_gontrol_list_kort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_gontrol_list_kort.Location = new System.Drawing.Point(10, 0);
            this.grid_gontrol_list_kort.MainView = this.grid_view;
            this.grid_gontrol_list_kort.Name = "grid_gontrol_list_kort";
            this.grid_gontrol_list_kort.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.edit_button,
            this.delete_button});
            this.grid_gontrol_list_kort.Size = new System.Drawing.Size(885, 373);
            this.grid_gontrol_list_kort.TabIndex = 1;
            this.grid_gontrol_list_kort.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grid_view});
            // 
            // grid_view
            // 
            this.grid_view.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.kod_kort,
            this.type_kort,
            this.edit,
            this.delete});
            this.grid_view.GridControl = this.grid_gontrol_list_kort;
            this.grid_view.Name = "grid_view";
            this.grid_view.OptionsFind.AlwaysVisible = true;
            this.grid_view.OptionsView.ShowGroupPanel = false;
            // 
            // id
            // 
            this.id.Caption = "id";
            this.id.FieldName = "id";
            this.id.MaxWidth = 40;
            this.id.MinWidth = 40;
            this.id.Name = "id";
            this.id.OptionsColumn.AllowEdit = false;
            this.id.Width = 40;
            // 
            // kod_kort
            // 
            this.kod_kort.Caption = "Рамзи корт";
            this.kod_kort.FieldName = "kod_kort";
            this.kod_kort.MinWidth = 80;
            this.kod_kort.Name = "kod_kort";
            this.kod_kort.OptionsColumn.AllowEdit = false;
            this.kod_kort.Visible = true;
            this.kod_kort.VisibleIndex = 0;
            this.kod_kort.Width = 709;
            // 
            // type_kort
            // 
            this.type_kort.Caption = "Намуди корт";
            this.type_kort.FieldName = "name";
            this.type_kort.MaxWidth = 300;
            this.type_kort.MinWidth = 280;
            this.type_kort.Name = "type_kort";
            this.type_kort.OptionsColumn.AllowEdit = false;
            this.type_kort.OptionsEditForm.CaptionLocation = DevExpress.XtraGrid.EditForm.EditFormColumnCaptionLocation.Top;
            this.type_kort.OptionsEditForm.StartNewRow = true;
            this.type_kort.Visible = true;
            this.type_kort.VisibleIndex = 1;
            this.type_kort.Width = 280;
            // 
            // edit
            // 
            this.edit.ColumnEdit = this.edit_button;
            this.edit.MaxWidth = 30;
            this.edit.MinWidth = 30;
            this.edit.Name = "edit";
            this.edit.Visible = true;
            this.edit.VisibleIndex = 2;
            this.edit.Width = 30;
            // 
            // edit_button
            // 
            this.edit_button.AutoHeight = false;
            editorButtonImageOptions3.Image = global::ObiGarm.Properties.Resources.edit_for_grid_view;
            this.edit_button.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.edit_button.Name = "edit_button";
            this.edit_button.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // delete
            // 
            this.delete.ColumnEdit = this.delete_button;
            this.delete.MaxWidth = 30;
            this.delete.MinWidth = 30;
            this.delete.Name = "delete";
            this.delete.Visible = true;
            this.delete.VisibleIndex = 3;
            this.delete.Width = 30;
            // 
            // delete_button
            // 
            this.delete_button.AutoHeight = false;
            editorButtonImageOptions4.Image = global::ObiGarm.Properties.Resources.delete_for_grid;
            this.delete_button.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions4, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject13, serializableAppearanceObject14, serializableAppearanceObject15, serializableAppearanceObject16, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.delete_button.Name = "delete_button";
            this.delete_button.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(905, 44);
            this.panel1.TabIndex = 2;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(108)))), ((int)(((byte)(59)))));
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(775, 10);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(120, 24);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Сохтан";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // ListKort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 447);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListKort";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "ListKort";
            this.Shown += new System.EventHandler(this.ListKort_Shown);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_gontrol_list_kort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_button)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_add;
        private DevExpress.XtraGrid.GridControl grid_gontrol_list_kort;
        private DevExpress.XtraGrid.Views.Grid.GridView grid_view;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn kod_kort;
        private DevExpress.XtraGrid.Columns.GridColumn type_kort;
        private DevExpress.XtraGrid.Columns.GridColumn edit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit edit_button;
        private DevExpress.XtraGrid.Columns.GridColumn delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit delete_button;
    }
}