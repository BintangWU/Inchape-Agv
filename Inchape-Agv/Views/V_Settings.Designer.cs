namespace Inchape_Agv.Views
{
    partial class V_Settings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cbo_comPort = new ComboBox();
            btn_refreshCom = new FontAwesome.Sharp.IconButton();
            cbo_baud = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            tb_rfAddr = new TextBox();
            btn_apply = new FontAwesome.Sharp.IconButton();
            tb_comState = new TextBox();
            groupBox1 = new GroupBox();
            btn_save = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            tb_homeMark = new TextBox();
            groupBox2 = new GroupBox();
            tb_mac = new TextBox();
            tb_serverPort = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tb_ip = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 37);
            label1.Name = "label1";
            label1.Size = new Size(90, 19);
            label1.TabIndex = 0;
            label1.Text = "COM Port:";
            // 
            // cbo_comPort
            // 
            cbo_comPort.DropDownHeight = 200;
            cbo_comPort.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_comPort.DropDownWidth = 110;
            cbo_comPort.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbo_comPort.FormattingEnabled = true;
            cbo_comPort.IntegralHeight = false;
            cbo_comPort.Location = new Point(102, 34);
            cbo_comPort.Name = "cbo_comPort";
            cbo_comPort.Size = new Size(121, 27);
            cbo_comPort.TabIndex = 1;
            // 
            // btn_refreshCom
            // 
            btn_refreshCom.Cursor = Cursors.Hand;
            btn_refreshCom.FlatAppearance.BorderSize = 0;
            btn_refreshCom.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            btn_refreshCom.IconColor = Color.Black;
            btn_refreshCom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_refreshCom.IconSize = 24;
            btn_refreshCom.Location = new Point(229, 34);
            btn_refreshCom.Name = "btn_refreshCom";
            btn_refreshCom.Padding = new Padding(0, 3, 0, 0);
            btn_refreshCom.Size = new Size(27, 27);
            btn_refreshCom.TabIndex = 2;
            btn_refreshCom.UseVisualStyleBackColor = true;
            // 
            // cbo_baud
            // 
            cbo_baud.DropDownHeight = 200;
            cbo_baud.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_baud.DropDownWidth = 110;
            cbo_baud.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbo_baud.FormattingEnabled = true;
            cbo_baud.IntegralHeight = false;
            cbo_baud.Items.AddRange(new object[] { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" });
            cbo_baud.Location = new Point(102, 67);
            cbo_baud.Name = "cbo_baud";
            cbo_baud.Size = new Size(121, 27);
            cbo_baud.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 70);
            label2.Name = "label2";
            label2.Size = new Size(90, 19);
            label2.TabIndex = 4;
            label2.Text = "Baudrate:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 134);
            label3.Name = "label3";
            label3.Size = new Size(81, 19);
            label3.TabIndex = 5;
            label3.Text = "RF Addr:";
            // 
            // tb_rfAddr
            // 
            tb_rfAddr.BorderStyle = BorderStyle.FixedSingle;
            tb_rfAddr.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_rfAddr.Location = new Point(102, 132);
            tb_rfAddr.Name = "tb_rfAddr";
            tb_rfAddr.Size = new Size(121, 26);
            tb_rfAddr.TabIndex = 7;
            // 
            // btn_apply
            // 
            btn_apply.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_apply.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_apply.IconColor = Color.Black;
            btn_apply.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_apply.Location = new Point(6, 233);
            btn_apply.Name = "btn_apply";
            btn_apply.Size = new Size(254, 31);
            btn_apply.TabIndex = 8;
            btn_apply.Text = "APPLY";
            btn_apply.UseVisualStyleBackColor = true;
            // 
            // tb_comState
            // 
            tb_comState.BackColor = Color.FromArgb(229, 62, 48);
            tb_comState.BorderStyle = BorderStyle.None;
            tb_comState.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_comState.Location = new Point(10, 100);
            tb_comState.Name = "tb_comState";
            tb_comState.ReadOnly = true;
            tb_comState.Size = new Size(250, 19);
            tb_comState.TabIndex = 10;
            tb_comState.Text = "Disconnected";
            tb_comState.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_save);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btn_apply);
            groupBox1.Controls.Add(tb_homeMark);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tb_comState);
            groupBox1.Controls.Add(cbo_comPort);
            groupBox1.Controls.Add(cbo_baud);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tb_rfAddr);
            groupBox1.Controls.Add(btn_refreshCom);
            groupBox1.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(10, 10);
            groupBox1.Margin = new Padding(10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 430);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Serial ";
            // 
            // btn_save
            // 
            btn_save.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_save.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_save.IconColor = Color.Black;
            btn_save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_save.Location = new Point(6, 196);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(254, 31);
            btn_save.TabIndex = 12;
            btn_save.Text = "SAVE";
            btn_save.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 166);
            label7.Name = "label7";
            label7.Size = new Size(81, 19);
            label7.TabIndex = 11;
            label7.Text = "Home ID:";
            // 
            // tb_homeMark
            // 
            tb_homeMark.BorderStyle = BorderStyle.FixedSingle;
            tb_homeMark.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_homeMark.Location = new Point(102, 164);
            tb_homeMark.Name = "tb_homeMark";
            tb_homeMark.Size = new Size(121, 26);
            tb_homeMark.TabIndex = 12;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tb_mac);
            groupBox2.Controls.Add(tb_serverPort);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(tb_ip);
            groupBox2.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(296, 10);
            groupBox2.Margin = new Padding(10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(233, 430);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Server";
            // 
            // tb_mac
            // 
            tb_mac.BorderStyle = BorderStyle.FixedSingle;
            tb_mac.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_mac.Location = new Point(66, 100);
            tb_mac.Name = "tb_mac";
            tb_mac.ReadOnly = true;
            tb_mac.Size = new Size(156, 26);
            tb_mac.TabIndex = 9;
            // 
            // tb_serverPort
            // 
            tb_serverPort.BorderStyle = BorderStyle.FixedSingle;
            tb_serverPort.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_serverPort.Location = new Point(66, 67);
            tb_serverPort.Name = "tb_serverPort";
            tb_serverPort.Size = new Size(100, 26);
            tb_serverPort.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 37);
            label4.Name = "label4";
            label4.Size = new Size(36, 19);
            label4.TabIndex = 0;
            label4.Text = "IP:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 70);
            label5.Name = "label5";
            label5.Size = new Size(54, 19);
            label5.TabIndex = 4;
            label5.Text = "Port:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 102);
            label6.Name = "label6";
            label6.Size = new Size(45, 19);
            label6.TabIndex = 5;
            label6.Text = "MAC:";
            // 
            // tb_ip
            // 
            tb_ip.BorderStyle = BorderStyle.FixedSingle;
            tb_ip.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_ip.Location = new Point(66, 35);
            tb_ip.Name = "tb_ip";
            tb_ip.PlaceholderText = "192.168.0.1";
            tb_ip.ReadOnly = true;
            tb_ip.Size = new Size(156, 26);
            tb_ip.TabIndex = 7;
            // 
            // V_Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "V_Settings";
            Size = new Size(800, 450);
            Load += V_Settings_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ComboBox cbo_comPort;
        private FontAwesome.Sharp.IconButton btn_refreshCom;
        private ComboBox cbo_baud;
        private Label label2;
        private Label label3;
        private TextBox tb_rfAddr;
        private FontAwesome.Sharp.IconButton btn_apply;
        private TextBox tb_comState;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox4;
        private TextBox textBox3;
        private Label label4;
        private TextBox tb_mac;
        private Label label5;
        private Label label6;
        private TextBox tb_ip;
        private TextBox tb_serverPort;
        private FontAwesome.Sharp.IconButton btn_save;
        private Label label7;
        private TextBox tb_homeMark;
    }
}
