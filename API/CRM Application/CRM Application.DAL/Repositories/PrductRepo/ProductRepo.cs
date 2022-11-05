
namespace CRM_Application.DAL;

public class ProductRepo:GenericRepo<Product>,IProductRepo
{
	private readonly CRMDbContext _context;
	public ProductRepo(CRMDbContext context):base(context)
	{
		_context = context;
	}

}
