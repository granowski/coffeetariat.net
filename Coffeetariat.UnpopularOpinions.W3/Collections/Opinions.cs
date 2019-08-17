using System.Collections.Generic;
using System.Linq;
using Coffeetariat.UnpopularOpinions.W3.Interfaces;
using Coffeetariat.UnpopularOpinions.W3.Models;

namespace Coffeetariat.UnpopularOpinions.W3.Collections
{
  public class Opinions : IOpinions
  {
    private List<Opinion> _cachedOpinions;

    public Opinions()
    {
      _cachedOpinions = new List<Opinion>
      {
        new Opinion()
        {
          Id = 0,
          Message = "Koala's are nature's gimp-panda."
        },
        new Opinion()
        {
          Id = 0,
          Message = "My anaconda... whut!?"
        }
      };
    }

    public IEnumerable<Opinion> GetLast10() => _cachedOpinions.Take(10);

    public IResult Create(Opinion opinion)
    {
      _cachedOpinions.Add(opinion);
      return null;
    }

    public int LastId()
    {
      return _cachedOpinions.Max(o => o.Id) + 1;
    }
  }
}