using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract public class Trans
    {
        public string? car_brand;
        public int number;
        public int speed;
        public int? load_capacity;
        public string trailer;
        
        abstract public int max_load_capacity { get; set; }
        

        abstract public void OutputArr(Trans[] arr);
        abstract public void InputArr(Trans[] arr);
        abstract public void LoadCapacity(Trans[] arr, int i);
        public virtual void SearchCar(Trans[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i].load_capacity >= max_load_capacity)
                {
                    Console.Write("\n\t\t Організувати пошук машин, які відповідають вимогам вантажопідйомності.\n");
                    Console.Write("\tМарка автомобіля: " + arr[i].car_brand);
                    Console.Write("\n\tНомер автомобіля: " + arr[i].number);
                    Console.Write("\n\tМаксимальна швидкість автомобіля: " + arr[i].speed);
                    Console.Write("\n\tМаксимальна вантажопідйомність: " + arr[i].load_capacity);
                }
            }
        }



        public Trans()
        {
            car_brand = "null";
            number = 0;
            speed = 0;        
            load_capacity = 0;
            trailer = "null";
        }
        public Trans(string ?car_brand, int number, int speed, string trailer)
        {
            this.car_brand = car_brand;
            this.number = number;   
            this.speed = speed;          
            this.trailer = trailer;
        }
     

    }
}
