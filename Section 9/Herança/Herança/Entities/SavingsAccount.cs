namespace Herança.Entities
{
    class SavingsAccount : Account
    {
        public double InteresRate { get; set; }
        
        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interesRate)
            :base(number, holder, balance)
        {
            InteresRate = interesRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InteresRate;
        }

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
