using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Car : Trans   //(марка, номер, швидкість, вантажопідйомність)
    {
        public override int max_load_capacity { get { return 500; } set { this.max_load_capacity = max_load_capacity; } }

        public override void OutputArr(Trans[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("\n\t\tВивід даних для легкового автомобіля!\t\tПорядковий номер: " + (i + 1) + "\n");
                Console.Write("\tМарка автомобіля: " + arr[i].car_brand);
                Console.Write("\n\tНомер автомобіля: " + arr[i].number);
                Console.Write("\n\tМаксимальна швидкість автомобіля: " + arr[i].speed);
                Console.Write("\n\tМаксимальна вантажопідйомність: " + arr[i].load_capacity);
            }
        }

        public override void InputArr(Trans[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Car();
                Console.Write("\n\t\tВведіть дані для легкового автомобіля!\n\tВведіть марку автомобіля: ");
                arr[i].car_brand = Console.ReadLine();
                Console.Write("\n\tВведіть номер автомобіля: ");
                arr[i].number = int.Parse(Console.ReadLine());
                Console.Write("\n\tВведіть максимальну швидкість автомобіля: ");
                arr[i].speed = int.Parse(Console.ReadLine());
                Console.Write("\n\tВведіть максимальну вантажопідйомність: ");
                arr[i].load_capacity = int.Parse(Console.ReadLine());
                Console.WriteLine();
                
            }
        }

        public override void LoadCapacity(Trans[] arr, int i)
        {
            
        }
        public override void SearchCar(Trans[] arr)
        {
            Console.Write("\n\t\t Організувати пошук машин, які відповідають вимогам вантажопідйомності.\n");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].load_capacity <= max_load_capacity)
                {
                    
                    Console.Write("\tМарка автомобіля: " + arr[i].car_brand);
                    Console.Write("\n\tНомер автомобіля: " + arr[i].number);
                    Console.Write("\n\tМаксимальна швидкість автомобіля: " + arr[i].speed);
                    Console.Write("\n\tМаксимальна вантажопідйомність: " + arr[i].load_capacity);
                }
            }
        }
        public Car():base()
        {
            load_capacity = 0;
        }
        public Car(string? car_brand, int number, int speed, int load_capacity, string trailer) : base(car_brand, number, speed,  trailer)
        {
            this.load_capacity = load_capacity; 
        }
    }
}
