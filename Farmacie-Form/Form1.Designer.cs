namespace Farmacie_Form
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnModifica = new System.Windows.Forms.Button();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.btnCauta = new System.Windows.Forms.Button();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.lblNume_med = new System.Windows.Forms.Label();
            this.lblData_exp = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.lblCantitate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTip_med = new System.Windows.Forms.Label();
            this.lblAdministrare = new System.Windows.Forms.Label();
            this.rbParenteral = new System.Windows.Forms.RadioButton();
            this.rbOrala = new System.Windows.Forms.RadioButton();
            this.rdboxAdministrare = new System.Windows.Forms.GroupBox();
            this.rdboxTip = new System.Windows.Forms.GroupBox();
            this.checkAntiinflamator = new System.Windows.Forms.CheckBox();
            this.checkVitamine = new System.Windows.Forms.CheckBox();
            this.checkVaccin = new System.Windows.Forms.CheckBox();
            this.checkAntibiotic = new System.Windows.Forms.CheckBox();
            this.dtpData_exp = new System.Windows.Forms.DateTimePicker();
            this.txtNume_med = new System.Windows.Forms.TextBox();
            this.txtCantitate = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.lstAfisare = new System.Windows.Forms.ListBox();
            this.cmbDoza = new System.Windows.Forms.ComboBox();
            this.lblDoza = new System.Windows.Forms.Label();
            this.dataGridMedicamente = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFiltrare = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalvare = new System.Windows.Forms.ToolStripMenuItem();
            this.lblID = new System.Windows.Forms.Label();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.dtpLow = new System.Windows.Forms.DateTimePicker();
            this.dtpHigh = new System.Windows.Forms.DateTimePicker();
            this.btnDataF = new System.Windows.Forms.Button();
            this.btnReducere = new System.Windows.Forms.Button();
            this.lblReducere = new System.Windows.Forms.Label();
            this.rdboxAdministrare.SuspendLayout();
            this.rdboxTip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedicamente)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(312, 469);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(107, 25);
            this.btnModifica.TabIndex = 0;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(177, 469);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(107, 27);
            this.btnAfiseaza.TabIndex = 1;
            this.btnAfiseaza.Text = "Afiseaza";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // btnCauta
            // 
            this.btnCauta.Location = new System.Drawing.Point(312, 422);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(107, 25);
            this.btnCauta.TabIndex = 2;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click);
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(177, 422);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(107, 25);
            this.btnAdauga.TabIndex = 3;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // lblNume_med
            // 
            this.lblNume_med.AutoSize = true;
            this.lblNume_med.Location = new System.Drawing.Point(34, 45);
            this.lblNume_med.Name = "lblNume_med";
            this.lblNume_med.Size = new System.Drawing.Size(125, 17);
            this.lblNume_med.TabIndex = 4;
            this.lblNume_med.Text = "Nume medicament";
            // 
            // lblData_exp
            // 
            this.lblData_exp.AutoSize = true;
            this.lblData_exp.Location = new System.Drawing.Point(34, 83);
            this.lblData_exp.Name = "lblData_exp";
            this.lblData_exp.Size = new System.Drawing.Size(91, 17);
            this.lblData_exp.TabIndex = 5;
            this.lblData_exp.Text = "Data expirarii";
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Location = new System.Drawing.Point(34, 120);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(34, 17);
            this.lblPret.TabIndex = 6;
            this.lblPret.Text = "Pret";
            // 
            // lblCantitate
            // 
            this.lblCantitate.AutoSize = true;
            this.lblCantitate.Location = new System.Drawing.Point(34, 158);
            this.lblCantitate.Name = "lblCantitate";
            this.lblCantitate.Size = new System.Drawing.Size(64, 17);
            this.lblCantitate.TabIndex = 7;
            this.lblCantitate.Text = "Cantitate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 8;
            // 
            // lblTip_med
            // 
            this.lblTip_med.AutoSize = true;
            this.lblTip_med.Location = new System.Drawing.Point(34, 295);
            this.lblTip_med.Name = "lblTip_med";
            this.lblTip_med.Size = new System.Drawing.Size(108, 17);
            this.lblTip_med.TabIndex = 9;
            this.lblTip_med.Text = "Tip Medicament";
            // 
            // lblAdministrare
            // 
            this.lblAdministrare.AutoSize = true;
            this.lblAdministrare.Location = new System.Drawing.Point(34, 205);
            this.lblAdministrare.Name = "lblAdministrare";
            this.lblAdministrare.Size = new System.Drawing.Size(87, 17);
            this.lblAdministrare.TabIndex = 10;
            this.lblAdministrare.Text = "Administrare";
            // 
            // rbParenteral
            // 
            this.rbParenteral.AutoSize = true;
            this.rbParenteral.Checked = true;
            this.rbParenteral.Location = new System.Drawing.Point(23, 41);
            this.rbParenteral.Name = "rbParenteral";
            this.rbParenteral.Size = new System.Drawing.Size(95, 21);
            this.rbParenteral.TabIndex = 11;
            this.rbParenteral.TabStop = true;
            this.rbParenteral.Text = "Parenteral";
            this.rbParenteral.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rbParenteral.UseVisualStyleBackColor = true;
            // 
            // rbOrala
            // 
            this.rbOrala.AutoSize = true;
            this.rbOrala.Location = new System.Drawing.Point(23, 18);
            this.rbOrala.Name = "rbOrala";
            this.rbOrala.Size = new System.Drawing.Size(64, 21);
            this.rbOrala.TabIndex = 12;
            this.rbOrala.Text = "Orală";
            this.rbOrala.UseVisualStyleBackColor = true;
            // 
            // rdboxAdministrare
            // 
            this.rdboxAdministrare.Controls.Add(this.rbOrala);
            this.rdboxAdministrare.Controls.Add(this.rbParenteral);
            this.rdboxAdministrare.Location = new System.Drawing.Point(177, 187);
            this.rdboxAdministrare.Name = "rdboxAdministrare";
            this.rdboxAdministrare.Size = new System.Drawing.Size(242, 68);
            this.rdboxAdministrare.TabIndex = 13;
            this.rdboxAdministrare.TabStop = false;
            // 
            // rdboxTip
            // 
            this.rdboxTip.Controls.Add(this.checkAntiinflamator);
            this.rdboxTip.Controls.Add(this.checkVitamine);
            this.rdboxTip.Controls.Add(this.checkVaccin);
            this.rdboxTip.Controls.Add(this.checkAntibiotic);
            this.rdboxTip.Location = new System.Drawing.Point(177, 274);
            this.rdboxTip.Name = "rdboxTip";
            this.rdboxTip.Size = new System.Drawing.Size(242, 88);
            this.rdboxTip.TabIndex = 14;
            this.rdboxTip.TabStop = false;
            // 
            // checkAntiinflamator
            // 
            this.checkAntiinflamator.AutoSize = true;
            this.checkAntiinflamator.Location = new System.Drawing.Point(113, 48);
            this.checkAntiinflamator.Name = "checkAntiinflamator";
            this.checkAntiinflamator.Size = new System.Drawing.Size(116, 21);
            this.checkAntiinflamator.TabIndex = 15;
            this.checkAntiinflamator.Text = "Antiinflamator";
            this.checkAntiinflamator.UseVisualStyleBackColor = true;
            this.checkAntiinflamator.CheckedChanged += new System.EventHandler(this.ckbTip_CheckedChanged);
            // 
            // checkVitamine
            // 
            this.checkVitamine.AutoSize = true;
            this.checkVitamine.Location = new System.Drawing.Point(113, 21);
            this.checkVitamine.Name = "checkVitamine";
            this.checkVitamine.Size = new System.Drawing.Size(84, 21);
            this.checkVitamine.TabIndex = 15;
            this.checkVitamine.Text = "Vitamine";
            this.checkVitamine.UseVisualStyleBackColor = true;
            this.checkVitamine.CheckedChanged += new System.EventHandler(this.ckbTip_CheckedChanged);
            // 
            // checkVaccin
            // 
            this.checkVaccin.AutoSize = true;
            this.checkVaccin.Location = new System.Drawing.Point(20, 48);
            this.checkVaccin.Name = "checkVaccin";
            this.checkVaccin.Size = new System.Drawing.Size(72, 21);
            this.checkVaccin.TabIndex = 15;
            this.checkVaccin.Text = "Vaccin";
            this.checkVaccin.UseVisualStyleBackColor = true;
            this.checkVaccin.CheckedChanged += new System.EventHandler(this.ckbTip_CheckedChanged);
            // 
            // checkAntibiotic
            // 
            this.checkAntibiotic.AutoSize = true;
            this.checkAntibiotic.Location = new System.Drawing.Point(20, 21);
            this.checkAntibiotic.Name = "checkAntibiotic";
            this.checkAntibiotic.Size = new System.Drawing.Size(87, 21);
            this.checkAntibiotic.TabIndex = 0;
            this.checkAntibiotic.Text = "Antibiotic";
            this.checkAntibiotic.UseVisualStyleBackColor = true;
            this.checkAntibiotic.CheckStateChanged += new System.EventHandler(this.ckbTip_CheckedChanged);
            // 
            // dtpData_exp
            // 
            this.dtpData_exp.Location = new System.Drawing.Point(177, 83);
            this.dtpData_exp.Name = "dtpData_exp";
            this.dtpData_exp.Size = new System.Drawing.Size(242, 22);
            this.dtpData_exp.TabIndex = 15;
            // 
            // txtNume_med
            // 
            this.txtNume_med.Location = new System.Drawing.Point(177, 45);
            this.txtNume_med.Name = "txtNume_med";
            this.txtNume_med.Size = new System.Drawing.Size(242, 22);
            this.txtNume_med.TabIndex = 16;
            // 
            // txtCantitate
            // 
            this.txtCantitate.Location = new System.Drawing.Point(177, 155);
            this.txtCantitate.Name = "txtCantitate";
            this.txtCantitate.Size = new System.Drawing.Size(242, 22);
            this.txtCantitate.TabIndex = 17;
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(177, 117);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(242, 22);
            this.txtPret.TabIndex = 18;
            // 
            // lstAfisare
            // 
            this.lstAfisare.FormattingEnabled = true;
            this.lstAfisare.ItemHeight = 16;
            this.lstAfisare.Location = new System.Drawing.Point(460, 45);
            this.lstAfisare.Name = "lstAfisare";
            this.lstAfisare.Size = new System.Drawing.Size(598, 516);
            this.lstAfisare.TabIndex = 19;
            this.lstAfisare.SelectedIndexChanged += new System.EventHandler(this.lstAfisare_SelectedIndexChanged);
            // 
            // cmbDoza
            // 
            this.cmbDoza.FormattingEnabled = true;
            this.cmbDoza.Items.AddRange(new object[] {
            "250",
            "500",
            "1000"});
            this.cmbDoza.Location = new System.Drawing.Point(177, 377);
            this.cmbDoza.Name = "cmbDoza";
            this.cmbDoza.Size = new System.Drawing.Size(242, 24);
            this.cmbDoza.TabIndex = 20;
            // 
            // lblDoza
            // 
            this.lblDoza.AutoSize = true;
            this.lblDoza.Location = new System.Drawing.Point(38, 377);
            this.lblDoza.Name = "lblDoza";
            this.lblDoza.Size = new System.Drawing.Size(41, 17);
            this.lblDoza.TabIndex = 21;
            this.lblDoza.Text = "Doză";
            // 
            // dataGridMedicamente
            // 
            this.dataGridMedicamente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMedicamente.Location = new System.Drawing.Point(1064, 47);
            this.dataGridMedicamente.Name = "dataGridMedicamente";
            this.dataGridMedicamente.RowHeadersWidth = 51;
            this.dataGridMedicamente.RowTemplate.Height = 24;
            this.dataGridMedicamente.Size = new System.Drawing.Size(374, 510);
            this.dataGridMedicamente.TabIndex = 22;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFiltrare,
            this.menuSalvare});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1450, 28);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuFiltrare
            // 
            this.menuFiltrare.Name = "menuFiltrare";
            this.menuFiltrare.Size = new System.Drawing.Size(226, 26);
            this.menuFiltrare.Text = "Filtrare medicamente cantitate";
            this.menuFiltrare.Click += new System.EventHandler(this.filtrareMed);
            // 
            // menuSalvare
            // 
            this.menuSalvare.Name = "menuSalvare";
            this.menuSalvare.Size = new System.Drawing.Size(123, 26);
            this.menuSalvare.Text = "Salvare in fisier";
            this.menuSalvare.Click += new System.EventHandler(this.salvareInFisierToolStripMenuItem_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(436, 47);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 17);
            this.lblID.TabIndex = 25;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(378, 559);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 17);
            this.lblMesaj.TabIndex = 30;
            // 
            // dtpLow
            // 
            this.dtpLow.Location = new System.Drawing.Point(178, 511);
            this.dtpLow.Name = "dtpLow";
            this.dtpLow.Size = new System.Drawing.Size(200, 22);
            this.dtpLow.TabIndex = 31;
            // 
            // dtpHigh
            // 
            this.dtpHigh.Location = new System.Drawing.Point(178, 539);
            this.dtpHigh.Name = "dtpHigh";
            this.dtpHigh.Size = new System.Drawing.Size(200, 22);
            this.dtpHigh.TabIndex = 32;
            // 
            // btnDataF
            // 
            this.btnDataF.Location = new System.Drawing.Point(12, 510);
            this.btnDataF.Name = "btnDataF";
            this.btnDataF.Size = new System.Drawing.Size(130, 23);
            this.btnDataF.TabIndex = 33;
            this.btnDataF.Text = "Filtrare dupa data";
            this.btnDataF.UseVisualStyleBackColor = true;
            this.btnDataF.Click += new System.EventHandler(this.btnDataF_Click);
            // 
            // btnReducere
            // 
            this.btnReducere.Location = new System.Drawing.Point(178, 583);
            this.btnReducere.Name = "btnReducere";
            this.btnReducere.Size = new System.Drawing.Size(241, 23);
            this.btnReducere.TabIndex = 34;
            this.btnReducere.Text = "Reduceri";
            this.btnReducere.UseVisualStyleBackColor = true;
            this.btnReducere.Click += new System.EventHandler(this.btnReducere_Click);
            // 
            // lblReducere
            // 
            this.lblReducere.AutoSize = true;
            this.lblReducere.Location = new System.Drawing.Point(457, 28);
            this.lblReducere.Name = "lblReducere";
            this.lblReducere.Size = new System.Drawing.Size(0, 17);
            this.lblReducere.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1450, 618);
            this.Controls.Add(this.lblReducere);
            this.Controls.Add(this.btnReducere);
            this.Controls.Add(this.btnDataF);
            this.Controls.Add(this.dtpHigh);
            this.Controls.Add(this.dtpLow);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.dataGridMedicamente);
            this.Controls.Add(this.lblDoza);
            this.Controls.Add(this.cmbDoza);
            this.Controls.Add(this.lstAfisare);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.txtCantitate);
            this.Controls.Add(this.txtNume_med);
            this.Controls.Add(this.dtpData_exp);
            this.Controls.Add(this.rdboxTip);
            this.Controls.Add(this.rdboxAdministrare);
            this.Controls.Add(this.lblAdministrare);
            this.Controls.Add(this.lblTip_med);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCantitate);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.lblData_exp);
            this.Controls.Add(this.lblNume_med);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.rdboxAdministrare.ResumeLayout(false);
            this.rdboxAdministrare.PerformLayout();
            this.rdboxTip.ResumeLayout(false);
            this.rdboxTip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMedicamente)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label lblNume_med;
        private System.Windows.Forms.Label lblData_exp;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Label lblCantitate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTip_med;
        private System.Windows.Forms.Label lblAdministrare;
        private System.Windows.Forms.RadioButton rbParenteral;
        private System.Windows.Forms.RadioButton rbOrala;
        private System.Windows.Forms.GroupBox rdboxAdministrare;
        private System.Windows.Forms.GroupBox rdboxTip;
        private System.Windows.Forms.CheckBox checkVaccin;
        private System.Windows.Forms.CheckBox checkAntibiotic;
        private System.Windows.Forms.CheckBox checkVitamine;
        private System.Windows.Forms.CheckBox checkAntiinflamator;
        private System.Windows.Forms.DateTimePicker dtpData_exp;
        private System.Windows.Forms.TextBox txtNume_med;
        private System.Windows.Forms.TextBox txtCantitate;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.ListBox lstAfisare;
        private System.Windows.Forms.ComboBox cmbDoza;
        private System.Windows.Forms.Label lblDoza;
        private System.Windows.Forms.DataGridView dataGridMedicamente;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFiltrare;
        private System.Windows.Forms.ToolStripMenuItem menuSalvare;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.DateTimePicker dtpLow;
        private System.Windows.Forms.DateTimePicker dtpHigh;
        private System.Windows.Forms.Button btnDataF;
        private System.Windows.Forms.Button btnReducere;
        private System.Windows.Forms.Label lblReducere;
    }
}

