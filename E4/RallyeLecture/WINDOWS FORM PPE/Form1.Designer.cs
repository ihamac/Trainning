namespace WINDOWS_FORM_PPE
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbNiveau = new System.Windows.Forms.ComboBox();
            this.cbListBox = new System.Windows.Forms.CheckedListBox();
            this.fichers = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.construit = new System.Windows.Forms.RadioButton();
            this.aléatoire = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Lancer l\'intégration";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "répertoire des fichiers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "fichier csv à integrer :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "mot de passe : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "année scolaire";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "niveau :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(293, 242);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // cmbNiveau
            // 
            this.cmbNiveau.FormattingEnabled = true;
            this.cmbNiveau.Location = new System.Drawing.Point(293, 274);
            this.cmbNiveau.Name = "cmbNiveau";
            this.cmbNiveau.Size = new System.Drawing.Size(121, 21);
            this.cmbNiveau.TabIndex = 12;
            this.cmbNiveau.Text = "choisir le niveau";
            this.cmbNiveau.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cbListBox
            // 
            this.cbListBox.FormattingEnabled = true;
            this.cbListBox.Location = new System.Drawing.Point(293, 77);
            this.cbListBox.Name = "cbListBox";
            this.cbListBox.Size = new System.Drawing.Size(431, 139);
            this.cbListBox.TabIndex = 13;
            // 
            // fichers
            // 
            this.fichers.FormattingEnabled = true;
            this.fichers.Location = new System.Drawing.Point(304, 16);
            this.fichers.Name = "fichers";
            this.fichers.Size = new System.Drawing.Size(322, 21);
            this.fichers.TabIndex = 15;
            this.fichers.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.construit);
            this.panel1.Controls.Add(this.aléatoire);
            this.panel1.Location = new System.Drawing.Point(293, 307);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 34);
            this.panel1.TabIndex = 17;
            // 
            // construit
            // 
            this.construit.AutoSize = true;
            this.construit.Location = new System.Drawing.Point(149, 15);
            this.construit.Name = "construit";
            this.construit.Size = new System.Drawing.Size(65, 17);
            this.construit.TabIndex = 1;
            this.construit.TabStop = true;
            this.construit.Text = "construit";
            this.construit.UseVisualStyleBackColor = true;
            // 
            // aléatoire
            // 
            this.aléatoire.AutoSize = true;
            this.aléatoire.Location = new System.Drawing.Point(3, 14);
            this.aléatoire.Name = "aléatoire";
            this.aléatoire.Size = new System.Drawing.Size(65, 17);
            this.aléatoire.TabIndex = 0;
            this.aléatoire.TabStop = true;
            this.aléatoire.Text = "aléatoire";
            this.aléatoire.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fichers);
            this.Controls.Add(this.cbListBox);
            this.Controls.Add(this.cmbNiveau);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cmbNiveau;
        private System.Windows.Forms.CheckedListBox cbListBox;
        private System.Windows.Forms.ComboBox fichers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton construit;
        private System.Windows.Forms.RadioButton aléatoire;
    }
}

