﻿namespace ObiGarm.Users.Bonk
{
    partial class AddBonk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBonk));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.panel_full = new System.Windows.Forms.Panel();
            this.panel_botton = new System.Windows.Forms.Panel();
            this.btn_hide = new System.Windows.Forms.Button();
            this.lbl_tab = new System.Windows.Forms.Label();
            this.btn_creat = new System.Windows.Forms.Button();
            this.group_name_frame = new DevExpress.XtraEditors.GroupControl();
            this.txt_name = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel_full.SuspendLayout();
            this.panel_botton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.group_name_frame)).BeginInit();
            this.group_name_frame.SuspendLayout();
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
            this.panel_full.Size = new System.Drawing.Size(658, 165);
            this.panel_full.TabIndex = 2;
            // 
            // panel_botton
            // 
            this.panel_botton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel_botton.Controls.Add(this.btn_hide);
            this.panel_botton.Controls.Add(this.lbl_tab);
            this.panel_botton.Controls.Add(this.btn_creat);
            this.panel_botton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_botton.Location = new System.Drawing.Point(10, 117);
            this.panel_botton.Name = "panel_botton";
            this.panel_botton.Padding = new System.Windows.Forms.Padding(8);
            this.panel_botton.Size = new System.Drawing.Size(638, 38);
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
            this.btn_hide.Location = new System.Drawing.Point(371, 8);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(120, 22);
            this.btn_hide.TabIndex = 3;
            this.btn_hide.Text = "Баромадан";
            this.btn_hide.UseVisualStyleBackColor = false;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // lbl_tab
            // 
            this.lbl_tab.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_tab.Location = new System.Drawing.Point(491, 8);
            this.lbl_tab.Name = "lbl_tab";
            this.lbl_tab.Size = new System.Drawing.Size(19, 22);
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
            this.btn_creat.Location = new System.Drawing.Point(510, 8);
            this.btn_creat.Name = "btn_creat";
            this.btn_creat.Size = new System.Drawing.Size(120, 22);
            this.btn_creat.TabIndex = 1;
            this.btn_creat.Text = "Сохтан";
            this.btn_creat.UseVisualStyleBackColor = false;
            this.btn_creat.Click += new System.EventHandler(this.btn_creat_Click);
            // 
            // group_name_frame
            // 
            this.group_name_frame.Controls.Add(this.txt_name);
            this.group_name_frame.Controls.Add(this.lbl_name);
            this.group_name_frame.Dock = System.Windows.Forms.DockStyle.Top;
            this.group_name_frame.Location = new System.Drawing.Point(10, 10);
            this.group_name_frame.Name = "group_name_frame";
            this.group_name_frame.Padding = new System.Windows.Forms.Padding(5);
            this.group_name_frame.Size = new System.Drawing.Size(638, 97);
            this.group_name_frame.TabIndex = 1;
            this.group_name_frame.Text = "Сохтан";
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
            this.txt_name.Location = new System.Drawing.Point(7, 53);
            this.txt_name.MaxLength = 32767;
            this.txt_name.MinimumSize = new System.Drawing.Size(100, 35);
            this.txt_name.Modified = false;
            this.txt_name.Multiline = false;
            this.txt_name.Name = "txt_name";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_name.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Empty;
            stateProperties2.FillColor = System.Drawing.Color.White;
            stateProperties2.ForeColor = System.Drawing.Color.Empty;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_name.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_name.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_name.OnIdleState = stateProperties4;
            this.txt_name.PasswordChar = '\0';
            this.txt_name.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txt_name.PlaceholderText = "Ном";
            this.txt_name.ReadOnly = false;
            this.txt_name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_name.SelectedText = "";
            this.txt_name.SelectionLength = 0;
            this.txt_name.SelectionStart = 0;
            this.txt_name.ShortcutsEnabled = true;
            this.txt_name.Size = new System.Drawing.Size(624, 35);
            this.txt_name.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txt_name.TabIndex = 3;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_name.TextMarginBottom = 0;
            this.txt_name.TextMarginLeft = 5;
            this.txt_name.TextMarginTop = 0;
            this.txt_name.TextPlaceholder = "Ном";
            this.txt_name.UseSystemPasswordChar = false;
            this.txt_name.WordWrap = true;
            // 
            // lbl_name
            // 
            this.lbl_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(7, 28);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbl_name.Size = new System.Drawing.Size(624, 25);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Номи банк:";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddBonk
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 205);
            this.Controls.Add(this.panel_full);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBonk";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сохтан";
            this.Shown += new System.EventHandler(this.AddBonk_Shown);
            this.panel_full.ResumeLayout(false);
            this.panel_botton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.group_name_frame)).EndInit();
            this.group_name_frame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private System.Windows.Forms.Panel panel_full;
        private System.Windows.Forms.Panel panel_botton;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.Label lbl_tab;
        private System.Windows.Forms.Button btn_creat;
        private DevExpress.XtraEditors.GroupControl group_name_frame;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
    }
}