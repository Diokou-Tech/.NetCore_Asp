using BethanysPieShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly IPieRepository _pieRepo;

        public SearchController(IPieRepository pieRepo)
        {
            _pieRepo = pieRepo;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var datas = _pieRepo.AllPies;
            return Ok(datas);
        }       
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var data = _pieRepo.GetPieById(id);
            if(data is null)
            {
                return NotFound();
            }
            return Ok(data);
        }
    } 
}
