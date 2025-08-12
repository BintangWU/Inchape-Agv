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
            btn_clearProdNo = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            btn_send.Text = "SEND TO STORAGE";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += btn_send_Click;
            // 
            // btn_clearProdNo
            // 
            btn_clearProdNo.Cursor = Cursors.Hand;
            btn_clearProdNo.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_clearProdNo.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_clearProdNo.IconColor = Color.Black;
            btn_clearProdNo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_clearProdNo.Location = new Point(669, 10);
            btn_clearProdNo.Name = "btn_clearProdNo";
            btn_clearProdNo.Size = new Size(140, 129);
            btn_clearProdNo.TabIndex = 3;
            btn_clearProdNo.Text = "CLEAR Prod No";
            btn_clearProdNo.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 152);
            dataGridView1.Margin = new Padding(10);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(799, 336);
            dataGridView1.TabIndex = 4;
            // 
            // V_Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(btn_clearProdNo);
            Controls.Add(btn_send);
            Controls.Add(tb_prodNo);
            Controls.Add(label1);
            Name = "V_Home";
            Size = new Size(821, 498);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_prodNo;
        private FontAwesome.Sharp.IconButton btn_send;
        private FontAwesome.Sharp.IconButton btn_clearProdNo;
        private DataGridView dataGridView1;
    }
}
