namespace Project1
{
    partial class BloodPressure
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SystolicBloodPressureTextBox = new System.Windows.Forms.TextBox();
            this.DiatolicBloodPressureTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the Patient\'s Blood Pressure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Systolic";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Diatolic";
            // 
            // SystolicBloodPressureTextBox
            // 
            this.SystolicBloodPressureTextBox.Location = new System.Drawing.Point(112, 76);
            this.SystolicBloodPressureTextBox.Name = "SystolicBloodPressureTextBox";
            this.SystolicBloodPressureTextBox.Size = new System.Drawing.Size(209, 20);
            this.SystolicBloodPressureTextBox.TabIndex = 3;
            // 
            // DiatolicBloodPressureTextBox
            // 
            this.DiatolicBloodPressureTextBox.Location = new System.Drawing.Point(112, 113);
            this.DiatolicBloodPressureTextBox.Name = "DiatolicBloodPressureTextBox";
            this.DiatolicBloodPressureTextBox.Size = new System.Drawing.Size(209, 20);
            this.DiatolicBloodPressureTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "mmHG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "mmHG";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(112, 175);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "OK";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(246, 175);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // BloodPressure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 225);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DiatolicBloodPressureTextBox);
            this.Controls.Add(this.SystolicBloodPressureTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BloodPressure";
            this.Text = "BloodPressure";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SystolicBloodPressureTextBox;
        private System.Windows.Forms.TextBox DiatolicBloodPressureTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
    }
}