namespace PosApp.Views
{
    partial class PaymentDialog
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTotalAmount;
        private TextBox txtPaymentAmount;
        private Button btnConfirm;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtPaymentAmount = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTotalAmount
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(20, 20);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(80, 15);
            this.lblTotalAmount.TabIndex = 0;
            this.lblTotalAmount.Text = "ยอดรวม: 0.00";

            // txtPaymentAmount
            this.txtPaymentAmount.Location = new System.Drawing.Point(20, 50);
            this.txtPaymentAmount.Name = "txtPaymentAmount";
            this.txtPaymentAmount.Size = new System.Drawing.Size(200, 23);
            this.txtPaymentAmount.TabIndex = 1;

            // btnConfirm
            this.btnConfirm.Location = new System.Drawing.Point(20, 90);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(90, 30);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "ยืนยัน";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(130, 90);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "ยกเลิก";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // PaymentDialog
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 140);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.txtPaymentAmount);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Name = "PaymentDialog";
            this.Text = "ชำระเงิน";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
