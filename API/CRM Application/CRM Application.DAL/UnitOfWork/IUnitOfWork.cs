
namespace CRM_Application.DAL;

public interface IUnitOfWork
{
    public ICustomerRepo CustomerRepo {get; }

    public ICustomerAddressRepo CustomerAddressRepo { get; }

    public IProductRepo ProductRepo { get; }


    public void SaveChanges();
}
