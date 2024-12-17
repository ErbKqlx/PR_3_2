using Microsoft.EntityFrameworkCore;
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

            this.db.Partners.Load();
            this.dataGridViewPartners.DataSource = db.Partners.Local.ToBindingList();
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
                if (this.dataGridViewPartners.CurrentRow != null)
                {
                    var partner = (Partner)this.dataGridViewPartners.CurrentRow.DataBoundItem;

                    if (partner != null)
                    {
                        this.db.Entry(partner).Collection(e => e.PartnersProducts).Load();
                        this.dataGridViewPartnersProducts.DataSource = partner.PartnersProducts;
                    }
                }
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            this.db!.SaveChanges();

            this.dataGridViewPartners.Refresh();
        }
    }
}
