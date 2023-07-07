using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Services.Interfaces
{
    internal interface ITaxService
    {
        public double Tax(double amount);
    }
}
