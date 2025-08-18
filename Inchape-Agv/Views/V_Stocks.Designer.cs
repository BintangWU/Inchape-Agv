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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dtg_stocks = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            index = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            route = new DataGridViewTextBoxColumn();
            markId = new DataGridViewTextBoxColumn();
            endMarkId = new DataGridViewTextBoxColumn();
            typeStock = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            prodNo = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            delete = new DataGridViewLinkColumn();
            btn_add = new FontAwesome.Sharp.IconButton();
            tb_name = new TextBox();
            tb_route = new TextBox();
            tb_endMarkId = new TextBox();
            tb_markId = new TextBox();
            cbo_type = new ComboBox();
            btn_update = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            cbo_typeStock = new ComboBox();
            btn_import = new FontAwesome.Sharp.IconButton();
            linkLabel1 = new LinkLabel();
            btn_export = new FontAwesome.Sharp.IconButton();
            label7 = new Label();
            tb_index = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtg_stocks).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 12);
            label1.Margin = new Padding(10, 10, 0, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 43);
            label2.Margin = new Padding(10, 10, 0, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 19);
            label2.TabIndex = 9;
            label2.Text = "Route:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(214, 13);
            label4.Margin = new Padding(10, 10, 0, 0);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 11;
            label4.Text = "MarkID:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(178, 43);
            label5.Margin = new Padding(10, 10, 0, 0);
            label5.Name = "label5";
            label5.Size = new Size(108, 19);
            label5.TabIndex = 12;
            label5.Text = "End MarkID:";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(362, 42);
            label6.Margin = new Padding(10, 10, 0, 0);
            label6.Name = "label6";
            label6.Size = new Size(54, 19);
            label6.TabIndex = 16;
            label6.Text = "Type:";
            // 
            // dtg_stocks
            // 
            dtg_stocks.AllowUserToDeleteRows = false;
            dtg_stocks.AllowUserToOrderColumns = true;
            dtg_stocks.AllowUserToResizeRows = false;
            dtg_stocks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtg_stocks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.LightSkyBlue;
            dataGridViewCellStyle5.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dtg_stocks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dtg_stocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_stocks.Columns.AddRange(new DataGridViewColumn[] { id, index, name, route, markId, endMarkId, typeStock, type, prodNo, status, delete });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dtg_stocks.DefaultCellStyle = dataGridViewCellStyle6;
            dtg_stocks.Location = new Point(10, 81);
            dtg_stocks.Margin = new Padding(10);
            dtg_stocks.Name = "dtg_stocks";
            dtg_stocks.RowHeadersVisible = false;
            dtg_stocks.Size = new Size(930, 449);
            dtg_stocks.TabIndex = 20;
            dtg_stocks.CellClick += dtg_stocks_CellClick;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            id.DataPropertyName = "id";
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Resizable = DataGridViewTriState.False;
            id.Width = 50;
            // 
            // index
            // 
            index.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            index.DataPropertyName = "index";
            index.HeaderText = "IDX";
            index.Name = "index";
            index.ReadOnly = true;
            index.Resizable = DataGridViewTriState.False;
            index.Width = 60;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.DataPropertyName = "name";
            name.HeaderText = "NAME";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // route
            // 
            route.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            route.DataPropertyName = "route";
            route.HeaderText = "ROUTE";
            route.Name = "route";
            route.ReadOnly = true;
            route.Resizable = DataGridViewTriState.False;
            route.Width = 60;
            // 
            // markId
            // 
            markId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            markId.DataPropertyName = "markId";
            markId.HeaderText = "MARK";
            markId.Name = "markId";
            markId.ReadOnly = true;
            markId.Resizable = DataGridViewTriState.False;
            markId.Width = 60;
            // 
            // endMarkId
            // 
            endMarkId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            endMarkId.DataPropertyName = "endMarkId";
            endMarkId.HeaderText = "END MARK";
            endMarkId.Name = "endMarkId";
            endMarkId.ReadOnly = true;
            endMarkId.Resizable = DataGridViewTriState.False;
            endMarkId.Width = 60;
            // 
            // typeStock
            // 
            typeStock.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            typeStock.DataPropertyName = "typeStock";
            typeStock.HeaderText = "STOCK";
            typeStock.Name = "typeStock";
            typeStock.ReadOnly = true;
            typeStock.Resizable = DataGridViewTriState.False;
            typeStock.Width = 60;
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
            // prodNo
            // 
            prodNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            prodNo.DataPropertyName = "prodNo";
            prodNo.HeaderText = "CODE";
            prodNo.Name = "prodNo";
            prodNo.ReadOnly = true;
            prodNo.Resizable = DataGridViewTriState.True;
            // 
            // status
            // 
            status.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            status.DataPropertyName = "status";
            status.HeaderText = "STATUS";
            status.Name = "status";
            status.ReadOnly = true;
            status.Resizable = DataGridViewTriState.False;
            status.Width = 75;
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
            // btn_add
            // 
            btn_add.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_add.Cursor = Cursors.Hand;
            btn_add.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btn_add.IconColor = Color.Black;
            btn_add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_add.IconSize = 24;
            btn_add.Location = new Point(784, 10);
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
            tb_name.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_name.Location = new Point(76, 10);
            tb_name.Margin = new Padding(3, 10, 3, 3);
            tb_name.Name = "tb_name";
            tb_name.Size = new Size(100, 26);
            tb_name.TabIndex = 22;
            // 
            // tb_route
            // 
            tb_route.BorderStyle = BorderStyle.FixedSingle;
            tb_route.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_route.Location = new Point(76, 41);
            tb_route.Margin = new Padding(3, 10, 3, 3);
            tb_route.Name = "tb_route";
            tb_route.Size = new Size(100, 26);
            tb_route.TabIndex = 23;
            // 
            // tb_endMarkId
            // 
            tb_endMarkId.BorderStyle = BorderStyle.FixedSingle;
            tb_endMarkId.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_endMarkId.Location = new Point(289, 41);
            tb_endMarkId.Margin = new Padding(3, 10, 3, 3);
            tb_endMarkId.Name = "tb_endMarkId";
            tb_endMarkId.Size = new Size(53, 26);
            tb_endMarkId.TabIndex = 25;
            // 
            // tb_markId
            // 
            tb_markId.BorderStyle = BorderStyle.FixedSingle;
            tb_markId.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_markId.Location = new Point(289, 10);
            tb_markId.Margin = new Padding(3, 10, 3, 3);
            tb_markId.Name = "tb_markId";
            tb_markId.Size = new Size(53, 26);
            tb_markId.TabIndex = 24;
            // 
            // cbo_type
            // 
            cbo_type.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbo_type.FormattingEnabled = true;
            cbo_type.Items.AddRange(new object[] { "LH", "RH" });
            cbo_type.Location = new Point(419, 40);
            cbo_type.Margin = new Padding(3, 10, 3, 3);
            cbo_type.Name = "cbo_type";
            cbo_type.Size = new Size(72, 27);
            cbo_type.TabIndex = 26;
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
            btn_update.Location = new Point(865, 10);
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
            label3.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(353, 12);
            label3.Margin = new Padding(10, 10, 0, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 19);
            label3.TabIndex = 28;
            label3.Text = "Stock:";
            // 
            // cbo_typeStock
            // 
            cbo_typeStock.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbo_typeStock.FormattingEnabled = true;
            cbo_typeStock.Items.AddRange(new object[] { "FG", "Trolley " });
            cbo_typeStock.Location = new Point(419, 9);
            cbo_typeStock.Margin = new Padding(3, 10, 3, 3);
            cbo_typeStock.Name = "cbo_typeStock";
            cbo_typeStock.Size = new Size(72, 27);
            cbo_typeStock.TabIndex = 29;
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
            btn_import.Location = new Point(703, 10);
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
            btn_export.Location = new Point(622, 10);
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
            label7.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(504, 13);
            label7.Margin = new Padding(10, 10, 0, 0);
            label7.Name = "label7";
            label7.Size = new Size(45, 19);
            label7.TabIndex = 33;
            label7.Text = "Idx:";
            // 
            // tb_index
            // 
            tb_index.BorderStyle = BorderStyle.FixedSingle;
            tb_index.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_index.Location = new Point(552, 10);
            tb_index.Margin = new Padding(3, 10, 3, 3);
            tb_index.Name = "tb_index";
            tb_index.Size = new Size(53, 26);
            tb_index.TabIndex = 34;
            // 
            // V_Stocks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tb_index);
            Controls.Add(label7);
            Controls.Add(btn_export);
            Controls.Add(linkLabel1);
            Controls.Add(btn_import);
            Controls.Add(cbo_typeStock);
            Controls.Add(label3);
            Controls.Add(btn_update);
            Controls.Add(cbo_type);
            Controls.Add(tb_endMarkId);
            Controls.Add(tb_markId);
            Controls.Add(tb_route);
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
        private TextBox tb_route;
        private TextBox tb_endMarkId;
        private TextBox tb_markId;
        private ComboBox cbo_type;
        private FontAwesome.Sharp.IconButton btn_update;
        private Label label3;
        private ComboBox cbo_typeStock;
        private FontAwesome.Sharp.IconButton btn_import;
        private LinkLabel linkLabel1;
        private FontAwesome.Sharp.IconButton btn_export;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn index;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn route;
        private DataGridViewTextBoxColumn markId;
        private DataGridViewTextBoxColumn endMarkId;
        private DataGridViewTextBoxColumn typeStock;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn prodNo;
        private DataGridViewTextBoxColumn status;
        private DataGridViewLinkColumn delete;
        private Label label7;
        private TextBox tb_index;
    }
}
