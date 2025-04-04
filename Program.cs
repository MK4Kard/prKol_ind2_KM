using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prKol_ind2_4_KM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите навзвание файла");
            string name = Console.ReadLine();

            if (File.Exists(name))
            {
                string[] file = File.ReadAllLines(name);

                Queue<int> number = new Queue<int>();

                var nums = file.SelectMany(n => n.Split(' '));

                foreach (var num in nums)
                {
                    if (int.TryParse(num, out int result))
                    {
                        number.Enqueue(Convert.ToInt32(num));
                    }
                    else
                    {
                        Console.WriteLine("В файле есть не число");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
                }

                var order_num = number.OrderBy(n => n < 0);

                foreach (var or_n in order_num)
                {
                    Console.WriteLine(or_n);
                }
            }
            else
            {
                Console.WriteLine("Несуществующий файл");
            }

            Console.ReadLine();
        }
    }
}
