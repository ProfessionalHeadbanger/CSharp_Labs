namespace CSH_Lab3
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.task1Button = new System.Windows.Forms.Button();
            this.task2Button = new System.Windows.Forms.Button();
            this.task3Button = new System.Windows.Forms.Button();
            this.task4Button = new System.Windows.Forms.Button();
            this.hardtask5Button = new System.Windows.Forms.Button();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.inputCardTextBox = new System.Windows.Forms.TextBox();
            this.inputCardButton = new System.Windows.Forms.Button();
            this.shuffleButton = new System.Windows.Forms.Button();
            this.example1Button = new System.Windows.Forms.Button();
            this.example2Button = new System.Windows.Forms.Button();
            this.example3Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // task1Button
            // 
            this.task1Button.Location = new System.Drawing.Point(13, 13);
            this.task1Button.Name = "task1Button";
            this.task1Button.Size = new System.Drawing.Size(75, 23);
            this.task1Button.TabIndex = 0;
            this.task1Button.Text = "Задание 1";
            this.task1Button.UseVisualStyleBackColor = true;
            this.task1Button.Click += new System.EventHandler(this.task1Button_Click);
            // 
            // task2Button
            // 
            this.task2Button.Location = new System.Drawing.Point(12, 42);
            this.task2Button.Name = "task2Button";
            this.task2Button.Size = new System.Drawing.Size(75, 23);
            this.task2Button.TabIndex = 2;
            this.task2Button.Text = "Задание 2";
            this.task2Button.UseVisualStyleBackColor = true;
            this.task2Button.Click += new System.EventHandler(this.task2Button_Click);
            // 
            // task3Button
            // 
            this.task3Button.Location = new System.Drawing.Point(12, 71);
            this.task3Button.Name = "task3Button";
            this.task3Button.Size = new System.Drawing.Size(75, 23);
            this.task3Button.TabIndex = 3;
            this.task3Button.Text = "Задание 3";
            this.task3Button.UseVisualStyleBackColor = true;
            this.task3Button.Click += new System.EventHandler(this.task3Button_Click);
            // 
            // task4Button
            // 
            this.task4Button.Location = new System.Drawing.Point(12, 100);
            this.task4Button.Name = "task4Button";
            this.task4Button.Size = new System.Drawing.Size(75, 23);
            this.task4Button.TabIndex = 4;
            this.task4Button.Text = "Задание 4";
            this.task4Button.UseVisualStyleBackColor = true;
            this.task4Button.Click += new System.EventHandler(this.task4Button_Click);
            // 
            // hardtask5Button
            // 
            this.hardtask5Button.Location = new System.Drawing.Point(12, 129);
            this.hardtask5Button.Name = "hardtask5Button";
            this.hardtask5Button.Size = new System.Drawing.Size(75, 23);
            this.hardtask5Button.TabIndex = 6;
            this.hardtask5Button.Text = "Задание 5*";
            this.hardtask5Button.UseVisualStyleBackColor = true;
            this.hardtask5Button.Click += new System.EventHandler(this.hardtask5Button_Click);
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(169, 13);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.Size = new System.Drawing.Size(366, 197);
            this.richTextBoxOutput.TabIndex = 7;
            this.richTextBoxOutput.Text = "";
            // 
            // inputCardTextBox
            // 
            this.inputCardTextBox.Location = new System.Drawing.Point(169, 250);
            this.inputCardTextBox.Name = "inputCardTextBox";
            this.inputCardTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputCardTextBox.TabIndex = 8;
            this.inputCardTextBox.Visible = false;
            // 
            // inputCardButton
            // 
            this.inputCardButton.Location = new System.Drawing.Point(290, 248);
            this.inputCardButton.Name = "inputCardButton";
            this.inputCardButton.Size = new System.Drawing.Size(75, 23);
            this.inputCardButton.TabIndex = 9;
            this.inputCardButton.Text = "Ввести";
            this.inputCardButton.UseVisualStyleBackColor = true;
            this.inputCardButton.Visible = false;
            this.inputCardButton.Click += new System.EventHandler(this.inputCardButton_Click);
            // 
            // shuffleButton
            // 
            this.shuffleButton.Location = new System.Drawing.Point(561, 13);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(84, 23);
            this.shuffleButton.TabIndex = 10;
            this.shuffleButton.Text = "Перемешать";
            this.shuffleButton.UseVisualStyleBackColor = true;
            this.shuffleButton.Visible = false;
            this.shuffleButton.Click += new System.EventHandler(this.shuffleButton_Click);
            // 
            // example1Button
            // 
            this.example1Button.Location = new System.Drawing.Point(561, 71);
            this.example1Button.Name = "example1Button";
            this.example1Button.Size = new System.Drawing.Size(75, 23);
            this.example1Button.TabIndex = 11;
            this.example1Button.Text = "Пример 1";
            this.example1Button.UseVisualStyleBackColor = true;
            this.example1Button.Visible = false;
            this.example1Button.Click += new System.EventHandler(this.example1Button_Click);
            // 
            // example2Button
            // 
            this.example2Button.Location = new System.Drawing.Point(561, 100);
            this.example2Button.Name = "example2Button";
            this.example2Button.Size = new System.Drawing.Size(75, 23);
            this.example2Button.TabIndex = 12;
            this.example2Button.Text = "Пример 2";
            this.example2Button.UseVisualStyleBackColor = true;
            this.example2Button.Visible = false;
            this.example2Button.Click += new System.EventHandler(this.example2Button_Click);
            // 
            // example3Button
            // 
            this.example3Button.Location = new System.Drawing.Point(561, 129);
            this.example3Button.Name = "example3Button";
            this.example3Button.Size = new System.Drawing.Size(75, 23);
            this.example3Button.TabIndex = 13;
            this.example3Button.Text = "Пример 3";
            this.example3Button.UseVisualStyleBackColor = true;
            this.example3Button.Visible = false;
            this.example3Button.Click += new System.EventHandler(this.example3Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.example3Button);
            this.Controls.Add(this.example2Button);
            this.Controls.Add(this.example1Button);
            this.Controls.Add(this.shuffleButton);
            this.Controls.Add(this.inputCardButton);
            this.Controls.Add(this.inputCardTextBox);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.hardtask5Button);
            this.Controls.Add(this.task4Button);
            this.Controls.Add(this.task3Button);
            this.Controls.Add(this.task2Button);
            this.Controls.Add(this.task1Button);
            this.Name = "MainForm";
            this.Text = "Lab3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button task1Button;
        private System.Windows.Forms.Button task2Button;
        private System.Windows.Forms.Button task3Button;
        private System.Windows.Forms.Button task4Button;
        private System.Windows.Forms.Button hardtask5Button;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.TextBox inputCardTextBox;
        private System.Windows.Forms.Button inputCardButton;
        private System.Windows.Forms.Button shuffleButton;
        private System.Windows.Forms.Button example1Button;
        private System.Windows.Forms.Button example2Button;
        private System.Windows.Forms.Button example3Button;
    }
}

