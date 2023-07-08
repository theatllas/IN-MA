namespace Inventory_Management_System
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            inventoryMangementSystemLable = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            showPasswordCheckBox = new CheckBox();
            clearButton = new Button();
            loginButton = new Button();
            passwordLabel = new Label();
            passwordTextBox = new TextBox();
            userNameLabel = new Label();
            userNameTextBox = new TextBox();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // inventoryMangementSystemLable
            // 
            inventoryMangementSystemLable.AutoSize = true;
            inventoryMangementSystemLable.BackColor = Color.Transparent;
            inventoryMangementSystemLable.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            inventoryMangementSystemLable.ForeColor = Color.White;
            inventoryMangementSystemLable.Location = new Point(106, 23);
            inventoryMangementSystemLable.Name = "inventoryMangementSystemLable";
            inventoryMangementSystemLable.Size = new Size(502, 38);
            inventoryMangementSystemLable.TabIndex = 0;
            inventoryMangementSystemLable.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(showPasswordCheckBox);
            panel1.Controls.Add(clearButton);
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(passwordLabel);
            panel1.Controls.Add(passwordTextBox);
            panel1.Controls.Add(userNameLabel);
            panel1.Controls.Add(userNameTextBox);
            panel1.Location = new Point(155, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 391);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(136, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // showPasswordCheckBox
            // 
            showPasswordCheckBox.AutoSize = true;
            showPasswordCheckBox.BackColor = Color.Transparent;
            showPasswordCheckBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            showPasswordCheckBox.ForeColor = Color.Brown;
            showPasswordCheckBox.Location = new Point(155, 319);
            showPasswordCheckBox.Name = "showPasswordCheckBox";
            showPasswordCheckBox.Size = new Size(175, 32);
            showPasswordCheckBox.TabIndex = 9;
            showPasswordCheckBox.Text = "Show Password";
            showPasswordCheckBox.UseVisualStyleBackColor = false;
            showPasswordCheckBox.CheckedChanged += showPasswordCheckBox_CheckedChanged;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.Transparent;
            clearButton.FlatAppearance.BorderSize = 0;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clearButton.ForeColor = Color.Brown;
            clearButton.Location = new Point(80, 310);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(69, 48);
            clearButton.TabIndex = 8;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.White;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.ForeColor = Color.DeepSkyBlue;
            loginButton.Location = new Point(80, 258);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(242, 46);
            loginButton.TabIndex = 7;
            loginButton.Text = "LOGIN";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Location = new Point(80, 171);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(112, 31);
            passwordLabel.TabIndex = 6;
            passwordLabel.Text = "Password";
            // 
            // passwordTextBox
            // 
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(80, 205);
            passwordTextBox.Multiline = true;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(242, 33);
            passwordTextBox.TabIndex = 5;
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.BackColor = Color.Transparent;
            userNameLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            userNameLabel.ForeColor = Color.White;
            userNameLabel.Location = new Point(80, 91);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(123, 31);
            userNameLabel.TabIndex = 4;
            userNameLabel.Text = "UserName";
            // 
            // userNameTextBox
            // 
            userNameTextBox.BorderStyle = BorderStyle.None;
            userNameTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            userNameTextBox.Location = new Point(80, 125);
            userNameTextBox.Multiline = true;
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(242, 33);
            userNameTextBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Padaloma", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(291, 474);
            button1.Name = "button1";
            button1.Size = new Size(106, 48);
            button1.TabIndex = 11;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 530);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(inventoryMangementSystemLable);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label inventoryMangementSystemLable;
        private Panel panel1;
        private Button clearButton;
        private Button loginButton;
        private Label passwordLabel;
        private TextBox passwordTextBox;
        private Label userNameLabel;
        private TextBox userNameTextBox;
        private CheckBox showPasswordCheckBox;
        private PictureBox pictureBox1;
        private Button button1;
    }
}