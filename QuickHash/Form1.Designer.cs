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
            this.lblhashAlgo = new System.Windows.Forms.Label();
            this.hashAlgoComboBox = new System.Windows.Forms.ComboBox();
            this.lblHashResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblhashAlgo
            // 
            this.lblhashAlgo.AutoSize = true;
            this.lblhashAlgo.Location = new System.Drawing.Point(13, 13);
            this.lblhashAlgo.Name = "lblhashAlgo";
            this.lblhashAlgo.Size = new System.Drawing.Size(78, 13);
            this.lblhashAlgo.TabIndex = 0;
            this.lblhashAlgo.Text = "Hash Algorithm";
            // 
            // hashAlgoComboBox
            // 
            this.hashAlgoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hashAlgoComboBox.FormattingEnabled = true;
            this.hashAlgoComboBox.Items.AddRange(new object[] {
            "SHA1",
            "SHA256",
            "SHA384",
            "SHA512",
            "MD2",
            "MD4",
            "MD5 "});
            this.hashAlgoComboBox.Location = new System.Drawing.Point(16, 30);
            this.hashAlgoComboBox.Name = "hashAlgoComboBox";
            this.hashAlgoComboBox.Size = new System.Drawing.Size(75, 21);
            this.hashAlgoComboBox.TabIndex = 1;
            this.hashAlgoComboBox.SelectedIndexChanged += new System.EventHandler(this.hashAlgoComboBox_SelectedIndexChanged);
            // 
            // lblHashResult
            // 
            this.lblHashResult.AutoSize = true;
            this.lblHashResult.Location = new System.Drawing.Point(120, 38);
            this.lblHashResult.Name = "lblHashResult";
            this.lblHashResult.Size = new System.Drawing.Size(30, 13);
            this.lblHashResult.TabIndex = 2;
            this.lblHashResult.Text = "hash";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 111);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblHashResult);
            this.Controls.Add(this.hashAlgoComboBox);
            this.Controls.Add(this.lblhashAlgo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblhashAlgo;
        private System.Windows.Forms.Label lblHashResult;
        private System.Windows.Forms.ComboBox hashAlgoComboBox;
        private System.Windows.Forms.Button button1;
    }
}

