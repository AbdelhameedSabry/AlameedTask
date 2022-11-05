

using CRM_Application.DAL;

namespace CRM_Application.DA;

public class OrderRepo: GenericRepo<OrderHeader>,IOrderRepo
{
    private readonly CRMDbContext _context;

    public OrderRepo(CRMDbContext context):base(context)
    {
        _context = context;
    }
}
