namespace WikiDeck
{
    partial class FormCardFilter
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
            System.Windows.Forms.GroupBox groupBoxColors;
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxBlack = new System.Windows.Forms.CheckBox();
            this.checkBoxBlue = new System.Windows.Forms.CheckBox();
            this.checkBoxWhite = new System.Windows.Forms.CheckBox();
            this.checkBoxGreen = new System.Windows.Forms.CheckBox();
            this.checkBoxRed = new System.Windows.Forms.CheckBox();
            this.checkBoxColorless = new System.Windows.Forms.CheckBox();
            groupBoxColors = new System.Windows.Forms.GroupBox();
            groupBoxColors.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxColors
            // 
            groupBoxColors.Controls.Add(this.flowLayoutPanel1);
            groupBoxColors.Location = new System.Drawing.Point(12, 13);
            groupBoxColors.Name = "groupBoxColors";
            groupBoxColors.Size = new System.Drawing.Size(60, 196);
            groupBoxColors.TabIndex = 1;
            groupBoxColors.TabStop = false;
            groupBoxColors.Text = "Colors";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxBlack);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxBlue);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxWhite);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxGreen);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxRed);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxColorless);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 16);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(48, 172);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // checkBoxBlack
            // 
            this.checkBoxBlack.Image = global::WikiDeck.Properties.Resources.Color_B;
            this.checkBoxBlack.Location = new System.Drawing.Point(3, 3);
            this.checkBoxBlack.Name = "checkBoxBlack";
            this.checkBoxBlack.Size = new System.Drawing.Size(41, 22);
            this.checkBoxBlack.TabIndex = 2;
            this.checkBoxBlack.UseVisualStyleBackColor = true;
            // 
            // checkBoxBlue
            // 
            this.checkBoxBlue.Image = global::WikiDeck.Properties.Resources.Color_U;
            this.checkBoxBlue.Location = new System.Drawing.Point(3, 31);
            this.checkBoxBlue.Name = "checkBoxBlue";
            this.checkBoxBlue.Size = new System.Drawing.Size(41, 22);
            this.checkBoxBlue.TabIndex = 0;
            this.checkBoxBlue.UseVisualStyleBackColor = true;
            // 
            // checkBoxWhite
            // 
            this.checkBoxWhite.Image = global::WikiDeck.Properties.Resources.Color_W;
            this.checkBoxWhite.Location = new System.Drawing.Point(3, 59);
            this.checkBoxWhite.Name = "checkBoxWhite";
            this.checkBoxWhite.Size = new System.Drawing.Size(41, 22);
            this.checkBoxWhite.TabIndex = 1;
            this.checkBoxWhite.UseVisualStyleBackColor = true;
            // 
            // checkBoxGreen
            // 
            this.checkBoxGreen.Image = global::WikiDeck.Properties.Resources.Color_G;
            this.checkBoxGreen.Location = new System.Drawing.Point(3, 87);
            this.checkBoxGreen.Name = "checkBoxGreen";
            this.checkBoxGreen.Size = new System.Drawing.Size(41, 22);
            this.checkBoxGreen.TabIndex = 3;
            this.checkBoxGreen.UseVisualStyleBackColor = true;
            // 
            // checkBoxRed
            // 
            this.checkBoxRed.Image = global::WikiDeck.Properties.Resources.Color_R;
            this.checkBoxRed.Location = new System.Drawing.Point(3, 115);
            this.checkBoxRed.Name = "checkBoxRed";
            this.checkBoxRed.Size = new System.Drawing.Size(41, 22);
            this.checkBoxRed.TabIndex = 4;
            this.checkBoxRed.UseVisualStyleBackColor = true;
            // 
            // checkBoxColorless
            // 
            this.checkBoxColorless.Image = global::WikiDeck.Properties.Resources.Mana_C;
            this.checkBoxColorless.Location = new System.Drawing.Point(3, 143);
            this.checkBoxColorless.Name = "checkBoxColorless";
            this.checkBoxColorless.Size = new System.Drawing.Size(41, 22);
            this.checkBoxColorless.TabIndex = 5;
            this.checkBoxColorless.UseVisualStyleBackColor = true;
            // 
            // FormCardFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(145, 217);
            this.Controls.Add(groupBoxColors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCardFilter";
            this.Text = "Card Filter";
            this.Load += new System.EventHandler(this.FormCardFilter_Load);
            groupBoxColors.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxBlue;
        private System.Windows.Forms.CheckBox checkBoxWhite;
        private System.Windows.Forms.CheckBox checkBoxBlack;
        private System.Windows.Forms.CheckBox checkBoxGreen;
        private System.Windows.Forms.CheckBox checkBoxRed;
        private System.Windows.Forms.CheckBox checkBoxColorless;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}