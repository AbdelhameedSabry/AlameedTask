

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_Application.DAL;

public class Customer
{
    [Required]
    [Key]
    public int Id { get; set; }

    [Required]
    public Guid Code { get; set; }

    [Required]
    [DataType(DataType.Text)]
    [MaxLength(10),MinLength(5)]
    public string FirstName { get; set; }

    [Required]
    [DataType(DataType.Text)]
    [MaxLength(10), MinLength(5)]
    public string LastName { get; set; }

    [Required]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    [DataType(DataType.PhoneNumber)]
    public int? Phone { get; set; }

    public ICollection<OrderHeader> OrderHeaders { get; set; }

    public ICollection<CustomerAddress> CustomerAddress { get; set; }=new HashSet<CustomerAddress>();
}
