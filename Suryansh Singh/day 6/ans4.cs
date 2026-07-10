using System;
class Calculator{
    public void WelcomeMessage(){
        Console.WriteLine("Welcome to Calculator");
    }
    public void PrintNumber(int number){
        Console.WriteLine("Number = " + number);
    }
    public int GetCurrentYear(){
        return DateTime.Now.Year;
    }
    public int Add(int a, int b){
        return a + b;
    }
}
class Program{
    static void Main(){
        Calculator c = new Calculator();
        c.WelcomeMessage();
        c.PrintNumber(50);
        Console.WriteLine("Current Year = " + c.GetCurrentYear());
        Console.WriteLine("Addition = " + c.Add(10, 20));
    }
}