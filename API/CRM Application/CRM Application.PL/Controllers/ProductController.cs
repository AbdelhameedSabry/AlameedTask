using CRM_Application.BL;
using Microsoft.AspNetCore.Mvc;

namespace CRM_Application.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IproductManager _productManager;

        public ProductController(IproductManager productManager)
        {
            _productManager = productManager;
        }

        //get all products 
        [HttpGet]
        [Route("getAllProducts")]
        public ActionResult<List<ProductReadDto>> GetAllProducts()
        {
            return _productManager.GetAllProduds();
        }

        //get products by id 
        [HttpGet]
        [Route("getProductById")]
        public ActionResult<ProductReadDto> GetProductId(int id)
        {
            return _productManager.GetProductById(id);
        }
        //add Product
        [HttpPost]
        [Route("AddProduct")]
        public ActionResult<ProductReadDto> AddProduct(ProductWriteDto productWriteDto)
        {
            var prod = _productManager.AddProduct(productWriteDto);
            if (prod == null)
                return BadRequest();

            return Ok();
        }

        //Get update Product
        [HttpPut]
        [Route("EditProduct")]
        public ActionResult EditProduct(ProductWriteDto productWriteDto)
        {
            bool isupdated=_productManager.UpdateProduct(productWriteDto);
            if (!isupdated)
                return BadRequest("Cant not Update");

            return Ok();
        }
    }
}
