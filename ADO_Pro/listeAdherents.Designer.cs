namespace ADO_Pro
{
    partial class listeAdherents
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
            this.dgv_listeAdherents = new System.Windows.Forms.DataGridView();
            this.bsAdherent = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Numéro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prénom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tél = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeAdherents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdherent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_listeAdherents
            // 
            this.dgv_listeAdherents.AllowUserToAddRows = false;
            this.dgv_listeAdherents.AllowUserToDeleteRows = false;
            this.dgv_listeAdherents.AutoGenerateColumns = false;
            this.dgv_listeAdherents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listeAdherents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numéro,
            this.Nom,
            this.Prénom,
            this.Rue,
            this.CP,
            this.Ville,
            this.Tél,
            this.Mail});
            this.dgv_listeAdherents.DataSource = this.bsAdherent;
            this.dgv_listeAdherents.Location = new System.Drawing.Point(12, 12);
            this.dgv_listeAdherents.MultiSelect = false;
            this.dgv_listeAdherents.Name = "dgv_listeAdherents";
            this.dgv_listeAdherents.ReadOnly = true;
            this.dgv_listeAdherents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listeAdherents.Size = new System.Drawing.Size(844, 407);
            this.dgv_listeAdherents.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(910, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Afficher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_Afficher_Click);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(910, 77);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(75, 23);
            this.Modifier.TabIndex = 2;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(910, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(910, 181);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Nouveau";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_Nouveau_Click);
            // 
            // Numéro
            // 
            this.Numéro.DataPropertyName = "num";
            this.Numéro.HeaderText = "Numéro";
            this.Numéro.Name = "Numéro";
            this.Numéro.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "nom";
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Prénom
            // 
            this.Prénom.DataPropertyName = "prenom";
            this.Prénom.HeaderText = "Prénom";
            this.Prénom.Name = "Prénom";
            this.Prénom.ReadOnly = true;
            // 
            // Rue
            // 
            this.Rue.DataPropertyName = "rue";
            this.Rue.HeaderText = "Rue";
            this.Rue.Name = "Rue";
            this.Rue.ReadOnly = true;
            // 
            // CP
            // 
            this.CP.DataPropertyName = "cp";
            this.CP.HeaderText = "CP";
            this.CP.Name = "CP";
            this.CP.ReadOnly = true;
            // 
            // Ville
            // 
            this.Ville.DataPropertyName = "ville";
            this.Ville.HeaderText = "Ville";
            this.Ville.Name = "Ville";
            this.Ville.ReadOnly = true;
            // 
            // Tél
            // 
            this.Tél.DataPropertyName = "tel";
            this.Tél.HeaderText = "Tél";
            this.Tél.Name = "Tél";
            this.Tél.ReadOnly = true;
            // 
            // Mail
            // 
            this.Mail.DataPropertyName = "mail";
            this.Mail.HeaderText = "Mail";
            this.Mail.Name = "Mail";
            this.Mail.ReadOnly = true;
            // 
            // listeAdherents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 431);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_listeAdherents);
            this.Name = "listeAdherents";
            this.Text = "listeAdherents";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listeAdherents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAdherent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_listeAdherents;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource bsAdherent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numéro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prénom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rue;
        private System.Windows.Forms.DataGridViewTextBoxColumn CP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tél;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mail;
    }
}