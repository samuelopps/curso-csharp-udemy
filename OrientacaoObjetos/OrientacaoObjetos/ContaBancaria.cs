using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjetos
{
    internal class ContaBancaria
    {
        public string Account { get; private set; }
        public string Name { get; set; }
        private double Value { get; set; } = 0.0;

        public ContaBancaria(string Account, string Name)
        {
            this.Account = Account;
            this.Name = Name;
        }

        public ContaBancaria(string Account, string Name, double Value) : this(Account, Name)
        {
            addValue(Value);
        }

        public string addValue(double value)
        {
            Value += value;

            return "Dados da conta atualizados:";
        }

        public string subtractValue(double value)
        {
            Value -= (value + 5);

            return "Dados da conta atualizados:";
        }

        public override string ToString()
        {
            return $"Conta {Account}, Titular: {Name}, Saldo: $ {Value.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
