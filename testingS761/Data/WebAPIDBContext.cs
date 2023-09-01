using Microsoft.EntityFrameworkCore;
using testingS761.Model;

namespace testingS761.Data
{
    public class WebAPIDBContext : DbContext
    {
        public WebAPIDBContext(DbContextOptions<WebAPIDBContext> options) : base(options) { }
        public DbSet<ColumnData> ColumnDatas { get; set; }
        public DbSet<Row> Rows { get; set; }

    }
}
