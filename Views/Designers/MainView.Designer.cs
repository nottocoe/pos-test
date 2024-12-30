namespace PosApp.Views
{
    partial class MainView
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnOpenPos;
        private System.Windows.Forms.Button btnCheckStocks; // Added button

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
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnOpenPos = new System.Windows.Forms.Button();
            this.btnCheckStocks = new System.Windows.Forms.Button(); // Initialize button
            this.SuspendLayout();
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(75, 100);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(150, 30);
            this.btnUpdateProduct.TabIndex = 0;
            this.btnUpdateProduct.Text = "แก้ไขข้อมูลสินค้า";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnOpenPos
            // 
            this.btnOpenPos.Location = new System.Drawing.Point(75, 150);
            this.btnOpenPos.Name = "btnOpenPos";
            this.btnOpenPos.Size = new System.Drawing.Size(150, 30);
            this.btnOpenPos.TabIndex = 1;
            this.btnOpenPos.Text = "ระบบ POS ขายหน้าร้าน";
            this.btnOpenPos.UseVisualStyleBackColor = true;
            this.btnOpenPos.Click += new System.EventHandler(this.btnOpenPos_Click);
            // 
            // btnCheckStocks
            // 
            this.btnCheckStocks.Location = new System.Drawing.Point(75, 200);
            this.btnCheckStocks.Name = "btnCheckStocks";
            this.btnCheckStocks.Size = new System.Drawing.Size(150, 30);
            this.btnCheckStocks.TabIndex = 2;
            this.btnCheckStocks.Text = "ตรวจสอบสต็อก";
            this.btnCheckStocks.UseVisualStyleBackColor = true;
            this.btnCheckStocks.Click += new System.EventHandler(this.btnCheckStocks_Click);
            // 
            // MainView
            // 
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.btnCheckStocks);
            this.Controls.Add(this.btnOpenPos);
            this.Controls.Add(this.btnUpdateProduct);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POS System";
            this.ResumeLayout(false);
        }
    }
}
