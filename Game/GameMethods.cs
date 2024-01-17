using System.Security.Cryptography.X509Certificates;

namespace Game;

public abstract class GameMethods
{

    public static void Run()
    {
        Console.Clear();
        Character protagonist = new("David", 100, 10, 10);
        Character antagosnit = new("Majid", 100, 10, 50);
        //Character regular = new("noName", 100,);
        Console.SetCursorPosition(protagonist.HPosition, protagonist.VPosition);
        System.Console.Write("P");
        Console.SetCursorPosition(antagosnit.HPosition, antagosnit.VPosition);
        System.Console.Write("A");

        while (true)
        {
            //System.Console.WriteLine(Console.ReadKey().Key.ToString());

            switch (Console.ReadKey(true).Key.ToString())
            {
                case "NumPad0":
                    Jump(antagosnit, protagonist).Wait();
                    continue;
                case "D1":
                    Shoot(antagosnit, protagonist).Wait();
                    continue;
                case "S":
                    Jump(protagonist, antagosnit).Wait();
                    break;
                case "W":
                    Shoot(protagonist, antagosnit).Wait();
                    continue;
                default:
                    continue;
            }
        }

        static async Task Jump(Character character1, Character character2)
        {
            int c = 0;
            while (c <= 2)
            {
                Console.Clear();
                System.Console.WriteLine();
                character1.VPosition -= c;
                Console.SetCursorPosition(character1.HPosition, character1.VPosition);
                Console.Write("***");
                Console.SetCursorPosition(character2.HPosition, character2.VPosition);
                Console.Write("***");
                Thread.Sleep(5);
                c++;
            }
            c = 2;
            while (c >= 0)
            {
                Console.Clear();
                character1.VPosition += c;
                Console.SetCursorPosition(character1.HPosition, character1.VPosition);
                Console.Write("***");
                Console.SetCursorPosition(character2.HPosition, character2.VPosition);
                Console.Write("***");
                Thread.Sleep(5);
                c--;
            }
        }

        static async Task Shoot(Character character1, Character character2)
        {

        }
    }



}





