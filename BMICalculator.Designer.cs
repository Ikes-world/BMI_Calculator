namespace Assignment5_BMI_Calculator
{
    partial class BMICalculatorForm
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
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.ImperialConversionButton = new System.Windows.Forms.RadioButton();
			this.MetricsConversionButton = new System.Windows.Forms.RadioButton();
			this.CalculateBMIButton = new System.Windows.Forms.Button();
			this.Weight = new System.Windows.Forms.Label();
			this.WeightBox1 = new System.Windows.Forms.TextBox();
			this.Height = new System.Windows.Forms.Label();
			this.HeightBox1 = new System.Windows.Forms.TextBox();
			this.ResultsLabel = new System.Windows.Forms.Label();
			this.BMI_Label = new System.Windows.Forms.Label();
			this.ResultLabelBox = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.98602F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.01398F));
			this.tableLayoutPanel1.Controls.Add(this.ImperialConversionButton, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.MetricsConversionButton, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.CalculateBMIButton, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.Weight, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.WeightBox1, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.Height, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.HeightBox1, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.ResultsLabel, 0, 3);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(31, 52);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.36283F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.63717F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(235, 251);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// ImperialConversionButton
			// 
			this.ImperialConversionButton.AutoSize = true;
			this.ImperialConversionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ImperialConversionButton.Location = new System.Drawing.Point(127, 3);
			this.ImperialConversionButton.Name = "ImperialConversionButton";
			this.ImperialConversionButton.Size = new System.Drawing.Size(83, 21);
			this.ImperialConversionButton.TabIndex = 1;
			this.ImperialConversionButton.TabStop = true;
			this.ImperialConversionButton.Text = "Imperial";
			this.ImperialConversionButton.UseVisualStyleBackColor = true;
			// 
			// MetricsConversionButton
			// 
			this.MetricsConversionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.MetricsConversionButton.AutoSize = true;
			this.MetricsConversionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MetricsConversionButton.Location = new System.Drawing.Point(43, 3);
			this.MetricsConversionButton.Name = "MetricsConversionButton";
			this.MetricsConversionButton.Size = new System.Drawing.Size(78, 21);
			this.MetricsConversionButton.TabIndex = 1;
			this.MetricsConversionButton.TabStop = true;
			this.MetricsConversionButton.Text = "Metrics";
			this.MetricsConversionButton.UseVisualStyleBackColor = true;
			// 
			// CalculateBMIButton
			// 
			this.CalculateBMIButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CalculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CalculateBMIButton.Location = new System.Drawing.Point(127, 209);
			this.CalculateBMIButton.Name = "CalculateBMIButton";
			this.CalculateBMIButton.Size = new System.Drawing.Size(105, 39);
			this.CalculateBMIButton.TabIndex = 3;
			this.CalculateBMIButton.Text = "Calculate";
			this.CalculateBMIButton.UseVisualStyleBackColor = true;
			this.CalculateBMIButton.Click += new System.EventHandler(this.Btn_BMI);
			// 
			// Weight
			// 
			this.Weight.AutoSize = true;
			this.Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Weight.Location = new System.Drawing.Point(3, 85);
			this.Weight.Name = "Weight";
			this.Weight.Size = new System.Drawing.Size(106, 25);
			this.Weight.TabIndex = 0;
			this.Weight.Text = "My Weight";
			// 
			// WeightBox1
			// 
			this.WeightBox1.Location = new System.Drawing.Point(127, 88);
			this.WeightBox1.Name = "WeightBox1";
			this.WeightBox1.Size = new System.Drawing.Size(105, 38);
			this.WeightBox1.TabIndex = 1;
			// 
			// Height
			// 
			this.Height.AutoSize = true;
			this.Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Height.Location = new System.Drawing.Point(3, 37);
			this.Height.Name = "Height";
			this.Height.Size = new System.Drawing.Size(100, 25);
			this.Height.TabIndex = 0;
			this.Height.Text = "My Height";
			// 
			// HeightBox1
			// 
			this.HeightBox1.Location = new System.Drawing.Point(127, 40);
			this.HeightBox1.Name = "HeightBox1";
			this.HeightBox1.Size = new System.Drawing.Size(105, 38);
			this.HeightBox1.TabIndex = 1;
			// 
			// ResultsLabel
			// 
			this.ResultsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ResultsLabel.AutoSize = true;
			this.ResultsLabel.Location = new System.Drawing.Point(3, 220);
			this.ResultsLabel.Name = "ResultsLabel";
			this.ResultsLabel.Size = new System.Drawing.Size(114, 31);
			this.ResultsLabel.TabIndex = 4;
			this.ResultsLabel.Text = "Results:";
			// 
			// BMI_Label
			// 
			this.BMI_Label.AutoSize = true;
			this.BMI_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BMI_Label.Location = new System.Drawing.Point(49, 9);
			this.BMI_Label.Name = "BMI_Label";
			this.BMI_Label.Size = new System.Drawing.Size(192, 31);
			this.BMI_Label.TabIndex = 2;
			this.BMI_Label.Text = "BMI Calculator";
			// 
			// ResultLabelBox
			// 
			this.ResultLabelBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ResultLabelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ResultLabelBox.Location = new System.Drawing.Point(31, 309);
			this.ResultLabelBox.Name = "ResultLabelBox";
			this.ResultLabelBox.Size = new System.Drawing.Size(232, 30);
			this.ResultLabelBox.TabIndex = 5;
			// 
			// BMICalculatorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(304, 441);
			this.Controls.Add(this.BMI_Label);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.ResultLabelBox);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
			this.MaximizeBox = false;
			this.Name = "BMICalculatorForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BMI Calculator";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMICalculatorForm_FormClosing);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Height;
        private System.Windows.Forms.TextBox HeightBox1;
        private System.Windows.Forms.Label Weight;
        private System.Windows.Forms.RadioButton MetricsConversionButton;
        private System.Windows.Forms.RadioButton ImperialConversionButton;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.TextBox WeightBox1;
        private System.Windows.Forms.Label ResultsLabel;
        private System.Windows.Forms.Label BMI_Label;
		private System.Windows.Forms.TextBox ResultLabelBox;
	}
}

