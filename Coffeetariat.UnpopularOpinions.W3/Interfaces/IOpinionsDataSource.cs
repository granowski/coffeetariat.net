using System.Collections.Generic;
using Coffeetariat.UnpopularOpinions.W3.Collections;
using Coffeetariat.UnpopularOpinions.W3.Models;

namespace Coffeetariat.UnpopularOpinions.W3.Interfaces
{
    public interface IOpinionsDataSource
    {
        Opinions LoadFromFile(string filename);
    }
}