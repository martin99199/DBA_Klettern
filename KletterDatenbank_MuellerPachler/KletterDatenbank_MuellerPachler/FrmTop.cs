using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KletterDatenbank_MuellerPachler
{
    public partial class FrmTop : Form
    {
        public FrmTop()
        {
            InitializeComponent();
        }

        private void FrmTop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eF_DB_KletterroutenDataSet.Personen' table. You can move, or remove it, as needed.
            this.personenTableAdapter.Fill(this.eF_DB_KletterroutenDataSet.Personen);

        }

        private void personenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void personenBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.personenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eF_DB_KletterroutenDataSet);

        }

        private void gebieteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.eF_DB_KletterroutenDataSet);

        }

        private void personenBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.personenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eF_DB_KletterroutenDataSet);

        }

        private void btnGebiete_Click(object sender, EventArgs e)
        {
            FRM_Routen dialog = new FRM_Routen();
            dialog.ShowDialog();
            dialog.Dispose();
        }

        private void btnWunsch_Click(object sender, EventArgs e)
        {

        }
    }
}
