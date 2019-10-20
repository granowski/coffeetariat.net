using System.Collections.Generic;
using System.Linq;
using Coffeetariat.UnpopularOpinions.W3.Collections;
using Coffeetariat.UnpopularOpinions.W3.Interfaces;
using Coffeetariat.UnpopularOpinions.W3.Models;

namespace Coffeetariat.UnpopularOpinions.W3.Repositories
{
  public class OpinionsRepository : IOpinionsRepository
  {
    private Opinions opinions;
//    private Opinions _cachedOpinions;

    public OpinionsRepository(IOpinionsDataSource data)
    {
//      _cachedOpinions = new Opinions()
//      {
//        new Opinion()
//        {
//          Id = 0,
//          Message = ""
//        },
//        new Opinion()
//        {
//          Id = 1,
//          Message = "My anaconda... whut!?"
//        }
//      };
      this.opinions = data.LoadFromFile("opinions.xml");
    }

    public IEnumerable<Opinion> GetLast10() => this.opinions.Take(10);

    public IResult Create(Opinion opinion)
    {
      this.opinions.Add(opinion);
      return null;
    }

    public int LastId()
    {
      return this.opinions.Max(o => o.Id) + 1;
    }
  }
}