using Coffeetariat.UnpopularOpinions.W3.Interfaces;
using Coffeetariat.UnpopularOpinions.W3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Coffeetariat.UnpopularOpinions.W3.Controllers
{
  [Route("api/opinions")]
  public class Opinions : ControllerBase
  {
    private readonly IOpinionsRepository _opinionsRepository;

    public Opinions(IOpinionsRepository opinionsRepository)
    {
      _opinionsRepository = opinionsRepository;
    }

    [HttpGet()]
    public IActionResult Get()
    {
      return Ok(_opinionsRepository.GetLast10());
    }

    [HttpPut("create")]
    public IActionResult Put([FromBody] string message)
    {
      var result = _opinionsRepository.Create(new Opinion
      {
        Id = _opinionsRepository.LastId(),
        Message = message
      });
      
      return Ok();  
    }
  }
}