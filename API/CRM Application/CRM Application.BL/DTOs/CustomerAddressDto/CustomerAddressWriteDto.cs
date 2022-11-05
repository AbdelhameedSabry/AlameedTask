

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CRM_Application.BL;

public class CustomerAddressWriteDto
{
    public int Id { get; set; }
    public string AddressLineOne { get; set; } = null!;

    public string AddressLineTwo { get; set; }=null!;

    public string city { get; set; } = null!;

    public string state { get; set; } = null!;

    public string PostalCode { get; set; }=null !;

    public string Country { get; set; }=null!;

    public bool isShipping { get; set; }

    public bool isbilling { get; set; }

    public int CustomerId { get; set; }
}
