namespace TigerCheck
{
     partial class Form3
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
               this.HideCommentsPanel = new System.Windows.Forms.Panel();
               this.NormalRadioButton = new System.Windows.Forms.RadioButton();
               this.AbnormalRadioButton = new System.Windows.Forms.RadioButton();
               this.CommentsTextBox = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.SubmitButton = new System.Windows.Forms.Button();
               this.CancelButton = new System.Windows.Forms.Button();
               this.barcodePanel = new System.Windows.Forms.Panel();
               this.CloseButtonH = new System.Windows.Forms.Button();
               this.barcodeSubmit = new System.Windows.Forms.Button();
               this.barcodeTextBox = new System.Windows.Forms.TextBox();
               this.label3 = new System.Windows.Forms.Label();
               this.barcodePanel.SuspendLayout();
               this.SuspendLayout();
               // 
               // HideCommentsPanel
               // 
               this.HideCommentsPanel.Location = new System.Drawing.Point(61, 124);
               this.HideCommentsPanel.Name = "HideCommentsPanel";
               this.HideCommentsPanel.Size = new System.Drawing.Size(393, 59);
               this.HideCommentsPanel.TabIndex = 0;
               // 
               // NormalRadioButton
               // 
               this.NormalRadioButton.AutoSize = true;
               this.NormalRadioButton.Location = new System.Drawing.Point(142, 80);
               this.NormalRadioButton.Name = "NormalRadioButton";
               this.NormalRadioButton.Size = new System.Drawing.Size(58, 17);
               this.NormalRadioButton.TabIndex = 1;
               this.NormalRadioButton.TabStop = true;
               this.NormalRadioButton.Text = "Normal";
               this.NormalRadioButton.UseVisualStyleBackColor = true;
               this.NormalRadioButton.CheckedChanged += new System.EventHandler(this.NormalRadioButton_CheckedChanged);
               // 
               // AbnormalRadioButton
               // 
               this.AbnormalRadioButton.AutoSize = true;
               this.AbnormalRadioButton.Location = new System.Drawing.Point(285, 80);
               this.AbnormalRadioButton.Name = "AbnormalRadioButton";
               this.AbnormalRadioButton.Size = new System.Drawing.Size(69, 17);
               this.AbnormalRadioButton.TabIndex = 2;
               this.AbnormalRadioButton.TabStop = true;
               this.AbnormalRadioButton.Text = "Abnormal";
               this.AbnormalRadioButton.UseVisualStyleBackColor = true;
               this.AbnormalRadioButton.CheckedChanged += new System.EventHandler(this.AbnormalRadioButton_CheckedChanged);
               // 
               // CommentsTextBox
               // 
               this.CommentsTextBox.Location = new System.Drawing.Point(134, 138);
               this.CommentsTextBox.Name = "CommentsTextBox";
               this.CommentsTextBox.Size = new System.Drawing.Size(273, 20);
               this.CommentsTextBox.TabIndex = 3;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(137, 42);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(231, 13);
               this.label1.TabIndex = 4;
               this.label1.Text = "Pick the option that reflects your patient\'s throat";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(72, 141);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(56, 13);
               this.label2.TabIndex = 5;
               this.label2.Text = "Comments";
               // 
               // SubmitButton
               // 
               this.SubmitButton.Location = new System.Drawing.Point(142, 206);
               this.SubmitButton.Name = "SubmitButton";
               this.SubmitButton.Size = new System.Drawing.Size(75, 23);
               this.SubmitButton.TabIndex = 6;
               this.SubmitButton.Text = "Submit";
               this.SubmitButton.UseVisualStyleBackColor = true;
               this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
               // 
               // CancelButton
               // 
               this.CancelButton.Location = new System.Drawing.Point(279, 206);
               this.CancelButton.Name = "CancelButton";
               this.CancelButton.Size = new System.Drawing.Size(75, 23);
               this.CancelButton.TabIndex = 7;
               this.CancelButton.Text = "Cancel";
               this.CancelButton.UseVisualStyleBackColor = true;
               this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
               // 
               // barcodePanel
               // 
               this.barcodePanel.Controls.Add(this.CloseButtonH);
               this.barcodePanel.Controls.Add(this.barcodeSubmit);
               this.barcodePanel.Controls.Add(this.barcodeTextBox);
               this.barcodePanel.Controls.Add(this.label3);
               this.barcodePanel.Location = new System.Drawing.Point(12, 12);
               this.barcodePanel.Name = "barcodePanel";
               this.barcodePanel.Size = new System.Drawing.Size(479, 217);
               this.barcodePanel.TabIndex = 8;
               // 
               // CloseButtonH
               // 
               this.CloseButtonH.Location = new System.Drawing.Point(208, 152);
               this.CloseButtonH.Name = "CloseButtonH";
               this.CloseButtonH.Size = new System.Drawing.Size(75, 23);
               this.CloseButtonH.TabIndex = 3;
               this.CloseButtonH.Text = "Close";
               this.CloseButtonH.UseVisualStyleBackColor = true;
               this.CloseButtonH.Click += new System.EventHandler(this.CloseButtonH_Click);
               // 
               // barcodeSubmit
               // 
               this.barcodeSubmit.Location = new System.Drawing.Point(208, 123);
               this.barcodeSubmit.Name = "barcodeSubmit";
               this.barcodeSubmit.Size = new System.Drawing.Size(75, 23);
               this.barcodeSubmit.TabIndex = 2;
               this.barcodeSubmit.Text = "Submit";
               this.barcodeSubmit.UseVisualStyleBackColor = true;
               this.barcodeSubmit.Click += new System.EventHandler(this.barcodeSubmit_Click);
               // 
               // barcodeTextBox
               // 
               this.barcodeTextBox.Location = new System.Drawing.Point(158, 97);
               this.barcodeTextBox.Name = "barcodeTextBox";
               this.barcodeTextBox.Size = new System.Drawing.Size(167, 20);
               this.barcodeTextBox.TabIndex = 1;
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.Location = new System.Drawing.Point(154, 58);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(171, 20);
               this.label3.TabIndex = 0;
               this.label3.Text = "Enter or Scan Barcode";
               // 
               // Form3
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(503, 241);
               this.Controls.Add(this.barcodePanel);
               this.Controls.Add(this.CancelButton);
               this.Controls.Add(this.SubmitButton);
               this.Controls.Add(this.HideCommentsPanel);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.label1);
               this.Controls.Add(this.CommentsTextBox);
               this.Controls.Add(this.AbnormalRadioButton);
               this.Controls.Add(this.NormalRadioButton);
               this.Name = "Form3";
               this.ShowInTaskbar = false;
               this.Text = "Throat";
               this.barcodePanel.ResumeLayout(false);
               this.barcodePanel.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.Panel HideCommentsPanel;
          private System.Windows.Forms.RadioButton NormalRadioButton;
          private System.Windows.Forms.RadioButton AbnormalRadioButton;
          private System.Windows.Forms.TextBox CommentsTextBox;
          private System.Windows.Forms.Label label1;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Button SubmitButton;
          private System.Windows.Forms.Button CancelButton;
          private System.Windows.Forms.Panel barcodePanel;
          private System.Windows.Forms.Button CloseButtonH;
          private System.Windows.Forms.Button barcodeSubmit;
          private System.Windows.Forms.TextBox barcodeTextBox;
          private System.Windows.Forms.Label label3;
     }
}