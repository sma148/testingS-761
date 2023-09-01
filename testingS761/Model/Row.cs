using System.ComponentModel.DataAnnotations;
namespace testingS761.Model
{
    public class Row
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public List<ColumnData> Columns { get; set; }
    }
}
