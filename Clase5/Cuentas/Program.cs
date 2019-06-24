using System;

namespace Cuentas
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.Amount = 0.0;
            Console.WriteLine(account.Amount);

            History history = account.SaveHistory();
            account.Amount = 100.0;
            // DoSomething(account) -> Incrementa el saldo por un deposito -> Falla -> 0.0 
            Console.WriteLine(account.Amount);

            account.RestoreHistory(history);
            // 0.0 (recuperar el estado)
            Console.WriteLine(account.Amount);
        }
    }

    class Account
    {     
        public double Amount { get; set; }       

        public History SaveHistory()
        {
            return new History(Amount);
        }

        public void RestoreHistory(History history)
        {
            this.Amount = history.Amount;
        }
    }

    class History
    {
        public double Amount { get; set; }
        public History(double amount)
        {
            this.Amount = amount;
        }
    }
}
