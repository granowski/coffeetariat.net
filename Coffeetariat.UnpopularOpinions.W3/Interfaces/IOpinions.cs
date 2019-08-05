using System.Collections.Generic;
using Coffeetariat.UnpopularOpinions.W3.Models;

namespace Coffeetariat.UnpopularOpinions.W3.Interfaces
{
  public interface IOpinions
  {
    IEnumerable<Opinion> GetLast10();
  }
}