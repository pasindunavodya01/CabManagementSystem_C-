namespace WinFormsApp3
{
    partial class DriverManagementForm
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
            txtDriverId = new TextBox();
            button2 = new Button();
            dgvDrivers = new DataGridView();
            button4 = new Button();
            button1 = new Button();
            txtDriverContact = new TextBox();
            txtDriverName = new TextBox();
            button6 = new Button();
            button5 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).BeginInit();
            SuspendLayout();
            // 
            // txtDriverId
            // 
            txtDriverId.Location = new Point(371, 15);
            txtDriverId.Name = "txtDriverId";
            txtDriverId.Size = new Size(125, 27);
            txtDriverId.TabIndex = 22;
            // 
            // button2
            // 
            button2.Location = new Point(347, 57);
            button2.Name = "button2";
            button2.Size = new Size(150, 29);
            button2.TabIndex = 21;
            button2.Text = "Remove Driver";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dgvDrivers
            // 
            dgvDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrivers.Location = new Point(25, 272);
            dgvDrivers.Name = "dgvDrivers";
            dgvDrivers.RowHeadersWidth = 51;
            dgvDrivers.RowTemplate.Height = 29;
            dgvDrivers.Size = new Size(569, 188);
            dgvDrivers.TabIndex = 20;
            dgvDrivers.CellContentClick += dgvCars_CellContentClick;
            // 
            // button4
            // 
            button4.Location = new Point(656, 14);
            button4.Name = "button4";
            button4.Size = new Size(74, 29);
            button4.TabIndex = 19;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(178, 91);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 16;
            button1.Text = "Add Driver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtDriverContact
            // 
            txtDriverContact.Location = new Point(146, 55);
            txtDriverContact.Name = "txtDriverContact";
            txtDriverContact.Size = new Size(125, 27);
            txtDriverContact.TabIndex = 24;
            // 
            // txtDriverName
            // 
            txtDriverName.Location = new Point(146, 19);
            txtDriverName.Name = "txtDriverName";
            txtDriverName.Size = new Size(125, 27);
            txtDriverName.TabIndex = 23;
            // 
            // button6
            // 
            button6.Location = new Point(411, 171);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(86, 31);
            button6.TabIndex = 27;
            button6.Text = "Save ";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(347, 132);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(150, 31);
            button5.TabIndex = 26;
            button5.Text = "toggle availability";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.Location = new Point(347, 93);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(150, 31);
            button3.TabIndex = 25;
            button3.Text = "check availability";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 23);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 28;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 59);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 29;
            label2.Text = "Contact Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(293, 19);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 30;
            label3.Text = "DriverId";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 249);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 31;
            label4.Text = "All Drivers";
            // 
            // DriverManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 475);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(txtDriverContact);
            Controls.Add(txtDriverName);
            Controls.Add(txtDriverId);
            Controls.Add(button2);
            Controls.Add(dgvDrivers);
            Controls.Add(button4);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DriverManagementForm";
            Text = "DriverManagementForm";
            Load += DriverManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDriverId;
        private Button button2;
        private DataGridView dgvDrivers;
        private Button button4;
        private Button button1;
        private TextBox txtDriverContact;
        private TextBox txtDriverName;
        private Button button6;
        private Button button5;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}