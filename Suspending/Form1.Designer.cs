namespace Suspending
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.buttonCleanPanel = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBoxSuspend = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.checkBoxBuffer = new System.Windows.Forms.CheckBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Dock = System.Windows.Forms.DockStyle.Right;
            this.button.Location = new System.Drawing.Point(708, 0);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(221, 63);
            this.button.TabIndex = 0;
            this.button.Text = "Start";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.buttonCleanPanel);
            this.panel.Controls.Add(this.buttonClean);
            this.panel.Controls.Add(this.listBox1);
            this.panel.Controls.Add(this.checkBoxSuspend);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.textBoxCount);
            this.panel.Controls.Add(this.labelResult);
            this.panel.Controls.Add(this.checkBoxBuffer);
            this.panel.Controls.Add(this.button);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(929, 63);
            this.panel.TabIndex = 1;
            // 
            // buttonCleanPanel
            // 
            this.buttonCleanPanel.BackColor = System.Drawing.Color.SeaShell;
            this.buttonCleanPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCleanPanel.Location = new System.Drawing.Point(901, 40);
            this.buttonCleanPanel.Name = "buttonCleanPanel";
            this.buttonCleanPanel.Size = new System.Drawing.Size(28, 23);
            this.buttonCleanPanel.TabIndex = 8;
            this.buttonCleanPanel.Text = "C";
            this.buttonCleanPanel.UseVisualStyleBackColor = false;
            this.buttonCleanPanel.Click += new System.EventHandler(this.ButtonCleanPanel_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.BackColor = System.Drawing.Color.SeaShell;
            this.buttonClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClean.Location = new System.Drawing.Point(415, -1);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(28, 23);
            this.buttonClean.TabIndex = 7;
            this.buttonClean.Text = "C";
            this.buttonClean.UseVisualStyleBackColor = false;
            this.buttonClean.Click += new System.EventHandler(this.ButtonClean_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(409, 63);
            this.listBox1.TabIndex = 6;
            // 
            // checkBoxSuspend
            // 
            this.checkBoxSuspend.AutoSize = true;
            this.checkBoxSuspend.Location = new System.Drawing.Point(450, 36);
            this.checkBoxSuspend.Name = "checkBoxSuspend";
            this.checkBoxSuspend.Size = new System.Drawing.Size(102, 17);
            this.checkBoxSuspend.TabIndex = 5;
            this.checkBoxSuspend.Text = "Use suspending";
            this.checkBoxSuspend.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Count";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(602, 6);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(100, 20);
            this.textBoxCount.TabIndex = 3;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(559, 37);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(37, 13);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "Result";
            // 
            // checkBoxBuffer
            // 
            this.checkBoxBuffer.AutoSize = true;
            this.checkBoxBuffer.Location = new System.Drawing.Point(450, 8);
            this.checkBoxBuffer.Name = "checkBoxBuffer";
            this.checkBoxBuffer.Size = new System.Drawing.Size(102, 17);
            this.checkBoxBuffer.TabIndex = 1;
            this.checkBoxBuffer.Text = "Double buffered";
            this.checkBoxBuffer.UseVisualStyleBackColor = true;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 63);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(929, 536);
            this.panelContainer.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(929, 599);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.CheckBox checkBoxBuffer;
        private System.Windows.Forms.CheckBox checkBoxSuspend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonCleanPanel;
    }
}

