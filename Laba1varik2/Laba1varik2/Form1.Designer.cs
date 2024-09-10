namespace Laba1varik2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxRadius = new TextBox();
            textBoxVolume = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonCalculate = new Button();
            SuspendLayout();
            // 
            // textBoxRadius
            // 
            textBoxRadius.Location = new Point(72, 110);
            textBoxRadius.Name = "textBoxRadius";
            textBoxRadius.Size = new Size(345, 27);
            textBoxRadius.TabIndex = 0;
            // 
            // textBoxVolume
            // 
            textBoxVolume.Location = new Point(72, 152);
            textBoxVolume.Name = "textBoxVolume";
            textBoxVolume.Size = new Size(345, 27);
            textBoxVolume.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(88, 9);
            label1.Name = "label1";
            label1.Size = new Size(296, 81);
            label1.TabIndex = 2;
            label1.Text = "V=4/3πR³";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 141);
            label2.Name = "label2";
            label2.Size = new Size(56, 38);
            label2.TabIndex = 3;
            label2.Text = "V=";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 99);
            label3.Name = "label3";
            label3.Size = new Size(55, 38);
            label3.TabIndex = 4;
            label3.Text = "R=";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(177, 224);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(94, 29);
            buttonCalculate.TabIndex = 5;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 273);
            Controls.Add(buttonCalculate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxVolume);
            Controls.Add(textBoxRadius);
            Name = "Form1";
            Text = "Radius";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxRadius;
        private TextBox textBoxVolume;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonCalculate;
    }
}
