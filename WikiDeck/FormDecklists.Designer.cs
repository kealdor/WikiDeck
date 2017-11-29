namespace WikiDeck
{
    partial class FormDecklists
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.comboBoxStrategy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxIncludeColorless = new System.Windows.Forms.CheckBox();
            this.linkLabelColorless = new System.Windows.Forms.LinkLabel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(16, 38);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 13);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(16, 64);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 13);
            label2.TabIndex = 3;
            label2.Text = "Description";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(82, 35);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(356, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(82, 61);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(356, 20);
            this.textBoxDescription.TabIndex = 2;
            // 
            // comboBoxStrategy
            // 
            this.comboBoxStrategy.FormattingEnabled = true;
            this.comboBoxStrategy.Items.AddRange(new object[] {
            "Aggro",
            "Midrange",
            "Control",
            "Mill/Burn",
            "Combo"});
            this.comboBoxStrategy.Location = new System.Drawing.Point(82, 87);
            this.comboBoxStrategy.Name = "comboBoxStrategy";
            this.comboBoxStrategy.Size = new System.Drawing.Size(162, 21);
            this.comboBoxStrategy.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Strategy";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(16, 13);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(179, 13);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.Text = "Checking for existing decklist entry...";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(281, 148);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(363, 148);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // checkBoxIncludeColorless
            // 
            this.checkBoxIncludeColorless.AutoSize = true;
            this.checkBoxIncludeColorless.Location = new System.Drawing.Point(82, 114);
            this.checkBoxIncludeColorless.Name = "checkBoxIncludeColorless";
            this.checkBoxIncludeColorless.Size = new System.Drawing.Size(185, 17);
            this.checkBoxIncludeColorless.TabIndex = 9;
            this.checkBoxIncludeColorless.Text = "Include \"Colorless\" in deck colors";
            this.checkBoxIncludeColorless.UseVisualStyleBackColor = true;
            // 
            // linkLabelColorless
            // 
            this.linkLabelColorless.AutoSize = true;
            this.linkLabelColorless.LinkArea = new System.Windows.Forms.LinkArea(1, 2);
            this.linkLabelColorless.Location = new System.Drawing.Point(265, 114);
            this.linkLabelColorless.Name = "linkLabelColorless";
            this.linkLabelColorless.Size = new System.Drawing.Size(18, 17);
            this.linkLabelColorless.TabIndex = 10;
            this.linkLabelColorless.TabStop = true;
            this.linkLabelColorless.Text = "(?)";
            this.linkLabelColorless.UseCompatibleTextRendering = true;
            this.linkLabelColorless.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelColorless_LinkClicked);
            // 
            // FormDecklists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 186);
            this.Controls.Add(this.linkLabelColorless);
            this.Controls.Add(this.checkBoxIncludeColorless);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxStrategy);
            this.Controls.Add(label2);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormDecklists";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Decklists Entry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDecklists_FormClosing);
            this.Shown += new System.EventHandler(this.FormDecklists_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.ComboBox comboBoxStrategy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxIncludeColorless;
        private System.Windows.Forms.LinkLabel linkLabelColorless;
    }
}