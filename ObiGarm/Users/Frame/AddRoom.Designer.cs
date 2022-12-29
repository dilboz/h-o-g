namespace ObiGarm.Users.Frame
{
    partial class AddRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRoom));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.panel_full = new System.Windows.Forms.Panel();
            this.panel_botton = new System.Windows.Forms.Panel();
            this.btn_hide = new System.Windows.Forms.Button();
            this.lbl_tab = new System.Windows.Forms.Label();
            this.btn_creat = new System.Windows.Forms.Button();
            this.group_name_frame = new DevExpress.XtraEditors.GroupControl();
            this.txt_name_room = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.lbl_room = new System.Windows.Forms.Label();
            this.combo_frame = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_max_count = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.panel_full.SuspendLayout();
            this.panel_botton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.group_name_frame)).BeginInit();
            this.group_name_frame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_max_count)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_full
            // 
            this.panel_full.BackColor = System.Drawing.Color.White;
            this.panel_full.Controls.Add(this.panel_botton);
            this.panel_full.Controls.Add(this.group_name_frame);
            this.panel_full.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_full.Location = new System.Drawing.Point(20, 20);
            this.panel_full.Name = "panel_full";
            this.panel_full.Padding = new System.Windows.Forms.Padding(10);
            this.panel_full.Size = new System.Drawing.Size(609, 292);
            this.panel_full.TabIndex = 0;
            // 
            // panel_botton
            // 
            this.panel_botton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_botton.Controls.Add(this.btn_hide);
            this.panel_botton.Controls.Add(this.lbl_tab);
            this.panel_botton.Controls.Add(this.btn_creat);
            this.panel_botton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_botton.Location = new System.Drawing.Point(10, 238);
            this.panel_botton.Name = "panel_botton";
            this.panel_botton.Padding = new System.Windows.Forms.Padding(8);
            this.panel_botton.Size = new System.Drawing.Size(589, 44);
            this.panel_botton.TabIndex = 12;
            // 
            // btn_hide
            // 
            this.btn_hide.BackColor = System.Drawing.Color.Red;
            this.btn_hide.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_hide.FlatAppearance.BorderSize = 0;
            this.btn_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hide.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hide.ForeColor = System.Drawing.Color.White;
            this.btn_hide.Location = new System.Drawing.Point(322, 8);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(120, 28);
            this.btn_hide.TabIndex = 3;
            this.btn_hide.Text = "Баромадан";
            this.btn_hide.UseVisualStyleBackColor = false;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // lbl_tab
            // 
            this.lbl_tab.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_tab.Location = new System.Drawing.Point(442, 8);
            this.lbl_tab.Name = "lbl_tab";
            this.lbl_tab.Size = new System.Drawing.Size(19, 28);
            this.lbl_tab.TabIndex = 2;
            // 
            // btn_creat
            // 
            this.btn_creat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(108)))), ((int)(((byte)(59)))));
            this.btn_creat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_creat.FlatAppearance.BorderSize = 0;
            this.btn_creat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_creat.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_creat.ForeColor = System.Drawing.Color.White;
            this.btn_creat.Location = new System.Drawing.Point(461, 8);
            this.btn_creat.Name = "btn_creat";
            this.btn_creat.Size = new System.Drawing.Size(120, 28);
            this.btn_creat.TabIndex = 1;
            this.btn_creat.Text = "Сохтан";
            this.btn_creat.UseVisualStyleBackColor = false;
            this.btn_creat.Click += new System.EventHandler(this.btn_creat_Click);
            // 
            // group_name_frame
            // 
            this.group_name_frame.Controls.Add(this.txt_max_count);
            this.group_name_frame.Controls.Add(this.label1);
            this.group_name_frame.Controls.Add(this.txt_name_room);
            this.group_name_frame.Controls.Add(this.lbl_room);
            this.group_name_frame.Controls.Add(this.combo_frame);
            this.group_name_frame.Controls.Add(this.lbl_name);
            this.group_name_frame.Dock = System.Windows.Forms.DockStyle.Top;
            this.group_name_frame.Location = new System.Drawing.Point(10, 10);
            this.group_name_frame.Name = "group_name_frame";
            this.group_name_frame.Padding = new System.Windows.Forms.Padding(5);
            this.group_name_frame.Size = new System.Drawing.Size(589, 222);
            this.group_name_frame.TabIndex = 1;
            this.group_name_frame.Text = "Сохтани ҳуҷра";
            // 
            // txt_name_room
            // 
            this.txt_name_room.AcceptsReturn = false;
            this.txt_name_room.AcceptsTab = false;
            this.txt_name_room.AnimationSpeed = 200;
            this.txt_name_room.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_name_room.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_name_room.BackColor = System.Drawing.Color.Transparent;
            this.txt_name_room.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_name_room.BackgroundImage")));
            this.txt_name_room.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_name_room.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txt_name_room.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_name_room.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_name_room.BorderRadius = 15;
            this.txt_name_room.BorderThickness = 1;
            this.txt_name_room.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_name_room.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name_room.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txt_name_room.DefaultText = "";
            this.txt_name_room.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_name_room.FillColor = System.Drawing.Color.White;
            this.txt_name_room.HideSelection = true;
            this.txt_name_room.IconLeft = null;
            this.txt_name_room.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name_room.IconPadding = 10;
            this.txt_name_room.IconRight = null;
            this.txt_name_room.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name_room.Lines = new string[0];
            this.txt_name_room.Location = new System.Drawing.Point(7, 114);
            this.txt_name_room.MaxLength = 32767;
            this.txt_name_room.MinimumSize = new System.Drawing.Size(100, 35);
            this.txt_name_room.Modified = false;
            this.txt_name_room.Multiline = false;
            this.txt_name_room.Name = "txt_name_room";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_name_room.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Empty;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_name_room.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_name_room.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_name_room.OnIdleState = stateProperties8;
            this.txt_name_room.PasswordChar = '\0';
            this.txt_name_room.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_name_room.PlaceholderText = "НОМ";
            this.txt_name_room.ReadOnly = false;
            this.txt_name_room.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_name_room.SelectedText = "";
            this.txt_name_room.SelectionLength = 0;
            this.txt_name_room.SelectionStart = 0;
            this.txt_name_room.ShortcutsEnabled = true;
            this.txt_name_room.Size = new System.Drawing.Size(575, 35);
            this.txt_name_room.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txt_name_room.TabIndex = 8;
            this.txt_name_room.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_name_room.TextMarginBottom = 0;
            this.txt_name_room.TextMarginLeft = 5;
            this.txt_name_room.TextMarginTop = 0;
            this.txt_name_room.TextPlaceholder = "НОМ";
            this.txt_name_room.UseSystemPasswordChar = false;
            this.txt_name_room.WordWrap = true;
            // 
            // lbl_room
            // 
            this.lbl_room.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_room.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room.Location = new System.Drawing.Point(7, 89);
            this.lbl_room.Name = "lbl_room";
            this.lbl_room.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbl_room.Size = new System.Drawing.Size(575, 25);
            this.lbl_room.TabIndex = 7;
            this.lbl_room.Text = "Рақами ҳуҷра:";
            this.lbl_room.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // combo_frame
            // 
            this.combo_frame.BackColor = System.Drawing.Color.Transparent;
            this.combo_frame.BorderRadius = 10;
            this.combo_frame.Dock = System.Windows.Forms.DockStyle.Top;
            this.combo_frame.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_frame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_frame.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_frame.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_frame.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_frame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_frame.ItemHeight = 30;
            this.combo_frame.Location = new System.Drawing.Point(7, 53);
            this.combo_frame.Name = "combo_frame";
            this.combo_frame.Size = new System.Drawing.Size(575, 36);
            this.combo_frame.TabIndex = 6;
            // 
            // lbl_name
            // 
            this.lbl_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(7, 28);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbl_name.Size = new System.Drawing.Size(575, 25);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Номи бино:";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 149);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(575, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Шумораи истироҳаткунанда:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_max_count
            // 
            this.txt_max_count.BackColor = System.Drawing.Color.Transparent;
            this.txt_max_count.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(108)))), ((int)(((byte)(59)))));
            this.txt_max_count.BorderRadius = 10;
            this.txt_max_count.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_max_count.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_max_count.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_max_count.Location = new System.Drawing.Point(7, 174);
            this.txt_max_count.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txt_max_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txt_max_count.Name = "txt_max_count";
            this.txt_max_count.Size = new System.Drawing.Size(575, 30);
            this.txt_max_count.TabIndex = 40;
            this.txt_max_count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddRoom
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 332);
            this.Controls.Add(this.panel_full);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRoom";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ҳуҷра";
            this.Shown += new System.EventHandler(this.AddRoom_Shown);
            this.panel_full.ResumeLayout(false);
            this.panel_botton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.group_name_frame)).EndInit();
            this.group_name_frame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_max_count)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private System.Windows.Forms.Panel panel_full;
        private DevExpress.XtraEditors.GroupControl group_name_frame;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Panel panel_botton;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.Label lbl_tab;
        private System.Windows.Forms.Button btn_creat;
        private System.Windows.Forms.Label lbl_room;
        private Guna.UI2.WinForms.Guna2ComboBox combo_frame;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_name_room;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2NumericUpDown txt_max_count;
    }
}