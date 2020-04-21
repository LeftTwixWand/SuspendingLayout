namespace Suspending
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonStart = new System.Windows.Forms.Button();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.buttonCleanItems = new System.Windows.Forms.Button();
            this.buttonCleanLogs = new System.Windows.Forms.Button();
            this.checkBoxSuspend = new System.Windows.Forms.CheckBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.checkBoxBuffer = new System.Windows.Forms.CheckBox();
            this.panelParameters = new System.Windows.Forms.Panel();
            this.listBoxLogs = new System.Windows.Forms.ListBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.tableLayoutPanelHeader = new System.Windows.Forms.TableLayoutPanel();
            this.panelButtons = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            this.panelParameters.SuspendLayout();
            this.tableLayoutPanelHeader.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.BackColor = System.Drawing.Color.LightCoral;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(7, 29);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(199, 33);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDownCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numericUpDownCount.Location = new System.Drawing.Point(207, 5);
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownCount.TabIndex = 9;
            this.numericUpDownCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonCleanItems
            // 
            this.buttonCleanItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCleanItems.BackColor = System.Drawing.Color.SeaShell;
            this.buttonCleanItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCleanItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonCleanItems.Location = new System.Drawing.Point(106, 0);
            this.buttonCleanItems.Name = "buttonCleanItems";
            this.buttonCleanItems.Size = new System.Drawing.Size(100, 30);
            this.buttonCleanItems.TabIndex = 8;
            this.buttonCleanItems.Text = "Clean items";
            this.buttonCleanItems.UseVisualStyleBackColor = false;
            this.buttonCleanItems.Click += new System.EventHandler(this.ButtonCleanItems_Click);
            // 
            // buttonCleanLogs
            // 
            this.buttonCleanLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCleanLogs.BackColor = System.Drawing.Color.SeaShell;
            this.buttonCleanLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCleanLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonCleanLogs.Location = new System.Drawing.Point(7, 0);
            this.buttonCleanLogs.Name = "buttonCleanLogs";
            this.buttonCleanLogs.Size = new System.Drawing.Size(100, 30);
            this.buttonCleanLogs.TabIndex = 7;
            this.buttonCleanLogs.Text = "Clean logs";
            this.buttonCleanLogs.UseVisualStyleBackColor = false;
            this.buttonCleanLogs.Click += new System.EventHandler(this.ButtonCleanLogs_Click);
            // 
            // checkBoxSuspend
            // 
            this.checkBoxSuspend.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBoxSuspend.AutoSize = true;
            this.checkBoxSuspend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxSuspend.Location = new System.Drawing.Point(19, 33);
            this.checkBoxSuspend.Name = "checkBoxSuspend";
            this.checkBoxSuspend.Size = new System.Drawing.Size(129, 21);
            this.checkBoxSuspend.TabIndex = 5;
            this.checkBoxSuspend.Text = "Use suspending";
            this.checkBoxSuspend.UseVisualStyleBackColor = true;
            // 
            // labelCount
            // 
            this.labelCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelCount.Location = new System.Drawing.Point(161, 7);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(45, 17);
            this.labelCount.TabIndex = 4;
            this.labelCount.Text = "Count";
            // 
            // labelResult
            // 
            this.labelResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelResult.Location = new System.Drawing.Point(161, 34);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(89, 17);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "Elapsed time";
            // 
            // checkBoxBuffer
            // 
            this.checkBoxBuffer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBoxBuffer.AutoSize = true;
            this.checkBoxBuffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxBuffer.Location = new System.Drawing.Point(19, 6);
            this.checkBoxBuffer.Name = "checkBoxBuffer";
            this.checkBoxBuffer.Size = new System.Drawing.Size(129, 21);
            this.checkBoxBuffer.TabIndex = 1;
            this.checkBoxBuffer.Text = "Double buffered";
            this.checkBoxBuffer.UseVisualStyleBackColor = true;
            // 
            // panelParameters
            // 
            this.panelParameters.BackColor = System.Drawing.Color.MistyRose;
            this.panelParameters.Controls.Add(this.numericUpDownCount);
            this.panelParameters.Controls.Add(this.checkBoxBuffer);
            this.panelParameters.Controls.Add(this.labelResult);
            this.panelParameters.Controls.Add(this.labelCount);
            this.panelParameters.Controls.Add(this.checkBoxSuspend);
            this.panelParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelParameters.Location = new System.Drawing.Point(354, 3);
            this.panelParameters.Name = "panelParameters";
            this.panelParameters.Size = new System.Drawing.Size(345, 57);
            this.panelParameters.TabIndex = 4;
            // 
            // listBoxLogs
            // 
            this.listBoxLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxLogs.FormattingEnabled = true;
            this.listBoxLogs.Location = new System.Drawing.Point(3, 3);
            this.listBoxLogs.Name = "listBoxLogs";
            this.listBoxLogs.Size = new System.Drawing.Size(345, 57);
            this.listBoxLogs.TabIndex = 1;
            // 
            // panelContainer
            // 
            this.panelContainer.AutoScroll = true;
            this.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 63);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(909, 525);
            this.panelContainer.TabIndex = 3;
            // 
            // tableLayoutPanelHeader
            // 
            this.tableLayoutPanelHeader.BackColor = System.Drawing.Color.MistyRose;
            this.tableLayoutPanelHeader.ColumnCount = 3;
            this.tableLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 207F));
            this.tableLayoutPanelHeader.Controls.Add(this.panelButtons, 2, 0);
            this.tableLayoutPanelHeader.Controls.Add(this.listBoxLogs, 0, 0);
            this.tableLayoutPanelHeader.Controls.Add(this.panelParameters, 1, 0);
            this.tableLayoutPanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelHeader.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelHeader.Name = "tableLayoutPanelHeader";
            this.tableLayoutPanelHeader.RowCount = 1;
            this.tableLayoutPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHeader.Size = new System.Drawing.Size(909, 63);
            this.tableLayoutPanelHeader.TabIndex = 5;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.MistyRose;
            this.panelButtons.Controls.Add(this.buttonCleanItems);
            this.panelButtons.Controls.Add(this.buttonCleanLogs);
            this.panelButtons.Controls.Add(this.buttonStart);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.Location = new System.Drawing.Point(702, 0);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(207, 63);
            this.panelButtons.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 588);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.tableLayoutPanelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Suspending test";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            this.panelParameters.ResumeLayout(false);
            this.panelParameters.PerformLayout();
            this.tableLayoutPanelHeader.ResumeLayout(false);
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.CheckBox checkBoxBuffer;
        private System.Windows.Forms.CheckBox checkBoxSuspend;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonCleanLogs;
        private System.Windows.Forms.Button buttonCleanItems;
        private System.Windows.Forms.NumericUpDown numericUpDownCount;
        private System.Windows.Forms.Panel panelParameters;
        private System.Windows.Forms.ListBox listBoxLogs;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHeader;
        private System.Windows.Forms.Panel panelButtons;
    }
}

