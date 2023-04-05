
namespace ADO_Pro
{
    partial class FicheAuteur
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
            this.Form_Nom = new System.Windows.Forms.Label();
            this.Form_Prenom = new System.Windows.Forms.Label();
            this.Form_Nationalite = new System.Windows.Forms.Label();
            this.btn_Anuler = new System.Windows.Forms.Button();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // Form_Numéro
            // 
            this.Form_Numéro.AutoSize = true;
            this.Form_Numéro.Location = new System.Drawing.Point(51, 29);
            this.Form_Numéro.Name = "Form_Numéro";
            this.Form_Numéro.Size = new System.Drawing.Size(44, 13);
            this.Form_Numéro.TabIndex = 0;
            this.Form_Numéro.Text = "Numéro";
            // 
            // Form_Nom
            // 
            this.Form_Nom.AutoSize = true;
            this.Form_Nom.Location = new System.Drawing.Point(51, 68);
            this.Form_Nom.Name = "Form_Nom";
            this.Form_Nom.Size = new System.Drawing.Size(29, 13);
            this.Form_Nom.TabIndex = 1;
            this.Form_Nom.Text = "Nom";
            // 
            // Form_Prenom
            // 
            this.Form_Prenom.AutoSize = true;
            this.Form_Prenom.Location = new System.Drawing.Point(51, 103);
            this.Form_Prenom.Name = "Form_Prenom";
            this.Form_Prenom.Size = new System.Drawing.Size(43, 13);
            this.Form_Prenom.TabIndex = 2;
            this.Form_Prenom.Text = "Prénom";
            // 
            // Form_Nationalite
            // 
            this.Form_Nationalite.AutoSize = true;
            this.Form_Nationalite.Location = new System.Drawing.Point(51, 138);
            this.Form_Nationalite.Name = "Form_Nationalite";
            this.Form_Nationalite.Size = new System.Drawing.Size(57, 13);
            this.Form_Nationalite.TabIndex = 3;
            this.Form_Nationalite.Text = "Nationalité";
            // 
            // btn_Anuler
            // 
            this.btn_Anuler.Location = new System.Drawing.Point(16, 195);
            this.btn_Anuler.Name = "btn_Anuler";
            this.btn_Anuler.Size = new System.Drawing.Size(64, 20);
            this.btn_Anuler.TabIndex = 4;
            this.btn_Anuler.Text = "Annuler";
            this.btn_Anuler.UseVisualStyleBackColor = true;
            this.btn_Anuler.Click += new System.EventHandler(this.btn_Anuler_Click);
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(208, 195);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(64, 20);
            this.btn_Valider.TabIndex = 5;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Nationalite", true));
            this.textBox1.Location = new System.Drawing.Point(129, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 20);
            this.textBox1.TabIndex = 6;
            // 
            // bs
            // 
            this.bs.DataSource = typeof(ADO_Pro.Auteur);
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Prenom", true));
            this.textBox2.Location = new System.Drawing.Point(129, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(86, 20);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Nom", true));
            this.textBox3.Location = new System.Drawing.Point(129, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(86, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "Num", true));
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(129, 23);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(86, 20);
            this.textBox4.TabIndex = 9;
            // 
            // FicheAuteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 263);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.btn_Anuler);
            this.Controls.Add(this.Form_Nationalite);
            this.Controls.Add(this.Form_Prenom);
            this.Controls.Add(this.Form_Nom);
            this.Controls.Add(this.Form_Numéro);
            this.Name = "FicheAuteur";
            this.Text = "FicheAuteur";
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Form_Numéro;
        private System.Windows.Forms.Label Form_Nom;
        private System.Windows.Forms.Label Form_Prenom;
        private System.Windows.Forms.Label Form_Nationalite;
        private System.Windows.Forms.Button btn_Anuler;
        private System.Windows.Forms.Button btn_Valider;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.BindingSource bs;
    }
}