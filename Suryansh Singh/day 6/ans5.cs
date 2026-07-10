using System;
class Car{
    public string Brand;
    public string Model;
    public double Price;
    public string FuelType;
    public void StartCar(){
        Console.WriteLine("Car Started");
    }
    public void StopCar(){
        Console.WriteLine("Car Stopped");
    }
    public string GetCarInfo(){
        return Brand + " " + Model + " " + FuelType;
    }
    public double CalculateRoadTax(double taxPercentage){
        return Price * taxPercentage / 100;
    }
}
class Program{
    static void Main(){
        Car c1 = new Car();
        c1.Brand = "Hyundai";
        c1.Model = "Creta";
        c1.Price = 1500000;
        c1.FuelType = "Petrol";
        Car c2 = new Car();
        c2.Brand = "Toyota";
        c2.Model = "Fortuner";
        c2.Price = 3500000;
        c2.FuelType = "Diesel";
        Console.WriteLine(c1.GetCarInfo());
        double tax = c1.CalculateRoadTax(10);
        Console.WriteLine("Road Tax = ₹" + tax);
        Console.WriteLine("Final Price = ₹" + (c1.Price + tax));
        c1.StartCar();
        c1.StopCar();
    }
}