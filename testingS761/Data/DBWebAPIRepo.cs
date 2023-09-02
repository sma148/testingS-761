using testingS761.Model;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using testingS761.Dtos;
using Microsoft.EntityFrameworkCore;

namespace testingS761.Data
{
    public class DBWebAPIRepo : IWebAPIRepo
    {
        private readonly WebAPIDBContext _dbContext;

        public DBWebAPIRepo(WebAPIDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool AddScholarshipData(ScholarshipDataInputDto scholarshipData)
        {
            IEnumerable<Row> rows = scholarshipData.Rows;
            foreach (Row row in rows)
            {
                _dbContext.Rows.Add(row);
            }
            _dbContext.SaveChanges();
            return true;
        }

        public IEnumerable<Row> GetAllScholarshipData()
        {
            IEnumerable<Row> rows = _dbContext.Rows
                                      .Include(r => r.Columns) // Assuming the navigation property in Row class is named 'Columns'
                                      .ToList();
            return rows;
        }
    }
}
