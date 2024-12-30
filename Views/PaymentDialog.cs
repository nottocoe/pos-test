using System;
using System.Windows.Forms;

namespace PosApp.Views
{
    [Serializable] // เพิ่ม Attribute [Serializable] เพื่ออนุญาตให้ซีเรียไลซ์
    public partial class PaymentDialog : Form
    {
        public decimal PaymentAmount;
        private readonly decimal _totalAmount;

        public PaymentDialog(decimal totalAmount)
        {
            _totalAmount = totalAmount;
            InitializeComponent();
            lblTotalAmount.Text = $"ยอดรวม: {_totalAmount}"; // แสดงยอดรวม
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // ตรวจสอบค่าที่กรอกใน TextBox
            if (decimal.TryParse(txtPaymentAmount.Text.Trim(), out var paymentAmount) && paymentAmount >= _totalAmount)
            {
                PaymentAmount = paymentAmount; // เก็บค่าเงินที่จ่าย
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("กรุณากรอกจำนวนเงินที่มากกว่าหรือเท่ากับยอดรวม!", "ข้อผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}