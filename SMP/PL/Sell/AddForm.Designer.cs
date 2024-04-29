namespace SMP.PL.Sell
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            label1 = new Label();
            btnAdd = new Button();
            groupBox1 = new GroupBox();
            linkLabelClient = new LinkLabel();
            linkLabelProduct = new LinkLabel();
            cmbClient = new ComboBox();
            cmbProductName = new ComboBox();
            label10 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            nudQuantity = new NumericUpDown();
            label3 = new Label();
            nudPrice = new NumericUpDown();
            label6 = new Label();
            label11 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label4 = new Label();
            lblQuantity = new Label();
            lblTPrice = new Label();
            lblTPricePerProduct = new Label();
            label5 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            btnPrint = new Button();
            btnDelete = new Button();
            btnReload = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(504, 53);
            label1.Name = "label1";
            label1.Size = new Size(106, 37);
            label1.TabIndex = 0;
            label1.Text = "اسم المنتج";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.White;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAdd.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
            btnAdd.ImageAlign = ContentAlignment.MiddleRight;
            btnAdd.Location = new Point(649, 516);
            btnAdd.Margin = new Padding(4, 6, 4, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(43, 56);
            btnAdd.TabIndex = 3;
            btnAdd.Tag = "اضافه";
            btnAdd.TextAlign = ContentAlignment.MiddleLeft;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(linkLabelClient);
            groupBox1.Controls.Add(linkLabelProduct);
            groupBox1.Controls.Add(cmbClient);
            groupBox1.Controls.Add(cmbProductName);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(623, 207);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات اساسيه";
            // 
            // linkLabelClient
            // 
            linkLabelClient.AutoSize = true;
            linkLabelClient.Location = new Point(330, 121);
            linkLabelClient.Name = "linkLabelClient";
            linkLabelClient.Size = new Size(78, 43);
            linkLabelClient.TabIndex = 7;
            linkLabelClient.TabStop = true;
            linkLabelClient.Text = "اضافه";
            linkLabelClient.LinkClicked += linkLabelClient_LinkClicked;
            // 
            // linkLabelProduct
            // 
            linkLabelProduct.AutoSize = true;
            linkLabelProduct.Location = new Point(330, 44);
            linkLabelProduct.Name = "linkLabelProduct";
            linkLabelProduct.Size = new Size(78, 43);
            linkLabelProduct.TabIndex = 7;
            linkLabelProduct.TabStop = true;
            linkLabelProduct.Text = "اضافه";
            linkLabelProduct.LinkClicked += linkLabelProduct_LinkClicked;
            // 
            // cmbClient
            // 
            cmbClient.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbClient.FormattingEnabled = true;
            cmbClient.Location = new Point(19, 122);
            cmbClient.Name = "cmbClient";
            cmbClient.Size = new Size(305, 45);
            cmbClient.TabIndex = 6;
            // 
            // cmbProductName
            // 
            cmbProductName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbProductName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cmbProductName.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbProductName.FormattingEnabled = true;
            cmbProductName.Location = new Point(19, 45);
            cmbProductName.Name = "cmbProductName";
            cmbProductName.Size = new Size(305, 45);
            cmbProductName.TabIndex = 6;
            cmbProductName.SelectedIndexChanged += cmbProductName_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(478, 52);
            label10.Name = "label10";
            label10.Size = new Size(29, 43);
            label10.TabIndex = 5;
            label10.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(535, 121);
            label2.Name = "label2";
            label2.Size = new Size(75, 37);
            label2.TabIndex = 0;
            label2.Text = "العميل";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(nudQuantity);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(nudPrice);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label7);
            groupBox2.Font = new Font("Cairo", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 261);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(623, 246);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "البيع ";
            // 
            // nudQuantity
            // 
            nudQuantity.DecimalPlaces = 2;
            nudQuantity.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudQuantity.Location = new Point(32, 158);
            nudQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.RightToLeft = RightToLeft.No;
            nudQuantity.Size = new Size(374, 45);
            nudQuantity.TabIndex = 4;
            nudQuantity.TextAlign = HorizontalAlignment.Center;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.ValueChanged += nudQuantity_ValueChanged;
            nudQuantity.KeyDown += nudQuantity_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cairo", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(507, 150);
            label3.Name = "label3";
            label3.Size = new Size(100, 53);
            label3.TabIndex = 2;
            label3.Text = "الكميه";
            // 
            // nudPrice
            // 
            nudPrice.DecimalPlaces = 2;
            nudPrice.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudPrice.Location = new Point(32, 62);
            nudPrice.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.RightToLeft = RightToLeft.No;
            nudPrice.Size = new Size(374, 45);
            nudPrice.TabIndex = 4;
            nudPrice.TextAlign = HorizontalAlignment.Center;
            nudPrice.ValueChanged += nudPrice_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cairo", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(479, 54);
            label6.Name = "label6";
            label6.Size = new Size(128, 53);
            label6.TabIndex = 2;
            label6.Text = "سعر البيع";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Red;
            label11.Location = new Point(488, 156);
            label11.Name = "label11";
            label11.Size = new Size(35, 53);
            label11.TabIndex = 5;
            label11.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(455, 54);
            label7.Name = "label7";
            label7.Size = new Size(35, 53);
            label7.TabIndex = 5;
            label7.Text = "*";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lblQuantity);
            panel1.Controls.Add(lblTPrice);
            panel1.Controls.Add(lblTPricePerProduct);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(708, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(641, 387);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(641, 87);
            panel2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cairo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(215, 17);
            label4.Name = "label4";
            label4.Size = new Size(195, 56);
            label4.TabIndex = 0;
            label4.Text = "تفاصيل المنتج";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Cairo", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.FromArgb(255, 128, 0);
            lblQuantity.Location = new Point(75, 177);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.RightToLeft = RightToLeft.No;
            lblQuantity.Size = new Size(54, 75);
            lblQuantity.TabIndex = 1;
            lblQuantity.Text = "0";
            // 
            // lblTPrice
            // 
            lblTPrice.AutoSize = true;
            lblTPrice.Font = new Font("Cairo", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTPrice.ForeColor = Color.Red;
            lblTPrice.Location = new Point(265, 303);
            lblTPrice.Name = "lblTPrice";
            lblTPrice.RightToLeft = RightToLeft.No;
            lblTPrice.Size = new Size(59, 81);
            lblTPrice.TabIndex = 1;
            lblTPrice.Text = "0";
            // 
            // lblTPricePerProduct
            // 
            lblTPricePerProduct.AutoSize = true;
            lblTPricePerProduct.Font = new Font("Cairo", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTPricePerProduct.ForeColor = Color.FromArgb(255, 128, 0);
            lblTPricePerProduct.Location = new Point(451, 177);
            lblTPricePerProduct.Name = "lblTPricePerProduct";
            lblTPricePerProduct.RightToLeft = RightToLeft.No;
            lblTPricePerProduct.Size = new Size(54, 75);
            lblTPricePerProduct.TabIndex = 1;
            lblTPricePerProduct.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cairo", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(40, 122);
            label5.Name = "label5";
            label5.Size = new Size(131, 70);
            label5.TabIndex = 0;
            label5.Text = "الكميه";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cairo", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.MenuHighlight;
            label8.Location = new Point(186, 236);
            label8.Name = "label8";
            label8.Size = new Size(224, 75);
            label8.TabIndex = 0;
            label8.Text = "السعر الكلى";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cairo", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(287, 122);
            label9.Name = "label9";
            label9.Size = new Size(327, 70);
            label9.TabIndex = 0;
            label9.Text = "السعر الكلى (للمنتج)";
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(708, 411);
            panel3.Name = "panel3";
            panel3.Size = new Size(641, 351);
            panel3.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 45;
            dataGridView1.Size = new Size(641, 351);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.White;
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnPrint.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.ForeColor = Color.FromArgb(0, 64, 0);
            btnPrint.Image = (Image)resources.GetObject("btnPrint.Image");
            btnPrint.ImageAlign = ContentAlignment.MiddleRight;
            btnPrint.Location = new Point(638, 638);
            btnPrint.Margin = new Padding(4, 6, 4, 6);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(62, 56);
            btnPrint.TabIndex = 3;
            btnPrint.TextAlign = ContentAlignment.MiddleLeft;
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.White;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.Red;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleRight;
            btnDelete.Location = new Point(638, 570);
            btnDelete.Margin = new Padding(4, 6, 4, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(63, 56);
            btnDelete.TabIndex = 3;
            btnDelete.TextAlign = ContentAlignment.MiddleLeft;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReload
            // 
            btnReload.BackColor = Color.White;
            btnReload.Cursor = Cursors.Hand;
            btnReload.FlatAppearance.BorderSize = 0;
            btnReload.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnReload.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnReload.FlatStyle = FlatStyle.Flat;
            btnReload.ForeColor = Color.CornflowerBlue;
            btnReload.Image = (Image)resources.GetObject("btnReload.Image");
            btnReload.ImageAlign = ContentAlignment.MiddleRight;
            btnReload.Location = new Point(638, 706);
            btnReload.Margin = new Padding(4, 6, 4, 6);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(61, 56);
            btnReload.TabIndex = 3;
            btnReload.TextAlign = ContentAlignment.MiddleLeft;
            btnReload.UseVisualStyleBackColor = false;
            btnReload.Click += btnReload_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(12F, 43F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1361, 774);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnReload);
            Controls.Add(btnPrint);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Font = new Font("Cairo Medium", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(4, 6, 4, 6);
            Name = "AddForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "عمليه بيع";
            Activated += AddForm_Activated;
            Load += AddForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnAdd;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label6;
        private TextBox txtSellPrice;
        private Panel panel1;
        private Label lblTPricePerProduct;
        private Label label9;
        private Label label10;
        private NumericUpDown nudPrice;
        private ComboBox cmbProductName;
        private LinkLabel linkLabelClient;
        private LinkLabel linkLabelProduct;
        private ComboBox cmbClient;
        private Label label2;
        private NumericUpDown nudQuantity;
        private Label label3;
        private Panel panel2;
        private Label label4;
        private Label lblQuantity;
        private Label label5;
        private Label lblTPrice;
        private Label label8;
        private Panel panel3;
        private Button btnPrint;
        private Button btnDelete;
        private Button btnReload;
        private Label label11;
        private Label label7;
        private DataGridView dataGridView1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}