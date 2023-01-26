namespace ObiGarm.Regisrarura.Lists
{
    partial class ListRoom
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
            this.panel_btn_doctor = new System.Windows.Forms.Panel();
            this.btn_clear_doctor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_inser_docrot = new System.Windows.Forms.Button();
            this.combo_frame = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.search_list_room = new DevExpress.XtraEditors.SearchControl();
            this.list_load_room = new DevExpress.XtraEditors.ListBoxControl();
            this.messDilalog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.label_info = new DevExpress.XtraEditors.LabelControl();
            this.panel_btn_doctor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search_list_room.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_load_room)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_btn_doctor
            // 
            this.panel_btn_doctor.BackColor = System.Drawing.Color.White;
            this.panel_btn_doctor.Controls.Add(this.btn_clear_doctor);
            this.panel_btn_doctor.Controls.Add(this.label7);
            this.panel_btn_doctor.Controls.Add(this.btn_inser_docrot);
            this.panel_btn_doctor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_btn_doctor.Location = new System.Drawing.Point(15, 289);
            this.panel_btn_doctor.Name = "panel_btn_doctor";
            this.panel_btn_doctor.Padding = new System.Windows.Forms.Padding(8);
            this.panel_btn_doctor.Size = new System.Drawing.Size(630, 40);
            this.panel_btn_doctor.TabIndex = 31;
            // 
            // btn_clear_doctor
            // 
            this.btn_clear_doctor.BackColor = System.Drawing.Color.Red;
            this.btn_clear_doctor.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_clear_doctor.FlatAppearance.BorderSize = 0;
            this.btn_clear_doctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear_doctor.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_doctor.ForeColor = System.Drawing.Color.White;
            this.btn_clear_doctor.Location = new System.Drawing.Point(356, 8);
            this.btn_clear_doctor.Name = "btn_clear_doctor";
            this.btn_clear_doctor.Size = new System.Drawing.Size(116, 24);
            this.btn_clear_doctor.TabIndex = 3;
            this.btn_clear_doctor.TabStop = false;
            this.btn_clear_doctor.Text = "Баромадан";
            this.btn_clear_doctor.UseVisualStyleBackColor = false;
            this.btn_clear_doctor.Click += new System.EventHandler(this.btn_clear_doctor_Click);
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Location = new System.Drawing.Point(472, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 24);
            this.label7.TabIndex = 2;
            // 
            // btn_inser_docrot
            // 
            this.btn_inser_docrot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(108)))), ((int)(((byte)(59)))));
            this.btn_inser_docrot.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_inser_docrot.FlatAppearance.BorderSize = 0;
            this.btn_inser_docrot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inser_docrot.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inser_docrot.ForeColor = System.Drawing.Color.White;
            this.btn_inser_docrot.Location = new System.Drawing.Point(485, 8);
            this.btn_inser_docrot.Name = "btn_inser_docrot";
            this.btn_inser_docrot.Size = new System.Drawing.Size(137, 24);
            this.btn_inser_docrot.TabIndex = 1;
            this.btn_inser_docrot.Text = "Интихоби ҳуҷра";
            this.btn_inser_docrot.UseVisualStyleBackColor = false;
            this.btn_inser_docrot.Click += new System.EventHandler(this.btn_inser_docrot_Click);
            // 
            // combo_frame
            // 
            this.combo_frame.BackColor = System.Drawing.Color.Transparent;
            this.combo_frame.BorderRadius = 5;
            this.combo_frame.Dock = System.Windows.Forms.DockStyle.Top;
            this.combo_frame.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_frame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_frame.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_frame.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.combo_frame.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_frame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.combo_frame.ItemHeight = 20;
            this.combo_frame.Location = new System.Drawing.Point(15, 35);
            this.combo_frame.Name = "combo_frame";
            this.combo_frame.Size = new System.Drawing.Size(630, 26);
            this.combo_frame.TabIndex = 35;
            this.combo_frame.SelectedIndexChanged += new System.EventHandler(this.combo_frame_SelectedIndexChanged);
            // 
            // lbl_name
            // 
            this.lbl_name.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(15, 15);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lbl_name.Size = new System.Drawing.Size(630, 20);
            this.lbl_name.TabIndex = 34;
            this.lbl_name.Text = "Номи бино:";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 61);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(630, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ҳуҷраҳо:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // search_list_room
            // 
            this.search_list_room.Dock = System.Windows.Forms.DockStyle.Top;
            this.search_list_room.Location = new System.Drawing.Point(15, 81);
            this.search_list_room.Name = "search_list_room";
            this.search_list_room.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.search_list_room.Size = new System.Drawing.Size(630, 20);
            this.search_list_room.TabIndex = 37;
            // 
            // list_load_room
            // 
            this.list_load_room.Dock = System.Windows.Forms.DockStyle.Top;
            this.list_load_room.Location = new System.Drawing.Point(15, 101);
            this.list_load_room.Name = "list_load_room";
            this.list_load_room.Size = new System.Drawing.Size(630, 120);
            this.list_load_room.TabIndex = 38;
            this.list_load_room.Click += new System.EventHandler(this.list_load_room_Click);
            // 
            // messDilalog
            // 
            this.messDilalog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.messDilalog.Caption = "Хатоги";
            this.messDilalog.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.messDilalog.Parent = this;
            this.messDilalog.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.messDilalog.Text = null;
            // 
            // label_info
            // 
            this.label_info.AllowHtmlString = true;
            this.label_info.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.label_info.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_info.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.label_info.LineVisible = true;
            this.label_info.Location = new System.Drawing.Point(15, 221);
            this.label_info.Name = "label_info";
            this.label_info.Padding = new System.Windows.Forms.Padding(5);
            this.label_info.Size = new System.Drawing.Size(630, 26);
            this.label_info.TabIndex = 39;
            this.label_info.Text = "labelControl1";
            // 
            // ListRoom
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 344);
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.list_load_room);
            this.Controls.Add(this.search_list_room);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_frame);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.panel_btn_doctor);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListRoom";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Интихоби ҳуҷра";
            this.Shown += new System.EventHandler(this.ListRoom_Shown);
            this.panel_btn_doctor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.search_list_room.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_load_room)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_btn_doctor;
        private System.Windows.Forms.Button btn_clear_doctor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_inser_docrot;
        private Guna.UI2.WinForms.Guna2ComboBox combo_frame;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SearchControl search_list_room;
        private DevExpress.XtraEditors.ListBoxControl list_load_room;
        private Guna.UI2.WinForms.Guna2MessageDialog messDilalog;
        private DevExpress.XtraEditors.LabelControl label_info;
    }
}