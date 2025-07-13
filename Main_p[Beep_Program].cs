namespace Beep_Program
{
    internal class Beep_Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("*************************made by nooriplayer2024**********************");
            while (true)
            {
                count++;
                Console.WriteLine("-Beep");
                Console.Beep();
                if (Console.KeyAvailable)
                {
                    Console.ReadKey();
                    Console.WriteLine("-Beep is stopped" + "\n-beep count is [" + count + "]");
                    break;
                }
            }
        }
    }
}
