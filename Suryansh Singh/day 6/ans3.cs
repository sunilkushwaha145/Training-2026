using System;
class BankAccount{
    public int AccountNumber;
    public string AccountHolderName;
    public double Balance;
    public void Deposit(double amount){
        Balance += amount;
    }
    public bool Withdraw(double amount){
        if (Balance >= amount){
            Balance -= amount;
            return true;
        }
        else{
            Console.WriteLine("Insufficient Balance!");
            return false;
        }
    }
    public double GetBalance(){
        return Balance;
    }
    public void DisplayAccount(){
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Account Holder: " + AccountHolderName);
        Console.WriteLine("Balance: ₹" + Balance);
    }
}
class Program{
    static void Main(){
        BankAccount acc = new BankAccount();
        acc.AccountNumber = 12345;
        acc.AccountHolderName = "Rahul";
        acc.Balance = 10000;
        acc.Deposit(5000);
        acc.Withdraw(2000);
        acc.DisplayAccount();
    }
}