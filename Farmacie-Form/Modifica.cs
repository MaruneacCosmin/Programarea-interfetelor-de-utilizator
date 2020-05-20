using System;
using System.Drawing;
using System.Windows.Forms;
using LibrarieClase;
using NivelAccesDate;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Farmacie_Form
{
    public partial class Modifica : Form
    {
        IStocareData adminMed;
        public Medicament Medd;
        public Form1 frmPrincipala;
        List<string> medicamenteSelectate = new List<string>();

        public Modifica()
        {
            InitializeComponent();
            adminMed = StocareFactory.GetAdministratorStocare();
        }
        private void btnModifica_Click(object sender, EventArgs e)
        {
            try
            {
                Medd.Nume_med = txtNume_med.Text;
                Medd.Cantitate =Convert.ToInt32 (txtCantitate.Text);
                Medd.Pret = Convert.ToInt32(txtPret.Text);
                Medd.TipAdm = (TipAdministrare)GetTipAdmSelectat();
                Medd.Data_exp = dtpData_exp.Value;
                Medd.DataActualizare = DateTime.Now;
                Medd.Doza = Int32.Parse(cmbDoza.Text);
                adminMed.UpdateMedd(Medd,Medd.ID);
                MessageBox.Show("Medicamentul a fost actualizat!");
            }
            catch (Exception)
            {
                MessageBox.Show("Medicamentul nu a putut fi acutalizat");
            }
            finally
            {
                frmPrincipala.btnAfiseaza_Click(null, null);
                this.Close();
            }
            
        }
        private TipAdministrare GetTipAdmSelectat()
        {
            if (rbOrala.Checked)
                return TipAdministrare.Orala;
            if (rbParenteral.Checked)
                return TipAdministrare.Parenteral;
            return TipAdministrare.Tip_Inexistent;
        }

        
    }
}
