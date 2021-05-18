using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardville.Core
{
    public class Table3D<K1, K2, K3, V>
    {
        private struct Key3D<D1, D2, D3>
        {
            public readonly D1 First;
            public readonly D2 Second;
            public readonly D3 Third;

            public Key3D(D1 d1, D2 d2, D3 d3)
            {
                First = d1;
                Second = d2;
                Third = d3;
            }

            public override int GetHashCode()
            {
                return unchecked((First.GetHashCode() * 0x666 + Second.GetHashCode())
                    * 0x666 + Third.GetHashCode());
            }
        }

        private Dictionary<Key3D<K1, K2, K3>, V> underCapret;
        public V this[K1 index1, K2 index2, K3 index3]
        {
            get
                => underCapret[new Key3D<K1, K2, K3>(index1, index2, index3)];
            set
                => underCapret[new Key3D<K1, K2, K3>(index1, index2, index3)] = value;
        }
    }
}
