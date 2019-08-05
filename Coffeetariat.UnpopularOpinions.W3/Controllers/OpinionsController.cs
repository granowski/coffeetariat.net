using Coffeetariat.UnpopularOpinions.W3.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Coffeetariat.UnpopularOpinions.W3.Controllers
{
  [Route("api/opinions")]
  public class Opinions : ControllerBase
  {
    private IOpinions _opinions;

    public Opinions(IOpinions opinions)
    {
      _opinions = opinions;
    }
//    
//    public IActionResult Search()
//    {
//      return Ok();
//    }

    [HttpGet()]
    public IActionResult Get()
    {
      return Ok(_opinions.GetLast10());
    }
  }
}