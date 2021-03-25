using System;
using System.Media;
using System.Threading;

namespace ScenarioGame_Console
{
    public class Program_UI
    {
        LevelTwo levelTwo = new LevelTwo();
        GameInfo gameInfo = new GameInfo();
        public void Run()
        {
            StartUpPage();
           
        }
        public void StartUpPage()
        {
            SoundPlayer startUpSound = new SoundPlayer(@"C:\wav_files\startup_sound.wav");
            string title = @"  



                                           $$ $$$$$ $$
                                           $$ $$$$$ $$
                                          .$$ $$$$$ $$.
                                          :$$ $$$$$ $$:
                                          $$$ $$$$$ $$$
                                          $$$ $$$$$ $$$
                                         ,$$$ $$$$$ $$$.
                                        ,$$$$ $$$$$ $$$$.
                                       ,$$$$; $$$$$ :$$$$.
                                      ,$$$$$  $$$$$  $$$$$.
                                     ,$$$$$$' $$$$$  `$$$$$$.
                                   ,$$$$$$$'  $$$$$   `$$$$$$$.
                               ,s$$$$$$$'     $$$$$     `$$$$$$$s.
                             $$$$$$$$$'       $$$$$       `$$$$$$$$$
                             $$$$$Y'          $$$$$          `Y$$$$$
";

            bool keepRunning = true;
            while(keepRunning)
            {
                startUpSound.Play();
                Console.WriteLine(title);
                Thread.Sleep(5000);
                Menu();

            }
        }
        public void Menu()
        {
            SoundPlayer selectionSound = new SoundPlayer(@"C:\wav_files\515736__matrixxx__retro-coin-06.wav");
            SoundPlayer errorSound = new SoundPlayer(@"C:\wav_files\450616__breviceps__8-bit-error.wav");
            SoundPlayer menuSound = new SoundPlayer(@"C:\wav_files\MenuMusic_SongofStorms.wav");
            
            //easter egg sound
            //selection sounds within game
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
                menuSound.PlayLooping();
                string input = Console.ReadLine();
                switch(input)
                {
                    case "1":
                        //Start game
                        selectionSound.Play();
                        levelTwo.Opening();
                        menuSound.Stop();
                        break;
                    case "2":
                        //game info
                        gameInfo.GameInformation();
                        break;
                    case "3":
                        //Exit
                        selectionSound.Play();
                        //keepRunning = false;
                        Environment.Exit(0);
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
//        public void Credits()
//        {
//            Console.Clear();
//            string closing = @"

//                                     ^^
//    ^^      ..                                       ..
//            []                                       []
//          .:[]:_          ^^                       ,:[]:.
//        .: :[]: :-.                             ,-: :[]: :.
//      .: : :[]: : :`._                       ,.': : :[]: : :.
//    .: : : :[]: : : : :-._               _,-: : : : :[]: : : :.
//_..: : : : :[]: : : : : : :-._________.-: : : : : : :[]: : : : :-._
//_:_:_:_:_:_:[]:_:_:_:_:_:_:_:_:_:_:_:_:_:_:_:_:_:_:_:[]:_:_:_:_:_:_
//!!!!!!!!!!!![]!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!![]!!!!!!!!!!!!!
//^^^^^^^^^^^^[]^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^[]^^^^^^^^^^^^^
//            []                                       []
//            []                                       []
//            []                                       []
// ~~^-~^_~^~/  \~^-~^~_~^-~_^~-^~_^~~-^~_~^~-~_~-^~_^/  \~^-~_~^-~~-
//~ _~~- ~^-^~-^~~- ^~_^-^~~_ -~^_ -~_-~~^- _~~_~-^_ ~^-^~~-_^-~ ~^
//   ~ ^- _~~_-  ~~ _ ~  ^~  - ~~^ _ -  ^~-  ~ _  ~~^  - ~_   - ~^_~
//     ~-  ^_  ~^ -  ^~ _ - ~^~ _   _~^~-  _ ~~^ - _ ~ - _ ~~^ -
//        ~^ -_ ~^^ -_ ~ _ - _ ~^~-  _~ -_   ~- _ ~^ _ -  ~ ^-
//            ~^~ - _ ^ - ~~~ _ - _ ~-^ ~ __- ~_ - ~  ~^_-
//                ~ ~- ^~ -  ~^ -  ~ ^~ - ~~  ^~ - ~
//";
//            Console.WriteLine(closing);
//            Thread.Sleep(10000);
//            StartUpPage();
//        }

    }
}