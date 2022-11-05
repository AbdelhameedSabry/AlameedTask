

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_Application.DAL;

public class OrderShippingAddress
{
    [Key]
    public int Id { get; set; }

    [MaxLength(100), MinLength(10)]
    public string AddressLineOne { get; set; }

    [MaxLength(100), MinLength(10)]
    public string AddressLineTwo { get; set; }

    [Required]
    [DataType(DataType.Text)]
    [MaxLength(20), MinLength(3)]
    public string city { get; set; }

    [Required]
    [DataType(DataType.Text)]
    [MaxLength(20), MinLength(3)]
    public string state { get; set; }

    [Required]
    [DataType(DataType.PostalCode)]
    public string PostalCode { get; set; }

    [Required]
    [DataType(DataType.Text)]
    [MaxLength(20), MinLength(3)]
    public string Country { get; set; }

}
