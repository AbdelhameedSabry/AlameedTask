
using System.ComponentModel.DataAnnotations;

namespace CRM_Application.BL;

public class ProductWriteDto
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public decimal Price { get; set; }
}
