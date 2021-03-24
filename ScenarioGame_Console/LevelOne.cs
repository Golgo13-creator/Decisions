using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace ScenarioGame_Console
{
    //public class LevelOne
    //{
    //    readonly LevelTwo levelTwo = new LevelTwo();
        
    //    public void Opening()
    //    {
    //        Console.Clear();
    //        Console.WriteLine("You wake up in a dark room. What do you do?\n");
    //        Console.WriteLine("1. Turn on a light");
    //        Console.WriteLine("2. Walk around in the dark");
    //        //while loop possibly
    //        string input = Console.ReadLine();
            
    //        switch (input)
    //        {
    //            case "1":
    //                //track 1.
    //                levelTwo.TurnOnALight();
    //                break;
    //            case "2":
    //                //track 2 
    //                levelTwo.WalkAroundInTheDark();
    //                break;
    //            default:
    //                Console.WriteLine("Please select one or two");
    //                break;
    //        }
    //        Console.ReadLine();
    //    }
    //}
    public class LevelTwo
    {
        //readonly LevelOne levelOne = new LevelOne();
        //LevelThree levelThree = new LevelThree();
       // SoundPlayer gamePlaySound = new SoundPlayer(@);
        
        public void Opening()
        {
            Console.Clear();
            Console.WriteLine("You wake up in a dark room. What do you do?\n");
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
            Console.Clear();
            Console.WriteLine("You find a key\n");
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
            Console.WriteLine("You find a massive door\n");
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
            Console.WriteLine("You enter a pitch black room\n");
            Console.WriteLine("1. ");
            Console.WriteLine("2. ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    //track 1
                    
                    break;
                case "2":
                    //track 2
                    
                    break;
                default:
                    Console.WriteLine("Please select one or two");
                    break;
            }
            Console.ReadLine();
        }
        public void WalkAroundInTheDark()
        {
           // Program_UI program_UI = new Program_UI();
            Console.Clear();
            Console.WriteLine("You stub your toe\n");
            Console.WriteLine("1.Double over in pain looking for a light switch");
            Console.WriteLine("2. Push through the pain and continue looking around in the dark");
            //while loop possibly
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
            Console.WriteLine("Press any key to return to menu");
            //program_UI.Menu();
        }
        
        public void PushThrough()
        {
            Console.Clear();
            Console.WriteLine("You fall over\n");
            Console.WriteLine("Press any key to continue\n");
            Console.ReadKey();
            Console.WriteLine("You bonk your head and pass out\n");
            Console.WriteLine("Press any key to continue");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Opening();
                    break;
                default:
                    Opening();
                    break;
            }
        }
    }
    //public class LevelThree
    //{
    //    public void FourthScenario()
    //    {
    //        Program_UI program_UI = new Program_UI();
    //        Console.Clear();
    //        Console.WriteLine("You go out with your husband for dinner at a new restaurant you have not frequented before.\n It is in a part of town you rarely visit.\n You are shocked to see your friend’s spouse having dinner with a very young, attractive person.\n From the way they are behaving, it is obvious they are more than friends.\n The couple finish their meal and leave without seeing you.\n They behave very affectionately on the way out the door.\n Do you tell your friend knowing you probably wont be believed or\n do you say nothing and mind your own business?\n");
    //        Console.WriteLine("1. Tell your friend.");
    //        Console.WriteLine("2. Say nothing.");
    //        //while loop possibly
    //        string input = Console.ReadLine();

    //        switch (input)
    //        {
    //            case "1":
    //                //scenario 1
    //                Console.WriteLine("Test");
    //                break;
    //            case "2":
    //                //scenario 2
    //                Console.WriteLine("Test");
    //                break;
    //            default:
    //                Console.WriteLine("Please select one or two");
    //                break;
    //        }
    //        Console.ReadLine();
    //        program_UI.Menu();
    //    }
    //}

}
