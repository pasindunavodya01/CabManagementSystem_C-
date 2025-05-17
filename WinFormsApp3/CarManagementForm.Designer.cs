namespace WinFormsApp3
{
    partial class CarManagementForm
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
            button4 = new Button();
            txtPlateNumber = new TextBox();
            txtModel = new TextBox();
            button1 = new Button();
            txtCarId = new TextBox();
            button2 = new Button();
            dgvCars = new DataGridView();
            button3 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Location = new Point(579, 181);
            button4.Name = "button4";
            button4.Size = new Size(207, 29);
            button4.TabIndex = 12;
            button4.Text = "ViewAvailableCars";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // txtPlateNumber
            // 
            txtPlateNumber.Location = new Point(122, 45);
            txtPlateNumber.Name = "txtPlateNumber";
            txtPlateNumber.Size = new Size(125, 27);
            txtPlateNumber.TabIndex = 11;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(122, 12);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(125, 27);
            txtModel.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(153, 77);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Add car";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // txtCarId
            // 
            txtCarId.Location = new Point(425, 15);
            txtCarId.Name = "txtCarId";
            txtCarId.Size = new Size(125, 27);
            txtCarId.TabIndex = 15;
            // 
            // button2
            // 
            button2.Location = new Point(390, 49);
            button2.Name = "button2";
            button2.Size = new Size(160, 29);
            button2.TabIndex = 14;
            button2.Text = "Remove car";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // dgvCars
            // 
            dgvCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCars.Location = new Point(41, 217);
            dgvCars.Margin = new Padding(3, 4, 3, 4);
            dgvCars.Name = "dgvCars";
            dgvCars.RowHeadersWidth = 51;
            dgvCars.RowTemplate.Height = 25;
            dgvCars.Size = new Size(616, 200);
            dgvCars.TabIndex = 16;
            dgvCars.CellContentClick += dgvCars_CellContentClick;
            // 
            // button3
            // 
            button3.Location = new Point(397, 84);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(154, 31);
            button3.TabIndex = 17;
            button3.Text = "check availability";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(397, 123);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(154, 31);
            button5.TabIndex = 18;
            button5.Text = "toggle availability";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(465, 161);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(86, 31);
            button6.TabIndex = 19;
            button6.Text = "Save ";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 16);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 20;
            label1.Text = "Model";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 49);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 21;
            label2.Text = "Plate Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(375, 19);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 22;
            label3.Text = "CarId";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 193);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 23;
            label4.Text = "All cars";
            // 
            // button7
            // 
            button7.Location = new Point(714, 13);
            button7.Name = "button7";
            button7.Size = new Size(74, 29);
            button7.TabIndex = 24;
            button7.Text = "Back";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // CarManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(button7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(dgvCars);
            Controls.Add(txtCarId);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(txtPlateNumber);
            Controls.Add(txtModel);
            Controls.Add(button1);
            Name = "CarManagementForm";
            Text = "CarManagementForm";
            Load += CarManagementForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button4;
        private TextBox txtPlateNumber;
        private TextBox txtModel;
        private Button button1;
        private TextBox txtCarId;
        private Button button2;
        private DataGridView dgvCars;
        private Button button3;
        private Button button5;
        private Button button6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button7;
    }
}