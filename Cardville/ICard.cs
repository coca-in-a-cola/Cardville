using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardville
{
    public interface ICard
    {
        bool CanInteractWith(ICard another);
        void InteractWith(ICard another);
    }
}
