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
            btn_car = new FontAwesome.Sharp.IconButton();
            btn_outTest = new FontAwesome.Sharp.IconButton();
            tb_outBound = new TextBox();
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
            // btn_car
            // 
            btn_car.Cursor = Cursors.Hand;
            btn_car.Font = new Font("Consolas", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_car.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_car.IconColor = Color.Black;
            btn_car.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_car.Location = new Point(10, 209);
            btn_car.Name = "btn_car";
            btn_car.Size = new Size(275, 61);
            btn_car.TabIndex = 4;
            btn_car.Text = "Car at Home";
            btn_car.UseVisualStyleBackColor = true;
            // 
            // btn_outTest
            // 
            btn_outTest.Cursor = Cursors.Hand;
            btn_outTest.Font = new Font("Consolas", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_outTest.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_outTest.IconColor = Color.Black;
            btn_outTest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_outTest.Location = new Point(10, 287);
            btn_outTest.Name = "btn_outTest";
            btn_outTest.Size = new Size(275, 61);
            btn_outTest.TabIndex = 5;
            btn_outTest.Text = "OUTBOUND";
            btn_outTest.UseVisualStyleBackColor = true;
            // 
            // tb_outBound
            // 
            tb_outBound.BorderStyle = BorderStyle.None;
            tb_outBound.Font = new Font("Consolas", 35.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_outBound.Location = new Point(291, 292);
            tb_outBound.Name = "tb_outBound";
            tb_outBound.PlaceholderText = "612055555";
            tb_outBound.Size = new Size(382, 56);
            tb_outBound.TabIndex = 6;
            tb_outBound.TextAlign = HorizontalAlignment.Center;
            // 
            // V_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tb_outBound);
            Controls.Add(btn_outTest);
            Controls.Add(btn_car);
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
        private FontAwesome.Sharp.IconButton btn_car;
        private FontAwesome.Sharp.IconButton btn_outTest;
        private TextBox tb_outBound;
    }
}
