namespace ADO_Pro
{
    partial class ListeGenres
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
            this.dgv_ListeGenres = new System.Windows.Forms.DataGridView();
            this.bsGenre = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeGenres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGenre)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ListeGenres
            // 
            this.dgv_ListeGenres.AllowUserToAddRows = false;
            this.dgv_ListeGenres.AllowUserToDeleteRows = false;
            this.dgv_ListeGenres.AutoGenerateColumns = false;
            this.dgv_ListeGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListeGenres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Column1});
            this.dgv_ListeGenres.DataSource = this.bsGenre;
            this.dgv_ListeGenres.Location = new System.Drawing.Point(-15, -2);
            this.dgv_ListeGenres.MultiSelect = false;
            this.dgv_ListeGenres.Name = "dgv_ListeGenres";
            this.dgv_ListeGenres.ReadOnly = true;
            this.dgv_ListeGenres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ListeGenres.Size = new System.Drawing.Size(403, 363);
            this.dgv_ListeGenres.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Afficher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_Afficher_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(294, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(294, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(294, 149);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Nouveau";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn_Nouveau_Click);
            // 
            // Numero
            // 
            this.Numero.DataPropertyName = "num";
            this.Numero.HeaderText = "Numéro";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "libelle";
            this.Column1.HeaderText = "Libelle";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // ListeGenres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 373);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_ListeGenres);
            this.Name = "ListeGenres";
            this.Text = "Genre";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListeGenres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGenre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ListeGenres;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingSource bsGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}