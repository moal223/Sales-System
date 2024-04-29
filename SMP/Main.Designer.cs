namespace SMP
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            pn_navbar = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_home = new Button();
            btn_cat = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button9 = new Button();
            button10 = new Button();
            pn_headernav = new Panel();
            pn_titlenav = new Panel();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btn_collapes = new Button();
            label1 = new Label();
            pn_topbar = new Panel();
            lb_titlepage = new Label();
            pn_cont = new Panel();
            pn_navbar.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            pn_headernav.SuspendLayout();
            pn_titlenav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            pn_topbar.SuspendLayout();
            SuspendLayout();
            // 
            // pn_navbar
            // 
            pn_navbar.BackColor = Color.DarkSlateGray;
            pn_navbar.Controls.Add(flowLayoutPanel1);
            pn_navbar.Controls.Add(pn_headernav);
            pn_navbar.Dock = DockStyle.Right;
            pn_navbar.Location = new Point(1012, 0);
            pn_navbar.Name = "pn_navbar";
            pn_navbar.Size = new Size(250, 754);
            pn_navbar.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btn_home);
            flowLayoutPanel1.Controls.Add(btn_cat);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Controls.Add(button7);
            flowLayoutPanel1.Controls.Add(button9);
            flowLayoutPanel1.Controls.Add(button10);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 230);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 524);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btn_home
            // 
            btn_home.BackColor = Color.DarkSlateGray;
            btn_home.Cursor = Cursors.Hand;
            btn_home.FlatAppearance.BorderSize = 0;
            btn_home.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btn_home.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 122, 204);
            btn_home.FlatStyle = FlatStyle.Flat;
            btn_home.ForeColor = Color.Silver;
            btn_home.Image = (Image)resources.GetObject("btn_home.Image");
            btn_home.ImageAlign = ContentAlignment.MiddleLeft;
            btn_home.Location = new Point(3, 3);
            btn_home.Name = "btn_home";
            btn_home.Size = new Size(244, 51);
            btn_home.TabIndex = 0;
            btn_home.Text = "الرئيسيه";
            btn_home.UseVisualStyleBackColor = false;
            btn_home.Click += btn_home_Click;
            // 
            // btn_cat
            // 
            btn_cat.BackColor = Color.DarkSlateGray;
            btn_cat.Cursor = Cursors.Hand;
            btn_cat.FlatAppearance.BorderSize = 0;
            btn_cat.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btn_cat.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 122, 204);
            btn_cat.FlatStyle = FlatStyle.Flat;
            btn_cat.ForeColor = Color.Silver;
            btn_cat.Image = (Image)resources.GetObject("btn_cat.Image");
            btn_cat.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cat.Location = new Point(3, 60);
            btn_cat.Name = "btn_cat";
            btn_cat.Size = new Size(244, 51);
            btn_cat.TabIndex = 0;
            btn_cat.Text = "الاصناف";
            btn_cat.UseVisualStyleBackColor = false;
            btn_cat.Click += btn_cat_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSlateGray;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.DimGray;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 122, 204);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Silver;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(3, 117);
            button3.Name = "button3";
            button3.Size = new Size(244, 51);
            button3.TabIndex = 0;
            button3.Text = "الموردين";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkSlateGray;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.DimGray;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 122, 204);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Silver;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(3, 174);
            button4.Name = "button4";
            button4.Size = new Size(244, 51);
            button4.TabIndex = 0;
            button4.Text = "المشتريات";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkSlateGray;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.DimGray;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 122, 204);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.Silver;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(3, 231);
            button5.Name = "button5";
            button5.Size = new Size(244, 51);
            button5.TabIndex = 0;
            button5.Text = "العملاء";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DarkSlateGray;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.DimGray;
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 122, 204);
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.Silver;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(3, 288);
            button6.Name = "button6";
            button6.Size = new Size(244, 51);
            button6.TabIndex = 0;
            button6.Text = "المبيعات";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.DarkSlateGray;
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseDownBackColor = Color.DimGray;
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 122, 204);
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.Silver;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(3, 345);
            button7.Name = "button7";
            button7.Size = new Size(244, 51);
            button7.TabIndex = 0;
            button7.Text = "التقارير";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.DarkSlateGray;
            button9.Cursor = Cursors.Hand;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.MouseDownBackColor = Color.DimGray;
            button9.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 122, 204);
            button9.FlatStyle = FlatStyle.Flat;
            button9.ForeColor = Color.Silver;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(3, 402);
            button9.Name = "button9";
            button9.Size = new Size(244, 51);
            button9.TabIndex = 1;
            button9.Text = "المستخدمين";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.DarkSlateGray;
            button10.Cursor = Cursors.Hand;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 122, 204);
            button10.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 122, 204);
            button10.FlatStyle = FlatStyle.Flat;
            button10.ForeColor = Color.Silver;
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.Location = new Point(3, 459);
            button10.Name = "button10";
            button10.Size = new Size(244, 51);
            button10.TabIndex = 2;
            button10.Text = "الاعدادات";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // pn_headernav
            // 
            pn_headernav.BackColor = Color.DarkSlateGray;
            pn_headernav.Controls.Add(pn_titlenav);
            pn_headernav.Controls.Add(flowLayoutPanel2);
            pn_headernav.Dock = DockStyle.Top;
            pn_headernav.Location = new Point(0, 0);
            pn_headernav.Name = "pn_headernav";
            pn_headernav.Size = new Size(250, 230);
            pn_headernav.TabIndex = 0;
            // 
            // pn_titlenav
            // 
            pn_titlenav.Controls.Add(label4);
            pn_titlenav.Controls.Add(label3);
            pn_titlenav.Controls.Add(pictureBox1);
            pn_titlenav.Dock = DockStyle.Fill;
            pn_titlenav.Location = new Point(0, 0);
            pn_titlenav.Name = "pn_titlenav";
            pn_titlenav.Size = new Size(192, 230);
            pn_titlenav.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(128, 64, 64);
            label4.Location = new Point(33, 184);
            label4.Name = "label4";
            label4.Size = new Size(67, 43);
            label4.TabIndex = 1;
            label4.Text = "ادمن";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(23, 141);
            label3.Name = "label3";
            label3.Size = new Size(160, 43);
            label3.TabIndex = 2;
            label3.Text = "اسم المستخدم";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btn_collapes);
            flowLayoutPanel2.Dock = DockStyle.Right;
            flowLayoutPanel2.Location = new Point(192, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(58, 230);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // btn_collapes
            // 
            btn_collapes.BackColor = Color.DarkSlateGray;
            btn_collapes.Cursor = Cursors.Hand;
            btn_collapes.FlatAppearance.BorderColor = Color.DarkSlateGray;
            btn_collapes.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btn_collapes.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 122, 204);
            btn_collapes.FlatStyle = FlatStyle.Flat;
            btn_collapes.ForeColor = Color.FromArgb(45, 45, 45);
            btn_collapes.Image = (Image)resources.GetObject("btn_collapes.Image");
            btn_collapes.Location = new Point(0, 3);
            btn_collapes.Name = "btn_collapes";
            btn_collapes.Size = new Size(55, 49);
            btn_collapes.TabIndex = 1;
            btn_collapes.UseVisualStyleBackColor = false;
            btn_collapes.Click += btn_collapes_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(419, 2);
            label1.Name = "label1";
            label1.Size = new Size(91, 43);
            label1.TabIndex = 1;
            label1.Text = "الرٍئيسيه";
            // 
            // pn_topbar
            // 
            pn_topbar.BackColor = Color.DarkSlateGray;
            pn_topbar.Controls.Add(lb_titlepage);
            pn_topbar.Dock = DockStyle.Top;
            pn_topbar.Location = new Point(0, 0);
            pn_topbar.Name = "pn_topbar";
            pn_topbar.Size = new Size(1012, 58);
            pn_topbar.TabIndex = 4;
            // 
            // lb_titlepage
            // 
            lb_titlepage.Anchor = AnchorStyles.Top;
            lb_titlepage.AutoSize = true;
            lb_titlepage.ForeColor = Color.Silver;
            lb_titlepage.Location = new Point(505, 9);
            lb_titlepage.Name = "lb_titlepage";
            lb_titlepage.Size = new Size(91, 43);
            lb_titlepage.TabIndex = 0;
            lb_titlepage.Text = "الرئيسيه";
            // 
            // pn_cont
            // 
            pn_cont.BackColor = Color.White;
            pn_cont.Dock = DockStyle.Fill;
            pn_cont.Location = new Point(0, 58);
            pn_cont.Name = "pn_cont";
            pn_cont.Size = new Size(1012, 696);
            pn_cont.TabIndex = 5;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(12F, 43F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 45);
            ClientSize = new Size(1262, 754);
            Controls.Add(pn_cont);
            Controls.Add(pn_topbar);
            Controls.Add(pn_navbar);
            Font = new Font("Cairo Medium", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 6, 4, 6);
            Name = "Main";
            RightToLeft = RightToLeft.Yes;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SMP";
            Load += Main_Load;
            pn_navbar.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            pn_headernav.ResumeLayout(false);
            pn_titlenav.ResumeLayout(false);
            pn_titlenav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            pn_topbar.ResumeLayout(false);
            pn_topbar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_navbar;
        private Label label1;
        private Panel pn_headernav;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_home;
        private Button btn_cat;
        private Button button3;
        private Button btn_collapes;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button9;
        private Button button10;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel pn_titlenav;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel pn_topbar;
        private Label lb_titlepage;
        private Panel pn_cont;
    }
}
