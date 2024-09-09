namespace Assignment4._1
{
    partial class ContactsForm
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
            this.contactsGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.text_FirstName = new System.Windows.Forms.TextBox();
            this.text_LastName = new System.Windows.Forms.TextBox();
            this.text_MobileNum = new System.Windows.Forms.TextBox();
            this.text_WorkNum = new System.Windows.Forms.TextBox();
            this.text_Address = new System.Windows.Forms.TextBox();
            this.lb_Contacts = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.text_Search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.contactsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // contactsGrid
            // 
            this.contactsGrid.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.contactsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactsGrid.Location = new System.Drawing.Point(304, 57);
            this.contactsGrid.Name = "contactsGrid";
            this.contactsGrid.Size = new System.Drawing.Size(437, 268);
            this.contactsGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mobile #";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Work #";
            // 
            // text_FirstName
            // 
            this.text_FirstName.Location = new System.Drawing.Point(105, 57);
            this.text_FirstName.Name = "text_FirstName";
            this.text_FirstName.Size = new System.Drawing.Size(100, 20);
            this.text_FirstName.TabIndex = 6;
            // 
            // text_LastName
            // 
            this.text_LastName.Location = new System.Drawing.Point(105, 97);
            this.text_LastName.Name = "text_LastName";
            this.text_LastName.Size = new System.Drawing.Size(100, 20);
            this.text_LastName.TabIndex = 7;
            // 
            // text_MobileNum
            // 
            this.text_MobileNum.Location = new System.Drawing.Point(102, 132);
            this.text_MobileNum.Name = "text_MobileNum";
            this.text_MobileNum.Size = new System.Drawing.Size(100, 20);
            this.text_MobileNum.TabIndex = 8;
            // 
            // text_WorkNum
            // 
            this.text_WorkNum.Location = new System.Drawing.Point(102, 170);
            this.text_WorkNum.Name = "text_WorkNum";
            this.text_WorkNum.Size = new System.Drawing.Size(100, 20);
            this.text_WorkNum.TabIndex = 9;
            // 
            // text_Address
            // 
            this.text_Address.Location = new System.Drawing.Point(102, 202);
            this.text_Address.Name = "text_Address";
            this.text_Address.Size = new System.Drawing.Size(100, 20);
            this.text_Address.TabIndex = 10;
            // 
            // lb_Contacts
            // 
            this.lb_Contacts.AutoSize = true;
            this.lb_Contacts.Font = new System.Drawing.Font("RODE Noto Sans CJK SC B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Contacts.Location = new System.Drawing.Point(464, 9);
            this.lb_Contacts.Name = "lb_Contacts";
            this.lb_Contacts.Size = new System.Drawing.Size(119, 36);
            this.lb_Contacts.TabIndex = 11;
            this.lb_Contacts.Text = "Contacts";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Address";
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LightGreen;
            this.buttonAdd.Location = new System.Drawing.Point(169, 280);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonDelete.Location = new System.Drawing.Point(44, 280);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(105, 334);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 15;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Search (last name)";
            // 
            // text_Search
            // 
            this.text_Search.Location = new System.Drawing.Point(102, 241);
            this.text_Search.Name = "text_Search";
            this.text_Search.Size = new System.Drawing.Size(100, 20);
            this.text_Search.TabIndex = 17;
            // 
            // ContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.text_Search);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lb_Contacts);
            this.Controls.Add(this.text_Address);
            this.Controls.Add(this.text_WorkNum);
            this.Controls.Add(this.text_MobileNum);
            this.Controls.Add(this.text_LastName);
            this.Controls.Add(this.text_FirstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.contactsGrid);
            this.Name = "ContactsForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.contactsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView contactsGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text_FirstName;
        private System.Windows.Forms.TextBox text_LastName;
        private System.Windows.Forms.TextBox text_MobileNum;
        private System.Windows.Forms.TextBox text_WorkNum;
        private System.Windows.Forms.TextBox text_Address;
        private System.Windows.Forms.Label lb_Contacts;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_Search;
    }
}

