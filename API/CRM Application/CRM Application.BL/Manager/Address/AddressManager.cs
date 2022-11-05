
using AutoMapper;
using CRM_Application.DAL;

namespace CRM_Application.BL;

public class AddressManager : IAddressManager
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public AddressManager(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public void SaveAddress(CustomerAddressWriteDto customerAddressWriteDto)
    {
        var address = _mapper.Map<CustomerAddress>(customerAddressWriteDto);
        _unitOfWork.CustomerAddressRepo.Add(address);
        _unitOfWork.SaveChanges();
    }

    public bool UpdateCustomerAddress(CustomerAddressWriteDto customerAddressWriteDto)
    {
        var address = _unitOfWork.CustomerAddressRepo.GetById(customerAddressWriteDto.Id);
        if (address == null)
            return false;
        var customerAddress = _mapper.Map(customerAddressWriteDto,address);
        _unitOfWork.CustomerAddressRepo.Update(customerAddress);
        _unitOfWork.SaveChanges();

        return true;
    }
}
