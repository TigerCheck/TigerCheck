namespace TigerCheck
{
    partial class AdminScreen
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
            this.newSessionButton = new System.Windows.Forms.Button();
            this.checkInButton = new System.Windows.Forms.Button();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.currentSessionNoChange = new System.Windows.Forms.Label();
            this.currentSessionLabel = new System.Windows.Forms.Label();
            this.patientsInNoChange = new System.Windows.Forms.Label();
            this.patientsInLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newSessionButton
            // 
            this.newSessionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newSessionButton.Location = new System.Drawing.Point(144, 239);
            this.newSessionButton.Name = "newSessionButton";
            this.newSessionButton.Size = new System.Drawing.Size(184, 90);
            this.newSessionButton.TabIndex = 0;
            this.newSessionButton.Text = "New Session";
            this.newSessionButton.UseVisualStyleBackColor = true;
            this.newSessionButton.Click += new System.EventHandler(this.newSessionButton_Click);
            // 
            // checkInButton
            // 
            this.checkInButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkInButton.Location = new System.Drawing.Point(356, 239);
            this.checkInButton.Name = "checkInButton";
            this.checkInButton.Size = new System.Drawing.Size(184, 90);
            this.checkInButton.TabIndex = 1;
            this.checkInButton.Text = "Check-In ";
            this.checkInButton.UseVisualStyleBackColor = true;
            // 
            // checkOutButton
            // 
            this.checkOutButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkOutButton.Location = new System.Drawing.Point(573, 239);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(184, 90);
            this.checkOutButton.TabIndex = 2;
            this.checkOutButton.Text = "Check-Out";
            this.checkOutButton.UseVisualStyleBackColor = true;
            // 
            // currentSessionNoChange
            // 
            this.currentSessionNoChange.AutoSize = true;
            this.currentSessionNoChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentSessionNoChange.Location = new System.Drawing.Point(26, 29);
            this.currentSessionNoChange.Name = "currentSessionNoChange";
            this.currentSessionNoChange.Size = new System.Drawing.Size(127, 20);
            this.currentSessionNoChange.TabIndex = 3;
            this.currentSessionNoChange.Text = "Current Session:";
            // 
            // currentSessionLabel
            // 
            this.currentSessionLabel.AutoSize = true;
            this.currentSessionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentSessionLabel.Location = new System.Drawing.Point(159, 29);
            this.currentSessionLabel.Name = "currentSessionLabel";
            this.currentSessionLabel.Size = new System.Drawing.Size(57, 20);
            this.currentSessionLabel.TabIndex = 4;
            this.currentSessionLabel.Text = "-None-";
            // 
            // patientsInNoChange
            // 
            this.patientsInNoChange.AutoSize = true;
            this.patientsInNoChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientsInNoChange.Location = new System.Drawing.Point(29, 56);
            this.patientsInNoChange.Name = "patientsInNoChange";
            this.patientsInNoChange.Size = new System.Drawing.Size(100, 20);
            this.patientsInNoChange.TabIndex = 5;
            this.patientsInNoChange.Text = "Patients - IN:";
            // 
            // patientsInLabel
            // 
            this.patientsInLabel.AutoSize = true;
            this.patientsInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientsInLabel.Location = new System.Drawing.Point(135, 56);
            this.patientsInLabel.Name = "patientsInLabel";
            this.patientsInLabel.Size = new System.Drawing.Size(18, 20);
            this.patientsInLabel.TabIndex = 7;
            this.patientsInLabel.Text = "0";
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 578);
            this.Controls.Add(this.patientsInLabel);
            this.Controls.Add(this.patientsInNoChange);
            this.Controls.Add(this.currentSessionLabel);
            this.Controls.Add(this.currentSessionNoChange);
            this.Controls.Add(this.checkOutButton);
            this.Controls.Add(this.checkInButton);
            this.Controls.Add(this.newSessionButton);
            this.Name = "AdminScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiger Check";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AdminScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newSessionButton;
        private System.Windows.Forms.Button checkInButton;
        private System.Windows.Forms.Button checkOutButton;
        private System.Windows.Forms.Label currentSessionNoChange;
        private System.Windows.Forms.Label currentSessionLabel;
        private System.Windows.Forms.Label patientsInNoChange;
        private System.Windows.Forms.Label patientsInLabel;
    }
}

