namespace StudentAttendanceManagementSystem
{
    partial class MainScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_pack = new System.Windows.Forms.Button();
            this.btn_helps = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_reports = new System.Windows.Forms.Button();
            this.btn_classes = new System.Windows.Forms.Button();
            this.btn_users = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btn_help);
            this.panel1.Controls.Add(this.btn_pack);
            this.panel1.Controls.Add(this.btn_helps);
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Controls.Add(this.btn_reports);
            this.panel1.Controls.Add(this.btn_classes);
            this.panel1.Controls.Add(this.btn_users);
            this.panel1.Controls.Add(this.btn_dashboard);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 732);
            this.panel1.TabIndex = 0;
            // 
            // btn_help
            // 
            this.btn_help.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.btn_help.Location = new System.Drawing.Point(12, 315);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(189, 40);
            this.btn_help.TabIndex = 8;
            this.btn_help.Text = "HELP";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // btn_pack
            // 
            this.btn_pack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_pack.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.btn_pack.ForeColor = System.Drawing.Color.Crimson;
            this.btn_pack.Location = new System.Drawing.Point(0, 689);
            this.btn_pack.Name = "btn_pack";
            this.btn_pack.Size = new System.Drawing.Size(215, 40);
            this.btn_pack.TabIndex = 7;
            this.btn_pack.Text = "LOGOUT";
            this.btn_pack.UseVisualStyleBackColor = false;
            this.btn_pack.Click += new System.EventHandler(this.btn_pack_Click);
            // 
            // btn_helps
            // 
            this.btn_helps.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.btn_helps.Location = new System.Drawing.Point(12, 265);
            this.btn_helps.Name = "btn_helps";
            this.btn_helps.Size = new System.Drawing.Size(189, 40);
            this.btn_helps.TabIndex = 6;
            this.btn_helps.Text = "STUDENTS";
            this.btn_helps.UseVisualStyleBackColor = true;
            // 
            // btn_print
            // 
            this.btn_print.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_print.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.btn_print.Location = new System.Drawing.Point(12, 453);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(189, 40);
            this.btn_print.TabIndex = 5;
            this.btn_print.Text = "PRINT";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_reports
            // 
            this.btn_reports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reports.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.btn_reports.Location = new System.Drawing.Point(12, 407);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(189, 40);
            this.btn_reports.TabIndex = 4;
            this.btn_reports.Text = "REPORTS";
            this.btn_reports.UseVisualStyleBackColor = true;
            this.btn_reports.Click += new System.EventHandler(this.btn_reports_Click);
            // 
            // btn_classes
            // 
            this.btn_classes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_classes.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.btn_classes.Location = new System.Drawing.Point(12, 361);
            this.btn_classes.Name = "btn_classes";
            this.btn_classes.Size = new System.Drawing.Size(189, 40);
            this.btn_classes.TabIndex = 3;
            this.btn_classes.Text = "CLASSES";
            this.btn_classes.UseVisualStyleBackColor = true;
            this.btn_classes.Click += new System.EventHandler(this.btn_classes_Click);
            // 
            // btn_users
            // 
            this.btn_users.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.btn_users.Location = new System.Drawing.Point(12, 219);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(189, 40);
            this.btn_users.TabIndex = 2;
            this.btn_users.Text = "USERS";
            this.btn_users.UseVisualStyleBackColor = true;
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.btn_dashboard.Location = new System.Drawing.Point(12, 173);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(189, 40);
            this.btn_dashboard.TabIndex = 1;
            this.btn_dashboard.Text = "DASHBOARD";
            this.btn_dashboard.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::StudentAttendanceManagementSystem.Properties.Resources.icon1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(215, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 732);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PowderBlue;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(218, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(933, 82);
            this.panel3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(18, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(442, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "STUDENT ATTENDANCE MANAGEMENT SYSTEM";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "BSCPE",
            "BSCE",
            "BSEE",
            "BSABE"});
            this.comboBox1.Location = new System.Drawing.Point(240, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 732);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DASHBOARD";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_pack;
        private System.Windows.Forms.Button btn_helps;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_reports;
        private System.Windows.Forms.Button btn_classes;
        private System.Windows.Forms.Button btn_users;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_help;
    }
}