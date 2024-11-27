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
    public partial class FrmGererVehicule : Form
    {
        private AutoEcoleEntities mesDonneesEF;

        public FrmGererVehicule (AutoEcoleEntities mesDonneeEf)
        {
            InitializeComponent();
            this.mesDonneesEF = mesDonneeEf;
            this.BdgSourceVoiture.DataSource = mesDonneeEf.vehicules.ToList();
       
        }
       

     /*   public string getImmatricule(string immatricule)
        {
            string vrai = "";
            var lesVoitures = (from v in this.mesDonneesEF.vehicules
                              orderby v.numImma
                              select v);

            lesVoitures.ToList();

            foreach (var v in lesVoitures) 
            {
                if(v.numImma == immatricule)
                {
                    vrai = v.

                }
            }



             = lesVoitures.FirstOrDefault();
            return "";
        }
     */


       

        private void FrmGererVehicule_Load(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {
           
        }


        private vehicule newVehicule()
        {
            vehicule newVehicule = new vehicule();
            newVehicule.numImma = txtNumero.Text;
            newVehicule.couleur = txtCouleur.Text;
            newVehicule.modele = txtModele.Text;
            newVehicule.enEtat = 0;

           

            if (BoxTrue.Checked)
            {
                newVehicule.enEtat = 1;
             }

            else
            {
                newVehicule.enEtat = 0;
            }

            return newVehicule;

        }
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bdEnregistrer.Visible = true;
            txtCouleur.ReadOnly = false;
            txtNumero.ReadOnly = false;
            txtModele.ReadOnly = false;



        }

        private void bdEnregistrer_Click(object sender, EventArgs e)
        {

            if (this.mesDonneesEF == null)
            {
                MessageBox.Show("Le contexte mesDonneesEF n'est pas initialisé !");
               
            }


            try
            {
                this.mesDonneesEF.vehicules.Add(newVehicule());
                this.mesDonneesEF.SaveChanges();
                MessageBox.Show("Enregsitrement Validé");
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'enregistrement : {ex.Message} ");

            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            using (var context = new AutoEcoleEntities())
            {
              //  var idASupprimer = Convert.ToString(txtNumero);
                var idASupprimer = Convert.ToString(txtNumero.Text); // Suppose que txtNumero est une TextBox.
                Console.WriteLine(idASupprimer);

                // Rechercher l'entité en fonction d'un champ unique, par exemple une clé primaire.
                var entiteSupprimer = context.vehicules.FirstOrDefault(v => v.numImma == idASupprimer);
                Console.WriteLine(idASupprimer);
               // entiteSupprimer = context.vehicules;
           
            
            
                if (entiteSupprimer != null)
                {
                    var leconsImm = context.lecons.Where  (l => l.numImmaVehicule == idASupprimer).ToList();

                    if (!leconsImm.Any())
                    {

                        context.vehicules.Remove(entiteSupprimer);
                        context.SaveChanges();

                        BdgSourceVoiture.RemoveCurrent();
                        MessageBox.Show("Enregistrement Supprimé ! ");
                    }

                    else
                    {

                        var vehiculeASupprimer = context.vehicules.FirstOrDefault(v => v.numImma == idASupprimer);

                        context.lecons.RemoveRange(leconsImm);

                        context.SaveChanges();

                        MessageBox.Show("Voiture et ses leçons associées ont été supprimées avec succès !");
                    }
                }
            }
        }
    }
}
