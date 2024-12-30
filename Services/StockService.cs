using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PosApp.Data;
using PosApp.Models;

namespace PosApp.Services
{
    public class StockService
    {
        private readonly ApplicationDbContext _dbContext;

        public StockService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void UpdateStock(Stock stock)
        {
            var existingStock = _dbContext.Stocks.FirstOrDefault(s => s.Sku == stock.Sku);
            if (existingStock != null)
            {
                existingStock.Quantity += stock.Quantity;
                _dbContext.Stocks.Update(existingStock);
            }
            else
            {
                _dbContext.Stocks.Add(stock);
            }
            _dbContext.SaveChanges();
        }

        public List<Stock> GetAllStocks() => _dbContext.Stocks.Include(s => s.Product).ToList();

        public Stock? GetStockBySku(string sku)
        {
            return _dbContext.Stocks.Include(s => s.Product).FirstOrDefault(s => s.Sku == sku);
        }

        public void DecreaseStock(string sku, int quantity)
        {
            var stock = GetStockBySku(sku);
            if (stock != null && stock.Quantity >= quantity)
            {
                stock.Quantity -= quantity;
                _dbContext.Stocks.Update(stock);
                _dbContext.SaveChanges();
            }
        }
    }
}
