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
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmCategory_Load(object sender, EventArgs e)
        {
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
            dataGridView1.Columns[2].Visible = false;
        }

        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
            dataGridView1.Columns[2].Visible = false;
        }

        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            string categorytitle = txtCategoryTitle.Text;
            Categories categories = new Categories();
            categories.CategoryName = categorytitle;
            db.Categories.Add(categories);
            db.SaveChanges();
            MessageBox.Show("Yeni kategori başarılı şekilde eklendi!", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
            dataGridView1.Columns[2].Visible = false;

        }

        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var deletecategory = db.Categories.Find(id);
            db.Categories.Remove(deletecategory);
            db.SaveChanges();
            MessageBox.Show("Kategori başarılı şekilde silindi!", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
            dataGridView1.Columns[2].Visible = false;

        }

        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            string categorytitle = txtCategoryTitle.Text;
            var updatecategory = db.Categories.Find(id);
            updatecategory.CategoryName = categorytitle;
            db.SaveChanges();
            MessageBox.Show("Kategori başarılı şekilde güncellendi!", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
            dataGridView1.Columns[2].Visible = false;
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

        private void btnSpendingsForm_Click(object sender, EventArgs e)
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
