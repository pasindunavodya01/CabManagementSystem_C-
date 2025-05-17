namespace WinFormsApp3
{
    partial class OrderDetailsForm
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
            txtOrderId = new TextBox();
            txtCustomerName = new TextBox();
            txtCustomerContact = new TextBox();
            txtDriverName = new TextBox();
            txtDriverContact = new TextBox();
            txtOrderDate = new TextBox();
            txtCurrentLocation = new TextBox();
            txtDestination = new TextBox();
            SuspendLayout();
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(0, 0);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.Size = new Size(125, 27);
            txtOrderId.TabIndex = 0;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(0, 33);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(125, 27);
            txtCustomerName.TabIndex = 1;
            txtCustomerName.TextChanged += textBox2_TextChanged;
            // 
            // txtCustomerContact
            // 
            txtCustomerContact.Location = new Point(0, 66);
            txtCustomerContact.Name = "txtCustomerContact";
            txtCustomerContact.Size = new Size(125, 27);
            txtCustomerContact.TabIndex = 2;
            // 
            // txtDriverName
            // 
            txtDriverName.Location = new Point(0, 99);
            txtDriverName.Name = "txtDriverName";
            txtDriverName.Size = new Size(125, 27);
            txtDriverName.TabIndex = 3;
            // 
            // txtDriverContact
            // 
            txtDriverContact.Location = new Point(0, 132);
            txtDriverContact.Name = "txtDriverContact";
            txtDriverContact.Size = new Size(125, 27);
            txtDriverContact.TabIndex = 4;
            // 
            // txtOrderDate
            // 
            txtOrderDate.Location = new Point(0, 165);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new Size(125, 27);
            txtOrderDate.TabIndex = 5;
            // 
            // txtCurrentLocation
            // 
            txtCurrentLocation.Location = new Point(0, 198);
            txtCurrentLocation.Name = "txtCurrentLocation";
            txtCurrentLocation.Size = new Size(125, 27);
            txtCurrentLocation.TabIndex = 6;
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(0, 247);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(125, 27);
            txtDestination.TabIndex = 7;
            // 
            // OrderDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDestination);
            Controls.Add(txtCurrentLocation);
            Controls.Add(txtOrderDate);
            Controls.Add(txtDriverContact);
            Controls.Add(txtDriverName);
            Controls.Add(txtCustomerContact);
            Controls.Add(txtCustomerName);
            Controls.Add(txtOrderId);
            Name = "OrderDetailsForm";
            Text = "OrderDetailsForm";
            Load += OrderDetailsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOrderId;
        private TextBox txtCustomerName;
        private TextBox txtCustomerContact;
        private TextBox txtDriverName;
        private TextBox txtDriverContact;
        private TextBox txtOrderDate;
        private TextBox txtCurrentLocation;
        private TextBox txtDestination;
    }
}