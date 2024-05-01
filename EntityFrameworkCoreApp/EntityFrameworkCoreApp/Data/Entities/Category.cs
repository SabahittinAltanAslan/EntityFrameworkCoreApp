using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkCoreApp.Data.Entities
{
    //[Table(name:"Category",Schema ="c")]
    public class Category
    {
        [Column("category_id")]
        public int Id { get; set; }

        [Required]
        [Column("category_name",TypeName="nvarchar(100)")]
        public string Name { get; set; }
    }
}
