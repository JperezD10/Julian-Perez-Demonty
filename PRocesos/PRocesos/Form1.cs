using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PRocesos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Process p in Process.GetProcesses())
            {
                listBox1.Items.Add(p);

            }
            listBox1.DisplayMember = "ProcessName";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
            Process p = (Process)listBox1.SelectedItem;

            p.Kill();
                MessageBox.Show("eliminado:"+ p.ProcessName);
            }
            catch
            {

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox2.Text))
            { 
                Process.Start(textBox1.Text);
            }
            else
            {
                Process.Start(textBox1.Text, textBox2.Text);

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            Process p = (Process)listBox1.SelectedItem;

            label1.Text = p.ProcessName;
            label2.Text = p.TotalProcessorTime.ToString();
            label3.Text = p.StartTime.ToString();
            label4.Text = p.MainWindowTitle;
            }
           catch
            {

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
