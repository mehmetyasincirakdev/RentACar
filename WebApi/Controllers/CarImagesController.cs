using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController:ControllerBase
    {
        private ICarImageService _iCarImageService;

        public CarImagesController(ICarImageService iCarImageService)
        {
            _iCarImageService = iCarImageService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _iCarImageService.GetAll();
            return Ok(result);
        }
    }
}