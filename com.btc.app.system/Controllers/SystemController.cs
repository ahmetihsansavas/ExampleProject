using com.btc.manager.System.Abstract;
using com.btc.process.type.Dto.System;
using com.btc.type.Entity.System;
using Microsoft.AspNetCore.Mvc;

namespace com.btc.app.system.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class SystemController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<SystemController> _logger;
        private readonly IUserManager _userManager;
        public SystemController(ILogger<SystemController> logger, IUserManager userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        //[HttpGet(Name = "GetWeatherForecast")]
        //public IEnumerable<WeatherForecast> GetWeatherForecast()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();
        //}

        [HttpGet(Name = "GetUsers")]
        public IActionResult GetUsers()
        {
            return Ok(_userManager.GetAll());
        }

        [HttpPost(Name = "CreateUser")]
        public async Task<IActionResult> CreateUser(User user)
        {
            return Ok(await _userManager.Create(user));
        }

        [HttpGet(Name = "GetUserNameById")]
        public IActionResult GetUserNameById(int id)
        {
            return Ok(_userManager.GetName(id));
        }
    }
}
