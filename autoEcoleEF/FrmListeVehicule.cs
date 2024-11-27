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
    public partial class FrmListeVehicule : Form
    {
        private AutoEcoleEntities mesDonneesEF;
        public FrmListeVehicule(AutoEcoleEntities mesDonneEf)
        {
            InitializeComponent();
            this.mesDonneesEF = mesDonneEf;
            this.bdgVehicules.DataSource = mesDonneesEF.vehicules.ToList();
        
        }

        private void FrmListeVehicule_Load(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnEnregsitrer_Click(object sender, EventArgs e)
        {
            this.bdgVehicules.EndEdit();
            this.mesDonneesEF.SaveChanges();
        }

        private void bdgVehicules_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
