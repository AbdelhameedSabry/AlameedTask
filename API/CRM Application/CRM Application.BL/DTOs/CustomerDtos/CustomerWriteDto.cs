
using System.ComponentModel.DataAnnotations;

namespace CRM_Application.BL;

public class CustomerWriteDto
{
    public int Id { get; set; }

    public Guid Code { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int? Phone { get; set; }

}
