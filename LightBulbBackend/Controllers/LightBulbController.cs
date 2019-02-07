using System;
using LightBulbBackend.Models;
using LightBulbBackend.Services;
using Microsoft.AspNetCore.Mvc;

namespace LightBulbBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LightBulbController : ControllerBase
    {
        private readonly ILightBulbService lightBulbService;

        public LightBulbController(ILightBulbService lightBulbService)
        {
            this.lightBulbService = lightBulbService;
        }

        [HttpGet("{numOfPeople}/{bulbs}")]
        public ActionResult<Results> Calculate(int numOfPeople, int bulbs)
        {
            try
            {
                var results = lightBulbService.Calculate(numOfPeople, bulbs);
                return Ok(results);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
