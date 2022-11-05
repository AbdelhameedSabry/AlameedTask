

namespace CRM_Application.BL;

public interface IAddressManager
{
    public void SaveAddress(CustomerAddressWriteDto customerAddressWriteDto);

    public bool UpdateCustomerAddress(CustomerAddressWriteDto customerAddressWriteDto);    
}
