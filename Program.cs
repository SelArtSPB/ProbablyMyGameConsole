using System.Security.Principal;

namespace MyGame2._0
{
    internal class Game
    {

        static void Main()
        {
            Start();
            Role();
            Stats();
        }
        static void Start()
        {
            Console.WriteLine("Хочешь начать игру?\n1 - Да\n2 - Нет");
            string start = Console.ReadLine();
            start = start.ToLower();
            if (start == "да" || start == "1")
            {
                Console.Clear();

            }
            else if (start == "нет" || start == "2")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Stats();
            }
        }
        static string role;
        static void Role()
        {
            Console.Write("'Новая душа?' - раздался голос из темноты\n'Мне павда жаль, что так получилось'\n'Но, ты умер'\n'Не волнуйся, я помогу тебе'");
            Console.ReadKey();
            Console.WriteLine("\nТемнота резко изменяеться на яркий свет и перед тобой появляются неизвестные тебе образы");
            Console.ReadKey();
            Console.WriteLine("'Душа' - раздался голос у тебя в голове\n'Эти образы,герои прошлого'\n'Выбери одного из них и ты получишь его силу и навыки'");
            Console.ReadKey();
            Console.WriteLine("\nВоин - герой прошедший безчисленное количество боёв (увеличиное здоровье и урон)");
            Console.WriteLine("Плут - городская жизнь далась ему очень тудно (увеличеное здоровье и скорость)");
            Console.WriteLine("Бомж - брошенный одиночка в этом жестоком мире (без бонусов)");
            Console.ReadKey();
            do
            {
                Console.Clear() ;
                Console.WriteLine("'Душа, выбирай свою судьбу'");
                Console.WriteLine("1 - Воин\n2 - Плут\n3 - Бомж");
                string vibor = Console.ReadLine();
                vibor.ToLower();
                if (vibor == "воин" || vibor == "1")
                {
                    Console.Clear();
                    Console.WriteLine("Ты точно хочешь выбрать его?\n1 - Да\n2 - Нет");
                    string a = Console.ReadLine();
                    if (a == "да" || a == "1")
                    {
                        role = "ВОИН";
                    }
                    else if (a == "нет" || a == "2")
                    {
                        role = " ";
                    }

                }
                else if (vibor == "плут" || vibor == "2")
                {
                    Console.Clear();
                    Console.WriteLine("Ты точно хочешь выбрать его?\n1 - Да\n2 - Нет");
                    string a = Console.ReadLine();
                    if (a == "да" || a == "1")
                    {
                        role = "ПЛУТ";
                    }
                    else if (a == "нет" || a == "2")
                    {
                        role = " ";
                    }
                }
                else if (vibor == "бомж" || vibor == "3")
                {
                    Console.Clear();
                    Console.WriteLine("Ты точно хочешь выбрать его?\n1 - Да\n2 - Нет");
                    string a = Console.ReadLine();
                    if (a == "да" || a == "1")
                    {
                        role = "БОМЖ";
                    }
                    else if (a == "нет" || a == "2")
                    {
                        role = " ";
                    }
                }
                else
                {
                    Console.Clear();
                }
            } while (role != "ВОИН" && role != "ПЛУТ" && role != "БОМЖ");
            
        }
        static void Stats()
        {

        }
        static void LevelUP()
        {

        }
        static void Sborka()
        {

        }
    }
}
