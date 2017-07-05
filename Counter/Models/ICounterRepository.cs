using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter.Models
{
    interface ICounterRepository
    {
        Counter GetCounter();
        void UpdateCounter(Counter input);
    }
}
