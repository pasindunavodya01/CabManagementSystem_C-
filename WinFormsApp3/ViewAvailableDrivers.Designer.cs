namespace WinFormsApp3
{
    partial class ViewAvailableDrivers
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
            dgvAvailableDrivers = new DataGridView();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableDrivers).BeginInit();
            SuspendLayout();
            // 
            // dgvAvailableDrivers
            // 
            dgvAvailableDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailableDrivers.Location = new Point(0, 0);
            dgvAvailableDrivers.Name = "dgvAvailableDrivers";
            dgvAvailableDrivers.RowHeadersWidth = 51;
            dgvAvailableDrivers.RowTemplate.Height = 29;
            dgvAvailableDrivers.Size = new Size(300, 188);
            dgvAvailableDrivers.TabIndex = 0;
            dgvAvailableDrivers.CellContentClick += dgvAvailableDrivers_CellContentClick;
            // 
            // button4
            // 
            button4.Location = new Point(714, 23);
            button4.Name = "button4";
            button4.Size = new Size(74, 29);
            button4.TabIndex = 20;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = true;
            // 
            // ViewAvailableDrivers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(dgvAvailableDrivers);
            Name = "ViewAvailableDrivers";
            Text = "ViewAvailableDrivers";
            Load += ViewAvailableDrivers_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAvailableDrivers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAvailableDrivers;
        private Button button4;
    }
}