namespace WinFormsApp3
{
    partial class ConfirmationForm
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
            lblConfirmation = new Label();
            SuspendLayout();
            // 
            // lblConfirmation
            // 
            lblConfirmation.AutoSize = true;
            lblConfirmation.Location = new Point(253, 104);
            lblConfirmation.Name = "lblConfirmation";
            lblConfirmation.Size = new Size(50, 20);
            lblConfirmation.TabIndex = 0;
            lblConfirmation.Text = "label1";
            // 
            // ConfirmationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblConfirmation);
            Name = "ConfirmationForm";
            Text = "ConfirmationForm";
            Load += ConfirmationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblConfirmation;
    }
}