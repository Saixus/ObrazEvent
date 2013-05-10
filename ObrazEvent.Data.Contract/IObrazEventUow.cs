using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObrazEvent.Data.Contract
{
    public interface IObrazEventUow
    {
        void Commit();

        IServiceRepository Services { get; }
    }
}
