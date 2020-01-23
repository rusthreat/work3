using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme3_HomeWork
{
    class Program
    {

        static string User;
        static bool human;
        static string str;
        static int diff;
        static int mode;
        static string User1;
        static string User2;
        static int userTry;
        static int gameNumber;

        static void Main(string[] args)
        {
            #region УСЛОВИЯ ЗАДАЧИ
            // Просматривая сайты по поиску работы, у вас вызывает интерес следующая вакансия:

            // Требуемый опыт работы: без опыта
            // Частичная занятость, удалённая работа
            //
            // Описание 
            //
            // Стартап «Micarosppoftle» занимающийся разработкой
            // многопользовательских игр ищет разработчиков в свою команду.
            // Компания готова рассмотреть C#-программистов не имеющих опыта в разработке, 
            // но желающих развиваться в сфере разработки игр на платформе .NET.
            //
            // Должность Интерн C#/
            //
            // Основные требования:
            // C#, операторы ввода и вывода данных, управляющие конструкции 
            // 
            // Конкурентным преимуществом будет знание процедурного программирования.
            //
            // Не технические требования: 
            // английский на уровне понимания документации и справочных материалов
            //
            // В качестве тестового задания предлагается решить следующую задачу.
            //
            // Написать игру, в которою могут играть два игрока.
            // При старте, игрокам предлагается ввести свои никнеймы.
            // Никнеймы хранятся до конца игры.
            // Программа загадывает случайное число gameNumber от 12 до 120 сообщая это число игрокам.
            // Игроки ходят по очереди(игра сообщает о ходе текущего игрока)
            // Игрок, ход которого указан вводит число userTry, которое может принимать значения 1, 2, 3 или 4,
            // введенное число вычитается из gameNumber
            // Новое значение gameNumber показывается игрокам на экране.
            // Выигрывает тот игрок, после чьего хода gameNumber обратилась в ноль.
            // Игра поздравляет победителя, предлагая сыграть реванш
            // 
            // * Бонус:
            // Подумать над возможностью реализации разных уровней сложности.
            // В качестве уровней сложности может выступать настраиваемое, в начале игры,
            // значение userTry, изменение диапазона gameNumber, или указание большего количества игроков (3, 4, 5...)

            // *** Сложный бонус
            // Подумать над возможностью реализации однопользовательской игры
            // т е игрок должен играть с компьютером

            #endregion

            // Название игры
            string gamename = "ИГРА \"ЧИСЛА\"";

            #region ВЫБОР СЛОЖНОСТИ
            /* Признак сложности:             
             * 0 - простой
             * 1 - средний
             * 2 - сложный
             */
            
            // Полный цикл для начала игры с нуля
            while(true)
            {
                while(true)
                {
                    Console.Clear();

                    // Вывод названия игры по центру экрана
                    Console.SetCursorPosition(Console.WindowWidth / 2 - gamename.Length / 2, Console.WindowHeight / 2 - 3);
                    Console.WriteLine(gamename);
                
                    // Обработка выбора сложности
                    str = "Выберите уровень сложности:";
                    Console.SetCursorPosition(Console.WindowWidth / 2 - str.Length / 2, Console.WindowHeight / 2);
                    Console.WriteLine(str);
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 32 / 2, Console.WindowHeight / 2 + 1);
                    Console.WriteLine("0 - простой (1-3). Диапозон 30-39");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 32 / 2, Console.WindowHeight / 2 + 2);
                    Console.WriteLine("1 - средний (1-4). Диапозон 20-29");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 32 / 2, Console.WindowHeight / 2 + 3);
                    Console.WriteLine("2 - сложный (1-5). Диапозон 10-19");
                    Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + 4);

                    diff = Convert.ToInt32(Console.ReadLine());

                    if (diff >= 0 && diff <= 2)
                    // обработка верного выбора сложности
                    {
                        break;
                    }
                    // обработка неверного выбора сложности
                    else
                    {
                        str = "Неверный выбор";
                        Console.SetCursorPosition(Console.WindowWidth / 2 - str.Length / 2, Console.WindowHeight / 2 + 5);
                        Console.WriteLine(str);
                        str = "Нажмите любую клавишу...";
                        Console.SetCursorPosition(Console.WindowWidth / 2 - str.Length / 2, Console.WindowHeight / 2 + 6);
                        Console.WriteLine(str);
                        Console.ReadKey();
                    }
                }  
                #endregion
            
                #region ВЫБОР РЕЖИМА ИГРЫ
                /* Признак режима игры
                 * 0 - для 2х игроков
                 * 1 - с компьютером
                 */

                while(true)
                {
                    Console.Clear();

                    // Вывод названия игры по центру экрана
                    Console.SetCursorPosition(Console.WindowWidth / 2 - gamename.Length / 2, Console.WindowHeight / 2 - 3);
                    Console.WriteLine(gamename);
                
                    // Режим сложности для вывода
                    switch (diff)
                    {
                        case 0: str = "простой"; break;
                        case 1: str = "средний"; break;
                        case 2: str = "сложный"; break;
                    }
                        
                    // Вывод ранее выбранного уровня сложности
                    str = $"Уровень сложности: {str}";
                    Console.SetCursorPosition(Console.WindowWidth / 2 - str.Length / 2, Console.WindowHeight / 2 - 1);
                    Console.WriteLine(str);

                    // Режимы игры
                    str = "Выберите режим игры:";         
                    Console.SetCursorPosition(Console.WindowWidth / 2 - str.Length / 2, Console.WindowHeight / 2 + 1);
                    Console.WriteLine(str);
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 18 / 2, Console.WindowHeight / 2 + 2);
                    Console.WriteLine("0 - для 2х игроков");
                    Console.SetCursorPosition(Console.WindowWidth / 2 - 18 / 2, Console.WindowHeight / 2 + 3);
                    Console.WriteLine("1 - с компьютером");
                    Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + 4);

                    // Выбор режима игры
                    mode = Convert.ToInt32(Console.ReadLine());

                    if (mode >= 0 && mode <= 1)
                    // обработка верного выбора сложности
                    {
                        Console.Clear();

                        // Вывод названия игры по центру экрана
                        Console.SetCursorPosition(Console.WindowWidth / 2 - gamename.Length / 2, Console.WindowHeight / 2 - 3);
                        Console.WriteLine(gamename);
                
                        str = "строка";
                
                        // Режим сложности для вывода
                        switch (diff)
                        {
                            case 0: str = "простой"; break;
                            case 1: str = "средний"; break;
                            case 2: str = "сложный"; break;
                        }
                        
                        // Вывод ранее выбранного уровня сложности
                        str = $"Уровень сложности: {str}";
                        Console.SetCursorPosition(Console.WindowWidth / 2 - str.Length / 2, Console.WindowHeight / 2 - 1);
                        Console.WriteLine(str);

                        switch (mode)
                        {
                            case 0: str = "для 2х игроков"; break;
                            case 1: str = "с компьютером "; break;
                        }
                    
                        str = $"Режим игры: {str}";
                        Console.SetCursorPosition(Console.WindowWidth / 2 - str.Length / 2, Console.WindowHeight / 2);
                        Console.WriteLine(str);

                        break;
                    }
                    // обработка неверного выбора сложности
                    else
                    {
                        str = "Неверный выбор";
                        Console.SetCursorPosition(Console.WindowWidth / 2 - str.Length / 2, Console.WindowHeight / 2 + 5);
                        Console.WriteLine(str);
                        str = "Нажмите любую клавишу...";
                        Console.SetCursorPosition(Console.WindowWidth / 2 - str.Length / 2, Console.WindowHeight / 2 + 6);
                        Console.WriteLine(str);
                        Console.ReadKey();
                    }
                }
                #endregion
            
                #region ВВОД ИМЕН ИГРОКОВ
                str = "Введите имя 1го игрока:"; 
                Console.SetCursorPosition(Console.WindowWidth / 2 - str.Length / 2, Console.WindowHeight / 2 + 1);
                Console.WriteLine(str);
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + 2);
                User1 = Console.ReadLine();

                str = "Введите имя 2го игрока:";

                if (mode == 0)
                {
                    str = "Введите имя 2го игрока:"; 
                    Console.SetCursorPosition(Console.WindowWidth / 2 - str.Length / 2, Console.WindowHeight / 2 + 3);
                    Console.WriteLine(str);
                    Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + 4);
                    User2 = Console.ReadLine();
                }
                else
                {
                    User2 = "Компьютер";
                }
                #endregion

                #region ИГРА
                // Генерация случайного числа
                Random rand = new Random();

                // Генерация игрового числа для разных уровней сложности

                if (diff == 0)
                {
                    gameNumber = rand.Next(30, 39);
                }
                else if (diff == 1)
                {
                    gameNumber = rand.Next(20, 29);
                }
                else
                {
                    gameNumber = rand.Next(10, 19);
                }

                // Начало игры
                Console.Clear();

                int count = 1;

                switch (diff)
                {
                    case 0: str = "1,2,3. Диапозон 30-39"; break;
                    case 1: str = "1,2,3,4. Диапозон 20-29"; break;
                    case 2: str = "1,2,3,4,5. Диапозон 10-19"; break;
                }

                Console.WriteLine($"Начало игры. Число: {gameNumber}");
                Console.WriteLine($"Сложность игры: {diff}. Доступные цифры: {str}");
            
                while (true)
                {
                    if (count == 1)
                    // первый ход в игре
                    {
                        User = User1;
                        human = true;
                    }
                    else
                    {
                        if (count % 2 == 0)
                        // Определение текущего игрока по счетчику count: если нечетный - 1, если четный - 2
                        // ход второго игрока
                        {
                            User = User2;
                            human = (mode == 0) ? true : false;
                        }
                        else
                        // ход первого игрока
                        {
                            User = User1;
                            human = true;
                        }
                    }

                    Console.WriteLine($"\nХод {count} - {User} ");
                    Console.WriteLine($"Число {gameNumber}");
                
                    if (human)
                    // получение числа хода игрока
                    {
                        userTry = Convert.ToInt32(Console.ReadLine());
                    
                        if (userTry >= 1 && userTry <=3 && diff == 0)
                        {
                    
                        }
                        else if (userTry >= 1 && userTry <=4 && diff == 1)
                        {
                    
                        }
                        else if (userTry >= 1 && userTry <=5 && diff == 2)
                        {
                    
                        }
                        else
                        {
                            Console.WriteLine("Неверный ход. Попробуйте еще раз");
                            continue;
                        }
                    }
                    else
                    // расчет хода компьютера
                    {
                        if (diff == 0)
                        {
                            userTry = rand.Next(1, 4);
                        }
                        else if (diff == 1)
                        {
                            userTry = rand.Next(1, 5);
                        }
                        else if (diff == 2)
                        {
                            userTry = rand.Next(1, 6);
                        }
                        Console.WriteLine(userTry);
                    }

                    gameNumber = gameNumber - userTry;

                    // Проверка на завершение игры
                    if (gameNumber <= 0)
                    {
                        Console.WriteLine($"\nИгра завершена! {User} победил!");
                        break;
                    }
                    //else if (gameNumber < 0)
                    //{
                    //    Console.WriteLine($"\nИгра завершена! Число = {gameNumber}. Ничья!");
                    //    break;
                    //}

                    count++;
                }

                Console.WriteLine("\nНачать новую игру? (y/n)");
                str = Console.ReadLine();

                if (str == "y")
                {
                    continue;
                }
                else
                {
                    break;
                }

            }

            #endregion

            //Console.ReadKey();

            // Демонстрация
            // Число: 12,
            // Ход User1: 3
            //
            // Число: 9
            // Ход User2: 4
            //
            // Число: 5
            // Ход User1: 2
            //
            // Число: 3
            // Ход User2: 3
            //
            // User2 победил!
                       
        }
    }
}
