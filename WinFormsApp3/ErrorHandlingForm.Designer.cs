namespace WinFormsApp3
{
    partial class ErrorHandlingForm
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
            lblErrorMessage = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.Location = new Point(0, 0);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(50, 20);
            lblErrorMessage.TabIndex = 0;
            lblErrorMessage.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(53, 82);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ErrorHandlingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(lblErrorMessage);
            Name = "ErrorHandlingForm";
            Text = "ErrorHandlingForm";
            Load += ErrorHandlingForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblErrorMessage;
        private Button button1;
    }
}