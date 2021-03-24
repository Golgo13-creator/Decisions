using System;
using System.Media;

namespace ScenarioGame_Console
{
    public class Program_UI
    {
        LevelTwo levelTwo = new LevelTwo();
        GameInfo gameInfo = new GameInfo();
        public void Run()
        {
            Menu();
        }
        public void Menu()
        {
            SoundPlayer startUpSound = new SoundPlayer(@"C:\wav_files\startup_sound.wav");
            SoundPlayer selectionSound = new SoundPlayer(@"C:\wav_files\515736__matrixxx__retro-coin-06.wav");
            SoundPlayer errorSound = new SoundPlayer(@"C:\wav_files\450616__breviceps__8-bit-error.wav");
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
                        selectionSound.Play();
                        levelTwo.Opening();
                        break;
                    case "2":
                        //game info
                        selectionSound.Play();
                        gameInfo.GameInformation();
                        break;
                    case "3":
                        //Exit
                        selectionSound.Play();
                        keepRunning = false;
                        break;
                    default:
                        errorSound.Play();
                        Console.WriteLine("Please enter a valid number");
                        Console.ReadKey();
                        break;
                }
                Console.Clear();
            }
        }

    }
}