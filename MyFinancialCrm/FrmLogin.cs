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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();

        private void btnLoginDashboardForm_Click(object sender, EventArgs e)
        {
            string username = txtLoginUser.Text;
            string password = txtLoginPassword.Text;
            var user = db.Users.Where(u => u.Username == username && u.Password == password).FirstOrDefault();
            if (user != null)
            {
                FrmDashboard frmDashboard = new FrmDashboard();
                frmDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
            }


        }

        
    }
}
