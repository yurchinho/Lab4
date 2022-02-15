using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Motorcycle : Trans
    {
        public override int max_load_capacity { get { return 50; } set { this.max_load_capacity = max_load_capacity; } }

        public override void OutputArr(Trans[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("\n\t\tВивід даних для мотоцикла!\t\tПорядковий номер: " + (i + 1));
                Console.WriteLine("\tМарка мотоцикла: " + arr[i].car_brand);
                Console.WriteLine("\tНомер мотоцикла: " + arr[i].number);
                Console.WriteLine("\tМаксимальна швидкість мотоцикла: " + arr[i].speed);
                Console.WriteLine("\tНаявність прицепа: " + arr[i].trailer);
                LoadCapacity(arr,i);
                Console.WriteLine("\tМаксимальна вантажопідйомність: " + arr[i].load_capacity);
            }
        }

        public override void InputArr(Trans[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Motorcycle();
                Console.Write("\n\t\tВведіть дані для мотоцикла!\n\tВведіть марку мотоцикла: ");
                arr[i].car_brand = Console.ReadLine();
                Console.Write("\n\tВведіть номер мотоцикла: ");
                arr[i].number = int.Parse(Console.ReadLine());
                Console.Write("\n\tВведіть максимальну швидкість мотоцикла: ");
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
           
                if(arr[i].trailer == "Так")
                {
                    arr[i].load_capacity = arr[i].load_capacity * 2;
                }
                else
                {
                    arr[i].load_capacity = 0;
                }
            
            
        }
        public override void SearchCar(Trans[] arr)
        {
            Console.Write("\n\t\t Організувати пошук мотоциклів, які відповідають вимогам вантажопідйомності.\n");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].load_capacity <= max_load_capacity)
                {
                    Console.Write("\tМарка мотоцикла: " + arr[i].car_brand);
                    Console.Write("\n\tНомер мотоцикла: " + arr[i].number);
                    Console.Write("\n\tМаксимальна швидкість мотоцикла: " + arr[i].speed);
                    Console.Write("\n\tМаксимальна вантажопідйомність: " + arr[i].load_capacity);
                }
            }
        }

        public Motorcycle() : base()
        {
            load_capacity = 0; 
        }
        public Motorcycle(string? car_brand, int number, int speed,int load_capacity, string trailer) : base(car_brand, number, speed, trailer)
        {
            this.load_capacity = load_capacity;
        }
    }
}

