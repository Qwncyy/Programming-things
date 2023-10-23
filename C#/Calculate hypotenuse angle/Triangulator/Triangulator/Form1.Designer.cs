namespace Triangulator
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
            this.txtHypotenuse = new System.Windows.Forms.TextBox();
            this.lblHypotenuse = new System.Windows.Forms.Label();
            this.btnCalculateHypotenuse = new System.Windows.Forms.Button();
            this.txtShortSide2 = new System.Windows.Forms.TextBox();
            this.lblShortSide2 = new System.Windows.Forms.Label();
            this.txtShortSide1 = new System.Windows.Forms.TextBox();
            this.lblShortSide1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHypotenuse
            // 
            this.txtHypotenuse.Location = new System.Drawing.Point(25, 273);
            this.txtHypotenuse.Name = "txtHypotenuse";
            this.txtHypotenuse.Size = new System.Drawing.Size(106, 20);
            this.txtHypotenuse.TabIndex = 13;
            this.txtHypotenuse.TextChanged += new System.EventHandler(this.txtHypotenuse_TextChanged);
            // 
            // lblHypotenuse
            // 
            this.lblHypotenuse.AutoSize = true;
            this.lblHypotenuse.Location = new System.Drawing.Point(24, 241);
            this.lblHypotenuse.Name = "lblHypotenuse";
            this.lblHypotenuse.Size = new System.Drawing.Size(64, 13);
            this.lblHypotenuse.TabIndex = 12;
            this.lblHypotenuse.Text = "Hypotenuse";
            // 
            // btnCalculateHypotenuse
            // 
            this.btnCalculateHypotenuse.Location = new System.Drawing.Point(25, 186);
            this.btnCalculateHypotenuse.Name = "btnCalculateHypotenuse";
            this.btnCalculateHypotenuse.Size = new System.Drawing.Size(107, 29);
            this.btnCalculateHypotenuse.TabIndex = 11;
            this.btnCalculateHypotenuse.Text = "Calculate";
            this.btnCalculateHypotenuse.UseVisualStyleBackColor = true;
            this.btnCalculateHypotenuse.Click += new System.EventHandler(this.btnCalculateHypotenuse_Click);
            // 
            // txtShortSide2
            // 
            this.txtShortSide2.Location = new System.Drawing.Point(25, 113);
            this.txtShortSide2.Name = "txtShortSide2";
            this.txtShortSide2.Size = new System.Drawing.Size(106, 20);
            this.txtShortSide2.TabIndex = 10;
            this.txtShortSide2.TextChanged += new System.EventHandler(this.txtShortSide2_TextChanged);
            // 
            // lblShortSide2
            // 
            this.lblShortSide2.AutoSize = true;
            this.lblShortSide2.Location = new System.Drawing.Point(22, 86);
            this.lblShortSide2.Name = "lblShortSide2";
            this.lblShortSide2.Size = new System.Drawing.Size(37, 13);
            this.lblShortSide2.TabIndex = 9;
            this.lblShortSide2.Text = "Side 2";
            // 
            // txtShortSide1
            // 
            this.txtShortSide1.Location = new System.Drawing.Point(25, 42);
            this.txtShortSide1.Name = "txtShortSide1";
            this.txtShortSide1.Size = new System.Drawing.Size(107, 20);
            this.txtShortSide1.TabIndex = 8;
            this.txtShortSide1.TextChanged += new System.EventHandler(this.txtShortSide1_TextChanged);
            // 
            // lblShortSide1
            // 
            this.lblShortSide1.AutoSize = true;
            this.lblShortSide1.Location = new System.Drawing.Point(22, 13);
            this.lblShortSide1.Name = "lblShortSide1";
            this.lblShortSide1.Size = new System.Drawing.Size(37, 13);
            this.lblShortSide1.TabIndex = 7;
            this.lblShortSide1.Text = "Side 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHypotenuse);
            this.Controls.Add(this.lblHypotenuse);
            this.Controls.Add(this.btnCalculateHypotenuse);
            this.Controls.Add(this.txtShortSide2);
            this.Controls.Add(this.lblShortSide2);
            this.Controls.Add(this.txtShortSide1);
            this.Controls.Add(this.lblShortSide1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHypotenuse;
        private System.Windows.Forms.Label lblHypotenuse;
        private System.Windows.Forms.Button btnCalculateHypotenuse;
        private System.Windows.Forms.TextBox txtShortSide2;
        private System.Windows.Forms.Label lblShortSide2;
        private System.Windows.Forms.TextBox txtShortSide1;
        private System.Windows.Forms.Label lblShortSide1;
    }
}

