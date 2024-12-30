namespace PosApp.Views
{
    partial class CheckStocksView
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewStocks;

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
            this.dataGridViewStocks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStocks)).BeginInit();
            this.SuspendLayout();

            this.dataGridViewStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStocks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStocks.Location = new System.Drawing.Point(0, 0); // Removed padding for full flexibility
            this.dataGridViewStocks.Name = "dataGridViewStocks";
            this.dataGridViewStocks.Size = new System.Drawing.Size(800, 450);
            this.dataGridViewStocks.TabIndex = 0;

            // Enable column auto-sizing
            this.dataGridViewStocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // Optional: Enable row headers to adjust automatically
            this.dataGridViewStocks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewStocks);
            this.Name = "CheckStocksView";
            this.Text = "ตรวจสอบสต็อก";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStocks)).EndInit();
            this.ResumeLayout(false);
        }

    }
}
