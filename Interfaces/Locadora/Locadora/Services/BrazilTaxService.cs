﻿using Locadora.Services.Interfaces;

namespace Locadora.Services
{
    internal class BrazilTaxService : ITaxService
    {
        public double Tax(double amount)
        {
            if(amount <= 100)
            {
                return amount * 0.2;
            }

            return amount * 0.25;
        }
    }
}
