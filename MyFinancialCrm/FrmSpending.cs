using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyFinancialCrm.Models;


namespace MyFinancialCrm
{
    public partial class FrmSpending : Form
    {
        public FrmSpending()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmSpending_Load(object sender, EventArgs e)
        {
            var totalspending = db.Spendings.Sum(x => x.SpendingAmount);
            lblTotalSpending.Text = totalspending.ToString() + " ₺";

            var avgspending = db.Spendings.Average(x => x.SpendingAmount);
            lblAvgSpending.Text = db.Spendings.Average(x => (decimal)x.SpendingAmount).ToString("N2") + " ₺";

            var maxspending = db.Spendings.Max(x => x.SpendingAmount);
            lblMaxSpending.Text = maxspending.ToString() + " ₺";
            var maxspendingtitle = db.Spendings.Where(x => x.SpendingAmount == maxspending).Select(x => x.SpendingTitle).FirstOrDefault();
            lblSpendingMaxTotalName.Text = maxspendingtitle;


        }

        private void btnSpendingList_Click(object sender, EventArgs e)
        {
            var values = (from s in db.Spendings join c in db.Categories on s.CategoryId equals c.CategoryId
                          select new
                          {
                              
                              s.SpendingTitle,
                              s.SpendingAmount,
                              s.SpendingDate,
                              CategoryName = c.CategoryName // CategoryId yerine CategoryName
                          }).ToList();

            dataGridView1.DataSource = values;

        }

        private void btnSpendingRecentDate_Click(object sender, EventArgs e)
        {
            /*var RecentDate = db.Spendings.OrderByDescending(x => x.SpendingDate).ToList();
            dataGridView1.DataSource = RecentDate;*/
            var RecentDate = (from s in db.Spendings join c in db.Categories on s.CategoryId equals c.CategoryId
                              orderby s.SpendingDate descending
                              select new
                              {
                                  s.SpendingTitle,
                                  s.SpendingAmount,
                                  s.SpendingDate,
                                  CategoryName = c.CategoryName
                              }).ToList();
            dataGridView1.DataSource = RecentDate;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            var descendingmaxtotal = (from s in db.Spendings join c in db.Categories on s.CategoryId equals c.CategoryId
                                      orderby s.SpendingAmount descending
                                      select new
                                      {
                                          s.SpendingTitle,
                                          s.SpendingAmount,
                                          s.SpendingDate,
                                          CategoryName = c.CategoryName
                                      }).ToList();
            dataGridView1.DataSource = descendingmaxtotal;
        }

        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory();
            frm.Show();
            this.Hide();
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();
        }

        private void btnBillsForm_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
            this.Hide();
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void btnBankProcessForm_Click(object sender, EventArgs e)
        {
            FrmBankProcess frmBankProcess = new FrmBankProcess();
            frmBankProcess.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void btnUserSettingsForm_Click(object sender, EventArgs e)
        {
            FrmUserSettings frmUserSettings = new FrmUserSettings();
            frmUserSettings.Show();
            this.Hide();
        }
    }
}
