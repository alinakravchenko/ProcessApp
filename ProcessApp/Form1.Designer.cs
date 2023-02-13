using System.Windows.Forms;

namespace ProcessApp
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_startTime = new System.Windows.Forms.Label();
            this.label_processorTime = new System.Windows.Forms.Label();
            this.label_threadCount = new System.Windows.Forms.Label();
            this.label_copyProcess = new System.Windows.Forms.Label();
            this.btn_closeProcess = new System.Windows.Forms.Button();
            this.new_processStart = new System.Windows.Forms.TextBox();
            this.btn_newProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(10, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(274, 342);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "1200";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Информация о процессе:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Process ID:";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(371, 50);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(0, 13);
            this.label_id.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Start time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(291, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ProcessorTime:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ThreadCount:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Process copy:";
            // 
            // label_startTime
            // 
            this.label_startTime.AutoSize = true;
            this.label_startTime.Location = new System.Drawing.Point(371, 76);
            this.label_startTime.Name = "label_startTime";
            this.label_startTime.Size = new System.Drawing.Size(0, 13);
            this.label_startTime.TabIndex = 10;
            // 
            // label_processorTime
            // 
            this.label_processorTime.AutoSize = true;
            this.label_processorTime.Location = new System.Drawing.Point(371, 105);
            this.label_processorTime.Name = "label_processorTime";
            this.label_processorTime.Size = new System.Drawing.Size(0, 13);
            this.label_processorTime.TabIndex = 11;
            // 
            // label_threadCount
            // 
            this.label_threadCount.AutoSize = true;
            this.label_threadCount.Location = new System.Drawing.Point(371, 132);
            this.label_threadCount.Name = "label_threadCount";
            this.label_threadCount.Size = new System.Drawing.Size(0, 13);
            this.label_threadCount.TabIndex = 12;
            // 
            // label_copyProcess
            // 
            this.label_copyProcess.AutoSize = true;
            this.label_copyProcess.Location = new System.Drawing.Point(371, 159);
            this.label_copyProcess.Name = "label_copyProcess";
            this.label_copyProcess.Size = new System.Drawing.Size(0, 13);
            this.label_copyProcess.TabIndex = 13;
            // 
            // btn_closeProcess
            // 
            this.btn_closeProcess.Location = new System.Drawing.Point(374, 175);
            this.btn_closeProcess.Name = "btn_closeProcess";
            this.btn_closeProcess.Size = new System.Drawing.Size(75, 23);
            this.btn_closeProcess.TabIndex = 14;
            this.btn_closeProcess.Text = "close";
            this.btn_closeProcess.UseVisualStyleBackColor = true;
            this.btn_closeProcess.Click += new System.EventHandler(this.btn_closeProcess_Click);
            // 
            // new_processStart
            // 
            this.new_processStart.Location = new System.Drawing.Point(294, 215);
            this.new_processStart.Name = "new_processStart";
            this.new_processStart.Size = new System.Drawing.Size(251, 20);
            this.new_processStart.TabIndex = 15;
            this.new_processStart.TextChanged += new System.EventHandler(this.new_processStart_TextChanged);
            // 
            // btn_newProcess
            // 
            this.btn_newProcess.Enabled = false;
            this.btn_newProcess.Location = new System.Drawing.Point(325, 250);
            this.btn_newProcess.Name = "btn_newProcess";
            this.btn_newProcess.Size = new System.Drawing.Size(171, 23);
            this.btn_newProcess.TabIndex = 16;
            this.btn_newProcess.Text = "Запустить новый процесс";
            this.btn_newProcess.UseVisualStyleBackColor = true;
            this.btn_newProcess.Click += new System.EventHandler(this.btn_newProcess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 390);
            this.Controls.Add(this.btn_newProcess);
            this.Controls.Add(this.new_processStart);
            this.Controls.Add(this.btn_closeProcess);
            this.Controls.Add(this.label_copyProcess);
            this.Controls.Add(this.label_threadCount);
            this.Controls.Add(this.label_processorTime);
            this.Controls.Add(this.label_startTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label_id;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label_startTime;
        private Label label_processorTime;
        private Label label_threadCount;
        private Label label_copyProcess;
        private Button btn_closeProcess;
        private TextBox new_processStart;
        private Button btn_newProcess;
    }
}

