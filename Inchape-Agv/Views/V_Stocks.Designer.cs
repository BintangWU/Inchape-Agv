namespace Inchape_Agv.Views
{
    partial class V_Stocks
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtg_stocks = new DataGridView();
            btn_add = new FontAwesome.Sharp.IconButton();
            tb_name = new TextBox();
            tb_routeIn = new TextBox();
            tb_endLandMark = new TextBox();
            tb_landMark = new TextBox();
            cbo_door = new ComboBox();
            btn_update = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            cbo_type = new ComboBox();
            btn_import = new FontAwesome.Sharp.IconButton();
            linkLabel1 = new LinkLabel();
            btn_export = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            tb_index = new TextBox();
            label8 = new Label();
            tb_routeOut = new TextBox();
            id = new DataGridViewTextBoxColumn();
            idx = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            routeIn = new DataGridViewTextBoxColumn();
            routeOut = new DataGridViewTextBoxColumn();
            mark = new DataGridViewTextBoxColumn();
            endMark = new DataGridViewTextBoxColumn();
            door = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            code = new DataGridViewTextBoxColumn();
            delete = new DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)dtg_stocks).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 11.25F);
            label1.Location = new Point(162, 10);
            label1.Margin = new Padding(10, 10, 0, 0);
            label1.Name = "label1";
            label1.Size = new Size(48, 18);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 11.25F);
            label2.Location = new Point(10, 44);
            label2.Margin = new Padding(10, 10, 0, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 18);
            label2.TabIndex = 9;
            label2.Text = "Route In:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 11.25F);
            label4.Location = new Point(162, 46);
            label4.Margin = new Padding(10, 10, 0, 0);
            label4.Name = "label4";
            label4.Size = new Size(48, 18);
            label4.TabIndex = 11;
            label4.Text = "Mark:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 11.25F);
            label5.Location = new Point(162, 83);
            label5.Margin = new Padding(10, 10, 0, 0);
            label5.Name = "label5";
            label5.Size = new Size(80, 18);
            label5.TabIndex = 12;
            label5.Text = "End Mark:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(358, 10);
            label6.Margin = new Padding(10, 10, 0, 0);
            label6.Name = "label6";
            label6.Size = new Size(54, 19);
            label6.TabIndex = 16;
            label6.Text = "Door:";
            // 
            // dtg_stocks
            // 
            dtg_stocks.AllowUserToDeleteRows = false;
            dtg_stocks.AllowUserToOrderColumns = true;
            dtg_stocks.AllowUserToResizeRows = false;
            dtg_stocks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtg_stocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtg_stocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtg_stocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_stocks.Columns.AddRange(new DataGridViewColumn[] { id, idx, name, routeIn, routeOut, mark, endMark, door, type, code, delete });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtg_stocks.DefaultCellStyle = dataGridViewCellStyle2;
            dtg_stocks.Location = new Point(10, 116);
            dtg_stocks.Margin = new Padding(10);
            dtg_stocks.Name = "dtg_stocks";
            dtg_stocks.RowHeadersVisible = false;
            dtg_stocks.Size = new Size(930, 414);
            dtg_stocks.TabIndex = 20;
            dtg_stocks.CellClick += dtg_stocks_CellClick;
            // 
            // btn_add
            // 
            btn_add.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_add.Cursor = Cursors.Hand;
            btn_add.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btn_add.IconColor = Color.Black;
            btn_add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_add.IconSize = 24;
            btn_add.Location = new Point(622, 9);
            btn_add.Margin = new Padding(3, 10, 3, 3);
            btn_add.Name = "btn_add";
            btn_add.Padding = new Padding(0, 5, 0, 0);
            btn_add.Size = new Size(75, 58);
            btn_add.TabIndex = 21;
            btn_add.Text = "ADD";
            btn_add.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_add.UseVisualStyleBackColor = true;
            // 
            // tb_name
            // 
            tb_name.BorderStyle = BorderStyle.FixedSingle;
            tb_name.Font = new Font("Consolas", 11.25F);
            tb_name.Location = new Point(245, 8);
            tb_name.Margin = new Padding(3, 10, 3, 3);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(100, 25);
            tb_name.TabIndex = 22;
            // 
            // tb_routeIn
            // 
            tb_routeIn.BorderStyle = BorderStyle.FixedSingle;
            tb_routeIn.Font = new Font("Consolas", 11.25F);
            tb_routeIn.Location = new Point(96, 42);
            tb_routeIn.Margin = new Padding(3, 10, 3, 3);
            tb_routeIn.Name = "tb_routeIn";
            tb_routeIn.Size = new Size(53, 25);
            tb_routeIn.TabIndex = 23;
            // 
            // tb_endLandMark
            // 
            tb_endLandMark.BorderStyle = BorderStyle.FixedSingle;
            tb_endLandMark.Font = new Font("Consolas", 11.25F);
            tb_endLandMark.Location = new Point(245, 78);
            tb_endLandMark.Margin = new Padding(3, 10, 3, 3);
            tb_endLandMark.Name = "tb_endLandMark";
            tb_endLandMark.Size = new Size(53, 25);
            tb_endLandMark.TabIndex = 25;
            // 
            // tb_landMark
            // 
            tb_landMark.BorderStyle = BorderStyle.FixedSingle;
            tb_landMark.Font = new Font("Consolas", 11.25F);
            tb_landMark.Location = new Point(245, 42);
            tb_landMark.Margin = new Padding(3, 10, 3, 3);
            tb_landMark.Name = "tb_landMark";
            tb_landMark.Size = new Size(53, 25);
            tb_landMark.TabIndex = 24;
            // 
            // cbo_door
            // 
            cbo_door.Font = new Font("Consolas", 11.25F);
            cbo_door.FormattingEnabled = true;
            cbo_door.Items.AddRange(new object[] { "LH", "RH" });
            cbo_door.Location = new Point(415, 8);
            cbo_door.Margin = new Padding(3, 10, 3, 3);
            cbo_door.Name = "cbo_door";
            cbo_door.Size = new Size(72, 26);
            cbo_door.TabIndex = 26;
            // 
            // btn_update
            // 
            btn_update.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_update.Cursor = Cursors.Hand;
            btn_update.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btn_update.IconColor = Color.Black;
            btn_update.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_update.IconSize = 24;
            btn_update.Location = new Point(703, 9);
            btn_update.Margin = new Padding(3, 10, 3, 3);
            btn_update.Name = "btn_update";
            btn_update.Padding = new Padding(0, 5, 0, 0);
            btn_update.Size = new Size(75, 58);
            btn_update.TabIndex = 27;
            btn_update.Text = "UPDATE";
            btn_update.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_update.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 11.25F);
            label3.Location = new Point(358, 46);
            label3.Margin = new Padding(10, 10, 0, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 18);
            label3.TabIndex = 28;
            label3.Text = "Type:";
            // 
            // cbo_type
            // 
            cbo_type.Font = new Font("Consolas", 11.25F);
            cbo_type.FormattingEnabled = true;
            cbo_type.Items.AddRange(new object[] { "FG", "Trolley " });
            cbo_type.Location = new Point(415, 42);
            cbo_type.Margin = new Padding(3, 10, 3, 3);
            cbo_type.Name = "cbo_type";
            cbo_type.Size = new Size(72, 26);
            cbo_type.TabIndex = 29;
            // 
            // btn_import
            // 
            btn_import.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_import.Cursor = Cursors.Hand;
            btn_import.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_import.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            btn_import.IconColor = Color.Black;
            btn_import.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_import.IconSize = 24;
            btn_import.Location = new Point(784, 9);
            btn_import.Margin = new Padding(3, 10, 3, 3);
            btn_import.Name = "btn_import";
            btn_import.Padding = new Padding(0, 5, 0, 0);
            btn_import.Size = new Size(75, 58);
            btn_import.TabIndex = 30;
            btn_import.Text = "IMPORT";
            btn_import.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_import.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(13, 76);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 31;
            // 
            // btn_export
            // 
            btn_export.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_export.Cursor = Cursors.Hand;
            btn_export.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_export.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            btn_export.IconColor = Color.Black;
            btn_export.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_export.IconSize = 24;
            btn_export.Location = new Point(865, 9);
            btn_export.Margin = new Padding(3, 10, 3, 3);
            btn_export.Name = "btn_export";
            btn_export.Padding = new Padding(0, 5, 0, 0);
            btn_export.Size = new Size(75, 58);
            btn_export.TabIndex = 32;
            btn_export.Text = "EXPORT";
            btn_export.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_export.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 11.25F);
            label7.Location = new Point(10, 10);
            label7.Margin = new Padding(10, 10, 0, 0);
            label7.Name = "label7";
            label7.Size = new Size(40, 18);
            label7.TabIndex = 33;
            label7.Text = "Idx:";
            // 
            // tb_index
            // 
            tb_index.BorderStyle = BorderStyle.FixedSingle;
            tb_index.Font = new Font("Consolas", 11.25F);
            tb_index.Location = new Point(96, 8);
            tb_index.Margin = new Padding(3, 10, 3, 3);
            tb_index.Name = "tb_index";
            tb_index.Size = new Size(53, 25);
            tb_index.TabIndex = 34;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 11.25F);
            label8.Location = new Point(10, 80);
            label8.Margin = new Padding(10, 10, 0, 0);
            label8.Name = "label8";
            label8.Size = new Size(88, 18);
            label8.TabIndex = 35;
            label8.Text = "Route Out:";
            // 
            // tb_routeOut
            // 
            tb_routeOut.BorderStyle = BorderStyle.FixedSingle;
            tb_routeOut.Font = new Font("Consolas", 11.25F);
            tb_routeOut.Location = new Point(96, 76);
            tb_routeOut.Margin = new Padding(3, 10, 3, 3);
            tb_routeOut.Name = "tb_routeOut";
            tb_routeOut.Size = new Size(53, 25);
            tb_routeOut.TabIndex = 36;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            id.DataPropertyName = "id";
            id.HeaderText = "ID";
            id.Name = "id";
            id.Resizable = DataGridViewTriState.False;
            id.Visible = false;
            id.Width = 50;
            // 
            // idx
            // 
            idx.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            idx.DataPropertyName = "idx";
            idx.HeaderText = "IDX";
            idx.Name = "idx";
            idx.ReadOnly = true;
            idx.Resizable = DataGridViewTriState.False;
            idx.Width = 60;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.DataPropertyName = "name";
            name.HeaderText = "NAME";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // routeIn
            // 
            routeIn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            routeIn.DataPropertyName = "routeIn";
            routeIn.HeaderText = "ROUTE IN";
            routeIn.Name = "routeIn";
            routeIn.ReadOnly = true;
            routeIn.Resizable = DataGridViewTriState.False;
            routeIn.Width = 60;
            // 
            // routeOut
            // 
            routeOut.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            routeOut.DataPropertyName = "routeOut";
            routeOut.HeaderText = "ROUTE OUT";
            routeOut.Name = "routeOut";
            routeOut.Width = 60;
            // 
            // mark
            // 
            mark.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            mark.DataPropertyName = "mark";
            mark.HeaderText = "MARK";
            mark.Name = "mark";
            mark.ReadOnly = true;
            mark.Resizable = DataGridViewTriState.False;
            mark.Width = 60;
            // 
            // endMark
            // 
            endMark.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            endMark.DataPropertyName = "endMark";
            endMark.HeaderText = "END MARK";
            endMark.Name = "endMark";
            endMark.ReadOnly = true;
            endMark.Resizable = DataGridViewTriState.False;
            endMark.Width = 60;
            // 
            // door
            // 
            door.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            door.DataPropertyName = "door";
            door.HeaderText = "DOOR";
            door.Name = "door";
            door.ReadOnly = true;
            door.Resizable = DataGridViewTriState.False;
            door.Width = 60;
            // 
            // type
            // 
            type.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            type.DataPropertyName = "type";
            type.HeaderText = "TYPE";
            type.Name = "type";
            type.ReadOnly = true;
            type.Resizable = DataGridViewTriState.False;
            type.Width = 60;
            // 
            // code
            // 
            code.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            code.DataPropertyName = "code";
            code.HeaderText = "CODE";
            code.Name = "code";
            code.ReadOnly = true;
            code.Resizable = DataGridViewTriState.True;
            // 
            // delete
            // 
            delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            delete.HeaderText = "DELETE";
            delete.LinkBehavior = LinkBehavior.AlwaysUnderline;
            delete.Name = "delete";
            delete.Resizable = DataGridViewTriState.False;
            delete.SortMode = DataGridViewColumnSortMode.Automatic;
            delete.Text = "delete";
            delete.TrackVisitedState = false;
            delete.UseColumnTextForLinkValue = true;
            delete.VisitedLinkColor = Color.Blue;
            delete.Width = 75;
            // 
            // V_Stocks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tb_routeOut);
            Controls.Add(label8);
            Controls.Add(tb_index);
            Controls.Add(label7);
            Controls.Add(btn_export);
            Controls.Add(linkLabel1);
            Controls.Add(btn_import);
            Controls.Add(cbo_type);
            Controls.Add(label3);
            Controls.Add(btn_update);
            Controls.Add(cbo_door);
            Controls.Add(tb_endLandMark);
            Controls.Add(tb_landMark);
            Controls.Add(tb_routeIn);
            Controls.Add(tb_name);
            Controls.Add(btn_add);
            Controls.Add(dtg_stocks);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "V_Stocks";
            Size = new Size(950, 540);
            Load += V_Stocks_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_stocks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dtg_stocks;
        private FontAwesome.Sharp.IconButton btn_add;
        private TextBox tb_name;
        private TextBox tb_routeIn;
        private TextBox tb_endLandMark;
        private TextBox tb_landMark;
        private ComboBox cbo_door;
        private FontAwesome.Sharp.IconButton btn_update;
        private Label label3;
        private ComboBox cbo_type;
        private FontAwesome.Sharp.IconButton btn_import;
        private LinkLabel linkLabel1;
        private FontAwesome.Sharp.IconButton btn_export;
        private Label label7;
        private TextBox tb_index;
        private Label label8;
        private TextBox tb_routeOut;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn idx;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn routeIn;
        private DataGridViewTextBoxColumn routeOut;
        private DataGridViewTextBoxColumn mark;
        private DataGridViewTextBoxColumn endMark;
        private DataGridViewTextBoxColumn door;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn code;
        private DataGridViewLinkColumn delete;
    }
}
