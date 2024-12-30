using System;
using System.Windows.Forms;
using PosApp.Data;
using PosApp.Services;

namespace PosApp.Views
{
    public partial class MainView : Form
    {
        private readonly ApplicationDbContext _dbContext;

        public MainView(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            InitializeComponent();
            this.Font = new System.Drawing.Font(this.Font.FontFamily, this.Font.Size + 2); // เพิ่มขนาดฟอนต์
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            using var updateProductView = new UpdateProductView(new ProductService(_dbContext), new StockService(_dbContext));
            updateProductView.ShowDialog();
        }

        private void btnOpenPos_Click(object sender, EventArgs e)
        {
            using var posTransactionView = new PosTransactionView(new ProductService(_dbContext), new StockService(_dbContext));
            posTransactionView.ShowDialog();
        }

        private void btnCheckStocks_Click(object sender, EventArgs e)
        {
            using var checkStocksView = new CheckStocksView(_dbContext);
            checkStocksView.ShowDialog();
        }

    }
}
