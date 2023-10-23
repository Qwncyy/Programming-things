namespace cementBagSale
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
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblNameInput = new System.Windows.Forms.Label();
            this.btnInputName = new System.Windows.Forms.Button();
            this.lblNumCementBags = new System.Windows.Forms.Label();
            this.txtCementNumberInput = new System.Windows.Forms.TextBox();
            this.btnCalculatePrice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(54, 59);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(223, 20);
            this.txtCustomerName.TabIndex = 0;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNameInput
            // 
            this.lblNameInput.AutoSize = true;
            this.lblNameInput.Location = new System.Drawing.Point(60, 43);
            this.lblNameInput.Name = "lblNameInput";
            this.lblNameInput.Size = new System.Drawing.Size(35, 13);
            this.lblNameInput.TabIndex = 1;
            this.lblNameInput.Text = "Name";
            this.lblNameInput.Click += new System.EventHandler(this.txtNameInput_Click);
            // 
            // btnInputName
            // 
            this.btnInputName.Location = new System.Drawing.Point(55, 85);
            this.btnInputName.Name = "btnInputName";
            this.btnInputName.Size = new System.Drawing.Size(222, 25);
            this.btnInputName.TabIndex = 2;
            this.btnInputName.Text = "Confirm Name";
            this.btnInputName.UseVisualStyleBackColor = true;
            this.btnInputName.Click += new System.EventHandler(this.btnInputName_Click);
            // 
            // lblNumCementBags
            // 
            this.lblNumCementBags.AutoSize = true;
            this.lblNumCementBags.Location = new System.Drawing.Point(60, 156);
            this.lblNumCementBags.Name = "lblNumCementBags";
            this.lblNumCementBags.Size = new System.Drawing.Size(100, 13);
            this.lblNumCementBags.TabIndex = 3;
            this.lblNumCementBags.Text = "No. of cement bags";
            // 
            // txtCementNumberInput
            // 
            this.txtCementNumberInput.Location = new System.Drawing.Point(67, 183);
            this.txtCementNumberInput.Name = "txtCementNumberInput";
            this.txtCementNumberInput.Size = new System.Drawing.Size(209, 20);
            this.txtCementNumberInput.TabIndex = 4;
            this.txtCementNumberInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnCalculatePrice
            // 
            this.btnCalculatePrice.Location = new System.Drawing.Point(72, 213);
            this.btnCalculatePrice.Name = "btnCalculatePrice";
            this.btnCalculatePrice.Size = new System.Drawing.Size(204, 26);
            this.btnCalculatePrice.TabIndex = 5;
            this.btnCalculatePrice.Text = "Price";
            this.btnCalculatePrice.UseVisualStyleBackColor = true;
            this.btnCalculatePrice.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 450);
            this.Controls.Add(this.btnCalculatePrice);
            this.Controls.Add(this.txtCementNumberInput);
            this.Controls.Add(this.lblNumCementBags);
            this.Controls.Add(this.btnInputName);
            this.Controls.Add(this.lblNameInput);
            this.Controls.Add(this.txtCustomerName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblNameInput;
        private System.Windows.Forms.Button btnInputName;
        private System.Windows.Forms.Label lblNumCementBags;
        private System.Windows.Forms.TextBox txtCementNumberInput;
        private System.Windows.Forms.Button btnCalculatePrice;
    }
}

