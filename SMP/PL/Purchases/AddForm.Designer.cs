namespace SMP.PL.Purchases
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
            txtProductName = new TextBox();
            btn_save = new Button();
            btn_saveClose = new Button();
            groupBox1 = new GroupBox();
            label10 = new Label();
            txtDetails = new RichTextBox();
            comboBoxSup = new ComboBox();
            comboBoxCat = new ComboBox();
            linkLabelAddSup = new LinkLabel();
            linkLabelAddCat = new LinkLabel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtType = new TextBox();
            groupBox2 = new GroupBox();
            nudSelling = new NumericUpDown();
            nudPurchase = new NumericUpDown();
            nudQuantity = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            lblProfit = new Label();
            lblSelling = new Label();
            label13 = new Label();
            label11 = new Label();
            lblPurchases = new Label();
            label9 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSelling).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPurchase).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(568, 53);
            label1.Name = "label1";
            label1.Size = new Size(106, 37);
            label1.TabIndex = 0;
            label1.Text = "اسم المنتج";
            // 
            // txtProductName
            // 
            txtProductName.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtProductName.Location = new Point(6, 53);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(374, 45);
            txtProductName.TabIndex = 1;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.White;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Image = (Image)resources.GetObject("btn_save.Image");
            btn_save.ImageAlign = ContentAlignment.MiddleRight;
            btn_save.Location = new Point(708, 681);
            btn_save.Margin = new Padding(4, 6, 4, 6);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(131, 56);
            btn_save.TabIndex = 3;
            btn_save.Text = "حفظ";
            btn_save.TextAlign = ContentAlignment.MiddleLeft;
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // btn_saveClose
            // 
            btn_saveClose.BackColor = Color.White;
            btn_saveClose.FlatStyle = FlatStyle.Flat;
            btn_saveClose.Image = (Image)resources.GetObject("btn_saveClose.Image");
            btn_saveClose.ImageAlign = ContentAlignment.MiddleRight;
            btn_saveClose.Location = new Point(1158, 681);
            btn_saveClose.Margin = new Padding(4, 6, 4, 6);
            btn_saveClose.Name = "btn_saveClose";
            btn_saveClose.Size = new Size(191, 56);
            btn_saveClose.TabIndex = 3;
            btn_saveClose.Text = "حفظ و غلق";
            btn_saveClose.TextAlign = ContentAlignment.MiddleLeft;
            btn_saveClose.UseVisualStyleBackColor = false;
            btn_saveClose.Click += btn_saveClose_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtDetails);
            groupBox1.Controls.Add(comboBoxSup);
            groupBox1.Controls.Add(comboBoxCat);
            groupBox1.Controls.Add(linkLabelAddSup);
            groupBox1.Controls.Add(linkLabelAddCat);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtType);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(680, 473);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات اساسيه";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(533, 52);
            label10.Name = "label10";
            label10.Size = new Size(29, 43);
            label10.TabIndex = 5;
            label10.Text = "*";
            // 
            // txtDetails
            // 
            txtDetails.BorderStyle = BorderStyle.FixedSingle;
            txtDetails.Font = new Font("Cairo", 12F);
            txtDetails.Location = new Point(6, 305);
            txtDetails.Name = "txtDetails";
            txtDetails.Size = new Size(517, 152);
            txtDetails.TabIndex = 4;
            txtDetails.Text = "";
            // 
            // comboBoxSup
            // 
            comboBoxSup.Font = new Font("Cairo", 12F);
            comboBoxSup.FormattingEnabled = true;
            comboBoxSup.Location = new Point(6, 244);
            comboBoxSup.Name = "comboBoxSup";
            comboBoxSup.Size = new Size(374, 45);
            comboBoxSup.TabIndex = 3;
            // 
            // comboBoxCat
            // 
            comboBoxCat.Font = new Font("Cairo", 12F);
            comboBoxCat.FormattingEnabled = true;
            comboBoxCat.Location = new Point(6, 174);
            comboBoxCat.Name = "comboBoxCat";
            comboBoxCat.Size = new Size(374, 45);
            comboBoxCat.TabIndex = 3;
            // 
            // linkLabelAddSup
            // 
            linkLabelAddSup.AutoSize = true;
            linkLabelAddSup.Location = new Point(386, 241);
            linkLabelAddSup.Name = "linkLabelAddSup";
            linkLabelAddSup.Size = new Size(78, 43);
            linkLabelAddSup.TabIndex = 2;
            linkLabelAddSup.TabStop = true;
            linkLabelAddSup.Text = "اضافه";
            linkLabelAddSup.LinkClicked += linkLabelAddSup_LinkClicked;
            // 
            // linkLabelAddCat
            // 
            linkLabelAddCat.AutoSize = true;
            linkLabelAddCat.Location = new Point(386, 177);
            linkLabelAddCat.Name = "linkLabelAddCat";
            linkLabelAddCat.Size = new Size(78, 43);
            linkLabelAddCat.TabIndex = 2;
            linkLabelAddCat.TabStop = true;
            linkLabelAddCat.Text = "اضافه";
            linkLabelAddCat.LinkClicked += linkLabelAddCat_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cairo", 12F);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(581, 308);
            label5.Name = "label5";
            label5.Size = new Size(77, 37);
            label5.TabIndex = 0;
            label5.Text = "تفاصيل";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cairo", 12F);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(584, 247);
            label4.Name = "label4";
            label4.Size = new Size(69, 37);
            label4.TabIndex = 0;
            label4.Text = "المورد";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cairo", 12F);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(581, 177);
            label3.Name = "label3";
            label3.Size = new Size(72, 37);
            label3.TabIndex = 0;
            label3.Text = "الصنف";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cairo", 12F);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(596, 118);
            label2.Name = "label2";
            label2.Size = new Size(57, 37);
            label2.TabIndex = 0;
            label2.Text = "النوع";
            // 
            // txtType
            // 
            txtType.Font = new Font("Cairo", 12F);
            txtType.Location = new Point(6, 115);
            txtType.Name = "txtType";
            txtType.Size = new Size(374, 45);
            txtType.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(nudSelling);
            groupBox2.Controls.Add(nudPurchase);
            groupBox2.Controls.Add(nudQuantity);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(12, 491);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(680, 246);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "البيع و الشراء";
            // 
            // nudSelling
            // 
            nudSelling.DecimalPlaces = 1;
            nudSelling.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudSelling.Location = new Point(11, 106);
            nudSelling.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudSelling.Name = "nudSelling";
            nudSelling.RightToLeft = RightToLeft.No;
            nudSelling.Size = new Size(374, 45);
            nudSelling.TabIndex = 4;
            nudSelling.TextAlign = HorizontalAlignment.Center;
            nudSelling.ValueChanged += nudSelling_ValueChanged;
            // 
            // nudPurchase
            // 
            nudPurchase.DecimalPlaces = 1;
            nudPurchase.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudPurchase.Location = new Point(11, 46);
            nudPurchase.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudPurchase.Name = "nudPurchase";
            nudPurchase.RightToLeft = RightToLeft.No;
            nudPurchase.Size = new Size(374, 45);
            nudPurchase.TabIndex = 4;
            nudPurchase.TextAlign = HorizontalAlignment.Center;
            nudPurchase.ValueChanged += nudPurchase_ValueChanged;
            // 
            // nudQuantity
            // 
            nudQuantity.DecimalPlaces = 1;
            nudQuantity.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudQuantity.Location = new Point(11, 165);
            nudQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.RightToLeft = RightToLeft.No;
            nudQuantity.Size = new Size(374, 45);
            nudQuantity.TabIndex = 4;
            nudQuantity.TextAlign = HorizontalAlignment.Center;
            nudQuantity.ValueChanged += nudQuantity_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cairo", 12F);
            label8.ForeColor = SystemColors.ControlDarkDark;
            label8.Location = new Point(585, 165);
            label8.Name = "label8";
            label8.Size = new Size(73, 37);
            label8.TabIndex = 2;
            label8.Text = "الكميه";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cairo", 12F);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(525, 108);
            label7.Name = "label7";
            label7.Size = new Size(149, 37);
            label7.TabIndex = 2;
            label7.Text = "سعر البيع (مفرد)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cairo", 12F);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(511, 54);
            label6.Name = "label6";
            label6.Size = new Size(163, 37);
            label6.TabIndex = 2;
            label6.Text = "سعر الشراء (مفرد)";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblProfit);
            panel1.Controls.Add(lblSelling);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(lblPurchases);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(708, 119);
            panel1.Name = "panel1";
            panel1.Size = new Size(641, 452);
            panel1.TabIndex = 6;
            // 
            // lblProfit
            // 
            lblProfit.AutoSize = true;
            lblProfit.Font = new Font("Cairo", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProfit.ForeColor = Color.FromArgb(255, 128, 0);
            lblProfit.Location = new Point(281, 325);
            lblProfit.Name = "lblProfit";
            lblProfit.RightToLeft = RightToLeft.No;
            lblProfit.Size = new Size(59, 81);
            lblProfit.TabIndex = 1;
            lblProfit.Text = "0";
            // 
            // lblSelling
            // 
            lblSelling.AutoSize = true;
            lblSelling.Font = new Font("Cairo", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelling.ForeColor = Color.FromArgb(255, 128, 0);
            lblSelling.Location = new Point(281, 192);
            lblSelling.Name = "lblSelling";
            lblSelling.RightToLeft = RightToLeft.No;
            lblSelling.Size = new Size(59, 81);
            lblSelling.TabIndex = 1;
            lblSelling.Text = "0";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Cairo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ControlDarkDark;
            label13.Location = new Point(227, 274);
            label13.Name = "label13";
            label13.Size = new Size(168, 56);
            label13.TabIndex = 0;
            label13.Text = "اجمالى الربح";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Cairo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = SystemColors.ControlDarkDark;
            label11.Location = new Point(157, 142);
            label11.Name = "label11";
            label11.Size = new Size(298, 56);
            label11.TabIndex = 0;
            label11.Text = "المبيعات (السعر الكلى)";
            // 
            // lblPurchases
            // 
            lblPurchases.AutoSize = true;
            lblPurchases.Font = new Font("Cairo", 25.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPurchases.ForeColor = Color.FromArgb(255, 128, 0);
            lblPurchases.Location = new Point(281, 67);
            lblPurchases.Name = "lblPurchases";
            lblPurchases.RightToLeft = RightToLeft.No;
            lblPurchases.Size = new Size(59, 81);
            lblPurchases.TabIndex = 1;
            lblPurchases.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cairo", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(154, 23);
            label9.Name = "label9";
            label9.Size = new Size(315, 56);
            label9.TabIndex = 0;
            label9.Text = "المشتريات (السعر الكلى)";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(12F, 43F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1361, 770);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btn_saveClose);
            Controls.Add(btn_save);
            Font = new Font("Cairo Medium", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 6, 4, 6);
            Name = "AddForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اضافة صنف";
            Activated += AddForm_Activated;
            Load += AddForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSelling).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPurchase).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtProductName;
        private Button btn_save;
        private Button btn_saveClose;
        private GroupBox groupBox1;
        private LinkLabel linkLabelAddCat;
        private Label label3;
        private Label label2;
        private TextBox txtType;
        private RichTextBox txtDetails;
        private ComboBox comboBoxSup;
        private ComboBox comboBoxCat;
        private LinkLabel linkLabelAddSup;
        private Label label5;
        private Label label4;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private TextBox txtSellPrice;
        private NumericUpDown nudQuantity;
        private Label label8;
        private Panel panel1;
        private Label lblPurchases;
        private Label label9;
        private Label lblProfit;
        private Label lblSelling;
        private Label label13;
        private Label label11;
        private Label label10;
        private NumericUpDown nudPurchase;
        private NumericUpDown nudSelling;
    }
}