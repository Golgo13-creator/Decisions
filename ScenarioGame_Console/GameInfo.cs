using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ScenarioGame_Console
{
    public class GameInfo
    {
        SoundPlayer menuSound = new SoundPlayer(@"C:\wav_files\MenuMusic_SongofStorms.wav");
        public void GameInformation()
        {
            Console.Clear();
            string gameInfo = "You find yourself in an unknown place.\n" +
                "You will have to answer the prompts correctly in order to find you way out.\n " +
                "To answer you will press either 1 or 2 followed by the enter key.";
            menuSound.PlayLooping();
            Console.WriteLine(gameInfo);
            Console.WriteLine("\n\n\nPress any key to return to the main menu");
            Console.ReadKey();
        }
        
    }
}
