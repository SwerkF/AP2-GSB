namespace Projet_AP2
{
    partial class maj_etp_norme
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
            this.dtp_norme = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_norme = new System.Windows.Forms.Button();
            this.tb_norme = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lv_norme = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.dtp_norme);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_norme);
            this.groupBox1.Controls.Add(this.tb_norme);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lv_norme);
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(1086, 687);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dtp_norme
            // 
            this.dtp_norme.Location = new System.Drawing.Point(485, 371);
            this.dtp_norme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_norme.Name = "dtp_norme";
            this.dtp_norme.Size = new System.Drawing.Size(228, 27);
            this.dtp_norme.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(354, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(354, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Norme :";
            // 
            // btn_norme
            // 
            this.btn_norme.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_norme.Location = new System.Drawing.Point(440, 459);
            this.btn_norme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_norme.Name = "btn_norme";
            this.btn_norme.Size = new System.Drawing.Size(207, 60);
            this.btn_norme.TabIndex = 3;
            this.btn_norme.Text = "Mettre à jour";
            this.btn_norme.UseVisualStyleBackColor = true;
            this.btn_norme.Click += new System.EventHandler(this.btn_norme_Click);
            // 
            // tb_norme
            // 
            this.tb_norme.Location = new System.Drawing.Point(485, 291);
            this.tb_norme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_norme.Name = "tb_norme";
            this.tb_norme.Size = new System.Drawing.Size(228, 27);
            this.tb_norme.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(365, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mise à jour étape normée";
            // 
            // lv_norme
            // 
            this.lv_norme.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv_norme.Location = new System.Drawing.Point(305, 116);
            this.lv_norme.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lv_norme.Name = "lv_norme";
            this.lv_norme.Size = new System.Drawing.Size(491, 128);
            this.lv_norme.TabIndex = 0;
            this.lv_norme.UseCompatibleStateImageBehavior = false;
            this.lv_norme.View = System.Windows.Forms.View.Details;
            this.lv_norme.SelectedIndexChanged += new System.EventHandler(this.lv_norme_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Numero";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Libelle";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Norme";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date";
            this.columnHeader4.Width = 100;
            // 
            // maj_etp_norme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1113, 719);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "maj_etp_norme";
            this.Text = "Mise à jour étape normée";
            this.Load += new System.EventHandler(this.maj_etp_norme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtp_norme;
        private Label label3;
        private Label label2;
        private Button btn_norme;
        private TextBox tb_norme;
        private Label label1;
        private ListView lv_norme;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}