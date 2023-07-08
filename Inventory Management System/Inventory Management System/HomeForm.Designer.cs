namespace Inventory_Management_System
{
    partial class HomeForm
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
            label5 = new Label();
            ExitButton = new Button();
            ProductsButton = new Button();
            UsersButton = new Button();
            CategoriesButton = new Button();
            OrdersButton = new Button();
            CustomersButton = new Button();
            LogoutButton = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 23F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(156, 9);
            label5.Name = "label5";
            label5.Size = new Size(650, 52);
            label5.TabIndex = 31;
            label5.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Paddington ", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ExitButton.Location = new Point(873, 306);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 48);
            ExitButton.TabIndex = 36;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ProductsButton
            // 
            ProductsButton.Font = new Font("Paddington ", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ProductsButton.Location = new Point(28, 165);
            ProductsButton.Name = "ProductsButton";
            ProductsButton.Size = new Size(136, 48);
            ProductsButton.TabIndex = 32;
            ProductsButton.Text = "Products";
            ProductsButton.UseVisualStyleBackColor = true;
            ProductsButton.Click += ProductsButton_Click;
            // 
            // UsersButton
            // 
            UsersButton.Font = new Font("Paddington ", 12F, FontStyle.Bold, GraphicsUnit.Point);
            UsersButton.Location = new Point(228, 165);
            UsersButton.Name = "UsersButton";
            UsersButton.Size = new Size(136, 48);
            UsersButton.TabIndex = 37;
            UsersButton.Text = "Users";
            UsersButton.UseVisualStyleBackColor = true;
            UsersButton.Click += UsersButton_Click;
            // 
            // CategoriesButton
            // 
            CategoriesButton.Font = new Font("Paddington ", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CategoriesButton.Location = new Point(429, 165);
            CategoriesButton.Name = "CategoriesButton";
            CategoriesButton.Size = new Size(136, 48);
            CategoriesButton.TabIndex = 38;
            CategoriesButton.Text = "Categories";
            CategoriesButton.UseVisualStyleBackColor = true;
            CategoriesButton.Click += CategoriesButton_Click;
            // 
            // OrdersButton
            // 
            OrdersButton.Font = new Font("Paddington ", 12F, FontStyle.Bold, GraphicsUnit.Point);
            OrdersButton.Location = new Point(812, 165);
            OrdersButton.Name = "OrdersButton";
            OrdersButton.Size = new Size(136, 48);
            OrdersButton.TabIndex = 40;
            OrdersButton.Text = "Orders";
            OrdersButton.UseVisualStyleBackColor = true;
            OrdersButton.Click += OrdersButton_Click;
            // 
            // CustomersButton
            // 
            CustomersButton.Font = new Font("Paddington ", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CustomersButton.Location = new Point(613, 165);
            CustomersButton.Name = "CustomersButton";
            CustomersButton.Size = new Size(136, 48);
            CustomersButton.TabIndex = 39;
            CustomersButton.Text = "Customers";
            CustomersButton.UseVisualStyleBackColor = true;
            CustomersButton.Click += CustomersButton_Click;
            // 
            // LogoutButton
            // 
            LogoutButton.Font = new Font("Paddington ", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LogoutButton.Location = new Point(429, 306);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(136, 48);
            LogoutButton.TabIndex = 41;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 378);
            Controls.Add(LogoutButton);
            Controls.Add(OrdersButton);
            Controls.Add(CustomersButton);
            Controls.Add(CategoriesButton);
            Controls.Add(UsersButton);
            Controls.Add(ExitButton);
            Controls.Add(ProductsButton);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Button ExitButton;
        private Button ProductsButton;
        private Button UsersButton;
        private Button CategoriesButton;
        private Button OrdersButton;
        private Button CustomersButton;
        private Button LogoutButton;
    }
}