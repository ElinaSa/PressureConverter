namespace PressureConverter
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxKPa = new TextBox();
            textBoxPsi = new TextBox();
            textBoxBar = new TextBox();
            buttonCalculate = new Button();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 24);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Paine kPa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 24);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Paine psi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(232, 24);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "Paine bar";
            // 
            // textBoxKPa
            // 
            textBoxKPa.Location = new Point(24, 48);
            textBoxKPa.Name = "textBoxKPa";
            textBoxKPa.Size = new Size(100, 23);
            textBoxKPa.TabIndex = 3;
            textBoxKPa.TextChanged += textBoxKPa_TextChanged;
            textBoxKPa.Leave += textBoxKPa_Leave;
            // 
            // textBoxPsi
            // 
            textBoxPsi.Enabled = false;
            textBoxPsi.Location = new Point(128, 48);
            textBoxPsi.Name = "textBoxPsi";
            textBoxPsi.Size = new Size(100, 23);
            textBoxPsi.TabIndex = 4;
            // 
            // textBoxBar
            // 
            textBoxBar.Enabled = false;
            textBoxBar.Location = new Point(232, 48);
            textBoxBar.Name = "textBoxBar";
            textBoxBar.Size = new Size(100, 23);
            textBoxBar.TabIndex = 5;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(232, 104);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(100, 32);
            buttonCalculate.TabIndex = 6;
            buttonCalculate.Text = "Laske";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(24, 104);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(100, 32);
            buttonClear.TabIndex = 7;
            buttonClear.Text = "Tyhjennä";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 219);
            Controls.Add(buttonClear);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxBar);
            Controls.Add(textBoxPsi);
            Controls.Add(textBoxKPa);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxKPa;
        private TextBox textBoxPsi;
        private TextBox textBoxBar;
        private Button buttonCalculate;
        private Button buttonClear;
    }
}
