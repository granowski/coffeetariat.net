using Coffeetariat.UnpopularOpinions.W3.Interfaces;
using Coffeetariat.UnpopularOpinions.W3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Coffeetariat.UnpopularOpinions.W3.Controllers
{
  [Route("api/opinions")]
  public class Opinions : ControllerBase
  {
    private readonly IOpinions _opinions;

    public Opinions(IOpinions opinions)
    {
      _opinions = opinions;
    }

    [HttpGet()]
    public IActionResult Get()
    {
      return Ok(_opinions.GetLast10());
    }

    [HttpPut("create")]
    public IActionResult Put([FromBody] string message)
    {
      var result = _opinions.Create(new Opinion
      {
        Id = _opinions.LastId(),
        Message = message
      });
      
      return Ok();  
    }
  }
}