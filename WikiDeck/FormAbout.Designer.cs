namespace WikiDeck
{
    partial class FormAbout
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
            this.labelCopyright = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabelDuels = new System.Windows.Forms.LinkLabel();
            this.linkLabelArena = new System.Windows.Forms.LinkLabel();
            this.linkLabelSource = new System.Windows.Forms.LinkLabel();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(169, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(136, 18);
            label1.TabIndex = 0;
            label1.Text = "WikiDeck";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCopyright
            // 
            this.labelCopyright.Location = new System.Drawing.Point(169, 170);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(136, 18);
            this.labelCopyright.TabIndex = 1;
            this.labelCopyright.Text = "copyright";
            this.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVersion
            // 
            this.labelVersion.Location = new System.Drawing.Point(190, 33);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(115, 18);
            this.labelVersion.TabIndex = 2;
            this.labelVersion.Text = "version";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(230, 202);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WikiDeck.Properties.Resources.Cardback;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(151, 212);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabelDuels
            // 
            this.linkLabelDuels.AutoSize = true;
            this.linkLabelDuels.Location = new System.Drawing.Point(190, 74);
            this.linkLabelDuels.Name = "linkLabelDuels";
            this.linkLabelDuels.Size = new System.Drawing.Size(90, 13);
            this.linkLabelDuels.TabIndex = 5;
            this.linkLabelDuels.TabStop = true;
            this.linkLabelDuels.Text = "Magic Duels Wiki";
            this.linkLabelDuels.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDuels_LinkClicked);
            // 
            // linkLabelArena
            // 
            this.linkLabelArena.AutoSize = true;
            this.linkLabelArena.Location = new System.Drawing.Point(190, 97);
            this.linkLabelArena.Name = "linkLabelArena";
            this.linkLabelArena.Size = new System.Drawing.Size(91, 13);
            this.linkLabelArena.TabIndex = 6;
            this.linkLabelArena.TabStop = true;
            this.linkLabelArena.Text = "Magic Arena Wiki";
            this.linkLabelArena.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelArena_LinkClicked);
            // 
            // linkLabelSource
            // 
            this.linkLabelSource.AutoSize = true;
            this.linkLabelSource.Location = new System.Drawing.Point(190, 119);
            this.linkLabelSource.Name = "linkLabelSource";
            this.linkLabelSource.Size = new System.Drawing.Size(54, 13);
            this.linkLabelSource.TabIndex = 7;
            this.linkLabelSource.TabStop = true;
            this.linkLabelSource.Text = "WikiDeck";
            this.linkLabelSource.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelSource_LinkClicked);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 237);
            this.Controls.Add(this.linkLabelSource);
            this.Controls.Add(this.linkLabelArena);
            this.Controls.Add(this.linkLabelDuels);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About WikiDeck";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabelDuels;
        private System.Windows.Forms.LinkLabel linkLabelArena;
        private System.Windows.Forms.LinkLabel linkLabelSource;
    }
}