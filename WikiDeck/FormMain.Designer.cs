namespace WikiDeck
{
    partial class FormMain
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
            this.richTextBoxDeck = new System.Windows.Forms.RichTextBox();
            this.buttonValidate = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textBoxDeckName = new System.Windows.Forms.TextBox();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.listBoxCardList = new System.Windows.Forms.ListBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonDecklist = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.labelCardCount = new System.Windows.Forms.Label();
            this.linkLabelColorLegend = new System.Windows.Forms.LinkLabel();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxDeck
            // 
            this.richTextBoxDeck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBoxDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDeck.Location = new System.Drawing.Point(320, 45);
            this.richTextBoxDeck.Name = "richTextBoxDeck";
            this.richTextBoxDeck.Size = new System.Drawing.Size(298, 435);
            this.richTextBoxDeck.TabIndex = 0;
            this.richTextBoxDeck.Text = "";
            // 
            // buttonValidate
            // 
            this.buttonValidate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonValidate.Location = new System.Drawing.Point(13, 418);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(75, 23);
            this.buttonValidate.TabIndex = 1;
            this.buttonValidate.Text = "Validate";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLoad.Location = new System.Drawing.Point(174, 418);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 2;
            this.buttonLoad.Text = "Load...";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // textBoxDeckName
            // 
            this.textBoxDeckName.Enabled = false;
            this.textBoxDeckName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDeckName.Location = new System.Drawing.Point(13, 13);
            this.textBoxDeckName.Name = "textBoxDeckName";
            this.textBoxDeckName.Size = new System.Drawing.Size(605, 26);
            this.textBoxDeckName.TabIndex = 3;
            this.textBoxDeckName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonUpload
            // 
            this.buttonUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUpload.Location = new System.Drawing.Point(13, 447);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(75, 23);
            this.buttonUpload.TabIndex = 4;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(13, 43);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(238, 20);
            this.textBoxSearch.TabIndex = 5;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // listBoxCardList
            // 
            this.listBoxCardList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxCardList.FormattingEnabled = true;
            this.listBoxCardList.Location = new System.Drawing.Point(13, 70);
            this.listBoxCardList.Name = "listBoxCardList";
            this.listBoxCardList.Size = new System.Drawing.Size(301, 342);
            this.listBoxCardList.TabIndex = 6;
            this.listBoxCardList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxCardList_MouseDoubleClick);
            // 
            // buttonNew
            // 
            this.buttonNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonNew.Location = new System.Drawing.Point(93, 418);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 23);
            this.buttonNew.TabIndex = 7;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonDecklist
            // 
            this.buttonDecklist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDecklist.Location = new System.Drawing.Point(94, 447);
            this.buttonDecklist.Name = "buttonDecklist";
            this.buttonDecklist.Size = new System.Drawing.Size(75, 23);
            this.buttonDecklist.TabIndex = 8;
            this.buttonDecklist.Text = "Decklist";
            this.buttonDecklist.UseVisualStyleBackColor = true;
            this.buttonDecklist.Click += new System.EventHandler(this.buttonDecklist_Click);
            // 
            // buttonView
            // 
            this.buttonView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonView.Location = new System.Drawing.Point(176, 447);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(75, 23);
            this.buttonView.TabIndex = 9;
            this.buttonView.Text = "View";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAbout.Location = new System.Drawing.Point(13, 477);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(75, 23);
            this.buttonAbout.TabIndex = 10;
            this.buttonAbout.Text = "About...";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // labelCardCount
            // 
            this.labelCardCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelCardCount.AutoSize = true;
            this.labelCardCount.Location = new System.Drawing.Point(539, 487);
            this.labelCardCount.Name = "labelCardCount";
            this.labelCardCount.Size = new System.Drawing.Size(79, 13);
            this.labelCardCount.TabIndex = 11;
            this.labelCardCount.Text = "Card Count NN";
            // 
            // linkLabelColorLegend
            // 
            this.linkLabelColorLegend.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.linkLabelColorLegend.AutoSize = true;
            this.linkLabelColorLegend.Location = new System.Drawing.Point(320, 487);
            this.linkLabelColorLegend.Name = "linkLabelColorLegend";
            this.linkLabelColorLegend.Size = new System.Drawing.Size(84, 13);
            this.linkLabelColorLegend.TabIndex = 12;
            this.linkLabelColorLegend.TabStop = true;
            this.linkLabelColorLegend.Text = "Validation colors";
            this.linkLabelColorLegend.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelColorLegend_LinkClicked);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(258, 41);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(56, 20);
            this.buttonFilter.TabIndex = 13;
            this.buttonFilter.Text = "More";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 505);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.linkLabelColorLegend);
            this.Controls.Add(this.labelCardCount);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.buttonDecklist);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.listBoxCardList);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.textBoxDeckName);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.richTextBoxDeck);
            this.MaximumSize = new System.Drawing.Size(653, 2048);
            this.MinimumSize = new System.Drawing.Size(16, 200);
            this.Name = "FormMain";
            this.Text = "Wiki Deck";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxDeck;
        private System.Windows.Forms.Button buttonValidate;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox textBoxDeckName;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ListBox listBoxCardList;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonDecklist;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Label labelCardCount;
        private System.Windows.Forms.LinkLabel linkLabelColorLegend;
        private System.Windows.Forms.Button buttonFilter;
    }
}

