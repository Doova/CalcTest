﻿namespace SuperCalc
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.lResult = new System.Windows.Forms.Label();
            this.cbOper = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panTwoArgs = new System.Windows.Forms.Panel();
            this.panMoreArgs = new System.Windows.Forms.Panel();
            this.tbMore = new System.Windows.Forms.RichTextBox();
            this.panTwoArgs.SuspendLayout();
            this.panMoreArgs.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "calc";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(17, 16);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(61, 20);
            this.tbX.TabIndex = 1;
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(93, 16);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(57, 20);
            this.tbY.TabIndex = 2;
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Location = new System.Drawing.Point(60, 259);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(51, 13);
            this.lResult.TabIndex = 4;
            this.lResult.Text = "fgujhgfuh";
            // 
            // cbOper
            // 
            this.cbOper.FormattingEnabled = true;
            this.cbOper.Location = new System.Drawing.Point(105, 16);
            this.cbOper.Name = "cbOper";
            this.cbOper.Size = new System.Drawing.Size(121, 21);
            this.cbOper.TabIndex = 5;
            this.cbOper.SelectedIndexChanged += new System.EventHandler(this.cbOper_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select operation";
            // 
            // panTwoArgs
            // 
            this.panTwoArgs.Controls.Add(this.tbY);
            this.panTwoArgs.Controls.Add(this.tbX);
            this.panTwoArgs.Location = new System.Drawing.Point(12, 79);
            this.panTwoArgs.Name = "panTwoArgs";
            this.panTwoArgs.Size = new System.Drawing.Size(200, 100);
            this.panTwoArgs.TabIndex = 7;
            this.panTwoArgs.Visible = false;
            // 
            // panMoreArgs
            // 
            this.panMoreArgs.Controls.Add(this.tbMore);
            this.panMoreArgs.Location = new System.Drawing.Point(233, 79);
            this.panMoreArgs.Name = "panMoreArgs";
            this.panMoreArgs.Size = new System.Drawing.Size(200, 100);
            this.panMoreArgs.TabIndex = 8;
            this.panMoreArgs.Visible = false;
            // 
            // tbMore
            // 
            this.tbMore.Location = new System.Drawing.Point(10, 12);
            this.tbMore.Name = "tbMore";
            this.tbMore.Size = new System.Drawing.Size(182, 71);
            this.tbMore.TabIndex = 0;
            this.tbMore.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 328);
            this.Controls.Add(this.panMoreArgs);
            this.Controls.Add(this.panTwoArgs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbOper);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panTwoArgs.ResumeLayout(false);
            this.panTwoArgs.PerformLayout();
            this.panMoreArgs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.ComboBox cbOper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panTwoArgs;
        private System.Windows.Forms.Panel panMoreArgs;
        private System.Windows.Forms.RichTextBox tbMore;
    }
}

