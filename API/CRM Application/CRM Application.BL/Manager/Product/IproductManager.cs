

namespace CRM_Application.BL;

public interface IproductManager
{
    public List<ProductReadDto> GetAllProduds();

    public ProductReadDto GetProductById(int id);

    public ProductReadDto AddProduct (ProductWriteDto productDto);

    public bool UpdateProduct (ProductWriteDto productDto);

    public bool DeleteProduct (int id);
}
