
//Form1.cs: For disigning 

namespace WinFormsApp1
{
    partial class FormEMI
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
            components = new System.ComponentModel.Container();
            Labe1 = new Label();
            label2 = new Label();
            label3 = new Label();
            amountTextBox = new TextBox();
            rateTextBox = new TextBox();
            termNumericUpDown = new NumericUpDown();
            button1 = new Button();
            outputLabel = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)termNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // Labe1
            // 
            Labe1.AutoSize = true;
            Labe1.Font = new Font("Segoe UI Black", 14.1F, FontStyle.Bold, GraphicsUnit.Point);
            Labe1.Location = new Point(81, 79);
            Labe1.Margin = new Padding(8, 0, 8, 0);
            Labe1.Name = "Labe1";
            Labe1.Size = new Size(428, 62);
            Labe1.TabIndex = 0;
            Labe1.Text = "Loan amount (P):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14.1F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(47, 211);
            label2.Margin = new Padding(8, 0, 8, 0);
            label2.Name = "label2";
            label2.Size = new Size(462, 62);
            label2.TabIndex = 1;
            label2.Text = " Annual rate (R) %:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 14.1F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(251, 340);
            label3.Margin = new Padding(8, 0, 8, 0);
            label3.Name = "label3";
            label3.Size = new Size(258, 62);
            label3.TabIndex = 2;
            label3.Text = "Term (n): ";
            // 
            // amountTextBox
            // 
            amountTextBox.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point);
            amountTextBox.ForeColor = Color.Blue;
            amountTextBox.Location = new Point(555, 71);
            amountTextBox.Margin = new Padding(8);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(395, 70);
            amountTextBox.TabIndex = 3;
            // 
            // rateTextBox
            // 
            rateTextBox.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point);
            rateTextBox.ForeColor = Color.Blue;
            rateTextBox.Location = new Point(551, 203);
            rateTextBox.Margin = new Padding(8);
            rateTextBox.Name = "rateTextBox";
            rateTextBox.Size = new Size(399, 70);
            rateTextBox.TabIndex = 4;
            // 
            // termNumericUpDown
            // 
            termNumericUpDown.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point);
            termNumericUpDown.ForeColor = Color.Blue;
            termNumericUpDown.Location = new Point(551, 332);
            termNumericUpDown.Margin = new Padding(8);
            termNumericUpDown.Name = "termNumericUpDown";
            termNumericUpDown.Size = new Size(408, 70);
            termNumericUpDown.TabIndex = 5;
            termNumericUpDown.ValueChanged += termNumericUpDown_ValueChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Blue;
            button1.Location = new Point(1018, 31);
            button1.Margin = new Padding(8);
            button1.Name = "button1";
            button1.Size = new Size(470, 400);
            button1.TabIndex = 6;
            button1.Text = "Calculate EMI ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // outputLabel
            // 
            outputLabel.BackColor = Color.FromArgb(192, 255, 255);
            outputLabel.BorderStyle = BorderStyle.FixedSingle;
            outputLabel.ForeColor = Color.Blue;
            outputLabel.Location = new Point(1544, 31);
            outputLabel.Margin = new Padding(8, 0, 8, 0);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(449, 400);
            outputLabel.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(40, 40);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // FormEMI
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(2082, 481);
            Controls.Add(outputLabel);
            Controls.Add(button1);
            Controls.Add(termNumericUpDown);
            Controls.Add(rateTextBox);
            Controls.Add(amountTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Labe1);
            Margin = new Padding(8);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEMI";
            Text = "Equated monthly installment";
            ((System.ComponentModel.ISupportInitialize)termNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Labe1;
        private Label label2;
        private Label label3;
        private TextBox amountTextBox;
        private TextBox rateTextBox;
        private NumericUpDown termNumericUpDown;
        private Button button1;
        private Label outputLabel;
        private ContextMenuStrip contextMenuStrip1;
    }
}