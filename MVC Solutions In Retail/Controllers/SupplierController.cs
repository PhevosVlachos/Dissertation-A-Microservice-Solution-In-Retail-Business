using Microsoft.AspNetCore.Mvc;
using MVC_Solutions_In_Retail.Model;
using MVC_Solutions_In_Retail.Services;

namespace MVC_Solutions_In_Retail.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class SupplierController : Controller
    {
        private readonly ILogger<SupplierController> _logger;
        private readonly ISupplierService _suppliers;

        public SupplierController(ILogger<SupplierController> logger, ISupplierService suppliers)
        {
            _logger = logger;
            _suppliers = suppliers;
        }

        [HttpGet("GetSuppliers")]
        public List<Supplier> GetSuppliers()
        {
            return _suppliers.ReadSuppliers();
        }

        [HttpGet("CreateSuppliers")]
        public string CreateSuppliers()
        {
            _suppliers.MakeSuppliers();
            return "Ok";
        }
    }
}
