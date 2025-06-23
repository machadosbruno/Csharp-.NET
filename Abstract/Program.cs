using System;
using coreObjectOrientedConcepts;

SavingAccount savingAccount = new SavingAccount();

savingAccount.getMessage();

savingAccount.deposit();
savingAccount.withdraw();
savingAccount.balance();

SavingAcc savingAcc = new SavingAccount();

Console.WriteLine();
Console.WriteLine();

savingAcc.openAccount();

savingAcc.deposit();
savingAcc.withdraw();
savingAcc.balance();

savingAcc.closeAccount();