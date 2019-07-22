namespace New_Perspectives
{
    partial class YesNo
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
            this.aYesButton = new System.Windows.Forms.Button();
            this.aNoButton = new System.Windows.Forms.Button();
            this.AQuestionLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aYesButton
            // 
            this.aYesButton.Location = new System.Drawing.Point(12, 166);
            this.aYesButton.Name = "aYesButton";
            this.aYesButton.Size = new System.Drawing.Size(181, 37);
            this.aYesButton.TabIndex = 0;
            this.aYesButton.Text = "Yes";
            this.aYesButton.UseVisualStyleBackColor = true;
            this.aYesButton.Click += new System.EventHandler(this.aYesButton_Click);
            // 
            // aNoButton
            // 
            this.aNoButton.Location = new System.Drawing.Point(199, 166);
            this.aNoButton.Name = "aNoButton";
            this.aNoButton.Size = new System.Drawing.Size(181, 37);
            this.aNoButton.TabIndex = 1;
            this.aNoButton.Text = "No";
            this.aNoButton.UseVisualStyleBackColor = true;
            this.aNoButton.Click += new System.EventHandler(this.aNoButton_Click);
            // 
            // AQuestionLable
            // 
            this.AQuestionLable.Location = new System.Drawing.Point(13, 19);
            this.AQuestionLable.Name = "AQuestionLable";
            this.AQuestionLable.Size = new System.Drawing.Size(366, 147);
            this.AQuestionLable.TabIndex = 2;
            this.AQuestionLable.Text = "A Question Slot";
            // 
            // YesNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 212);
            this.Controls.Add(this.AQuestionLable);
            this.Controls.Add(this.aNoButton);
            this.Controls.Add(this.aYesButton);
            this.Name = "YesNo";
            this.Text = "YesNo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button aYesButton;
        private System.Windows.Forms.Button aNoButton;
        private System.Windows.Forms.Label AQuestionLable;
    }
}