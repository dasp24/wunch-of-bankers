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
    public partial class TransactionForm : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        string action;
        string accountNumber = "";

        public TransactionForm(SqlConnection sharedConnection, string act)
        {
            InitializeComponent();
            con = sharedConnection;
            cmd = con.CreateCommand();
            action = act;
            Title.Text = action;
          
        }

        public int balance(string account)
        {
            cmd.CommandText = $"select SUM(Amount) as total from Deposits where AccNo = '{account}'";
            SqlDataReader posData = cmd.ExecuteReader();
            posData.Read();
            int positiveBal = Int32.Parse(posData["total"].ToString());
            posData.Close();
            cmd.CommandText = $"select SUM(Amount) as total from Withdrawals where AccNo = '{account}'";
            SqlDataReader negData = cmd.ExecuteReader();
            negData.Read();
            int negativeBal = Int32.Parse(negData["total"].ToString());
            negData.Close();
            return positiveBal - negativeBal;
        }

        private void searchForAccount(object sender, EventArgs e)
        {
            string accNum = accSearch.Text;
            cmd.CommandText = $"select * from Accounts where AccNo = '{accNum}'";
            SqlDataReader Data = cmd.ExecuteReader();
            if (!Data.Read()) MessageBox.Show("You made a mistake with your account number :)");
            else
            {
                string accNumber = Data["AccNo"].ToString();
                accountNumber = accNumber;
                name.Text = Data["Name"].ToString();
                address.Text = Data["Address"].ToString();
                sex.Text = accNumber[1] == 'M' ? "Male" : "Female";
                accountType.Text = accNumber[0] == 'C' ? "Current" : "Savings";
            }
            Data.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (accSearch.Text.Length == 5) searchForAccount(sender, e);
            else MessageBox.Show("account numbers are five characters long");
        }

        private void accSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                if (accSearch.Text.Length == 5) searchForAccount(sender, e);
                else MessageBox.Show("account numbers are five characters long");
            }
        }

        private void submit_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("d/M/yyyy");
            string table = action == "deposit" ? "Deposits" : "Withdrawals";
            if (accountNumber.Length != 5) MessageBox.Show("Which account???");
            else if(table == "Withdrawals" && balance(accSearch.Text) < Int32.Parse(amount.Text)) MessageBox.Show("not enough funds my friend");
            else
            {
                string done = action == "deposit" ? "Deposited" : "Withdrawn";
                cmd.CommandText = $"insert into {table} values ('{accountNumber}',{amount.Text},'{date}')";
                cmd.ExecuteNonQuery();
                MessageBox.Show(done + " new balance " + balance(accSearch.Text));
            }
        }
    }
}
