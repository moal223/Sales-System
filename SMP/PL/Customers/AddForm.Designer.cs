namespace SMP.PL.Customers
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
            txtSupname = new TextBox();
            pictureBox1 = new PictureBox();
            btn_save = new Button();
            btn_saveClose = new Button();
            label2 = new Label();
            txtSupPhone = new TextBox();
            label3 = new Label();
            txtSupMail = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 42);
            label1.Name = "label1";
            label1.Size = new Size(130, 43);
            label1.TabIndex = 0;
            label1.Text = "اسم العميل";
            // 
            // txtSupname
            // 
            txtSupname.Location = new Point(181, 38);
            txtSupname.Name = "txtSupname";
            txtSupname.Size = new Size(339, 51);
            txtSupname.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(217, 293);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 203);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.White;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Image = (Image)resources.GetObject("btn_save.Image");
            btn_save.ImageAlign = ContentAlignment.MiddleRight;
            btn_save.Location = new Point(428, 540);
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
            btn_saveClose.Location = new Point(13, 540);
            btn_saveClose.Margin = new Padding(4, 6, 4, 6);
            btn_saveClose.Name = "btn_saveClose";
            btn_saveClose.Size = new Size(191, 56);
            btn_saveClose.TabIndex = 3;
            btn_saveClose.Text = "حفظ و غلق";
            btn_saveClose.TextAlign = ContentAlignment.MiddleLeft;
            btn_saveClose.UseVisualStyleBackColor = false;
            btn_saveClose.Click += btn_saveClose_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 116);
            label2.Name = "label2";
            label2.Size = new Size(123, 43);
            label2.TabIndex = 0;
            label2.Text = "رقم الهاتف";
            // 
            // txtSupPhone
            // 
            txtSupPhone.Location = new Point(182, 112);
            txtSupPhone.Name = "txtSupPhone";
            txtSupPhone.Size = new Size(339, 51);
            txtSupPhone.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 198);
            label3.Name = "label3";
            label3.Size = new Size(165, 43);
            label3.TabIndex = 0;
            label3.Text = "البريد الالكترونى";
            // 
            // txtSupMail
            // 
            txtSupMail.Location = new Point(182, 194);
            txtSupMail.Name = "txtSupMail";
            txtSupMail.Size = new Size(339, 51);
            txtSupMail.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(124, 46);
            label6.Name = "label6";
            label6.Size = new Size(29, 43);
            label6.TabIndex = 4;
            label6.Text = "*";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(12F, 43F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(572, 611);
            Controls.Add(label6);
            Controls.Add(btn_saveClose);
            Controls.Add(btn_save);
            Controls.Add(pictureBox1);
            Controls.Add(txtSupMail);
            Controls.Add(txtSupPhone);
            Controls.Add(txtSupname);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Cairo Medium", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 6, 4, 6);
            Name = "AddForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "اضافة صنف";
            Load += AddForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSupname;
        private PictureBox pictureBox1;
        private Button btn_save;
        private Button btn_saveClose;
        private Label label2;
        private TextBox txtSupPhone;
        private Label label3;
        private TextBox txtSupMail;
        private Label label6;
    }
}