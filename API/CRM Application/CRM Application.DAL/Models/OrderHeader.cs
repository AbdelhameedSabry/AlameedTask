
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM_Application.DAL;

public class OrderHeader
{
    public int Id { get; set; }

    //Paid/Unpaid
    [Required]
    public string Status { get; set; }

    public DateTime CreatedDate { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public decimal Tax { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public decimal SubTotal { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public decimal GrandTotal { get; set; }

    [ForeignKey("Customer")]
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }

    [ForeignKey("OrderShippingAddress")]
    public int OrderShippingAddressId { get; set; }
    public OrderShippingAddress orderShippingAddress { get; set; }

    [ForeignKey("OrderBillingAddress")]
    public int OrderBillingAddressId { get; set; }
    public OrderBillingAddress orderBillingAddress { get; set; }

    [ForeignKey("OrderDetials")]
    public int OrderDetialsId { get; set; }
    public ICollection<OrderDetials> orderDetials { get; set; } = new HashSet<OrderDetials>();

}
