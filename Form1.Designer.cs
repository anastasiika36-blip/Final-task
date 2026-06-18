namespace BullsAndCows
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.textBoxGuess = new System.Windows.Forms.TextBox();
            this.numericUpDownDigits = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripAttempts = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelBulls = new System.Windows.Forms.Label();
            this.labelCows = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDigits)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Угадайте задуманное компьютером число.";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(41, 297);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(87, 40);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // textBoxGuess
            // 
            this.textBoxGuess.Location = new System.Drawing.Point(12, 126);
            this.textBoxGuess.MaxLength = 6;
            this.textBoxGuess.Name = "textBoxGuess";
            this.textBoxGuess.Size = new System.Drawing.Size(100, 22);
            this.textBoxGuess.TabIndex = 2;
            // 
            // numericUpDownDigits
            // 
            this.numericUpDownDigits.Location = new System.Drawing.Point(12, 70);
            this.numericUpDownDigits.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownDigits.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownDigits.Name = "numericUpDownDigits";
            this.numericUpDownDigits.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownDigits.TabIndex = 3;
            this.numericUpDownDigits.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAttempts,
            this.toolStripTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(318, 26);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripAttempts
            // 
            this.toolStripAttempts.Name = "toolStripAttempts";
            this.toolStripAttempts.Size = new System.Drawing.Size(86, 20);
            this.toolStripAttempts.Text = "Попыток: 0";
            // 
            // toolStripTime
            // 
            this.toolStripTime.Name = "toolStripTime";
            this.toolStripTime.Size = new System.Drawing.Size(192, 20);
            this.toolStripTime.Text = "Затрачено времени: 0 сек.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Число знаков:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Число:";
            // 
            // labelBulls
            // 
            this.labelBulls.AutoSize = true;
            this.labelBulls.Location = new System.Drawing.Point(15, 193);
            this.labelBulls.Name = "labelBulls";
            this.labelBulls.Size = new System.Drawing.Size(113, 16);
            this.labelBulls.TabIndex = 7;
            this.labelBulls.Text = "Угадано цифр: 0";
            // 
            // labelCows
            // 
            this.labelCows.AutoSize = true;
            this.labelCows.Location = new System.Drawing.Point(15, 225);
            this.labelCows.Name = "labelCows";
            this.labelCows.Size = new System.Drawing.Size(170, 16);
            this.labelCows.TabIndex = 8;
            this.labelCows.Text = "Из них на своих местах: 0";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(186, 297);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(87, 40);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Завершить";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 450);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.labelCows);
            this.Controls.Add(this.labelBulls);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.numericUpDownDigits);
            this.Controls.Add(this.textBoxGuess);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "УГАДАЙ ЧИСЛО";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDigits)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox textBoxGuess;
        private System.Windows.Forms.NumericUpDown numericUpDownDigits;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelBulls;
        private System.Windows.Forms.Label labelCows;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ToolStripStatusLabel toolStripAttempts;
        private System.Windows.Forms.ToolStripStatusLabel toolStripTime;
    }
}

