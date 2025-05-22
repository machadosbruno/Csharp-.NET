using System;
using System.Collectors.Generic;
using System.Link;
using System.Text;
using System.Threading.Tasks;

namespace coreObjectOrientedConcepts{
    public abstract class BankAccount{
        public abstract void deposit();
        public abstract void withdraw();
        public abstract void balance();
    }

    public class SavingAccount : BankAccount{

    }
}