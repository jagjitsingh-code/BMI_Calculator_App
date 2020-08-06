namespace BMI_Calculator_App
{
    partial class BMICalculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.ImperialUnitsRadio = new System.Windows.Forms.RadioButton();
            this.MetricUnitsRadio = new System.Windows.Forms.RadioButton();
            this.HeightTextbox = new System.Windows.Forms.TextBox();
            this.WeightTextbox = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.ResetAppButton = new System.Windows.Forms.Button();
            this.OutputBMITextbox = new System.Windows.Forms.RichTextBox();
            this.OutputBMIProgressBar = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.42795F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.57205F));
            this.tableLayoutPanel1.Controls.Add(this.HeightLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ImperialUnitsRadio, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.MetricUnitsRadio, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.HeightTextbox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.WeightTextbox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.WeightLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CalculateBMIButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ResetAppButton, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.52525F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.47475F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(458, 265);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeightLabel.Location = new System.Drawing.Point(13, 10);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(137, 28);
            this.HeightLabel.TabIndex = 3;
            this.HeightLabel.Text = "My Height (in)";
            // 
            // ImperialUnitsRadio
            // 
            this.ImperialUnitsRadio.AutoSize = true;
            this.ImperialUnitsRadio.Checked = true;
            this.ImperialUnitsRadio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ImperialUnitsRadio.Location = new System.Drawing.Point(13, 122);
            this.ImperialUnitsRadio.Name = "ImperialUnitsRadio";
            this.ImperialUnitsRadio.Size = new System.Drawing.Size(104, 32);
            this.ImperialUnitsRadio.TabIndex = 1;
            this.ImperialUnitsRadio.TabStop = true;
            this.ImperialUnitsRadio.Text = "Imperial";
            this.ImperialUnitsRadio.UseVisualStyleBackColor = true;
            // 
            // MetricUnitsRadio
            // 
            this.MetricUnitsRadio.AutoSize = true;
            this.MetricUnitsRadio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MetricUnitsRadio.Location = new System.Drawing.Point(181, 122);
            this.MetricUnitsRadio.Name = "MetricUnitsRadio";
            this.MetricUnitsRadio.Size = new System.Drawing.Size(89, 32);
            this.MetricUnitsRadio.TabIndex = 2;
            this.MetricUnitsRadio.TabStop = true;
            this.MetricUnitsRadio.Text = "Metric";
            this.MetricUnitsRadio.UseVisualStyleBackColor = true;
            // 
            // HeightTextbox
            // 
            this.HeightTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeightTextbox.Location = new System.Drawing.Point(181, 13);
            this.HeightTextbox.Name = "HeightTextbox";
            this.HeightTextbox.Size = new System.Drawing.Size(264, 34);
            this.HeightTextbox.TabIndex = 4;
            // 
            // WeightTextbox
            // 
            this.WeightTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WeightTextbox.Location = new System.Drawing.Point(181, 70);
            this.WeightTextbox.Name = "WeightTextbox";
            this.WeightTextbox.Size = new System.Drawing.Size(264, 34);
            this.WeightTextbox.TabIndex = 5;
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WeightLabel.Location = new System.Drawing.Point(13, 67);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(150, 28);
            this.WeightLabel.TabIndex = 6;
            this.WeightLabel.Text = "My Weight (lbs)";
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalculateBMIButton.Location = new System.Drawing.Point(13, 174);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(162, 60);
            this.CalculateBMIButton.TabIndex = 0;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = true;
            // 
            // ResetAppButton
            // 
            this.ResetAppButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetAppButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetAppButton.Location = new System.Drawing.Point(334, 174);
            this.ResetAppButton.Name = "ResetAppButton";
            this.ResetAppButton.Size = new System.Drawing.Size(111, 60);
            this.ResetAppButton.TabIndex = 7;
            this.ResetAppButton.Text = "Reset";
            this.ResetAppButton.UseVisualStyleBackColor = true;
            // 
            // OutputBMITextbox
            // 
            this.OutputBMITextbox.BackColor = System.Drawing.Color.White;
            this.OutputBMITextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputBMITextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OutputBMITextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputBMITextbox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.OutputBMITextbox.Location = new System.Drawing.Point(25, 308);
            this.OutputBMITextbox.Name = "OutputBMITextbox";
            this.OutputBMITextbox.ReadOnly = true;
            this.OutputBMITextbox.Size = new System.Drawing.Size(432, 122);
            this.OutputBMITextbox.TabIndex = 1;
            this.OutputBMITextbox.Text = "";
            // 
            // OutputBMIProgressBar
            // 
            this.OutputBMIProgressBar.Location = new System.Drawing.Point(25, 263);
            this.OutputBMIProgressBar.Maximum = 50;
            this.OutputBMIProgressBar.Name = "OutputBMIProgressBar";
            this.OutputBMIProgressBar.Size = new System.Drawing.Size(432, 29);
            this.OutputBMIProgressBar.TabIndex = 2;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 453);
            this.Controls.Add(this.OutputBMIProgressBar);
            this.Controls.Add(this.OutputBMITextbox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.RadioButton ImperialUnitsRadio;
        private System.Windows.Forms.RadioButton MetricUnitsRadio;
        private System.Windows.Forms.TextBox HeightTextbox;
        private System.Windows.Forms.TextBox WeightTextbox;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.RichTextBox OutputBMITextbox;
        private System.Windows.Forms.ProgressBar OutputBMIProgressBar;
        private System.Windows.Forms.Button ResetAppButton;
    }
}

