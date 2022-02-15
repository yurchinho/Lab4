using System;

 namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[]args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Console.Write("Введіть розмірність масива об'єктів: ");
            int size = int.Parse(Console.ReadLine());

            Trans[] arr = new Car[size];
            Trans[] arr1 = new Motorcycle[size];
            Trans[] arr2 = new Truck[size];           

            Car car = new Car();
            Motorcycle motorcycle = new Motorcycle();
            Truck truck = new Truck();

            car.InputArr(arr);
            motorcycle.InputArr(arr1); 
            truck.InputArr(arr2);   

            car.OutputArr(arr);
            motorcycle.OutputArr(arr1);
            truck.OutputArr(arr2);

            car.SearchCar(arr);
            motorcycle.SearchCar(arr1);
            truck.SearchCar(arr2);

            /*motorcycle.InputArr(trans);
            motorcycle.OutputArr(trans);
            motorcycle.SearchCar(trans);*/
            
            
        }
    }
}