namespace WinFormsApp3
{
    partial class AdminDashboardForm
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
            button3 = new Button();
            dgvCars = new DataGridView();
            button4 = new Button();
            dgvDrivers = new DataGridView();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(682, 58);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 5;
            button3.Text = "Edit Cars";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dgvCars
            // 
            dgvCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCars.Location = new Point(14, 53);
            dgvCars.Name = "dgvCars";
            dgvCars.RowHeadersWidth = 51;
            dgvCars.RowTemplate.Height = 29;
            dgvCars.Size = new Size(591, 172);
            dgvCars.TabIndex = 6;
            dgvCars.CellContentClick += dgvCars_CellContentClick;
            // 
            // button4
            // 
            button4.Location = new Point(682, 97);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 7;
            button4.Text = "Edit Drivers";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dgvDrivers
            // 
            dgvDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrivers.Location = new Point(14, 263);
            dgvDrivers.Name = "dgvDrivers";
            dgvDrivers.RowHeadersWidth = 51;
            dgvDrivers.RowTemplate.Height = 29;
            dgvDrivers.Size = new Size(591, 159);
            dgvDrivers.TabIndex = 8;
            dgvDrivers.CellContentClick += dgvDrivers_CellContentClick;
            // 
            // button5
            // 
            button5.Location = new Point(682, 133);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 9;
            button5.Text = "View Order";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(682, 21);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 11;
            button6.Text = "Add admin";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 27);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 12;
            label1.Text = "Available Cars";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 240);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 13;
            label2.Text = "Available Drivers";
            // 
            // button1
            // 
            button1.Location = new Point(690, 169);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 14;
            button1.Text = "LogOut";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 455);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(dgvDrivers);
            Controls.Add(button4);
            Controls.Add(dgvCars);
            Controls.Add(button3);
            Name = "AdminDashboardForm";
            Text = "AdminDashboardForm";
            Load += AdminDashboardForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDrivers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private DataGridView dgvCars;
        private Button button4;
        private DataGridView dgvDrivers;
        private Button button5;
        private Button button6;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}