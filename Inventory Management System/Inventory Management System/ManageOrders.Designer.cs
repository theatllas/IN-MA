namespace Inventory_Management_System
{
    partial class ManageOrders
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
            CustomerGridView = new DataGridView();
            label1 = new Label();
            CustomerIDTextBox = new TextBox();
            OrderIDTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            OrderDate = new DateTimePicker();
            SearchComboBox = new ComboBox();
            ProductGridView = new DataGridView();
            label6 = new Label();
            CustomerNameTextBox = new TextBox();
            label7 = new Label();
            label8 = new Label();
            QuantityTextBox = new TextBox();
            AddToOrderButton = new Button();
            OrderGridView = new DataGridView();
            label9 = new Label();
            TotalAmountLabel = new Label();
            InsertOrderButton = new Button();
            ViewOrdersButton = new Button();
            HomeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)CustomerGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrderGridView).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(443, 79);
            label4.Name = "label4";
            label4.Size = new Size(251, 41);
            label4.TabIndex = 47;
            label4.Text = "Manage Products";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 23F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(261, 9);
            label5.Name = "label5";
            label5.Size = new Size(650, 52);
            label5.TabIndex = 46;
            label5.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // CustomerGridView
            // 
            CustomerGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CustomerGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerGridView.Location = new Point(22, 163);
            CustomerGridView.Name = "CustomerGridView";
            CustomerGridView.RowHeadersWidth = 51;
            CustomerGridView.RowTemplate.Height = 29;
            CustomerGridView.Size = new Size(529, 252);
            CustomerGridView.TabIndex = 48;
            CustomerGridView.CellDoubleClick += CustomerGridView_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(181, 114);
            label1.Name = "label1";
            label1.Size = new Size(166, 35);
            label1.TabIndex = 49;
            label1.Text = "Customer List";
            // 
            // CustomerIDTextBox
            // 
            CustomerIDTextBox.Enabled = false;
            CustomerIDTextBox.Location = new Point(22, 526);
            CustomerIDTextBox.Name = "CustomerIDTextBox";
            CustomerIDTextBox.Size = new Size(203, 27);
            CustomerIDTextBox.TabIndex = 53;
            // 
            // OrderIDTextBox
            // 
            OrderIDTextBox.Location = new Point(22, 460);
            OrderIDTextBox.Name = "OrderIDTextBox";
            OrderIDTextBox.Size = new Size(203, 27);
            OrderIDTextBox.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 503);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 51;
            label2.Text = "Customer ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 437);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 50;
            label3.Text = "Order ID";
            // 
            // OrderDate
            // 
            OrderDate.Location = new Point(22, 656);
            OrderDate.Name = "OrderDate";
            OrderDate.Size = new Size(252, 27);
            OrderDate.TabIndex = 54;
            // 
            // SearchComboBox
            // 
            SearchComboBox.FormattingEnabled = true;
            SearchComboBox.Location = new Point(763, 123);
            SearchComboBox.Name = "SearchComboBox";
            SearchComboBox.Size = new Size(203, 28);
            SearchComboBox.TabIndex = 56;
            SearchComboBox.SelectionChangeCommitted += SearchComboBox_SelectionChangeCommitted;
            // 
            // ProductGridView
            // 
            ProductGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductGridView.Location = new Point(574, 163);
            ProductGridView.Name = "ProductGridView";
            ProductGridView.RowHeadersWidth = 51;
            ProductGridView.RowTemplate.Height = 29;
            ProductGridView.Size = new Size(596, 252);
            ProductGridView.TabIndex = 55;
            ProductGridView.CellContentDoubleClick += ProductGridView_CellContentDoubleClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 633);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 57;
            label6.Text = "Order Date";
            // 
            // CustomerNameTextBox
            // 
            CustomerNameTextBox.Enabled = false;
            CustomerNameTextBox.Location = new Point(22, 593);
            CustomerNameTextBox.Name = "CustomerNameTextBox";
            CustomerNameTextBox.Size = new Size(203, 27);
            CustomerNameTextBox.TabIndex = 59;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 570);
            label7.Name = "label7";
            label7.Size = new Size(116, 20);
            label7.TabIndex = 58;
            label7.Text = "Customer Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(328, 463);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 60;
            label8.Text = "Quantitiy";
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.Location = new Point(403, 460);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.Size = new Size(203, 27);
            QuantityTextBox.TabIndex = 61;
            // 
            // AddToOrderButton
            // 
            AddToOrderButton.Location = new Point(612, 458);
            AddToOrderButton.Name = "AddToOrderButton";
            AddToOrderButton.Size = new Size(123, 29);
            AddToOrderButton.TabIndex = 62;
            AddToOrderButton.Text = "Add to Order";
            AddToOrderButton.UseVisualStyleBackColor = true;
            AddToOrderButton.Click += AddToOrderButton_Click;
            // 
            // OrderGridView
            // 
            OrderGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OrderGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderGridView.Location = new Point(328, 493);
            OrderGridView.Name = "OrderGridView";
            OrderGridView.RowHeadersWidth = 51;
            OrderGridView.RowTemplate.Height = 29;
            OrderGridView.Size = new Size(842, 252);
            OrderGridView.TabIndex = 63;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(745, 448);
            label9.Name = "label9";
            label9.Size = new Size(164, 35);
            label9.TabIndex = 64;
            label9.Text = "Total Amount";
            // 
            // TotalAmountLabel
            // 
            TotalAmountLabel.AutoSize = true;
            TotalAmountLabel.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TotalAmountLabel.Location = new Point(915, 451);
            TotalAmountLabel.Name = "TotalAmountLabel";
            TotalAmountLabel.Size = new Size(164, 35);
            TotalAmountLabel.TabIndex = 65;
            TotalAmountLabel.Text = "Total Amount";
            // 
            // InsertOrderButton
            // 
            InsertOrderButton.Location = new Point(22, 702);
            InsertOrderButton.Name = "InsertOrderButton";
            InsertOrderButton.Size = new Size(123, 29);
            InsertOrderButton.TabIndex = 66;
            InsertOrderButton.Text = "Insert Order";
            InsertOrderButton.UseVisualStyleBackColor = true;
            InsertOrderButton.Click += InsertOrderButton_Click;
            // 
            // ViewOrdersButton
            // 
            ViewOrdersButton.Location = new Point(151, 702);
            ViewOrdersButton.Name = "ViewOrdersButton";
            ViewOrdersButton.Size = new Size(123, 29);
            ViewOrdersButton.TabIndex = 67;
            ViewOrdersButton.Text = "View Orders";
            ViewOrdersButton.UseVisualStyleBackColor = true;
            ViewOrdersButton.Click += ViewOrdersButton_Click;
            // 
            // HomeButton
            // 
            HomeButton.Location = new Point(1076, 123);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(94, 29);
            HomeButton.TabIndex = 68;
            HomeButton.Text = "Home";
            HomeButton.UseVisualStyleBackColor = true;
            HomeButton.Click += HomeButton_Click;
            // 
            // ManageOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 753);
            Controls.Add(HomeButton);
            Controls.Add(ViewOrdersButton);
            Controls.Add(InsertOrderButton);
            Controls.Add(TotalAmountLabel);
            Controls.Add(label9);
            Controls.Add(OrderGridView);
            Controls.Add(AddToOrderButton);
            Controls.Add(QuantityTextBox);
            Controls.Add(label8);
            Controls.Add(CustomerNameTextBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(SearchComboBox);
            Controls.Add(ProductGridView);
            Controls.Add(OrderDate);
            Controls.Add(CustomerIDTextBox);
            Controls.Add(OrderIDTextBox);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(CustomerGridView);
            Controls.Add(label4);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ManageOrders";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ManageOrders";
            Load += ManageOrders_Load;
            ((System.ComponentModel.ISupportInitialize)CustomerGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrderGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label5;
        private DataGridView CustomerGridView;
        private Label label1;
        private TextBox CustomerIDTextBox;
        private TextBox OrderIDTextBox;
        private Label label2;
        private Label label3;
        private DateTimePicker OrderDate;
        private ComboBox SearchComboBox;
        private DataGridView ProductGridView;
        private Label label6;
        private TextBox CustomerNameTextBox;
        private Label label7;
        private Label label8;
        private TextBox QuantityTextBox;
        private Button AddToOrderButton;
        private DataGridView OrderGridView;
        private Label label9;
        private Label TotalAmountLabel;
        private Button InsertOrderButton;
        private Button ViewOrdersButton;
        private Button HomeButton;
    }
}