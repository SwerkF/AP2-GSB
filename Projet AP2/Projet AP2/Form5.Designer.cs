namespace Projet_AP2
{
    partial class Form5
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lv_famille = new System.Windows.Forms.ListView();
            this.codeFamille = new System.Windows.Forms.ColumnHeader();
            this.designation = new System.Windows.Forms.ColumnHeader();
            this.nombreMedicaments = new System.Windows.Forms.ColumnHeader();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_medicaments = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lv_famille);
            this.groupBox1.Location = new System.Drawing.Point(18, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 413);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste FAMILLE";
            // 
            // lv_famille
            // 
            this.lv_famille.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codeFamille,
            this.designation,
            this.nombreMedicaments});
            this.lv_famille.Location = new System.Drawing.Point(12, 34);
            this.lv_famille.Name = "lv_famille";
            this.lv_famille.Size = new System.Drawing.Size(334, 356);
            this.lv_famille.TabIndex = 0;
            this.lv_famille.UseCompatibleStateImageBehavior = false;
            this.lv_famille.View = System.Windows.Forms.View.Details;
            this.lv_famille.SelectedIndexChanged += new System.EventHandler(this.lv_famille_SelectedIndexChanged);
            // 
            // codeFamille
            // 
            this.codeFamille.Text = "Code Famille";
            this.codeFamille.Width = 90;
            // 
            // designation
            // 
            this.designation.Text = "Designation";
            this.designation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.designation.Width = 100;
            // 
            // nombreMedicaments
            // 
            this.nombreMedicaments.Text = "Nombre Médicaments";
            this.nombreMedicaments.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nombreMedicaments.Width = 140;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_medicaments);
            this.groupBox2.Location = new System.Drawing.Point(410, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(685, 413);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste MEDICAMENTS";
            // 
            // lv_medicaments
            // 
            this.lv_medicaments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lv_medicaments.Location = new System.Drawing.Point(15, 34);
            this.lv_medicaments.Name = "lv_medicaments";
            this.lv_medicaments.Size = new System.Drawing.Size(654, 356);
            this.lv_medicaments.TabIndex = 1;
            this.lv_medicaments.UseCompatibleStateImageBehavior = false;
            this.lv_medicaments.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dépôt";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nom";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Code Fam";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Composition";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Effets";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Contre Indi";
            this.columnHeader6.Width = 150;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1112, 442);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form5";
            this.Text = "Consultation nombre médicament par famille";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ListView lv_famille;
        private ColumnHeader codeFamille;
        private ColumnHeader designation;
        private ColumnHeader nombreMedicaments;
        private GroupBox groupBox2;
        private ListView lv_medicaments;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}