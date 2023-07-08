namespace Inventory_Management_System
{
    partial class ManageUsers
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            AddButton = new Button();
            EditButton = new Button();
            DeleteButton = new Button();
            HomeButton = new Button();
            UsersGridView = new DataGridView();
            UserNameTextBox = new TextBox();
            FullNameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            TelephoneTextBox = new TextBox();
            ExitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)UsersGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 23F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(250, 9);
            label1.Name = "label1";
            label1.Size = new Size(650, 52);
            label1.TabIndex = 0;
            label1.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(475, 78);
            label2.Name = "label2";
            label2.Size = new Size(207, 41);
            label2.TabIndex = 1;
            label2.Text = "Manage Users";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 164);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 2;
            label3.Text = "UserName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 230);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 3;
            label4.Text = "FullName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 369);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 4;
            label5.Text = "Telephone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 298);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 5;
            label6.Text = "Password";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(53, 456);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(94, 29);
            AddButton.TabIndex = 6;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(53, 510);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(94, 29);
            EditButton.TabIndex = 7;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(53, 566);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(94, 29);
            DeleteButton.TabIndex = 8;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // HomeButton
            // 
            HomeButton.Location = new Point(53, 624);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(94, 29);
            HomeButton.TabIndex = 9;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += HomeButton_Click;
            // 
            // UsersGridView
            // 
            UsersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UsersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersGridView.Location = new Point(377, 216);
            UsersGridView.Name = "UsersGridView";
            UsersGridView.RowHeadersWidth = 51;
            UsersGridView.RowTemplate.Height = 29;
            UsersGridView.Size = new Size(762, 493);
            UsersGridView.TabIndex = 10;
            UsersGridView.CellDoubleClick += UsersGridView_CellDoubleClick;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(53, 187);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(203, 27);
            UserNameTextBox.TabIndex = 11;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(53, 253);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(203, 27);
            FullNameTextBox.TabIndex = 12;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(53, 321);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(203, 27);
            PasswordTextBox.TabIndex = 13;
            // 
            // TelephoneTextBox
            // 
            TelephoneTextBox.Location = new Point(53, 392);
            TelephoneTextBox.Name = "TelephoneTextBox";
            TelephoneTextBox.Size = new Size(203, 27);
            TelephoneTextBox.TabIndex = 14;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(53, 680);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 29);
            ExitButton.TabIndex = 15;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // ManageUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(ExitButton);
            Controls.Add(TelephoneTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(FullNameTextBox);
            Controls.Add(UserNameTextBox);
            Controls.Add(UsersGridView);
            Controls.Add(HomeButton);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(AddButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageUsers";
            Load += ManageUsers_Load;
            ((System.ComponentModel.ISupportInitialize)UsersGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button AddButton;
        private Button EditButton;
        private Button DeleteButton;
        private Button HomeButton;
        private DataGridView UsersGridView;
        private TextBox UserNameTextBox;
        private TextBox FullNameTextBox;
        private TextBox PasswordTextBox;
        private TextBox TelephoneTextBox;
        private Button ExitButton;
    }
}