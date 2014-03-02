namespace TigerCheck
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.barcodePanel = new System.Windows.Forms.Panel();
            this.submitButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.closeButtonBP = new System.Windows.Forms.Button();
            this.barcodePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the patient\'s blood pressure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Systolic";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Diatolic";
            // 
            // SystolicBloodPressureTextBox
            // 
            this.SystolicBloodPressureTextBox.Location = new System.Drawing.Point(102, 82);
            this.SystolicBloodPressureTextBox.Name = "SystolicBloodPressureTextBox";
            this.SystolicBloodPressureTextBox.Size = new System.Drawing.Size(178, 20);
            this.SystolicBloodPressureTextBox.TabIndex = 3;
            // 
            // DiatolicBloodPressureTextBox
            // 
            this.DiatolicBloodPressureTextBox.Location = new System.Drawing.Point(102, 112);
            this.DiatolicBloodPressureTextBox.Name = "DiatolicBloodPressureTextBox";
            this.DiatolicBloodPressureTextBox.Size = new System.Drawing.Size(178, 20);
            this.DiatolicBloodPressureTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "mmHG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "mmHG";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // barcodePanel
            // 
            this.barcodePanel.Controls.Add(this.closeButtonBP);
            this.barcodePanel.Controls.Add(this.submitButton);
            this.barcodePanel.Controls.Add(this.label6);
            this.barcodePanel.Controls.Add(this.barcodeTextBox);
            this.barcodePanel.Location = new System.Drawing.Point(33, 23);
            this.barcodePanel.Name = "barcodePanel";
            this.barcodePanel.Size = new System.Drawing.Size(338, 197);
            this.barcodePanel.TabIndex = 9;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(130, 111);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(82, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Scan Or Enter Barcode";
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.Location = new System.Drawing.Point(69, 85);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(201, 20);
            this.barcodeTextBox.TabIndex = 0;
            // 
            // closeButtonBP
            // 
            this.closeButtonBP.Location = new System.Drawing.Point(130, 141);
            this.closeButtonBP.Name = "closeButtonBP";
            this.closeButtonBP.Size = new System.Drawing.Size(75, 23);
            this.closeButtonBP.TabIndex = 3;
            this.closeButtonBP.Text = "Close";
            this.closeButtonBP.UseVisualStyleBackColor = true;
            this.closeButtonBP.Click += new System.EventHandler(this.closeButtonBP_Click);
            // 
            // BloodPressure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(397, 232);
            this.Controls.Add(this.barcodePanel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DiatolicBloodPressureTextBox);
            this.Controls.Add(this.SystolicBloodPressureTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BloodPressure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BloodPressure";
            this.Load += new System.EventHandler(this.BloodPressure_Load);
            this.barcodePanel.ResumeLayout(false);
            this.barcodePanel.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel barcodePanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button closeButtonBP;
    }
}