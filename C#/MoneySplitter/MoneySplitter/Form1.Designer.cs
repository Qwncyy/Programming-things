namespace MoneySplitter
{
    partial class MoneySplitter
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
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.txtNumPppl = new System.Windows.Forms.TextBox();
            this.lblNumPpl = new System.Windows.Forms.Label();
            this.btnSplitMoney = new System.Windows.Forms.Button();
            this.txtMoneySplit = new System.Windows.Forms.TextBox();
            this.lblMoneySplit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMoney
            // 
            this.txtMoney.Location = new System.Drawing.Point(39, 65);
            this.txtMoney.Multiline = true;
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(217, 45);
            this.txtMoney.TabIndex = 0;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Location = new System.Drawing.Point(36, 49);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(39, 13);
            this.lblMoney.TabIndex = 1;
            this.lblMoney.Text = "Money";
            this.lblMoney.Click += new System.EventHandler(this.lblMoney_Click);
            // 
            // txtNumPppl
            // 
            this.txtNumPppl.Location = new System.Drawing.Point(39, 183);
            this.txtNumPppl.Multiline = true;
            this.txtNumPppl.Name = "txtNumPppl";
            this.txtNumPppl.Size = new System.Drawing.Size(217, 43);
            this.txtNumPppl.TabIndex = 2;
            // 
            // lblNumPpl
            // 
            this.lblNumPpl.AutoSize = true;
            this.lblNumPpl.Location = new System.Drawing.Point(43, 167);
            this.lblNumPpl.Name = "lblNumPpl";
            this.lblNumPpl.Size = new System.Drawing.Size(72, 13);
            this.lblNumPpl.TabIndex = 3;
            this.lblNumPpl.Text = "No. of People";
            // 
            // btnSplitMoney
            // 
            this.btnSplitMoney.Location = new System.Drawing.Point(310, 122);
            this.btnSplitMoney.Name = "btnSplitMoney";
            this.btnSplitMoney.Size = new System.Drawing.Size(147, 32);
            this.btnSplitMoney.TabIndex = 4;
            this.btnSplitMoney.Text = "Split money";
            this.btnSplitMoney.UseVisualStyleBackColor = true;
            this.btnSplitMoney.Click += new System.EventHandler(this.btnSplitMoney_Click);
            // 
            // txtMoneySplit
            // 
            this.txtMoneySplit.Location = new System.Drawing.Point(510, 116);
            this.txtMoneySplit.Multiline = true;
            this.txtMoneySplit.Name = "txtMoneySplit";
            this.txtMoneySplit.Size = new System.Drawing.Size(252, 81);
            this.txtMoneySplit.TabIndex = 5;
            // 
            // lblMoneySplit
            // 
            this.lblMoneySplit.AutoSize = true;
            this.lblMoneySplit.Location = new System.Drawing.Point(507, 100);
            this.lblMoneySplit.Name = "lblMoneySplit";
            this.lblMoneySplit.Size = new System.Drawing.Size(62, 13);
            this.lblMoneySplit.TabIndex = 6;
            this.lblMoneySplit.Text = "Money Split";
            // 
            // MoneySplitter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMoneySplit);
            this.Controls.Add(this.txtMoneySplit);
            this.Controls.Add(this.btnSplitMoney);
            this.Controls.Add(this.lblNumPpl);
            this.Controls.Add(this.txtNumPppl);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.txtMoney);
            this.Name = "MoneySplitter";
            this.Text = "Money Splitter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.TextBox txtNumPppl;
        private System.Windows.Forms.Label lblNumPpl;
        private System.Windows.Forms.Button btnSplitMoney;
        private System.Windows.Forms.TextBox txtMoneySplit;
        private System.Windows.Forms.Label lblMoneySplit;
    }
}

