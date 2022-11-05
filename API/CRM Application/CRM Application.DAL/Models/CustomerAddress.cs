
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_Application.DAL;

public class CustomerAddress
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

    public bool isShipping { get; set; }

    public bool isbilling { get; set; }

    [ForeignKey("Customer")]
    public int CustomerId { get; set; }
    public Customer customer { get; set; }
}
