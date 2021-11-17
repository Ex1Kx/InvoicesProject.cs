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
    public class ClientsController : ControllerBase
    {
        private readonly IClientsRepository _clientsRepository;

        public ClientsController(IClientsRepository clientsRepository)
        {
            _clientsRepository = clientsRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetClients()
        {
            return Ok(await _clientsRepository.GetClients());
        }
    }
}
