using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suspending
{
    public partial class Form1 : Form
    {
        Stopwatch stopWatch = new Stopwatch();
        TimeSpan timerSpan = TimeSpan.Zero;
        int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCount.Text))
            {
                MessageBox.Show("Input sycle count");
                return;
            }
            else
            {
                int.TryParse(textBoxCount.Text, out counter);
            }

            this.DoubleBuffered = checkBoxBuffer.Checked;

            if (checkBoxSuspend.Checked)
            {
                stopWatch.Restart();

                this.SuspendLayout();
                panelContainer.SuspendLayout();

                for (int i = 0; i < counter; i++)
                {
                    var textbox = new TextBox();
                    textbox.SuspendLayout();
                    //textbox.Dock = i% 2 ==0 ? DockStyle.Left : DockStyle.Right;
                    textbox.Dock = DockStyle.Top;
                    textbox.Top = i * 10;
                    textbox.Text = i.ToString();
                    panelContainer.Controls.Add(textbox);
                    textbox.ResumeLayout(false);
                }

                panelContainer.ResumeLayout(true);
                this.ResumeLayout(true);

                stopWatch.Stop();
                timerSpan = stopWatch.Elapsed;
                labelResult.Text = $"Elapsed time = {string.Format("{0:00}:{1:00}:{2:00}.{3:00}", timerSpan.Hours, timerSpan.Minutes, timerSpan.Seconds, timerSpan.Milliseconds / 10)}";
            }
            else
            {
                stopWatch.Restart();

                for (int i = 0; i < counter; i++)
                {
                    var textbox = new TextBox();
                    textbox.Dock = DockStyle.Top;
                    textbox.Top = i * 10;
                    textbox.Text = i.ToString();
                    panelContainer.Controls.Add(textbox);

                }
                stopWatch.Stop();
                timerSpan = stopWatch.Elapsed;
                labelResult.Text = $"Elapsed time = {string.Format("{0:00}:{1:00}:{2:00}.{3:00}", timerSpan.Hours, timerSpan.Minutes, timerSpan.Seconds, timerSpan.Milliseconds / 10)}";
            }
            listBox1.Items.Add($"Count = {counter}, Buffer = {checkBoxBuffer.Checked}, Suspending = {checkBoxSuspend.Checked}, Time = {string.Format("{0:00}:{1:00}:{2:00}.{3:00}", timerSpan.Hours, timerSpan.Minutes, timerSpan.Seconds, timerSpan.Milliseconds / 10)}");
        }

        private void ButtonClean_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void ButtonCleanPanel_Click(object sender, EventArgs e)
        {
            if (panelContainer.Controls.Count > 0)
            {
                panelContainer.Controls.Clear();
            }
        }
    }
}