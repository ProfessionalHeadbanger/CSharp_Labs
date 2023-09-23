namespace CSH_Lab1
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
            this.buttonRectangle = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.buttonTriangle = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelSide = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelRadius = new System.Windows.Forms.Label();
            this.labelSideCA = new System.Windows.Forms.Label();
            this.labelSideAB = new System.Windows.Forms.Label();
            this.labelSideBC = new System.Windows.Forms.Label();
            this.labelPerimeter = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.ListButton1 = new System.Windows.Forms.Button();
            this.ListButton2 = new System.Windows.Forms.Button();
            this.ListButton3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.Location = new System.Drawing.Point(13, 12);
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(120, 23);
            this.buttonRectangle.TabIndex = 0;
            this.buttonRectangle.Text = "Прямоугольник";
            this.buttonRectangle.UseVisualStyleBackColor = true;
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // buttonSquare
            // 
            this.buttonSquare.Location = new System.Drawing.Point(13, 41);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(120, 23);
            this.buttonSquare.TabIndex = 1;
            this.buttonSquare.Text = "Квадрат";
            this.buttonSquare.UseVisualStyleBackColor = true;
            this.buttonSquare.Click += new System.EventHandler(this.buttonSquare_Click);
            // 
            // buttonCircle
            // 
            this.buttonCircle.Location = new System.Drawing.Point(12, 70);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(121, 23);
            this.buttonCircle.TabIndex = 2;
            this.buttonCircle.Text = "Круг";
            this.buttonCircle.UseVisualStyleBackColor = true;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // buttonTriangle
            // 
            this.buttonTriangle.Location = new System.Drawing.Point(12, 99);
            this.buttonTriangle.Name = "buttonTriangle";
            this.buttonTriangle.Size = new System.Drawing.Size(121, 23);
            this.buttonTriangle.TabIndex = 3;
            this.buttonTriangle.Text = "Треугольник";
            this.buttonTriangle.UseVisualStyleBackColor = true;
            this.buttonTriangle.Click += new System.EventHandler(this.buttonTriangle_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(13, 156);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(120, 58);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "Рассчитать";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(232, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Visible = false;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(169, 15);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(40, 13);
            this.labelWidth.TabIndex = 7;
            this.labelWidth.Text = "Длина";
            this.labelWidth.Visible = false;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(169, 42);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(46, 13);
            this.labelHeight.TabIndex = 9;
            this.labelHeight.Text = "Ширина";
            this.labelHeight.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(232, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.Visible = false;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // labelSide
            // 
            this.labelSide.AutoSize = true;
            this.labelSide.Location = new System.Drawing.Point(169, 15);
            this.labelSide.Name = "labelSide";
            this.labelSide.Size = new System.Drawing.Size(49, 13);
            this.labelSide.TabIndex = 10;
            this.labelSide.Text = "Сторона";
            this.labelSide.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(232, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 11;
            this.textBox3.Visible = false;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // labelRadius
            // 
            this.labelRadius.AutoSize = true;
            this.labelRadius.Location = new System.Drawing.Point(169, 15);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(43, 13);
            this.labelRadius.TabIndex = 12;
            this.labelRadius.Text = "Радиус";
            this.labelRadius.Visible = false;
            // 
            // labelSideCA
            // 
            this.labelSideCA.AutoSize = true;
            this.labelSideCA.Location = new System.Drawing.Point(166, 68);
            this.labelSideCA.Name = "labelSideCA";
            this.labelSideCA.Size = new System.Drawing.Size(61, 13);
            this.labelSideCA.TabIndex = 13;
            this.labelSideCA.Text = " Сторона 3";
            this.labelSideCA.Visible = false;
            // 
            // labelSideAB
            // 
            this.labelSideAB.AutoSize = true;
            this.labelSideAB.Location = new System.Drawing.Point(169, 15);
            this.labelSideAB.Name = "labelSideAB";
            this.labelSideAB.Size = new System.Drawing.Size(58, 13);
            this.labelSideAB.TabIndex = 14;
            this.labelSideAB.Text = "Сторона 1";
            this.labelSideAB.Visible = false;
            // 
            // labelSideBC
            // 
            this.labelSideBC.AutoSize = true;
            this.labelSideBC.Location = new System.Drawing.Point(169, 41);
            this.labelSideBC.Name = "labelSideBC";
            this.labelSideBC.Size = new System.Drawing.Size(58, 13);
            this.labelSideBC.TabIndex = 15;
            this.labelSideBC.Text = "Сторона 2";
            this.labelSideBC.Visible = false;
            // 
            // labelPerimeter
            // 
            this.labelPerimeter.AutoSize = true;
            this.labelPerimeter.Location = new System.Drawing.Point(13, 241);
            this.labelPerimeter.Name = "labelPerimeter";
            this.labelPerimeter.Size = new System.Drawing.Size(64, 13);
            this.labelPerimeter.TabIndex = 16;
            this.labelPerimeter.Text = "Периметр: ";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(13, 266);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(60, 13);
            this.labelArea.TabIndex = 17;
            this.labelArea.Text = "Площадь: ";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(538, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(227, 254);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // ListButton1
            // 
            this.ListButton1.Location = new System.Drawing.Point(447, 25);
            this.ListButton1.Name = "ListButton1";
            this.ListButton1.Size = new System.Drawing.Size(75, 23);
            this.ListButton1.TabIndex = 19;
            this.ListButton1.Text = "Список 1";
            this.ListButton1.UseVisualStyleBackColor = true;
            this.ListButton1.Click += new System.EventHandler(this.ListButton1_Click);
            // 
            // ListButton2
            // 
            this.ListButton2.Location = new System.Drawing.Point(447, 54);
            this.ListButton2.Name = "ListButton2";
            this.ListButton2.Size = new System.Drawing.Size(75, 23);
            this.ListButton2.TabIndex = 20;
            this.ListButton2.Text = "Список 2";
            this.ListButton2.UseVisualStyleBackColor = true;
            this.ListButton2.Click += new System.EventHandler(this.ListButton2_Click);
            // 
            // ListButton3
            // 
            this.ListButton3.Location = new System.Drawing.Point(447, 83);
            this.ListButton3.Name = "ListButton3";
            this.ListButton3.Size = new System.Drawing.Size(75, 23);
            this.ListButton3.TabIndex = 21;
            this.ListButton3.Text = "Список 3";
            this.ListButton3.UseVisualStyleBackColor = true;
            this.ListButton3.Click += new System.EventHandler(this.ListButton3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListButton3);
            this.Controls.Add(this.ListButton2);
            this.Controls.Add(this.ListButton1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelArea);
            this.Controls.Add(this.labelPerimeter);
            this.Controls.Add(this.labelSideBC);
            this.Controls.Add(this.labelSideAB);
            this.Controls.Add(this.labelSideCA);
            this.Controls.Add(this.labelRadius);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelSide);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.buttonTriangle);
            this.Controls.Add(this.buttonCircle);
            this.Controls.Add(this.buttonSquare);
            this.Controls.Add(this.buttonRectangle);
            this.Name = "MainForm";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRectangle;
        private System.Windows.Forms.Button buttonSquare;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button buttonTriangle;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelSide;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelRadius;
        private System.Windows.Forms.Label labelSideCA;
        private System.Windows.Forms.Label labelSideAB;
        private System.Windows.Forms.Label labelSideBC;
        private System.Windows.Forms.Label labelPerimeter;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button ListButton1;
        private System.Windows.Forms.Button ListButton2;
        private System.Windows.Forms.Button ListButton3;
    }
}

