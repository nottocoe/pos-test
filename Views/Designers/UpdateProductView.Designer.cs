namespace PosApp.Views
{
    partial class UpdateProductView
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtSku;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnSave;

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
            this.txtSku = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();

            // 
            // txtSku
            // 
            this.txtSku.Location = new System.Drawing.Point(200, 50); // ปรับให้ตำแหน่งอยู่กึ่งกลาง
            this.txtSku.Size = new System.Drawing.Size(300, 20);

            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(200, 100);
            this.txtName.Size = new System.Drawing.Size(300, 20);

            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(200, 150);
            this.txtPrice.Size = new System.Drawing.Size(300, 20);

            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(200, 200);
            this.txtStock.Size = new System.Drawing.Size(300, 20);

            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(270, 300); // ปรับปุ่มให้อยู่กึ่งกลาง
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.Text = "บันทึก";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // 
            // UpdateProductView
            // 
            this.Controls.Add(this.txtSku);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.btnSave);
            this.Text = "อัปเดตข้อมูลสินค้า";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

    }
}
