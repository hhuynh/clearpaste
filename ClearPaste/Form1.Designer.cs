namespace ClearPaste
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.hideButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.timeoutInput = new System.Windows.Forms.NumericUpDown();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.autoStartCheckbox = new System.Windows.Forms.CheckBox();
            this.copyLastPasteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.timeoutInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text buffer timeout (minutes)";
            // 
            // hideButton
            // 
            this.hideButton.Location = new System.Drawing.Point(39, 59);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(75, 23);
            this.hideButton.TabIndex = 2;
            this.hideButton.Text = "Hide";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(148, 59);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // timeoutInput
            // 
            this.timeoutInput.Location = new System.Drawing.Point(158, 18);
            this.timeoutInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeoutInput.Name = "timeoutInput";
            this.timeoutInput.Size = new System.Drawing.Size(44, 20);
            this.timeoutInput.TabIndex = 1;
            this.timeoutInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeoutInput.ValueChanged += new System.EventHandler(this.timeoutInput_ValueChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "ClearPaste";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "ClearPaste";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // autoStartCheckbox
            // 
            this.autoStartCheckbox.AutoSize = true;
            this.autoStartCheckbox.Location = new System.Drawing.Point(12, 99);
            this.autoStartCheckbox.Name = "autoStartCheckbox";
            this.autoStartCheckbox.Size = new System.Drawing.Size(197, 17);
            this.autoStartCheckbox.TabIndex = 4;
            this.autoStartCheckbox.Text = "start ClearPaste on Windows startup";
            this.autoStartCheckbox.UseVisualStyleBackColor = true;
            this.autoStartCheckbox.CheckedChanged += new System.EventHandler(this.autoStartCheckbox_CheckedChanged);
            // 
            // copyLastPasteButton
            // 
            this.copyLastPasteButton.Location = new System.Drawing.Point(80, 122);
            this.copyLastPasteButton.Name = "copyLastPasteButton";
            this.copyLastPasteButton.Size = new System.Drawing.Size(100, 23);
            this.copyLastPasteButton.TabIndex = 5;
            this.copyLastPasteButton.Text = "Copy last paste";
            this.copyLastPasteButton.UseVisualStyleBackColor = true;
            this.copyLastPasteButton.Click += new System.EventHandler(this.copyLastPasteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 157);
            this.Controls.Add(this.copyLastPasteButton);
            this.Controls.Add(this.autoStartCheckbox);
            this.Controls.Add(this.timeoutInput);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClearPaste by Hung Huynh";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timeoutInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.NumericUpDown timeoutInput;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox autoStartCheckbox;
        private System.Windows.Forms.Button copyLastPasteButton;
    }
}

