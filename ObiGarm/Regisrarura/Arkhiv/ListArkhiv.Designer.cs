
namespace ObiGarm.Regisrarura.Arkhiv
{
    partial class ListArkhiv
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
            this.grid_yet_not_client = new DevExpress.XtraGrid.GridControl();
            this.grid_view_client = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.number_order = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.full_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.date_time_start = new DevExpress.XtraGrid.Columns.GridColumn();
            this.date_time_end = new DevExpress.XtraGrid.Columns.GridColumn();
            this.to_vrach_column = new DevExpress.XtraGrid.Columns.GridColumn();
            this.to_vrach = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_yet_not_client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.to_vrach)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_yet_not_client
            // 
            this.grid_yet_not_client.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_yet_not_client.Location = new System.Drawing.Point(10, 10);
            this.grid_yet_not_client.MainView = this.grid_view_client;
            this.grid_yet_not_client.Name = "grid_yet_not_client";
            this.grid_yet_not_client.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.to_vrach});
            this.grid_yet_not_client.Size = new System.Drawing.Size(1370, 582);
            this.grid_yet_not_client.TabIndex = 1;
            this.grid_yet_not_client.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grid_view_client});
            // 
            // grid_view_client
            // 
            this.grid_view_client.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.number_order,
            this.id,
            this.full_name,
            this.date_time_start,
            this.date_time_end,
            this.to_vrach_column});
            this.grid_view_client.GridControl = this.grid_yet_not_client;
            this.grid_view_client.Name = "grid_view_client";
            this.grid_view_client.OptionsFind.AlwaysVisible = true;
            this.grid_view_client.OptionsView.ShowGroupPanel = false;
            // 
            // number_order
            // 
            this.number_order.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.number_order.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.number_order.AppearanceCell.Options.UseFont = true;
            this.number_order.AppearanceCell.Options.UseForeColor = true;
            this.number_order.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.number_order.AppearanceHeader.BackColor2 = System.Drawing.Color.White;
            this.number_order.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.number_order.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.number_order.AppearanceHeader.Options.UseBackColor = true;
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
            this.full_name.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.full_name.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.full_name.AppearanceCell.Options.UseFont = true;
            this.full_name.AppearanceCell.Options.UseForeColor = true;
            this.full_name.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.full_name.AppearanceHeader.BackColor2 = System.Drawing.Color.White;
            this.full_name.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.full_name.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.full_name.AppearanceHeader.Options.UseBackColor = true;
            this.full_name.AppearanceHeader.Options.UseFont = true;
            this.full_name.AppearanceHeader.Options.UseForeColor = true;
            this.full_name.Caption = "Номи пурра";
            this.full_name.FieldName = "full_name";
            this.full_name.Name = "full_name";
            this.full_name.OptionsColumn.AllowEdit = false;
            this.full_name.Visible = true;
            this.full_name.VisibleIndex = 1;
            // 
            // date_time_start
            // 
            this.date_time_start.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.date_time_start.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.date_time_start.AppearanceCell.Options.UseFont = true;
            this.date_time_start.AppearanceCell.Options.UseForeColor = true;
            this.date_time_start.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.date_time_start.AppearanceHeader.BackColor2 = System.Drawing.Color.White;
            this.date_time_start.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.date_time_start.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.date_time_start.AppearanceHeader.Options.UseBackColor = true;
            this.date_time_start.AppearanceHeader.Options.UseFont = true;
            this.date_time_start.AppearanceHeader.Options.UseForeColor = true;
            this.date_time_start.Caption = "Аз кай";
            this.date_time_start.DisplayFormat.FormatString = "D";
            this.date_time_start.FieldName = "date_time_start";
            this.date_time_start.MaxWidth = 250;
            this.date_time_start.MinWidth = 230;
            this.date_time_start.Name = "date_time_start";
            this.date_time_start.OptionsColumn.AllowEdit = false;
            this.date_time_start.Visible = true;
            this.date_time_start.VisibleIndex = 2;
            this.date_time_start.Width = 250;
            // 
            // date_time_end
            // 
            this.date_time_end.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.date_time_end.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.date_time_end.AppearanceCell.Options.UseFont = true;
            this.date_time_end.AppearanceCell.Options.UseForeColor = true;
            this.date_time_end.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.date_time_end.AppearanceHeader.BackColor2 = System.Drawing.Color.White;
            this.date_time_end.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.date_time_end.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.date_time_end.AppearanceHeader.Options.UseBackColor = true;
            this.date_time_end.AppearanceHeader.Options.UseFont = true;
            this.date_time_end.AppearanceHeader.Options.UseForeColor = true;
            this.date_time_end.Caption = "То кай";
            this.date_time_end.DisplayFormat.FormatString = "D";
            this.date_time_end.FieldName = "date_time_end";
            this.date_time_end.MaxWidth = 250;
            this.date_time_end.Name = "date_time_end";
            this.date_time_end.OptionsColumn.AllowEdit = false;
            this.date_time_end.Visible = true;
            this.date_time_end.VisibleIndex = 3;
            this.date_time_end.Width = 240;
            // 
            // to_vrach_column
            // 
            this.to_vrach_column.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 8.25F);
            this.to_vrach_column.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.to_vrach_column.AppearanceCell.Options.UseFont = true;
            this.to_vrach_column.AppearanceCell.Options.UseForeColor = true;
            this.to_vrach_column.AppearanceHeader.BackColor = System.Drawing.Color.White;
            this.to_vrach_column.AppearanceHeader.BackColor2 = System.Drawing.Color.White;
            this.to_vrach_column.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.to_vrach_column.AppearanceHeader.ForeColor = System.Drawing.Color.Black;
            this.to_vrach_column.AppearanceHeader.Options.UseBackColor = true;
            this.to_vrach_column.AppearanceHeader.Options.UseFont = true;
            this.to_vrach_column.AppearanceHeader.Options.UseForeColor = true;
            this.to_vrach_column.ColumnEdit = this.to_vrach;
            this.to_vrach_column.MaxWidth = 32;
            this.to_vrach_column.MinWidth = 32;
            this.to_vrach_column.Name = "to_vrach_column";
            this.to_vrach_column.OptionsFilter.AllowAutoFilter = false;
            this.to_vrach_column.Visible = true;
            this.to_vrach_column.VisibleIndex = 4;
            this.to_vrach_column.Width = 32;
            // 
            // to_vrach
            // 
            this.to_vrach.AutoHeight = false;
            editorButtonImageOptions1.Image = global::ObiGarm.Properties.Resources.order;
            this.to_vrach.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.to_vrach.Name = "to_vrach";
            this.to_vrach.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.to_vrach.Click += new System.EventHandler(this.to_vrach_Click);
            // 
            // ListArkhiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 602);
            this.Controls.Add(this.grid_yet_not_client);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.ShowIcon = false;
            this.Name = "ListArkhiv";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListArkhiv";
            this.Shown += new System.EventHandler(this.ListArkhiv_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.grid_yet_not_client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_view_client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.to_vrach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grid_yet_not_client;
        private DevExpress.XtraGrid.Views.Grid.GridView grid_view_client;
        private DevExpress.XtraGrid.Columns.GridColumn number_order;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn full_name;
        private DevExpress.XtraGrid.Columns.GridColumn date_time_start;
        private DevExpress.XtraGrid.Columns.GridColumn date_time_end;
        private DevExpress.XtraGrid.Columns.GridColumn to_vrach_column;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit to_vrach;
    }
}