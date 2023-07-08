namespace Inventory_Management_System
{
    partial class ManageCustomers
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
            ExitButton = new Button();
            CustomerPhoneTextBox = new TextBox();
            CustomerNameTextBox = new TextBox();
            CustomerIDTextBox = new TextBox();
            HomeButton = new Button();
            DeleteButton = new Button();
            EditButton = new Button();
            AddButton = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            CustomerGridView = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            OrdersLabel = new Label();
            AmountLabel = new Label();
            label9 = new Label();
            DateLabel = new Label();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)CustomerGridView).BeginInit();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(25, 687);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 28;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // CustomerPhoneTextBox
            // 
            CustomerPhoneTextBox.Location = new Point(25, 328);
            CustomerPhoneTextBox.Name = "CustomerPhoneTextBox";
            CustomerPhoneTextBox.Size = new Size(203, 27);
            CustomerPhoneTextBox.TabIndex = 26;
            // 
            // CustomerNameTextBox
            // 
            CustomerNameTextBox.Location = new Point(25, 260);
            CustomerNameTextBox.Name = "CustomerNameTextBox";
            CustomerNameTextBox.Size = new Size(203, 27);
            CustomerNameTextBox.TabIndex = 25;
            // 
            // CustomerIDTextBox
            // 
            CustomerIDTextBox.Location = new Point(25, 194);
            CustomerIDTextBox.Name = "CustomerIDTextBox";
            CustomerIDTextBox.Size = new Size(203, 27);
            CustomerIDTextBox.TabIndex = 24;
            // 
            // HomeButton
            // 
            HomeButton.Location = new Point(25, 631);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(94, 29);
            HomeButton.TabIndex = 23;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += HomeButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(25, 573);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 29);
            DeleteButton.TabIndex = 22;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(25, 517);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(94, 29);
            EditButton.TabIndex = 21;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(25, 463);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 20;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 305);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 19;
            label3.Text = "CustomerPhone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 237);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 17;
            label2.Text = "CustomerName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 171);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 16;
            label1.Text = " Customer ID";
            // 
            // CustomerGridView
            // 
            CustomerGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustomerGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerGridView.Location = new Point(418, 223);
            CustomerGridView.Name = "CustomerGridView";
            CustomerGridView.RowHeadersWidth = 51;
            CustomerGridView.RowTemplate.Height = 29;
            CustomerGridView.Size = new Size(706, 493);
            CustomerGridView.TabIndex = 29;
            CustomerGridView.CellDoubleClick += CustomerGridView_CellDoubleClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(476, 96);
            label4.Name = "label4";
            label4.Size = new Size(276, 41);
            label4.TabIndex = 31;
            label4.Text = "Manage Customers";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 23F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(251, 27);
            label5.Name = "label5";
            label5.Size = new Size(650, 52);
            label5.TabIndex = 30;
            label5.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(173, 419);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 32;
            label6.Text = "Orders Count";
            // 
            // OrdersLabel
            // 
            OrdersLabel.AutoSize = true;
            OrdersLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            OrdersLabel.Location = new Point(166, 439);
            OrdersLabel.Name = "OrdersLabel";
            OrdersLabel.Size = new Size(108, 41);
            OrdersLabel.TabIndex = 33;
            OrdersLabel.Text = "Orders";
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            AmountLabel.Location = new Point(164, 541);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(125, 41);
            AmountLabel.TabIndex = 35;
            AmountLabel.Text = "Amount";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(164, 521);
            label9.Name = "label9";
            label9.Size = new Size(110, 20);
            label9.TabIndex = 34;
            label9.Text = "Orders Amount";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            DateLabel.Location = new Point(173, 651);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(80, 41);
            DateLabel.TabIndex = 37;
            DateLabel.Text = "Date";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(169, 631);
            label11.Name = "label11";
            label11.Size = new Size(105, 20);
            label11.TabIndex = 36;
            label11.Text = "LastOrderDate";
            // 
            // ManageCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(DateLabel);
            Controls.Add(label11);
            Controls.Add(AmountLabel);
            Controls.Add(label9);
            Controls.Add(OrdersLabel);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(CustomerGridView);
            Controls.Add(ExitButton);
            Controls.Add(CustomerPhoneTextBox);
            Controls.Add(CustomerNameTextBox);
            Controls.Add(CustomerIDTextBox);
            Controls.Add(HomeButton);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(AddButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCustomers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageCustomers";
            Load += ManageCustomers_Load;
            ((System.ComponentModel.ISupportInitialize)CustomerGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitButton;
        private TextBox CustomerPhoneTextBox;
        private TextBox CustomerNameTextBox;
        private TextBox CustomerIDTextBox;
        private Button HomeButton;
        private Button DeleteButton;
        private Button EditButton;
        private Button AddButton;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView CustomerGridView;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label OrdersLabel;
        private Label AmountLabel;
        private Label label9;
        private Label DateLabel;
        private Label label11;
    }
}