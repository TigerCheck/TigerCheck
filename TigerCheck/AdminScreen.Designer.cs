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
            this.earsButton = new System.Windows.Forms.Button();
            this.visionButton = new System.Windows.Forms.Button();
            this.dentalButton = new System.Windows.Forms.Button();
            this.lungsButton = new System.Windows.Forms.Button();
            this.heartRateButton = new System.Windows.Forms.Button();
            this.cholesterolButton = new System.Windows.Forms.Button();
            this.bloodSugarButton = new System.Windows.Forms.Button();
            this.bloodPressureButton = new System.Windows.Forms.Button();
            this.heightWeightButton = new System.Windows.Forms.Button();
            this.throatButton = new System.Windows.Forms.Button();
            this.noseButton = new System.Windows.Forms.Button();
            this.heartButton = new System.Windows.Forms.Button();
            this.scoliosisButton = new System.Windows.Forms.Button();
            this.hearingButton = new System.Windows.Forms.Button();
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
            // earsButton
            // 
            this.earsButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.earsButton.Location = new System.Drawing.Point(548, 435);
            this.earsButton.Name = "earsButton";
            this.earsButton.Size = new System.Drawing.Size(141, 23);
            this.earsButton.TabIndex = 17;
            this.earsButton.Text = "Ears";
            this.earsButton.UseVisualStyleBackColor = true;
            this.earsButton.Visible = false;
            // 
            // visionButton
            // 
            this.visionButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.visionButton.Location = new System.Drawing.Point(548, 406);
            this.visionButton.Name = "visionButton";
            this.visionButton.Size = new System.Drawing.Size(141, 23);
            this.visionButton.TabIndex = 16;
            this.visionButton.Text = "Vision";
            this.visionButton.UseVisualStyleBackColor = true;
            this.visionButton.Visible = false;
            // 
            // dentalButton
            // 
            this.dentalButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dentalButton.Location = new System.Drawing.Point(548, 377);
            this.dentalButton.Name = "dentalButton";
            this.dentalButton.Size = new System.Drawing.Size(141, 23);
            this.dentalButton.TabIndex = 15;
            this.dentalButton.Text = "Dental";
            this.dentalButton.UseVisualStyleBackColor = true;
            this.dentalButton.Visible = false;
            // 
            // lungsButton
            // 
            this.lungsButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lungsButton.Location = new System.Drawing.Point(379, 435);
            this.lungsButton.Name = "lungsButton";
            this.lungsButton.Size = new System.Drawing.Size(141, 23);
            this.lungsButton.TabIndex = 14;
            this.lungsButton.Text = "Lungs";
            this.lungsButton.UseVisualStyleBackColor = true;
            this.lungsButton.Visible = false;
            // 
            // heartRateButton
            // 
            this.heartRateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.heartRateButton.Location = new System.Drawing.Point(379, 406);
            this.heartRateButton.Name = "heartRateButton";
            this.heartRateButton.Size = new System.Drawing.Size(141, 23);
            this.heartRateButton.TabIndex = 13;
            this.heartRateButton.Text = "Heart Rate";
            this.heartRateButton.UseVisualStyleBackColor = true;
            this.heartRateButton.Visible = false;
            this.heartRateButton.Click += new System.EventHandler(this.heartRateButton_Click);
            // 
            // cholesterolButton
            // 
            this.cholesterolButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cholesterolButton.Location = new System.Drawing.Point(379, 377);
            this.cholesterolButton.Name = "cholesterolButton";
            this.cholesterolButton.Size = new System.Drawing.Size(141, 23);
            this.cholesterolButton.TabIndex = 12;
            this.cholesterolButton.Text = "Cholesterol";
            this.cholesterolButton.UseVisualStyleBackColor = true;
            this.cholesterolButton.Visible = false;
            this.cholesterolButton.Click += new System.EventHandler(this.cholesterolButton_Click);
            // 
            // bloodSugarButton
            // 
            this.bloodSugarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bloodSugarButton.Location = new System.Drawing.Point(211, 435);
            this.bloodSugarButton.Name = "bloodSugarButton";
            this.bloodSugarButton.Size = new System.Drawing.Size(141, 23);
            this.bloodSugarButton.TabIndex = 11;
            this.bloodSugarButton.Text = "Blood Sugar";
            this.bloodSugarButton.UseVisualStyleBackColor = true;
            this.bloodSugarButton.Visible = false;
            this.bloodSugarButton.Click += new System.EventHandler(this.bloodSugarButton_Click);
            // 
            // bloodPressureButton
            // 
            this.bloodPressureButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bloodPressureButton.Location = new System.Drawing.Point(211, 406);
            this.bloodPressureButton.Name = "bloodPressureButton";
            this.bloodPressureButton.Size = new System.Drawing.Size(141, 23);
            this.bloodPressureButton.TabIndex = 10;
            this.bloodPressureButton.Text = "Blood Pressure";
            this.bloodPressureButton.UseVisualStyleBackColor = true;
            this.bloodPressureButton.Visible = false;
            this.bloodPressureButton.Click += new System.EventHandler(this.bloodPressureButton_Click);
            // 
            // heightWeightButton
            // 
            this.heightWeightButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.heightWeightButton.Location = new System.Drawing.Point(211, 377);
            this.heightWeightButton.Name = "heightWeightButton";
            this.heightWeightButton.Size = new System.Drawing.Size(141, 23);
            this.heightWeightButton.TabIndex = 9;
            this.heightWeightButton.Text = "Height/Weight";
            this.heightWeightButton.UseVisualStyleBackColor = true;
            this.heightWeightButton.Visible = false;
            this.heightWeightButton.Click += new System.EventHandler(this.heightWeightButton_Click);
            // 
            // throatButton
            // 
            this.throatButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.throatButton.Location = new System.Drawing.Point(211, 464);
            this.throatButton.Name = "throatButton";
            this.throatButton.Size = new System.Drawing.Size(141, 23);
            this.throatButton.TabIndex = 18;
            this.throatButton.Text = "Throat";
            this.throatButton.UseVisualStyleBackColor = true;
            this.throatButton.Visible = false;
            // 
            // noseButton
            // 
            this.noseButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.noseButton.Location = new System.Drawing.Point(379, 464);
            this.noseButton.Name = "noseButton";
            this.noseButton.Size = new System.Drawing.Size(141, 23);
            this.noseButton.TabIndex = 19;
            this.noseButton.Text = "Nose";
            this.noseButton.UseVisualStyleBackColor = true;
            this.noseButton.Visible = false;
            // 
            // heartButton
            // 
            this.heartButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.heartButton.Location = new System.Drawing.Point(548, 464);
            this.heartButton.Name = "heartButton";
            this.heartButton.Size = new System.Drawing.Size(141, 23);
            this.heartButton.TabIndex = 20;
            this.heartButton.Text = "Heart";
            this.heartButton.UseVisualStyleBackColor = true;
            this.heartButton.Visible = false;
            // 
            // scoliosisButton
            // 
            this.scoliosisButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.scoliosisButton.Location = new System.Drawing.Point(211, 493);
            this.scoliosisButton.Name = "scoliosisButton";
            this.scoliosisButton.Size = new System.Drawing.Size(141, 23);
            this.scoliosisButton.TabIndex = 21;
            this.scoliosisButton.Text = "Scoliosis";
            this.scoliosisButton.UseVisualStyleBackColor = true;
            this.scoliosisButton.Visible = false;
            // 
            // hearingButton
            // 
            this.hearingButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.hearingButton.Location = new System.Drawing.Point(379, 493);
            this.hearingButton.Name = "hearingButton";
            this.hearingButton.Size = new System.Drawing.Size(141, 23);
            this.hearingButton.TabIndex = 22;
            this.hearingButton.Text = "Hearing";
            this.hearingButton.UseVisualStyleBackColor = true;
            this.hearingButton.Visible = false;
            // 
            // AdminScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(928, 578);
            this.Controls.Add(this.hearingButton);
            this.Controls.Add(this.scoliosisButton);
            this.Controls.Add(this.heartButton);
            this.Controls.Add(this.noseButton);
            this.Controls.Add(this.throatButton);
            this.Controls.Add(this.earsButton);
            this.Controls.Add(this.visionButton);
            this.Controls.Add(this.dentalButton);
            this.Controls.Add(this.lungsButton);
            this.Controls.Add(this.heartRateButton);
            this.Controls.Add(this.cholesterolButton);
            this.Controls.Add(this.bloodSugarButton);
            this.Controls.Add(this.bloodPressureButton);
            this.Controls.Add(this.heightWeightButton);
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
        private System.Windows.Forms.Button earsButton;
        private System.Windows.Forms.Button visionButton;
        private System.Windows.Forms.Button dentalButton;
        private System.Windows.Forms.Button lungsButton;
        private System.Windows.Forms.Button heartRateButton;
        private System.Windows.Forms.Button cholesterolButton;
        private System.Windows.Forms.Button bloodSugarButton;
        private System.Windows.Forms.Button bloodPressureButton;
        private System.Windows.Forms.Button heightWeightButton;
        private System.Windows.Forms.Button throatButton;
        private System.Windows.Forms.Button noseButton;
        private System.Windows.Forms.Button heartButton;
        private System.Windows.Forms.Button scoliosisButton;
        private System.Windows.Forms.Button hearingButton;
    }
}

