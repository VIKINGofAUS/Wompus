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
            this.aUsernameTextbox = new System.Windows.Forms.TextBox();
            this.aPasswordTexbox = new System.Windows.Forms.TextBox();
            this.aUserNameLable = new System.Windows.Forms.Label();
            this.aPasswordLable = new System.Windows.Forms.Label();
            this.aSubmitButton = new System.Windows.Forms.Button();
            this.aincorrectLoginLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aUsernameTextbox
            // 
            this.aUsernameTextbox.Location = new System.Drawing.Point(123, 38);
            this.aUsernameTextbox.Name = "aUsernameTextbox";
            this.aUsernameTextbox.Size = new System.Drawing.Size(197, 22);
            this.aUsernameTextbox.TabIndex = 0;
            // 
            // aPasswordTexbox
            // 
            this.aPasswordTexbox.Location = new System.Drawing.Point(123, 70);
            this.aPasswordTexbox.Name = "aPasswordTexbox";
            this.aPasswordTexbox.Size = new System.Drawing.Size(197, 22);
            this.aPasswordTexbox.TabIndex = 0;
            // 
            // aUserNameLable
            // 
            this.aUserNameLable.AutoSize = true;
            this.aUserNameLable.Location = new System.Drawing.Point(33, 38);
            this.aUserNameLable.Name = "aUserNameLable";
            this.aUserNameLable.Size = new System.Drawing.Size(75, 17);
            this.aUserNameLable.TabIndex = 1;
            this.aUserNameLable.Text = "UserName";
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
            this.aSubmitButton.Location = new System.Drawing.Point(123, 109);
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
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 144);
            this.Controls.Add(this.aincorrectLoginLable);
            this.Controls.Add(this.aSubmitButton);
            this.Controls.Add(this.aPasswordLable);
            this.Controls.Add(this.aUserNameLable);
            this.Controls.Add(this.aPasswordTexbox);
            this.Controls.Add(this.aUsernameTextbox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox aUsernameTextbox;
        private System.Windows.Forms.TextBox aPasswordTexbox;
        private System.Windows.Forms.Label aUserNameLable;
        private System.Windows.Forms.Label aPasswordLable;
        private System.Windows.Forms.Button aSubmitButton;
        private System.Windows.Forms.Label aincorrectLoginLable;
    }
}