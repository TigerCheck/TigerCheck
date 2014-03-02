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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.heartRateButton = new System.Windows.Forms.Button();
            this.cholesterolButton = new System.Windows.Forms.Button();
            this.bloodSugarButton = new System.Windows.Forms.Button();
            this.bloodPressureButton = new System.Windows.Forms.Button();
            this.heightWeigtButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            this.checkInButton.Enabled = false;
            this.checkInButton.Location = new System.Drawing.Point(356, 239);
            this.checkInButton.Name = "checkInButton";
            this.checkInButton.Size = new System.Drawing.Size(184, 90);
            this.checkInButton.TabIndex = 1;
            this.checkInButton.Text = "Check-In ";
            this.checkInButton.UseVisualStyleBackColor = true;
            this.checkInButton.Click += new System.EventHandler(this.checkInButton_Click);
            // 
            // checkOutButton
            // 
            this.checkOutButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkOutButton.Enabled = false;
            this.checkOutButton.Location = new System.Drawing.Point(573, 239);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(184, 90);
            this.checkOutButton.TabIndex = 2;
            this.checkOutButton.Text = "Check-Out";
            this.checkOutButton.UseVisualStyleBackColor = true;
            this.checkOutButton.Click += new System.EventHandler(this.checkOutButton_Click);
            // 
            // currentSessionNoChange
            // 
            this.currentSessionNoChange.AutoSize = true;
            this.currentSessionNoChange.Enabled = false;
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
            this.currentSessionLabel.Enabled = false;
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
            this.patientsInNoChange.Enabled = false;
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
            this.patientsInLabel.Enabled = false;
            this.patientsInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientsInLabel.Location = new System.Drawing.Point(135, 56);
            this.patientsInLabel.Name = "patientsInLabel";
            this.patientsInLabel.Size = new System.Drawing.Size(18, 20);
            this.patientsInLabel.TabIndex = 7;
            this.patientsInLabel.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.heartRateButton);
            this.groupBox1.Controls.Add(this.cholesterolButton);
            this.groupBox1.Controls.Add(this.bloodSugarButton);
            this.groupBox1.Controls.Add(this.bloodPressureButton);
            this.groupBox1.Controls.Add(this.heightWeigtButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 427);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(928, 151);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(357, 88);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(92, 23);
            this.button9.TabIndex = 8;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(357, 59);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(92, 23);
            this.button8.TabIndex = 7;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(357, 30);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(92, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(196, 88);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // heartRateButton
            // 
            this.heartRateButton.Location = new System.Drawing.Point(196, 59);
            this.heartRateButton.Name = "heartRateButton";
            this.heartRateButton.Size = new System.Drawing.Size(92, 23);
            this.heartRateButton.TabIndex = 4;
            this.heartRateButton.Text = "HeartRate";
            this.heartRateButton.UseVisualStyleBackColor = true;
            this.heartRateButton.Click += new System.EventHandler(this.heartRateButton_Click);
            // 
            // cholesterolButton
            // 
            this.cholesterolButton.Location = new System.Drawing.Point(196, 30);
            this.cholesterolButton.Name = "cholesterolButton";
            this.cholesterolButton.Size = new System.Drawing.Size(92, 23);
            this.cholesterolButton.TabIndex = 3;
            this.cholesterolButton.Text = "Cholesterol";
            this.cholesterolButton.UseVisualStyleBackColor = true;
            this.cholesterolButton.Click += new System.EventHandler(this.cholesterolButton_Click);
            // 
            // bloodSugarButton
            // 
            this.bloodSugarButton.Location = new System.Drawing.Point(20, 88);
            this.bloodSugarButton.Name = "bloodSugarButton";
            this.bloodSugarButton.Size = new System.Drawing.Size(92, 23);
            this.bloodSugarButton.TabIndex = 2;
            this.bloodSugarButton.Text = "Blood Sugar";
            this.bloodSugarButton.UseVisualStyleBackColor = true;
            this.bloodSugarButton.Click += new System.EventHandler(this.bloodSugarButton_Click);
            // 
            // bloodPressureButton
            // 
            this.bloodPressureButton.Location = new System.Drawing.Point(20, 59);
            this.bloodPressureButton.Name = "bloodPressureButton";
            this.bloodPressureButton.Size = new System.Drawing.Size(92, 23);
            this.bloodPressureButton.TabIndex = 1;
            this.bloodPressureButton.Text = "Blood Pressure";
            this.bloodPressureButton.UseVisualStyleBackColor = true;
            this.bloodPressureButton.Click += new System.EventHandler(this.bloodPressureButton_Click);
            // 
            // heightWeigtButton
            // 
            this.heightWeigtButton.Location = new System.Drawing.Point(20, 30);
            this.heightWeigtButton.Name = "heightWeigtButton";
            this.heightWeigtButton.Size = new System.Drawing.Size(92, 23);
            this.heightWeigtButton.TabIndex = 0;
            this.heightWeigtButton.Text = "Height/Weight";
            this.heightWeigtButton.UseVisualStyleBackColor = true;
            this.heightWeigtButton.Click += new System.EventHandler(this.heightWeigtButton_Click);
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(928, 578);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button heartRateButton;
        private System.Windows.Forms.Button cholesterolButton;
        private System.Windows.Forms.Button bloodSugarButton;
        private System.Windows.Forms.Button bloodPressureButton;
        private System.Windows.Forms.Button heightWeigtButton;
    }
}

