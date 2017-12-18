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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
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
            this.checkBoxEnchantment = new System.Windows.Forms.CheckBox();
            this.checkBoxPlaneswalker = new System.Windows.Forms.CheckBox();
            this.groupBoxCmc = new System.Windows.Forms.GroupBox();
            this.numericUpDownCmcMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCmcMin = new System.Windows.Forms.NumericUpDown();
            this.checkBoxUseCmc = new System.Windows.Forms.CheckBox();
            this.listBoxSets = new System.Windows.Forms.ListBox();
            groupBoxColors = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            groupBoxColors.SuspendLayout();
            this.flowLayoutPanelColors.SuspendLayout();
            this.groupBoxType.SuspendLayout();
            this.flowLayoutPanelTypes.SuspendLayout();
            this.groupBoxCmc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCmcMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCmcMin)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxColors
            // 
            groupBoxColors.Controls.Add(this.flowLayoutPanelColors);
            groupBoxColors.Location = new System.Drawing.Point(12, 13);
            groupBoxColors.Name = "groupBoxColors";
            groupBoxColors.Size = new System.Drawing.Size(60, 207);
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
            this.flowLayoutPanelColors.Location = new System.Drawing.Point(0, 16);
            this.flowLayoutPanelColors.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.flowLayoutPanelColors.Name = "flowLayoutPanelColors";
            this.flowLayoutPanelColors.Size = new System.Drawing.Size(52, 188);
            this.flowLayoutPanelColors.TabIndex = 2;
            // 
            // checkBoxBlack
            // 
            this.checkBoxBlack.Image = global::WikiDeck.Properties.Resources.Color_B;
            this.checkBoxBlack.Location = new System.Drawing.Point(3, 0);
            this.checkBoxBlack.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.checkBoxBlack.Name = "checkBoxBlack";
            this.checkBoxBlack.Size = new System.Drawing.Size(41, 26);
            this.checkBoxBlack.TabIndex = 2;
            this.checkBoxBlack.Tag = "Black";
            this.checkBoxBlack.UseVisualStyleBackColor = true;
            // 
            // checkBoxBlue
            // 
            this.checkBoxBlue.Image = global::WikiDeck.Properties.Resources.Color_U;
            this.checkBoxBlue.Location = new System.Drawing.Point(3, 26);
            this.checkBoxBlue.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.checkBoxBlue.Name = "checkBoxBlue";
            this.checkBoxBlue.Size = new System.Drawing.Size(41, 26);
            this.checkBoxBlue.TabIndex = 0;
            this.checkBoxBlue.Tag = "Blue";
            this.checkBoxBlue.UseVisualStyleBackColor = true;
            // 
            // checkBoxWhite
            // 
            this.checkBoxWhite.Image = global::WikiDeck.Properties.Resources.Color_W;
            this.checkBoxWhite.Location = new System.Drawing.Point(3, 52);
            this.checkBoxWhite.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.checkBoxWhite.Name = "checkBoxWhite";
            this.checkBoxWhite.Size = new System.Drawing.Size(41, 26);
            this.checkBoxWhite.TabIndex = 1;
            this.checkBoxWhite.Tag = "White";
            this.checkBoxWhite.UseVisualStyleBackColor = true;
            // 
            // checkBoxGreen
            // 
            this.checkBoxGreen.Image = global::WikiDeck.Properties.Resources.Color_G;
            this.checkBoxGreen.Location = new System.Drawing.Point(3, 78);
            this.checkBoxGreen.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.checkBoxGreen.Name = "checkBoxGreen";
            this.checkBoxGreen.Size = new System.Drawing.Size(41, 26);
            this.checkBoxGreen.TabIndex = 3;
            this.checkBoxGreen.Tag = "Green";
            this.checkBoxGreen.UseVisualStyleBackColor = true;
            // 
            // checkBoxRed
            // 
            this.checkBoxRed.Image = global::WikiDeck.Properties.Resources.Color_R;
            this.checkBoxRed.Location = new System.Drawing.Point(3, 104);
            this.checkBoxRed.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.checkBoxRed.Name = "checkBoxRed";
            this.checkBoxRed.Size = new System.Drawing.Size(41, 26);
            this.checkBoxRed.TabIndex = 4;
            this.checkBoxRed.Tag = "Red";
            this.checkBoxRed.UseVisualStyleBackColor = true;
            // 
            // checkBoxColorless
            // 
            this.checkBoxColorless.Image = global::WikiDeck.Properties.Resources.Mana_C;
            this.checkBoxColorless.Location = new System.Drawing.Point(3, 130);
            this.checkBoxColorless.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.checkBoxColorless.Name = "checkBoxColorless";
            this.checkBoxColorless.Size = new System.Drawing.Size(41, 26);
            this.checkBoxColorless.TabIndex = 5;
            this.checkBoxColorless.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(25, 40);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(24, 13);
            label1.TabIndex = 2;
            label1.Text = "Min";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(93, 40);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(27, 13);
            label2.TabIndex = 3;
            label2.Text = "Max";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(13, 304);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(28, 13);
            label3.TabIndex = 5;
            label3.Text = "Sets";
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.flowLayoutPanelTypes);
            this.groupBoxType.Location = new System.Drawing.Point(79, 13);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(111, 207);
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
            this.flowLayoutPanelTypes.Controls.Add(this.checkBoxEnchantment);
            this.flowLayoutPanelTypes.Controls.Add(this.checkBoxPlaneswalker);
            this.flowLayoutPanelTypes.Location = new System.Drawing.Point(7, 16);
            this.flowLayoutPanelTypes.Name = "flowLayoutPanelTypes";
            this.flowLayoutPanelTypes.Size = new System.Drawing.Size(95, 188);
            this.flowLayoutPanelTypes.TabIndex = 0;
            this.flowLayoutPanelTypes.Tag = "Land";
            // 
            // checkBoxLand
            // 
            this.checkBoxLand.Location = new System.Drawing.Point(3, 0);
            this.checkBoxLand.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.checkBoxLand.Name = "checkBoxLand";
            this.checkBoxLand.Size = new System.Drawing.Size(168, 26);
            this.checkBoxLand.TabIndex = 0;
            this.checkBoxLand.Tag = "Land";
            this.checkBoxLand.Text = "Land";
            this.checkBoxLand.UseVisualStyleBackColor = true;
            // 
            // checkBoxCreature
            // 
            this.checkBoxCreature.Location = new System.Drawing.Point(3, 26);
            this.checkBoxCreature.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.checkBoxCreature.Name = "checkBoxCreature";
            this.checkBoxCreature.Size = new System.Drawing.Size(168, 26);
            this.checkBoxCreature.TabIndex = 1;
            this.checkBoxCreature.Tag = "Creature";
            this.checkBoxCreature.Text = "Creature";
            this.checkBoxCreature.UseVisualStyleBackColor = true;
            // 
            // checkBoxSorcery
            // 
            this.checkBoxSorcery.Location = new System.Drawing.Point(3, 52);
            this.checkBoxSorcery.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.checkBoxSorcery.Name = "checkBoxSorcery";
            this.checkBoxSorcery.Size = new System.Drawing.Size(168, 26);
            this.checkBoxSorcery.TabIndex = 2;
            this.checkBoxSorcery.Tag = "Sorcery";
            this.checkBoxSorcery.Text = "Sorcery";
            this.checkBoxSorcery.UseVisualStyleBackColor = true;
            // 
            // checkBoxInstant
            // 
            this.checkBoxInstant.Location = new System.Drawing.Point(3, 78);
            this.checkBoxInstant.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.checkBoxInstant.Name = "checkBoxInstant";
            this.checkBoxInstant.Size = new System.Drawing.Size(168, 26);
            this.checkBoxInstant.TabIndex = 3;
            this.checkBoxInstant.Tag = "Instant";
            this.checkBoxInstant.Text = "Instant";
            this.checkBoxInstant.UseVisualStyleBackColor = true;
            // 
            // checkBoxArtifact
            // 
            this.checkBoxArtifact.Location = new System.Drawing.Point(3, 104);
            this.checkBoxArtifact.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.checkBoxArtifact.Name = "checkBoxArtifact";
            this.checkBoxArtifact.Size = new System.Drawing.Size(168, 26);
            this.checkBoxArtifact.TabIndex = 4;
            this.checkBoxArtifact.Tag = "Artifact";
            this.checkBoxArtifact.Text = "Artifact";
            this.checkBoxArtifact.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnchantment
            // 
            this.checkBoxEnchantment.Location = new System.Drawing.Point(3, 130);
            this.checkBoxEnchantment.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.checkBoxEnchantment.Name = "checkBoxEnchantment";
            this.checkBoxEnchantment.Size = new System.Drawing.Size(168, 26);
            this.checkBoxEnchantment.TabIndex = 5;
            this.checkBoxEnchantment.Tag = "Enchantment";
            this.checkBoxEnchantment.Text = "Enchantment";
            this.checkBoxEnchantment.UseVisualStyleBackColor = true;
            // 
            // checkBoxPlaneswalker
            // 
            this.checkBoxPlaneswalker.Location = new System.Drawing.Point(3, 156);
            this.checkBoxPlaneswalker.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.checkBoxPlaneswalker.Name = "checkBoxPlaneswalker";
            this.checkBoxPlaneswalker.Size = new System.Drawing.Size(168, 26);
            this.checkBoxPlaneswalker.TabIndex = 6;
            this.checkBoxPlaneswalker.Tag = "Planeswalker";
            this.checkBoxPlaneswalker.Text = "Planeswalker";
            this.checkBoxPlaneswalker.UseVisualStyleBackColor = true;
            // 
            // groupBoxCmc
            // 
            this.groupBoxCmc.Controls.Add(this.numericUpDownCmcMax);
            this.groupBoxCmc.Controls.Add(label2);
            this.groupBoxCmc.Controls.Add(label1);
            this.groupBoxCmc.Controls.Add(this.numericUpDownCmcMin);
            this.groupBoxCmc.Controls.Add(this.checkBoxUseCmc);
            this.groupBoxCmc.Location = new System.Drawing.Point(13, 228);
            this.groupBoxCmc.Name = "groupBoxCmc";
            this.groupBoxCmc.Size = new System.Drawing.Size(168, 63);
            this.groupBoxCmc.TabIndex = 3;
            this.groupBoxCmc.TabStop = false;
            // 
            // numericUpDownCmcMax
            // 
            this.numericUpDownCmcMax.Location = new System.Drawing.Point(119, 37);
            this.numericUpDownCmcMax.Name = "numericUpDownCmcMax";
            this.numericUpDownCmcMax.Size = new System.Drawing.Size(36, 20);
            this.numericUpDownCmcMax.TabIndex = 4;
            this.numericUpDownCmcMax.ValueChanged += new System.EventHandler(this.numericUpDownCmcMax_ValueChanged);
            // 
            // numericUpDownCmcMin
            // 
            this.numericUpDownCmcMin.Location = new System.Drawing.Point(48, 37);
            this.numericUpDownCmcMin.Name = "numericUpDownCmcMin";
            this.numericUpDownCmcMin.Size = new System.Drawing.Size(36, 20);
            this.numericUpDownCmcMin.TabIndex = 1;
            this.numericUpDownCmcMin.ValueChanged += new System.EventHandler(this.numericUpDownCmcMin_ValueChanged);
            // 
            // checkBoxUseCmc
            // 
            this.checkBoxUseCmc.AutoSize = true;
            this.checkBoxUseCmc.Location = new System.Drawing.Point(7, 15);
            this.checkBoxUseCmc.Name = "checkBoxUseCmc";
            this.checkBoxUseCmc.Size = new System.Drawing.Size(88, 17);
            this.checkBoxUseCmc.TabIndex = 0;
            this.checkBoxUseCmc.Text = "Filter by CMC";
            this.checkBoxUseCmc.UseVisualStyleBackColor = true;
            this.checkBoxUseCmc.CheckStateChanged += new System.EventHandler(this.checkBoxUseCmc_CheckStateChanged);
            // 
            // listBoxSets
            // 
            this.listBoxSets.FormattingEnabled = true;
            this.listBoxSets.Items.AddRange(new object[] {
            "Shadows Over Innistrad",
            "Oath of the Gatewatch"});
            this.listBoxSets.Location = new System.Drawing.Point(13, 323);
            this.listBoxSets.Name = "listBoxSets";
            this.listBoxSets.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxSets.Size = new System.Drawing.Size(168, 121);
            this.listBoxSets.TabIndex = 4;
            // 
            // FormCardFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 457);
            this.Controls.Add(label3);
            this.Controls.Add(this.listBoxSets);
            this.Controls.Add(this.groupBoxCmc);
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
            this.groupBoxCmc.ResumeLayout(false);
            this.groupBoxCmc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCmcMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCmcMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.GroupBox groupBoxCmc;
        private System.Windows.Forms.CheckBox checkBoxUseCmc;
        private System.Windows.Forms.NumericUpDown numericUpDownCmcMax;
        private System.Windows.Forms.NumericUpDown numericUpDownCmcMin;
        private System.Windows.Forms.ListBox listBoxSets;
        private System.Windows.Forms.CheckBox checkBoxEnchantment;
        private System.Windows.Forms.CheckBox checkBoxPlaneswalker;
    }
}