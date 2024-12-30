using System;
using System.Windows.Forms;
using PosApp.Models;
using PosApp.Services;

namespace PosApp.Views
{
    public partial class UpdateProductView : Form
    {
        private readonly ProductService _productService;
        private readonly StockService _stockService;

        public UpdateProductView(ProductService productService, StockService stockService)
        {
            _productService = productService;
            _stockService = stockService;
            InitializeComponent();

            SetFormProperties();
            AdjustButtonSize();
            AddLabelsToForm();

            // Add event handlers to validate inputs
            txtSku.TextChanged += ValidateInputs;
            txtName.TextChanged += ValidateInputs;
            txtPrice.TextChanged += ValidateInputs;
            txtStock.TextChanged += ValidateInputs;

            btnSave.Enabled = false; // Start with the button disabled
        }

        private void SetFormProperties()
        {
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void AdjustButtonSize()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    button.Font = new Font(button.Font.FontFamily, button.Font.Size + 2, FontStyle.Bold);
                    button.AutoSize = true;
                    button.Padding = new Padding(10);
                }
            }
        }

        private void AddLabelsToForm()
        {
            var labelSku = new Label
            {
                Text = "รหัสสินค้า (SKU):",
                Font = new Font(this.Font.FontFamily, 12, FontStyle.Regular),
                Location = new System.Drawing.Point(50, 50),
                AutoSize = true
            };

            var labelName = new Label
            {
                Text = "ชื่อสินค้า:",
                Font = new Font(this.Font.FontFamily, 12, FontStyle.Regular),
                Location = new System.Drawing.Point(50, 100),
                AutoSize = true
            };

            var labelPrice = new Label
            {
                Text = "ราคาสินค้า:",
                Font = new Font(this.Font.FontFamily, 12, FontStyle.Regular),
                Location = new System.Drawing.Point(50, 150),
                AutoSize = true
            };

            var labelStock = new Label
            {
                Text = "จำนวนสินค้าในสต็อก:",
                Font = new Font(this.Font.FontFamily, 12, FontStyle.Regular),
                Location = new System.Drawing.Point(50, 200),
                AutoSize = true
            };

            this.Controls.Add(labelSku);
            this.Controls.Add(labelName);
            this.Controls.Add(labelPrice);
            this.Controls.Add(labelStock);
        }

        private void ValidateInputs(object? sender, EventArgs? e)
        {
            btnSave.Enabled = !string.IsNullOrWhiteSpace(txtSku.Text) &&
                              !string.IsNullOrWhiteSpace(txtName.Text) &&
                              !string.IsNullOrWhiteSpace(txtPrice.Text) &&
                              !string.IsNullOrWhiteSpace(txtStock.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var product = new Product
            {
                Sku = txtSku.Text,
                Name = txtName.Text,
                Price = (double)decimal.Parse(txtPrice.Text)
            };
            _productService.AddOrUpdateProduct(product);

            var stock = new Stock
            {
                Sku = txtSku.Text,
                Quantity = int.Parse(txtStock.Text)
            };
            _stockService.UpdateStock(stock);

            MessageBox.Show("เพิ่ม/อัปเดตสินค้าเรียบร้อยแล้ว", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
