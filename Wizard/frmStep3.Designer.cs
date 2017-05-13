namespace Wizard
{
    partial class frmStep3
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxChess = new System.Windows.Forms.CheckBox();
            this.checkBoxBasketBll = new System.Windows.Forms.CheckBox();
            this.checkBoxReading = new System.Windows.Forms.CheckBox();
            this.checkBoxShopping = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hobby :";
            // 
            // checkBoxChess
            // 
            this.checkBoxChess.AutoSize = true;
            this.checkBoxChess.Location = new System.Drawing.Point(263, 71);
            this.checkBoxChess.Name = "checkBoxChess";
            this.checkBoxChess.Size = new System.Drawing.Size(54, 16);
            this.checkBoxChess.TabIndex = 2;
            this.checkBoxChess.Text = "Chess";
            this.checkBoxChess.UseVisualStyleBackColor = true;
            // 
            // checkBoxBasketBll
            // 
            this.checkBoxBasketBll.AutoSize = true;
            this.checkBoxBasketBll.Location = new System.Drawing.Point(263, 120);
            this.checkBoxBasketBll.Name = "checkBoxBasketBll";
            this.checkBoxBasketBll.Size = new System.Drawing.Size(84, 16);
            this.checkBoxBasketBll.TabIndex = 2;
            this.checkBoxBasketBll.Text = "BasketBall";
            this.checkBoxBasketBll.UseVisualStyleBackColor = true;
            // 
            // checkBoxReading
            // 
            this.checkBoxReading.AutoSize = true;
            this.checkBoxReading.Location = new System.Drawing.Point(263, 169);
            this.checkBoxReading.Name = "checkBoxReading";
            this.checkBoxReading.Size = new System.Drawing.Size(66, 16);
            this.checkBoxReading.TabIndex = 2;
            this.checkBoxReading.Text = "Reading";
            this.checkBoxReading.UseVisualStyleBackColor = true;
            // 
            // checkBoxShopping
            // 
            this.checkBoxShopping.AutoSize = true;
            this.checkBoxShopping.Location = new System.Drawing.Point(263, 218);
            this.checkBoxShopping.Name = "checkBoxShopping";
            this.checkBoxShopping.Size = new System.Drawing.Size(72, 16);
            this.checkBoxShopping.TabIndex = 2;
            this.checkBoxShopping.Text = "Shopping";
            this.checkBoxShopping.UseVisualStyleBackColor = true;
            // 
            // frmStep3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.checkBoxShopping);
            this.Controls.Add(this.checkBoxReading);
            this.Controls.Add(this.checkBoxBasketBll);
            this.Controls.Add(this.checkBoxChess);
            this.Controls.Add(this.label1);
            this.Name = "frmStep3";
            this.Text = "frmStep3";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.checkBoxChess, 0);
            this.Controls.SetChildIndex(this.checkBoxBasketBll, 0);
            this.Controls.SetChildIndex(this.checkBoxReading, 0);
            this.Controls.SetChildIndex(this.checkBoxShopping, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxChess;
        private System.Windows.Forms.CheckBox checkBoxBasketBll;
        private System.Windows.Forms.CheckBox checkBoxReading;
        private System.Windows.Forms.CheckBox checkBoxShopping;
    }
}