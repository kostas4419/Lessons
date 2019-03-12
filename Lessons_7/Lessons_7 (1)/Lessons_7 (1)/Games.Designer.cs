namespace Lessons_7
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
            this.btnComand1 = new System.Windows.Forms.Button();
            this.btnComand2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnStepBack = new System.Windows.Forms.Button();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblInfo3 = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnComand1
            // 
            this.btnComand1.Location = new System.Drawing.Point(310, 97);
            this.btnComand1.Name = "btnComand1";
            this.btnComand1.Size = new System.Drawing.Size(75, 23);
            this.btnComand1.TabIndex = 0;
            this.btnComand1.Text = "+1";
            this.btnComand1.UseVisualStyleBackColor = true;
            this.btnComand1.Click += new System.EventHandler(this.btnComand1_Click);
            // 
            // btnComand2
            // 
            this.btnComand2.Location = new System.Drawing.Point(310, 138);
            this.btnComand2.Name = "btnComand2";
            this.btnComand2.Size = new System.Drawing.Size(75, 23);
            this.btnComand2.TabIndex = 1;
            this.btnComand2.Text = "х2";
            this.btnComand2.UseVisualStyleBackColor = true;
            this.btnComand2.Click += new System.EventHandler(this.btnComand2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(310, 211);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumber.Location = new System.Drawing.Point(205, 118);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(15, 16);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(46, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Результат";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(46, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Количество операций";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCount.Location = new System.Drawing.Point(205, 148);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(15, 16);
            this.lblCount.TabIndex = 6;
            this.lblCount.Text = "0";
            this.lblCount.UseMnemonic = false;
            // 
            // btnStepBack
            // 
            this.btnStepBack.Location = new System.Drawing.Point(310, 182);
            this.btnStepBack.Name = "btnStepBack";
            this.btnStepBack.Size = new System.Drawing.Size(75, 23);
            this.btnStepBack.TabIndex = 7;
            this.btnStepBack.Text = "Шаг назад";
            this.btnStepBack.UseVisualStyleBackColor = true;
            this.btnStepBack.Click += new System.EventHandler(this.btnStepBack_Click);
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo1.Location = new System.Drawing.Point(45, 35);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(121, 18);
            this.lblInfo1.TabIndex = 8;
            this.lblInfo1.Text = "Получите число";
            // 
            // lblInfo3
            // 
            this.lblInfo3.AutoSize = true;
            this.lblInfo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo3.Location = new System.Drawing.Point(168, 35);
            this.lblInfo3.Name = "lblInfo3";
            this.lblInfo3.Size = new System.Drawing.Size(24, 18);
            this.lblInfo3.TabIndex = 9;
            this.lblInfo3.Text = "10";
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo2.Location = new System.Drawing.Point(204, 34);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(256, 18);
            this.lblInfo2.TabIndex = 10;
            this.lblInfo2.Text = "за минимальное количество ходов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 266);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.lblInfo3);
            this.Controls.Add(this.lblInfo1);
            this.Controls.Add(this.btnStepBack);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnComand2);
            this.Controls.Add(this.btnComand1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Games";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComand1;
        private System.Windows.Forms.Button btnComand2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnStepBack;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblInfo3;
        private System.Windows.Forms.Label lblInfo2;
    }
}

