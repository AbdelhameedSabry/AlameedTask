

namespace CRM_Application.BL;

public class CustomerAddressChildReadDto
{

    public string AddressLineOne { get; set; } = null!;

    public string AddressLineTwo { get; set; } = null!;

    public string city { get; set; } = null!;

    public string state { get; set; } = null!;

    public string PostalCode { get; set; } = null!;

    public string Country { get; set; } = null!;

    public bool isShipping { get; set; }

    public bool isbilling { get; set; }
}
