namespace TigerCheck
{
     partial class Form6
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
               this.NormalRadioButton = new System.Windows.Forms.RadioButton();
               this.AbnormalRadioButton = new System.Windows.Forms.RadioButton();
               this.label2 = new System.Windows.Forms.Label();
               this.SubmitButton = new System.Windows.Forms.Button();
               this.CancelButton = new System.Windows.Forms.Button();
               this.barcodePanel = new System.Windows.Forms.Panel();
               this.CloseButtonH = new System.Windows.Forms.Button();
               this.barcodeSubmit = new System.Windows.Forms.Button();
               this.barcodeTextBox = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.barcodePanel.SuspendLayout();
               this.SuspendLayout();
               // 
               // NormalRadioButton
               // 
               this.NormalRadioButton.AutoSize = true;
               this.NormalRadioButton.Location = new System.Drawing.Point(99, 108);
               this.NormalRadioButton.Name = "NormalRadioButton";
               this.NormalRadioButton.Size = new System.Drawing.Size(58, 17);
               this.NormalRadioButton.TabIndex = 0;
               this.NormalRadioButton.TabStop = true;
               this.NormalRadioButton.Text = "Normal";
               this.NormalRadioButton.UseVisualStyleBackColor = true;
               this.NormalRadioButton.CheckedChanged += new System.EventHandler(this.NormalRadioButton_CheckedChanged);
               // 
               // AbnormalRadioButton
               // 
               this.AbnormalRadioButton.AutoSize = true;
               this.AbnormalRadioButton.Location = new System.Drawing.Point(218, 108);
               this.AbnormalRadioButton.Name = "AbnormalRadioButton";
               this.AbnormalRadioButton.Size = new System.Drawing.Size(69, 17);
               this.AbnormalRadioButton.TabIndex = 1;
               this.AbnormalRadioButton.TabStop = true;
               this.AbnormalRadioButton.Text = "Abnormal";
               this.AbnormalRadioButton.UseVisualStyleBackColor = true;
               this.AbnormalRadioButton.CheckedChanged += new System.EventHandler(this.AbnormalRadioButton_CheckedChanged);
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(68, 58);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(277, 13);
               this.label2.TabIndex = 3;
               this.label2.Text = "Please pick the option that reflects the patient\'s breathing";
               // 
               // SubmitButton
               // 
               this.SubmitButton.Location = new System.Drawing.Point(99, 146);
               this.SubmitButton.Name = "SubmitButton";
               this.SubmitButton.Size = new System.Drawing.Size(75, 23);
               this.SubmitButton.TabIndex = 4;
               this.SubmitButton.Text = "Submit";
               this.SubmitButton.UseVisualStyleBackColor = true;
               this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
               // 
               // CancelButton
               // 
               this.CancelButton.Location = new System.Drawing.Point(218, 146);
               this.CancelButton.Name = "CancelButton";
               this.CancelButton.Size = new System.Drawing.Size(75, 23);
               this.CancelButton.TabIndex = 5;
               this.CancelButton.Text = "Cancel";
               this.CancelButton.UseVisualStyleBackColor = true;
               this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
               // 
               // barcodePanel
               // 
               this.barcodePanel.Controls.Add(this.CloseButtonH);
               this.barcodePanel.Controls.Add(this.barcodeSubmit);
               this.barcodePanel.Controls.Add(this.barcodeTextBox);
               this.barcodePanel.Controls.Add(this.label1);
               this.barcodePanel.Location = new System.Drawing.Point(34, 39);
               this.barcodePanel.Name = "barcodePanel";
               this.barcodePanel.Size = new System.Drawing.Size(321, 171);
               this.barcodePanel.TabIndex = 8;
               // 
               // CloseButtonH
               // 
               this.CloseButtonH.Location = new System.Drawing.Point(139, 127);
               this.CloseButtonH.Name = "CloseButtonH";
               this.CloseButtonH.Size = new System.Drawing.Size(75, 23);
               this.CloseButtonH.TabIndex = 3;
               this.CloseButtonH.Text = "Close";
               this.CloseButtonH.UseVisualStyleBackColor = true;
               this.CloseButtonH.Click += new System.EventHandler(this.CloseButtonH_Click);
               // 
               // barcodeSubmit
               // 
               this.barcodeSubmit.Location = new System.Drawing.Point(139, 98);
               this.barcodeSubmit.Name = "barcodeSubmit";
               this.barcodeSubmit.Size = new System.Drawing.Size(75, 23);
               this.barcodeSubmit.TabIndex = 2;
               this.barcodeSubmit.Text = "Submit";
               this.barcodeSubmit.UseVisualStyleBackColor = true;
               this.barcodeSubmit.Click += new System.EventHandler(this.barcodeSubmit_Click);
               // 
               // barcodeTextBox
               // 
               this.barcodeTextBox.Location = new System.Drawing.Point(89, 72);
               this.barcodeTextBox.Name = "barcodeTextBox";
               this.barcodeTextBox.Size = new System.Drawing.Size(167, 20);
               this.barcodeTextBox.TabIndex = 1;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(85, 33);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(171, 20);
               this.label1.TabIndex = 0;
               this.label1.Text = "Enter or Scan Barcode";
               // 
               // Form6
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(417, 234);
               this.Controls.Add(this.barcodePanel);
               this.Controls.Add(this.CancelButton);
               this.Controls.Add(this.SubmitButton);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.AbnormalRadioButton);
               this.Controls.Add(this.NormalRadioButton);
               this.Name = "Form6";
               this.Text = "Breathing";
               this.barcodePanel.ResumeLayout(false);
               this.barcodePanel.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.RadioButton NormalRadioButton;
          private System.Windows.Forms.RadioButton AbnormalRadioButton;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Button SubmitButton;
          private System.Windows.Forms.Button CancelButton;
          private System.Windows.Forms.Panel barcodePanel;
          private System.Windows.Forms.Button CloseButtonH;
          private System.Windows.Forms.Button barcodeSubmit;
          private System.Windows.Forms.TextBox barcodeTextBox;
          private System.Windows.Forms.Label label1;
     }
}