namespace SMP.PL.Customers
{
    partial class Customers_UserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers_UserControl));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel2 = new Panel();
            textBoxSearch = new TextBox();
            btn_search = new Button();
            btn_reloadCat = new Button();
            btn_modCat = new Button();
            btn_delCat = new Button();
            btn_addCat = new Button();
            dataGridView1 = new DataGridView();
            comboBoxDataSplit = new ComboBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(textBoxSearch);
            panel2.Controls.Add(btn_search);
            panel2.Controls.Add(btn_reloadCat);
            panel2.Controls.Add(btn_modCat);
            panel2.Controls.Add(btn_delCat);
            panel2.Controls.Add(btn_addCat);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 593);
            panel2.Margin = new Padding(4, 6, 4, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(1012, 103);
            panel2.TabIndex = 7;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxSearch.Font = new Font("Cairo Medium", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxSearch.Location = new Point(571, 26);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(341, 51);
            textBoxSearch.TabIndex = 3;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // btn_search
            // 
            btn_search.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_search.BackColor = SystemColors.Control;
            btn_search.FlatAppearance.BorderSize = 0;
            btn_search.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btn_search.FlatAppearance.MouseOverBackColor = Color.Gray;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Image = (Image)resources.GetObject("btn_search.Image");
            btn_search.Location = new Point(919, 26);
            btn_search.Margin = new Padding(4, 6, 4, 6);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(77, 51);
            btn_search.TabIndex = 2;
            btn_search.TextAlign = ContentAlignment.MiddleLeft;
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // btn_reloadCat
            // 
            btn_reloadCat.BackColor = Color.White;
            btn_reloadCat.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btn_reloadCat.FlatAppearance.MouseOverBackColor = Color.Gray;
            btn_reloadCat.FlatStyle = FlatStyle.Flat;
            btn_reloadCat.Image = (Image)resources.GetObject("btn_reloadCat.Image");
            btn_reloadCat.ImageAlign = ContentAlignment.MiddleRight;
            btn_reloadCat.Location = new Point(433, 21);
            btn_reloadCat.Margin = new Padding(4, 6, 4, 6);
            btn_reloadCat.Name = "btn_reloadCat";
            btn_reloadCat.Size = new Size(131, 56);
            btn_reloadCat.TabIndex = 0;
            btn_reloadCat.Text = "تحديث";
            btn_reloadCat.TextAlign = ContentAlignment.MiddleLeft;
            btn_reloadCat.UseVisualStyleBackColor = false;
            btn_reloadCat.Click += btn_reloadCat_Click;
            // 
            // btn_modCat
            // 
            btn_modCat.BackColor = Color.White;
            btn_modCat.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btn_modCat.FlatAppearance.MouseOverBackColor = Color.Gray;
            btn_modCat.FlatStyle = FlatStyle.Flat;
            btn_modCat.Image = (Image)resources.GetObject("btn_modCat.Image");
            btn_modCat.ImageAlign = ContentAlignment.MiddleRight;
            btn_modCat.Location = new Point(296, 21);
            btn_modCat.Margin = new Padding(4, 6, 4, 6);
            btn_modCat.Name = "btn_modCat";
            btn_modCat.Size = new Size(129, 56);
            btn_modCat.TabIndex = 0;
            btn_modCat.Text = "تعديل";
            btn_modCat.TextAlign = ContentAlignment.MiddleLeft;
            btn_modCat.UseVisualStyleBackColor = false;
            btn_modCat.Click += btn_modCat_Click;
            // 
            // btn_delCat
            // 
            btn_delCat.BackColor = Color.White;
            btn_delCat.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btn_delCat.FlatAppearance.MouseOverBackColor = Color.Gray;
            btn_delCat.FlatStyle = FlatStyle.Flat;
            btn_delCat.Image = (Image)resources.GetObject("btn_delCat.Image");
            btn_delCat.ImageAlign = ContentAlignment.MiddleRight;
            btn_delCat.Location = new Point(164, 21);
            btn_delCat.Margin = new Padding(4, 6, 4, 6);
            btn_delCat.Name = "btn_delCat";
            btn_delCat.Size = new Size(124, 56);
            btn_delCat.TabIndex = 0;
            btn_delCat.Text = "حذف";
            btn_delCat.TextAlign = ContentAlignment.MiddleLeft;
            btn_delCat.UseVisualStyleBackColor = false;
            btn_delCat.Click += btn_delCat_Click;
            // 
            // btn_addCat
            // 
            btn_addCat.BackColor = Color.White;
            btn_addCat.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btn_addCat.FlatAppearance.MouseOverBackColor = Color.Gray;
            btn_addCat.FlatStyle = FlatStyle.Flat;
            btn_addCat.Image = (Image)resources.GetObject("btn_addCat.Image");
            btn_addCat.ImageAlign = ContentAlignment.MiddleRight;
            btn_addCat.Location = new Point(32, 21);
            btn_addCat.Margin = new Padding(4, 6, 4, 6);
            btn_addCat.Name = "btn_addCat";
            btn_addCat.Size = new Size(124, 56);
            btn_addCat.TabIndex = 0;
            btn_addCat.Text = "اضافة ";
            btn_addCat.TextAlign = ContentAlignment.MiddleLeft;
            btn_addCat.UseVisualStyleBackColor = false;
            btn_addCat.Click += btn_addCat_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Cairo Medium", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(0, 0, 0, 6);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.RowTemplate.Resizable = DataGridViewTriState.True;
            dataGridView1.Size = new Size(1012, 593);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // comboBoxDataSplit
            // 
            comboBoxDataSplit.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBoxDataSplit.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDataSplit.FormattingEnabled = true;
            comboBoxDataSplit.Location = new Point(3, 512);
            comboBoxDataSplit.Name = "comboBoxDataSplit";
            comboBoxDataSplit.Size = new Size(151, 51);
            comboBoxDataSplit.TabIndex = 9;
            comboBoxDataSplit.SelectedIndexChanged += comboBoxDataSplit_SelectedIndexChanged;
            // 
            // Customers_UserControl
            // 
            AutoScaleDimensions = new SizeF(12F, 43F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(comboBoxDataSplit);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Font = new Font("Cairo Medium", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 6, 4, 6);
            Name = "Customers_UserControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1012, 696);
            Load += Cat_UserControl_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private TextBox textBoxSearch;
        private Button btn_search;
        private Button btn_reloadCat;
        private Button btn_modCat;
        private Button btn_delCat;
        private Button btn_addCat;
        private DataGridView dataGridView1;
        private ComboBox comboBoxDataSplit;
    }
}
