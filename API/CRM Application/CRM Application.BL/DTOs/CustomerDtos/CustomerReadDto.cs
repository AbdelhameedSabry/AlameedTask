
using CRM_Application.DAL;

namespace CRM_Application.BL;

public class CustomerReadDto
{
    public int Id { get; set; }

    public Guid Code { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int? Phone { get; set; }

    public ICollection<OrderHeaderChildDto> OrderHeaders { get; set; } = new HashSet<OrderHeaderChildDto>();

    public ICollection<CustomerAddressChildReadDto> CustomerAddress { get; set; } = new HashSet<CustomerAddressChildReadDto>();
}
