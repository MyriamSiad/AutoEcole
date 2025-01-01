using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace autoEcoleEF
{
    public partial class FrmVisualiserEleve : Form
    {
        private AutoEcoleEntities mesDonneesEf;
        public FrmVisualiserEleve(AutoEcoleEntities mesDonneesEf)
        {
            InitializeComponent();
           this.mesDonneesEf = mesDonneesEf;
      

            this.bdgSeleve.DataSource = this.mesDonneesEf.eleves.Include("lecons").ToList();
            this.bdgSlecon.DataSource = this.mesDonneesEf.lecons.ToList();
            this.bdgSvehicule.DataSource = this.mesDonneesEf.vehicules.ToList();
           






            //this.mesDonneesEf.creer_Vehicule("153ZA79", "renault", "bleue", 1);
        }

        

        /*CREATE PROCEDURE creer_Vehicule ****** Requete procedure SQL SERVER

	         @p_id	 VARCHAR(8),
	        @p_modele VARCHAR(20),
	        @p_couleur VARCHAR(30),
	        @p_etat INT
	
        AS
        BEGIN

	        INSERT INTO vehicule (numImma, modele,couleur,enEtat)
	        VALUES(
		        @p_id,
		        @p_modele,
		        @p_couleur,
		        @p_etat)
	

        END;*/

        private void label1_Click(object sender, EventArgs e)
        {
           

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this.bdgSeleve.EndEdit();
            this.bdgSlecon.EndEdit();
            this.bdgSvehicule.EndEdit();
            this.mesDonneesEf.SaveChanges();
        }

        private void FrmVisualiserEleve_Load(object sender, EventArgs e)
        {
            var requete =from l in mesDonneesEf.lecons
                         select l;
            
           //this.dtgViewEleve.DataSource = requete;

        }

        private void dtgViewEleve_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dtgViewEleve.Rows[dtgViewEleve.CurrentRow.Index].Cells[0].Value);
            
            var requete = from l in mesDonneesEf.lecons
                          where l.idEleve == id
                          select l;
            this.dtgViewlecon.DataSource =requete.ToList();

        }

        private void dtgViewlecon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   

        }
    }
}
