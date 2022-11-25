namespace Projet_AP2
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.tb_dp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_cdefamille = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_composition = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_effets = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_contreIndi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nud_prix = new System.Windows.Forms.NumericUpDown();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.groupBo = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_prix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_dp
            // 
            this.tb_dp.Location = new System.Drawing.Point(122, 27);
            this.tb_dp.Name = "tb_dp";
            this.tb_dp.Size = new System.Drawing.Size(177, 23);
            this.tb_dp.TabIndex = 0;
            this.tb_dp.TextChanged += new System.EventHandler(this.tb_dp_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dépôt Légale :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(378, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nom médicament :";
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(494, 27);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(177, 23);
            this.tb_nom.TabIndex = 2;
            this.tb_nom.TextChanged += new System.EventHandler(this.tb_nom_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(34, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Code Famille :";
            // 
            // tb_cdefamille
            // 
            this.tb_cdefamille.Location = new System.Drawing.Point(122, 110);
            this.tb_cdefamille.Name = "tb_cdefamille";
            this.tb_cdefamille.Size = new System.Drawing.Size(177, 23);
            this.tb_cdefamille.TabIndex = 4;
            this.tb_cdefamille.TextChanged += new System.EventHandler(this.tb_cdefamille_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(74, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Effets :";
            // 
            // tb_composition
            // 
            this.tb_composition.Location = new System.Drawing.Point(494, 110);
            this.tb_composition.Name = "tb_composition";
            this.tb_composition.Size = new System.Drawing.Size(177, 23);
            this.tb_composition.TabIndex = 6;
            this.tb_composition.TextChanged += new System.EventHandler(this.tb_composition_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(406, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Composition :";
            // 
            // tb_effets
            // 
            this.tb_effets.Location = new System.Drawing.Point(122, 190);
            this.tb_effets.Name = "tb_effets";
            this.tb_effets.Size = new System.Drawing.Size(177, 23);
            this.tb_effets.TabIndex = 8;
            this.tb_effets.TextChanged += new System.EventHandler(this.tb_effets_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(383, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Contre Indication :";
            // 
            // tb_contreIndi
            // 
            this.tb_contreIndi.Location = new System.Drawing.Point(494, 190);
            this.tb_contreIndi.Name = "tb_contreIndi";
            this.tb_contreIndi.Size = new System.Drawing.Size(177, 23);
            this.tb_contreIndi.TabIndex = 10;
            this.tb_contreIndi.TextChanged += new System.EventHandler(this.tb_contreIndi_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(21, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Prix échantillon :";
            // 
            // nud_prix
            // 
            this.nud_prix.Location = new System.Drawing.Point(122, 264);
            this.nud_prix.Name = "nud_prix";
            this.nud_prix.Size = new System.Drawing.Size(120, 23);
            this.nud_prix.TabIndex = 14;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ajouter.Enabled = false;
            this.btn_ajouter.ForeColor = System.Drawing.Color.Black;
            this.btn_ajouter.Location = new System.Drawing.Point(430, 287);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(137, 43);
            this.btn_ajouter.TabIndex = 15;
            this.btn_ajouter.Text = "AJOUTER";
            this.btn_ajouter.UseVisualStyleBackColor = false;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(44, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(701, 44);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // groupBo
            // 
            this.groupBo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBo.Controls.Add(this.btn_ajouter);
            this.groupBo.Controls.Add(this.nud_prix);
            this.groupBo.Controls.Add(this.label7);
            this.groupBo.Controls.Add(this.label6);
            this.groupBo.Controls.Add(this.tb_contreIndi);
            this.groupBo.Controls.Add(this.label5);
            this.groupBo.Controls.Add(this.tb_effets);
            this.groupBo.Controls.Add(this.label4);
            this.groupBo.Controls.Add(this.tb_composition);
            this.groupBo.Controls.Add(this.label3);
            this.groupBo.Controls.Add(this.tb_cdefamille);
            this.groupBo.Controls.Add(this.label2);
            this.groupBo.Controls.Add(this.tb_nom);
            this.groupBo.Controls.Add(this.label1);
            this.groupBo.Controls.Add(this.tb_dp);
            this.groupBo.Location = new System.Drawing.Point(30, 76);
            this.groupBo.Name = "groupBo";
            this.groupBo.Size = new System.Drawing.Size(734, 355);
            this.groupBo.TabIndex = 17;
            this.groupBo.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.Text = "GSB - Ajout d\'un nouveau médicament";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_prix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBo.ResumeLayout(false);
            this.groupBo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox tb_dp;
        private Label label1;
        private Label label2;
        private TextBox tb_nom;
        private Label label3;
        private TextBox tb_cdefamille;
        private Label label4;
        private TextBox tb_composition;
        private Label label5;
        private TextBox tb_effets;
        private Label label6;
        private TextBox tb_contreIndi;
        private Label label7;
        private NumericUpDown nud_prix;
        private Button btn_ajouter;
        private PictureBox pictureBox1;
        private HelpProvider helpProvider1;
        private GroupBox groupBo;
    }
}