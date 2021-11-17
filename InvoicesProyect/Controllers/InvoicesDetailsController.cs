using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlE.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoicesProyect.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicesDetailsController : ControllerBase
    {
        private readonly InvoicesDetailsRepository _invoicesDRepository;

        public InvoicesDetailsController(IInvoicesDetails invoicesDetails)
        {
            _invoicesDRepository = (InvoicesDetailsRepository)invoicesDetails;
        }

        [HttpGet]
        public async Task<IActionResult> GetClients()
        {
            return Ok(await _invoicesDRepository.GetAllInvoices());
        }
    }
}
