namespace TestApp
{
    partial class Form1
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
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.lblSelectLanguage = new System.Windows.Forms.Label();
            this.lblSelectionResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Items.AddRange(new object[] {
            "English",
            "Hindic",
            "Arabic"});
            this.cmbLanguage.Location = new System.Drawing.Point(126, 72);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(121, 21);
            this.cmbLanguage.TabIndex = 0;
            this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbLanguage_SelectedIndexChanged);
            // 
            // lblSelectLanguage
            // 
            this.lblSelectLanguage.AutoSize = true;
            this.lblSelectLanguage.Location = new System.Drawing.Point(33, 75);
            this.lblSelectLanguage.Name = "lblSelectLanguage";
            this.lblSelectLanguage.Size = new System.Drawing.Size(87, 13);
            this.lblSelectLanguage.TabIndex = 1;
            this.lblSelectLanguage.Text = "Select language:";
            // 
            // lblSelectionResult
            // 
            this.lblSelectionResult.AutoSize = true;
            this.lblSelectionResult.Location = new System.Drawing.Point(123, 121);
            this.lblSelectionResult.Name = "lblSelectionResult";
            this.lblSelectionResult.Size = new System.Drawing.Size(0, 13);
            this.lblSelectionResult.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 198);
            this.Controls.Add(this.lblSelectionResult);
            this.Controls.Add(this.lblSelectLanguage);
            this.Controls.Add(this.cmbLanguage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Label lblSelectLanguage;
        private System.Windows.Forms.Label lblSelectionResult;
    }
}

