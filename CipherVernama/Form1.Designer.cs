namespace CipherVernama
{
    partial class Form1
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
            this.CipherButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.KeyInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CipheredOutput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.KeyOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CipherButton
            // 
            this.CipherButton.Location = new System.Drawing.Point(414, 188);
            this.CipherButton.Name = "CipherButton";
            this.CipherButton.Size = new System.Drawing.Size(114, 38);
            this.CipherButton.TabIndex = 0;
            this.CipherButton.Text = "Зашифровать";
            this.CipherButton.UseVisualStyleBackColor = true;
            this.CipherButton.Click += new System.EventHandler(this.CipherButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(231, 188);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(108, 38);
            this.ClearButton.TabIndex = 1;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(256, 90);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(272, 22);
            this.Input.TabIndex = 2;
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(256, 270);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(272, 22);
            this.Output.TabIndex = 3;
            // 
            // KeyInput
            // 
            this.KeyInput.Location = new System.Drawing.Point(256, 135);
            this.KeyInput.Name = "KeyInput";
            this.KeyInput.Size = new System.Drawing.Size(272, 22);
            this.KeyInput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Текст";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ключ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Текст в двоичной форме";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Зашифрованный текст";
            // 
            // CipheredOutput
            // 
            this.CipheredOutput.Location = new System.Drawing.Point(256, 368);
            this.CipheredOutput.Name = "CipheredOutput";
            this.CipheredOutput.Size = new System.Drawing.Size(272, 22);
            this.CipheredOutput.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(153, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ключ";
            // 
            // KeyOutput
            // 
            this.KeyOutput.Enabled = false;
            this.KeyOutput.Location = new System.Drawing.Point(256, 316);
            this.KeyOutput.Name = "KeyOutput";
            this.KeyOutput.Size = new System.Drawing.Size(272, 22);
            this.KeyOutput.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.KeyOutput);
            this.Controls.Add(this.CipheredOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KeyInput);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CipherButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CipherButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.TextBox Output;
        private System.Windows.Forms.TextBox KeyInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CipheredOutput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox KeyOutput;
    }
}

