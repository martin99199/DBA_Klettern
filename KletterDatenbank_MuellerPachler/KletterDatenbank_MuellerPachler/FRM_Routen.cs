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
    public partial class FRM_Routen : Form
    {
        public FRM_Routen()
        {
            InitializeComponent();
        }

        private void FRM_Routen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eF_DB_KletterroutenDataSet.Sektoren' table. You can move, or remove it, as needed.
            this.sektorenTableAdapter.Fill(this.eF_DB_KletterroutenDataSet.Sektoren);
            // TODO: This line of code loads data into the 'eF_DB_KletterroutenDataSet.Gebiete' table. You can move, or remove it, as needed.
            this.gebieteTableAdapter.Fill(this.eF_DB_KletterroutenDataSet.Gebiete);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.sektorenTableAdapter.Update(eF_DB_KletterroutenDataSet);
            this.Close();
        }
    }
}
