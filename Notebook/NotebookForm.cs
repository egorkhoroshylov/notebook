using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Notebook
{
    public partial class NotebookForm : Form
    {
        private List<NotebookEntry> entries = new List<NotebookEntry>();

        public NotebookForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            NotebookEntry entry = new NotebookEntry
            {
                FullName = txtName.Text,
                Address = txtAddress.Text,
                PhoneNumber = txtPhone.Text,
                Birthday = dtBirthday.Value,
                LastEdited = DateTime.Now
            };

            entries.Add(entry);
            RefreshList();
        }

        private void RefreshList()
        {
            listBoxEntries.Items.Clear();
            foreach (var entry in entries)
            {
                listBoxEntries.Items.Add(entry.ToString());
            }
        }
    }
}
