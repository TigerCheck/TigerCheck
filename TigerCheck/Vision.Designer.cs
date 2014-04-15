namespace TigerCheck
{
     partial class Form2
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
               this.barcodePanel = new System.Windows.Forms.Panel();
               this.barcodeCloseV = new System.Windows.Forms.Button();
               this.barcodeSubmit = new System.Windows.Forms.Button();
               this.barcodeTextBox = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.VisionTextBox = new System.Windows.Forms.TextBox();
               this.submitButton = new System.Windows.Forms.Button();
               this.cancelButton = new System.Windows.Forms.Button();
               this.barcodePanel.SuspendLayout();
               this.SuspendLayout();
               // 
               // barcodePanel
               // 
               this.barcodePanel.Controls.Add(this.barcodeCloseV);
               this.barcodePanel.Controls.Add(this.barcodeSubmit);
               this.barcodePanel.Controls.Add(this.barcodeTextBox);
               this.barcodePanel.Controls.Add(this.label1);
               this.barcodePanel.Location = new System.Drawing.Point(12, 12);
               this.barcodePanel.Name = "barcodePanel";
               this.barcodePanel.Size = new System.Drawing.Size(474, 226);
               this.barcodePanel.TabIndex = 5;
               // 
               // barcodeCloseV
               // 
               this.barcodeCloseV.Location = new System.Drawing.Point(188, 136);
               this.barcodeCloseV.Name = "barcodeCloseV";
               this.barcodeCloseV.Size = new System.Drawing.Size(75, 23);
               this.barcodeCloseV.TabIndex = 3;
               this.barcodeCloseV.Text = "Close";
               this.barcodeCloseV.UseVisualStyleBackColor = true;
               this.barcodeCloseV.Click += new System.EventHandler(this.barcodeCloseV_Click);
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
               // barcodeTextBox
               // 
               this.barcodeTextBox.Location = new System.Drawing.Point(138, 81);
               this.barcodeTextBox.Name = "barcodeTextBox";
               this.barcodeTextBox.Size = new System.Drawing.Size(167, 20);
               this.barcodeTextBox.TabIndex = 1;
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
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(162, 47);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(167, 18);
               this.label2.TabIndex = 6;
               this.label2.Text = "Enter the patient\'s vision";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.Location = new System.Drawing.Point(197, 113);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(32, 18);
               this.label3.TabIndex = 7;
               this.label3.Text = "20 /";
               // 
               // VisionTextBox
               // 
               this.VisionTextBox.Location = new System.Drawing.Point(229, 114);
               this.VisionTextBox.Name = "VisionTextBox";
               this.VisionTextBox.Size = new System.Drawing.Size(100, 20);
               this.VisionTextBox.TabIndex = 8;
               this.VisionTextBox.Text = "20";
               // 
               // submitButton
               // 
               this.submitButton.Location = new System.Drawing.Point(150, 171);
               this.submitButton.Name = "submitButton";
               this.submitButton.Size = new System.Drawing.Size(75, 23);
               this.submitButton.TabIndex = 9;
               this.submitButton.Text = "Submit";
               this.submitButton.UseVisualStyleBackColor = true;
               this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
               // 
               // cancelButton
               // 
               this.cancelButton.Location = new System.Drawing.Point(268, 171);
               this.cancelButton.Name = "cancelButton";
               this.cancelButton.Size = new System.Drawing.Size(75, 23);
               this.cancelButton.TabIndex = 10;
               this.cancelButton.Text = "Cancel";
               this.cancelButton.UseVisualStyleBackColor = true;
               this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
               // 
               // Form2
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(498, 250);
               this.Controls.Add(this.barcodePanel);
               this.Controls.Add(this.cancelButton);
               this.Controls.Add(this.submitButton);
               this.Controls.Add(this.VisionTextBox);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.label2);
               this.Name = "Form2";
               this.Text = "Vision";
               this.barcodePanel.ResumeLayout(false);
               this.barcodePanel.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Panel barcodePanel;
          private System.Windows.Forms.Button barcodeCloseV;
          private System.Windows.Forms.Button barcodeSubmit;
          private System.Windows.Forms.TextBox barcodeTextBox;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Label label3;
          private System.Windows.Forms.TextBox VisionTextBox;
          private System.Windows.Forms.Button submitButton;
          private System.Windows.Forms.Button cancelButton;
     }
}