
namespace CRM_Application.DAL;

public class CustomerAddressRepo:GenericRepo<CustomerAddress> ,ICustomerAddressRepo
{
    private readonly CRMDbContext _contex;

    public CustomerAddressRepo(CRMDbContext contex):base(contex)
    {
        _contex = contex;
    }

}
