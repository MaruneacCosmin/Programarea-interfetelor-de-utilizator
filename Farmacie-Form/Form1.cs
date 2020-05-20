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
    public partial class Form1 : Form
    {
        IStocareData adminMed;
        List<string> medicamenteSelectate = new List<string>();

        public Form1()
        {
            InitializeComponent();
            adminMed = StocareFactory.GetAdministratorStocare();
            this.Width = 350;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            ResetCuloareEtichete();

            CodEroare codValidare = Validare(txtNume_med.Text, txtPret.Text, txtCantitate.Text);

            if (codValidare != CodEroare.CORECT)
            {
                MarcheazaControaleCuDateIncorecte(codValidare);
            }
            else
            {
                Medicament s = new Medicament(txtNume_med.Text, txtCantitate.Text, txtPret.Text);

                s.Data_exp = dtpData_exp.Value;
                s.TipAdm = GetTipAdmSelectat();
                s.Medicamente = new List<string>();
                s.Medicamente.AddRange(medicamenteSelectate);
                s.Doza = Int32.Parse(cmbDoza.Text);
                s.DataActualizare = DateTime.Now;
              
                adminMed.AddMed(s);
                MessageBox.Show("Medicamentul a fost adaugat!");
                ResetareControale();
            }
        }

        private void ResetareControale()
        {
            txtNume_med.Text = txtCantitate.Text = txtPret.Text = string.Empty;
            rbOrala.Checked = false;
            rbParenteral.Checked = false;
            checkAntibiotic.Checked = false;
            checkVitamine.Checked = false;
            checkAntiinflamator.Checked = false;
            checkVaccin.Checked = false;
            medicamenteSelectate.Clear();
            cmbDoza.Text = string.Empty;
            lblMesaj.Text = string.Empty;

            lblID.Text = String.Empty;
        }

        private CodEroare Validare(string nume, string Pret, string cantitate)
        {
            CodEroare rezultatValidare = CodEroare.CORECT;
            if (nume == string.Empty)
            {
                rezultatValidare |= CodEroare.NUME_INCORECT;
            }
            if (cantitate == string.Empty)
            {
                rezultatValidare |= CodEroare.CANTITATE_INCORECTA;
            }
            if (Pret == string.Empty)
            {
                rezultatValidare |= CodEroare.Pret_INCORECT;
            }
           
            int administrareselect = 0;
            foreach (var control in rdboxAdministrare.Controls)
            {
                RadioButton rdb = null;
                try
                {
                    rdb = (RadioButton)control;
                }
                catch { }

                if (rdb != null && rdb.Checked == true)
                    administrareselect = 1;
            }
            if (administrareselect == 0)
                rezultatValidare |= CodEroare.ADMINISTRARE_INCORECTA;

            return rezultatValidare;
        }

        private void MarcheazaControaleCuDateIncorecte(CodEroare codValidare)
        {
            if ((codValidare & CodEroare.NUME_INCORECT) == CodEroare.NUME_INCORECT)
            {
                lblNume_med.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.Pret_INCORECT) == CodEroare.Pret_INCORECT)
            {
                lblPret.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.CANTITATE_INCORECTA) == CodEroare.CANTITATE_INCORECTA)
            {
                lblCantitate.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.ADMINISTRARE_INCORECTA) == CodEroare.ADMINISTRARE_INCORECTA)
            {
                lblAdministrare.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.TIP_INCORECT) == CodEroare.TIP_INCORECT)
            {
                lblTip_med.ForeColor = Color.Red;
            }
        }

        private void ResetCuloareEtichete()
        {
            lblNume_med.ForeColor = Color.Black;
            lblCantitate.ForeColor = Color.Black;
            lblPret.ForeColor = Color.Black;
            lblAdministrare.ForeColor = Color.Black;
            lblTip_med.ForeColor = Color.Black;
        }

        private TipAdministrare GetTipAdmSelectat()
        {
            if (rbOrala.Checked)
                return TipAdministrare.Orala;
            if (rbParenteral.Checked)
                return TipAdministrare.Parenteral;
            return TipAdministrare.Tip_Inexistent;
        }

        public void btnAfiseaza_Click(object sender, EventArgs e)
        {
            this.Width = 1330;
            List<Medicament> medicamente = adminMed.GetMedicamente();
            AdaugaMedicamentInControlListbox(medicamente);
            AdaugaMedicamentInControlDataGridView(medicamente);
        }

        private void AdaugaMedicamentInControlListbox(List<Medicament> medicamente)
        {
            lstAfisare.Items.Clear();

            //personalizare sursa de date
            //var antetTabel = String.Format("{0,-5}{1,-35}{2,20}{3,10}\n", "Id", "Nume Prenume", "ProgramStudiu", "Medie");
            //lstAfisare.Items.Add(antetTabel);

            foreach (Medicament s in medicamente)
            {
                //pentru a adauga un obiect de tip Medicament in colectia de Items a unui control de tip ListBox, 
                // clasa Medicament trebuie sa implementeze metoda ToString() specificand cuvantul cheie 'override' in definitie
                //pentru a arata ca metoda ToString a clasei de baza (Object) este suprascrisa
                lstAfisare.Items.Add(s);


                //personalizare sursa de date
                //var linieTabel = String.Format("{0,-5}{1,-35}{2,20}{3,10}\n", s.IdMedicament, s.NumeComplet, s.ProgramSTD.ToString(), s.Media.ToString());
                //lstAfisare.Items.Add(linieTabel);
            }
        }
        private void AdaugaMedicamentInControlDataGridView(List<Medicament> medicamenete)
        {
            
            dataGridMedicamente.DataSource = null;

            
            dataGridMedicamente.DataSource = medicamenete.Select(s => new { s.ID, s.Nume_med, s.Pret, s.Cantitate, s.TipAdm, Tip = string.Join(",", s.Medicamente), s.Doza, s.Data_exp, s.DataActualizare }).ToList();
        }


        private void btnCauta_Click(object sender, EventArgs e)
        {
            /*Medicament t = adminMed.GetMed(txtNume_med.Text);
            if (t != null)
            {
                
                foreach (var tip in rdboxTip.Controls)
                {
                    if (tip is CheckBox)
                    {
                        var tipBox = tip as CheckBox;
                        foreach (String dis in t.Medicamente)
                            if (tipBox.Text.Equals(dis))
                                tipBox.Checked = true;
                    }
                }
            }
            else
                MessageBox.Show("Medicamentul nu a fost gasit!");
            if (txtNume_med.Enabled == true)
            {
                txtNume_med.Enabled = false;  
              
                foreach (var button in rdboxAdministrare.Controls)
                {
                    if (button is RadioButton)
                    {
                        var radioButton = button as RadioButton;
                        radioButton.Enabled = false;
                    }
                }
            }
            else
            {
                txtNume_med.Enabled = true;
                foreach (var button in rdboxAdministrare.Controls)
                {
                    if (button is RadioButton)
                    {
                        var radioButton = button as RadioButton;
                        radioButton.Enabled = true;
                    }
                }
            }
            MessageBox.Show("Medicamentul a fost gasit!");*/

            List < Medicament > medicamente = adminMed.GetMedicamente();
            bool ok = false;
            lstAfisare.Items.Clear();
            foreach (Medicament m in medicamente)
            {
                if(m.Nume_med==txtNume_med.Text)
                {
                    lstAfisare.Items.Add(m.ConversieLaSir_Fisier());
                    ok = true;
                }
            }
            if (ok==true)
            
                MessageBox.Show("Medicamentul a fost gasit!");

            else
                MessageBox.Show("Medicamentul nu a fost gasit!");



        }



        private void btnModifica_Click(object sender, EventArgs e)
        {
            int index = lstAfisare.SelectedIndex + 1;
            Medicament x = adminMed.GetMedByIndex(index);
            if(x is null)
            {
                MessageBox.Show("Nu ati selectat niciun medicament");
            }
            Modifica f = new Modifica();
            f.Medd= x;
            f.frmPrincipala = this;
            f.Show();
        }



        private void ckbTip_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBoxControl = sender as CheckBox; 
            

            string medicamentSelectat = checkBoxControl.Text;

            if (checkBoxControl.Checked == true)
                medicamenteSelectate.Add(medicamentSelectat);
            else
                medicamenteSelectate.Remove(medicamentSelectat);
        }



        private void lstAfisare_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetareControale();
            Medicament t = null;
            try
            {
                t = adminMed.GetMedByIndex(lstAfisare.SelectedIndex +1);
            }
            catch (Exception ex)
            {
                lblMesaj.Text = "Eroare: " + ex.Message;
            }

            if (t != null)
            {
                lblID.Text = t.ID.ToString();

                txtNume_med.Text = t.Nume_med;

                foreach (var admn in rdboxAdministrare.Controls)
                {
                    if (admn is RadioButton)
                    {
                        var admnBox = admn as RadioButton;
                        if (admnBox.Text == t.TipAdm.ToString())
                        {
                            admnBox.Checked = true;
                        }
                    }
                }

                foreach (var disciplina in rdboxAdministrare.Controls)
                {
                    if (disciplina is CheckBox)
                    {
                        var disciplinaBox = disciplina as CheckBox;
                        foreach (String dis in t.Medicamente)
                            if (disciplinaBox.Text.Equals(dis))
                                disciplinaBox.Checked = true;
                    }
                }

                cmbDoza.Text = t.Doza.ToString();
                
            }
        }

        

        private void salvareInFisierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Medicament> Medicamente = adminMed.GetMedPret();
            sfd.ShowDialog();
            salvareRaport(Medicamente, sfd.FileName);
        }
        public void salvareRaport(List<Medicament> Medicamente, string numeFisier)
        {
            try
            {
                
                using (StreamWriter swFisierText = new StreamWriter(numeFisier, true))
                {
                    foreach (Medicament s in Medicamente)
                    {
                        swFisierText.WriteLine(s.ConversieLaSir());
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }

        private void filtrareMed(object sender, EventArgs e)
        {
            List<Medicament> sub100 = adminMed.GetMedPret();
            dataGridMedicamente.DataSource = sub100.Select(s => new { s.ID, s.Nume_med, s.Pret, s.Cantitate, s.TipAdm, Tip = string.Join(",", s.Medicamente), s.Doza, s.Data_exp, s.DataActualizare }).ToList();
        }

        private void btnDataF_Click(object sender, EventArgs e)
        {
            
            List<Medicament> sub100 = adminMed.GetMedData(dtpLow.Value,dtpHigh.Value);
            dataGridMedicamente.DataSource = sub100.Select(s => new { s.ID, s.Nume_med, s.Pret, s.Cantitate, s.TipAdm, Tip = string.Join(",", s.Medicamente), s.Doza, s.Data_exp, s.DataActualizare }).ToList();
        }

        private void btnReducere_Click(object sender, EventArgs e)
        {
            int index = lstAfisare.SelectedIndex + 1;
            Medicament x = adminMed.GetMedByIndex(index);
            if(x!=null)
            {
                if (x.Reducere == true)
                    lblReducere.Text = "Se poate aplica o reducere";
               
                if(x.Reducere==false)
                    lblReducere.Text = "Nu se poate aplica o reducere";
            }
        }
    }
}
