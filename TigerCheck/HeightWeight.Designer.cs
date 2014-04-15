namespace TigerCheck
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
               this.label1 = new System.Windows.Forms.Label();
               this.barcodeTextBox = new System.Windows.Forms.TextBox();
               this.barcodeSubmit = new System.Windows.Forms.Button();
               this.barcodeCloseHW = new System.Windows.Forms.Button();
               this.barcodePanel = new System.Windows.Forms.Panel();
               this.panel2 = new System.Windows.Forms.Panel();
               this.cancelButton = new System.Windows.Forms.Button();
               this.submitButton = new System.Windows.Forms.Button();
               this.label6 = new System.Windows.Forms.Label();
               this.WeightTextBox = new System.Windows.Forms.TextBox();
               this.label5 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.HeightInInchesTextBox = new System.Windows.Forms.TextBox();
               this.HeightInFeetTextBox = new System.Windows.Forms.TextBox();
               this.label3 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label7 = new System.Windows.Forms.Label();
               this.barcodePanel.SuspendLayout();
               this.panel2.SuspendLayout();
               this.SuspendLayout();
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(134, 42);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(171, 20);
               this.label1.TabIndex = 0;
               this.label1.Text = "Enter or Scan Barcode";
               // 
               // barcodeTextBox
               // 
               this.barcodeTextBox.Location = new System.Drawing.Point(138, 81);
               this.barcodeTextBox.Name = "barcodeTextBox";
               this.barcodeTextBox.Size = new System.Drawing.Size(167, 20);
               this.barcodeTextBox.TabIndex = 1;
               // 
               // barcodeSubmit
               // 
               this.barcodeSubmit.Location = new System.Drawing.Point(188, 107);
               this.barcodeSubmit.Name = "barcodeSubmit";
               this.barcodeSubmit.Size = new System.Drawing.Size(75, 23);
               this.barcodeSubmit.TabIndex = 2;
               this.barcodeSubmit.Text = "Submit";
               this.barcodeSubmit.UseVisualStyleBackColor = true;
               this.barcodeSubmit.Click += new System.EventHandler(this.barcodeSubmit_Click);
               // 
               // barcodeCloseHW
               // 
               this.barcodeCloseHW.Location = new System.Drawing.Point(188, 136);
               this.barcodeCloseHW.Name = "barcodeCloseHW";
               this.barcodeCloseHW.Size = new System.Drawing.Size(75, 23);
               this.barcodeCloseHW.TabIndex = 3;
               this.barcodeCloseHW.Text = "Close";
               this.barcodeCloseHW.UseVisualStyleBackColor = true;
               this.barcodeCloseHW.Click += new System.EventHandler(this.barcodeCloseHW_Click);
               // 
               // barcodePanel
               // 
               this.barcodePanel.Controls.Add(this.barcodeCloseHW);
               this.barcodePanel.Controls.Add(this.barcodeSubmit);
               this.barcodePanel.Controls.Add(this.barcodeTextBox);
               this.barcodePanel.Controls.Add(this.label1);
               this.barcodePanel.Location = new System.Drawing.Point(12, 12);
               this.barcodePanel.Name = "barcodePanel";
               this.barcodePanel.Size = new System.Drawing.Size(462, 193);
               this.barcodePanel.TabIndex = 4;
               // 
               // panel2
               // 
               this.panel2.Controls.Add(this.cancelButton);
               this.panel2.Controls.Add(this.submitButton);
               this.panel2.Controls.Add(this.label6);
               this.panel2.Controls.Add(this.WeightTextBox);
               this.panel2.Controls.Add(this.label5);
               this.panel2.Controls.Add(this.label4);
               this.panel2.Controls.Add(this.HeightInInchesTextBox);
               this.panel2.Controls.Add(this.HeightInFeetTextBox);
               this.panel2.Controls.Add(this.label3);
               this.panel2.Controls.Add(this.label2);
               this.panel2.Controls.Add(this.label7);
               this.panel2.Location = new System.Drawing.Point(37, 17);
               this.panel2.Name = "panel2";
               this.panel2.Size = new System.Drawing.Size(412, 182);
               this.panel2.TabIndex = 12;
               // 
               // cancelButton
               // 
               this.cancelButton.Location = new System.Drawing.Point(206, 148);
               this.cancelButton.Name = "cancelButton";
               this.cancelButton.Size = new System.Drawing.Size(75, 23);
               this.cancelButton.TabIndex = 10;
               this.cancelButton.Text = "Cancel";
               this.cancelButton.UseVisualStyleBackColor = true;
               this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
               // 
               // submitButton
               // 
               this.submitButton.Location = new System.Drawing.Point(105, 148);
               this.submitButton.Name = "submitButton";
               this.submitButton.Size = new System.Drawing.Size(75, 23);
               this.submitButton.TabIndex = 9;
               this.submitButton.Text = "OK";
               this.submitButton.UseVisualStyleBackColor = true;
               this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
               // 
               // label6
               // 
               this.label6.AutoSize = true;
               this.label6.Location = new System.Drawing.Point(299, 92);
               this.label6.Name = "label6";
               this.label6.Size = new System.Drawing.Size(43, 13);
               this.label6.TabIndex = 8;
               this.label6.Text = "Pounds";
               // 
               // WeightTextBox
               // 
               this.WeightTextBox.Location = new System.Drawing.Point(105, 89);
               this.WeightTextBox.Name = "WeightTextBox";
               this.WeightTextBox.Size = new System.Drawing.Size(176, 20);
               this.WeightTextBox.TabIndex = 7;
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Location = new System.Drawing.Point(299, 66);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(39, 13);
               this.label5.TabIndex = 6;
               this.label5.Text = "Inches";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(182, 66);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(28, 13);
               this.label4.TabIndex = 5;
               this.label4.Text = "Feet";
               // 
               // HeightInInchesTextBox
               // 
               this.HeightInInchesTextBox.Location = new System.Drawing.Point(223, 63);
               this.HeightInInchesTextBox.Name = "HeightInInchesTextBox";
               this.HeightInInchesTextBox.Size = new System.Drawing.Size(58, 20);
               this.HeightInInchesTextBox.TabIndex = 4;
               // 
               // HeightInFeetTextBox
               // 
               this.HeightInFeetTextBox.Location = new System.Drawing.Point(105, 63);
               this.HeightInFeetTextBox.Name = "HeightInFeetTextBox";
               this.HeightInFeetTextBox.Size = new System.Drawing.Size(58, 20);
               this.HeightInFeetTextBox.TabIndex = 3;
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(112, 17);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(179, 13);
               this.label3.TabIndex = 2;
               this.label3.Text = "Enter the patient\'s height and weight";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(29, 92);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(41, 13);
               this.label2.TabIndex = 1;
               this.label2.Text = "Weight";
               // 
               // label7
               // 
               this.label7.AutoSize = true;
               this.label7.Location = new System.Drawing.Point(29, 66);
               this.label7.Name = "label7";
               this.label7.Size = new System.Drawing.Size(38, 13);
               this.label7.TabIndex = 0;
               this.label7.Text = "Height";
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(486, 217);
               this.Controls.Add(this.barcodePanel);
               this.Controls.Add(this.panel2);
               this.Name = "Form1";
               this.Text = "Height / Weight";
               this.barcodePanel.ResumeLayout(false);
               this.barcodePanel.PerformLayout();
               this.panel2.ResumeLayout(false);
               this.panel2.PerformLayout();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.TextBox barcodeTextBox;
          private System.Windows.Forms.Button barcodeSubmit;
          private System.Windows.Forms.Button barcodeCloseHW;
          private System.Windows.Forms.Panel barcodePanel;
          private System.Windows.Forms.Panel panel2;
          private System.Windows.Forms.Button cancelButton;
          private System.Windows.Forms.Button submitButton;
          private System.Windows.Forms.Label label6;
          private System.Windows.Forms.TextBox WeightTextBox;
          private System.Windows.Forms.Label label5;
          private System.Windows.Forms.Label label4;
          private System.Windows.Forms.TextBox HeightInInchesTextBox;
          private System.Windows.Forms.TextBox HeightInFeetTextBox;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Label label7;


     }
}