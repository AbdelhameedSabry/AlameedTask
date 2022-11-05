using CRM_Application.BL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRM_Application.PL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerAddressController : ControllerBase
    {
        private readonly IAddressManager _addressManager;
        public CustomerAddressController(IAddressManager addressManager)
        {
            _addressManager = addressManager;
        }

        //add Customer Address
        [HttpPost]
        [Route("addCustomerAddress")]
        public ActionResult AddCustomerAddress(CustomerAddressWriteDto customerAddressWriteDto)
        {
            if (customerAddressWriteDto == null)
                return BadRequest("Can not add address");
            _addressManager.SaveAddress(customerAddressWriteDto);

            return Ok();
        }

        //update customer address 
        [HttpPut]
        [Route("UpdateCustomerAddress")]
        public ActionResult updateCustomerAddress(CustomerAddressWriteDto customerAddressWriteDto)
        {
            bool isupdated = _addressManager.UpdateCustomerAddress(customerAddressWriteDto);
            if (!isupdated)
                return BadRequest();
            return Ok();
        }
    }
}
