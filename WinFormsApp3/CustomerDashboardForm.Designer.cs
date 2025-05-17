namespace WinFormsApp3
{
    partial class CustomerDashboardForm
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
            cboAvailableCars = new ComboBox();
            cboAvailableDrivers = new ComboBox();
            button1 = new Button();
            button4 = new Button();
            txtCurrentLocation = new TextBox();
            txtDestination = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // cboAvailableCars
            // 
            cboAvailableCars.FormattingEnabled = true;
            cboAvailableCars.Location = new Point(593, 154);
            cboAvailableCars.Name = "cboAvailableCars";
            cboAvailableCars.Size = new Size(151, 28);
            cboAvailableCars.TabIndex = 0;
            // 
            // cboAvailableDrivers
            // 
            cboAvailableDrivers.FormattingEnabled = true;
            cboAvailableDrivers.Location = new Point(593, 197);
            cboAvailableDrivers.Name = "cboAvailableDrivers";
            cboAvailableDrivers.Size = new Size(151, 28);
            cboAvailableDrivers.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(650, 241);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(714, 398);
            button4.Name = "button4";
            button4.Size = new Size(74, 29);
            button4.TabIndex = 20;
            button4.Text = "LogOut";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtCurrentLocation
            // 
            txtCurrentLocation.Location = new Point(619, 77);
            txtCurrentLocation.Name = "txtCurrentLocation";
            txtCurrentLocation.Size = new Size(125, 27);
            txtCurrentLocation.TabIndex = 21;
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(619, 110);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(125, 27);
            txtDestination.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(486, 77);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 23;
            label1.Text = "Current Location";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(519, 113);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 24;
            label2.Text = "Destination";
            // 
            // button2
            // 
            button2.Location = new Point(619, 284);
            button2.Name = "button2";
            button2.Size = new Size(125, 29);
            button2.TabIndex = 25;
            button2.Text = "View My Order";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // CustomerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDestination);
            Controls.Add(txtCurrentLocation);
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(cboAvailableDrivers);
            Controls.Add(cboAvailableCars);
            Name = "CustomerDashboardForm";
            Text = "CustomerDashboardFormcs";
            Load += CustomerDashboardForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboAvailableCars;
        private ComboBox cboAvailableDrivers;
        private Button button1;
        private Button button4;
        private TextBox txtCurrentLocation;
        private TextBox txtDestination;
        private Label label1;
        private Label label2;
        private Button button2;
    }
}