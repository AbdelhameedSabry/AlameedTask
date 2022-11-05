

using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_Application.DAL;

public class OrderDetials
{
    public int Id { get; set; }

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public decimal Tax { get; set; }

    public decimal TotalPrice { get; set; }

    [ForeignKey("Product")]
    public int ProductId { get; set; }  
    public Product Product { get; set; }

    public OrderHeader OrderHeader { get; set; }
}
