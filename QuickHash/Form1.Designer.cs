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
            this.lblHashResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCopy.Location = new System.Drawing.Point(375, 78);
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
            this.cmbHashAlgo.Location = new System.Drawing.Point(12, 78);
            this.cmbHashAlgo.Name = "cmbHashAlgo";
            this.cmbHashAlgo.Size = new System.Drawing.Size(75, 21);
            this.cmbHashAlgo.TabIndex = 1;
            // 
            // lblHashResult
            // 
            this.lblHashResult.AutoSize = true;
            this.lblHashResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHashResult.Location = new System.Drawing.Point(0, 0);
            this.lblHashResult.Name = "lblHashResult";
            this.lblHashResult.Size = new System.Drawing.Size(50, 13);
            this.lblHashResult.TabIndex = 2;
            this.lblHashResult.Text = "loading...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 111);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lblHashResult);
            this.Controls.Add(this.cmbHashAlgo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(850, 150);
            this.Name = "Form1";
            this.Text = "QuickHash";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ComboBox cmbHashAlgo;
        private System.Windows.Forms.Label lblHashResult;
    }
}

