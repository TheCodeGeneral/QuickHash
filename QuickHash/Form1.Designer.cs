namespace QuickHash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCopy = new System.Windows.Forms.Button();
            this.cmbHashAlgo = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editPreferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMd5 = new System.Windows.Forms.TextBox();
            this.txtSha512 = new System.Windows.Forms.TextBox();
            this.txtSha384 = new System.Windows.Forms.TextBox();
            this.txtSha256 = new System.Windows.Forms.TextBox();
            this.txtSha1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCopy.Location = new System.Drawing.Point(375, 133);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // cmbHashAlgo
            // 
            this.cmbHashAlgo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbHashAlgo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHashAlgo.FormattingEnabled = true;
            this.cmbHashAlgo.Location = new System.Drawing.Point(12, 133);
            this.cmbHashAlgo.Name = "cmbHashAlgo";
            this.cmbHashAlgo.Size = new System.Drawing.Size(75, 21);
            this.cmbHashAlgo.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.editPreferencesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // editPreferencesToolStripMenuItem
            // 
            this.editPreferencesToolStripMenuItem.Name = "editPreferencesToolStripMenuItem";
            this.editPreferencesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.editPreferencesToolStripMenuItem.Text = "Edit Preferences";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMd5);
            this.panel1.Controls.Add(this.txtSha512);
            this.panel1.Controls.Add(this.txtSha384);
            this.panel1.Controls.Add(this.txtSha256);
            this.panel1.Controls.Add(this.txtSha1);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 100);
            this.panel1.TabIndex = 5;
            // 
            // txtMd5
            // 
            this.txtMd5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMd5.Location = new System.Drawing.Point(0, 80);
            this.txtMd5.Name = "txtMd5";
            this.txtMd5.ReadOnly = true;
            this.txtMd5.Size = new System.Drawing.Size(807, 13);
            this.txtMd5.TabIndex = 4;
            this.txtMd5.TabStop = false;
            this.txtMd5.Text = "Md5:";
            // 
            // txtSha512
            // 
            this.txtSha512.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSha512.Location = new System.Drawing.Point(0, 61);
            this.txtSha512.Name = "txtSha512";
            this.txtSha512.ReadOnly = true;
            this.txtSha512.Size = new System.Drawing.Size(807, 13);
            this.txtSha512.TabIndex = 3;
            this.txtSha512.TabStop = false;
            this.txtSha512.Text = "Sha512:";
            // 
            // txtSha384
            // 
            this.txtSha384.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSha384.Location = new System.Drawing.Point(0, 42);
            this.txtSha384.Name = "txtSha384";
            this.txtSha384.ReadOnly = true;
            this.txtSha384.Size = new System.Drawing.Size(807, 13);
            this.txtSha384.TabIndex = 2;
            this.txtSha384.TabStop = false;
            this.txtSha384.Text = "Sha384:";
            // 
            // txtSha256
            // 
            this.txtSha256.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSha256.Location = new System.Drawing.Point(0, 23);
            this.txtSha256.Name = "txtSha256";
            this.txtSha256.ReadOnly = true;
            this.txtSha256.Size = new System.Drawing.Size(807, 13);
            this.txtSha256.TabIndex = 1;
            this.txtSha256.TabStop = false;
            this.txtSha256.Text = "Sha256:";
            // 
            // txtSha1
            // 
            this.txtSha1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSha1.Location = new System.Drawing.Point(0, 4);
            this.txtSha1.Name = "txtSha1";
            this.txtSha1.ReadOnly = true;
            this.txtSha1.Size = new System.Drawing.Size(807, 13);
            this.txtSha1.TabIndex = 0;
            this.txtSha1.TabStop = false;
            this.txtSha1.Text = "Sha1:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 166);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.cmbHashAlgo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(850, 150);
            this.Name = "Form1";
            this.Text = "QuickHash";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ComboBox cmbHashAlgo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editPreferencesToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSha512;
        private System.Windows.Forms.TextBox txtSha384;
        private System.Windows.Forms.TextBox txtSha256;
        private System.Windows.Forms.TextBox txtSha1;
        private System.Windows.Forms.TextBox txtMd5;
    }
}

