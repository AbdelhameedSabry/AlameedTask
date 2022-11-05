

namespace CRM_Application.DAL;

public interface ICustomerRepo:IGenericRepo<Customer>
{
    //get all customer include thrir address
    List<Customer> GetCustomers();

    //get customer by id
    Customer GetCustomer(int id);
}
