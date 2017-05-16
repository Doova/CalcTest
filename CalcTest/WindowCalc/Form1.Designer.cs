namespace WindowCalc
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
            this.TBx = new System.Windows.Forms.TextBox();
            this.TBy = new System.Windows.Forms.TextBox();
            this.CBoper = new System.Windows.Forms.ComboBox();
            this.Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calc";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TBx
            // 
            this.TBx.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBx.Location = new System.Drawing.Point(12, 35);
            this.TBx.Name = "TBx";
            this.TBx.Size = new System.Drawing.Size(100, 21);
            this.TBx.TabIndex = 1;
            // 
            // TBy
            // 
            this.TBy.Location = new System.Drawing.Point(133, 36);
            this.TBy.Name = "TBy";
            this.TBy.Size = new System.Drawing.Size(100, 20);
            this.TBy.TabIndex = 2;
            // 
            // CBoper
            // 
            this.CBoper.FormattingEnabled = true;
            this.CBoper.Location = new System.Drawing.Point(300, 34);
            this.CBoper.Name = "CBoper";
            this.CBoper.Size = new System.Drawing.Size(121, 21);
            this.CBoper.TabIndex = 5;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(13, 72);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(0, 13);
            this.Result.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 218);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.CBoper);
            this.Controls.Add(this.TBy);
            this.Controls.Add(this.TBx);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TBx;
        private System.Windows.Forms.TextBox TBy;
        private System.Windows.Forms.ComboBox CBoper;
        private System.Windows.Forms.Label Result;
    }
}

