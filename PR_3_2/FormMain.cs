using Microsoft.VisualBasic.ApplicationServices;
using PR_3_2.Models;
using System.ComponentModel;

namespace PR_3_2
{
    public partial class FormMain : Form
    {
        private PartnersContext? db;

        public FormMain()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.db = new PartnersContext();

            //this.db.Users.Load();
            //this.dataGridViewUsers.DataSource = db.Users.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.db?.Dispose();
            this.db = null;
        }

        private void DataGridViewPartners_SelectionChanged(object sender, EventArgs e)
        {
            if (this.db != null)
            {
                var partner = (Partner)this.dataGridViewPartners.CurrentRow.DataBoundItem;

                if (partner != null)
                {
                    //this.db.Entry(user).Collection(e => e.Posts).Load();
                    //this.dataGridViewPosts.DataSource = user.Posts;
                }
            }
        }
    }
}
