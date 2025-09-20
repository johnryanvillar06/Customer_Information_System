namespace CustomerInformationSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewCustomers = new DataGridView();
            btnAddCustomer = new Button();
            btnEditCustomer = new Button();
            btnDeleteCustomer = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.AllowUserToOrderColumns = true;
            dataGridViewCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Location = new Point(12, 12);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.Size = new Size(776, 350);
            dataGridViewCustomers.TabIndex = 0;
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Location = new Point(12, 380);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(120, 40);
            btnAddCustomer.TabIndex = 1;
            btnAddCustomer.Text = "Add Customer";
            btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // btnEditCustomer
            // 
            btnEditCustomer.Location = new Point(138, 380);
            btnEditCustomer.Name = "btnEditCustomer";
            btnEditCustomer.Size = new Size(120, 40);
            btnEditCustomer.TabIndex = 2;
            btnEditCustomer.Text = "Edit Customer";
            btnEditCustomer.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCustomer
            // 
            btnDeleteCustomer.Location = new Point(264, 380);
            btnDeleteCustomer.Name = "btnDeleteCustomer";
            btnDeleteCustomer.Size = new Size(120, 40);
            btnDeleteCustomer.TabIndex = 3;
            btnDeleteCustomer.Text = "Delete Customer";
            btnDeleteCustomer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewCustomers);
            Controls.Add(btnAddCustomer);
            Controls.Add(btnEditCustomer);
            Controls.Add(btnDeleteCustomer);
            Name = "Form1";
            Text = "Customer Information System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCustomers;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnDeleteCustomer;
    }
}
