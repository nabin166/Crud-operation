using System.ComponentModel.DataAnnotations;

namespace Crud_operation.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required] //Data Anotation 
        public string Name { get; set; } = null!;
        public int DisplayOrder { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;


    }
}
