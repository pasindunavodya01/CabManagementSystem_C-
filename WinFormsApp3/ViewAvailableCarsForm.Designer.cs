namespace WinFormsApp3
{
    partial class ViewAvailableCarsForm
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
            dgvAvailableCars = new DataGridView();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableCars).BeginInit();
            SuspendLayout();
            // 
            // dgvAvailableCars
            // 
            dgvAvailableCars.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailableCars.Location = new Point(0, 0);
            dgvAvailableCars.Name = "dgvAvailableCars";
            dgvAvailableCars.RowHeadersWidth = 51;
            dgvAvailableCars.RowTemplate.Height = 29;
            dgvAvailableCars.Size = new Size(300, 188);
            dgvAvailableCars.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(714, 21);
            button4.Name = "button4";
            button4.Size = new Size(74, 29);
            button4.TabIndex = 20;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // ViewAvailableCarsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(dgvAvailableCars);
            Name = "ViewAvailableCarsForm";
            Text = "ViewAvailableCarsForm";
            Load += ViewAvailableCarsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAvailableCars).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvAvailableCars;
        private Button button4;
    }
}