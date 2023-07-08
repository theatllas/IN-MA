namespace Inventory_Management_System
{
    partial class ManageProducts
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
            label4 = new Label();
            label5 = new Label();
            ProductGridView = new DataGridView();
            ExitButton = new Button();
            ProductQuantityTextBox = new TextBox();
            ProductNameTextBox = new TextBox();
            ProductIDTextBox = new TextBox();
            HomeButton = new Button();
            DeleteButton = new Button();
            EditButton = new Button();
            AddButton = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ProductPriceTextBox = new TextBox();
            label6 = new Label();
            DiscriptionTextBox = new TextBox();
            label7 = new Label();
            CategoryComboBox = new ComboBox();
            SearchComboBox = new ComboBox();
            SearchButton = new Button();
            RefreshButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductGridView).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(460, 104);
            label4.Name = "label4";
            label4.Size = new Size(251, 41);
            label4.TabIndex = 45;
            label4.Text = "Manage Products";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 23F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(278, 34);
            label5.Name = "label5";
            label5.Size = new Size(650, 52);
            label5.TabIndex = 44;
            label5.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // ProductGridView
            // 
            ProductGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductGridView.Location = new Point(389, 230);
            ProductGridView.Name = "ProductGridView";
            ProductGridView.RowHeadersWidth = 51;
            ProductGridView.RowTemplate.Height = 29;
            ProductGridView.Size = new Size(762, 493);
            ProductGridView.TabIndex = 43;
            ProductGridView.CellDoubleClick += ProductGridView_CellDoubleClick;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(52, 694);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 42;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ProductQuantityTextBox
            // 
            ProductQuantityTextBox.Location = new Point(52, 335);
            ProductQuantityTextBox.Name = "ProductQuantityTextBox";
            ProductQuantityTextBox.Size = new Size(203, 27);
            ProductQuantityTextBox.TabIndex = 41;
            // 
            // ProductNameTextBox
            // 
            ProductNameTextBox.Location = new Point(52, 267);
            ProductNameTextBox.Name = "ProductNameTextBox";
            ProductNameTextBox.Size = new Size(203, 27);
            ProductNameTextBox.TabIndex = 40;
            // 
            // ProductIDTextBox
            // 
            ProductIDTextBox.Location = new Point(52, 201);
            ProductIDTextBox.Name = "ProductIDTextBox";
            ProductIDTextBox.Size = new Size(203, 27);
            ProductIDTextBox.TabIndex = 39;
            // 
            // HomeButton
            // 
            HomeButton.Location = new Point(52, 638);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(94, 29);
            HomeButton.TabIndex = 38;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += HomeButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(52, 580);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 29);
            DeleteButton.TabIndex = 37;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(161, 694);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(94, 29);
            EditButton.TabIndex = 36;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(161, 640);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 35;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 312);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 34;
            label3.Text = "Product Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 244);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 33;
            label2.Text = "Product Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 178);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 32;
            label1.Text = "Product ID";
            // 
            // ProductPriceTextBox
            // 
            ProductPriceTextBox.Location = new Point(52, 405);
            ProductPriceTextBox.Name = "ProductPriceTextBox";
            ProductPriceTextBox.Size = new Size(203, 27);
            ProductPriceTextBox.TabIndex = 47;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 382);
            label6.Name = "label6";
            label6.Size = new Size(96, 20);
            label6.TabIndex = 46;
            label6.Text = "Product Price";
            // 
            // DiscriptionTextBox
            // 
            DiscriptionTextBox.Location = new Point(52, 480);
            DiscriptionTextBox.Name = "DiscriptionTextBox";
            DiscriptionTextBox.Size = new Size(203, 27);
            DiscriptionTextBox.TabIndex = 49;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(52, 457);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 48;
            label7.Text = "Discription";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(52, 537);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(203, 28);
            CategoryComboBox.TabIndex = 50;
            // 
            // SearchComboBox
            // 
            SearchComboBox.FormattingEnabled = true;
            SearchComboBox.Location = new Point(573, 178);
            SearchComboBox.Name = "SearchComboBox";
            SearchComboBox.Size = new Size(203, 28);
            SearchComboBox.TabIndex = 51;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(797, 178);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 29);
            SearchButton.TabIndex = 52;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // RefreshButton
            // 
            RefreshButton.Location = new Point(897, 178);
            RefreshButton.Name = "RefreshButton";
            RefreshButton.Size = new Size(94, 29);
            RefreshButton.TabIndex = 53;
            RefreshButton.Text = "Refresh";
            RefreshButton.UseVisualStyleBackColor = true;
            RefreshButton.Click += RefreshButton_Click;
            // 
            // ManageProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(RefreshButton);
            Controls.Add(SearchButton);
            Controls.Add(SearchComboBox);
            Controls.Add(CategoryComboBox);
            Controls.Add(DiscriptionTextBox);
            Controls.Add(label7);
            Controls.Add(ProductPriceTextBox);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(ProductGridView);
            Controls.Add(ExitButton);
            Controls.Add(ProductQuantityTextBox);
            Controls.Add(ProductNameTextBox);
            Controls.Add(ProductIDTextBox);
            Controls.Add(HomeButton);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(AddButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageProducts";
            Load += ManageProducts_Load;
            ((System.ComponentModel.ISupportInitialize)ProductGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label5;
        private DataGridView ProductGridView;
        private Button ExitButton;
        private TextBox ProductQuantityTextBox;
        private TextBox ProductNameTextBox;
        private TextBox ProductIDTextBox;
        private Button HomeButton;
        private Button DeleteButton;
        private Button EditButton;
        private Button AddButton;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox ProductPriceTextBox;
        private Label label6;
        private TextBox DiscriptionTextBox;
        private Label label7;
        private ComboBox CategoryComboBox;
        private ComboBox SearchComboBox;
        private Button SearchButton;
        private Button RefreshButton;
    }
}