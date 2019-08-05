using System.Collections.Generic;
using Coffeetariat.UnpopularOpinions.W3.Interfaces;
using Coffeetariat.UnpopularOpinions.W3.Models;

namespace Coffeetariat.UnpopularOpinions.W3.Collections
{
  public class Opinions : IOpinions
  {
    public IEnumerable<Opinion> GetLast10()
    {
      // todo -> implement a repository like pattern
      return new List<Opinion>()
      {
        new Opinion()
        {
          Id = 0,
          Message = "Koala's are nature's gimp-panda."
        }
      };
    }
  }
}