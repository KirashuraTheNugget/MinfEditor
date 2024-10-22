namespace MinfEditor_Reattempt
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
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            Open = new Button();
            linkLabel1 = new LinkLabel();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            numericUpDown2 = new NumericUpDown();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 30);
            label1.TabIndex = 0;
            label1.Text = "MinfEditor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 21);
            label2.Name = "label2";
            label2.Size = new Size(208, 15);
            label2.TabIndex = 1;
            label2.Text = "A tool made by Kirasnuggets. 2024. V1";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Open
            // 
            Open.Location = new Point(12, 42);
            Open.Name = "Open";
            Open.Size = new Size(94, 23);
            Open.TabIndex = 2;
            Open.Text = "Open Mtninf";
            Open.UseVisualStyleBackColor = true;
            Open.Click += Open_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(22, 68);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(295, 15);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Don't know what an action does? Use this spreadsheet!";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 118);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 5;
            label3.Text = "Start Frame";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(160, 118);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(160, 100);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 7;
            label4.Text = "End Frame";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(307, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(307, 100);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 9;
            label5.Text = "Action";
            // 
            // button1
            // 
            button1.Location = new Point(128, 42);
            button1.Name = "button1";
            button1.Size = new Size(96, 23);
            button1.TabIndex = 10;
            button1.Text = "Save Mtninf";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 161);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(numericUpDown2);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(linkLabel1);
            Controls.Add(Open);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "MinfEditor";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button Open;
        private LinkLabel linkLabel1;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private NumericUpDown numericUpDown2;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private Button button1;
    }
}
