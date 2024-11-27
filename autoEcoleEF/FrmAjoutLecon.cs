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
    public partial class FrmAjoutLecon : Form
    {
        private AutoEcoleEntities mesDonneef;
        public FrmAjoutLecon(AutoEcoleEntities mesDonneef)
        {
            InitializeComponent();
            this.mesDonneef = mesDonneef;
            this.cbxEleve.DataSource = mesDonneef.eleves.ToList();



            cbxEleve.DisplayMember = "Nom";

           // this.eleveBindingSource.DataSource = mesDonneef.eleves;
            for (int i = 8; i < 20; i++)
            {
                this.cbxHeure.Items.Add(i);
            }
            //cbxEleve.DisplayMember = "Prenom";



        }

        private int newNumLecon()
        {
            int num = 0;

            int dernier = (from ra in this.mesDonneef.lecons
                           select ra.id).Max();

            num = dernier + 1;

            return num;
        }

        private lecon nouvellelecon()
        {
            int n = newNumLecon();
            eleve el = (eleve)cbxEleve.SelectedValue;
            DateTime d = this.dateTimePicker1.Value;
            int heureLecon = Convert.ToInt32(this.cbxHeure.SelectedItem);
            int nbHeures = 1;
            if (this.rdHeure2.Checked)
            {
                nbHeures = 2;
            }

            lecon l = new lecon();
            l.date = d;
            l.heure = heureLecon;   
            l.duree = nbHeures;
            l.id = n ;
            l.eleve = el;
            return l;
        }
        private void FrmAjoutLecon_Load(object sender, EventArgs e)
        {
            
        }

      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this.mesDonneef.lecons.Add(nouvellelecon());
            this.mesDonneef.SaveChanges();
            MessageBox.Show("Enregistrement Validé ! ");
        }

        private void cbxEleve_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
