
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_Application.DAL;

public class Product
{
    [Required]
    [Key]
    public int Id { get; set; }

    [Required]
    [DataType(DataType.Text)]
    [MaxLength(20), MinLength(3)]
    public string Name { get; set; }


    public string Description { get; set; } = null!;

    [Required]
    public decimal Price { get; set; }
    
    public  OrderDetials OrderDetials { get; set; }

}
