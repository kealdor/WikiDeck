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
            this.flowLayoutPanelColors = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxBlack = new System.Windows.Forms.CheckBox();
            this.checkBoxBlue = new System.Windows.Forms.CheckBox();
            this.checkBoxWhite = new System.Windows.Forms.CheckBox();
            this.checkBoxGreen = new System.Windows.Forms.CheckBox();
            this.checkBoxRed = new System.Windows.Forms.CheckBox();
            this.checkBoxColorless = new System.Windows.Forms.CheckBox();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelTypes = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxLand = new System.Windows.Forms.CheckBox();
            this.checkBoxCreature = new System.Windows.Forms.CheckBox();
            this.checkBoxSorcery = new System.Windows.Forms.CheckBox();
            this.checkBoxInstant = new System.Windows.Forms.CheckBox();
            this.checkBoxArtifact = new System.Windows.Forms.CheckBox();
            groupBoxColors = new System.Windows.Forms.GroupBox();
            groupBoxColors.SuspendLayout();
            this.flowLayoutPanelColors.SuspendLayout();
            this.groupBoxType.SuspendLayout();
            this.flowLayoutPanelTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxColors
            // 
            groupBoxColors.Controls.Add(this.flowLayoutPanelColors);
            groupBoxColors.Location = new System.Drawing.Point(12, 13);
            groupBoxColors.Name = "groupBoxColors";
            groupBoxColors.Size = new System.Drawing.Size(60, 196);
            groupBoxColors.TabIndex = 1;
            groupBoxColors.TabStop = false;
            groupBoxColors.Text = "Colors";
            // 
            // flowLayoutPanelColors
            // 
            this.flowLayoutPanelColors.Controls.Add(this.checkBoxBlack);
            this.flowLayoutPanelColors.Controls.Add(this.checkBoxBlue);
            this.flowLayoutPanelColors.Controls.Add(this.checkBoxWhite);
            this.flowLayoutPanelColors.Controls.Add(this.checkBoxGreen);
            this.flowLayoutPanelColors.Controls.Add(this.checkBoxRed);
            this.flowLayoutPanelColors.Controls.Add(this.checkBoxColorless);
            this.flowLayoutPanelColors.Location = new System.Drawing.Point(6, 16);
            this.flowLayoutPanelColors.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.flowLayoutPanelColors.Name = "flowLayoutPanelColors";
            this.flowLayoutPanelColors.Size = new System.Drawing.Size(48, 172);
            this.flowLayoutPanelColors.TabIndex = 2;
            // 
            // checkBoxBlack
            // 
            this.checkBoxBlack.Image = global::WikiDeck.Properties.Resources.Color_B;
            this.checkBoxBlack.Location = new System.Drawing.Point(3, 3);
            this.checkBoxBlack.Name = "checkBoxBlack";
            this.checkBoxBlack.Size = new System.Drawing.Size(41, 22);
            this.checkBoxBlack.TabIndex = 2;
            this.checkBoxBlack.Tag = "Black";
            this.checkBoxBlack.UseVisualStyleBackColor = true;
            // 
            // checkBoxBlue
            // 
            this.checkBoxBlue.Image = global::WikiDeck.Properties.Resources.Color_U;
            this.checkBoxBlue.Location = new System.Drawing.Point(3, 31);
            this.checkBoxBlue.Name = "checkBoxBlue";
            this.checkBoxBlue.Size = new System.Drawing.Size(41, 22);
            this.checkBoxBlue.TabIndex = 0;
            this.checkBoxBlue.Tag = "Blue";
            this.checkBoxBlue.UseVisualStyleBackColor = true;
            // 
            // checkBoxWhite
            // 
            this.checkBoxWhite.Image = global::WikiDeck.Properties.Resources.Color_W;
            this.checkBoxWhite.Location = new System.Drawing.Point(3, 59);
            this.checkBoxWhite.Name = "checkBoxWhite";
            this.checkBoxWhite.Size = new System.Drawing.Size(41, 22);
            this.checkBoxWhite.TabIndex = 1;
            this.checkBoxWhite.Tag = "White";
            this.checkBoxWhite.UseVisualStyleBackColor = true;
            // 
            // checkBoxGreen
            // 
            this.checkBoxGreen.Image = global::WikiDeck.Properties.Resources.Color_G;
            this.checkBoxGreen.Location = new System.Drawing.Point(3, 87);
            this.checkBoxGreen.Name = "checkBoxGreen";
            this.checkBoxGreen.Size = new System.Drawing.Size(41, 22);
            this.checkBoxGreen.TabIndex = 3;
            this.checkBoxGreen.Tag = "Green";
            this.checkBoxGreen.UseVisualStyleBackColor = true;
            // 
            // checkBoxRed
            // 
            this.checkBoxRed.Image = global::WikiDeck.Properties.Resources.Color_R;
            this.checkBoxRed.Location = new System.Drawing.Point(3, 115);
            this.checkBoxRed.Name = "checkBoxRed";
            this.checkBoxRed.Size = new System.Drawing.Size(41, 22);
            this.checkBoxRed.TabIndex = 4;
            this.checkBoxRed.Tag = "Red";
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
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.flowLayoutPanelTypes);
            this.groupBoxType.Location = new System.Drawing.Point(79, 13);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(87, 188);
            this.groupBoxType.TabIndex = 2;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Types";
            // 
            // flowLayoutPanelTypes
            // 
            this.flowLayoutPanelTypes.Controls.Add(this.checkBoxLand);
            this.flowLayoutPanelTypes.Controls.Add(this.checkBoxCreature);
            this.flowLayoutPanelTypes.Controls.Add(this.checkBoxSorcery);
            this.flowLayoutPanelTypes.Controls.Add(this.checkBoxInstant);
            this.flowLayoutPanelTypes.Controls.Add(this.checkBoxArtifact);
            this.flowLayoutPanelTypes.Location = new System.Drawing.Point(7, 16);
            this.flowLayoutPanelTypes.Name = "flowLayoutPanelTypes";
            this.flowLayoutPanelTypes.Size = new System.Drawing.Size(74, 166);
            this.flowLayoutPanelTypes.TabIndex = 0;
            this.flowLayoutPanelTypes.Tag = "Land";
            // 
            // checkBoxLand
            // 
            this.checkBoxLand.Location = new System.Drawing.Point(3, 3);
            this.checkBoxLand.Name = "checkBoxLand";
            this.checkBoxLand.Size = new System.Drawing.Size(50, 22);
            this.checkBoxLand.TabIndex = 0;
            this.checkBoxLand.Tag = "Land";
            this.checkBoxLand.Text = "Land";
            this.checkBoxLand.UseVisualStyleBackColor = true;
            // 
            // checkBoxCreature
            // 
            this.checkBoxCreature.Location = new System.Drawing.Point(3, 31);
            this.checkBoxCreature.Name = "checkBoxCreature";
            this.checkBoxCreature.Size = new System.Drawing.Size(66, 22);
            this.checkBoxCreature.TabIndex = 1;
            this.checkBoxCreature.Tag = "Creature";
            this.checkBoxCreature.Text = "Creature";
            this.checkBoxCreature.UseVisualStyleBackColor = true;
            // 
            // checkBoxSorcery
            // 
            this.checkBoxSorcery.Location = new System.Drawing.Point(3, 59);
            this.checkBoxSorcery.Name = "checkBoxSorcery";
            this.checkBoxSorcery.Size = new System.Drawing.Size(62, 22);
            this.checkBoxSorcery.TabIndex = 2;
            this.checkBoxSorcery.Tag = "Sorcery";
            this.checkBoxSorcery.Text = "Sorcery";
            this.checkBoxSorcery.UseVisualStyleBackColor = true;
            // 
            // checkBoxInstant
            // 
            this.checkBoxInstant.Location = new System.Drawing.Point(3, 87);
            this.checkBoxInstant.Name = "checkBoxInstant";
            this.checkBoxInstant.Size = new System.Drawing.Size(58, 22);
            this.checkBoxInstant.TabIndex = 3;
            this.checkBoxInstant.Tag = "Instant";
            this.checkBoxInstant.Text = "Instant";
            this.checkBoxInstant.UseVisualStyleBackColor = true;
            // 
            // checkBoxArtifact
            // 
            this.checkBoxArtifact.Location = new System.Drawing.Point(3, 115);
            this.checkBoxArtifact.Name = "checkBoxArtifact";
            this.checkBoxArtifact.Size = new System.Drawing.Size(59, 22);
            this.checkBoxArtifact.TabIndex = 4;
            this.checkBoxArtifact.Tag = "Artifact";
            this.checkBoxArtifact.Text = "Artifact";
            this.checkBoxArtifact.UseVisualStyleBackColor = true;
            // 
            // FormCardFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 217);
            this.Controls.Add(this.groupBoxType);
            this.Controls.Add(groupBoxColors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCardFilter";
            this.Text = "Card Filter";
            this.Load += new System.EventHandler(this.FormCardFilter_Load);
            groupBoxColors.ResumeLayout(false);
            this.flowLayoutPanelColors.ResumeLayout(false);
            this.groupBoxType.ResumeLayout(false);
            this.flowLayoutPanelTypes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxBlue;
        private System.Windows.Forms.CheckBox checkBoxWhite;
        private System.Windows.Forms.CheckBox checkBoxBlack;
        private System.Windows.Forms.CheckBox checkBoxGreen;
        private System.Windows.Forms.CheckBox checkBoxRed;
        private System.Windows.Forms.CheckBox checkBoxColorless;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelColors;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTypes;
        private System.Windows.Forms.CheckBox checkBoxLand;
        private System.Windows.Forms.CheckBox checkBoxCreature;
        private System.Windows.Forms.CheckBox checkBoxSorcery;
        private System.Windows.Forms.CheckBox checkBoxInstant;
        private System.Windows.Forms.CheckBox checkBoxArtifact;
    }
}