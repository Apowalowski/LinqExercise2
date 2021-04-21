using System;
using System.Collections.Generic;
using System.Linq;



namespace LinqExercise2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> videoGames = new List<string>
            { "The last of us", "Destiny,", "Super Smash Bros", "Death Stranding", "Call of Duty: Modern Warfare", "Grand Theft Auto"};
           IEnumerable<string> longGameNames = videoGames.OrderByDescending(x => x.Length);
            foreach(var videoGame in longGameNames)
            {
                Console.WriteLine(videoGame);
            }
            
        }
    }
}
