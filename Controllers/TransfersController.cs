using databaseFirstProject.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace databaseFirstProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransfersController : ControllerBase
    {
        private readonly ITransferServices _transferServices;
        public TransfersController(ITransferServices transferServices)
        {
            this._transferServices = transferServices;
        }

        [HttpGet]
        public IActionResult getTransfers()
        {
            try
            {
                var listOfTransfers = this._transferServices.getTransfers();
                return Ok(listOfTransfers);
            }
            catch (Exception e)
            {
                return BadRequest("Error");
            }
        }
    }
}
