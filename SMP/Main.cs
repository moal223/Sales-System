using SMP.PL.Categories;
using SMP.PL.Customers;
using SMP.PL.Purchases;
using SMP.PL.Sell;
using SMP.PL.Suppliers;

namespace SMP
{
    public partial class Main : Form
    {
        PL.Categories.Cat_UserControl uc_cat;
        PL.Suppliers.Suppliers_UserControl uc_suppliers;
        PL.Purchases.Purchase_UserControl uc_purchases;
        PL.Customers.Customers_UserControl uc_customers;
        PL.Sell.Sell_UserControl uc_selloper;
        PL.Reports.Reports_UserControl uc_reports;
        PL.Home.Home_UserControl uc_home;
        public Main(Cat_UserControl uc_cat, Customers_UserControl uc_customers, Purchase_UserControl uc_purchases,
            Suppliers_UserControl uc_suppliers, Sell_UserControl uc_selloper, PL.Reports.Reports_UserControl uc_reports, PL.Home.Home_UserControl uc_home)
        {
            InitializeComponent();

            this.uc_cat = uc_cat;
            this.uc_customers = uc_customers;
            this.uc_purchases = uc_purchases;
            this.uc_suppliers = uc_suppliers;
            this.uc_selloper = uc_selloper;
            this.uc_reports = uc_reports;
            this.uc_home = uc_home;
        }

        private void btn_collapes_Click(object sender, EventArgs e)
        {
            if (pn_navbar.Width == 250)
                pn_navbar.Width = 70;
            else
                pn_navbar.Width = 250;
        }

        private void btn_cat_Click(object sender, EventArgs e)
        {
            ButtonColorChaningByClick(btn_cat, btn_home, button3, button4, button5, button6, button7, button9, button10);
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(uc_cat);
            lb_titlepage.Text = "«·«’‰«›";
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            ButtonColorChaningByClick(btn_home, btn_cat, button3, button4, button5, button6, button7, button9, button10);
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(uc_home);
            lb_titlepage.Text = "«·—∆Ì”ÌÂ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonColorChaningByClick(button3, btn_home, btn_cat, button4, button5, button6, button7, button9, button10);
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(uc_suppliers);
            lb_titlepage.Text = "«·„Ê—œÌ‰";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ButtonColorChaningByClick(button4, button3, btn_home, btn_cat, button5, button6, button7, button9, button10);
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(uc_purchases);
            lb_titlepage.Text = "«·„‘ —Ì« ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ButtonColorChaningByClick(button5, button3, btn_home, btn_cat, button4, button6, button7, button9, button10);
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(uc_customers);
            lb_titlepage.Text = "«·⁄„·«¡";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ButtonColorChaningByClick(button6, button3, btn_home, btn_cat, button4, button5, button7, button9, button10);
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(uc_selloper);
            lb_titlepage.Text = "«·„»Ì⁄« ";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ButtonColorChaningByClick(button7, button3, btn_home, btn_cat, button4, button5, button6, button9, button10);
            pn_cont.Controls.Clear();
            pn_cont.Controls.Add(uc_reports);
            lb_titlepage.Text = "«· ﬁ«—Ì—";
        }

        private void ButtonColorChaningByClick(Button btn1, Button btn2, Button btn3, Button btn4,
            Button btn5, Button btn6, Button btn7, Button btn8, Button btn9)
        {
            btn1.BackColor = Color.FromArgb(0, 122, 204);
            btn2.BackColor = Color.DarkSlateGray;
            btn3.BackColor = Color.DarkSlateGray;
            btn4.BackColor = Color.DarkSlateGray;
            btn5.BackColor = Color.DarkSlateGray;
            btn6.BackColor = Color.DarkSlateGray;
            btn7.BackColor = Color.DarkSlateGray;
            btn8.BackColor = Color.DarkSlateGray;
            btn9.BackColor = Color.DarkSlateGray;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ButtonColorChaningByClick(button9, button3, btn_home, btn_cat, button4, button5, button6, button7, button10);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ButtonColorChaningByClick(button10, button3, btn_home, btn_cat, button4, button5, button6, button7, button9);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            pn_cont.Controls.Add(uc_home);
            lb_titlepage.Text = "«·—∆Ì”ÌÂ";
        }
    }
}
