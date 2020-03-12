namespace HealthandSafetyPPW4JamesRiley
{
    partial class Form2
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
            this.lstBreakdown = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstBreakdown
            // 
            this.lstBreakdown.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnYear,
            this.columnInterest,
            this.columnAmount});
            this.lstBreakdown.FullRowSelect = true;
            this.lstBreakdown.GridLines = true;
            this.lstBreakdown.Location = new System.Drawing.Point(229, 39);
            this.lstBreakdown.Name = "lstBreakdown";
            this.lstBreakdown.Size = new System.Drawing.Size(269, 186);
            this.lstBreakdown.TabIndex = 12;
            this.lstBreakdown.UseCompatibleStateImageBehavior = false;
            this.lstBreakdown.View = System.Windows.Forms.View.Details;
            this.lstBreakdown.SelectedIndexChanged += new System.EventHandler(this.LstBreakdown_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstBreakdown);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBreakdown;
    }
}