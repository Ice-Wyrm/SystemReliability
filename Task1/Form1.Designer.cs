namespace Task1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.averageTimeField = new System.Windows.Forms.NumericUpDown();
            this.recoveryTimeField = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.averageTimeField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recoveryTimeField)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ср. наработка на отказ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ср. время восстановления";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Коэффициент готовности";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(31, 253);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(21, 196);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(100, 20);
            this.resultBox.TabIndex = 6;
            // 
            // averageTimeField
            // 
            this.averageTimeField.Location = new System.Drawing.Point(12, 38);
            this.averageTimeField.Name = "averageTimeField";
            this.averageTimeField.Size = new System.Drawing.Size(120, 20);
            this.averageTimeField.TabIndex = 7;
            // 
            // recoveryTimeField
            // 
            this.recoveryTimeField.Location = new System.Drawing.Point(12, 126);
            this.recoveryTimeField.Name = "recoveryTimeField";
            this.recoveryTimeField.Size = new System.Drawing.Size(120, 20);
            this.recoveryTimeField.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(156, 284);
            this.Controls.Add(this.recoveryTimeField);
            this.Controls.Add(this.averageTimeField);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.averageTimeField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recoveryTimeField)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.NumericUpDown averageTimeField;
        private System.Windows.Forms.NumericUpDown recoveryTimeField;
    }
}

