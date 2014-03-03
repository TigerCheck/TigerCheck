namespace TigerCheck
{
    partial class HeartRate
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
            this.HeartRateTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.barcodePanel = new System.Windows.Forms.Panel();
            this.closeButtonHR = new System.Windows.Forms.Button();
            this.submitButtonHR = new System.Windows.Forms.Button();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.barcodePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the Patient\'s Heart Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Heart Rate";
            // 
            // HeartRateTextBox
            // 
            this.HeartRateTextBox.Location = new System.Drawing.Point(104, 81);
            this.HeartRateTextBox.Name = "HeartRateTextBox";
            this.HeartRateTextBox.Size = new System.Drawing.Size(174, 20);
            this.HeartRateTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bpm";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(104, 143);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "OK";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click_1);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(204, 142);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // barcodePanel
            // 
            this.barcodePanel.Controls.Add(this.closeButtonHR);
            this.barcodePanel.Controls.Add(this.submitButtonHR);
            this.barcodePanel.Controls.Add(this.barcodeTextBox);
            this.barcodePanel.Controls.Add(this.label4);
            this.barcodePanel.Location = new System.Drawing.Point(12, 12);
            this.barcodePanel.Name = "barcodePanel";
            this.barcodePanel.Size = new System.Drawing.Size(372, 159);
            this.barcodePanel.TabIndex = 6;
            // 
            // closeButtonHR
            // 
            this.closeButtonHR.Location = new System.Drawing.Point(152, 124);
            this.closeButtonHR.Name = "closeButtonHR";
            this.closeButtonHR.Size = new System.Drawing.Size(75, 23);
            this.closeButtonHR.TabIndex = 3;
            this.closeButtonHR.Text = "Close";
            this.closeButtonHR.UseVisualStyleBackColor = true;
            this.closeButtonHR.Click += new System.EventHandler(this.closeButtonHR_Click);
            // 
            // submitButtonHR
            // 
            this.submitButtonHR.Location = new System.Drawing.Point(152, 95);
            this.submitButtonHR.Name = "submitButtonHR";
            this.submitButtonHR.Size = new System.Drawing.Size(75, 23);
            this.submitButtonHR.TabIndex = 2;
            this.submitButtonHR.Text = "Submit";
            this.submitButtonHR.UseVisualStyleBackColor = true;
            this.submitButtonHR.Click += new System.EventHandler(this.submitButtonHR_Click);
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.Location = new System.Drawing.Point(107, 65);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(170, 20);
            this.barcodeTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(103, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Enter Or Scan Barcode";
            // 
            // HeartRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(396, 183);
            this.Controls.Add(this.barcodePanel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HeartRateTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HeartRate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HeartRate";
            this.barcodePanel.ResumeLayout(false);
            this.barcodePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HeartRateTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel barcodePanel;
        private System.Windows.Forms.Button submitButtonHR;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button closeButtonHR;
    }
}