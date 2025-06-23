using System;
using System.Text;
using System.Threading.Tasks;

namespace coreObjectOrientedConcepts{
    public abstract class BankAccount{
        public abstract void deposit();
        public abstract void withdraw();
        public abstract void balance();
        public void getMessage(){
            Console.WriteLine("Welcome to ABC Bank!");
        }
    }

    public class SavingAccount : BankAccount{
        public override void balance(){
            Console.WriteLine("Balance in Savin Account");
        }

        public override void deposit(){
            Console.WriteLine("Deposit in Savin Account");
        }

        public override void withdraw(){
            Console.WriteLine("Withdraw in Savin Account");
        }
    }
}