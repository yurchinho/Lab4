using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Truck : Trans
    {
        public override int max_load_capacity { get { return 6000; } set { this.max_load_capacity = max_load_capacity; } }

        public override void OutputArr(Trans[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("\n\t\tВивід даних для грузовика!\t\tПорядковий номер: " + (i + 1));
                Console.WriteLine("\tМарка грузовика: " + arr[i].car_brand);
                Console.WriteLine("\tНомер грузовика: " + arr[i].number);
                Console.WriteLine("\tМаксимальна швидкість грузовика: " + arr[i].speed);
                Console.WriteLine("\tНаявність прицепа: " + arr[i].trailer);
                LoadCapacity(arr, i);
                Console.WriteLine("\tМаксимальна вантажопідйомність: " + arr[i].load_capacity);
            }
        }

        public override void InputArr(Trans[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Truck();
                Console.Write("\n\t\tВведіть дані для грузовика!\n\tВведіть марку грузовика: ");
                arr[i].car_brand = Console.ReadLine();
                Console.Write("\n\tВведіть номер грузовика: ");
                arr[i].number = int.Parse(Console.ReadLine());
                Console.Write("\n\tВведіть максимальну швидкість грузовика: ");
                arr[i].speed = int.Parse(Console.ReadLine());
                Console.Write("\n\tВведіть наявність прицепу: ('Так' або 'Ні')  ");
                arr[i].trailer = Console.ReadLine();
                Console.Write("\n\tВведіть максимальну вантажопідйомність: ");
                arr[i].load_capacity = int.Parse(Console.ReadLine());

                Console.WriteLine();
            }
        }
        public override void LoadCapacity(Trans[] arr, int i)
        {
            for (; i < arr.Length; i++)
            {
                if (arr[i].trailer == "Так")
                {
                    arr[i].load_capacity = arr[i].load_capacity * 2;
                }
                else
                {
                    arr[i].load_capacity = 0;
                }
            }

        }
        public override void SearchCar(Trans[] arr)
        {
            Console.Write("\n\t\t Організувати пошук грузовиків, які відповідають вимогам вантажопідйомності.\n");

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].load_capacity <= max_load_capacity)
                {
                    Console.Write("\tМарка грузовика: " + arr[i].car_brand);
                    Console.Write("\n\tНомер грузовика: " + arr[i].number);
                    Console.Write("\n\tМаксимальна швидкість грузовика: " + arr[i].speed);
                    Console.Write("\n\tМаксимальна вантажопідйомність: " + arr[i].load_capacity);
                }
            }
        }

        public Truck() : base()
        {
            load_capacity = 0;
        }
        public Truck(string? car_brand, int number, int speed, int load_capacity, string trailer) : base(car_brand, number, speed, trailer)
        {
            this.load_capacity = load_capacity;
        }
    }
}

