namespace CemBags2
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
            this.txtNameInput = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnNameInput = new System.Windows.Forms.Button();
            this.txtNumBagsInput = new System.Windows.Forms.TextBox();
            this.lblCmntBags = new System.Windows.Forms.Label();
            this.btnCalculateBagPrice = new System.Windows.Forms.Button();
            this.txtShowPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNameInput
            // 
            this.txtNameInput.Location = new System.Drawing.Point(42, 111);
            this.txtNameInput.Name = "txtNameInput";
            this.txtNameInput.Size = new System.Drawing.Size(243, 20);
            this.txtNameInput.TabIndex = 0;
            this.txtNameInput.TextChanged += new System.EventHandler(this.txtNameInput_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(50, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // btnNameInput
            // 
            this.btnNameInput.Location = new System.Drawing.Point(58, 157);
            this.btnNameInput.Name = "btnNameInput";
            this.btnNameInput.Size = new System.Drawing.Size(168, 23);
            this.btnNameInput.TabIndex = 2;
            this.btnNameInput.Text = "Confirm";
            this.btnNameInput.UseVisualStyleBackColor = true;
            this.btnNameInput.Click += new System.EventHandler(this.btnNameInput_Click);
            // 
            // txtNumBagsInput
            // 
            this.txtNumBagsInput.Location = new System.Drawing.Point(48, 258);
            this.txtNumBagsInput.Name = "txtNumBagsInput";
            this.txtNumBagsInput.Size = new System.Drawing.Size(293, 20);
            this.txtNumBagsInput.TabIndex = 3;
            this.txtNumBagsInput.TextChanged += new System.EventHandler(this.txtNumBagsInput_TextChanged);
            // 
            // lblCmntBags
            // 
            this.lblCmntBags.AutoSize = true;
            this.lblCmntBags.Location = new System.Drawing.Point(48, 232);
            this.lblCmntBags.Name = "lblCmntBags";
            this.lblCmntBags.Size = new System.Drawing.Size(108, 13);
            this.lblCmntBags.TabIndex = 4;
            this.lblCmntBags.Text = "Num. of cement bags";
            // 
            // btnCalculateBagPrice
            // 
            this.btnCalculateBagPrice.Location = new System.Drawing.Point(59, 293);
            this.btnCalculateBagPrice.Name = "btnCalculateBagPrice";
            this.btnCalculateBagPrice.Size = new System.Drawing.Size(96, 32);
            this.btnCalculateBagPrice.TabIndex = 5;
            this.btnCalculateBagPrice.Text = "Price";
            this.btnCalculateBagPrice.UseVisualStyleBackColor = true;
            this.btnCalculateBagPrice.Click += new System.EventHandler(this.btnCalculateBagPrice_Click);
            // 
            // txtShowPrice
            // 
            this.txtShowPrice.Location = new System.Drawing.Point(43, 340);
            this.txtShowPrice.Multiline = true;
            this.txtShowPrice.Name = "txtShowPrice";
            this.txtShowPrice.Size = new System.Drawing.Size(339, 20);
            this.txtShowPrice.TabIndex = 6;
            this.txtShowPrice.TextChanged += new System.EventHandler(this.txtShowPrice_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtShowPrice);
            this.Controls.Add(this.btnCalculateBagPrice);
            this.Controls.Add(this.lblCmntBags);
            this.Controls.Add(this.txtNumBagsInput);
            this.Controls.Add(this.btnNameInput);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtNameInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNameInput;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnNameInput;
        private System.Windows.Forms.TextBox txtNumBagsInput;
        private System.Windows.Forms.Label lblCmntBags;
        private System.Windows.Forms.Button btnCalculateBagPrice;
        private System.Windows.Forms.TextBox txtShowPrice;
    }
}

