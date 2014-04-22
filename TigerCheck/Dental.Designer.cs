namespace TigerCheck
{
     partial class Dental
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
               this.NormalRadioButton = new System.Windows.Forms.RadioButton();
               this.AbnormalRadioButton = new System.Windows.Forms.RadioButton();
               this.IssuesTextBox = new System.Windows.Forms.TextBox();
               this.CommentsTextBox = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.HideCommentsPanel = new System.Windows.Forms.Panel();
               this.CancelButton = new System.Windows.Forms.Button();
               this.SubmitButton = new System.Windows.Forms.Button();
               this.barcodePanel.SuspendLayout();
               this.SuspendLayout();
               // 
               // barcodePanel
               // 
               this.barcodePanel.Controls.Add(this.barcodeCloseV);
               this.barcodePanel.Controls.Add(this.barcodeSubmit);
               this.barcodePanel.Controls.Add(this.barcodeTextBox);
               this.barcodePanel.Controls.Add(this.label1);
               this.barcodePanel.Location = new System.Drawing.Point(12, 13);
               this.barcodePanel.Name = "barcodePanel";
               this.barcodePanel.Size = new System.Drawing.Size(462, 226);
               this.barcodePanel.TabIndex = 6;
               // 
               // barcodeCloseV
               // 
               this.barcodeCloseV.Location = new System.Drawing.Point(188, 136);
               this.barcodeCloseV.Name = "barcodeCloseV";
               this.barcodeCloseV.Size = new System.Drawing.Size(75, 23);
               this.barcodeCloseV.TabIndex = 3;
               this.barcodeCloseV.Text = "Close";
               this.barcodeCloseV.UseVisualStyleBackColor = true;
               this.barcodeCloseV.Click += new System.EventHandler(this.closeButtonD_Click);
               // 
               // barcodeSubmit
               // 
               this.barcodeSubmit.Location = new System.Drawing.Point(188, 107);
               this.barcodeSubmit.Name = "barcodeSubmit";
               this.barcodeSubmit.Size = new System.Drawing.Size(75, 23);
               this.barcodeSubmit.TabIndex = 2;
               this.barcodeSubmit.Text = "Submit";
               this.barcodeSubmit.UseVisualStyleBackColor = true;
               this.barcodeSubmit.Click += new System.EventHandler(this.submitButtonD_Click);
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
               // NormalRadioButton
               // 
               this.NormalRadioButton.AutoSize = true;
               this.NormalRadioButton.Location = new System.Drawing.Point(118, 93);
               this.NormalRadioButton.Name = "NormalRadioButton";
               this.NormalRadioButton.Size = new System.Drawing.Size(84, 17);
               this.NormalRadioButton.TabIndex = 7;
               this.NormalRadioButton.TabStop = true;
               this.NormalRadioButton.Text = "No problems";
               this.NormalRadioButton.UseVisualStyleBackColor = true;
               this.NormalRadioButton.CheckedChanged += new System.EventHandler(this.NormalRadioButton_CheckedChanged);
               // 
               // AbnormalRadioButton
               // 
               this.AbnormalRadioButton.AutoSize = true;
               this.AbnormalRadioButton.Location = new System.Drawing.Point(285, 93);
               this.AbnormalRadioButton.Name = "AbnormalRadioButton";
               this.AbnormalRadioButton.Size = new System.Drawing.Size(68, 17);
               this.AbnormalRadioButton.TabIndex = 8;
               this.AbnormalRadioButton.TabStop = true;
               this.AbnormalRadioButton.Text = "Problems";
               this.AbnormalRadioButton.UseVisualStyleBackColor = true;
               this.AbnormalRadioButton.CheckedChanged += new System.EventHandler(this.AbnormalRadioButton_CheckedChanged);
               // 
               // IssuesTextBox
               // 
               this.IssuesTextBox.Location = new System.Drawing.Point(118, 153);
               this.IssuesTextBox.Name = "IssuesTextBox";
               this.IssuesTextBox.Size = new System.Drawing.Size(265, 20);
               this.IssuesTextBox.TabIndex = 9;
               // 
               // CommentsTextBox
               // 
               this.CommentsTextBox.AutoSize = true;
               this.CommentsTextBox.Location = new System.Drawing.Point(56, 156);
               this.CommentsTextBox.Name = "CommentsTextBox";
               this.CommentsTextBox.Size = new System.Drawing.Size(56, 13);
               this.CommentsTextBox.TabIndex = 10;
               this.CommentsTextBox.Text = "Comments";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(115, 42);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(226, 13);
               this.label2.TabIndex = 11;
               this.label2.Text = "Mark whether the patient has issues with teeth";
               // 
               // HideCommentsPanel
               // 
               this.HideCommentsPanel.Location = new System.Drawing.Point(49, 132);
               this.HideCommentsPanel.Name = "HideCommentsPanel";
               this.HideCommentsPanel.Size = new System.Drawing.Size(381, 70);
               this.HideCommentsPanel.TabIndex = 12;
               // 
               // CancelButton
               // 
               this.CancelButton.Location = new System.Drawing.Point(278, 179);
               this.CancelButton.Name = "CancelButton";
               this.CancelButton.Size = new System.Drawing.Size(75, 23);
               this.CancelButton.TabIndex = 13;
               this.CancelButton.Text = "Cancel";
               this.CancelButton.UseVisualStyleBackColor = true;
               this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
               // 
               // SubmitButton
               // 
               this.SubmitButton.Location = new System.Drawing.Point(127, 179);
               this.SubmitButton.Name = "SubmitButton";
               this.SubmitButton.Size = new System.Drawing.Size(75, 23);
               this.SubmitButton.TabIndex = 14;
               this.SubmitButton.Text = "Submit";
               this.SubmitButton.UseVisualStyleBackColor = true;
               this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
               // 
               // Dental
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(486, 251);
               this.Controls.Add(this.barcodePanel);
               this.Controls.Add(this.HideCommentsPanel);
               this.Controls.Add(this.SubmitButton);
               this.Controls.Add(this.CancelButton);
               this.Controls.Add(this.label2);
               this.Controls.Add(this.CommentsTextBox);
               this.Controls.Add(this.IssuesTextBox);
               this.Controls.Add(this.AbnormalRadioButton);
               this.Controls.Add(this.NormalRadioButton);
               this.Name = "Dental";
               this.Text = "Dental";
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
          private System.Windows.Forms.RadioButton NormalRadioButton;
          private System.Windows.Forms.RadioButton AbnormalRadioButton;
          private System.Windows.Forms.TextBox IssuesTextBox;
          private System.Windows.Forms.Label CommentsTextBox;
          private System.Windows.Forms.Label label2;
          private System.Windows.Forms.Panel HideCommentsPanel;
          private System.Windows.Forms.Button CancelButton;
          private System.Windows.Forms.Button SubmitButton;
     }
}