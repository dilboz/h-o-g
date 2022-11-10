namespace ObiGarm.Regisrarura.Lists
{
    partial class ListVrach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListVrach));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.list_load_vrach = new DevExpress.XtraEditors.ListBoxControl();
            this.search_list_vrach = new DevExpress.XtraEditors.SearchControl();
            this.label_tab = new System.Windows.Forms.Label();
            this.panel_btn_doctor = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_inser_vrach = new System.Windows.Forms.Button();
            this.txt_vrach = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.lbl_room = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_load_vrach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_list_vrach.Properties)).BeginInit();
            this.panel_btn_doctor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.list_load_vrach);
            this.groupControl1.Controls.Add(this.search_list_vrach);
            this.groupControl1.Controls.Add(this.label_tab);
            this.groupControl1.Controls.Add(this.panel_btn_doctor);
            this.groupControl1.Controls.Add(this.txt_vrach);
            this.groupControl1.Controls.Add(this.lbl_room);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(15, 15);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Padding = new System.Windows.Forms.Padding(10);
            this.groupControl1.Size = new System.Drawing.Size(630, 358);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Табиб";
            // 
            // list_load_vrach
            // 
            this.list_load_vrach.Dock = System.Windows.Forms.DockStyle.Top;
            this.list_load_vrach.Location = new System.Drawing.Point(12, 122);
            this.list_load_vrach.Name = "list_load_vrach";
            this.list_load_vrach.Size = new System.Drawing.Size(606, 182);
            this.list_load_vrach.TabIndex = 30;
            this.list_load_vrach.Click += new System.EventHandler(this.list_load_vrach_Click);
            // 
            // search_list_vrach
            // 
            this.search_list_vrach.Client = this.list_load_vrach;
            this.search_list_vrach.Dock = System.Windows.Forms.DockStyle.Top;
            this.search_list_vrach.Location = new System.Drawing.Point(12, 102);
            this.search_list_vrach.Name = "search_list_vrach";
            this.search_list_vrach.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.search_list_vrach.Properties.Client = this.list_load_vrach;
            this.search_list_vrach.Size = new System.Drawing.Size(606, 20);
            this.search_list_vrach.TabIndex = 29;            // 
            // label_tab
            // 
            this.label_tab.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_tab.Location = new System.Drawing.Point(12, 88);
            this.label_tab.Name = "label_tab";
            this.label_tab.Size = new System.Drawing.Size(606, 14);
            this.label_tab.TabIndex = 27;
            // 
            // panel_btn_doctor
            // 
            this.panel_btn_doctor.BackColor = System.Drawing.Color.White;
            this.panel_btn_doctor.Controls.Add(this.btn_exit);
            this.panel_btn_doctor.Controls.Add(this.label7);
            this.panel_btn_doctor.Controls.Add(this.btn_inser_vrach);
            this.panel_btn_doctor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_btn_doctor.Location = new System.Drawing.Point(12, 302);
            this.panel_btn_doctor.Name = "panel_btn_doctor";
            this.panel_btn_doctor.Padding = new System.Windows.Forms.Padding(8);
            this.panel_btn_doctor.Size = new System.Drawing.Size(606, 44);
            this.panel_btn_doctor.TabIndex = 26;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(332, 8);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(116, 28);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Баромадан";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Location = new System.Drawing.Point(448, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 28);
            this.label7.TabIndex = 2;
            // 
            // btn_inser_vrach
            // 
            this.btn_inser_vrach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(108)))), ((int)(((byte)(59)))));
            this.btn_inser_vrach.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_inser_vrach.FlatAppearance.BorderSize = 0;
            this.btn_inser_vrach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inser_vrach.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inser_vrach.ForeColor = System.Drawing.Color.White;
            this.btn_inser_vrach.Location = new System.Drawing.Point(461, 8);
            this.btn_inser_vrach.Name = "btn_inser_vrach";
            this.btn_inser_vrach.Size = new System.Drawing.Size(137, 28);
            this.btn_inser_vrach.TabIndex = 1;
            this.btn_inser_vrach.Text = "Интихоби табиб";
            this.btn_inser_vrach.UseVisualStyleBackColor = false;
            this.btn_inser_vrach.Click += new System.EventHandler(this.btn_inser_vrach_Click);
            // 
            // txt_vrach
            // 
            this.txt_vrach.AcceptsReturn = false;
            this.txt_vrach.AcceptsTab = false;
            this.txt_vrach.AnimationSpeed = 200;
            this.txt_vrach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_vrach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_vrach.BackColor = System.Drawing.Color.Transparent;
            this.txt_vrach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_vrach.BackgroundImage")));
            this.txt_vrach.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_vrach.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txt_vrach.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_vrach.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_vrach.BorderRadius = 15;
            this.txt_vrach.BorderThickness = 1;
            this.txt_vrach.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_vrach.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_vrach.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txt_vrach.DefaultText = "";
            this.txt_vrach.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_vrach.FillColor = System.Drawing.Color.White;
            this.txt_vrach.HideSelection = true;
            this.txt_vrach.IconLeft = null;
            this.txt_vrach.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_vrach.IconPadding = 10;
            this.txt_vrach.IconRight = null;
            this.txt_vrach.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_vrach.Lines = new string[0];
            this.txt_vrach.Location = new System.Drawing.Point(12, 58);
            this.txt_vrach.MaxLength = 32767;
            this.txt_vrach.MinimumSize = new System.Drawing.Size(100, 30);
            this.txt_vrach.Modified = false;
            this.txt_vrach.Multiline = false;
            this.txt_vrach.Name = "txt_vrach";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_vrach.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.Empty;
            stateProperties14.FillColor = System.Drawing.Color.White;
            stateProperties14.ForeColor = System.Drawing.Color.Empty;
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_vrach.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_vrach.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_vrach.OnIdleState = stateProperties16;
            this.txt_vrach.PasswordChar = '\0';
            this.txt_vrach.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_vrach.PlaceholderText = "";
            this.txt_vrach.ReadOnly = false;
            this.txt_vrach.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_vrach.SelectedText = "";
            this.txt_vrach.SelectionLength = 0;
            this.txt_vrach.SelectionStart = 0;
            this.txt_vrach.ShortcutsEnabled = true;
            this.txt_vrach.Size = new System.Drawing.Size(606, 30);
            this.txt_vrach.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txt_vrach.TabIndex = 22;
            this.txt_vrach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_vrach.TextMarginBottom = 0;
            this.txt_vrach.TextMarginLeft = 5;
            this.txt_vrach.TextMarginTop = 0;
            this.txt_vrach.TextPlaceholder = "";
            this.txt_vrach.UseSystemPasswordChar = false;
            this.txt_vrach.WordWrap = true;
            // 
            // lbl_room
            // 
            this.lbl_room.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_room.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room.Location = new System.Drawing.Point(12, 33);
            this.lbl_room.Name = "lbl_room";
            this.lbl_room.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbl_room.Size = new System.Drawing.Size(606, 25);
            this.lbl_room.TabIndex = 21;
            this.lbl_room.Text = "Номи пурраи табиб";
            this.lbl_room.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ListVrach
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 388);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListVrach";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Интихоби табиб";
            this.Shown += new System.EventHandler(this.ListVrach_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.list_load_vrach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.search_list_vrach.Properties)).EndInit();
            this.panel_btn_doctor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_vrach;
        private System.Windows.Forms.Label lbl_room;
        private System.Windows.Forms.Panel panel_btn_doctor;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_inser_vrach;
        private System.Windows.Forms.Label label_tab;
        private DevExpress.XtraEditors.ListBoxControl list_load_vrach;
        private DevExpress.XtraEditors.SearchControl search_list_vrach;
    }
}