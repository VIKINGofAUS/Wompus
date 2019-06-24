namespace New_Perspectives
{
    partial class LoginForm
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.aEmailTextbox = new System.Windows.Forms.TextBox();
            this.aPasswordTexbox = new System.Windows.Forms.TextBox();
            this.aEmailLable = new System.Windows.Forms.Label();
            this.aPasswordLable = new System.Windows.Forms.Label();
            this.aSubmitButton = new System.Windows.Forms.Button();
            this.aincorrectLoginLable = new System.Windows.Forms.Label();
            this.aKeyLable = new System.Windows.Forms.Label();
            this.aKeyBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // aEmailTextbox
            // 
            this.aEmailTextbox.Location = new System.Drawing.Point(123, 38);
            this.aEmailTextbox.Name = "aEmailTextbox";
            this.aEmailTextbox.Size = new System.Drawing.Size(197, 22);
            this.aEmailTextbox.TabIndex = 0;
            // 
            // aPasswordTexbox
            // 
            this.aPasswordTexbox.Location = new System.Drawing.Point(123, 70);
            this.aPasswordTexbox.Name = "aPasswordTexbox";
            this.aPasswordTexbox.Size = new System.Drawing.Size(197, 22);
            this.aPasswordTexbox.TabIndex = 0;
            // 
            // aEmailLable
            // 
            this.aEmailLable.AutoSize = true;
            this.aEmailLable.Location = new System.Drawing.Point(33, 38);
            this.aEmailLable.Name = "aEmailLable";
            this.aEmailLable.Size = new System.Drawing.Size(42, 17);
            this.aEmailLable.TabIndex = 1;
            this.aEmailLable.Text = "Email";
            // 
            // aPasswordLable
            // 
            this.aPasswordLable.AutoSize = true;
            this.aPasswordLable.Location = new System.Drawing.Point(33, 73);
            this.aPasswordLable.Name = "aPasswordLable";
            this.aPasswordLable.Size = new System.Drawing.Size(69, 17);
            this.aPasswordLable.TabIndex = 2;
            this.aPasswordLable.Text = "Password";
            // 
            // aSubmitButton
            // 
            this.aSubmitButton.Location = new System.Drawing.Point(123, 134);
            this.aSubmitButton.Name = "aSubmitButton";
            this.aSubmitButton.Size = new System.Drawing.Size(197, 23);
            this.aSubmitButton.TabIndex = 3;
            this.aSubmitButton.Text = "Submit";
            this.aSubmitButton.UseVisualStyleBackColor = true;
            this.aSubmitButton.Click += new System.EventHandler(this.aSubmitButton_Click);
            // 
            // aincorrectLoginLable
            // 
            this.aincorrectLoginLable.AutoSize = true;
            this.aincorrectLoginLable.Location = new System.Drawing.Point(107, 9);
            this.aincorrectLoginLable.Name = "aincorrectLoginLable";
            this.aincorrectLoginLable.Size = new System.Drawing.Size(213, 17);
            this.aincorrectLoginLable.TabIndex = 4;
            this.aincorrectLoginLable.Text = "Username or password incorrect";
            this.aincorrectLoginLable.Visible = false;
            // 
            // aKeyLable
            // 
            this.aKeyLable.AutoSize = true;
            this.aKeyLable.Location = new System.Drawing.Point(33, 101);
            this.aKeyLable.Name = "aKeyLable";
            this.aKeyLable.Size = new System.Drawing.Size(32, 17);
            this.aKeyLable.TabIndex = 5;
            this.aKeyLable.Text = "Key";
            this.aKeyLable.Visible = false;
            // 
            // aKeyBox
            // 
            this.aKeyBox.Location = new System.Drawing.Point(123, 98);
            this.aKeyBox.Name = "aKeyBox";
            this.aKeyBox.Size = new System.Drawing.Size(197, 22);
            this.aKeyBox.TabIndex = 0;
            this.aKeyBox.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 169);
            this.Controls.Add(this.aKeyLable);
            this.Controls.Add(this.aincorrectLoginLable);
            this.Controls.Add(this.aSubmitButton);
            this.Controls.Add(this.aPasswordLable);
            this.Controls.Add(this.aEmailLable);
            this.Controls.Add(this.aKeyBox);
            this.Controls.Add(this.aPasswordTexbox);
            this.Controls.Add(this.aEmailTextbox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox aEmailTextbox;
        private System.Windows.Forms.TextBox aPasswordTexbox;
        private System.Windows.Forms.Label aEmailLable;
        private System.Windows.Forms.Label aPasswordLable;
        private System.Windows.Forms.Button aSubmitButton;
        private System.Windows.Forms.Label aincorrectLoginLable;
        private System.Windows.Forms.Label aKeyLable;
        private System.Windows.Forms.TextBox aKeyBox;
    }
}