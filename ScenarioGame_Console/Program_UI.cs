using System;
using System.Media;

namespace ScenarioGame_Console
{
    public class Program_UI
    {
        LevelOne levelOne = new LevelOne();
        GameInfo gameInfo = new GameInfo();
        public void Run()
        {
            Menu();
        }
        public void Menu()
        {
            SoundPlayer startUpSound = new SoundPlayer(@"C:\wav_files\startup_sound.wav");
            startUpSound.Play();
            bool keepRunning = true;
            while(keepRunning)
            {
                Console.Clear();
                string title = @"
  _____            _     _                 
 |  __ \          (_)   (_)                
 | |  | | ___  ___ _ ___ _  ___  _ __  ___ 
 | |  | |/ _ \/ __| / __| |/ _ \| '_ \/ __|
 | |__| |  __/ (__| \__ \ | (_) | | | \__ \
 |_____/ \___|\___|_|___/_|\___/|_| |_|___/
                                           ";                                                                                                                                                       

                Console.WriteLine(title);
                Console.WriteLine("\n\nStart Menu\n" +
                      "\n\nSelect from the list of options\n" +
                      "1. Start Game\n" +
                      "2. Game Info\n" +
                      "3. Exit\n");
                string input = Console.ReadLine();
                switch(input)
                {
                    case "1":
                        //Start game
                        levelOne.FirstScenario();
                        break;
                    case "2":
                        //game info
                        gameInfo.GameInformation();
                        break;
                    case "3":
                        //Exit
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            }
        }

    }
}