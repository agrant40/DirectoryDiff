namespace DirectoryDiff
{
    partial class frmMain
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
            this.btnBrowse1 = new System.Windows.Forms.Button();
            this.btnBrowse2 = new System.Windows.Forms.Button();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.btnDiff = new System.Windows.Forms.Button();
            this.txtDir1 = new System.Windows.Forms.TextBox();
            this.txtDir2 = new System.Windows.Forms.TextBox();
            this.btnSimiliar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrowse1
            // 
            this.btnBrowse1.Location = new System.Drawing.Point(353, 12);
            this.btnBrowse1.Name = "btnBrowse1";
            this.btnBrowse1.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse1.TabIndex = 2;
            this.btnBrowse1.Text = "Browse";
            this.btnBrowse1.UseVisualStyleBackColor = true;
            this.btnBrowse1.Click += new System.EventHandler(this.btnBrowse1_Click);
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.Location = new System.Drawing.Point(353, 56);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse2.TabIndex = 3;
            this.btnBrowse2.Text = "Browse";
            this.btnBrowse2.UseVisualStyleBackColor = true;
            this.btnBrowse2.Click += new System.EventHandler(this.btnBrowse2_Click);
            // 
            // lstFiles
            // 
            this.lstFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(12, 151);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(451, 199);
            this.lstFiles.TabIndex = 4;
            // 
            // btnDiff
            // 
            this.btnDiff.Location = new System.Drawing.Point(255, 96);
            this.btnDiff.Name = "btnDiff";
            this.btnDiff.Size = new System.Drawing.Size(173, 23);
            this.btnDiff.TabIndex = 5;
            this.btnDiff.Text = "List Differences";
            this.btnDiff.UseVisualStyleBackColor = true;
            this.btnDiff.Click += new System.EventHandler(this.btnDiff_Click);
            // 
            // txtDir1
            // 
            this.txtDir1.Location = new System.Drawing.Point(42, 15);
            this.txtDir1.Name = "txtDir1";
            this.txtDir1.Size = new System.Drawing.Size(305, 20);
            this.txtDir1.TabIndex = 6;
            // 
            // txtDir2
            // 
            this.txtDir2.Location = new System.Drawing.Point(42, 59);
            this.txtDir2.Name = "txtDir2";
            this.txtDir2.Size = new System.Drawing.Size(305, 20);
            this.txtDir2.TabIndex = 7;
            // 
            // btnSimiliar
            // 
            this.btnSimiliar.Location = new System.Drawing.Point(42, 96);
            this.btnSimiliar.Name = "btnSimiliar";
            this.btnSimiliar.Size = new System.Drawing.Size(173, 23);
            this.btnSimiliar.TabIndex = 8;
            this.btnSimiliar.Text = "List Files in Both";
            this.btnSimiliar.UseVisualStyleBackColor = true;
            this.btnSimiliar.Click += new System.EventHandler(this.btnSimiliar_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 362);
            this.Controls.Add(this.btnSimiliar);
            this.Controls.Add(this.txtDir2);
            this.Controls.Add(this.txtDir1);
            this.Controls.Add(this.btnDiff);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.btnBrowse2);
            this.Controls.Add(this.btnBrowse1);
            this.Name = "frmMain";
            this.Text = "DirectoryDiff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse1;
        private System.Windows.Forms.Button btnBrowse2;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Button btnDiff;
        private System.Windows.Forms.TextBox txtDir1;
        private System.Windows.Forms.TextBox txtDir2;
        private System.Windows.Forms.Button btnSimiliar;
    }
}

