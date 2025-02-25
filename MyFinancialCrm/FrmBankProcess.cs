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
    public partial class FrmBankProcess : Form
    {
        public FrmBankProcess()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void FrmBankProcess_Load(object sender, EventArgs e)
        {
            var bankProcesses1 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(1).FirstOrDefault();
            lblBankProcess1.Text = bankProcesses1.Description + " " + bankProcesses1.Amount + " ₺ " + Convert.ToDateTime(bankProcesses1.ProcessDate).ToString("dd/MM/yyyy");

            var bankProcesses2 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(2).Skip(1).FirstOrDefault();
            lblBankProcess2.Text = bankProcesses2.Description + " " + bankProcesses2.Amount + " ₺" + " " + Convert.ToDateTime(bankProcesses2.ProcessDate).ToString("dd/MM/yyyy");

            var bankProcesses3 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(3).Skip(2).FirstOrDefault();
            lblBankProcess3.Text = bankProcesses3.Description + " " + bankProcesses3.Amount + " ₺" + " " + Convert.ToDateTime(bankProcesses3.ProcessDate).ToString("dd/MM/yyyy");

            var bankProcesses4 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(4).Skip(3).FirstOrDefault();
            lblBankProcess4.Text = bankProcesses4.Description + " " + bankProcesses4.Amount + " ₺" + " " + Convert.ToDateTime(bankProcesses4.ProcessDate).ToString("dd/MM/yyyy");

            var bankProcesses5 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(5).Skip(4).FirstOrDefault();
            lblBankProcess5.Text = bankProcesses5.Description + " " + bankProcesses5.Amount + " ₺" + " " + Convert.ToDateTime(bankProcesses5.ProcessDate).ToString("dd/MM/yyyy");

            var bankProcesses6 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(6).Skip(5).FirstOrDefault();
            lblBankProcess6.Text = bankProcesses6.Description + " " + bankProcesses6.Amount + " ₺" + " " + Convert.ToDateTime(bankProcesses6.ProcessDate).ToString("dd/MM/yyyy");

            var bankProcesses7 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(7).Skip(6).FirstOrDefault();
            lblBankProcess7.Text = bankProcesses7.Description + " " + bankProcesses7.Amount + " ₺" + " " + Convert.ToDateTime(bankProcesses7.ProcessDate).ToString("dd/MM/yyyy");

            var bankProcesses8 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(8).Skip(7).FirstOrDefault();
            lblBankProcess8.Text = bankProcesses8.Description + " " + bankProcesses8.Amount + " ₺" + " " + Convert.ToDateTime(bankProcesses8.ProcessDate).ToString("dd/MM/yyyy");

            var bankProcesses9 = db.BankProcesses.OrderByDescending(x => x.BankProcessId).Take(9).Skip(8).FirstOrDefault();
            lblBankProcess9.Text = bankProcesses9.Description + " " + bankProcesses9.Amount + " ₺" + " " + Convert.ToDateTime(bankProcesses9.ProcessDate).ToString("dd/MM/yyyy");
        }

        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            FrmCategory frmCategory = new FrmCategory();
            frmCategory.Show();
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

        private void btnSpendingsForm_Click(object sender, EventArgs e)
        {
            FrmSpending frmSpending = new FrmSpending();
            frmSpending.Show();
            this.Hide();
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frmDashboard = new FrmDashboard();
            frmDashboard.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmUserSettings frmUserSettings = new FrmUserSettings();
            frmUserSettings.Show();
            this.Hide();
        }
    }
}
