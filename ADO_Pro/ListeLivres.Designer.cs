namespace ADO_Pro
{
    partial class ListeLivres
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
            this.dgv_ListeLivres = new System.Windows.Forms.DataGridView();
            this.bsLivre = new System.Windows.Forms.BindingSource(this.components);
            this.Afficher = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Nouveau = new System.Windows.Forms.Button();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editeur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.annee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.langue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeLivres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLivre)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ListeLivres
            // 
            this.dgv_ListeLivres.AllowUserToAddRows = false;
            this.dgv_ListeLivres.AllowUserToDeleteRows = false;
            this.dgv_ListeLivres.AutoGenerateColumns = false;
            this.dgv_ListeLivres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListeLivres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.isbn,
            this.titre,
            this.prix,
            this.editeur,
            this.annee,
            this.langue});
            this.dgv_ListeLivres.DataSource = this.bsLivre;
            this.dgv_ListeLivres.Location = new System.Drawing.Point(12, 12);
            this.dgv_ListeLivres.MultiSelect = false;
            this.dgv_ListeLivres.Name = "dgv_ListeLivres";
            this.dgv_ListeLivres.ReadOnly = true;
            this.dgv_ListeLivres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListeLivres.Size = new System.Drawing.Size(743, 278);
            this.dgv_ListeLivres.TabIndex = 0;
            // 
            // Afficher
            // 
            this.Afficher.Location = new System.Drawing.Point(814, 28);
            this.Afficher.Name = "Afficher";
            this.Afficher.Size = new System.Drawing.Size(75, 23);
            this.Afficher.TabIndex = 1;
            this.Afficher.Text = "Afficher";
            this.Afficher.UseVisualStyleBackColor = true;
            this.Afficher.Click += new System.EventHandler(this.btn_Afficher_Click);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(814, 80);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(75, 23);
            this.Modifier.TabIndex = 2;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(814, 135);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(75, 23);
            this.Supprimer.TabIndex = 3;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // Nouveau
            // 
            this.Nouveau.Location = new System.Drawing.Point(814, 199);
            this.Nouveau.Name = "Nouveau";
            this.Nouveau.Size = new System.Drawing.Size(75, 23);
            this.Nouveau.TabIndex = 4;
            this.Nouveau.Text = "Nouveau";
            this.Nouveau.UseVisualStyleBackColor = true;
            this.Nouveau.Click += new System.EventHandler(this.btn_Nouveau_Click);
            // 
            // Num
            // 
            this.Num.DataPropertyName = "num";
            this.Num.HeaderText = "Numéro";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            // 
            // isbn
            // 
            this.isbn.DataPropertyName = "isbn";
            this.isbn.HeaderText = "ISBN";
            this.isbn.Name = "isbn";
            this.isbn.ReadOnly = true;
            // 
            // titre
            // 
            this.titre.DataPropertyName = "titre";
            this.titre.HeaderText = "Titre";
            this.titre.Name = "titre";
            this.titre.ReadOnly = true;
            // 
            // prix
            // 
            this.prix.DataPropertyName = "prix";
            this.prix.HeaderText = "Prix";
            this.prix.Name = "prix";
            this.prix.ReadOnly = true;
            // 
            // editeur
            // 
            this.editeur.DataPropertyName = "editeur";
            this.editeur.HeaderText = "Editeur";
            this.editeur.Name = "editeur";
            this.editeur.ReadOnly = true;
            // 
            // annee
            // 
            this.annee.DataPropertyName = "annee";
            this.annee.HeaderText = "Année";
            this.annee.Name = "annee";
            this.annee.ReadOnly = true;
            // 
            // langue
            // 
            this.langue.DataPropertyName = "langue";
            this.langue.HeaderText = "Langue";
            this.langue.Name = "langue";
            this.langue.ReadOnly = true;
            // 
            // ListeLivres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 302);
            this.Controls.Add(this.Nouveau);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Afficher);
            this.Controls.Add(this.dgv_ListeLivres);
            this.Name = "ListeLivres";
            this.Text = "ListeLivres";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeLivres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLivre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ListeLivres;
        private System.Windows.Forms.Button Afficher;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button Nouveau;
        private System.Windows.Forms.BindingSource bsLivre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn editeur;
        private System.Windows.Forms.DataGridViewTextBoxColumn annee;
        private System.Windows.Forms.DataGridViewTextBoxColumn langue;
    }
}