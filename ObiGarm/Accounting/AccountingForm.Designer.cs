namespace ObiGarm.Accounting
{
    partial class AccountingForm
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
            this.btn_get_money = new System.Windows.Forms.Button();
            this.panel_menu = new System.Windows.Forms.Panel();
            this.panel_consumption = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_consuption_money_in_bank = new System.Windows.Forms.Button();
            this.btn_consuption_money_in_kassa = new System.Windows.Forms.Button();
            this.btn_consuption_money = new System.Windows.Forms.Button();
            this.panel_get_money = new System.Windows.Forms.Panel();
            this.panel_user_menu = new System.Windows.Forms.Panel();
            this.btn_get_money_in_bank = new System.Windows.Forms.Button();
            this.btn_get_money_in_kassa = new System.Windows.Forms.Button();
            this.panel_left = new System.Windows.Forms.Panel();
            this.panel_top = new System.Windows.Forms.Panel();
            this.logout_button = new System.Windows.Forms.Button();
            this.user_info_label = new System.Windows.Forms.Label();
            this.panel_child_all = new System.Windows.Forms.Panel();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.picture_logo = new System.Windows.Forms.PictureBox();
            this.panel_menu.SuspendLayout();
            this.panel_consumption.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_get_money.SuspendLayout();
            this.panel_user_menu.SuspendLayout();
            this.panel_left.SuspendLayout();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_get_money
            // 
            this.btn_get_money.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_get_money.FlatAppearance.BorderSize = 0;
            this.btn_get_money.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_get_money.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_get_money.ForeColor = System.Drawing.Color.White;
            this.btn_get_money.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_get_money.Location = new System.Drawing.Point(0, 0);
            this.btn_get_money.Name = "btn_get_money";
            this.btn_get_money.Size = new System.Drawing.Size(212, 40);
            this.btn_get_money.TabIndex = 26;
            this.btn_get_money.Text = "Воридоти";
            this.btn_get_money.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_get_money.UseVisualStyleBackColor = true;
            this.btn_get_money.Click += new System.EventHandler(this.btn_get_money_Click);
            // 
            // panel_menu
            // 
            this.panel_menu.AutoScroll = true;
            this.panel_menu.Controls.Add(this.panel_consumption);
            this.panel_menu.Controls.Add(this.btn_consuption_money);
            this.panel_menu.Controls.Add(this.panel_get_money);
            this.panel_menu.Controls.Add(this.btn_get_money);
            this.panel_menu.Location = new System.Drawing.Point(12, 75);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(212, 405);
            this.panel_menu.TabIndex = 3;
            // 
            // panel_consumption
            // 
            this.panel_consumption.Controls.Add(this.panel2);
            this.panel_consumption.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_consumption.Location = new System.Drawing.Point(0, 171);
            this.panel_consumption.Name = "panel_consumption";
            this.panel_consumption.Size = new System.Drawing.Size(212, 91);
            this.panel_consumption.TabIndex = 30;
            this.panel_consumption.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_consuption_money_in_bank);
            this.panel2.Controls.Add(this.btn_consuption_money_in_kassa);
            this.panel2.Location = new System.Drawing.Point(22, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 78);
            this.panel2.TabIndex = 5;
            // 
            // btn_consuption_money_in_bank
            // 
            this.btn_consuption_money_in_bank.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_consuption_money_in_bank.FlatAppearance.BorderSize = 0;
            this.btn_consuption_money_in_bank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consuption_money_in_bank.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_consuption_money_in_bank.ForeColor = System.Drawing.Color.White;
            this.btn_consuption_money_in_bank.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_consuption_money_in_bank.Location = new System.Drawing.Point(0, 40);
            this.btn_consuption_money_in_bank.Name = "btn_consuption_money_in_bank";
            this.btn_consuption_money_in_bank.Size = new System.Drawing.Size(196, 40);
            this.btn_consuption_money_in_bank.TabIndex = 30;
            this.btn_consuption_money_in_bank.Text = "Маблағҳои гайринақдии бонкӣ";
            this.btn_consuption_money_in_bank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_consuption_money_in_bank.UseVisualStyleBackColor = true;
            this.btn_consuption_money_in_bank.Click += new System.EventHandler(this.btn_consuption_money_in_bank_Click);
            // 
            // btn_consuption_money_in_kassa
            // 
            this.btn_consuption_money_in_kassa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_consuption_money_in_kassa.FlatAppearance.BorderSize = 0;
            this.btn_consuption_money_in_kassa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consuption_money_in_kassa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_consuption_money_in_kassa.ForeColor = System.Drawing.Color.White;
            this.btn_consuption_money_in_kassa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_consuption_money_in_kassa.Location = new System.Drawing.Point(0, 0);
            this.btn_consuption_money_in_kassa.Name = "btn_consuption_money_in_kassa";
            this.btn_consuption_money_in_kassa.Size = new System.Drawing.Size(196, 40);
            this.btn_consuption_money_in_kassa.TabIndex = 29;
            this.btn_consuption_money_in_kassa.Text = "Маблағҳои нақдии хазина";
            this.btn_consuption_money_in_kassa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_consuption_money_in_kassa.UseVisualStyleBackColor = true;
            this.btn_consuption_money_in_kassa.Click += new System.EventHandler(this.btn_consuption_money_in_kassa_Click);
            // 
            // btn_consuption_money
            // 
            this.btn_consuption_money.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_consuption_money.FlatAppearance.BorderSize = 0;
            this.btn_consuption_money.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consuption_money.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_consuption_money.ForeColor = System.Drawing.Color.White;
            this.btn_consuption_money.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_consuption_money.Location = new System.Drawing.Point(0, 131);
            this.btn_consuption_money.Name = "btn_consuption_money";
            this.btn_consuption_money.Size = new System.Drawing.Size(212, 40);
            this.btn_consuption_money.TabIndex = 29;
            this.btn_consuption_money.Text = "Содироти";
            this.btn_consuption_money.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_consuption_money.UseVisualStyleBackColor = true;
            this.btn_consuption_money.Click += new System.EventHandler(this.btn_consuption_money_Click);
            // 
            // panel_get_money
            // 
            this.panel_get_money.Controls.Add(this.panel_user_menu);
            this.panel_get_money.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel_get_money.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_get_money.Location = new System.Drawing.Point(0, 40);
            this.panel_get_money.Name = "panel_get_money";
            this.panel_get_money.Size = new System.Drawing.Size(212, 91);
            this.panel_get_money.TabIndex = 28;
            this.panel_get_money.Visible = false;
            // 
            // panel_user_menu
            // 
            this.panel_user_menu.Controls.Add(this.btn_get_money_in_bank);
            this.panel_user_menu.Controls.Add(this.btn_get_money_in_kassa);
            this.panel_user_menu.Location = new System.Drawing.Point(22, 8);
            this.panel_user_menu.Name = "panel_user_menu";
            this.panel_user_menu.Size = new System.Drawing.Size(199, 78);
            this.panel_user_menu.TabIndex = 5;
            // 
            // btn_get_money_in_bank
            // 
            this.btn_get_money_in_bank.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_get_money_in_bank.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_get_money_in_bank.FlatAppearance.BorderSize = 0;
            this.btn_get_money_in_bank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_get_money_in_bank.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_get_money_in_bank.ForeColor = System.Drawing.Color.White;
            this.btn_get_money_in_bank.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_get_money_in_bank.Location = new System.Drawing.Point(0, 40);
            this.btn_get_money_in_bank.Name = "btn_get_money_in_bank";
            this.btn_get_money_in_bank.Size = new System.Drawing.Size(199, 40);
            this.btn_get_money_in_bank.TabIndex = 30;
            this.btn_get_money_in_bank.Text = "Маблағҳои гайринақдии бонкӣ";
            this.btn_get_money_in_bank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_get_money_in_bank.UseVisualStyleBackColor = true;
            this.btn_get_money_in_bank.Click += new System.EventHandler(this.btn_get_money_in_bank_Click);
            // 
            // btn_get_money_in_kassa
            // 
            this.btn_get_money_in_kassa.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_get_money_in_kassa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_get_money_in_kassa.FlatAppearance.BorderSize = 0;
            this.btn_get_money_in_kassa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_get_money_in_kassa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_get_money_in_kassa.ForeColor = System.Drawing.Color.White;
            this.btn_get_money_in_kassa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_get_money_in_kassa.Location = new System.Drawing.Point(0, 0);
            this.btn_get_money_in_kassa.Name = "btn_get_money_in_kassa";
            this.btn_get_money_in_kassa.Size = new System.Drawing.Size(199, 40);
            this.btn_get_money_in_kassa.TabIndex = 29;
            this.btn_get_money_in_kassa.Text = "Маблағҳои нақдии хазина";
            this.btn_get_money_in_kassa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_get_money_in_kassa.UseVisualStyleBackColor = true;
            this.btn_get_money_in_kassa.Click += new System.EventHandler(this.btn_get_money_in_kassa_Click);
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.panel_left.Controls.Add(this.picture_logo);
            this.panel_left.Controls.Add(this.panel_menu);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(230, 492);
            this.panel_left.TabIndex = 4;
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(143)))), ((int)(((byte)(78)))));
            this.panel_top.Controls.Add(this.logout_button);
            this.panel_top.Controls.Add(this.user_info_label);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(230, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel_top.Size = new System.Drawing.Size(868, 55);
            this.panel_top.TabIndex = 5;
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
            this.logout_button.Location = new System.Drawing.Point(730, 12);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(125, 35);
            this.logout_button.TabIndex = 24;
            this.logout_button.Text = "Баромадан";
            this.logout_button.UseVisualStyleBackColor = false;
            // 
            // user_info_label
            // 
            this.user_info_label.Dock = System.Windows.Forms.DockStyle.Left;
            this.user_info_label.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.user_info_label.ForeColor = System.Drawing.Color.White;
            this.user_info_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.user_info_label.Location = new System.Drawing.Point(10, 0);
            this.user_info_label.Name = "user_info_label";
            this.user_info_label.Size = new System.Drawing.Size(557, 55);
            this.user_info_label.TabIndex = 6;
            this.user_info_label.Text = "Истифодабаранда: Сафараров Дилбоз\r\nНамуди Истифодабаранда: Админ";
            this.user_info_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_child_all
            // 
            this.panel_child_all.AllowDrop = true;
            this.panel_child_all.AutoScroll = true;
            this.panel_child_all.BackColor = System.Drawing.SystemColors.Control;
            this.panel_child_all.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_child_all.Location = new System.Drawing.Point(230, 55);
            this.panel_child_all.Name = "panel_child_all";
            this.panel_child_all.Size = new System.Drawing.Size(868, 437);
            this.panel_child_all.TabIndex = 6;
            // 
            // picture_logo
            // 
            this.picture_logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.picture_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picture_logo.Image = global::ObiGarm.Properties.Resources.logo;
            this.picture_logo.Location = new System.Drawing.Point(0, 0);
            this.picture_logo.Name = "picture_logo";
            this.picture_logo.Size = new System.Drawing.Size(230, 69);
            this.picture_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_logo.TabIndex = 0;
            this.picture_logo.TabStop = false;
            // 
            // AccountingForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 492);
            this.Controls.Add(this.panel_child_all);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_left);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AccountingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AccountingForm_FormClosed);
            this.Shown += new System.EventHandler(this.AccountingForm_Shown);
            this.panel_menu.ResumeLayout(false);
            this.panel_consumption.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel_get_money.ResumeLayout(false);
            this.panel_user_menu.ResumeLayout(false);
            this.panel_left.ResumeLayout(false);
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_get_money;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel_child_all;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Label user_info_label;
        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private System.Windows.Forms.Panel panel_consumption;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_consuption_money_in_bank;
        private System.Windows.Forms.Button btn_consuption_money_in_kassa;
        private System.Windows.Forms.Button btn_consuption_money;
        private System.Windows.Forms.Panel panel_get_money;
        private System.Windows.Forms.Panel panel_user_menu;
        private System.Windows.Forms.Button btn_get_money_in_bank;
        private System.Windows.Forms.Button btn_get_money_in_kassa;
        private System.Windows.Forms.PictureBox picture_logo;
    }
}