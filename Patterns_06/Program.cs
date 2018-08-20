using System;
using System.Collections.Generic;

namespace Patterns_06
{
    class Program
    {
        static void Main(string[] args)
        {
            var teamlead = new TeamLeadHandler();
            var director = new DirectorHandler();
            var president = new PresidentHandler();

            teamlead.setNext(director).setNext(president);

            foreach (var money in new List<int> { 200, 10, 5500, 100000 })
            {
                Console.WriteLine($"Client: Give me money {money}?");
                Console.WriteLine(teamlead.GetMoney(money));
            }
        }
    }
}
