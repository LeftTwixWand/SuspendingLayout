using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Suspending
{
    /// <summary>
    /// MainForm class
    /// </summary>
    public partial class FormMain : Form
    {
        /// <summary>
        /// Timer.
        /// </summary>
        private readonly Stopwatch stopWatch = new Stopwatch();

        /// <summary>
        /// Result time.
        /// </summary>
        private TimeSpan timerSpan = TimeSpan.Zero;

        /// <summary>
        /// Сycle times.
        /// </summary>
        private int counter = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormMain"/> class.
        /// </summary>
        public FormMain()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Start button click event
        /// </summary>
        /// <param name="sender">Sender - button</param>
        /// <param name="e">Click event arguments</param>
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (numericUpDownCount.Value < 1) // If the cycle will be executed less than 1 time
            {
                MessageBox.Show("Input correct value");
                return; // Exit from function
            }
            else
            {
                counter = Convert.ToInt32(numericUpDownCount.Value); // Parse value
            }

            this.DoubleBuffered = checkBoxBuffer.Checked; // Set form double buffered value

            if (checkBoxSuspend.Checked) // Use suspen layout
            {
                stopWatch.Restart(); // Restart timer

                this.SuspendLayout(); // Suspend form layout
                panelContainer.SuspendLayout(); // Suspend panel container layout

                for (int i = 0; i < counter; i++) // In cycle add items into panelContainer  
                {
                    TextBox textbox = new TextBox(); // Create object
                    textbox.SuspendLayout(); // Suspend object layout
                    textbox.Dock = DockStyle.Top; // Set properties
                    textbox.Text = $"Number: {i}";
                    panelContainer.Controls.Add(textbox); // Add an object to the control collection
                    textbox.ResumeLayout(false); // Resume layout with false parameter. This means, that control will not be redrawn.
                }

                panelContainer.ResumeLayout(true); // Resume panleContainer layout with true parameter. This means that control and children will be redrawn.
                this.ResumeLayout(true); // Resume form layout

                stopWatch.Stop(); // Stop timer
                timerSpan = stopWatch.Elapsed; // Get result

                // Show result
                labelResult.Text = $"Elapsed time = {timerSpan.Hours}:{timerSpan.Minutes}:{timerSpan.Seconds}.{timerSpan.Milliseconds / 10 }";
            }
            else // Don't use suspend layout
            {
                stopWatch.Restart(); // Use suspen layout

                for (int i = 0; i < counter; i++) // In cycle add items into panelContainer  
                {
                    var textbox = new TextBox
                    {
                        Dock = DockStyle.Top,
                        Text = $"Number: {i}"
                    };

                    panelContainer.Controls.Add(textbox);
                }

                stopWatch.Stop(); // Stop timer
                timerSpan = stopWatch.Elapsed; // Get result

                // Show result
                labelResult.Text = $"Elapsed time = {timerSpan.Hours}:{timerSpan.Minutes}:{timerSpan.Seconds}.{timerSpan.Milliseconds / 10 }";
            }

            // Add information to logs
            listBoxLogs.Items.Add($"Count = {counter}, Buffer = {checkBoxBuffer.Checked}, Suspending = {checkBoxSuspend.Checked}, Time = {timerSpan.Hours}:{timerSpan.Minutes}:{timerSpan.Seconds}.{timerSpan.Milliseconds / 10 }");
        }

        /// <summary>
        /// Button clean logs click event 
        /// </summary>
        /// <param name="sender">Sender - button</param>
        /// <param name="e">Click event arguments</param>
        private void ButtonCleanLogs_Click(object sender, EventArgs e)
        {
            listBoxLogs.Items.Clear(); // Clean item from listBoxLogs
        }

        /// <summary>
        /// Button clean items click event 
        /// </summary>
        /// <param name="sender">Sender - button</param>
        /// <param name="e">Click event arguments</param>
        private void ButtonCleanItems_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear(); // Clean all items from panelContainer
        }

    }
}