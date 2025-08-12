namespace Inchape_Agv
{
    partial class FormMain
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
            FontAwesome.Sharp.IconButton btn_close;
            FontAwesome.Sharp.IconButton btn_maximize;
            FontAwesome.Sharp.IconButton btn_minimize;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            pnl_header = new Panel();
            title_header = new Label();
            img_header = new PictureBox();
            panel2 = new Panel();
            btn_config = new FontAwesome.Sharp.IconButton();
            btn_stock = new FontAwesome.Sharp.IconButton();
            btn_task = new FontAwesome.Sharp.IconButton();
            btn_home = new FontAwesome.Sharp.IconButton();
            pnl_btnMainMenu = new Panel();
            pnl_content = new Panel();
            cS_DragControl1 = new CS_DragControl();
            cS_DragControl2 = new CS_DragControl();
            cS_DragControl3 = new CS_DragControl();
            cS_DragControl4 = new CS_DragControl();
            btn_close = new FontAwesome.Sharp.IconButton();
            btn_maximize = new FontAwesome.Sharp.IconButton();
            btn_minimize = new FontAwesome.Sharp.IconButton();
            pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_header).BeginInit();
            panel2.SuspendLayout();
            pnl_btnMainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // btn_close
            // 
            btn_close.Cursor = Cursors.Hand;
            btn_close.Dock = DockStyle.Right;
            btn_close.FlatAppearance.BorderSize = 0;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_close.IconChar = FontAwesome.Sharp.IconChar.None;
            btn_close.IconColor = Color.Black;
            btn_close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_close.IconSize = 32;
            btn_close.Location = new Point(87, 0);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(42, 42);
            btn_close.TabIndex = 1;
            btn_close.Text = "X";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // btn_maximize
            // 
            btn_maximize.Cursor = Cursors.Hand;
            btn_maximize.Dock = DockStyle.Right;
            btn_maximize.FlatAppearance.BorderSize = 0;
            btn_maximize.FlatStyle = FlatStyle.Flat;
            btn_maximize.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_maximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            btn_maximize.IconColor = Color.Black;
            btn_maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_maximize.IconSize = 32;
            btn_maximize.Location = new Point(45, 0);
            btn_maximize.Name = "btn_maximize";
            btn_maximize.Size = new Size(42, 42);
            btn_maximize.TabIndex = 2;
            btn_maximize.UseVisualStyleBackColor = true;
            btn_maximize.Click += btn_maximize_Click;
            // 
            // btn_minimize
            // 
            btn_minimize.Cursor = Cursors.Hand;
            btn_minimize.Dock = DockStyle.Right;
            btn_minimize.FlatAppearance.BorderSize = 0;
            btn_minimize.FlatStyle = FlatStyle.Flat;
            btn_minimize.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btn_minimize.IconColor = Color.Black;
            btn_minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_minimize.IconSize = 32;
            btn_minimize.Location = new Point(3, 0);
            btn_minimize.Name = "btn_minimize";
            btn_minimize.Size = new Size(42, 42);
            btn_minimize.TabIndex = 3;
            btn_minimize.UseVisualStyleBackColor = true;
            btn_minimize.Click += btn_minimize_Click;
            // 
            // pnl_header
            // 
            pnl_header.BackColor = Color.FromArgb(52, 128, 250);
            pnl_header.Controls.Add(title_header);
            pnl_header.Controls.Add(img_header);
            pnl_header.Controls.Add(panel2);
            pnl_header.Dock = DockStyle.Top;
            pnl_header.Location = new Point(0, 0);
            pnl_header.Name = "pnl_header";
            pnl_header.Size = new Size(1024, 42);
            pnl_header.TabIndex = 0;
            // 
            // title_header
            // 
            title_header.AutoSize = true;
            title_header.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title_header.Location = new Point(48, 7);
            title_header.Name = "title_header";
            title_header.Size = new Size(168, 28);
            title_header.TabIndex = 2;
            title_header.Text = "INFINITI AGV";
            // 
            // img_header
            // 
            img_header.BackColor = Color.FromArgb(52, 128, 250);
            img_header.BackgroundImage = (Image)resources.GetObject("img_header.BackgroundImage");
            img_header.BackgroundImageLayout = ImageLayout.Stretch;
            img_header.Dock = DockStyle.Left;
            img_header.Location = new Point(0, 0);
            img_header.Margin = new Padding(0, 3, 3, 3);
            img_header.Name = "img_header";
            img_header.Padding = new Padding(5, 0, 0, 0);
            img_header.Size = new Size(42, 42);
            img_header.TabIndex = 1;
            img_header.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_minimize);
            panel2.Controls.Add(btn_maximize);
            panel2.Controls.Add(btn_close);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(895, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(129, 42);
            panel2.TabIndex = 0;
            // 
            // btn_config
            // 
            btn_config.Cursor = Cursors.Hand;
            btn_config.Dock = DockStyle.Top;
            btn_config.FlatAppearance.BorderSize = 0;
            btn_config.FlatAppearance.MouseOverBackColor = Color.FromArgb(73, 193, 255);
            btn_config.FlatStyle = FlatStyle.Flat;
            btn_config.Font = new Font("Consolas", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_config.IconChar = FontAwesome.Sharp.IconChar.Sliders;
            btn_config.IconColor = Color.Black;
            btn_config.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_config.IconSize = 32;
            btn_config.ImageAlign = ContentAlignment.MiddleLeft;
            btn_config.Location = new Point(0, 156);
            btn_config.Name = "btn_config";
            btn_config.Padding = new Padding(5, 0, 0, 0);
            btn_config.Size = new Size(144, 52);
            btn_config.TabIndex = 4;
            btn_config.Text = "Config";
            btn_config.TextAlign = ContentAlignment.MiddleRight;
            btn_config.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_config.UseVisualStyleBackColor = true;
            // 
            // btn_stock
            // 
            btn_stock.Cursor = Cursors.Hand;
            btn_stock.Dock = DockStyle.Top;
            btn_stock.FlatAppearance.BorderSize = 0;
            btn_stock.FlatAppearance.MouseOverBackColor = Color.FromArgb(73, 193, 255);
            btn_stock.FlatStyle = FlatStyle.Flat;
            btn_stock.Font = new Font("Consolas", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_stock.IconChar = FontAwesome.Sharp.IconChar.Database;
            btn_stock.IconColor = Color.Black;
            btn_stock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_stock.IconSize = 32;
            btn_stock.ImageAlign = ContentAlignment.MiddleLeft;
            btn_stock.Location = new Point(0, 104);
            btn_stock.Name = "btn_stock";
            btn_stock.Padding = new Padding(5, 0, 0, 0);
            btn_stock.Size = new Size(144, 52);
            btn_stock.TabIndex = 3;
            btn_stock.Text = "Stock";
            btn_stock.TextAlign = ContentAlignment.MiddleRight;
            btn_stock.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_stock.UseVisualStyleBackColor = true;
            // 
            // btn_task
            // 
            btn_task.Cursor = Cursors.Hand;
            btn_task.Dock = DockStyle.Top;
            btn_task.FlatAppearance.BorderSize = 0;
            btn_task.FlatAppearance.MouseOverBackColor = Color.FromArgb(73, 193, 255);
            btn_task.FlatStyle = FlatStyle.Flat;
            btn_task.Font = new Font("Consolas", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_task.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            btn_task.IconColor = Color.Black;
            btn_task.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_task.IconSize = 32;
            btn_task.ImageAlign = ContentAlignment.MiddleLeft;
            btn_task.Location = new Point(0, 52);
            btn_task.Name = "btn_task";
            btn_task.Padding = new Padding(5, 0, 0, 0);
            btn_task.Size = new Size(144, 52);
            btn_task.TabIndex = 2;
            btn_task.Text = "Task";
            btn_task.TextAlign = ContentAlignment.MiddleRight;
            btn_task.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_task.UseVisualStyleBackColor = true;
            // 
            // btn_home
            // 
            btn_home.Cursor = Cursors.Hand;
            btn_home.Dock = DockStyle.Top;
            btn_home.FlatAppearance.BorderSize = 0;
            btn_home.FlatAppearance.MouseOverBackColor = Color.FromArgb(73, 193, 255);
            btn_home.FlatStyle = FlatStyle.Flat;
            btn_home.Font = new Font("Consolas", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_home.IconChar = FontAwesome.Sharp.IconChar.House;
            btn_home.IconColor = Color.Black;
            btn_home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_home.IconSize = 32;
            btn_home.ImageAlign = ContentAlignment.MiddleLeft;
            btn_home.Location = new Point(0, 0);
            btn_home.Name = "btn_home";
            btn_home.Padding = new Padding(5, 0, 0, 0);
            btn_home.Size = new Size(144, 52);
            btn_home.TabIndex = 1;
            btn_home.Text = "Home";
            btn_home.TextAlign = ContentAlignment.MiddleRight;
            btn_home.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_home.UseVisualStyleBackColor = true;
            // 
            // pnl_btnMainMenu
            // 
            pnl_btnMainMenu.BackColor = Color.FromArgb(52, 128, 250);
            pnl_btnMainMenu.Controls.Add(btn_config);
            pnl_btnMainMenu.Controls.Add(btn_stock);
            pnl_btnMainMenu.Controls.Add(btn_task);
            pnl_btnMainMenu.Controls.Add(btn_home);
            pnl_btnMainMenu.Dock = DockStyle.Left;
            pnl_btnMainMenu.Location = new Point(0, 42);
            pnl_btnMainMenu.Name = "pnl_btnMainMenu";
            pnl_btnMainMenu.Size = new Size(144, 498);
            pnl_btnMainMenu.TabIndex = 1;
            // 
            // pnl_content
            // 
            pnl_content.Dock = DockStyle.Fill;
            pnl_content.Location = new Point(144, 42);
            pnl_content.Name = "pnl_content";
            pnl_content.Size = new Size(880, 498);
            pnl_content.TabIndex = 2;
            // 
            // cS_DragControl1
            // 
            cS_DragControl1.SelectControl = img_header;
            // 
            // cS_DragControl2
            // 
            cS_DragControl2.SelectControl = title_header;
            // 
            // cS_DragControl3
            // 
            cS_DragControl3.SelectControl = pnl_header;
            // 
            // cS_DragControl4
            // 
            cS_DragControl4.SelectControl = pnl_btnMainMenu;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 540);
            Controls.Add(pnl_content);
            Controls.Add(pnl_btnMainMenu);
            Controls.Add(pnl_header);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FormMain_Load;
            pnl_header.ResumeLayout(false);
            pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)img_header).EndInit();
            panel2.ResumeLayout(false);
            pnl_btnMainMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_header;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btn_close;
        private FontAwesome.Sharp.IconButton btn_home;
        private FontAwesome.Sharp.IconButton btn_task;
        private FontAwesome.Sharp.IconButton btn_config;
        private FontAwesome.Sharp.IconButton btn_stock;
        private Panel pnl_btnMainMenu;
        private PictureBox img_header;
        private Label title_header;
        private Panel pnl_content;
        private CS_DragControl cS_DragControl1;
        private CS_DragControl cS_DragControl2;
        private CS_DragControl cS_DragControl3;
        private CS_DragControl cS_DragControl4;
    }
}
