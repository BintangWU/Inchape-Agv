namespace Inchape_Agv.Views
{
    partial class V_Home
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
            tb_prodNo = new TextBox();
            btn_send = new FontAwesome.Sharp.IconButton();
            btn_test = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 10);
            label1.Margin = new Padding(10);
            label1.Name = "label1";
            label1.Size = new Size(258, 55);
            label1.TabIndex = 0;
            label1.Text = "Prod No.:";
            // 
            // tb_prodNo
            // 
            tb_prodNo.BorderStyle = BorderStyle.None;
            tb_prodNo.Font = new Font("Consolas", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_prodNo.Location = new Point(281, 10);
            tb_prodNo.Name = "tb_prodNo";
            tb_prodNo.PlaceholderText = "612055555";
            tb_prodNo.Size = new Size(382, 56);
            tb_prodNo.TabIndex = 1;
            tb_prodNo.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_send
            // 
            btn_send.Cursor = Cursors.Hand;
            btn_send.Font = new Font("Consolas", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_send.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_send.IconColor = Color.Black;
            btn_send.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_send.Location = new Point(10, 78);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(653, 61);
            btn_send.TabIndex = 2;
            btn_send.Text = "SEND to WAREHOUSE";
            btn_send.UseVisualStyleBackColor = true;
            // 
            // btn_test
            // 
            btn_test.Cursor = Cursors.Hand;
            btn_test.Font = new Font("Consolas", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_test.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_test.IconColor = Color.Black;
            btn_test.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_test.Location = new Point(10, 172);
            btn_test.Name = "btn_test";
            btn_test.Size = new Size(153, 61);
            btn_test.TabIndex = 4;
            btn_test.Text = "TEST";
            btn_test.UseVisualStyleBackColor = true;
            // 
            // V_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_test);
            Controls.Add(btn_send);
            Controls.Add(tb_prodNo);
            Controls.Add(label1);
            Name = "V_Home";
            Size = new Size(821, 498);
            Load += V_Home_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_prodNo;
        private FontAwesome.Sharp.IconButton btn_send;
        private FontAwesome.Sharp.IconButton btn_test;
    }
}
