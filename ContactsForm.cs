using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4._1
{
    public partial class ContactsForm : Form
    {
        private Dictionary<string, Person> Contacts;

        public ContactsForm()
        {
            InitializeComponent();
            Contacts = new Dictionary<string, Person>();
            InitializeDataGridView();
            addData();
        }

        private void InitializeDataGridView()
        {
            contactsGrid.Columns.Clear();
            contactsGrid.Columns.Add("Key", "Last Name");
            contactsGrid.Columns.Add("FirstName", "First Name");
            contactsGrid.Columns.Add("LastName", "Last Name");
            contactsGrid.Columns.Add("MobilePhone", "Mobile Phone");
            contactsGrid.Columns.Add("WorkPhone", "Work Phone");
            contactsGrid.Columns.Add("Address", "Address");
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Contacts.Add(text_LastName.Text, new Person(text_FirstName.Text, text_LastName.Text, text_MobileNum.Text, text_WorkNum.Text, text_Address.Text));
            string firstName = text_FirstName.Text;
            string lastName = text_LastName.Text;
            string mobilePhone = text_MobileNum.Text;
            string workPhone = text_WorkNum.Text;
            string address = text_Address.Text;
            addData();

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string warning = ("Are you sure you want to delete contact?");
            string caption = ("Confirm Delete");
            var response = MessageBox.Show(warning, caption, MessageBoxButtons.YesNo);

            if (response == DialogResult.Yes)
            {
                string remove = contactsGrid.CurrentRow.Cells[1].Value.ToString();
                Contacts.Remove(remove);
            }
            addData();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string search = text_Search.Text.Trim();

            if (Contacts.TryGetValue(search, out Person person))
            {
                MessageBox.Show($"Name: {person.FirstName} {person.LastName} Mobile Phone: {person.MobileNum} Work Phone: {person.WorkNum} Address: {person.Address}", "Search Result");
            }
            else
            {
                MessageBox.Show("No contact found");
            }
        }

        private void ContactsList()
        {
            Contacts.Add("Johnson", new Person("Joe", "Johnson", "123-456-7890", "123-456-7890", "123 Cool St."));
            Contacts.Add("Smith", new Person("Joe", "Smith", "123-456-7890", "123-456-7890", "123 Cool St."));
            Contacts.Add("Lewis", new Person("Joe", "Lewis", "123-456-7890", "123-456-7890", "123 Cool St."));
            Contacts.Add("Baker", new Person("Joe", "Baker", "123-456-7890", "123-456-7890", "123 Cool St."));

        }
        private void addData()
        {
                       
            foreach (var entry in Contacts)
            {
                contactsGrid.Rows.Add(entry.Value.FirstName, entry.Value.LastName, entry.Value.MobileNum, entry.Value.WorkNum, entry.Value.Address);
            }
        }

    }
}


