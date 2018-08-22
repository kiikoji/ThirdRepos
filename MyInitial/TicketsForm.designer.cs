namespace Ticketing
{
    partial class TicketsForm
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
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.chkDiscount = new System.Windows.Forms.CheckBox();
            this.radBalcony = new System.Windows.Forms.RadioButton();
            this.radGeneral = new System.Windows.Forms.RadioButton();
            this.radBox = new System.Windows.Forms.RadioButton();
            this.grpSection = new System.Windows.Forms.GroupBox();
            this.cmdCalculate = new System.Windows.Forms.Button();
            this.radBack = new System.Windows.Forms.RadioButton();
            this.chkDiscount2 = new System.Windows.Forms.CheckBox();
            this.grpSection.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(48, 44);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(45, 12);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(111, 44);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(91, 22);
            this.txtQuantity.TabIndex = 1;
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Location = new System.Drawing.Point(244, 44);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(65, 12);
            this.lblAmountDue.TabIndex = 2;
            this.lblAmountDue.Text = "Amount Due";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(327, 49);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(0, 12);
            this.lblAmount.TabIndex = 3;
            // 
            // chkDiscount
            // 
            this.chkDiscount.AutoSize = true;
            this.chkDiscount.Location = new System.Drawing.Point(111, 88);
            this.chkDiscount.Name = "chkDiscount";
            this.chkDiscount.Size = new System.Drawing.Size(98, 16);
            this.chkDiscount.TabIndex = 5;
            this.chkDiscount.Text = "Senior / Student";
            this.chkDiscount.UseVisualStyleBackColor = true;
            this.chkDiscount.CheckedChanged += new System.EventHandler(this.chkDiscount_CheckedChanged);
            // 
            // radBalcony
            // 
            this.radBalcony.AutoSize = true;
            this.radBalcony.Location = new System.Drawing.Point(26, 16);
            this.radBalcony.Name = "radBalcony";
            this.radBalcony.Size = new System.Drawing.Size(62, 16);
            this.radBalcony.TabIndex = 6;
            this.radBalcony.Text = "Balcony";
            this.radBalcony.UseVisualStyleBackColor = true;
            // 
            // radGeneral
            // 
            this.radGeneral.AutoSize = true;
            this.radGeneral.Checked = true;
            this.radGeneral.Location = new System.Drawing.Point(26, 37);
            this.radGeneral.Name = "radGeneral";
            this.radGeneral.Size = new System.Drawing.Size(59, 16);
            this.radGeneral.TabIndex = 7;
            this.radGeneral.TabStop = true;
            this.radGeneral.Text = "General";
            this.radGeneral.UseVisualStyleBackColor = true;
            // 
            // radBox
            // 
            this.radBox.AutoSize = true;
            this.radBox.Location = new System.Drawing.Point(26, 58);
            this.radBox.Name = "radBox";
            this.radBox.Size = new System.Drawing.Size(69, 16);
            this.radBox.TabIndex = 8;
            this.radBox.Text = "Box Seats";
            this.radBox.UseVisualStyleBackColor = true;
            // 
            // grpSection
            // 
            this.grpSection.Controls.Add(this.radBack);
            this.grpSection.Controls.Add(this.radBox);
            this.grpSection.Controls.Add(this.radGeneral);
            this.grpSection.Controls.Add(this.radBalcony);
            this.grpSection.Location = new System.Drawing.Point(52, 130);
            this.grpSection.Name = "grpSection";
            this.grpSection.Size = new System.Drawing.Size(139, 102);
            this.grpSection.TabIndex = 9;
            this.grpSection.TabStop = false;
            this.grpSection.Text = "Section";
            // 
            // cmdCalculate
            // 
            this.cmdCalculate.Location = new System.Drawing.Point(294, 247);
            this.cmdCalculate.Name = "cmdCalculate";
            this.cmdCalculate.Size = new System.Drawing.Size(108, 32);
            this.cmdCalculate.TabIndex = 10;
            this.cmdCalculate.Text = "Calculate";
            this.cmdCalculate.UseVisualStyleBackColor = true;
            this.cmdCalculate.Click += new System.EventHandler(this.cmdCalculate_Click);
            // 
            // radBack
            // 
            this.radBack.AutoSize = true;
            this.radBack.Location = new System.Drawing.Point(26, 80);
            this.radBack.Name = "radBack";
            this.radBack.Size = new System.Drawing.Size(70, 16);
            this.radBack.TabIndex = 9;
            this.radBack.TabStop = true;
            this.radBack.Text = "Back Stall";
            this.radBack.UseVisualStyleBackColor = true;
            // 
            // chkDiscount2
            // 
            this.chkDiscount2.AutoSize = true;
            this.chkDiscount2.Location = new System.Drawing.Point(231, 87);
            this.chkDiscount2.Name = "chkDiscount2";
            this.chkDiscount2.Size = new System.Drawing.Size(50, 16);
            this.chkDiscount2.TabIndex = 11;
            this.chkDiscount2.Text = "Child";
            this.chkDiscount2.UseVisualStyleBackColor = true;
            this.chkDiscount2.CheckedChanged += new System.EventHandler(this.chkDiscount2_CheckedChanged);
            // 
            // TicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 411);
            this.ClientSize = new System.Drawing.Size(608, 411);
            this.Controls.Add(this.chkDiscount2);
            this.Controls.Add(this.cmdCalculate);
            this.Controls.Add(this.grpSection);
            this.Controls.Add(this.chkDiscount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblAmountDue);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Name = "TicketsForm";
            this.Text = "Theater Ticket Purchase";
            this.Load += new System.EventHandler(this.TicketsForm_Load);
            this.grpSection.ResumeLayout(false);
            this.grpSection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.CheckBox chkDiscount;
        private System.Windows.Forms.RadioButton radBalcony;
        private System.Windows.Forms.RadioButton radGeneral;
        private System.Windows.Forms.RadioButton radBox;
        private System.Windows.Forms.GroupBox grpSection;
        private System.Windows.Forms.Button cmdCalculate;
        private System.Windows.Forms.RadioButton radBack;
        private System.Windows.Forms.CheckBox chkDiscount2;
    }
}

