namespace WinFormsApp3
{
    partial class AdminRegisterForm
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
            button1 = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            txtContactNumber = new TextBox();
            txtName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(298, 267);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(290, 193);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 12;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(290, 160);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 11;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Location = new Point(290, 83);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(125, 27);
            txtContactNumber.TabIndex = 8;
            txtContactNumber.TextChanged += txtContactNumber_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(290, 40);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 40);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 14;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 83);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 15;
            label2.Text = "Contact Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 164);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 16;
            label3.Text = "Create an Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(155, 197);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 17;
            label4.Text = "Create a Password";
            // 
            // button4
            // 
            button4.Location = new Point(714, 12);
            button4.Name = "button4";
            button4.Size = new Size(74, 29);
            button4.TabIndex = 20;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // AdminRegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(button4);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtContactNumber);
            Controls.Add(txtName);
            Name = "AdminRegisterForm";
            Text = "AdminRegisterForm";
            Load += AdminRegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private TextBox txtContactNumber;
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button4;
    }
}