namespace NoteTakingWindowsForms
{
    partial class InsertNote
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            TitleTextBox = new TextBox();
            label2 = new Label();
            label4 = new Label();
            TextTextBox = new TextBox();
            ClearButton = new Button();
            SaveButton = new Button();
            BackButton = new Button();
            label5 = new Label();
            IDTextBox = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1002, 77);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Virgo 01", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(363, 22);
            label1.Name = "label1";
            label1.Size = new Size(284, 44);
            label1.TabIndex = 2;
            label1.Text = "Note App ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 509);
            panel2.Name = "panel2";
            panel2.Size = new Size(1002, 31);
            panel2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Virgo 01", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(468, 9);
            label3.Name = "label3";
            label3.Size = new Size(64, 22);
            label3.TabIndex = 3;
            label3.Text = "Exit";
            label3.Click += label3_Click;
            // 
            // TitleTextBox
            // 
            TitleTextBox.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TitleTextBox.Location = new Point(26, 223);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(413, 36);
            TitleTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 185);
            label2.Name = "label2";
            label2.Size = new Size(72, 35);
            label2.TabIndex = 4;
            label2.Text = "Title:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(468, 95);
            label4.Name = "label4";
            label4.Size = new Size(70, 35);
            label4.TabIndex = 6;
            label4.Text = "Text:";
            // 
            // TextTextBox
            // 
            TextTextBox.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextTextBox.Location = new Point(468, 133);
            TextTextBox.Multiline = true;
            TextTextBox.Name = "TextTextBox";
            TextTextBox.Size = new Size(520, 361);
            TextTextBox.TabIndex = 5;
            // 
            // ClearButton
            // 
            ClearButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClearButton.Location = new Point(306, 444);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(133, 50);
            ClearButton.TabIndex = 7;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SaveButton.Location = new Point(167, 444);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(133, 50);
            SaveButton.TabIndex = 8;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.Location = new Point(26, 444);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(133, 50);
            BackButton.TabIndex = 9;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(26, 95);
            label5.Name = "label5";
            label5.Size = new Size(47, 35);
            label5.TabIndex = 12;
            label5.Text = "ID:";
            // 
            // IDTextBox
            // 
            IDTextBox.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            IDTextBox.Location = new Point(26, 133);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(153, 36);
            IDTextBox.TabIndex = 11;
            // 
            // InsertNote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 540);
            Controls.Add(label5);
            Controls.Add(IDTextBox);
            Controls.Add(BackButton);
            Controls.Add(SaveButton);
            Controls.Add(ClearButton);
            Controls.Add(label4);
            Controls.Add(TextTextBox);
            Controls.Add(label2);
            Controls.Add(TitleTextBox);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InsertNote";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InsertNote";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label3;
        private TextBox TitleTextBox;
        private Label label2;
        private Label label4;
        private TextBox TextTextBox;
        private Button ClearButton;
        private Button SaveButton;
        private Button BackButton;
        private Label label5;
        private TextBox IDTextBox;
    }
}