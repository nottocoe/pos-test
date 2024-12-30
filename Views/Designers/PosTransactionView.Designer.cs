namespace PosApp.Views
{
    partial class PosTransactionView
    {
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.DataGridView dgvTransactionItems;
        private System.Windows.Forms.Label lblSummaryItems;
        private System.Windows.Forms.Label lblSummaryPieces;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Panel panelSummary;

        private void InitializeComponent()
        {
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.dgvTransactionItems = new System.Windows.Forms.DataGridView();
            this.lblSummaryItems = new System.Windows.Forms.Label();
            this.lblSummaryPieces = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.panelSummary = new System.Windows.Forms.Panel();

            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionItems)).BeginInit();
            this.SuspendLayout();

            // txtBarcode
            this.txtBarcode.Location = new System.Drawing.Point(12, 400);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(180, 20);
            this.txtBarcode.TabIndex = 0;
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            this.txtBarcode.Dock = DockStyle.Bottom;

            // dgvTransactionItems
            this.dgvTransactionItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransactionItems.Location = new System.Drawing.Point(12, 50);
            this.dgvTransactionItems.Name = "dgvTransactionItems";
            this.dgvTransactionItems.Size = new System.Drawing.Size(600, 300);
            this.dgvTransactionItems.TabIndex = 1;
            this.dgvTransactionItems.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10.5F);

            // panelSummary
            this.panelSummary.Location = new System.Drawing.Point(620, 50);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(200, 300);
            this.panelSummary.TabIndex = 2;

            // lblSummaryItems
            this.lblSummaryItems.AutoSize = true;
            this.lblSummaryItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryItems.Location = new System.Drawing.Point(10, 10);
            this.lblSummaryItems.Name = "lblSummaryItems";
            this.lblSummaryItems.Size = new System.Drawing.Size(70, 13);
            this.lblSummaryItems.Text = "รวมรายการ: 0";

            // lblSummaryPieces
            this.lblSummaryPieces.AutoSize = true;
            this.lblSummaryPieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryPieces.Location = new System.Drawing.Point(10, 40);
            this.lblSummaryPieces.Name = "lblSummaryPieces";
            this.lblSummaryPieces.Size = new System.Drawing.Size(60, 13);
            this.lblSummaryPieces.Text = "รวมชิ้น: 0";

            // lblTotalAmount
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(10, 70);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(80, 13);
            this.lblTotalAmount.Text = "ยอดรวม: 0.00";

            // btnCheckout
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(50, 100);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(100, 30);
            this.btnCheckout.TabIndex = 4;
            this.btnCheckout.Text = "ชำระเงิน";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);

            // เพิ่ม Controls ลงใน Panel
            this.panelSummary.Controls.Add(this.lblSummaryItems);
            this.panelSummary.Controls.Add(this.lblSummaryPieces);
            this.panelSummary.Controls.Add(this.lblTotalAmount);
            this.panelSummary.Controls.Add(this.btnCheckout);

            // PosTransactionView
            this.ClientSize = new System.Drawing.Size(824, 400);
            this.Controls.Add(this.txtBarcode);
            this.Controls.Add(this.dgvTransactionItems);
            this.Controls.Add(this.panelSummary);
            this.Name = "PosTransactionView";
            this.Text = "ระบบ POS ขายหน้าร้าน";

            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactionItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}