namespace Projet_AP2
{
    partial class Form6
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lv_etapes = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lv_med = new System.Windows.Forms.ListView();
            this.codeFamille = new System.Windows.Forms.ColumnHeader();
            this.designation = new System.Windows.Forms.ColumnHeader();
            this.nombreMedicaments = new System.Windows.Forms.ColumnHeader();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lv_etapes);
            this.groupBox2.Location = new System.Drawing.Point(415, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 413);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Workflow ETAPES";
            // 
            // lv_etapes
            // 
            this.lv_etapes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv_etapes.Location = new System.Drawing.Point(15, 34);
            this.lv_etapes.Name = "lv_etapes";
            this.lv_etapes.Size = new System.Drawing.Size(334, 356);
            this.lv_etapes.TabIndex = 1;
            this.lv_etapes.UseCompatibleStateImageBehavior = false;
            this.lv_etapes.View = System.Windows.Forms.View.Details;
            this.lv_etapes.SelectedIndexChanged += new System.EventHandler(this.lv_etapes_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Dépôt";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Etape Num";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Décision";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date";
            this.columnHeader4.Width = 100;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lv_med);
            this.groupBox1.Location = new System.Drawing.Point(23, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 413);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "liste MEDICAMENTS";
            // 
            // lv_med
            // 
            this.lv_med.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codeFamille,
            this.designation,
            this.nombreMedicaments});
            this.lv_med.Location = new System.Drawing.Point(12, 34);
            this.lv_med.Name = "lv_med";
            this.lv_med.Size = new System.Drawing.Size(334, 356);
            this.lv_med.TabIndex = 0;
            this.lv_med.UseCompatibleStateImageBehavior = false;
            this.lv_med.View = System.Windows.Forms.View.Details;
            this.lv_med.SelectedIndexChanged += new System.EventHandler(this.lv_med_SelectedIndexChanged);
            // 
            // codeFamille
            // 
            this.codeFamille.Text = "Dépôt légal";
            this.codeFamille.Width = 90;
            // 
            // designation
            // 
            this.designation.Text = "Nom Commercial";
            this.designation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.designation.Width = 150;
            // 
            // nombreMedicaments
            // 
            this.nombreMedicaments.Text = "Famille";
            this.nombreMedicaments.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nombreMedicaments.Width = 90;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form6";
            this.Text = "Consultation médicament en cours de validation";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private ListView lv_etapes;
        private GroupBox groupBox1;
        private ListView lv_med;
        private ColumnHeader codeFamille;
        private ColumnHeader designation;
        private ColumnHeader nombreMedicaments;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}