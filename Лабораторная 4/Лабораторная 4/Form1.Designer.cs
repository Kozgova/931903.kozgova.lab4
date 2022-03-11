
namespace Лабораторная_4
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.edRule = new System.Windows.Forms.NumericUpDown();
            this.btStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.edRule)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Правило";
            // 
            // edRule
            // 
            this.edRule.Location = new System.Drawing.Point(188, 199);
            this.edRule.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.edRule.Name = "edRule";
            this.edRule.Size = new System.Drawing.Size(120, 22);
            this.edRule.TabIndex = 1;
            this.edRule.Value = new decimal(new int[] {
            110,
            0,
            0,
            0});
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(91, 268);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(181, 106);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "старт / стоп";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(357, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 472);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 626);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.edRule);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.edRule)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown edRule;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}

