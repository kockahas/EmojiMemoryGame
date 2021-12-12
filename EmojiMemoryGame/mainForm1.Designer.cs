namespace EmojiMemoryGame
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelLeftSide = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pinfobutton = new System.Windows.Forms.Button();
            this.login_button5 = new System.Windows.Forms.Button();
            this.exit_button4 = new System.Windows.Forms.Button();
            this.btn_8x8start = new System.Windows.Forms.Button();
            this.btn_6x6start = new System.Windows.Forms.Button();
            this.btn_4x4start = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer_netpinger = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBox4x4 = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listBox6x6 = new System.Windows.Forms.ListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.listBox8x8 = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.loggingfressh = new System.Windows.Forms.Timer(this.components);
            this.panelLeftSide.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeftSide
            // 
            this.panelLeftSide.BackColor = System.Drawing.Color.Navy;
            this.panelLeftSide.Controls.Add(this.button1);
            this.panelLeftSide.Controls.Add(this.pinfobutton);
            this.panelLeftSide.Controls.Add(this.login_button5);
            this.panelLeftSide.Controls.Add(this.exit_button4);
            this.panelLeftSide.Controls.Add(this.btn_8x8start);
            this.panelLeftSide.Controls.Add(this.btn_6x6start);
            this.panelLeftSide.Controls.Add(this.btn_4x4start);
            this.panelLeftSide.Controls.Add(this.panelTop);
            this.panelLeftSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftSide.Location = new System.Drawing.Point(0, 0);
            this.panelLeftSide.Name = "panelLeftSide";
            this.panelLeftSide.Size = new System.Drawing.Size(151, 448);
            this.panelLeftSide.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(53, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 33);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pinfobutton
            // 
            this.pinfobutton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pinfobutton.FlatAppearance.BorderSize = 0;
            this.pinfobutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.pinfobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pinfobutton.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pinfobutton.Location = new System.Drawing.Point(0, 298);
            this.pinfobutton.Name = "pinfobutton";
            this.pinfobutton.Size = new System.Drawing.Size(151, 50);
            this.pinfobutton.TabIndex = 2;
            this.pinfobutton.Text = "Program Infó";
            this.pinfobutton.UseVisualStyleBackColor = true;
            this.pinfobutton.Click += new System.EventHandler(this.pinfobutton_Click);
            // 
            // login_button5
            // 
            this.login_button5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.login_button5.Enabled = false;
            this.login_button5.FlatAppearance.BorderSize = 0;
            this.login_button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.login_button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button5.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.login_button5.Location = new System.Drawing.Point(0, 348);
            this.login_button5.Name = "login_button5";
            this.login_button5.Size = new System.Drawing.Size(151, 50);
            this.login_button5.TabIndex = 1;
            this.login_button5.Text = "Bejelentkezés";
            this.login_button5.UseVisualStyleBackColor = true;
            this.login_button5.Click += new System.EventHandler(this.login_button5_Click);
            // 
            // exit_button4
            // 
            this.exit_button4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exit_button4.FlatAppearance.BorderSize = 0;
            this.exit_button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exit_button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.exit_button4.Location = new System.Drawing.Point(0, 398);
            this.exit_button4.Name = "exit_button4";
            this.exit_button4.Size = new System.Drawing.Size(151, 50);
            this.exit_button4.TabIndex = 1;
            this.exit_button4.Text = "Kilépés a játékból";
            this.exit_button4.UseVisualStyleBackColor = true;
            this.exit_button4.Click += new System.EventHandler(this.exit_button4_Click);
            // 
            // btn_8x8start
            // 
            this.btn_8x8start.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_8x8start.FlatAppearance.BorderSize = 0;
            this.btn_8x8start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btn_8x8start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_8x8start.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_8x8start.Location = new System.Drawing.Point(0, 203);
            this.btn_8x8start.Name = "btn_8x8start";
            this.btn_8x8start.Size = new System.Drawing.Size(151, 50);
            this.btn_8x8start.TabIndex = 1;
            this.btn_8x8start.Text = "8X8 játék indítás";
            this.btn_8x8start.UseVisualStyleBackColor = true;
            this.btn_8x8start.Click += new System.EventHandler(this.btn_8x8start_Click);
            // 
            // btn_6x6start
            // 
            this.btn_6x6start.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_6x6start.FlatAppearance.BorderSize = 0;
            this.btn_6x6start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btn_6x6start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_6x6start.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_6x6start.Location = new System.Drawing.Point(0, 153);
            this.btn_6x6start.Name = "btn_6x6start";
            this.btn_6x6start.Size = new System.Drawing.Size(151, 50);
            this.btn_6x6start.TabIndex = 1;
            this.btn_6x6start.Text = "6X6 játék indítás";
            this.btn_6x6start.UseVisualStyleBackColor = true;
            this.btn_6x6start.Click += new System.EventHandler(this.btn_6x6start_Click);
            // 
            // btn_4x4start
            // 
            this.btn_4x4start.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_4x4start.FlatAppearance.BorderSize = 0;
            this.btn_4x4start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btn_4x4start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_4x4start.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_4x4start.Location = new System.Drawing.Point(0, 103);
            this.btn_4x4start.Name = "btn_4x4start";
            this.btn_4x4start.Size = new System.Drawing.Size(151, 50);
            this.btn_4x4start.TabIndex = 1;
            this.btn_4x4start.Text = "4X4 játék indítás";
            this.btn_4x4start.UseVisualStyleBackColor = true;
            this.btn_4x4start.Click += new System.EventHandler(this.btn_4x4start_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(151, 103);
            this.panelTop.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(8, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 1;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "---";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_netpinger
            // 
            this.timer_netpinger.Enabled = true;
            this.timer_netpinger.Interval = 5000;
            this.timer_netpinger.Tick += new System.EventHandler(this.timer_netpinger_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(151, 426);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(326, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(151, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(326, 426);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.Enter += new System.EventHandler(this.tabControl1_Enter);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(318, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Szerver eredménylisták";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(312, 392);
            this.tabControl2.TabIndex = 0;
            this.tabControl2.SelectedIndexChanged += new System.EventHandler(this.tabControl2_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBox4x4);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(304, 364);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "4x4";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBox4x4
            // 
            this.listBox4x4.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox4x4.FormattingEnabled = true;
            this.listBox4x4.ItemHeight = 15;
            this.listBox4x4.Location = new System.Drawing.Point(3, 3);
            this.listBox4x4.Name = "listBox4x4";
            this.listBox4x4.Size = new System.Drawing.Size(298, 289);
            this.listBox4x4.TabIndex = 0;
            this.listBox4x4.Tag = "4";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listBox6x6);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(304, 364);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "6x6";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listBox6x6
            // 
            this.listBox6x6.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox6x6.FormattingEnabled = true;
            this.listBox6x6.ItemHeight = 15;
            this.listBox6x6.Location = new System.Drawing.Point(3, 3);
            this.listBox6x6.Name = "listBox6x6";
            this.listBox6x6.Size = new System.Drawing.Size(298, 289);
            this.listBox6x6.TabIndex = 0;
            this.listBox6x6.Tag = "6";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.listBox8x8);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(304, 364);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "8x8";
            // 
            // listBox8x8
            // 
            this.listBox8x8.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox8x8.FormattingEnabled = true;
            this.listBox8x8.ItemHeight = 15;
            this.listBox8x8.Location = new System.Drawing.Point(0, 0);
            this.listBox8x8.Name = "listBox8x8";
            this.listBox8x8.Size = new System.Drawing.Size(304, 289);
            this.listBox8x8.TabIndex = 0;
            this.listBox8x8.Tag = "8";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(318, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lokális játék eredmények";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(72, 298);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 98);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(66, 71);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(44, 19);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "8X8";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(66, 46);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(44, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "6X6";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(66, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(44, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "4X4";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(312, 289);
            this.listBox1.TabIndex = 4;
            // 
            // loggingfressh
            // 
            this.loggingfressh.Interval = 10000;
            this.loggingfressh.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 448);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelLeftSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "mainForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emoji memoria játék";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.panelLeftSide.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLeftSide;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button login_button5;
        private System.Windows.Forms.Button exit_button4;
        private System.Windows.Forms.Button btn_8x8start;
        private System.Windows.Forms.Button btn_6x6start;
        private System.Windows.Forms.Timer timer_netpinger;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button btn_4x4start;
        public System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ListBox listBox4x4;
        private System.Windows.Forms.ListBox listBox6x6;
        private System.Windows.Forms.ListBox listBox8x8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button pinfobutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer loggingfressh;
        private System.Windows.Forms.Label label3;
    }
}

