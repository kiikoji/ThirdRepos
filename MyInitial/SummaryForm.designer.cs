namespace MyNameSpace
{
    partial class SummaryForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.drinksSoldTextBox = new System.Windows.Forms.TextBox();
            this.numberOrdersTextBox = new System.Windows.Forms.TextBox();
            this.totalSalesTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(181, 149);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "&OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Drinks Sold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Orders";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Sales";
            // 
            // drinksSoldTextBox
            // 
            this.drinksSoldTextBox.Location = new System.Drawing.Point(156, 44);
            this.drinksSoldTextBox.Name = "drinksSoldTextBox";
            this.drinksSoldTextBox.ReadOnly = true;
            this.drinksSoldTextBox.Size = new System.Drawing.Size(100, 20);
            this.drinksSoldTextBox.TabIndex = 4;
            // 
            // numberOrdersTextBox
            // 
            this.numberOrdersTextBox.Location = new System.Drawing.Point(156, 70);
            this.numberOrdersTextBox.Name = "numberOrdersTextBox";
            this.numberOrdersTextBox.ReadOnly = true;
            this.numberOrdersTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberOrdersTextBox.TabIndex = 5;
            // 
            // totalSalesTextBox
            // 
            this.totalSalesTextBox.Location = new System.Drawing.Point(156, 96);
            this.totalSalesTextBox.Name = "totalSalesTextBox";
            this.totalSalesTextBox.ReadOnly = true;
            this.totalSalesTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalSalesTextBox.TabIndex = 6;
            // 
            // SummaryForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 210);
            this.Controls.Add(this.totalSalesTextBox);
            this.Controls.Add(this.numberOrdersTextBox);
            this.Controls.Add(this.drinksSoldTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okButton);
            this.Name = "SummaryForm";
            this.Text = "Juice Bar Sales Summary";
            this.Activated += new System.EventHandler(this.SummaryForm_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numberOrdersTextBox;
        private System.Windows.Forms.TextBox totalSalesTextBox;
        internal System.Windows.Forms.TextBox drinksSoldTextBox;
    }
}