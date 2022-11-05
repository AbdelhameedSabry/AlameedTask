using CRM_Application.BL;
using Microsoft.AspNetCore.Mvc;

namespace CRM_Application.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerManager _customerManager;
        public CustomerController(ICustomerManager customerManager)
        {
            _customerManager = customerManager;
        }

        //return all Cutomer with addresses and orders
        [HttpGet]
        [Route("GetAll")]
        public ActionResult<IEnumerable<CustomerReadDto>> GetAll()
        {
            return _customerManager.GetAllCustomersWithAddress();
        }

        //return just one Customer with address and orders
        [HttpGet]
        [Route("GetCustomerById")]
        public ActionResult<CustomerReadDto> GetCustomerById(int id)
        {
            return _customerManager.GetCustomerWithAddress(id);
        }

        //add Cutomer
        [HttpPost]
        [Route("addCustomer")]
        public ActionResult<CustomerReadDto> AddCustomer(CustomerWriteDto customerWriteDto)
        {
            return _customerManager.AddCustomer(customerWriteDto);
        }

        //updatae Custoemr
        [HttpPut]
        [Route("updateCustomer")]
        public ActionResult updateCustomer(CustomerWriteDto customerWriteDto)
        {
            bool isupdated = _customerManager.EditCustomer(customerWriteDto);
            if (!isupdated)
                return BadRequest("Data Not Updated");

            return Ok();
        }

    }
}
