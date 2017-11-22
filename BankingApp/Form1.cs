using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BankingApp
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=c:\\users\\admin\\source\\repos\\BankingApp\\BankingApp\\Database1.mdf;Integrated Security=True";
            con.Open();
            cmd = con.CreateCommand();
        }

        private void newAccount_Click(object sender, EventArgs e)
        {
            F2 f2 = new F2(con);
            f2.Show();
        }

        private void Deposit_Click(object sender, EventArgs e)
        {
            string action = "deposit";
            TransactionForm deposit = new TransactionForm(con, action);
            deposit.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string action = "withdrawal";
            TransactionForm deposit = new TransactionForm(con, action);
            deposit.Show();
        }
    }
}
