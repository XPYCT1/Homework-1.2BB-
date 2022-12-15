namespace Homework_1._2BB_
{
internal class Program
{
    static void Main(string[] args)
    {
        int[,] arr1 = new int[50, 5];
        Random rand = new Random();
        for (int i = 0; i < 50; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                arr1[i, j] = rand.Next(50, 100);
                Console.Write("{0}\t", arr1[i, j]);
            }
        }
        int[,] arr2 = new int[50, 5];
        for (int i = 0; i < 50; i++)
        {
            for (int j = 0; j < 5; j++)
            {

                arr2[i, j] = rand.Next(50, 100);
                Console.WriteLine("{0}\t", arr2[i, j]);
            }
        }
        Monsters[] monsterArray = new Monsters[50];
        for (int i = 0; i < 50; i++)
        {
            Monsters m = new Monsters();

            m.health = rand.Next(50, 100); ;
            m.armor = rand.Next(50, 100); ;
            m.age = rand.Next(50, 100); ;
            m.max_age = rand.Next(50, 100); ;
            m.power = rand.Next(50, 100); ;
            monsterArray[i] = m;
        }
        Monsters[] monsterArray1 = new Monsters[50];
        for (int i = 0; i < 50; i++)
        {
            Monsters b = new Monsters();
            b.health = arr2[i, 0];
            b.armor = arr2[i, 1];
            b.age = arr2[i, 2];
            b.max_age = arr2[i, 3];
            b.power = arr2[i, 4];
            monsterArray1[i] = b;
        }


        for (int i = 0; i < 50; i++)
        {
            monsterArray[i].Attack(monsterArray[i], monsterArray1[i]);


        }
        for (int i = 0; i < 50; i++)
        {
            monsterArray[i].getOlder(monsterArray[i]);
            Console.WriteLine($"Монстер 1-го поколения {i + 1} умер от старости ");

        }

        for (int i = 0; i < 50; i++)
        {
            monsterArray1[i].getOlder(monsterArray1[i]);
            Console.WriteLine($"Монстер 2-го поколения {i + 1} умер от старости ");

        }

        for (int i = 0; i < 50; i++)
        {
            if (monsterArray[i].isLive == false)
                monsterArray[i] = null;
            Console.WriteLine($"Монстер {i + 1} умер");

        }
        int[,] arr3 = new int[50, 5];

        for (int i = 0; i < 50; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                arr3[i, j] = rand.Next(arr1[i, j] - 20, arr1[i, j] + 20);
                Console.Write("{0}\t", arr3[i, j]);
            }
        }
        Monsters[] monsterArray2 = new Monsters[50];
        for (int i = 0; i < 50; i++)
        {
            Monsters с = new Monsters();
            с.health = arr3[i, 0];
            с.armor = arr3[i, 1];
            с.age = arr3[i, 2];
            с.max_age = arr3[i, 3];
            с.power = arr3[i, 4];
            monsterArray2[i] = с;
        }
        double k = 0;
        for (int i = 0; i < 50; i++)
        {
            k = k + arr3[i, 0] + arr3[i, 0] + arr1[i, 0];
            k = k / 3;
        }

        int a = 0;
        Console.Write($"Средние здоровье популяции {k} ");
    }






    internal class Monsters
    {
        public int health { get; set; }
        public int armor { get; set; }
        public int age { get; set; }

        public bool isLive { get; set; }
        public int max_age { get; set; }
        public int power { get; set; }

        public void Attack(Monsters monsterArray, Monsters monsterArray1)
        {
            for (int i = 0; i < 50; i++)
            {
                monsterArray.health -= monsterArray1.power;
                monsterArray.health += monsterArray.armor;


                break;
            }
        }
        public void getOlder(Monsters monsterArray)
        {
            for (int i = 0; i < 50; i++)
            {
                if (monsterArray.age >= monsterArray.max_age)
                {
                    monsterArray.max_age -= monsterArray.age;


                    if (monsterArray.max_age < 0)
                        monsterArray.isLive = false;
                    break;
                }


            }
        }


    }
}
}
