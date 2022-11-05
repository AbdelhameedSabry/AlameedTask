
using AutoMapper;
using CRM_Application.DAL;

namespace CRM_Application.BL;

public class CustomerManager : ICustomerManager
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public CustomerManager(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }


    public List<CustomerReadDto> GetAllCustomersWithAddress()
    {
        var customers = _unitOfWork.CustomerRepo.GetCustomers();
        return _mapper.Map<List<CustomerReadDto>>(customers);
    }

    public CustomerReadDto GetCustomerWithAddress(int Id)
    {
        var customers = _unitOfWork.CustomerRepo.GetCustomer(Id);
        return _mapper.Map<CustomerReadDto>(customers);
    }
  
    public CustomerReadDto AddCustomer(CustomerWriteDto customerWriteDto)
    {
        var customer = _mapper.Map<Customer>(customerWriteDto);
        customer.Code = Guid.NewGuid();
        _unitOfWork.CustomerRepo.Add(customer);
        _unitOfWork.SaveChanges();

        return _mapper.Map<CustomerReadDto>(customer);
    }

    public bool EditCustomer(CustomerWriteDto customerWriteDto)
    {
        var customer = _unitOfWork.CustomerRepo.GetCustomer(customerWriteDto.Id);
        if (customer == null)
            return false;

        var custimerDto=_mapper.Map(customerWriteDto, customer);
        _unitOfWork.CustomerRepo.Update(customer);
        _unitOfWork.SaveChanges();
        return true;

    }
}
