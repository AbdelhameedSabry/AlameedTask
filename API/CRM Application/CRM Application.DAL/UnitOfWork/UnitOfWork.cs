
namespace CRM_Application.DAL;

public class UnitOfWork : IUnitOfWork
{
    private readonly CRMDbContext _context;

    public ICustomerRepo CustomerRepo { get; }

    public ICustomerAddressRepo CustomerAddressRepo { get; }

    public IProductRepo ProductRepo { get; }

    public UnitOfWork(CRMDbContext context,
                      ICustomerRepo customerRepo,
                      ICustomerAddressRepo customerAddressRepo,
                      IProductRepo productRepo)
    {
        _context = context;
        CustomerRepo = customerRepo;
        CustomerAddressRepo = customerAddressRepo;
        ProductRepo = productRepo;
    }



    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}
