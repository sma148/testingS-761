using testingS761.Model;
using testingS761.Dtos;

namespace testingS761.Data
{
    public interface IWebAPIRepo
    {
        bool AddScholarshipData(ScholarshipDataInputDto scholarshipData);
        IEnumerable<Row> GetAllScholarshipData();
    }
}
