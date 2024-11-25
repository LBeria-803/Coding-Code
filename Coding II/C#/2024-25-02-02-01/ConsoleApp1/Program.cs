using System.Globalization;

namespace _2024_25_02_02_01
{
    internal class Program
    {
        // the Main method that ALL
        // programs MUST have
        // The main entry point

        static void Main(string[] args)
        {
            DoExample02();
        }
        static void DoExample01()
        {
            SayHello();

            #region basic variables and data types

            int i = 100; // integer data type
            Console.WriteLine(i);

            bool isTrue = false; // boolean data type
            Console.WriteLine(isTrue);

            char letter = 'a'; // char data type
            Console.WriteLine(letter);

            float gpa = 4.5f; // floating point data type; requires 'f' after the floating point value
            Console.WriteLine(gpa);

            string name = "Casey Diya";
            Console.WriteLine(name);

            Console.WriteLine("Age: ");
            string? input = Console.ReadLine();

            #endregion

            uint age = 15;

            #region if statements

            if (input != null)
            {
                Console.WriteLine("You entered " + input);
                try
                {
                    age = uint.Parse(input);
                }
                catch (FormatException e)
                {
                    Console.WriteLine(input + " isn't a valid age!");
                    Console.WriteLine("Defaulting to age " + age);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine("Age is either too low or too high");
                    Console.WriteLine("Defaulting to age " + age);

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }

            if (age < 5)
            {
                Console.WriteLine("You are a baby");
            }
            else if (age < 13)
            {
                Console.WriteLine("You are a child");
            }
            else if (age >= 13 && age < 20)
            {
                Console.WriteLine("You are a teenager");
            }
            else if (age >= 20 && age < 30)
            {
                Console.WriteLine("You are a young adult");
            }
            else
            {
                Console.WriteLine("You are over the hill :-)");
            }

            #endregion

            #region Switch Statements

            Console.WriteLine("favorite Month? ");
            input = Console.ReadLine();

            if (input != null)
            {
                switch (input.ToLower())
                {
                    case "January":
                        Console.WriteLine("It usually snows on your birthday");
                        break;
                    case "February":
                        Console.WriteLine("It usually snows on your birthday");
                        break;
                    case "March":
                        Console.WriteLine("Trees always look nice on your birthday. ");
                        break;
                    case "April":
                        Console.WriteLine("It's usually rainy on your birthday");
                        break;
                    case "May":
                        Console.WriteLine("School is almost over on your birthday");
                        break;
                    case "June":
                        Console.WriteLine("It's usually hot on your birthday");
                        break;
                    case "July":
                        Console.WriteLine("You are usually having a pool party on your birthday");
                        break;
                    case "August":
                        Console.WriteLine("It's usually the start of school on your birthday");
                        break;
                    case "September":
                        Console.WriteLine("It's usually cooler on your birthday");
                        break;
                    case "October":
                        Console.WriteLine("Your birthday is in spooky season");
                        break;
                    case "November":
                        Console.WriteLine("It's usually getting colder on your birthday");
                        break;
                    case "December":
                        Console.WriteLine("Your birthday is always around christmas time on your birthday");
                        break;
                    default:
                        Console.WriteLine("You entered an invalid month");
                        break;

                        
                }
            }
            #endregion

            SayBye();

            #region arrays
            // declares and allocates an array with 5 ints (def 0)
            int[] numbers = new int[5];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            // ITERATE through the array
            // in order to access each item
            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine();


            int[,] mdNumbers = new int[3, 2];
            mdNumbers[0, 0] = 1;
            mdNumbers[0, 1] = 2;
            mdNumbers[1, 0] = 3;
            mdNumbers[1, 1] = 4;
            mdNumbers[2, 0] = 5;
            mdNumbers[2, 1] = 6;

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 2; y++)
                {
                    Console.WriteLine(mdNumbers[x, y]);
                }
            }
            #endregion
        }

        static void DoExample02()
        {
            List<int> numbers = new List<int> ();
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(40);
            numbers.Add(50);

            List<IAttackable> actors = new List<IAttackable>();
            actors.Add(new Player("Conner"));
            actors.Add(new Player("Daniel"));
            actors.Add(new Player("Trevor"));
            actors.Add(new Player("Peyton"));
            actors.Add(new Player("Jenna"));
            actors.Add(new Player("Kanyon"));
            actors.Add(new Player("Silas"));
            actors.Add(new Player("Tyson"));
            actors.Add(new Player("Dylan"));
            actors.Add(new Player("Layton"));
            actors.Add(new Player("Landon B."));
            actors.Add(new Player("Levi"));
            actors.Add(new Player("Brandon"));
            actors.Add(new Player("Landon R."));
            actors.Add(new Enemy("Mr. Scott"));


            foreach (IAttackable attackable in actors)
            {
                Console.WriteLine(attackable.GetType());
            }

            Enemy enemy = new Enemy("Mr. Scott");
            Console.WriteLine(enemy.Attack());
        }

        static void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        static void SayBye()
        {
            Console.WriteLine("Goodbye!");
        }

        /* the quick brown fox jumps over the lazy dog
         * the quich brown fox jumps over the lazy dog 
         * the quick brown fox jumps over the lazy dog
         * the quick brown fox jumps over the lazy dog
         * the quick brown fox jumps over the lazy dog
         * the quick brown fox jumps over the lazy dog
         * the quick brown fox jumps over the lazy dog
         * the quick brown fox jumps over the lazy dog
         * THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG
         * THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG
         * THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG
         * THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG
         * ThE qUiCk BrOwN fOx JuMpS oVeR tHe LaZy DoG
         */

        // 1) basics / data -> variables data types
        // 2) intermediate level -> classes, generics, ...
        // 3) advanced parts
    }
    interface IAttackable
    {
        public string Attack();
    }

    class Actor
    {
        public Actor(string actorName)
        {
            Name = actorName;
        }
    }

    class Player :IAttackable
    {
        private string name = "";

        public Player(string playerName)
        {
            name = playerName;
        }

        public string Name { get; set; }

        public string Attack()
        {
            return Name + " attacks!";
        }
    }

    class Enemy :IAttackable
    {
        public Enemy(string enemyName) 
        {
            Name = enemyName;
        }

        public string Name { get; set; }

        public string Attack()
        {
            string msg = 
        }
    }

    class NPC : IAttackable
    {
        public NPC(string npcName)
        {

        }

        public string Attack()
        {
            return "NPC's can't attack, dummy!";
        }

    }
}