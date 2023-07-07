namespace Herenca.Entities
{
    internal class Account
    {
        public int Number { get; private set; } //Pode ser acessado, mas n pode ser alterado

        public string Holder { get; private set; }

        public double Balance { get; protected set; } //Pode ser acessado, e só pode ser alterado pela classe ou subclasses

        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void WithDraw(double amount)
        {
            Balance -= (amount + 5.00);
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
