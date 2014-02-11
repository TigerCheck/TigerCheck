namespace TigerCheck
{
    partial class checkOutScreen
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
            this.barcodeTextBox = new System.Windows.Forms.TextBox();
            this.barcodeNumberLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // barcodeTextBox
            // 
            this.barcodeTextBox.Location = new System.Drawing.Point(154, 63);
            this.barcodeTextBox.Name = "barcodeTextBox";
            this.barcodeTextBox.Size = new System.Drawing.Size(192, 20);
            this.barcodeTextBox.TabIndex = 0;
            // 
            // barcodeNumberLabel
            // 
            this.barcodeNumberLabel.AutoSize = true;
            this.barcodeNumberLabel.Location = new System.Drawing.Point(46, 66);
            this.barcodeNumberLabel.Name = "barcodeNumberLabel";
            this.barcodeNumberLabel.Size = new System.Drawing.Size(87, 13);
            this.barcodeNumberLabel.TabIndex = 1;
            this.barcodeNumberLabel.Text = "Barcode Number";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(154, 112);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // checkOutScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(418, 181);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.barcodeNumberLabel);
            this.Controls.Add(this.barcodeTextBox);
            this.Name = "checkOutScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check-Out ";
            this.Load += new System.EventHandler(this.checkOutScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox barcodeTextBox;
        private System.Windows.Forms.Label barcodeNumberLabel;
        private System.Windows.Forms.Button submitButton;
    }
}