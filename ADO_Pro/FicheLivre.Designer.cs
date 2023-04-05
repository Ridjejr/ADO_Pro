namespace ADO_Pro
{
    partial class FicheLivre
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
            this.Form_Numéro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.text_num = new System.Windows.Forms.TextBox();
            this.bsLivre = new System.Windows.Forms.BindingSource(this.components);
            this.text_isbn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_titre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_prix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_editeur = new System.Windows.Forms.TextBox();
            this.text_langue = new System.Windows.Forms.TextBox();
            this.Année = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.text_annee = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsLivre)).BeginInit();
            this.SuspendLayout();
            // 
            // Form_Numéro
            // 
            this.Form_Numéro.AutoSize = true;
            this.Form_Numéro.Location = new System.Drawing.Point(54, 37);
            this.Form_Numéro.Name = "Form_Numéro";
            this.Form_Numéro.Size = new System.Drawing.Size(44, 13);
            this.Form_Numéro.TabIndex = 1;
            this.Form_Numéro.Text = "Numéro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ISBN";
            // 
            // text_num
            // 
            this.text_num.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLivre, "Num", true));
            this.text_num.Enabled = false;
            this.text_num.Location = new System.Drawing.Point(170, 34);
            this.text_num.Name = "text_num";
            this.text_num.Size = new System.Drawing.Size(100, 20);
            this.text_num.TabIndex = 3;
            // 
            // bsLivre
            // 
            this.bsLivre.DataSource = typeof(ADO_Pro.Livre);
            // 
            // text_isbn
            // 
            this.text_isbn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLivre, "Isbn", true));
            this.text_isbn.Location = new System.Drawing.Point(170, 89);
            this.text_isbn.Name = "text_isbn";
            this.text_isbn.Size = new System.Drawing.Size(100, 20);
            this.text_isbn.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Titre";
            // 
            // text_titre
            // 
            this.text_titre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLivre, "Titre", true));
            this.text_titre.Location = new System.Drawing.Point(170, 145);
            this.text_titre.Name = "text_titre";
            this.text_titre.Size = new System.Drawing.Size(100, 20);
            this.text_titre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prix";
            // 
            // text_prix
            // 
            this.text_prix.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLivre, "Prix", true));
            this.text_prix.Location = new System.Drawing.Point(170, 210);
            this.text_prix.Name = "text_prix";
            this.text_prix.Size = new System.Drawing.Size(100, 20);
            this.text_prix.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Editeur";
            // 
            // text_editeur
            // 
            this.text_editeur.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLivre, "Editeur", true));
            this.text_editeur.Location = new System.Drawing.Point(170, 273);
            this.text_editeur.Name = "text_editeur";
            this.text_editeur.Size = new System.Drawing.Size(100, 20);
            this.text_editeur.TabIndex = 10;
            // 
            // text_langue
            // 
            this.text_langue.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLivre, "Langue", true));
            this.text_langue.Location = new System.Drawing.Point(170, 404);
            this.text_langue.Name = "text_langue";
            this.text_langue.Size = new System.Drawing.Size(100, 20);
            this.text_langue.TabIndex = 11;
            // 
            // Année
            // 
            this.Année.AutoSize = true;
            this.Année.Location = new System.Drawing.Point(55, 333);
            this.Année.Name = "Année";
            this.Année.Size = new System.Drawing.Size(38, 13);
            this.Année.TabIndex = 12;
            this.Année.Text = "Année";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Annuler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_Anuler_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(263, 458);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Valider";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Langue";
            // 
            // text_annee
            // 
            this.text_annee.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsLivre, "Annee", true));
            this.text_annee.Location = new System.Drawing.Point(170, 333);
            this.text_annee.Name = "text_annee";
            this.text_annee.Size = new System.Drawing.Size(100, 20);
            this.text_annee.TabIndex = 16;
            // 
            // FicheLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 518);
            this.Controls.Add(this.text_annee);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Année);
            this.Controls.Add(this.text_langue);
            this.Controls.Add(this.text_editeur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_prix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_titre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_isbn);
            this.Controls.Add(this.text_num);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Form_Numéro);
            this.Name = "FicheLivre";
            this.Text = "FicheLivre";
            ((System.ComponentModel.ISupportInitialize)(this.bsLivre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Form_Numéro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_num;
        private System.Windows.Forms.TextBox text_isbn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_titre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_prix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_editeur;
        private System.Windows.Forms.TextBox text_langue;
        private System.Windows.Forms.Label Année;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource bsLivre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_annee;
    }
}