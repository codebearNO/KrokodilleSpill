using System.Threading.Tasks.Sources;

namespace KrokodilleSpill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int score = 0;
            while (score < 10) 
            {
                int rand2 = random.Next(1, 11);
                int rand1 = random.Next(1, 11);
                Console.WriteLine($"Score: {score}");
                Console.WriteLine($"{rand1} _ {rand2}");

                var guess = Console.ReadLine();

                int result = guess switch
                {
                    "=" => rand1 == rand2 ? score++ : score--,
                    "<" => rand1 < rand2 ? score++ : score--,
                    ">" => rand1 > rand2 ? score++ : score--,
                    _ => score = 20
                };
                Console.Clear();
            }

            Console.WriteLine(score != 20 ? "You win!" : "You lose!");
        }
    }
}