namespace DirectoryListerInstaller
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
            this.installBtn = new System.Windows.Forms.Button();
            this.uninstallBtn = new System.Windows.Forms.Button();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // installBtn
            // 
            this.installBtn.Location = new System.Drawing.Point(117, 113);
            this.installBtn.Name = "installBtn";
            this.installBtn.Size = new System.Drawing.Size(123, 50);
            this.installBtn.TabIndex = 0;
            this.installBtn.Text = "Install";
            this.installBtn.UseVisualStyleBackColor = true;
            this.installBtn.Click += new System.EventHandler(this.installBtn_Click);
            // 
            // uninstallBtn
            // 
            this.uninstallBtn.Location = new System.Drawing.Point(362, 113);
            this.uninstallBtn.Name = "uninstallBtn";
            this.uninstallBtn.Size = new System.Drawing.Size(123, 50);
            this.uninstallBtn.TabIndex = 1;
            this.uninstallBtn.Text = "Uninstall";
            this.uninstallBtn.UseVisualStyleBackColor = true;
            this.uninstallBtn.Click += new System.EventHandler(this.uninstallBtn_Click);
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(12, 9);
            this.instructionsLabel.MaximumSize = new System.Drawing.Size(600, 0);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(567, 85);
            this.instructionsLabel.TabIndex = 2;
            this.instructionsLabel.Text = resources.GetString("instructionsLabel.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 190);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.uninstallBtn);
            this.Controls.Add(this.installBtn);
            this.Name = "Form1";
            this.Text = "Directory Lister Installer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button installBtn;
        private System.Windows.Forms.Button uninstallBtn;
        private System.Windows.Forms.Label instructionsLabel;
    }
}

