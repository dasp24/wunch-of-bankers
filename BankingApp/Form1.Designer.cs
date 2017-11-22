namespace BankingApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newAccount = new System.Windows.Forms.Button();
            this.Deposit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newAccount
            // 
            this.newAccount.Location = new System.Drawing.Point(12, 170);
            this.newAccount.Name = "newAccount";
            this.newAccount.Size = new System.Drawing.Size(141, 23);
            this.newAccount.TabIndex = 0;
            this.newAccount.Text = "create new account";
            this.newAccount.UseVisualStyleBackColor = true;
            this.newAccount.Click += new System.EventHandler(this.newAccount_Click);
            // 
            // Deposit
            // 
            this.Deposit.Location = new System.Drawing.Point(12, 132);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(141, 23);
            this.Deposit.TabIndex = 1;
            this.Deposit.Text = "Make a Deposit my friend";
            this.Deposit.UseVisualStyleBackColor = true;
            this.Deposit.Click += new System.EventHandler(this.Deposit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Make a Withdrawal my friend";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Deposit);
            this.Controls.Add(this.newAccount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newAccount;
        private System.Windows.Forms.Button Deposit;
        private System.Windows.Forms.Button button1;
    }
}

