namespace Pizza_Order
{
    partial class OrderInvoiceForm
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
            this.SubTotalListView = new System.Windows.Forms.ListView();
            this.Pizza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PriceHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.PizzaPrice = new System.Windows.Forms.Label();
            this.taxPriceLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ConfirmOrder = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SubTotalListView
            // 
            this.SubTotalListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Pizza,
            this.PriceHeader});
            this.SubTotalListView.Location = new System.Drawing.Point(29, 62);
            this.SubTotalListView.Name = "SubTotalListView";
            this.SubTotalListView.Size = new System.Drawing.Size(454, 330);
            this.SubTotalListView.TabIndex = 0;
            this.SubTotalListView.UseCompatibleStateImageBehavior = false;
            this.SubTotalListView.View = System.Windows.Forms.View.Details;
            // 
            // Pizza
            // 
            this.Pizza.Text = "Pizza";
            this.Pizza.Width = 350;
            // 
            // PriceHeader
            // 
            this.PriceHeader.Text = "Price";
            this.PriceHeader.Width = 350;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(489, 151);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(53, 13);
            this.TotalLabel.TabIndex = 1;
            this.TotalLabel.Text = "Sub Total";
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Location = new System.Drawing.Point(498, 178);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(34, 13);
            this.TaxLabel.TabIndex = 2;
            this.TaxLabel.Text = "+ Tax";
            // 
            // PizzaPrice
            // 
            this.PizzaPrice.AutoSize = true;
            this.PizzaPrice.Location = new System.Drawing.Point(594, 151);
            this.PizzaPrice.Name = "PizzaPrice";
            this.PizzaPrice.Size = new System.Drawing.Size(34, 13);
            this.PizzaPrice.TabIndex = 3;
            this.PizzaPrice.Text = "$0.00";
            // 
            // taxPriceLabel
            // 
            this.taxPriceLabel.AutoSize = true;
            this.taxPriceLabel.Location = new System.Drawing.Point(594, 178);
            this.taxPriceLabel.Name = "taxPriceLabel";
            this.taxPriceLabel.Size = new System.Drawing.Size(34, 13);
            this.taxPriceLabel.TabIndex = 4;
            this.taxPriceLabel.Text = "$0.00";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(498, 221);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(36, 13);
            this.totalPriceLabel.TabIndex = 5;
            this.totalPriceLabel.Text = "Total";
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.BackColor = System.Drawing.Color.Lavender;
            this.TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPrice.Location = new System.Drawing.Point(594, 221);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(39, 13);
            this.TotalPrice.TabIndex = 6;
            this.TotalPrice.Text = "$0.00";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(12, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ConfirmOrder
            // 
            this.ConfirmOrder.Location = new System.Drawing.Point(188, 414);
            this.ConfirmOrder.Name = "ConfirmOrder";
            this.ConfirmOrder.Size = new System.Drawing.Size(124, 23);
            this.ConfirmOrder.TabIndex = 8;
            this.ConfirmOrder.Text = "Confirm Order";
            this.ConfirmOrder.UseVisualStyleBackColor = true;
            this.ConfirmOrder.Click += new System.EventHandler(this.ConfirmOrder_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.Location = new System.Drawing.Point(45, 39);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(421, 20);
            this.MessageLabel.TabIndex = 9;
            this.MessageLabel.Text = "Please click the Confirm Order button to see the final price!";
            // 
            // OrderInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 462);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.ConfirmOrder);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SubTotalListView);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.taxPriceLabel);
            this.Controls.Add(this.PizzaPrice);
            this.Controls.Add(this.TaxLabel);
            this.Controls.Add(this.TotalLabel);
            this.Name = "OrderInvoiceForm";
            this.Text = "OrderInvoiceForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColumnHeader Pizza;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label PizzaPrice;
        private System.Windows.Forms.Label taxPriceLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label TotalPrice;
        public System.Windows.Forms.ListView SubTotalListView;
        private System.Windows.Forms.ColumnHeader PriceHeader;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ConfirmOrder;
        private System.Windows.Forms.Label MessageLabel;
    }
}