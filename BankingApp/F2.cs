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
    public partial class F2 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public F2(SqlConnection sharedConnection)
        {
            InitializeComponent();
            con = sharedConnection;
            cmd = con.CreateCommand();

        }

        private void create_Click(object sender, EventArgs e)
        {
            string fullName = name.Text;
            string fullAddress = address.Text;
            string gender = male.Checked ? "M" : "F";
            string accountType = current.Checked ? "C" : "S";
            // RIGHT(REPLICATE(pad_char, length) + LEFT(string, length), length)
            cmd.CommandText = $"select CONCAT('{accountType}','{gender}',RIGHT(REPLICATE(0,3)+LEFT(ISNULL(max(SUBSTRING(AccNo,3,3))+1,'001'),3),3)) as newAcNo from Accounts where SUBSTRING(AccNo,1,1) = '{accountType}'";

            SqlDataReader R = cmd.ExecuteReader();
            R.Read();

            string newAccNo = (R["newAcNo"].ToString());
            R.Close();
            cmd.CommandText = $"insert into Accounts values('{newAccNo}','{fullName}','{fullAddress}','a')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("added");
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
