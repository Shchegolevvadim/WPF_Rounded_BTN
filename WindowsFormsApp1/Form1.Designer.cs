namespace WindowsFormsApp1
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
            this.label2 = new System.Windows.Forms.Label();
            this.roundBtn1 = new WindowsFormsApp1.RoundBtn();
            this.roundBtn2 = new WindowsFormsApp1.RoundBtn();
            this.roundBtn3 = new WindowsFormsApp1.RoundBtn();
            this.roundBtn4 = new WindowsFormsApp1.RoundBtn();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Edwardian Script ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Приветсвуем вас в нашем ресторане";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 368);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 2;
            // 
            // roundBtn1
            // 
            this.roundBtn1.BackColor = System.Drawing.Color.OrangeRed;
            this.roundBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundBtn1.Location = new System.Drawing.Point(116, 112);
            this.roundBtn1.Name = "roundBtn1";
            this.roundBtn1.Radius = 45;
            this.roundBtn1.Size = new System.Drawing.Size(248, 68);
            this.roundBtn1.TabIndex = 3;
            this.roundBtn1.Text = "Завтраки (с 7 до 11 часов)";
            this.roundBtn1.Click += new System.EventHandler(this.roundBtn1_Click_1);
            // 
            // roundBtn2
            // 
            this.roundBtn2.BackColor = System.Drawing.Color.OrangeRed;
            this.roundBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundBtn2.Location = new System.Drawing.Point(414, 114);
            this.roundBtn2.Name = "roundBtn2";
            this.roundBtn2.Radius = 45;
            this.roundBtn2.Size = new System.Drawing.Size(281, 65);
            this.roundBtn2.TabIndex = 4;
            this.roundBtn2.Text = "Обеды (с 12 до 16 часов)";
            this.roundBtn2.Click += new System.EventHandler(this.roundBtn2_Click);
            // 
            // roundBtn3
            // 
            this.roundBtn3.BackColor = System.Drawing.Color.OrangeRed;
            this.roundBtn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundBtn3.Location = new System.Drawing.Point(116, 220);
            this.roundBtn3.Name = "roundBtn3";
            this.roundBtn3.Radius = 45;
            this.roundBtn3.Size = new System.Drawing.Size(248, 72);
            this.roundBtn3.TabIndex = 5;
            this.roundBtn3.Text = "Ужины (с 18 до 22 часов)";
            this.roundBtn3.Click += new System.EventHandler(this.roundBtn3_Click);
            // 
            // roundBtn4
            // 
            this.roundBtn4.BackColor = System.Drawing.Color.OrangeRed;
            this.roundBtn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundBtn4.Location = new System.Drawing.Point(413, 226);
            this.roundBtn4.Name = "roundBtn4";
            this.roundBtn4.Radius = 45;
            this.roundBtn4.Size = new System.Drawing.Size(281, 65);
            this.roundBtn4.TabIndex = 6;
            this.roundBtn4.Text = "Чай, кофе, легкие закуски";
            this.roundBtn4.Click += new System.EventHandler(this.roundBtn4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roundBtn4);
            this.Controls.Add(this.roundBtn3);
            this.Controls.Add(this.roundBtn2);
            this.Controls.Add(this.roundBtn1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private RoundBtn roundBtn1;
        private RoundBtn roundBtn2;
        private RoundBtn roundBtn3;
        private RoundBtn roundBtn4;
    }
}

