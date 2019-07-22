namespace New_Perspectives
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
            this.aWelcomeLabel = new System.Windows.Forms.Label();
            this.aMaximiseScreenTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.aSignUpButton = new System.Windows.Forms.Button();
            this.aRegisterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aWelcomeLabel
            // 
            this.aWelcomeLabel.AutoSize = true;
            this.aWelcomeLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aWelcomeLabel.Location = new System.Drawing.Point(169, 26);
            this.aWelcomeLabel.Name = "aWelcomeLabel";
            this.aWelcomeLabel.Size = new System.Drawing.Size(33, 23);
            this.aWelcomeLabel.TabIndex = 23;
            this.aWelcomeLabel.Text = "Or";
            this.aWelcomeLabel.Click += new System.EventHandler(this.aWelcomeLabel_Click);
            // 
            // aMaximiseScreenTimer
            // 
            this.aMaximiseScreenTimer.Enabled = true;
            this.aMaximiseScreenTimer.Interval = 3600000;
            this.aMaximiseScreenTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "New Perspectives";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // aSignUpButton
            // 
            this.aSignUpButton.Location = new System.Drawing.Point(12, 12);
            this.aSignUpButton.Name = "aSignUpButton";
            this.aSignUpButton.Size = new System.Drawing.Size(147, 50);
            this.aSignUpButton.TabIndex = 24;
            this.aSignUpButton.Text = "Sign In";
            this.aSignUpButton.UseVisualStyleBackColor = true;
            this.aSignUpButton.Visible = false;
            this.aSignUpButton.Click += new System.EventHandler(this.aSignUpButton_Click);
            // 
            // aRegisterButton
            // 
            this.aRegisterButton.Location = new System.Drawing.Point(211, 12);
            this.aRegisterButton.Name = "aRegisterButton";
            this.aRegisterButton.Size = new System.Drawing.Size(147, 50);
            this.aRegisterButton.TabIndex = 24;
            this.aRegisterButton.Text = "Register";
            this.aRegisterButton.UseVisualStyleBackColor = true;
            this.aRegisterButton.Visible = false;
            this.aRegisterButton.Click += new System.EventHandler(this.aRegisterButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(370, 78);
            this.Controls.Add(this.aRegisterButton);
            this.Controls.Add(this.aSignUpButton);
            this.Controls.Add(this.aWelcomeLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "New Perspectives";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label aWelcomeLabel;
        private System.Windows.Forms.Timer aMaximiseScreenTimer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button aSignUpButton;
        private System.Windows.Forms.Button aRegisterButton;
    }
}

