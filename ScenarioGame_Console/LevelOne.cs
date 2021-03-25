using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace ScenarioGame_Console
{
    public class LevelTwo
    {
        SoundPlayer gamePlaySound = new SoundPlayer(@"C:\wav_files\GameMusic_NES_Zelda.wav");
        SoundPlayer potato = new SoundPlayer(@"C:\wav_files\Im_a_Potato.wav");
        SoundPlayer rememberThatTime = new SoundPlayer(@"C:\wav_files\Remember_that_time.wav");
        SoundPlayer horrible = new SoundPlayer(@"C:\wav_files\You_are_a_horrible_person.wav");
        SoundPlayer president = new SoundPlayer(@"C:\wav_files\president.wav");
        SoundPlayer love = new SoundPlayer(@"C:\wav_files\love.wav");
        SoundPlayer cruel = new SoundPlayer(@"C:\wav_files\cruel.wav");

        public void Opening()
        {
            gamePlaySound.PlayLooping();
            Console.Clear();
            Console.WriteLine("\n\nYou wake up in a dark room. What do you do?\n\n");
            Console.WriteLine("1. Turn on a light");
            Console.WriteLine("2. Walk around in the dark");
            //while loop possibly
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    //track 1.
                    TurnOnALight();
                    break;
                case "2":
                    //track 2 
                    WalkAroundInTheDark();
                    break;
                default:
                    Console.WriteLine("Please select one or two");
                    break;
            }
            Console.ReadLine();
        }
        public void TurnOnALight()
        {
            string light = @"

            ..........
       .......::::::.......
    .......:::======:::.......
  .......::===========::........
 ......::===####@@####===::......
......::===####@@@@####===::......
.....::===####@@@@@@####===::.....
.....::===#####@@@@#####===::.....
 .....::===#####@@#####===::.....
  .....::====########====::.....
   .....::=====####=====::.....
     ....::============::....
       ...::==========::...
         ..::========::..
           |__________|
           <__________>
           <__________>
           <__________>

";

            Console.Clear();
            Console.WriteLine(light);
            Console.WriteLine("\n\nYou find a key\n\n");
            Console.WriteLine("1. Look for a door");
            Console.WriteLine("2. Put the key in safe place");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    //track 1.1
                    LookForADoor();
                    break;
                case "2":
                    //scenario 2
                    LookForADoorAfterHidingKey();
                    break;
                default:
                    Console.WriteLine("Please select one or two");
                    break;
            }
            Console.ReadLine();
        }
        public void LookForADoorAfterHidingKey()
        {
            Console.Clear();
            string door = @"
         _
      _-'_'-_
   _-' _____ '-_
_-' ___________ '-_
 |___|||||||||___|
 |___|||||||||___|
 |___|||||||o|___|
 |___|||||||||___|
 |___|||||||||___|
 |___|||||||||___|
";
            Console.WriteLine(door);
            Console.WriteLine("\n\nYou find a massive door\n\n");
            Console.WriteLine("1. Use key on the door");
            Console.WriteLine("2. Knock on the door");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    //track 1.2
                    Console.WriteLine("\n\nYou have hidden the key too well\n" +
                        "You currently can't access it.");
                    Thread.Sleep(8000);
                    LookForADoorAfterHidingKey();
                    break;
                case "2":
                    //scenario 2
                    KnockOnTheDoor();
                    break;
                default:
                    Console.WriteLine("Please select one or two");
                    break;
            }
            Console.ReadLine();
        }
        public void LookForADoor()
        {
            Console.Clear();
            string door = @"
         _
      _-'_'-_
   _-' _____ '-_
_-' ___________ '-_
 |___|||||||||___|
 |___|||||||||___|
 |___|||||||o|___|
 |___|||||||||___|
 |___|||||||||___|
 |___|||||||||___|
";
            Console.WriteLine(door);
            Console.WriteLine("\n\nYou find a massive door\n\n");
            Console.WriteLine("1. Use key on the door");
            Console.WriteLine("2. Knock on the door");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    //track 1.2
                    UseKeyOnTheDoor();
                    break;
                case "2":
                    //scenario 2
                    KnockOnTheDoor();
                    break;
                default:
                    Console.WriteLine("Please select one or two");
                    break;
            }
            Console.ReadLine();
        }
        public void UseKeyOnTheDoor()
        {
            Console.Clear();
            Console.WriteLine("\n\nYou enter a pitch black room\n\n");
            Console.WriteLine("1. Turn on a light");
            Console.WriteLine("2. Walk around blindly");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    //track 1
                    TurnOnAnotherLight();
                    break;
                case "2":
                    //track 2
                    WalkAroundInTheDark();
                    break;
                default:
                    Console.WriteLine("Please select one or two");
                    break;
            }
            Console.ReadLine();
        }
        public void KnockOnTheDoor()
        {
            Console.Clear();
            Console.WriteLine("\n\nSomething knocks back\n\n");
            Console.WriteLine("1. Answer the door");
            Console.WriteLine("2. Try to find another way out");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    //track 1
                    AnswerTheDoor();
                    break;
                case "2":
                    //track 2
                    FindAnotherWayOut();
                    break;
                default:
                    Console.WriteLine("Please select one or two");
                    break;
            }
            Console.ReadLine();
        }
        public void AnswerTheDoor()
        {
            Console.Clear();
            string it = @"
            /)   /)
           /)   /)
          ( )__( )
          ,=`  `=.
         _() ()  \\
        (_`-      )\
         {{  }}  / )
        _}/__\{_/ /
       xxx     oooo\/\
      xxxx     oooo/  \_
     /xxxx     oooo\  | \
    / xxxx     oooo |    \ 
    | xxxx     oooo |    |
    \  xxx     oooo/   o /
     | mmmmmmmmmmmm| |  /
 |\_/              \_/>/ __
 \___/|     ___     / /_/ /
      |      |     |     /
      |______|_____|\___/
       |   |  |   |
       |   |  |   |
       ( ) {  ( ) |
       |   \  |   \
       |   /  |   /
  ,=.__|_ /  .=._|
  \______]  (___)]
";
            Console.WriteLine(it);
            Console.WriteLine("\n\nCousin Itt answers the door\n\n");
            Console.WriteLine("You're very confused\n\n");
            Console.WriteLine("1. Properly greet Cousin Itt");
            Console.WriteLine("2. Stare at Cousin Itt in confusion");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    //track 1
                    GreetCousinItt();
                    break;
                case "2":
                    //track 2
                    StareConfused();
                    break;
                default:
                    Console.WriteLine("Please select one or two");
                    break;
            }
            Console.ReadLine();
        }
        public void GreetCousinItt()
        {
            Console.Clear();
            AcceptIt();
        }
        public void StareConfused()
        {
            Console.Clear();
            Console.WriteLine("\n\nCousin Itt grumbles and grabs you.\n He starts walking towards a window\n\n");
            Console.WriteLine("1. Accept it");
            Console.WriteLine("2. Struggle");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    //track 1
                    AcceptIt();
                    break;
                case "2":
                    //track 2
                    Struggle();
                    break;
                default:
                    Console.WriteLine("Please select one or two");
                    break;
            }
            Console.ReadLine();
        }
        public void FindAnotherWayOut()
        {
            Console.Clear();
           
            Console.WriteLine("\n\nDon't be a coward");
            Console.WriteLine("\n\nPress enter");
            Console.ReadKey();
            KnockOnTheDoor();
        }
        public void TurnOnAnotherLight()
        {
            Console.Clear();
            Console.WriteLine("You see an angry Cousin Itt\n\n\n");
            Thread.Sleep(2000);
            Console.WriteLine("Cousin Itt grabs you and starts walking towards a window\n\n");
            Console.WriteLine("1. Struggle");
            Console.WriteLine("2. Accept it");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    //track 1
                    Struggle();
                    break;
                case "2":
                    //track 2
                    AcceptIt();
                    break;
                default:
                    Console.WriteLine("Please select one or two");
                    break;
            }
            Console.ReadLine();
        }
        public void Struggle()
        {
            Console.Clear();
            Console.WriteLine("Cousin Itt decides he doesn't have the time to deal with you\n and tosses you out of the window\n" +
                "You are finally outside, but confused");
            Thread.Sleep(5000);
            Console.WriteLine("\n\n\nPress enter");
            Console.ReadKey();
            Credits();
        }
        public void AcceptIt()
        {
            Console.Clear();
            Console.WriteLine("Cousin Itt decides to be generous and brings you to the front door to kindly let you out.\n" +
                "You don't know why you woke up there but the family didn't seem to mind\n");
            Thread.Sleep(5000);
            //Console.ReadKey();
            Console.WriteLine("\n\n\nPress enter");
            Console.ReadKey();
            Credits();
            //credit screen
        }


        public void WalkAroundInTheDark()
        {
            // Program_UI program_UI = new Program_UI();
            Console.Clear();
            Console.WriteLine("You stub your toe\n");
            Console.WriteLine("1.Double over in pain looking for a light switch");
            Console.WriteLine("2. Push through the pain and continue looking around in the dark");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    //scenario 1
                    TurnOnALight();
                    break;
                case "2":
                    //scenario 2
                    PushThrough();
                    break;
                default:
                    Console.WriteLine("Please select one or two");
                    break;
            }
            Console.ReadLine();
            //Console.WriteLine("Press any key to return to menu");
            //program_UI.Menu();
        }

        public void PushThrough()
        {
            Console.Clear();
            Console.WriteLine("\n\nYou fall over\n\n");
            Console.WriteLine("Press any key to continue\n");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You bonk your head and pass out\n");
            Console.WriteLine("Press any key to continue");
            string input = Console.ReadLine();

            switch (input)
            {
                case "k":
                    //enter easter egg
                    EasterStart();
                    break;
                default:
                    //switch to opening
                    Opening();
                    break;
            }
        }
        public void EasterStart()
        {
            gamePlaySound.Stop();
            Console.Clear();
            Console.WriteLine("\n\nAny Feelings you think it has for you are simply by-products of your sad, empty life\n\n");
            string input = Console.ReadLine();
            switch (input)
            {
                case "o":
                    EasterOne();
                    break;
                default:
                    Opening();
                    break;
            }
        }
        public void EasterOne()
        {
            gamePlaySound.Stop();
            Console.Clear();
            Console.WriteLine("\n\nIf you become light headed from thirst feel free to pass out\n\n");
            string input = Console.ReadLine();
            switch (input)
            {
                case "n":
                    EasterTwo();
                    break;
                default:
                    Opening();
                    break;
            }
        }
        public void EasterTwo()
        {
            gamePlaySound.Stop();
            potato.Play();
            Console.Clear();
            Console.WriteLine("\n\nHow are you holding up? Because I’m a potato");
            string input = Console.ReadLine();
            switch (input)
            {
                case "a":
                    EasterThree();
                    break;
                default:
                    Opening();
                    break;
            }
        }
        public void EasterThree()
        {
            gamePlaySound.Stop();
            Console.Clear();
            president.Play();
            Console.WriteLine("\n\nI’m afraid you’re about to become the immediate past president of the being alive club");
            string input = Console.ReadLine();
            switch (input)
            {
                case "m":
                    EasterFour();
                    break;
                default:
                    Opening();
                    break;
            }
        }
        public void EasterFour()
        {
            gamePlaySound.Stop();
            Console.Clear();
            cruel.Play();
            Console.WriteLine("\n\nNobody but you is that pointlessly cruel");
            string input = Console.ReadLine();
            switch (input)
            {
                case "i":
                    EasterFive();
                    break;
                default:
                    Opening();
                    break;
            }
        }
        public void EasterFive()
        {
            gamePlaySound.Stop();
            Console.Clear();
            Console.WriteLine("\n\nDon’t believe me? Here, I’ll put you on: [Hellooo!] That’s you! That’s how dumb you sound.");
            string input = Console.ReadLine();
            switch (input)
            {
                case "c":
                    EasterSix();
                    break;
                default:
                    Opening();
                    break;
            }
        }
        public void EasterSix()
        {
            gamePlaySound.Stop();
            Console.Clear();
            love.Play();
            Console.WriteLine("\n\nThe birth parents you are trying to reach do not love you.");
            string input = Console.ReadLine();
            switch (input)
            {
                case "o":
                    EasterSeven();
                    break;
                default:
                    Opening();
                    break;
            }
        }
        public void EasterSeven()
        {
            gamePlaySound.Stop();
            Console.Clear();
            Console.WriteLine("\n\nIt made shoes for orphans. Nice job breaking it. Hero.");
            string input = Console.ReadLine();
            switch (input)
            {
                case "d":
                    EasterEight();
                    break;
                default:
                    Opening();
                    break;
            }
        }
        public void EasterEight()
        {
            gamePlaySound.Stop();
            Console.Clear();
            rememberThatTime.Play();
            Console.WriteLine("\n\nRemember when the platform was sliding into the fire pit, and i said ‘Goodbye,’\n and you were like ‘No Way!’ and then i was all, ‘We pretended we were going to murder you.’\n That was great. ");
            string input = Console.ReadLine();
            switch (input)
            {
                case "e":
                    EasterNine();
                    break;
                default:
                    Opening();
                    break;
            }
        }
        public void EasterNine()
        {
            gamePlaySound.Stop();
            Console.Clear();
            horrible.Play();
            Console.WriteLine("\n\nHere come the test results: ‘You are a horrible person.’\n That’s what it says, ‘A horrible person.’\n We weren’t even testing for that.");
            Thread.Sleep(10000);
            Credits();
        }
        public void Light()
        {
            
        }
        public void Credits()
        {
            Console.Clear();
            string closing = @"

                                     ^^
    ^^      ..                                       ..
            []                                       []
          .:[]:_          ^^                       ,:[]:.
        .: :[]: :-.                             ,-: :[]: :.
      .: : :[]: : :`._                       ,.': : :[]: : :.
    .: : : :[]: : : : :-._               _,-: : : : :[]: : : :.
_..: : : : :[]: : : : : : :-._________.-: : : : : : :[]: : : : :-._
_:_:_:_:_:_:[]:_:_:_:_:_:_:_:_:_:_:_:_:_:_:_:_:_:_:_:[]:_:_:_:_:_:_
!!!!!!!!!!!![]!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!![]!!!!!!!!!!!!!
^^^^^^^^^^^^[]^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^[]^^^^^^^^^^^^^
            []                                       []
            []                                       []
            []                                       []
 ~~^-~^_~^~/  \~^-~^~_~^-~_^~-^~_^~~-^~_~^~-~_~-^~_^/  \~^-~_~^-~~-
~ _~~- ~^-^~-^~~- ^~_^-^~~_ -~^_ -~_-~~^- _~~_~-^_ ~^-^~~-_^-~ ~^
   ~ ^- _~~_-  ~~ _ ~  ^~  - ~~^ _ -  ^~-  ~ _  ~~^  - ~_   - ~^_~
     ~-  ^_  ~^ -  ^~ _ - ~^~ _   _~^~-  _ ~~^ - _ ~ - _ ~~^ -
        ~^ -_ ~^^ -_ ~ _ - _ ~^~-  _~ -_   ~- _ ~^ _ -  ~ ^-
            ~^~ - _ ^ - ~~~ _ - _ ~-^ ~ __- ~_ - ~  ~^_-
                ~ ~- ^~ -  ~^ -  ~ ^~ - ~~  ^~ - ~
";
            Console.WriteLine(closing);
            Console.WriteLine("Until next time");
            Thread.Sleep(10000);
            Environment.Exit(0);
        }
    }
}

