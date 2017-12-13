namespace WikiDeck
{
    partial class FormCard
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelCardText = new System.Windows.Forms.Label();
            this.labelFlavorText = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelType = new System.Windows.Forms.Label();
            this.labelPower = new System.Windows.Forms.Label();
            this.flowLayoutPanelManaCost = new System.Windows.Forms.FlowLayoutPanel();
            this.labelOtherCard = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(12, 31);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(37, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "name";
            // 
            // labelCardText
            // 
            this.labelCardText.AutoSize = true;
            this.labelCardText.Location = new System.Drawing.Point(3, 0);
            this.labelCardText.MaximumSize = new System.Drawing.Size(262, 300);
            this.labelCardText.MinimumSize = new System.Drawing.Size(262, 0);
            this.labelCardText.Name = "labelCardText";
            this.labelCardText.Size = new System.Drawing.Size(262, 13);
            this.labelCardText.TabIndex = 1;
            this.labelCardText.Text = "labelCardText";
            // 
            // labelFlavorText
            // 
            this.labelFlavorText.AutoSize = true;
            this.labelFlavorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFlavorText.Location = new System.Drawing.Point(3, 13);
            this.labelFlavorText.Name = "labelFlavorText";
            this.labelFlavorText.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.labelFlavorText.Size = new System.Drawing.Size(33, 23);
            this.labelFlavorText.TabIndex = 2;
            this.labelFlavorText.Text = "flavor";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelCardText);
            this.flowLayoutPanel1.Controls.Add(this.labelFlavorText);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(11, 84);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(263, 157);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(12, 49);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(27, 13);
            this.labelType.TabIndex = 4;
            this.labelType.Text = "type";
            // 
            // labelPower
            // 
            this.labelPower.AutoSize = true;
            this.labelPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPower.Location = new System.Drawing.Point(12, 67);
            this.labelPower.Name = "labelPower";
            this.labelPower.Size = new System.Drawing.Size(27, 13);
            this.labelPower.TabIndex = 5;
            this.labelPower.Text = "0/0";
            // 
            // flowLayoutPanelManaCost
            // 
            this.flowLayoutPanelManaCost.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanelManaCost.Location = new System.Drawing.Point(155, 5);
            this.flowLayoutPanelManaCost.Name = "flowLayoutPanelManaCost";
            this.flowLayoutPanelManaCost.Size = new System.Drawing.Size(123, 21);
            this.flowLayoutPanelManaCost.TabIndex = 7;
            // 
            // labelOtherCard
            // 
            this.labelOtherCard.AutoSize = true;
            this.labelOtherCard.ForeColor = System.Drawing.Color.Blue;
            this.labelOtherCard.Location = new System.Drawing.Point(12, 244);
            this.labelOtherCard.Name = "labelOtherCard";
            this.labelOtherCard.Size = new System.Drawing.Size(57, 13);
            this.labelOtherCard.TabIndex = 8;
            this.labelOtherCard.Text = "Other card";
            // 
            // FormCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 264);
            this.Controls.Add(this.labelOtherCard);
            this.Controls.Add(this.flowLayoutPanelManaCost);
            this.Controls.Add(this.labelPower);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCard";
            this.Text = "Card Details";
            this.Shown += new System.EventHandler(this.FormCard_Shown);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCardText;
        private System.Windows.Forms.Label labelFlavorText;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelPower;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelManaCost;
        private System.Windows.Forms.Label labelOtherCard;
    }
}