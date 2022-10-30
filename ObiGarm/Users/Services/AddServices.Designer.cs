namespace ObiGarm.Services
{
    partial class AddServices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddServices));
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
            this.group_services = new DevExpress.XtraEditors.GroupControl();
            this.txt_time_services = new DevExpress.XtraEditors.TimeEdit();
            this.label_time_servces = new System.Windows.Forms.Label();
            this.txt_name = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel_full.SuspendLayout();
            this.panel_botton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.group_services)).BeginInit();
            this.group_services.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_time_services.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_full
            // 
            this.panel_full.BackColor = System.Drawing.Color.White;
            this.panel_full.Controls.Add(this.panel_botton);
            this.panel_full.Controls.Add(this.group_services);
            this.panel_full.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_full.Location = new System.Drawing.Point(20, 20);
            this.panel_full.Name = "panel_full";
            this.panel_full.Padding = new System.Windows.Forms.Padding(10);
            this.panel_full.Size = new System.Drawing.Size(733, 248);
            this.panel_full.TabIndex = 0;
            // 
            // panel_botton
            // 
            this.panel_botton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_botton.Controls.Add(this.btn_hide);
            this.panel_botton.Controls.Add(this.lbl_tab);
            this.panel_botton.Controls.Add(this.btn_creat);
            this.panel_botton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_botton.Location = new System.Drawing.Point(10, 194);
            this.panel_botton.Name = "panel_botton";
            this.panel_botton.Padding = new System.Windows.Forms.Padding(8);
            this.panel_botton.Size = new System.Drawing.Size(713, 44);
            this.panel_botton.TabIndex = 23;
            // 
            // btn_hide
            // 
            this.btn_hide.BackColor = System.Drawing.Color.Red;
            this.btn_hide.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_hide.FlatAppearance.BorderSize = 0;
            this.btn_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hide.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hide.ForeColor = System.Drawing.Color.White;
            this.btn_hide.Location = new System.Drawing.Point(446, 8);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(120, 28);
            this.btn_hide.TabIndex = 3;
            this.btn_hide.Text = "Баромадан";
            this.btn_hide.UseVisualStyleBackColor = false;
            // 
            // lbl_tab
            // 
            this.lbl_tab.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_tab.Location = new System.Drawing.Point(566, 8);
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
            this.btn_creat.Location = new System.Drawing.Point(585, 8);
            this.btn_creat.Name = "btn_creat";
            this.btn_creat.Size = new System.Drawing.Size(120, 28);
            this.btn_creat.TabIndex = 1;
            this.btn_creat.Text = "Сохтан";
            this.btn_creat.UseVisualStyleBackColor = false;
            this.btn_creat.Click += new System.EventHandler(this.btn_creat_Click);
            // 
            // group_services
            // 
            this.group_services.Controls.Add(this.txt_time_services);
            this.group_services.Controls.Add(this.label_time_servces);
            this.group_services.Controls.Add(this.txt_name);
            this.group_services.Controls.Add(this.lbl_name);
            this.group_services.Dock = System.Windows.Forms.DockStyle.Top;
            this.group_services.Location = new System.Drawing.Point(10, 10);
            this.group_services.Name = "group_services";
            this.group_services.Padding = new System.Windows.Forms.Padding(10);
            this.group_services.Size = new System.Drawing.Size(713, 162);
            this.group_services.TabIndex = 0;
            this.group_services.Text = "Сохтани хизматрасони";
            // 
            // txt_time_services
            // 
            this.txt_time_services.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_time_services.EditValue = new System.DateTime(2022, 10, 28, 12, 0, 0, 0);
            this.txt_time_services.Location = new System.Drawing.Point(12, 118);
            this.txt_time_services.Name = "txt_time_services";
            this.txt_time_services.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_time_services.Properties.Appearance.Options.UseFont = true;
            this.txt_time_services.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_time_services.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.txt_time_services.Properties.TouchUIMaxValue = new System.DateTime(9999, 12, 31, 11, 59, 0, 0);
            this.txt_time_services.Size = new System.Drawing.Size(689, 26);
            this.txt_time_services.TabIndex = 27;
            // 
            // label_time_servces
            // 
            this.label_time_servces.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_time_servces.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time_servces.Location = new System.Drawing.Point(12, 93);
            this.label_time_servces.Name = "label_time_servces";
            this.label_time_servces.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label_time_servces.Size = new System.Drawing.Size(689, 25);
            this.label_time_servces.TabIndex = 26;
            this.label_time_servces.Text = "Вакти хизматрасони барои як мизоч:";
            this.label_time_servces.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_name
            // 
            this.txt_name.AcceptsReturn = false;
            this.txt_name.AcceptsTab = false;
            this.txt_name.AnimationSpeed = 200;
            this.txt_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_name.BackColor = System.Drawing.Color.Transparent;
            this.txt_name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_name.BackgroundImage")));
            this.txt_name.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txt_name.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txt_name.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txt_name.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_name.BorderRadius = 15;
            this.txt_name.BorderThickness = 1;
            this.txt_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.txt_name.DefaultText = "";
            this.txt_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_name.FillColor = System.Drawing.Color.White;
            this.txt_name.HideSelection = true;
            this.txt_name.IconLeft = null;
            this.txt_name.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.IconPadding = 10;
            this.txt_name.IconRight = null;
            this.txt_name.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_name.Lines = new string[0];
            this.txt_name.Location = new System.Drawing.Point(12, 58);
            this.txt_name.MaxLength = 32767;
            this.txt_name.MinimumSize = new System.Drawing.Size(100, 35);
            this.txt_name.Modified = false;
            this.txt_name.Multiline = false;
            this.txt_name.Name = "txt_name";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_name.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Empty;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_name.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_name.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_name.OnIdleState = stateProperties8;
            this.txt_name.PasswordChar = '\0';
            this.txt_name.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_name.PlaceholderText = "Ном хизматрасони";
            this.txt_name.ReadOnly = false;
            this.txt_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_name.SelectedText = "";
            this.txt_name.SelectionLength = 0;
            this.txt_name.SelectionStart = 0;
            this.txt_name.ShortcutsEnabled = true;
            this.txt_name.Size = new System.Drawing.Size(689, 35);
            this.txt_name.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txt_name.TabIndex = 25;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_name.TextMarginBottom = 0;
            this.txt_name.TextMarginLeft = 5;
            this.txt_name.TextMarginTop = 0;
            this.txt_name.TextPlaceholder = "Ном хизматрасони";
            this.txt_name.UseSystemPasswordChar = false;
            this.txt_name.WordWrap = true;
            // 
            // lbl_name
            // 
            this.lbl_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(12, 33);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbl_name.Size = new System.Drawing.Size(689, 25);
            this.lbl_name.TabIndex = 24;
            this.lbl_name.Text = "Ном:";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddServices
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 288);
            this.Controls.Add(this.panel_full);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddServices";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сохтани хизматрасони";
            this.Shown += new System.EventHandler(this.AddServices_Shown);
            this.panel_full.ResumeLayout(false);
            this.panel_botton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.group_services)).EndInit();
            this.group_services.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_time_services.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private System.Windows.Forms.Panel panel_full;
        private DevExpress.XtraEditors.GroupControl group_services;
        private System.Windows.Forms.Label label_time_servces;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Panel panel_botton;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.Label lbl_tab;
        private System.Windows.Forms.Button btn_creat;
        private DevExpress.XtraEditors.TimeEdit txt_time_services;
    }
}