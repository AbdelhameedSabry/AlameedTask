using AutoMapper;
using CRM_Application.DAL;

namespace CRM_Application.BL;

public class AutoMapperProfile:Profile
{
	public AutoMapperProfile()
	{
		CreateMap<Customer, CustomerReadDto>();
		CreateMap<OrderHeader, OrderHeaderChildDto>();
		CreateMap<CustomerAddress, CustomerAddressChildReadDto>();

		CreateMap<CustomerWriteDto, Customer>();
		CreateMap<CustomerAddressWriteDto, CustomerAddress>();

		CreateMap<CustomerAddressWriteDto, CustomerAddress>();

		CreateMap<Product, ProductReadDto>();
		CreateMap<ProductWriteDto,Product>();
	

;	}
}
