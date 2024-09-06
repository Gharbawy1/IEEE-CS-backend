using Microsoft.AspNetCore.Mvc;
namespace Firs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly string FilePath= "C:\\Users\\HP\\source\\repos\\Firs\\Firs\\names.txt";

        [HttpGet("{name}")]
        public string Get(string name)
        {
            if (!System.IO.File.Exists(FilePath))
            {
                System.IO.File.Create(FilePath).Close();
            }
            var names = System.IO.File.ReadAllLines(FilePath);

            if (names.Contains(name)) {
                return $"Hello again,{name}";
            }
            else
            {
                System.IO.File.AppendAllText(FilePath, name + System.Environment.NewLine);
                return $"Hello,{name}";
            }


        }
        
        [HttpGet("names")]
        public IActionResult GetAllUsers()
        {
            if (!System.IO.File.Exists(FilePath))
            {
                // File not found 
                return Ok("No Names Found");
            }
            var Allnames = System.IO.File.ReadAllLines(FilePath).ToList();
            return Ok(Allnames);


        }

    }
}
