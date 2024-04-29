namespace SMP.PL.Reports
{
    partial class Reports_UserControl
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_sellReport = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btn_sellReport);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1012, 696);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // btn_sellReport
            // 
            btn_sellReport.BackColor = Color.White;
            btn_sellReport.Cursor = Cursors.Hand;
            btn_sellReport.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaption;
            btn_sellReport.FlatAppearance.MouseOverBackColor = SystemColors.GradientActiveCaption;
            btn_sellReport.FlatStyle = FlatStyle.Flat;
            btn_sellReport.Font = new Font("Cairo Medium", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_sellReport.ImageAlign = ContentAlignment.MiddleRight;
            btn_sellReport.Location = new Point(609, 20);
            btn_sellReport.Margin = new Padding(20);
            btn_sellReport.Name = "btn_sellReport";
            btn_sellReport.Size = new Size(383, 196);
            btn_sellReport.TabIndex = 2;
            btn_sellReport.Text = " تقرير المبيعات";
            btn_sellReport.UseVisualStyleBackColor = false;
            btn_sellReport.Click += btn_sellReport_Click;
            // 
            // Reports_UserControl
            // 
            AutoScaleDimensions = new SizeF(12F, 43F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Cairo Medium", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 6, 4, 6);
            Name = "Reports_UserControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1012, 696);
            Load += Cat_UserControl_Load;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_sellReport;
    }
}
