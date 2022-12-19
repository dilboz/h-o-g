namespace ObiGarm.Users.Bonk
{
    partial class ListBonk
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.panelfuul_frame = new System.Windows.Forms.Panel();
            this.datagridview_bank = new Guna.UI2.WinForms.Guna2DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel_botton_frame = new System.Windows.Forms.Panel();
            this.add_frame = new System.Windows.Forms.Button();
            this.panelfuul_frame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_bank)).BeginInit();
            this.panel_botton_frame.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelfuul_frame
            // 
            this.panelfuul_frame.BackColor = System.Drawing.Color.White;
            this.panelfuul_frame.Controls.Add(this.datagridview_bank);
            this.panelfuul_frame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelfuul_frame.Location = new System.Drawing.Point(10, 58);
            this.panelfuul_frame.Name = "panelfuul_frame";
            this.panelfuul_frame.Padding = new System.Windows.Forms.Padding(10);
            this.panelfuul_frame.Size = new System.Drawing.Size(867, 440);
            this.panelfuul_frame.TabIndex = 16;
            // 
            // datagridview_bank
            // 
            this.datagridview_bank.AllowUserToAddRows = false;
            this.datagridview_bank.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.datagridview_bank.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.datagridview_bank.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(108)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(108)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridview_bank.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.datagridview_bank.ColumnHeadersHeight = 30;
            this.datagridview_bank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridview_bank.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.edit,
            this.delete});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridview_bank.DefaultCellStyle = dataGridViewCellStyle10;
            this.datagridview_bank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridview_bank.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridview_bank.Location = new System.Drawing.Point(10, 10);
            this.datagridview_bank.Name = "datagridview_bank";
            this.datagridview_bank.ReadOnly = true;
            this.datagridview_bank.RowHeadersVisible = false;
            this.datagridview_bank.Size = new System.Drawing.Size(847, 420);
            this.datagridview_bank.TabIndex = 1;
            this.datagridview_bank.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridview_bank.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.datagridview_bank.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.datagridview_bank.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.datagridview_bank.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.datagridview_bank.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.datagridview_bank.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridview_bank.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.datagridview_bank.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.datagridview_bank.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridview_bank.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridview_bank.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.datagridview_bank.ThemeStyle.HeaderStyle.Height = 30;
            this.datagridview_bank.ThemeStyle.ReadOnly = true;
            this.datagridview_bank.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridview_bank.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridview_bank.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datagridview_bank.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagridview_bank.ThemeStyle.RowsStyle.Height = 22;
            this.datagridview_bank.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.datagridview_bank.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.datagridview_bank.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridview_bank_CellContentClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id.DataPropertyName = "id";
            this.id.FillWeight = 50F;
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 50;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.FillWeight = 39.37896F;
            this.name.HeaderText = "Номи бонк";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(4);
            this.edit.DefaultCellStyle = dataGridViewCellStyle8;
            this.edit.FillWeight = 50F;
            this.edit.HeaderText = "";
            this.edit.Image = global::ObiGarm.Properties.Resources.icons8_edit_26px;
            this.edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.edit.MinimumWidth = 50;
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Width = 50;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.delete.DefaultCellStyle = dataGridViewCellStyle9;
            this.delete.FillWeight = 50F;
            this.delete.HeaderText = "";
            this.delete.Image = global::ObiGarm.Properties.Resources.delete_96px;
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete.MinimumWidth = 50;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 50;
            // 
            // panel_botton_frame
            // 
            this.panel_botton_frame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_botton_frame.Controls.Add(this.add_frame);
            this.panel_botton_frame.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_botton_frame.Location = new System.Drawing.Point(10, 10);
            this.panel_botton_frame.Name = "panel_botton_frame";
            this.panel_botton_frame.Padding = new System.Windows.Forms.Padding(8);
            this.panel_botton_frame.Size = new System.Drawing.Size(867, 48);
            this.panel_botton_frame.TabIndex = 15;
            // 
            // add_frame
            // 
            this.add_frame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(108)))), ((int)(((byte)(59)))));
            this.add_frame.Dock = System.Windows.Forms.DockStyle.Right;
            this.add_frame.FlatAppearance.BorderSize = 0;
            this.add_frame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_frame.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_frame.ForeColor = System.Drawing.Color.White;
            this.add_frame.Location = new System.Drawing.Point(739, 8);
            this.add_frame.Name = "add_frame";
            this.add_frame.Size = new System.Drawing.Size(120, 32);
            this.add_frame.TabIndex = 1;
            this.add_frame.Text = "Сохтан";
            this.add_frame.UseVisualStyleBackColor = false;
            this.add_frame.Click += new System.EventHandler(this.add_frame_Click);
            // 
            // ListBonk
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 508);
            this.Controls.Add(this.panelfuul_frame);
            this.Controls.Add(this.panel_botton_frame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListBonk";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListBonk";
            this.Shown += new System.EventHandler(this.ListBonk_Shown);
            this.panelfuul_frame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridview_bank)).EndInit();
            this.panel_botton_frame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private System.Windows.Forms.Panel panelfuul_frame;
        private Guna.UI2.WinForms.Guna2DataGridView datagridview_bank;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.Panel panel_botton_frame;
        private System.Windows.Forms.Button add_frame;
    }
}