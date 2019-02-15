using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestWorld.RestClient
{
  [ApiController]
  [Route("/jacob/[controller]")]
  [Produces("application/json")]
  public class MovieController : ControllerBase
  {

    private List<string> movies = new List<string>()
    {
      "Titanic",
      "Star Wars",
      "Angry Birds"
    };
    [HttpGet]
    public async Task<IActionResult> Get()
    {
      return await Task.Run(()=>
      {
        return Ok("<h1> HTML YES </h1>");
      });//200-series
      // return NoContent(); //200-series
      // return NotFound(); //400-series
      // return Redirect(); //300-Series
      // return BadRequest(); //500-series
    }
    [HttpPost]
    public IActionResult Post()
    {
      return Ok("post request");
    }
  }
}