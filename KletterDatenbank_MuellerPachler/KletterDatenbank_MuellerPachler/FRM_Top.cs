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
    public partial class FRM_Top : Form
    {
        public FRM_Top()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FRM_Top_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eF_KletterRoutenDataSet.Gebiet' table. You can move, or remove it, as needed.
            this.gebietTableAdapter.Fill(this.eF_KletterRoutenDataSet.Gebiet);
            // TODO: This line of code loads data into the 'eF_KletterRoutenDataSet.Sektor' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'eF_KletterRoutenDataSet.Person' table. You can move, or remove it, as needed.
            this.personTableAdapter.Fill(this.eF_KletterRoutenDataSet.Person);

        }

    }
}
