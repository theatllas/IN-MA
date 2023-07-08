namespace Inventory_Management_System
{
    partial class ManageCategories
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
            CategoryGridView = new DataGridView();
            ExitButton = new Button();
            CategoryNameTextBox = new TextBox();
            CategoryIDTextBox = new TextBox();
            HomeButton = new Button();
            DeleteButton = new Button();
            EditButton = new Button();
            AddButton = new Button();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)CategoryGridView).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(493, 101);
            label4.Name = "label4";
            label4.Size = new Size(276, 41);
            label4.TabIndex = 45;
            label4.Text = "Manage Categories";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 23F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(268, 32);
            label5.Name = "label5";
            label5.Size = new Size(650, 52);
            label5.TabIndex = 44;
            label5.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // CategoryGridView
            // 
            CategoryGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CategoryGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CategoryGridView.Location = new Point(379, 228);
            CategoryGridView.Name = "CategoryGridView";
            CategoryGridView.RowHeadersWidth = 51;
            CategoryGridView.RowTemplate.Height = 29;
            CategoryGridView.Size = new Size(762, 493);
            CategoryGridView.TabIndex = 43;
            CategoryGridView.CellDoubleClick += CategoryGridView_CellDoubleClick;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(42, 692);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 42;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // CategoryNameTextBox
            // 
            CategoryNameTextBox.Location = new Point(42, 265);
            CategoryNameTextBox.Name = "CategoryNameTextBox";
            CategoryNameTextBox.Size = new Size(203, 27);
            CategoryNameTextBox.TabIndex = 40;
            // 
            // CategoryIDTextBox
            // 
            CategoryIDTextBox.Location = new Point(42, 199);
            CategoryIDTextBox.Name = "CategoryIDTextBox";
            CategoryIDTextBox.Size = new Size(203, 27);
            CategoryIDTextBox.TabIndex = 39;
            // 
            // HomeButton
            // 
            HomeButton.Location = new Point(42, 636);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(94, 29);
            HomeButton.TabIndex = 38;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += HomeButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(42, 578);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 29);
            DeleteButton.TabIndex = 37;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(42, 522);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(94, 29);
            EditButton.TabIndex = 36;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(42, 468);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 35;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 242);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 33;
            label2.Text = "Category Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 176);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 32;
            label1.Text = "Category ID";
            // 
            // ManageCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(CategoryGridView);
            Controls.Add(ExitButton);
            Controls.Add(CategoryNameTextBox);
            Controls.Add(CategoryIDTextBox);
            Controls.Add(HomeButton);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(AddButton);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageCategories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageCategories";
            Load += ManageCategories_Load;
            ((System.ComponentModel.ISupportInitialize)CategoryGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label5;
        private DataGridView CategoryGridView;
        private Button ExitButton;
        private TextBox CategoryNameTextBox;
        private TextBox CategoryIDTextBox;
        private Button HomeButton;
        private Button DeleteButton;
        private Button EditButton;
        private Button AddButton;
        private Label label2;
        private Label label1;
    }
}