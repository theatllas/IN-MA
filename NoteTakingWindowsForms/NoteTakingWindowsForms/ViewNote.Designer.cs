namespace NoteTakingWindowsForms
{
    partial class ViewNote
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
            panel2 = new Panel();
            label3 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            TextTextBox = new TextBox();
            label4 = new Label();
            TitleTextBox = new TextBox();
            NotesGridView = new DataGridView();
            BackButton = new Button();
            label5 = new Label();
            DeleteButton = new Button();
            EditButton = new Button();
            label6 = new Label();
            IDTextBox = new TextBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NotesGridView).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 509);
            panel2.Name = "panel2";
            panel2.Size = new Size(1002, 31);
            panel2.TabIndex = 3;
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
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1002, 77);
            panel1.TabIndex = 7;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(7, 184);
            label2.Name = "label2";
            label2.Size = new Size(70, 35);
            label2.TabIndex = 11;
            label2.Text = "Text:";
            // 
            // TextTextBox
            // 
            TextTextBox.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextTextBox.Location = new Point(88, 185);
            TextTextBox.Multiline = true;
            TextTextBox.Name = "TextTextBox";
            TextTextBox.Size = new Size(413, 307);
            TextTextBox.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(7, 136);
            label4.Name = "label4";
            label4.Size = new Size(72, 35);
            label4.TabIndex = 13;
            label4.Text = "Title:";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TitleTextBox.Location = new Point(88, 137);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(413, 36);
            TitleTextBox.TabIndex = 12;
            // 
            // NotesGridView
            // 
            NotesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            NotesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NotesGridView.Location = new Point(522, 125);
            NotesGridView.Name = "NotesGridView";
            NotesGridView.RowHeadersWidth = 51;
            NotesGridView.RowTemplate.Height = 29;
            NotesGridView.Size = new Size(466, 334);
            NotesGridView.TabIndex = 14;
            NotesGridView.CellDoubleClick += NotesGridView_CellDoubleClick;
            // 
            // BackButton
            // 
            BackButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.Location = new Point(855, 467);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(133, 36);
            BackButton.TabIndex = 15;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(522, 82);
            label5.Name = "label5";
            label5.Size = new Size(194, 35);
            label5.TabIndex = 16;
            label5.Text = "Previous Notes:";
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteButton.Location = new Point(689, 467);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(133, 36);
            DeleteButton.TabIndex = 18;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditButton
            // 
            EditButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EditButton.Location = new Point(522, 467);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(133, 36);
            EditButton.TabIndex = 19;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(7, 94);
            label6.Name = "label6";
            label6.Size = new Size(47, 35);
            label6.TabIndex = 21;
            label6.Text = "ID:";
            // 
            // IDTextBox
            // 
            IDTextBox.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            IDTextBox.Location = new Point(88, 95);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(210, 36);
            IDTextBox.TabIndex = 20;
            // 
            // ViewNote
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 540);
            Controls.Add(label6);
            Controls.Add(IDTextBox);
            Controls.Add(EditButton);
            Controls.Add(DeleteButton);
            Controls.Add(label5);
            Controls.Add(BackButton);
            Controls.Add(NotesGridView);
            Controls.Add(label4);
            Controls.Add(TitleTextBox);
            Controls.Add(label2);
            Controls.Add(TextTextBox);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewNote";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewNote";
            Load += ViewNote_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NotesGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label3;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox TextTextBox;
        private Label label4;
        private TextBox TitleTextBox;
        private DataGridView NotesGridView;
        private Button BackButton;
        private Label label5;
        private Button DeleteButton;
        private Button EditButton;
        private Label label6;
        private TextBox IDTextBox;
    }
}