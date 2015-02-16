namespace SerialMonitor
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
            this.comComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialTextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.serialMessageBox = new System.Windows.Forms.TextBox();
            this.sendCmdButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comComboBox
            // 
            this.comComboBox.FormattingEnabled = true;
            this.comComboBox.Location = new System.Drawing.Point(124, 26);
            this.comComboBox.Name = "comComboBox";
            this.comComboBox.Size = new System.Drawing.Size(121, 21);
            this.comComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM Port";
            // 
            // serialTextBox
            // 
            this.serialTextBox.AcceptsReturn = true;
            this.serialTextBox.AcceptsTab = true;
            this.serialTextBox.Location = new System.Drawing.Point(45, 146);
            this.serialTextBox.MaxLength = 20000;
            this.serialTextBox.Multiline = true;
            this.serialTextBox.Name = "serialTextBox";
            this.serialTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.serialTextBox.Size = new System.Drawing.Size(419, 296);
            this.serialTextBox.TabIndex = 2;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(279, 24);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 3;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(360, 24);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // serialMessageBox
            // 
            this.serialMessageBox.Location = new System.Drawing.Point(45, 94);
            this.serialMessageBox.Name = "serialMessageBox";
            this.serialMessageBox.Size = new System.Drawing.Size(200, 20);
            this.serialMessageBox.TabIndex = 5;
            // 
            // sendCmdButton
            // 
            this.sendCmdButton.Location = new System.Drawing.Point(279, 91);
            this.sendCmdButton.Name = "sendCmdButton";
            this.sendCmdButton.Size = new System.Drawing.Size(75, 23);
            this.sendCmdButton.TabIndex = 6;
            this.sendCmdButton.Text = "Send";
            this.sendCmdButton.UseVisualStyleBackColor = true;
            this.sendCmdButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(360, 91);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 454);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.sendCmdButton);
            this.Controls.Add(this.serialMessageBox);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.serialTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serialTextBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.TextBox serialMessageBox;
        private System.Windows.Forms.Button sendCmdButton;
        private System.Windows.Forms.Button clearButton;
    }
}

