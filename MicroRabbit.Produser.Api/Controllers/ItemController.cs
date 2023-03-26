using MicroRabbit.Produser.Application.Interfaces;
using MicroRabbit.Produser.Application.Models;
using Microsoft.AspNetCore.Mvc;

namespace MicroRabbit.Produser.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly ILogger<ItemController> _logger;
        private readonly IItemService _itemService;

        public ItemController(ILogger<ItemController> logger, IItemService itemService)
        {
            _logger = logger;
            _itemService = itemService;
        }        

        [HttpPost]
        public IActionResult Post([FromBody] ItemTransfer itemTransfer)
        {
            _itemService.Transfer(itemTransfer);
            return Ok(itemTransfer);
        }
    }
}