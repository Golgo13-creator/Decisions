using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScenarioGame_Console
{
    public class GameInfo
    {
        
        public void GameInformation()
        {
            Console.Clear();
            string gameInfo = "This game will put you through various scenarios.\n" +
                "These scenarios will require you to make decisions based on the question.\n " +
                "To answer you will press either 1 or 2";
            Console.WriteLine(gameInfo);
            Console.WriteLine("\n\n\nPress any key to return to the main menu");
            Console.ReadKey();
        }
        
    }
}
