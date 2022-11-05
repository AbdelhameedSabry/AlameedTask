

using AutoMapper;
using CRM_Application.DAL;

namespace CRM_Application.BL;

public class ProductManager : IproductManager
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    public ProductManager(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public List<ProductReadDto> GetAllProduds()
    {
        return _mapper.Map< List<ProductReadDto>>(_unitOfWork.ProductRepo.GetAll());
    }

    public ProductReadDto GetProductById(int id)
    {
        return _mapper.Map<ProductReadDto>(_unitOfWork.ProductRepo.GetById(id));
    }

    public ProductReadDto AddProduct(ProductWriteDto productDto)
    {
        var product=_mapper.Map<Product>(productDto);   
        _unitOfWork.ProductRepo.Add(product);
        _unitOfWork.SaveChanges();

        return _mapper.Map<ProductReadDto>(product);
    }

    public bool UpdateProduct(ProductWriteDto productDto)
    {
        var product = _unitOfWork.ProductRepo.GetById(productDto.Id);
        if(product == null)
            return false;

        var prod = _mapper.Map(productDto, product);
        _unitOfWork.ProductRepo.Update(prod);
        _unitOfWork.SaveChanges();
        return true;

    }

    public bool DeleteProduct(int id)
    {
       var prod = _unitOfWork.ProductRepo.GetById(id);
        if (prod == null)
            return false;

        _unitOfWork.ProductRepo.Delete(prod);
        _unitOfWork.SaveChanges();
        return true;
    }
   
}
