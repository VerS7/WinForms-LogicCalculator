using BooleanAlgebra;


namespace WinForms_AAC_LogicCalculator
{
    partial class CalculatorForm
    {
        private System.ComponentModel.IContainer components = null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            this.formulaEntry = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.actionsLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // formulaEntry
            // 
            this.formulaEntry.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.formulaEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.formulaEntry.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formulaEntry.Location = new System.Drawing.Point(12, 12);
            this.formulaEntry.Name = "formulaEntry";
            this.formulaEntry.PlaceholderText = "Введите логическое выражение";
            this.formulaEntry.Size = new System.Drawing.Size(285, 29);
            this.formulaEntry.TabIndex = 0;
            this.formulaEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calcButton
            // 
            this.calcButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.calcButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calcButton.Location = new System.Drawing.Point(12, 47);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(110, 34);
            this.calcButton.TabIndex = 1;
            this.calcButton.Text = "Вычислить";
            this.calcButton.UseVisualStyleBackColor = false;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click_1);
            // 
            // actionsLabel
            // 
            this.actionsLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.actionsLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.actionsLabel.Location = new System.Drawing.Point(12, 94);
            this.actionsLabel.Name = "actionsLabel";
            this.actionsLabel.Size = new System.Drawing.Size(285, 163);
            this.actionsLabel.TabIndex = 2;
            // 
            // resultLabel
            // 
            this.resultLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.resultLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.resultLabel.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultLabel.Location = new System.Drawing.Point(203, 47);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(94, 34);
            this.resultLabel.TabIndex = 3;
            this.resultLabel.Text = "Результат";
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 269);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.actionsLabel);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.formulaEntry);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculatorForm";
            this.Text = "AAC Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox formulaEntry;
        private Button calcButton;
        private Label actionsLabel;
        private Label resultLabel;
    }
}