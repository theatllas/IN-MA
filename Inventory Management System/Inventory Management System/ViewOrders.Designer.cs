namespace Inventory_Management_System
{
    partial class ViewOrders
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
            OrderGridView = new DataGridView();
            BackButton = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)OrderGridView).BeginInit();
            SuspendLayout();
            // 
            // OrderGridView
            // 
            OrderGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OrderGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderGridView.Location = new Point(172, 241);
            OrderGridView.Name = "OrderGridView";
            OrderGridView.RowHeadersWidth = 51;
            OrderGridView.RowTemplate.Height = 29;
            OrderGridView.Size = new Size(842, 428);
            OrderGridView.TabIndex = 64;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(511, 702);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(123, 29);
            BackButton.TabIndex = 68;
            BackButton.Text = "Back";
            BackButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += BackButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(472, 24);
            label4.Name = "label4";
            label4.Size = new Size(180, 41);
            label4.TabIndex = 69;
            label4.Text = "View Orders";
            // 
            // ViewOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(label4);
            Controls.Add(BackButton);
            Controls.Add(OrderGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewOrders";
            Load += ViewOrders_Load;
            ((System.ComponentModel.ISupportInitialize)OrderGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView OrderGridView;
        private Button BackButton;
        private Label label4;
    }
}