using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardville
{
    public interface ICardGeneratorData
    {
        RaritySystem RaritySystem { get; }
        int SpawnerLevel {get;set;}
    }
}
