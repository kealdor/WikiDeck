namespace WikiDeck
{
    partial class FormColorLegend
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
            this.labelBadFormat = new System.Windows.Forms.Label();
            this.labelUnknownCard = new System.Windows.Forms.Label();
            this.labelValid = new System.Windows.Forms.Label();
            this.labelDuplicate = new System.Windows.Forms.Label();
            this.labelMaxExceeded = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBadFormat
            // 
            this.labelBadFormat.BackColor = System.Drawing.Color.White;
            this.labelBadFormat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelBadFormat.Location = new System.Drawing.Point(12, 33);
            this.labelBadFormat.Name = "labelBadFormat";
            this.labelBadFormat.Size = new System.Drawing.Size(168, 23);
            this.labelBadFormat.TabIndex = 0;
            this.labelBadFormat.Text = "Invalid entry format";
            this.labelBadFormat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelUnknownCard
            // 
            this.labelUnknownCard.BackColor = System.Drawing.Color.White;
            this.labelUnknownCard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelUnknownCard.Location = new System.Drawing.Point(12, 56);
            this.labelUnknownCard.Name = "labelUnknownCard";
            this.labelUnknownCard.Size = new System.Drawing.Size(168, 23);
            this.labelUnknownCard.TabIndex = 1;
            this.labelUnknownCard.Text = "Unkown card";
            this.labelUnknownCard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelValid
            // 
            this.labelValid.BackColor = System.Drawing.Color.White;
            this.labelValid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelValid.Location = new System.Drawing.Point(12, 10);
            this.labelValid.Name = "labelValid";
            this.labelValid.Size = new System.Drawing.Size(168, 23);
            this.labelValid.TabIndex = 2;
            this.labelValid.Text = "Valid entry";
            this.labelValid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDuplicate
            // 
            this.labelDuplicate.BackColor = System.Drawing.Color.White;
            this.labelDuplicate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelDuplicate.Location = new System.Drawing.Point(12, 79);
            this.labelDuplicate.Name = "labelDuplicate";
            this.labelDuplicate.Size = new System.Drawing.Size(168, 23);
            this.labelDuplicate.TabIndex = 3;
            this.labelDuplicate.Text = "Duplicate entry";
            this.labelDuplicate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMaxExceeded
            // 
            this.labelMaxExceeded.BackColor = System.Drawing.Color.White;
            this.labelMaxExceeded.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMaxExceeded.Location = new System.Drawing.Point(12, 102);
            this.labelMaxExceeded.Name = "labelMaxExceeded";
            this.labelMaxExceeded.Size = new System.Drawing.Size(168, 23);
            this.labelMaxExceeded.TabIndex = 4;
            this.labelMaxExceeded.Text = "Invalid amount";
            this.labelMaxExceeded.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormColorLegend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(191, 134);
            this.Controls.Add(this.labelMaxExceeded);
            this.Controls.Add(this.labelDuplicate);
            this.Controls.Add(this.labelValid);
            this.Controls.Add(this.labelUnknownCard);
            this.Controls.Add(this.labelBadFormat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormColorLegend";
            this.Text = "Validation Colors";
            this.Load += new System.EventHandler(this.FormColorLegend_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBadFormat;
        private System.Windows.Forms.Label labelUnknownCard;
        private System.Windows.Forms.Label labelValid;
        private System.Windows.Forms.Label labelDuplicate;
        private System.Windows.Forms.Label labelMaxExceeded;
    }
}