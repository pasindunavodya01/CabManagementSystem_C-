namespace WinFormsApp3
{
    partial class RegisterForm
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
            txtName = new TextBox();
            txtContactNumber = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(235, 27);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 0;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Location = new Point(235, 69);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(125, 27);
            txtContactNumber.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(235, 111);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(125, 27);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(235, 144);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(245, 184);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(184, 31);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 73);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 29;
            label2.Text = "Contact Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(160, 115);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 32;
            label5.Text = "Username";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(163, 155);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 33;
            label6.Text = "Password";
            // 
            // button4
            // 
            button4.Location = new Point(714, 26);
            button4.Name = "button4";
            button4.Size = new Size(74, 29);
            button4.TabIndex = 34;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(button4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtContactNumber);
            Controls.Add(txtName);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtContactNumber;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private Button button4;
    }
}