
using Microsoft.EntityFrameworkCore;

namespace CRM_Application.DAL;

public class CustomerRepo : GenericRepo<Customer>, ICustomerRepo
{
    private readonly CRMDbContext _contex;

    public CustomerRepo(CRMDbContext contex):base(contex)
    {
        _contex = contex;
    }

    public List<Customer> GetCustomers()
    {
        return _contex.Customers
            .Include(c=>c.CustomerAddress)
            .Include(c=>c.OrderHeaders)
            .ToList(); 
    }

    public Customer GetCustomer(int id)
    {
        return _contex.Customers
            .Include(c => c.CustomerAddress)
            .Include(c => c.OrderHeaders)
            .Where(c=>c.Id==id)
            .FirstOrDefault();
    }
    
}
