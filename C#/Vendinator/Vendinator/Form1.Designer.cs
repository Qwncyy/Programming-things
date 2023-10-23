namespace Vendinator
{
    partial class Form1
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnStockChocolate = new System.Windows.Forms.Button();
            this.btnStockCrisps = new System.Windows.Forms.Button();
            this.btnStockWater = new System.Windows.Forms.Button();
            this.btnBuyChocolate = new System.Windows.Forms.Button();
            this.btnBuyCrisps = new System.Windows.Forms.Button();
            this.btnBuyWater = new System.Windows.Forms.Button();
            this.btnViewStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(31, 27);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(35, 13);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "label1";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(33, 56);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(136, 20);
            this.txtAmount.TabIndex = 1;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // btnStockChocolate
            // 
            this.btnStockChocolate.Location = new System.Drawing.Point(34, 129);
            this.btnStockChocolate.Name = "btnStockChocolate";
            this.btnStockChocolate.Size = new System.Drawing.Size(134, 38);
            this.btnStockChocolate.TabIndex = 2;
            this.btnStockChocolate.Text = "Stock Chocolate";
            this.btnStockChocolate.UseVisualStyleBackColor = true;
            this.btnStockChocolate.Click += new System.EventHandler(this.btnStockChocolate_Click);
            // 
            // btnStockCrisps
            // 
            this.btnStockCrisps.Location = new System.Drawing.Point(33, 173);
            this.btnStockCrisps.Name = "btnStockCrisps";
            this.btnStockCrisps.Size = new System.Drawing.Size(134, 38);
            this.btnStockCrisps.TabIndex = 3;
            this.btnStockCrisps.Text = "Stock Crisps";
            this.btnStockCrisps.UseVisualStyleBackColor = true;
            this.btnStockCrisps.Click += new System.EventHandler(this.btnStockCrisps_Click);
            // 
            // btnStockWater
            // 
            this.btnStockWater.Location = new System.Drawing.Point(35, 217);
            this.btnStockWater.Name = "btnStockWater";
            this.btnStockWater.Size = new System.Drawing.Size(134, 38);
            this.btnStockWater.TabIndex = 4;
            this.btnStockWater.Text = "Stock Water";
            this.btnStockWater.UseVisualStyleBackColor = true;
            this.btnStockWater.Click += new System.EventHandler(this.btnStockWater_Click);
            // 
            // btnBuyChocolate
            // 
            this.btnBuyChocolate.Location = new System.Drawing.Point(298, 46);
            this.btnBuyChocolate.Name = "btnBuyChocolate";
            this.btnBuyChocolate.Size = new System.Drawing.Size(134, 38);
            this.btnBuyChocolate.TabIndex = 5;
            this.btnBuyChocolate.Text = "Buy Chocolate";
            this.btnBuyChocolate.UseVisualStyleBackColor = true;
            this.btnBuyChocolate.Click += new System.EventHandler(this.btnBuyChocolate_Click);
            // 
            // btnBuyCrisps
            // 
            this.btnBuyCrisps.Location = new System.Drawing.Point(438, 46);
            this.btnBuyCrisps.Name = "btnBuyCrisps";
            this.btnBuyCrisps.Size = new System.Drawing.Size(134, 38);
            this.btnBuyCrisps.TabIndex = 6;
            this.btnBuyCrisps.Text = "Buy Crisps";
            this.btnBuyCrisps.UseVisualStyleBackColor = true;
            this.btnBuyCrisps.Click += new System.EventHandler(this.btnBuyCrisps_Click);
            // 
            // btnBuyWater
            // 
            this.btnBuyWater.Location = new System.Drawing.Point(578, 46);
            this.btnBuyWater.Name = "btnBuyWater";
            this.btnBuyWater.Size = new System.Drawing.Size(134, 38);
            this.btnBuyWater.TabIndex = 7;
            this.btnBuyWater.Text = "Buy Water";
            this.btnBuyWater.UseVisualStyleBackColor = true;
            this.btnBuyWater.Click += new System.EventHandler(this.btnBuyWater_Click);
            // 
            // btnViewStock
            // 
            this.btnViewStock.Location = new System.Drawing.Point(578, 217);
            this.btnViewStock.Name = "btnViewStock";
            this.btnViewStock.Size = new System.Drawing.Size(134, 38);
            this.btnViewStock.TabIndex = 8;
            this.btnViewStock.Text = "View Stock";
            this.btnViewStock.UseVisualStyleBackColor = true;
            this.btnViewStock.Click += new System.EventHandler(this.btnViewStock_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewStock);
            this.Controls.Add(this.btnBuyWater);
            this.Controls.Add(this.btnBuyCrisps);
            this.Controls.Add(this.btnBuyChocolate);
            this.Controls.Add(this.btnStockWater);
            this.Controls.Add(this.btnStockCrisps);
            this.Controls.Add(this.btnStockChocolate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnStockChocolate;
        private System.Windows.Forms.Button btnStockCrisps;
        private System.Windows.Forms.Button btnStockWater;
        private System.Windows.Forms.Button btnBuyChocolate;
        private System.Windows.Forms.Button btnBuyCrisps;
        private System.Windows.Forms.Button btnBuyWater;
        private System.Windows.Forms.Button btnViewStock;
    }
}

