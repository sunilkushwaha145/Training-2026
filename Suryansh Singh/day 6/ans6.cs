using System;
class MathOperations{
    public void DisplayMessage(){
        Console.WriteLine("Welcome to C Sharp");
    }
    public void DisplayNumber(int number){
        Console.WriteLine("Number = " + number);
    }
    public DateTime GetDate(){
        return DateTime.Today;
    }
    public int Multiply(int a, int b){
        return a * b;
    }
}
class Program{
    static void Main(){
        MathOperations obj = new MathOperations();
        obj.DisplayMessage();
        obj.DisplayNumber(25);
        Console.WriteLine("Today's Date = " + obj.GetDate());
        Console.WriteLine("Multiplication = " + obj.Multiply(5, 4));
    }
}