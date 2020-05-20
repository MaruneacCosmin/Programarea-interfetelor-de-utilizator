namespace Farmacie_Form
{
    partial class Modifica
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
            this.lblDoza = new System.Windows.Forms.Label();
            this.cmbDoza = new System.Windows.Forms.ComboBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.txtCantitate = new System.Windows.Forms.TextBox();
            this.txtNume_med = new System.Windows.Forms.TextBox();
            this.dtpData_exp = new System.Windows.Forms.DateTimePicker();
            this.rdboxTip = new System.Windows.Forms.GroupBox();
            this.checkAntiinflamator = new System.Windows.Forms.CheckBox();
            this.checkVitamine = new System.Windows.Forms.CheckBox();
            this.checkVaccin = new System.Windows.Forms.CheckBox();
            this.checkAntibiotic = new System.Windows.Forms.CheckBox();
            this.rdboxAdministrare = new System.Windows.Forms.GroupBox();
            this.rbOrala = new System.Windows.Forms.RadioButton();
            this.rbParenteral = new System.Windows.Forms.RadioButton();
            this.lblAdministrare = new System.Windows.Forms.Label();
            this.lblTip_med = new System.Windows.Forms.Label();
            this.lblCantitate = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.lblData_exp = new System.Windows.Forms.Label();
            this.lblNume_med = new System.Windows.Forms.Label();
            this.btnModifica = new System.Windows.Forms.Button();
            this.rdboxTip.SuspendLayout();
            this.rdboxAdministrare.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDoza
            // 
            this.lblDoza.AutoSize = true;
            this.lblDoza.Location = new System.Drawing.Point(31, 360);
            this.lblDoza.Name = "lblDoza";
            this.lblDoza.Size = new System.Drawing.Size(41, 17);
            this.lblDoza.TabIndex = 42;
            this.lblDoza.Text = "Doză";
            // 
            // cmbDoza
            // 
            this.cmbDoza.FormattingEnabled = true;
            this.cmbDoza.Items.AddRange(new object[] {
            "250",
            "500",
            "1000"});
            this.cmbDoza.Location = new System.Drawing.Point(170, 360);
            this.cmbDoza.Name = "cmbDoza";
            this.cmbDoza.Size = new System.Drawing.Size(242, 24);
            this.cmbDoza.TabIndex = 41;
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(170, 100);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(242, 22);
            this.txtPret.TabIndex = 40;
            // 
            // txtCantitate
            // 
            this.txtCantitate.Location = new System.Drawing.Point(170, 138);
            this.txtCantitate.Name = "txtCantitate";
            this.txtCantitate.Size = new System.Drawing.Size(242, 22);
            this.txtCantitate.TabIndex = 39;
            // 
            // txtNume_med
            // 
            this.txtNume_med.Location = new System.Drawing.Point(170, 28);
            this.txtNume_med.Name = "txtNume_med";
            this.txtNume_med.Size = new System.Drawing.Size(242, 22);
            this.txtNume_med.TabIndex = 38;
            // 
            // dtpData_exp
            // 
            this.dtpData_exp.Location = new System.Drawing.Point(170, 66);
            this.dtpData_exp.Name = "dtpData_exp";
            this.dtpData_exp.Size = new System.Drawing.Size(242, 22);
            this.dtpData_exp.TabIndex = 37;
            // 
            // rdboxTip
            // 
            this.rdboxTip.Controls.Add(this.checkAntiinflamator);
            this.rdboxTip.Controls.Add(this.checkVitamine);
            this.rdboxTip.Controls.Add(this.checkVaccin);
            this.rdboxTip.Controls.Add(this.checkAntibiotic);
            this.rdboxTip.Location = new System.Drawing.Point(170, 257);
            this.rdboxTip.Name = "rdboxTip";
            this.rdboxTip.Size = new System.Drawing.Size(242, 88);
            this.rdboxTip.TabIndex = 36;
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
            // 
            // rdboxAdministrare
            // 
            this.rdboxAdministrare.Controls.Add(this.rbOrala);
            this.rdboxAdministrare.Controls.Add(this.rbParenteral);
            this.rdboxAdministrare.Location = new System.Drawing.Point(170, 170);
            this.rdboxAdministrare.Name = "rdboxAdministrare";
            this.rdboxAdministrare.Size = new System.Drawing.Size(242, 68);
            this.rdboxAdministrare.TabIndex = 35;
            this.rdboxAdministrare.TabStop = false;
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
            // lblAdministrare
            // 
            this.lblAdministrare.AutoSize = true;
            this.lblAdministrare.Location = new System.Drawing.Point(27, 188);
            this.lblAdministrare.Name = "lblAdministrare";
            this.lblAdministrare.Size = new System.Drawing.Size(87, 17);
            this.lblAdministrare.TabIndex = 34;
            this.lblAdministrare.Text = "Administrare";
            // 
            // lblTip_med
            // 
            this.lblTip_med.AutoSize = true;
            this.lblTip_med.Location = new System.Drawing.Point(27, 278);
            this.lblTip_med.Name = "lblTip_med";
            this.lblTip_med.Size = new System.Drawing.Size(108, 17);
            this.lblTip_med.TabIndex = 33;
            this.lblTip_med.Text = "Tip Medicament";
            // 
            // lblCantitate
            // 
            this.lblCantitate.AutoSize = true;
            this.lblCantitate.Location = new System.Drawing.Point(27, 141);
            this.lblCantitate.Name = "lblCantitate";
            this.lblCantitate.Size = new System.Drawing.Size(64, 17);
            this.lblCantitate.TabIndex = 32;
            this.lblCantitate.Text = "Cantitate";
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Location = new System.Drawing.Point(27, 103);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(34, 17);
            this.lblPret.TabIndex = 31;
            this.lblPret.Text = "Pret";
            // 
            // lblData_exp
            // 
            this.lblData_exp.AutoSize = true;
            this.lblData_exp.Location = new System.Drawing.Point(27, 66);
            this.lblData_exp.Name = "lblData_exp";
            this.lblData_exp.Size = new System.Drawing.Size(91, 17);
            this.lblData_exp.TabIndex = 30;
            this.lblData_exp.Text = "Data expirarii";
            // 
            // lblNume_med
            // 
            this.lblNume_med.AutoSize = true;
            this.lblNume_med.Location = new System.Drawing.Point(27, 28);
            this.lblNume_med.Name = "lblNume_med";
            this.lblNume_med.Size = new System.Drawing.Size(125, 17);
            this.lblNume_med.TabIndex = 29;
            this.lblNume_med.Text = "Nume medicament";
            // 
            // btnModifica
            // 
            this.btnModifica.Location = new System.Drawing.Point(233, 450);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(107, 25);
            this.btnModifica.TabIndex = 45;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // Modifica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 505);
            this.Controls.Add(this.btnModifica);
            this.Controls.Add(this.lblDoza);
            this.Controls.Add(this.cmbDoza);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.txtCantitate);
            this.Controls.Add(this.txtNume_med);
            this.Controls.Add(this.dtpData_exp);
            this.Controls.Add(this.rdboxTip);
            this.Controls.Add(this.rdboxAdministrare);
            this.Controls.Add(this.lblAdministrare);
            this.Controls.Add(this.lblTip_med);
            this.Controls.Add(this.lblCantitate);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.lblData_exp);
            this.Controls.Add(this.lblNume_med);
            this.Name = "Modifica";
            this.Text = "Modifica";
            this.rdboxTip.ResumeLayout(false);
            this.rdboxTip.PerformLayout();
            this.rdboxAdministrare.ResumeLayout(false);
            this.rdboxAdministrare.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDoza;
        private System.Windows.Forms.ComboBox cmbDoza;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.TextBox txtCantitate;
        private System.Windows.Forms.TextBox txtNume_med;
        private System.Windows.Forms.DateTimePicker dtpData_exp;
        private System.Windows.Forms.GroupBox rdboxTip;
        private System.Windows.Forms.CheckBox checkAntiinflamator;
        private System.Windows.Forms.CheckBox checkVitamine;
        private System.Windows.Forms.CheckBox checkVaccin;
        private System.Windows.Forms.CheckBox checkAntibiotic;
        private System.Windows.Forms.GroupBox rdboxAdministrare;
        private System.Windows.Forms.RadioButton rbOrala;
        private System.Windows.Forms.RadioButton rbParenteral;
        private System.Windows.Forms.Label lblAdministrare;
        private System.Windows.Forms.Label lblTip_med;
        private System.Windows.Forms.Label lblCantitate;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Label lblData_exp;
        private System.Windows.Forms.Label lblNume_med;
        private System.Windows.Forms.Button btnModifica;
    }
}