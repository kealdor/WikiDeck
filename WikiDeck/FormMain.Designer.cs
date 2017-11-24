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
            this.SuspendLayout();
            // 
            // richTextBoxDeck
            // 
            this.richTextBoxDeck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxDeck.Location = new System.Drawing.Point(12, 45);
            this.richTextBoxDeck.Name = "richTextBoxDeck";
            this.richTextBoxDeck.Size = new System.Drawing.Size(298, 451);
            this.richTextBoxDeck.TabIndex = 0;
            this.richTextBoxDeck.Text = "";
            // 
            // buttonValidate
            // 
            this.buttonValidate.Location = new System.Drawing.Point(316, 473);
            this.buttonValidate.Name = "buttonValidate";
            this.buttonValidate.Size = new System.Drawing.Size(75, 23);
            this.buttonValidate.TabIndex = 1;
            this.buttonValidate.Text = "Validate";
            this.buttonValidate.UseVisualStyleBackColor = true;
            this.buttonValidate.Click += new System.EventHandler(this.buttonValidate_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(397, 473);
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
            this.buttonUpload.Location = new System.Drawing.Point(478, 473);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(75, 23);
            this.buttonUpload.TabIndex = 4;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(317, 46);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(301, 20);
            this.textBoxSearch.TabIndex = 5;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // listBoxCardList
            // 
            this.listBoxCardList.FormattingEnabled = true;
            this.listBoxCardList.Location = new System.Drawing.Point(317, 73);
            this.listBoxCardList.Name = "listBoxCardList";
            this.listBoxCardList.Size = new System.Drawing.Size(301, 342);
            this.listBoxCardList.TabIndex = 6;
            this.listBoxCardList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxCardList_MouseDoubleClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 508);
            this.Controls.Add(this.listBoxCardList);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.textBoxDeckName);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonValidate);
            this.Controls.Add(this.richTextBoxDeck);
            this.Name = "FormMain";
            this.Text = "Wiki Deck";
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
    }
}

