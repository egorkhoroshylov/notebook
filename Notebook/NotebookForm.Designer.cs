namespace Notebook
{
    partial class NotebookForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DateTimePicker dtBirthday;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox listBoxEntries;

        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dtBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.listBoxEntries = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // txtName
            this.txtName.Location = new System.Drawing.Point(12, 12);
            this.txtName.Size = new System.Drawing.Size(200, 23);
            this.txtName.PlaceholderText = "Full Name";

            // txtAddress
            this.txtAddress.Location = new System.Drawing.Point(12, 41);
            this.txtAddress.Size = new System.Drawing.Size(200, 23);
            this.txtAddress.PlaceholderText = "Address";

            // txtPhone
            this.txtPhone.Location = new System.Drawing.Point(12, 70);
            this.txtPhone.Size = new System.Drawing.Size(200, 23);
            this.txtPhone.PlaceholderText = "Phone";

            // dtBirthday
            this.dtBirthday.Location = new System.Drawing.Point(12, 99);
            this.dtBirthday.Size = new System.Drawing.Size(200, 23);

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(12, 128);
            this.btnAdd.Size = new System.Drawing.Size(200, 23);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // listBoxEntries
            this.listBoxEntries.Location = new System.Drawing.Point(12, 157);
            this.listBoxEntries.Size = new System.Drawing.Size(360, 180);

            // NotebookForm
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.dtBirthday);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.listBoxEntries);
            this.Name = "NotebookForm";
            this.Text = "Notebook";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
