using System;
using System.Text;
using System.Threading.Tasks;

namespace coreObjectOrientedConcepts{
    interface iManageBank{
        void openAccount();
        void closeAccount();
    }
    internal interface iBankAccount
    {
        void deposit();
        void withdraw();
        void balance();
    }

    public class SavingAcc : iBankAccount, iManageBank{
        public void balance(){
            Console.WriteLine("Balance in Savin Account");
        }

        public void deposit(){
            Console.WriteLine("Deposit in Savin Account");
        }

        public void withdraw(){
            Console.WriteLine("Withdraw in Savin Account");
        }

        public void openAccount(){
            Console.WriteLine("Open in Savingg Account");
        }

        public void closeAccount(){
            Console.WriteLine("Close in Saving Account");
        }
    }
}