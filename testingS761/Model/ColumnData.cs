using System.ComponentModel.DataAnnotations;
namespace testingS761.Model
{
    public class ColumnData
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Value { get; set; }
    }
}
