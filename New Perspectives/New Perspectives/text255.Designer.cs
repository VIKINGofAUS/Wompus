namespace New_Perspectives
{
    partial class text255
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
            this.aAnswerTextbox = new System.Windows.Forms.TextBox();
            this.aQuestionLable = new System.Windows.Forms.Label();
            this.aSubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // aAnswerTextbox
            // 
            this.aAnswerTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aAnswerTextbox.Location = new System.Drawing.Point(12, 111);
            this.aAnswerTextbox.MaxLength = 255;
            this.aAnswerTextbox.Multiline = true;
            this.aAnswerTextbox.Name = "aAnswerTextbox";
            this.aAnswerTextbox.Size = new System.Drawing.Size(380, 126);
            this.aAnswerTextbox.TabIndex = 0;
            // 
            // aQuestionLable
            // 
            this.aQuestionLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aQuestionLable.Location = new System.Drawing.Point(13, 13);
            this.aQuestionLable.Name = "aQuestionLable";
            this.aQuestionLable.Size = new System.Drawing.Size(379, 83);
            this.aQuestionLable.TabIndex = 1;
            this.aQuestionLable.Text = "98 length Question";
            this.aQuestionLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // aSubmitButton
            // 
            this.aSubmitButton.Location = new System.Drawing.Point(12, 243);
            this.aSubmitButton.Name = "aSubmitButton";
            this.aSubmitButton.Size = new System.Drawing.Size(380, 33);
            this.aSubmitButton.TabIndex = 2;
            this.aSubmitButton.Text = "Submit";
            this.aSubmitButton.UseVisualStyleBackColor = true;
            this.aSubmitButton.Click += new System.EventHandler(this.aSubmitButton_Click);
            // 
            // text255
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 280);
            this.Controls.Add(this.aSubmitButton);
            this.Controls.Add(this.aQuestionLable);
            this.Controls.Add(this.aAnswerTextbox);
            this.Name = "text255";
            this.Text = "Question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox aAnswerTextbox;
        private System.Windows.Forms.Label aQuestionLable;
        private System.Windows.Forms.Button aSubmitButton;
    }
}