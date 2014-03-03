namespace TigerCheck
{
    partial class BloodSugar
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bloodSugarTextBox = new System.Windows.Forms.TextBox();
            this.barcodePanel = new System.Windows.Forms.Panel();
            this.closeButtonBS = new System.Windows.Forms.Button();
            this.submitButtonBS = new System.Windows.Forms.Button();
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.barcodePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "mg/dL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Blood Sugar";
            // 
            // bloodSugarTextBox
            // 
            this.bloodSugarTextBox.Location = new System.Drawing.Point(125, 60);
            this.bloodSugarTextBox.Name = "bloodSugarTextBox";
            this.bloodSugarTextBox.Size = new System.Drawing.Size(50, 20);
            this.bloodSugarTextBox.TabIndex = 10;
            // 
            // barcodePanel
            // 
            this.barcodePanel.Controls.Add(this.closeButtonBS);
            this.barcodePanel.Controls.Add(this.submitButtonBS);
            this.barcodePanel.Controls.Add(this.barcodeTextBox);
            this.barcodePanel.Controls.Add(this.label3);
            this.barcodePanel.Location = new System.Drawing.Point(12, 27);
            this.barcodePanel.Name = "barcodePanel";
            this.barcodePanel.Size = new System.Drawing.Size(260, 200);
            this.barcodePanel.TabIndex = 15;
            // 
            // closeButtonBS
            // 
            this.closeButtonBS.Location = new System.Drawing.Point(88, 145);
            this.closeButtonBS.Name = "closeButtonBS";
            this.closeButtonBS.Size = new System.Drawing.Size(75, 23);
            this.closeButtonBS.TabIndex = 3;
            this.closeButtonBS.Text = "Close";
            this.closeButtonBS.UseVisualStyleBackColor = true;
            this.closeButtonBS.Click += new System.EventHandler(this.closeButtonBS_Click);
            // 
            // submitButtonBS
            // 
            this.submitButtonBS.Location = new System.Drawing.Point(88, 115);
            this.submitButtonBS.Name = "submitButtonBS";
            this.submitButtonBS.Size = new System.Drawing.Size(75, 23);
            this.submitButtonBS.TabIndex = 2;
            this.submitButtonBS.Text = "Submit";
            this.submitButtonBS.UseVisualStyleBackColor = true;
            this.submitButtonBS.Click += new System.EventHandler(this.submitButtonBS_Click);
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.Location = new System.Drawing.Point(52, 76);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(155, 20);
            this.barcodeTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter Or Scan Barcode";
            // 
            // BloodSugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.barcodePanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bloodSugarTextBox);
            this.Name = "BloodSugar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BloodSugar";
            this.barcodePanel.ResumeLayout(false);
            this.barcodePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bloodSugarTextBox;
        private System.Windows.Forms.Panel barcodePanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submitButtonBS;
        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.Button closeButtonBS;
    }
}