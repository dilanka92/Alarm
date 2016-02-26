namespace MyAlarm
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Sleep = new System.Windows.Forms.Button();
            this.btn_Lock = new System.Windows.Forms.Button();
            this.btn_Hibr = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_Rst = new System.Windows.Forms.Button();
            this.btn_Shut = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_act = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_sec = new System.Windows.Forms.ComboBox();
            this.cmb_min = new System.Windows.Forms.ComboBox();
            this.cmb_hr = new System.Windows.Forms.ComboBox();
            this.lblSec = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.lblMin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblHr = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mynotifyicon = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Sleep
            // 
            this.btn_Sleep.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Sleep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.btn_Sleep.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Sleep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sleep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sleep.Location = new System.Drawing.Point(136, 30);
            this.btn_Sleep.Name = "btn_Sleep";
            this.btn_Sleep.Size = new System.Drawing.Size(100, 50);
            this.btn_Sleep.TabIndex = 1;
            this.btn_Sleep.Text = "Sleep";
            this.btn_Sleep.UseVisualStyleBackColor = false;
            this.btn_Sleep.Click += new System.EventHandler(this.btn_Sleep_Click);
            // 
            // btn_Lock
            // 
            this.btn_Lock.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Lock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.btn_Lock.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Lock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Lock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Lock.Location = new System.Drawing.Point(13, 30);
            this.btn_Lock.Name = "btn_Lock";
            this.btn_Lock.Size = new System.Drawing.Size(100, 50);
            this.btn_Lock.TabIndex = 0;
            this.btn_Lock.Text = "Lock";
            this.btn_Lock.UseVisualStyleBackColor = false;
            this.btn_Lock.Click += new System.EventHandler(this.btn_Lock_Click);
            // 
            // btn_Hibr
            // 
            this.btn_Hibr.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Hibr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.btn_Hibr.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Hibr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Hibr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Hibr.Location = new System.Drawing.Point(256, 30);
            this.btn_Hibr.Name = "btn_Hibr";
            this.btn_Hibr.Size = new System.Drawing.Size(100, 50);
            this.btn_Hibr.TabIndex = 2;
            this.btn_Hibr.Text = "Hibernate";
            this.btn_Hibr.UseVisualStyleBackColor = false;
            this.btn_Hibr.Click += new System.EventHandler(this.btn_Hibr_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.btn_Rst);
            this.groupBox1.Controls.Add(this.btn_Shut);
            this.groupBox1.Controls.Add(this.btn_Lock);
            this.groupBox1.Controls.Add(this.btn_Sleep);
            this.groupBox1.Controls.Add(this.btn_Hibr);
            this.groupBox1.Location = new System.Drawing.Point(12, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 156);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quick Buttons";
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Help;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::MyAlarm.Properties.Resources.about_me_button1;
            this.button4.Location = new System.Drawing.Point(283, 104);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 42);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_Rst
            // 
            this.btn_Rst.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Rst.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.btn_Rst.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Rst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rst.Location = new System.Drawing.Point(136, 100);
            this.btn_Rst.Name = "btn_Rst";
            this.btn_Rst.Size = new System.Drawing.Size(100, 50);
            this.btn_Rst.TabIndex = 3;
            this.btn_Rst.Text = "Restart";
            this.btn_Rst.UseVisualStyleBackColor = false;
            this.btn_Rst.Click += new System.EventHandler(this.btn_Rst_Click);
            // 
            // btn_Shut
            // 
            this.btn_Shut.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btn_Shut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SlateBlue;
            this.btn_Shut.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Shut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Shut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Shut.Location = new System.Drawing.Point(13, 100);
            this.btn_Shut.Name = "btn_Shut";
            this.btn_Shut.Size = new System.Drawing.Size(100, 50);
            this.btn_Shut.TabIndex = 3;
            this.btn_Shut.Text = "Shut Down";
            this.btn_Shut.UseVisualStyleBackColor = false;
            this.btn_Shut.Click += new System.EventHandler(this.btn_Shut_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmb_act);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmb_sec);
            this.groupBox2.Controls.Add(this.cmb_min);
            this.groupBox2.Controls.Add(this.cmb_hr);
            this.groupBox2.Controls.Add(this.lblSec);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.lblMin);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.lblHr);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 236);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Set Alarm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(222, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "S";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(168, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "M";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(116, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "H";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Select Action :";
            // 
            // cmb_act
            // 
            this.cmb_act.AllowDrop = true;
            this.cmb_act.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmb_act.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_act.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_act.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_act.FormattingEnabled = true;
            this.cmb_act.Items.AddRange(new object[] {
            " ----- Select -----",
            "Hibernate",
            "Lock",
            "Restart",
            "Shut Down",
            "Sleep"});
            this.cmb_act.Location = new System.Drawing.Point(131, 112);
            this.cmb_act.Name = "cmb_act";
            this.cmb_act.Size = new System.Drawing.Size(121, 24);
            this.cmb_act.Sorted = true;
            this.cmb_act.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(205, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = ":";
            // 
            // cmb_sec
            // 
            this.cmb_sec.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmb_sec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_sec.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_sec.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmb_sec.FormattingEnabled = true;
            this.cmb_sec.Location = new System.Drawing.Point(217, 48);
            this.cmb_sec.Name = "cmb_sec";
            this.cmb_sec.Size = new System.Drawing.Size(40, 25);
            this.cmb_sec.TabIndex = 14;
            this.cmb_sec.SelectedIndexChanged += new System.EventHandler(this.cmb_sec_SelectedIndexChanged);
            this.cmb_sec.Click += new System.EventHandler(this.cmb_sec_Click);
            // 
            // cmb_min
            // 
            this.cmb_min.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmb_min.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_min.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_min.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmb_min.FormatString = "N0";
            this.cmb_min.FormattingEnabled = true;
            this.cmb_min.Location = new System.Drawing.Point(164, 48);
            this.cmb_min.Name = "cmb_min";
            this.cmb_min.Size = new System.Drawing.Size(40, 25);
            this.cmb_min.TabIndex = 13;
            this.cmb_min.SelectedIndexChanged += new System.EventHandler(this.cmb_min_SelectedIndexChanged);
            this.cmb_min.Click += new System.EventHandler(this.cmb_min_Click);
            // 
            // cmb_hr
            // 
            this.cmb_hr.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmb_hr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_hr.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_hr.ForeColor = System.Drawing.SystemColors.InfoText;
            this.cmb_hr.FormatString = "N0";
            this.cmb_hr.Location = new System.Drawing.Point(111, 48);
            this.cmb_hr.Name = "cmb_hr";
            this.cmb_hr.Size = new System.Drawing.Size(40, 25);
            this.cmb_hr.TabIndex = 12;
            this.cmb_hr.SelectedValueChanged += new System.EventHandler(this.cmb_hr_SelectedValueChanged);
            this.cmb_hr.Click += new System.EventHandler(this.cmb_hr_Click);
            this.cmb_hr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb_hr_KeyDown);
            this.cmb_hr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_hr_KeyPress);
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSec.Location = new System.Drawing.Point(237, 182);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(57, 39);
            this.lblSec.TabIndex = 11;
            this.lblSec.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(152, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label10.Location = new System.Drawing.Point(207, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 39);
            this.label10.TabIndex = 10;
            this.label10.Text = ":";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(308, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 47);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblMin.Location = new System.Drawing.Point(152, 182);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(57, 39);
            this.lblMin.TabIndex = 9;
            this.lblMin.Text = "00";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(308, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 47);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.Location = new System.Drawing.Point(122, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 39);
            this.label8.TabIndex = 8;
            this.label8.Text = ":";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLight;
            this.button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Cyan;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(308, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 47);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblHr
            // 
            this.lblHr.AutoSize = true;
            this.lblHr.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHr.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblHr.Location = new System.Drawing.Point(67, 182);
            this.lblHr.Name = "lblHr";
            this.lblHr.Size = new System.Drawing.Size(57, 39);
            this.lblHr.TabIndex = 7;
            this.lblHr.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "sec";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "hrs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Set time :";
            // 
            // mynotifyicon
            // 
            this.mynotifyicon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.mynotifyicon.BalloonTipText = "My Alarm Is Running In Background";
            this.mynotifyicon.BalloonTipTitle = "My Alarm";
            this.mynotifyicon.Icon = ((System.Drawing.Icon)(resources.GetObject("mynotifyicon.Icon")));
            this.mynotifyicon.Tag = "My Alarm";
            this.mynotifyicon.Text = "My Alarm v6.4";
            this.mynotifyicon.Visible = true;
            this.mynotifyicon.Click += new System.EventHandler(this.mynotifyicon_Click);
            this.mynotifyicon.DoubleClick += new System.EventHandler(this.mynotifyicon_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(398, 453);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "My Alarm";
            this.Text = "My Alarm v6.4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Sleep;
        private System.Windows.Forms.Button btn_Lock;
        private System.Windows.Forms.Button btn_Hibr;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblHr;
        private System.Windows.Forms.NotifyIcon mynotifyicon;
        private System.Windows.Forms.ComboBox cmb_sec;
        private System.Windows.Forms.ComboBox cmb_min;
        private System.Windows.Forms.ComboBox cmb_hr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_act;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_Rst;
        private System.Windows.Forms.Button btn_Shut;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
    }
}

