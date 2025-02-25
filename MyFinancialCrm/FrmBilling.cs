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
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmBilling_Load(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtBillPeriod.Text;

            Bills bills = new Bills();
            bills.BillTitle = title;
            bills.BillAmount = amount;
            bills.BillPeriod = period;
            db.Bills.Add(bills);
            db.SaveChanges();
            MessageBox.Show("Yeni ödeme başarılı şekilde eklendi!","Ödeme & Faturalar",MessageBoxButtons.OK,MessageBoxIcon.Information);

            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;

            txtBillTitle.Text = "";
            txtBillAmount.Text = "";
            txtBillPeriod.Text = "";
        }

        private void btnRemoveBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillId.Text);
            var removebill = db.Bills.Find(id);
            string billtitle = removebill.BillTitle;
            db.Bills.Remove(removebill);
            db.SaveChanges();
            MessageBox.Show(billtitle + " adlı ödeme başarılı şekilde silindi!", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;

            txtBillId.Text = "";
            txtBillTitle.Text = "";
            txtBillAmount.Text = "";
            txtBillPeriod.Text = "";


        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            string title = txtBillTitle.Text;
            string period = txtBillPeriod.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);

            int id = int.Parse(txtBillId.Text);
            var updatebill = db.Bills.Find(id);
            updatebill.BillTitle = title;
            updatebill.BillAmount = amount;
            updatebill.BillPeriod = period;
            db.SaveChanges();
            MessageBox.Show(id + ". id'li Ödeme başarılı şekilde güncellendi!", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;

            txtBillId.Text = "";
            txtBillTitle.Text = "";
            txtBillAmount.Text = "";
            txtBillPeriod.Text = "";
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();

            

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            FrmCategory frmCategory = new FrmCategory();
            frmCategory.Show();
            this.Hide();
        }

        private void btnSpendingForm_Click(object sender, EventArgs e)
        {
            FrmSpending frmSpending = new FrmSpending();
            frmSpending.Show();
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
