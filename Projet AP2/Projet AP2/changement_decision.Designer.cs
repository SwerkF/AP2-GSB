namespace Projet_AP2
{
    partial class changement_decision
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
            this.dtp_etape = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lv_next_etape = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.btn_refuser = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lv_workflow = new System.Windows.Forms.ListView();
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
            this.groupBox1.Controls.Add(this.dtp_etape);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lv_next_etape);
            this.groupBox1.Controls.Add(this.btn_refuser);
            this.groupBox1.Controls.Add(this.btn_valider);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lv_workflow);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(937, 522);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dtp_etape
            // 
            this.dtp_etape.Location = new System.Drawing.Point(520, 108);
            this.dtp_etape.Name = "dtp_etape";
            this.dtp_etape.Size = new System.Drawing.Size(274, 23);
            this.dtp_etape.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(30, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Etape suivante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Liste des workflows";
            // 
            // lv_next_etape
            // 
            this.lv_next_etape.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader9,
            this.columnHeader10});
            this.lv_next_etape.Location = new System.Drawing.Point(30, 260);
            this.lv_next_etape.Name = "lv_next_etape";
            this.lv_next_etape.Size = new System.Drawing.Size(448, 57);
            this.lv_next_etape.TabIndex = 8;
            this.lv_next_etape.UseCompatibleStateImageBehavior = false;
            this.lv_next_etape.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Numero";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Libelle";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Norme";
            this.columnHeader9.Width = 80;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Date Norme";
            this.columnHeader10.Width = 120;
            // 
            // btn_refuser
            // 
            this.btn_refuser.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_refuser.Location = new System.Drawing.Point(532, 437);
            this.btn_refuser.Name = "btn_refuser";
            this.btn_refuser.Size = new System.Drawing.Size(129, 33);
            this.btn_refuser.TabIndex = 3;
            this.btn_refuser.Text = "Refuser";
            this.btn_refuser.UseVisualStyleBackColor = true;
            this.btn_refuser.Click += new System.EventHandler(this.btn_refuser_Click);
            // 
            // btn_valider
            // 
            this.btn_valider.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_valider.Location = new System.Drawing.Point(275, 437);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(129, 33);
            this.btn_valider.TabIndex = 2;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(293, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Validation d\'une étape";
            // 
            // lv_workflow
            // 
            this.lv_workflow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lv_workflow.Location = new System.Drawing.Point(30, 108);
            this.lv_workflow.Name = "lv_workflow";
            this.lv_workflow.Size = new System.Drawing.Size(448, 111);
            this.lv_workflow.TabIndex = 0;
            this.lv_workflow.UseCompatibleStateImageBehavior = false;
            this.lv_workflow.View = System.Windows.Forms.View.Details;
            this.lv_workflow.SelectedIndexChanged += new System.EventHandler(this.lv_workflow_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Depot";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Libelle";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Num Etape";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Libelle";
            this.columnHeader4.Width = 160;
            // 
            // changement_decision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(961, 546);
            this.Controls.Add(this.groupBox1);
            this.Name = "changement_decision";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.changement_decision_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ListView lv_workflow;
        private Label label1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Button btn_refuser;
        private Button btn_valider;
        private Label label3;
        private ListView lv_next_etape;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private Label label4;
        private DateTimePicker dtp_etape;
    }
}