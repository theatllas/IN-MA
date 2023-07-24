namespace NoteTakingWindowsForms
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label3 = new Label();
            InsertANoteButton = new Button();
            ViewNotesButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1002, 77);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Virgo 01", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(353, 20);
            label1.Name = "label1";
            label1.Size = new Size(284, 44);
            label1.TabIndex = 3;
            label1.Text = "Note App ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Controls.Add(label3);
            panel2.Location = new Point(-1, 509);
            panel2.Name = "panel2";
            panel2.Size = new Size(1002, 31);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Virgo 01", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(459, 9);
            label3.Name = "label3";
            label3.Size = new Size(64, 22);
            label3.TabIndex = 4;
            label3.Text = "Exit";
            label3.Click += label3_Click_1;
            // 
            // InsertANoteButton
            // 
            InsertANoteButton.Location = new Point(140, 328);
            InsertANoteButton.Name = "InsertANoteButton";
            InsertANoteButton.Size = new Size(133, 50);
            InsertANoteButton.TabIndex = 2;
            InsertANoteButton.Text = "Insert a Note";
            InsertANoteButton.UseVisualStyleBackColor = true;
            InsertANoteButton.Click += InsertANoteButton_Click;
            // 
            // ViewNotesButton
            // 
            ViewNotesButton.Location = new Point(746, 328);
            ViewNotesButton.Name = "ViewNotesButton";
            ViewNotesButton.Size = new Size(133, 50);
            ViewNotesButton.TabIndex = 3;
            ViewNotesButton.Text = "View Notes";
            ViewNotesButton.UseVisualStyleBackColor = true;
            ViewNotesButton.Click += ViewNotesButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.addnote_120243;
            pictureBox1.Location = new Point(140, 189);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 133);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(746, 189);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(133, 133);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 540);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(ViewNotesButton);
            Controls.Add(InsertANoteButton);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button InsertANoteButton;
        private Button ViewNotesButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label3;
    }
}