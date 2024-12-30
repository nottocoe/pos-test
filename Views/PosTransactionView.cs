using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PosApp.Models;
using PosApp.Services;

namespace PosApp.Views
{
    public partial class PosTransactionView : Form
    {
        private readonly ProductService _productService;
        private readonly StockService _stockService;
        private readonly List<CartItem> _cartItems = new();

        public PosTransactionView(ProductService productService, StockService stockService)
        {
            _productService = productService ?? throw new ArgumentNullException(nameof(productService));
            _stockService = stockService ?? throw new ArgumentNullException(nameof(stockService));
            InitializeComponent();

            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            dgvTransactionItems.Columns.Add("SkuColumn", "รหัสสินค้า");
            dgvTransactionItems.Columns.Add("NameColumn", "ชื่อสินค้า");
            dgvTransactionItems.Columns.Add("PriceColumn", "ราคา");
            dgvTransactionItems.Columns.Add("QuantityColumn", "จำนวน");
            dgvTransactionItems.Columns.Add("TotalColumn", "รวม");

            dgvTransactionItems.Dock = DockStyle.Fill;
            dgvTransactionItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            panelSummary.Dock = DockStyle.Right;
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string barcode = txtBarcode.Text.Trim();
                if (string.IsNullOrEmpty(barcode))
                {
                    MessageBox.Show("กรุณากรอกรหัสสินค้า!");
                    return;
                }

                var product = _productService.GetProductBySku(barcode);
                if (product == null)
                {
                    MessageBox.Show("ไม่พบสินค้า!");
                    txtBarcode.Clear();
                    return;
                }

                var stock = _stockService.GetStockBySku(barcode);
                if (stock == null || stock.Quantity <= 0)
                {
                    MessageBox.Show("สินค้าหมดในคลัง!");
                    txtBarcode.Clear();
                    return;
                }

                AddToCart(product);
                txtBarcode.Clear();
            }
        }

        private void AddToCart(Product product)
        {
            var existingCartItem = _cartItems.FirstOrDefault(c => c.Product.Sku == product.Sku);
            if (existingCartItem != null)
            {
                existingCartItem.Quantity++;
            }
            else
            {
                _cartItems.Add(new CartItem(product, 1));
            }

            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            dgvTransactionItems.Rows.Clear();
            foreach (var cartItem in _cartItems)
            {
                dgvTransactionItems.Rows.Add(
                    cartItem.Product.Sku,
                    cartItem.Product.Name,
                    cartItem.Product.Price,
                    cartItem.Quantity,
                    cartItem.Quantity * cartItem.Product.Price
                );
            }

            UpdateSummary();
        }

        private void UpdateSummary()
        {
            // รวมรายการ (จำนวนแถวใน DataGridView)
            lblSummaryItems.Text = $"รวมรายการ: {_cartItems.Count}";

            // รวมชิ้น (ผลรวมของ Quantity)
            int totalPieces = _cartItems.Sum(c => c.Quantity);
            lblSummaryPieces.Text = $"รวมชิ้น: {totalPieces}";

            // ยอดรวม (ผลรวมของ Total)
            decimal totalAmount = _cartItems.Sum(c => c.Quantity * (decimal)c.Product.Price);
            lblTotalAmount.Text = $"ยอดรวม: {totalAmount}";
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (_cartItems.Count == 0)
            {
                MessageBox.Show("ไม่มีสินค้าในตะกร้า!");
                return;
            }

            decimal totalAmount = _cartItems.Sum(c => c.Quantity * (decimal)c.Product.Price);

            // เปิด Popup Dialog
            using (var paymentDialog = new PaymentDialog(totalAmount))
            {
                if (paymentDialog.ShowDialog() == DialogResult.OK)
                {
                    decimal PaymentAmount = paymentDialog.PaymentAmount;

                    // ตรวจสอบว่าจำนวนเงินที่จ่ายเพียงพอ
                    if (PaymentAmount < totalAmount)
                    {
                        MessageBox.Show("จำนวนเงินที่จ่ายไม่เพียงพอ!");
                        return;
                    }

                    // คำนวณเงินทอน
                    decimal change = PaymentAmount - totalAmount;
                    MessageBox.Show($"ทำรายการสำเร็จ! เงินทอน: {change}");

                    // ลดสต็อก
                    foreach (var cartItem in _cartItems)
                    {
                        if (cartItem.Quantity > 0)
                        {
                            _stockService.DecreaseStock(cartItem.Product.Sku, cartItem.Quantity);
                        }
                    }

                    // เคลียร์รายการสินค้าในตะกร้า
                    _cartItems.Clear();
                    UpdateDataGridView();
                }
            }
        }


        public class CartItem
        {
            public Product Product { get; }
            public int Quantity { get; set; }

            public CartItem(Product product, int quantity)
            {
                Product = product ?? throw new ArgumentNullException(nameof(product));
                Quantity = quantity > 0 ? quantity : throw new ArgumentException("Quantity must be greater than 0", nameof(quantity));
            }
        }
    }
}
