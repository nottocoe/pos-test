using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PosApp.Data;
using PosApp.Views;
using System;
using System.Windows.Forms;

namespace PosApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // กำหนด connection string
            var connectionString = "Data Source=PosApp.db";

            // สร้าง DbContextOptions
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlite(connectionString)
                .Options;

            // สร้าง ApplicationDbContext
            using var dbContext = new ApplicationDbContext(options);

            // Apply Migrations
            dbContext.Database.Migrate();

            // เรียกใช้งาน MainView
            Application.Run(new MainView(dbContext));
        }
    }
}
