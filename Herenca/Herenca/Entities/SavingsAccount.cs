namespace Herenca.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)

        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void WithDraw(double amount)
        {
            //Alem da taxa de 5 reais, adiciona mais uma taxa de 2 reais
            base.WithDraw(amount);
            Balance -= 2.0;
        }

        //public override void WithDraw(double amount)
        //{
        //    //Alteracao para que ao realizar saque, nao cobre os 5 reais
        //    Balance -= amount;
        //}
    }
}
