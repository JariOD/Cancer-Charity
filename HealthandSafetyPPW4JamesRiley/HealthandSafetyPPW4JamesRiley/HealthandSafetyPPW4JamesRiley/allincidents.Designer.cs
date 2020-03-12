namespace HealthandSafetyPPW4JamesRiley
{
    partial class allincidents
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
            this.listViewData = new System.Windows.Forms.ListView();
            this.clmId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.incidenttype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.location = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.treatment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.followup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openform = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.chkFollowUp = new System.Windows.Forms.CheckBox();
            this.txtFollowUpCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.refresh = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewData
            // 
            this.listViewData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmId,
            this.name,
            this.incidenttype,
            this.description,
            this.location,
            this.treatment,
            this.followup});
            this.listViewData.GridLines = true;
            this.listViewData.Location = new System.Drawing.Point(29, 39);
            this.listViewData.Name = "listViewData";
            this.listViewData.Size = new System.Drawing.Size(738, 290);
            this.listViewData.TabIndex = 0;
            this.listViewData.UseCompatibleStateImageBehavior = false;
            this.listViewData.View = System.Windows.Forms.View.Details;
            // 
            // clmId
            // 
            this.clmId.Text = "ID";
            this.clmId.Width = 63;
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 94;
            // 
            // incidenttype
            // 
            this.incidenttype.Text = "Incident Type";
            this.incidenttype.Width = 104;
            // 
            // description
            // 
            this.description.Text = "Description";
            this.description.Width = 147;
            // 
            // location
            // 
            this.location.Text = "Location";
            this.location.Width = 101;
            // 
            // treatment
            // 
            this.treatment.Text = "Treatment";
            this.treatment.Width = 102;
            // 
            // followup
            // 
            this.followup.Text = "Follow up";
            this.followup.Width = 123;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // openform
            // 
            this.openform.Location = new System.Drawing.Point(664, 413);
            this.openform.Name = "openform";
            this.openform.Size = new System.Drawing.Size(103, 25);
            this.openform.TabIndex = 2;
            this.openform.Text = "&New Entry";
            this.openform.UseVisualStyleBackColor = true;
            this.openform.Click += new System.EventHandler(this.Openform_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(26, 368);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(79, 13);
            this.lblCount.TabIndex = 4;
            this.lblCount.Text = "Incident Count:";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(29, 385);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(76, 20);
            this.txtCount.TabIndex = 5;
            // 
            // chkFollowUp
            // 
            this.chkFollowUp.AutoSize = true;
            this.chkFollowUp.Location = new System.Drawing.Point(573, 421);
            this.chkFollowUp.Name = "chkFollowUp";
            this.chkFollowUp.Size = new System.Drawing.Size(73, 17);
            this.chkFollowUp.TabIndex = 6;
            this.chkFollowUp.Text = "Follow-Up";
            this.chkFollowUp.UseVisualStyleBackColor = true;
            this.chkFollowUp.CheckedChanged += new System.EventHandler(this.ChkFollowUp_CheckedChanged);
            // 
            // txtFollowUpCount
            // 
            this.txtFollowUpCount.Location = new System.Drawing.Point(174, 385);
            this.txtFollowUpCount.Name = "txtFollowUpCount";
            this.txtFollowUpCount.ReadOnly = true;
            this.txtFollowUpCount.Size = new System.Drawing.Size(76, 20);
            this.txtFollowUpCount.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Follow Up Count";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Public Percentage";
            // 
            // txtPercent
            // 
            this.txtPercent.Location = new System.Drawing.Point(318, 385);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.ReadOnly = true;
            this.txtPercent.Size = new System.Drawing.Size(91, 20);
            this.txtPercent.TabIndex = 9;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(443, 382);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 11;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.Button1_Click);
            // 
            // allincidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPercent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFollowUpCount);
            this.Controls.Add(this.chkFollowUp);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.openform);
            this.Controls.Add(this.listViewData);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "allincidents";
            this.Text = "Incident Log";
            this.Load += new System.EventHandler(this.Allincidents_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewData;
        private System.Windows.Forms.ColumnHeader clmId;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader incidenttype;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.ColumnHeader location;
        private System.Windows.Forms.ColumnHeader treatment;
        private System.Windows.Forms.ColumnHeader followup;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.Button openform;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.CheckBox chkFollowUp;
        private System.Windows.Forms.TextBox txtFollowUpCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPercent;
        private System.Windows.Forms.Button refresh;
    }
}