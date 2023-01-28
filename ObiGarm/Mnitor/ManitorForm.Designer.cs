namespace ObiGarm.Mnitor
{
    partial class ManitorForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.manitor_DataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel__top = new System.Windows.Forms.Panel();
            this.label_info_top = new System.Windows.Forms.Label();
            this.timer_select = new System.Windows.Forms.Timer(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_services = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_clients = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time_services_clirnts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.room_spitsalist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer_select_time_now = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manitor_DataGridView)).BeginInit();
            this.panel__top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel__top);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1382, 653);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.manitor_DataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 53);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panel2.Size = new System.Drawing.Size(1372, 595);
            this.panel2.TabIndex = 4;
            // 
            // manitor_DataGridView
            // 
            this.manitor_DataGridView.AllowUserToAddRows = false;
            this.manitor_DataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.manitor_DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(108)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(108)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.manitor_DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.manitor_DataGridView.ColumnHeadersHeight = 50;
            this.manitor_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.manitor_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.id_services,
            this.name_clients,
            this.time_services_clirnts,
            this.room_spitsalist});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(70)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.manitor_DataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.manitor_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manitor_DataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.manitor_DataGridView.Location = new System.Drawing.Point(0, 10);
            this.manitor_DataGridView.Name = "manitor_DataGridView";
            this.manitor_DataGridView.ReadOnly = true;
            this.manitor_DataGridView.RowHeadersVisible = false;
            this.manitor_DataGridView.RowTemplate.Height = 40;
            this.manitor_DataGridView.Size = new System.Drawing.Size(1372, 585);
            this.manitor_DataGridView.TabIndex = 8;
            this.manitor_DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.manitor_DataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.manitor_DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.manitor_DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(108)))), ((int)(((byte)(59)))));
            this.manitor_DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.manitor_DataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.manitor_DataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.manitor_DataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.manitor_DataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.manitor_DataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manitor_DataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.manitor_DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.manitor_DataGridView.ThemeStyle.HeaderStyle.Height = 50;
            this.manitor_DataGridView.ThemeStyle.ReadOnly = true;
            this.manitor_DataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.manitor_DataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.manitor_DataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manitor_DataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.manitor_DataGridView.ThemeStyle.RowsStyle.Height = 40;
            this.manitor_DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(108)))), ((int)(((byte)(59)))));
            this.manitor_DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.manitor_DataGridView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.manitor_DataGridView_RowPrePaint);
            // 
            // panel__top
            // 
            this.panel__top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(108)))), ((int)(((byte)(59)))));
            this.panel__top.Controls.Add(this.label_info_top);
            this.panel__top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel__top.Location = new System.Drawing.Point(5, 5);
            this.panel__top.Name = "panel__top";
            this.panel__top.Padding = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.panel__top.Size = new System.Drawing.Size(1372, 48);
            this.panel__top.TabIndex = 3;
            // 
            // label_info_top
            // 
            this.label_info_top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_info_top.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info_top.ForeColor = System.Drawing.Color.White;
            this.label_info_top.Location = new System.Drawing.Point(9, 8);
            this.label_info_top.Name = "label_info_top";
            this.label_info_top.Size = new System.Drawing.Size(1354, 32);
            this.label_info_top.TabIndex = 0;
            this.label_info_top.Text = "ХУШ ОМАДЕД! ИМРУЗ 12:12:2022 соат 12:00:00";
            this.label_info_top.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_select
            // 
            this.timer_select.Enabled = true;
            this.timer_select.Interval = 2000;
            this.timer_select.Tick += new System.EventHandler(this.timer_select_Tick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // id_services
            // 
            this.id_services.DataPropertyName = "id_services";
            this.id_services.HeaderText = "";
            this.id_services.Name = "id_services";
            this.id_services.ReadOnly = true;
            this.id_services.Visible = false;
            // 
            // name_clients
            // 
            this.name_clients.DataPropertyName = "name_clients";
            this.name_clients.HeaderText = "ИСТИРОҲАТКУНАНДАГОН";
            this.name_clients.MinimumWidth = 480;
            this.name_clients.Name = "name_clients";
            this.name_clients.ReadOnly = true;
            // 
            // time_services_clirnts
            // 
            this.time_services_clirnts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.time_services_clirnts.DataPropertyName = "time_services_clirnts";
            this.time_services_clirnts.FillWeight = 21.40067F;
            this.time_services_clirnts.HeaderText = "ВАҚТ";
            this.time_services_clirnts.MinimumWidth = 240;
            this.time_services_clirnts.Name = "time_services_clirnts";
            this.time_services_clirnts.ReadOnly = true;
            this.time_services_clirnts.Width = 250;
            // 
            // room_spitsalist
            // 
            this.room_spitsalist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.room_spitsalist.DataPropertyName = "room_spitsalist";
            this.room_spitsalist.FillWeight = 21.40067F;
            this.room_spitsalist.HeaderText = "ҲУҶРА";
            this.room_spitsalist.MinimumWidth = 215;
            this.room_spitsalist.Name = "room_spitsalist";
            this.room_spitsalist.ReadOnly = true;
            this.room_spitsalist.Width = 220;
            // 
            // timer_select_time_now
            // 
            this.timer_select_time_now.Enabled = true;
            this.timer_select_time_now.Interval = 500;
            this.timer_select_time_now.Tick += new System.EventHandler(this.timer_select_time_now_Tick);
            // 
            // ManitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 653);
            this.Controls.Add(this.panel1);
            this.IconOptions.ShowIcon = false;
            this.MinimizeBox = false;
            this.Name = "ManitorForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManitorForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ManitorForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.manitor_DataGridView)).EndInit();
            this.panel__top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView manitor_DataGridView;
        private System.Windows.Forms.Panel panel__top;
        private System.Windows.Forms.Label label_info_top;
        private System.Windows.Forms.Timer timer_select;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_services;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_clients;
        private System.Windows.Forms.DataGridViewTextBoxColumn time_services_clirnts;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_spitsalist;
        private System.Windows.Forms.Timer timer_select_time_now;
    }
}