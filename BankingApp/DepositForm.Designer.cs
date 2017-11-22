namespace BankingApp
{
    partial class TransactionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.accSearch = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.sex = new System.Windows.Forms.TextBox();
            this.accountType = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.amount = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account number";
            // 
            // accSearch
            // 
            this.accSearch.Location = new System.Drawing.Point(104, 25);
            this.accSearch.Name = "accSearch";
            this.accSearch.Size = new System.Drawing.Size(100, 20);
            this.accSearch.TabIndex = 1;
            this.accSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.accSearch_KeyPress);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(210, 23);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 2;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(104, 94);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 3;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(104, 120);
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Size = new System.Drawing.Size(100, 20);
            this.address.TabIndex = 4;
            // 
            // sex
            // 
            this.sex.Location = new System.Drawing.Point(104, 146);
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            this.sex.Size = new System.Drawing.Size(100, 20);
            this.sex.TabIndex = 5;
            // 
            // accountType
            // 
            this.accountType.Location = new System.Drawing.Point(104, 172);
            this.accountType.Name = "accountType";
            this.accountType.ReadOnly = true;
            this.accountType.Size = new System.Drawing.Size(100, 20);
            this.accountType.TabIndex = 6;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(210, 215);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 7;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(104, 217);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(100, 20);
            this.amount.TabIndex = 8;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(113, 6);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(0, 13);
            this.Title.TabIndex = 9;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.accountType);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.address);
            this.Controls.Add(this.name);
            this.Controls.Add(this.search);
            this.Controls.Add(this.accSearch);
            this.Controls.Add(this.label1);
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox accSearch;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox sex;
        private System.Windows.Forms.TextBox accountType;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label Title;
    }
}