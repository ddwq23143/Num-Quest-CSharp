using System;
using System.IO;

namespace RandomNum
{
    public class Main
    {
        public void Run()
        {
            Random random = new Random();
            int num = random.Next(1, 100);
            int attempts = 0;
            int input;
            string path = @"YOUR_ADDRESS_FROM_FILE";

            while (true)
            {
                Console.WriteLine("Введите ваш вариант: ");
                input = int.Parse(Console.ReadLine());
                attempts++;

                if (input == num)
                {
                    Console.WriteLine($"Ты угадал число {num} за {attempts} попыток");
                    File.WriteAllText(path, $"Ты угадал число {num} за {attempts} попыток");
                    break;
                }
                else if (input < num)
                {
                    Console.WriteLine($"{input} меньше загадонного числа");
                }
                else if (input > num)
                {
                    Console.WriteLine($"{input} больше загадонного числа");
                }
            }
        }
    }
}
