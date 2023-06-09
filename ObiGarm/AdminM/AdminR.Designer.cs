namespace ObiGarm.AdminM
{
    partial class AdminR
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
        /// 




        private void InitializeComponent()
        {
            this.panel_top = new System.Windows.Forms.Panel();
            this.logout_button = new System.Windows.Forms.Button();
            this.user_info_label = new System.Windows.Forms.Label();
            this.tab_menu = new Guna.UI2.WinForms.Guna2TabControl();
            this.tab_info_all = new System.Windows.Forms.TabPage();
            this.tab_hujrai_tashkhisi = new System.Windows.Forms.TabPage();
            this.tab_tainot_dukhtur = new System.Windows.Forms.TabPage();
            this.tab_antrometri = new System.Windows.Forms.TabPage();
            this.tartibi_ruz = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel_top.SuspendLayout();
            this.tab_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(143)))), ((int)(((byte)(78)))));
            this.panel_top.Controls.Add(this.logout_button);
            this.panel_top.Controls.Add(this.user_info_label);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_top.Size = new System.Drawing.Size(1230, 69);
            this.panel_top.TabIndex = 6;
            // 
            // logout_button
            // 
            this.logout_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logout_button.BackColor = System.Drawing.Color.Red;
            this.logout_button.FlatAppearance.BorderSize = 0;
            this.logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_button.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_button.ForeColor = System.Drawing.Color.White;
            this.logout_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.logout_button.Location = new System.Drawing.Point(1092, 12);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(125, 35);
            this.logout_button.TabIndex = 24;
            this.logout_button.Text = "Баромадан";
            this.logout_button.UseVisualStyleBackColor = false;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // user_info_label
            // 
            this.user_info_label.Dock = System.Windows.Forms.DockStyle.Left;
            this.user_info_label.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.user_info_label.ForeColor = System.Drawing.Color.White;
            this.user_info_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.user_info_label.Location = new System.Drawing.Point(10, 0);
            this.user_info_label.Name = "user_info_label";
            this.user_info_label.Size = new System.Drawing.Size(1040, 69);
            this.user_info_label.TabIndex = 6;
            this.user_info_label.Text = "Истифодабаранда: Сафараров Дилбоз\r\nНамуди Истифодабаранда: Админ";
            this.user_info_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tab_menu
            // 
            this.tab_menu.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tab_menu.Controls.Add(this.tab_info_all);
            this.tab_menu.Controls.Add(this.tab_hujrai_tashkhisi);
            this.tab_menu.Controls.Add(this.tab_tainot_dukhtur);
            this.tab_menu.Controls.Add(this.tab_antrometri);
            this.tab_menu.Controls.Add(this.tartibi_ruz);
            this.tab_menu.Controls.Add(this.tabPage1);
            this.tab_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_menu.ItemSize = new System.Drawing.Size(250, 40);
            this.tab_menu.Location = new System.Drawing.Point(0, 69);
            this.tab_menu.Margin = new System.Windows.Forms.Padding(4);
            this.tab_menu.Name = "tab_menu";
            this.tab_menu.SelectedIndex = 0;
            this.tab_menu.Size = new System.Drawing.Size(1230, 515);
            this.tab_menu.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tab_menu.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(123)))), ((int)(((byte)(84)))));
            this.tab_menu.TabButtonHoverState.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_menu.TabButtonHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tab_menu.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(141)))), ((int)(((byte)(95)))));
            this.tab_menu.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tab_menu.TabButtonIdleState.FillColor = System.Drawing.Color.White;
            this.tab_menu.TabButtonIdleState.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_menu.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tab_menu.TabButtonIdleState.InnerColor = System.Drawing.Color.White;
            this.tab_menu.TabButtonImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tab_menu.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tab_menu.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(232)))), ((int)(((byte)(225)))));
            this.tab_menu.TabButtonSelectedState.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_menu.TabButtonSelectedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(127)))), ((int)(((byte)(96)))));
            this.tab_menu.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(123)))), ((int)(((byte)(84)))));
            this.tab_menu.TabButtonSize = new System.Drawing.Size(250, 40);
            this.tab_menu.TabButtonTextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tab_menu.TabIndex = 41;
            this.tab_menu.TabMenuBackColor = System.Drawing.Color.White;
            // 
            // tab_info_all
            // 
            this.tab_info_all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.tab_info_all.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab_info_all.Location = new System.Drawing.Point(254, 4);
            this.tab_info_all.Margin = new System.Windows.Forms.Padding(4);
            this.tab_info_all.Name = "tab_info_all";
            this.tab_info_all.Padding = new System.Windows.Forms.Padding(12);
            this.tab_info_all.Size = new System.Drawing.Size(972, 507);
            this.tab_info_all.TabIndex = 0;
            this.tab_info_all.Text = "Статистика";
            // 
            // tab_hujrai_tashkhisi
            // 
            this.tab_hujrai_tashkhisi.Location = new System.Drawing.Point(254, 4);
            this.tab_hujrai_tashkhisi.Margin = new System.Windows.Forms.Padding(4);
            this.tab_hujrai_tashkhisi.Name = "tab_hujrai_tashkhisi";
            this.tab_hujrai_tashkhisi.Padding = new System.Windows.Forms.Padding(12);
            this.tab_hujrai_tashkhisi.Size = new System.Drawing.Size(972, 507);
            this.tab_hujrai_tashkhisi.TabIndex = 5;
            this.tab_hujrai_tashkhisi.Text = "Малумоҳо оиди маблағ";
            this.tab_hujrai_tashkhisi.UseVisualStyleBackColor = true;
            // 
            // tab_tainot_dukhtur
            // 
            this.tab_tainot_dukhtur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.tab_tainot_dukhtur.Location = new System.Drawing.Point(254, 4);
            this.tab_tainot_dukhtur.Margin = new System.Windows.Forms.Padding(4);
            this.tab_tainot_dukhtur.Name = "tab_tainot_dukhtur";
            this.tab_tainot_dukhtur.Padding = new System.Windows.Forms.Padding(12);
            this.tab_tainot_dukhtur.Size = new System.Drawing.Size(972, 507);
            this.tab_tainot_dukhtur.TabIndex = 1;
            this.tab_tainot_dukhtur.Text = "Ҳисоботи 1";
            // 
            // tab_antrometri
            // 
            this.tab_antrometri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.tab_antrometri.ForeColor = System.Drawing.Color.Black;
            this.tab_antrometri.Location = new System.Drawing.Point(254, 4);
            this.tab_antrometri.Margin = new System.Windows.Forms.Padding(4);
            this.tab_antrometri.Name = "tab_antrometri";
            this.tab_antrometri.Padding = new System.Windows.Forms.Padding(12);
            this.tab_antrometri.Size = new System.Drawing.Size(972, 507);
            this.tab_antrometri.TabIndex = 2;
            this.tab_antrometri.Text = "Ҳисоботи 2";
            // 
            // tartibi_ruz
            // 
            this.tartibi_ruz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.tartibi_ruz.Location = new System.Drawing.Point(254, 4);
            this.tartibi_ruz.Margin = new System.Windows.Forms.Padding(4);
            this.tartibi_ruz.Name = "tartibi_ruz";
            this.tartibi_ruz.Padding = new System.Windows.Forms.Padding(12);
            this.tartibi_ruz.Size = new System.Drawing.Size(972, 507);
            this.tartibi_ruz.TabIndex = 4;
            this.tartibi_ruz.Text = "Ҳисоботи 3";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(254, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(972, 507);
            this.tabPage1.TabIndex = 6;
            this.tabPage1.Text = "Ҳисоботи 4";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AdminR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 584);
            this.Controls.Add(this.tab_menu);
            this.Controls.Add(this.panel_top);
            this.Name = "AdminR";
            this.ShowIcon = false;
            this.Text = "MainAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminR_FormClosing);
            this.Load += new System.EventHandler(this.AdminR_Load);
            this.panel_top.ResumeLayout(false);
            this.tab_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Label user_info_label;
        private Guna.UI2.WinForms.Guna2TabControl tab_menu;
        private System.Windows.Forms.TabPage tab_info_all;
        private System.Windows.Forms.TabPage tab_hujrai_tashkhisi;
        private System.Windows.Forms.TabPage tab_tainot_dukhtur;
        private System.Windows.Forms.TabPage tab_antrometri;
        private System.Windows.Forms.TabPage tartibi_ruz;
        private System.Windows.Forms.TabPage tabPage1;
    }
}