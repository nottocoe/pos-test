using System;
using System.Linq;
using System.Windows.Forms;
using PosApp.Data;

namespace PosApp.Views
{
    public partial class CheckStocksView : Form
    {
        private readonly ApplicationDbContext _dbContext;

        public CheckStocksView(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            InitializeComponent(); // เรียก InitializeComponent ที่สร้างโดย Designer
            LoadStocks();
        }

        private void LoadStocks()
        {
            // ดึงข้อมูล Stocks จากฐานข้อมูล
            var stocks = _dbContext.Stocks
                .Select(s => new
                {
                    s.Sku,
                    ProductName = s.Product.Name, // ต้องแน่ใจว่า Stock มีความสัมพันธ์กับ Product
                    s.Quantity
                })
                .ToList();

            // แสดงใน DataGridView
            dataGridViewStocks.DataSource = stocks;
        }
    }
}
