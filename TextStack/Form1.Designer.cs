namespace TextStack
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
            textBox = new TextBox();
            textArea = new RichTextBox();
            writeBtn = new Button();
            undoBtn = new Button();
            redoBtn = new Button();
            alertLabel = new Label();
            exampleBox = new TextBox();
            exampleBtn = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Location = new Point(106, 55);
            textBox.Name = "textBox";
            textBox.Size = new Size(364, 31);
            textBox.TabIndex = 0;
            // 
            // textArea
            // 
            textArea.Location = new Point(106, 217);
            textArea.Name = "textArea";
            textArea.Size = new Size(523, 270);
            textArea.TabIndex = 1;
            textArea.Tag = "textArea";
            textArea.Text = "";
            // 
            // writeBtn
            // 
            writeBtn.Location = new Point(517, 53);
            writeBtn.Name = "writeBtn";
            writeBtn.Size = new Size(112, 34);
            writeBtn.TabIndex = 2;
            writeBtn.Text = "Write";
            writeBtn.UseVisualStyleBackColor = false;
            writeBtn.Click += writeBtn_Click;
            // 
            // undoBtn
            // 
            undoBtn.Location = new Point(106, 92);
            undoBtn.Name = "undoBtn";
            undoBtn.Size = new Size(112, 34);
            undoBtn.TabIndex = 3;
            undoBtn.Tag = "undo";
            undoBtn.Text = "undo";
            undoBtn.UseVisualStyleBackColor = true;
            undoBtn.Click += undoBtn_Click;
            // 
            // redoBtn
            // 
            redoBtn.Location = new Point(358, 92);
            redoBtn.Name = "redoBtn";
            redoBtn.Size = new Size(112, 34);
            redoBtn.TabIndex = 4;
            redoBtn.Tag = "redo";
            redoBtn.Text = "redo";
            redoBtn.UseVisualStyleBackColor = true;
            redoBtn.Click += redoBtn_Click;
            // 
            // alertLabel
            // 
            alertLabel.AutoSize = true;
            alertLabel.Location = new Point(106, 138);
            alertLabel.Name = "alertLabel";
            alertLabel.Size = new Size(0, 25);
            alertLabel.TabIndex = 5;
            // 
            // exampleBox
            // 
            exampleBox.Location = new Point(818, 57);
            exampleBox.Name = "exampleBox";
            exampleBox.Size = new Size(442, 31);
            exampleBox.TabIndex = 6;
            exampleBox.Text = "w Data w MINING u w Structures s";
            // 
            // exampleBtn
            // 
            exampleBtn.Location = new Point(981, 133);
            exampleBtn.Name = "exampleBtn";
            exampleBtn.Size = new Size(112, 34);
            exampleBtn.TabIndex = 7;
            exampleBtn.Text = "Result";
            exampleBtn.UseVisualStyleBackColor = true;
            exampleBtn.Click += exampleBtn_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(818, 217);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(539, 270);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1572, 592);
            Controls.Add(richTextBox1);
            Controls.Add(exampleBtn);
            Controls.Add(exampleBox);
            Controls.Add(alertLabel);
            Controls.Add(redoBtn);
            Controls.Add(undoBtn);
            Controls.Add(writeBtn);
            Controls.Add(textArea);
            Controls.Add(textBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private RichTextBox textArea;
        private Button writeBtn;
        private Button undoBtn;
        private Button redoBtn;
        public Label alertLabel;
        private TextBox exampleBox;
        private Button exampleBtn;
        private RichTextBox richTextBox1;
    }
}
