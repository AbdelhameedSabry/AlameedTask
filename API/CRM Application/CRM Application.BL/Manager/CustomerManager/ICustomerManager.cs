


namespace CRM_Application.BL;

public interface ICustomerManager
{
    List<CustomerReadDto> GetAllCustomersWithAddress();

    CustomerReadDto GetCustomerWithAddress(int Id);

    CustomerReadDto AddCustomer(CustomerWriteDto customerWriteDto);

    bool EditCustomer(CustomerWriteDto customerWriteDto);

}
