namespace SMP.PL.Categories
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
            txtCatname = new TextBox();
            pictureBox1 = new PictureBox();
            btn_save = new Button();
            btn_saveClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 43);
            label1.TabIndex = 0;
            label1.Text = "اسم الصنف";
            // 
            // txtCatname
            // 
            txtCatname.Location = new Point(55, 55);
            txtCatname.Name = "txtCatname";
            txtCatname.Size = new Size(339, 51);
            txtCatname.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(122, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 210);
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
            btn_save.Location = new Point(294, 410);
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
            btn_saveClose.Location = new Point(13, 410);
            btn_saveClose.Margin = new Padding(4, 6, 4, 6);
            btn_saveClose.Name = "btn_saveClose";
            btn_saveClose.Size = new Size(191, 56);
            btn_saveClose.TabIndex = 3;
            btn_saveClose.Text = "حفظ و غلق";
            btn_saveClose.TextAlign = ContentAlignment.MiddleLeft;
            btn_saveClose.UseVisualStyleBackColor = false;
            btn_saveClose.Click += btn_saveClose_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(12F, 43F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(438, 481);
            Controls.Add(btn_saveClose);
            Controls.Add(btn_save);
            Controls.Add(pictureBox1);
            Controls.Add(txtCatname);
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
        private TextBox txtCatname;
        private PictureBox pictureBox1;
        private Button btn_save;
        private Button btn_saveClose;
    }
}