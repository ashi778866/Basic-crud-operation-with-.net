using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace AsharCrud.Models
{
    public class Category
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("DisplayOrder")]
        [Range(1, 100, ErrorMessage = "Dipslay order only 1 and 100!!")]
        public int Displayorder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
