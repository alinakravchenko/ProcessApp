using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Linq;

namespace ProcessApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        Process killProcess = new Process();
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateProcessList();
        }

        public void UpdateProcessList()
        {
            Process[] processes = Process.GetProcesses();
            listBox1.Items.Clear();
            foreach (Process process in processes)
            {
                listBox1.Items.Add(process.ProcessName);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateProcessList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = Int32.Parse(textBox1.Text) * 1000;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int orderNumber = 0;
                int counter = 0;
                //в object передаём каждый элемент списка
                foreach (object obj in listBox1.Items)
                {
                    //сравниваем элемент списка с номером элемента
                    //имя объекта = выбранному элементу объекта
                    if ((string)obj == listBox1.Items[listBox1.SelectedIndex].ToString())
                    {
                    if (counter == listBox1.SelectedIndex)
                    {
                        break;
                    }
                        //увеличиваем
                        orderNumber++;
                    }
                    //идёт "в ногу" с индексом
                    counter++;

                }
                Process[] processesByName = Process.GetProcessesByName(listBox1.Items[listBox1.SelectedIndex].ToString());
                if (processesByName.Length > 0)
                {
                    killProcess = processesByName[0];
                    label_id.Text = processesByName[0].Id.ToString();
                    label_startTime.Text = processesByName[0].StartTime.ToString("H:m:s:fff");
                    label_processorTime.Text = processesByName[0].TotalProcessorTime.ToString();
                    label_threadCount.Text = processesByName[0].Threads.Count.ToString();
                    label_copyProcess.Text = processesByName.Count().ToString();

                }
                //проверяет hash код
                //foreach (Process process in processesByName)
                //{
                //    MessageBox.Show(process.GetHashCode().ToString());
                //}
               
            }
        }

        private void btn_closeProcess_Click(object sender, EventArgs e)
        {
            killProcess.Close();
        }

        private void new_processStart_TextChanged(object sender, EventArgs e)
        {
            if (new_processStart.Text.Length > 0)
            {
               btn_newProcess.Enabled = true;
            }
            else
            {
                btn_newProcess.Enabled = false;
            }
        }

        private void btn_newProcess_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo(new_processStart.Text);
            process.Start();
        }
    }
}

