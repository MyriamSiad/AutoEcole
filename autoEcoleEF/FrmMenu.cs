using autoEcoleEF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace autoEcoleEF
{
  
       
    public partial class FrmMenu : Form
    {
        private AutoEcoleEntities mesDonneesEf;


        public FrmMenu()
        {
            InitializeComponent();
            this.mesDonneesEf = new AutoEcoleEntities();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void elèveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gérerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGererEleve f = new FrmGererEleve(this.mesDonneesEf);
            f.MdiParent = this;
            f.Show();

        }

        private void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListeVehicule f = new FrmListeVehicule(this.mesDonneesEf);
            f.MdiParent = this;
            f.Show();

        }

        private void gérerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmGererEleve f = new FrmGererEleve(this.mesDonneesEf);
            f.MdiParent = this;
            f.Show();
        }

        private void ajoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAjoutLecon f = new FrmAjoutLecon(this.mesDonneesEf);
            f.MdiParent = this;
            f.Show();
        }

        private void validerToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FrmValiderLecon f = new FrmValiderLecon(this.mesDonneesEf);
            f.MdiParent = this;
            f.Show();

        }

        private void elèveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void visualiserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVisualiserEleve el = new FrmVisualiserEleve(this.mesDonneesEf);
            el.MdiParent = this;
            el.Show();
        }
    }
}
