namespace HealthandSafetyPPW4JamesRiley
{
    partial class addincidents
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.clear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbfolluwupno = new System.Windows.Forms.RadioButton();
            this.rdbfolluwupyes = new System.Windows.Forms.RadioButton();
            this.comboIncident = new System.Windows.Forms.ComboBox();
            this.txtBoxTreatment = new System.Windows.Forms.RichTextBox();
            this.rdbtreatmentno = new System.Windows.Forms.RadioButton();
            this.rdbtreatmentyes = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Incident Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Location";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(39, 85);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(39, 159);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 8;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(39, 403);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 20);
            this.txtLocation.TabIndex = 13;

            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(39, 306);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(231, 54);
            this.txtDescription.TabIndex = 14;
            this.txtDescription.Text = "";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(627, 191);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(123, 43);
            this.clear.TabIndex = 16;
            this.clear.Text = "&Clear All";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(627, 260);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(123, 43);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "&Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbtreatmentno);
            this.groupBox1.Controls.Add(this.rdbtreatmentyes);
            this.groupBox1.Location = new System.Drawing.Point(348, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 73);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Treatment";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbfolluwupno);
            this.groupBox2.Controls.Add(this.rdbfolluwupyes);
            this.groupBox2.Location = new System.Drawing.Point(348, 306);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 73);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Follow up";
            // 
            // rdbfolluwupno
            // 
            this.rdbfolluwupno.AutoSize = true;
            this.rdbfolluwupno.Location = new System.Drawing.Point(113, 29);
            this.rdbfolluwupno.Name = "rdbfolluwupno";
            this.rdbfolluwupno.Size = new System.Drawing.Size(39, 17);
            this.rdbfolluwupno.TabIndex = 1;
            this.rdbfolluwupno.TabStop = true;
            this.rdbfolluwupno.Text = "No";
            this.rdbfolluwupno.UseVisualStyleBackColor = true;
            // 
            // rdbfolluwupyes
            // 
            this.rdbfolluwupyes.AutoSize = true;
            this.rdbfolluwupyes.Location = new System.Drawing.Point(21, 29);
            this.rdbfolluwupyes.Name = "rdbfolluwupyes";
            this.rdbfolluwupyes.Size = new System.Drawing.Size(43, 17);
            this.rdbfolluwupyes.TabIndex = 0;
            this.rdbfolluwupyes.TabStop = true;
            this.rdbfolluwupyes.Text = "Yes";
            this.rdbfolluwupyes.UseVisualStyleBackColor = true;
            // 
            // comboIncident
            // 
            this.comboIncident.FormattingEnabled = true;
            this.comboIncident.Items.AddRange(new object[] {
            "Public",
            "Staff",
            "Participant"});
            this.comboIncident.Location = new System.Drawing.Point(39, 229);
            this.comboIncident.Name = "comboIncident";
            this.comboIncident.Size = new System.Drawing.Size(121, 21);
            this.comboIncident.TabIndex = 20;
           
            // 
            // txtBoxTreatment
            // 
            this.txtBoxTreatment.Location = new System.Drawing.Point(348, 182);
            this.txtBoxTreatment.Name = "txtBoxTreatment";
            this.txtBoxTreatment.Size = new System.Drawing.Size(231, 54);
            this.txtBoxTreatment.TabIndex = 21;
            this.txtBoxTreatment.Text = "";
            this.txtBoxTreatment.Visible = false;
            // 
            // rdbtreatmentno
            // 
            this.rdbtreatmentno.AutoSize = true;
            this.rdbtreatmentno.Location = new System.Drawing.Point(113, 30);
            this.rdbtreatmentno.Name = "rdbtreatmentno";
            this.rdbtreatmentno.Size = new System.Drawing.Size(39, 17);
            this.rdbtreatmentno.TabIndex = 1;
            this.rdbtreatmentno.TabStop = true;
            this.rdbtreatmentno.Text = "No";
            this.rdbtreatmentno.UseVisualStyleBackColor = true;
            this.rdbtreatmentno.CheckedChanged += new System.EventHandler(this.Rdbtreatmentno_CheckedChanged);
            // 
            // rdbtreatmentyes
            // 
            this.rdbtreatmentyes.AutoSize = true;
            this.rdbtreatmentyes.Location = new System.Drawing.Point(21, 30);
            this.rdbtreatmentyes.Name = "rdbtreatmentyes";
            this.rdbtreatmentyes.Size = new System.Drawing.Size(43, 17);
            this.rdbtreatmentyes.TabIndex = 0;
            this.rdbtreatmentyes.TabStop = true;
            this.rdbtreatmentyes.Text = "Yes";
            this.rdbtreatmentyes.UseVisualStyleBackColor = true;
            this.rdbtreatmentyes.CheckedChanged += new System.EventHandler(this.Rdbtreatmentyes_CheckedChanged);
            // 
            // addincidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 470);
            this.Controls.Add(this.txtBoxTreatment);
            this.Controls.Add(this.comboIncident);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addincidents";
            this.Text = "New Incident";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbfolluwupyes;
        private System.Windows.Forms.RadioButton rdbfolluwupno;
        private System.Windows.Forms.ComboBox comboIncident;
        private System.Windows.Forms.RichTextBox txtBoxTreatment;
        private System.Windows.Forms.RadioButton rdbtreatmentno;
        private System.Windows.Forms.RadioButton rdbtreatmentyes;
    }
}

