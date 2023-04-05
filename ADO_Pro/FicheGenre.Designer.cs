namespace ADO_Pro
{
    partial class FicheGenre
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
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Form_Nom = new System.Windows.Forms.Label();
            this.Form_Numéro = new System.Windows.Forms.Label();
            this.Annuler = new System.Windows.Forms.Button();
            this.Valider = new System.Windows.Forms.Button();
            this.bsGenre = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsGenre)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsGenre, "Num", true));
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(131, 28);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(86, 20);
            this.textBox4.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsGenre, "Libelle", true));
            this.textBox3.Location = new System.Drawing.Point(131, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(86, 20);
            this.textBox3.TabIndex = 16;
            // 
            // Form_Nom
            // 
            this.Form_Nom.AutoSize = true;
            this.Form_Nom.Location = new System.Drawing.Point(53, 73);
            this.Form_Nom.Name = "Form_Nom";
            this.Form_Nom.Size = new System.Drawing.Size(37, 13);
            this.Form_Nom.TabIndex = 11;
            this.Form_Nom.Text = "Libelle";
            // 
            // Form_Numéro
            // 
            this.Form_Numéro.AutoSize = true;
            this.Form_Numéro.Location = new System.Drawing.Point(53, 34);
            this.Form_Numéro.Name = "Form_Numéro";
            this.Form_Numéro.Size = new System.Drawing.Size(44, 13);
            this.Form_Numéro.TabIndex = 10;
            this.Form_Numéro.Text = "Numéro";
            // 
            // Annuler
            // 
            this.Annuler.Location = new System.Drawing.Point(22, 136);
            this.Annuler.Name = "Annuler";
            this.Annuler.Size = new System.Drawing.Size(75, 23);
            this.Annuler.TabIndex = 18;
            this.Annuler.Text = "Annuler";
            this.Annuler.UseVisualStyleBackColor = true;
            this.Annuler.Click += new System.EventHandler(this.btn_Anuler_Click);
            // 
            // Valider
            // 
            this.Valider.Location = new System.Drawing.Point(181, 136);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(75, 23);
            this.Valider.TabIndex = 19;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // bsGenre
            // 
            this.bsGenre.DataSource = typeof(ADO_Pro.Genre);
            // 
            // FicheGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 183);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.Annuler);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Form_Nom);
            this.Controls.Add(this.Form_Numéro);
            this.Name = "FicheGenre";
            this.Text = "FicheGenre";
            ((System.ComponentModel.ISupportInitialize)(this.bsGenre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Form_Nom;
        private System.Windows.Forms.Label Form_Numéro;
        private System.Windows.Forms.Button Annuler;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.BindingSource bsGenre;
    }
}