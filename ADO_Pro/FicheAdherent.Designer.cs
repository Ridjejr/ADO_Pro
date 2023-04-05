namespace ADO_Pro
{
    partial class FicheAdherent
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
            this.components = new System.ComponentModel.Container();
            this.text_Num = new System.Windows.Forms.TextBox();
            this.bsAdherent = new System.Windows.Forms.BindingSource(this.components);
            this.text_Nom = new System.Windows.Forms.TextBox();
            this.text_Prenom = new System.Windows.Forms.TextBox();
            this.text_Rue = new System.Windows.Forms.TextBox();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.btn_Anuler = new System.Windows.Forms.Button();
            this.Form_Nationalite = new System.Windows.Forms.Label();
            this.Form_Prenom = new System.Windows.Forms.Label();
            this.Form_Nom = new System.Windows.Forms.Label();
            this.Form_Numéro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_Tel = new System.Windows.Forms.TextBox();
            this.text_Ville = new System.Windows.Forms.TextBox();
            this.text_Cp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_Mail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdherent)).BeginInit();
            this.SuspendLayout();
            // 
            // text_Num
            // 
            this.text_Num.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdherent, "Num", true));
            this.text_Num.Enabled = false;
            this.text_Num.Location = new System.Drawing.Point(149, 22);
            this.text_Num.Name = "text_Num";
            this.text_Num.Size = new System.Drawing.Size(86, 20);
            this.text_Num.TabIndex = 19;
            // 
            // bsAdherent
            // 
            this.bsAdherent.DataSource = typeof(ADO_Pro.Adherent);
            // 
            // text_Nom
            // 
            this.text_Nom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdherent, "Nom", true));
            this.text_Nom.Location = new System.Drawing.Point(149, 61);
            this.text_Nom.Name = "text_Nom";
            this.text_Nom.Size = new System.Drawing.Size(86, 20);
            this.text_Nom.TabIndex = 18;
            // 
            // text_Prenom
            // 
            this.text_Prenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdherent, "Prenom", true));
            this.text_Prenom.Location = new System.Drawing.Point(149, 95);
            this.text_Prenom.Name = "text_Prenom";
            this.text_Prenom.Size = new System.Drawing.Size(86, 20);
            this.text_Prenom.TabIndex = 17;
            // 
            // text_Rue
            // 
            this.text_Rue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdherent, "Rue", true));
            this.text_Rue.Location = new System.Drawing.Point(149, 130);
            this.text_Rue.Name = "text_Rue";
            this.text_Rue.Size = new System.Drawing.Size(86, 20);
            this.text_Rue.TabIndex = 16;
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(251, 362);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(64, 20);
            this.btn_Valider.TabIndex = 15;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // btn_Anuler
            // 
            this.btn_Anuler.Location = new System.Drawing.Point(51, 362);
            this.btn_Anuler.Name = "btn_Anuler";
            this.btn_Anuler.Size = new System.Drawing.Size(64, 20);
            this.btn_Anuler.TabIndex = 14;
            this.btn_Anuler.Text = "Annuler";
            this.btn_Anuler.UseVisualStyleBackColor = true;
            this.btn_Anuler.Click += new System.EventHandler(this.btn_Anuler_Click);
            // 
            // Form_Nationalite
            // 
            this.Form_Nationalite.AutoSize = true;
            this.Form_Nationalite.Location = new System.Drawing.Point(71, 137);
            this.Form_Nationalite.Name = "Form_Nationalite";
            this.Form_Nationalite.Size = new System.Drawing.Size(27, 13);
            this.Form_Nationalite.TabIndex = 13;
            this.Form_Nationalite.Text = "Rue";
            // 
            // Form_Prenom
            // 
            this.Form_Prenom.AutoSize = true;
            this.Form_Prenom.Location = new System.Drawing.Point(71, 102);
            this.Form_Prenom.Name = "Form_Prenom";
            this.Form_Prenom.Size = new System.Drawing.Size(43, 13);
            this.Form_Prenom.TabIndex = 12;
            this.Form_Prenom.Text = "Prénom";
            // 
            // Form_Nom
            // 
            this.Form_Nom.AutoSize = true;
            this.Form_Nom.Location = new System.Drawing.Point(71, 67);
            this.Form_Nom.Name = "Form_Nom";
            this.Form_Nom.Size = new System.Drawing.Size(29, 13);
            this.Form_Nom.TabIndex = 11;
            this.Form_Nom.Text = "Nom";
            // 
            // Form_Numéro
            // 
            this.Form_Numéro.AutoSize = true;
            this.Form_Numéro.Location = new System.Drawing.Point(71, 28);
            this.Form_Numéro.Name = "Form_Numéro";
            this.Form_Numéro.Size = new System.Drawing.Size(44, 13);
            this.Form_Numéro.TabIndex = 10;
            this.Form_Numéro.Text = "Numéro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ville";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Code postale";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tél";
            // 
            // text_Tel
            // 
            this.text_Tel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdherent, "Tel", true));
            this.text_Tel.Location = new System.Drawing.Point(149, 256);
            this.text_Tel.Name = "text_Tel";
            this.text_Tel.Size = new System.Drawing.Size(86, 20);
            this.text_Tel.TabIndex = 23;
            // 
            // text_Ville
            // 
            this.text_Ville.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdherent, "Ville", true));
            this.text_Ville.Location = new System.Drawing.Point(149, 212);
            this.text_Ville.Name = "text_Ville";
            this.text_Ville.Size = new System.Drawing.Size(86, 20);
            this.text_Ville.TabIndex = 24;
            // 
            // text_Cp
            // 
            this.text_Cp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdherent, "Cp", true));
            this.text_Cp.Location = new System.Drawing.Point(149, 174);
            this.text_Cp.Name = "text_Cp";
            this.text_Cp.Size = new System.Drawing.Size(86, 20);
            this.text_Cp.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Mail";
            // 
            // text_Mail
            // 
            this.text_Mail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsAdherent, "Mail", true));
            this.text_Mail.Location = new System.Drawing.Point(149, 308);
            this.text_Mail.Name = "text_Mail";
            this.text_Mail.Size = new System.Drawing.Size(86, 20);
            this.text_Mail.TabIndex = 27;
            // 
            // FicheAdherent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 422);
            this.Controls.Add(this.text_Mail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_Cp);
            this.Controls.Add(this.text_Ville);
            this.Controls.Add(this.text_Tel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_Num);
            this.Controls.Add(this.text_Nom);
            this.Controls.Add(this.text_Prenom);
            this.Controls.Add(this.text_Rue);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.btn_Anuler);
            this.Controls.Add(this.Form_Nationalite);
            this.Controls.Add(this.Form_Prenom);
            this.Controls.Add(this.Form_Nom);
            this.Controls.Add(this.Form_Numéro);
            this.Name = "FicheAdherent";
            this.Text = "FicheAdherent";
            ((System.ComponentModel.ISupportInitialize)(this.bsAdherent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_Num;
        private System.Windows.Forms.TextBox text_Nom;
        private System.Windows.Forms.TextBox text_Prenom;
        private System.Windows.Forms.TextBox text_Rue;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.Button btn_Anuler;
        private System.Windows.Forms.Label Form_Nationalite;
        private System.Windows.Forms.Label Form_Prenom;
        private System.Windows.Forms.Label Form_Nom;
        private System.Windows.Forms.Label Form_Numéro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_Tel;
        private System.Windows.Forms.TextBox text_Ville;
        private System.Windows.Forms.TextBox text_Cp;
        private System.Windows.Forms.BindingSource bsAdherent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_Mail;
    }
}