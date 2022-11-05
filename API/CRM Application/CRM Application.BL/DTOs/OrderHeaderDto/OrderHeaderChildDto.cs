

using CRM_Application.DAL;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CRM_Application.BL;

public class OrderHeaderChildDto
{
    public int Id { get; set; }

    public string Status { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public decimal GrandTotal { get; set; }

}
