int proga = 0;
while (proga != 4)
{

    Console.WriteLine("Выбирите во что хотите сыграть?  \n Угадай число - 1;  \n Таблица умножения - 2;  \n Вывод делитель числа - 3, \n Завершить - 4.");
    int vibor = Convert.ToInt32(Console.ReadLine());

    if (vibor == 1)

    {
        Console.WriteLine("Игра угадай число");
        string cikl1 = "";
        while (cikl1 != "нет")
        {

            int cikl2 = 0;

            Random rnd = new Random();
            int a = rnd.Next(100);

            while (cikl2 == 0)
            {

                Console.WriteLine("Введите число");
                int b = Convert.ToInt32(Console.ReadLine());
                if (a > b)
                {
                    Console.WriteLine("Больше");
                }
                if (b > a)
                {
                    Console.WriteLine("Меньше");
                }
                if (a == b)
                {
                    Console.WriteLine("Правильно");
                    cikl2 = 1;
                }

            }
            Console.WriteLine("Желаете сыграть ещё? Да. Нет.");
            cikl1 = Console.ReadLine();
        }
    }
    if (vibor == 2)
    {
        Console.WriteLine("Таблица умножения");
        int[,] peremenay = new int[11, 11];
        for (int i = 1; i < 11; i++)
        {
            for (int j = 1; j < 11; j++)
            {
                peremenay[i, j] = i * j;
                Console.Write("{0}\t", peremenay[i, j]);
            }
            Console.WriteLine();
        }
    }
    if (vibor == 3)
    {
        string pr;
        pr = "";
        while (pr != "выход")
        {
            Console.WriteLine("Введите число, чьи делители нужно найти.");
            int a = Convert.ToInt32(Console.ReadLine());
            int c;
            for (int b = 1; b <= a; b++)
            {
                c = a % b;
                if (c == 0)
                {
                    Console.WriteLine(b);
                }
            }
            Console.WriteLine("Если хоти завершить напишите 'выход' ");
            pr = Console.ReadLine();
        }
    }
    if (vibor == 4)
    {
        proga = vibor;
    }
    if (vibor > 4 )
    {
        Console.WriteLine("Выберите от 1 до 4");
    }
}