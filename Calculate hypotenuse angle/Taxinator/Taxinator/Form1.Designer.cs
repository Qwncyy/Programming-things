namespace Taxinator
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
            this.lblSetPrice = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.txtDistanceInput = new System.Windows.Forms.TextBox();
            this.btnDistanceCost = new System.Windows.Forms.Button();
            this.lblPriceOutput = new System.Windows.Forms.Label();
            this.txtPriceOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSetPrice
            // 
            this.lblSetPrice.AutoSize = true;
            this.lblSetPrice.Location = new System.Drawing.Point(29, 46);
            this.lblSetPrice.Name = "lblSetPrice";
            this.lblSetPrice.Size = new System.Drawing.Size(208, 13);
            this.lblSetPrice.TabIndex = 0;
            this.lblSetPrice.Text = "Dr Doffenshmirtz\'s Taxi inator - set price £4";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(29, 102);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(49, 13);
            this.lblDistance.TabIndex = 1;
            this.lblDistance.Text = "Distance";
            // 
            // txtDistanceInput
            // 
            this.txtDistanceInput.Location = new System.Drawing.Point(32, 131);
            this.txtDistanceInput.Name = "txtDistanceInput";
            this.txtDistanceInput.Size = new System.Drawing.Size(194, 20);
            this.txtDistanceInput.TabIndex = 2;
            this.txtDistanceInput.TextChanged += new System.EventHandler(this.txtDistanceInput_TextChanged);
            // 
            // btnDistanceCost
            // 
            this.btnDistanceCost.Location = new System.Drawing.Point(32, 169);
            this.btnDistanceCost.Name = "btnDistanceCost";
            this.btnDistanceCost.Size = new System.Drawing.Size(188, 36);
            this.btnDistanceCost.TabIndex = 3;
            this.btnDistanceCost.Text = "Confirm";
            this.btnDistanceCost.UseVisualStyleBackColor = true;
            this.btnDistanceCost.Click += new System.EventHandler(this.btnDistanceCost_Click);
            // 
            // lblPriceOutput
            // 
            this.lblPriceOutput.AutoSize = true;
            this.lblPriceOutput.Location = new System.Drawing.Point(29, 220);
            this.lblPriceOutput.Name = "lblPriceOutput";
            this.lblPriceOutput.Size = new System.Drawing.Size(31, 13);
            this.lblPriceOutput.TabIndex = 4;
            this.lblPriceOutput.Text = "Price";
            // 
            // txtPriceOutput
            // 
            this.txtPriceOutput.Location = new System.Drawing.Point(32, 250);
            this.txtPriceOutput.Name = "txtPriceOutput";
            this.txtPriceOutput.Size = new System.Drawing.Size(207, 20);
            this.txtPriceOutput.TabIndex = 5;
            this.txtPriceOutput.TextChanged += new System.EventHandler(this.txtPriceOutput_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPriceOutput);
            this.Controls.Add(this.lblPriceOutput);
            this.Controls.Add(this.btnDistanceCost);
            this.Controls.Add(this.txtDistanceInput);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblSetPrice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSetPrice;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TextBox txtDistanceInput;
        private System.Windows.Forms.Button btnDistanceCost;
        private System.Windows.Forms.Label lblPriceOutput;
        private System.Windows.Forms.TextBox txtPriceOutput;
    }
}

