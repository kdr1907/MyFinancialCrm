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
    public partial class FrmUserSettings : Form
    {
        public FrmUserSettings()
        {
            InitializeComponent();
        }

        

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
            string newUsername = txtNewUserName.Text;
            string newPassword = txtNewUserPassword.Text;

            
            
                // Giriş yapan kullanıcıyı bul (Mevcut kullanıcı adını alarak)
                var user = db.Users.FirstOrDefault(u => u.Username == txtNewUserName.Text);

                if (user != null)
                {
                    user.Username = newUsername;
                    user.Password = newPassword; // Şifreyi hashlemelisin!

                    db.SaveChanges();
                    MessageBox.Show("Kullanıcı bilgileri güncellendi!");

                    FrmLogin frmLogin = new FrmLogin();
                    frmLogin.Show();
                    this.Hide();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Kullanıcı bulunamadı!");
                }


            


        }

        private void FrmUserSettings_Load(object sender, EventArgs e)
        {
            var username = db.Users.FirstOrDefault();
            txtNewUserName.Text = username.Username;
            txtNewUserPassword.Text = username.Password;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Close();
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

        private void btnSpendingsForm_Click(object sender, EventArgs e)
        {
            FrmSpending frmSpending = new FrmSpending();
            frmSpending.Show();
            this.Hide();
        }

        private void btnBillsForm_Click(object sender, EventArgs e)
        {
            FrmBilling frmBilling = new FrmBilling();
            frmBilling.Show();
            this.Hide();
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            FrmBanks frmBanks = new FrmBanks();
            frmBanks.Show();
            this.Hide();
        }

        private void btnCategoryForm_Click(object sender, EventArgs e)
        {
            FrmCategory frmCategory = new FrmCategory();
            frmCategory.Show();
            this.Hide();
        }
    }
}
