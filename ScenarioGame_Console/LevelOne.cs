using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScenarioGame_Console
{
    public class LevelOne
    {
        LevelTwo levelTwo = new LevelTwo();
        
        public void FirstScenario()
        {
            Console.Clear();
            Console.WriteLine("Fenton is the driver of a train, whose brakes have failed.\n" +
                " On the track ahead are five people, but the track also has a turn going to the left.\n " +
                " Fenton can turn the train to the left but unfortunately there is one person on this track.\n  " +
                "What should Fenton do?\n");
            Console.WriteLine("1. Turn left and kill five people");
            Console.WriteLine("2. Turn right and kill one person");
            //while loop possibly
            string input = Console.ReadLine();
            
            switch (input)
            {
                case "1":
                    //scenario 1
                    levelTwo.SecondScenario();
                    break;
                case "2":
                    //scenario 2
                    levelTwo.ThirdScenario();
                    break;
                default:
                    Console.WriteLine("Please select one or two");
                    break;
            }
            Console.ReadLine();
        }
    }
    public class LevelTwo
    {
        LevelThree levelThree = new LevelThree();

        public void SecondScenario()
        {
            Console.Clear();
            Console.WriteLine("Olli is a transplant surgeon. One of his patients needs a new heart but has a very rare blood type.\n" +
                " It just so happens Olli has a healthy specimen with that very blood type.\n" +
                " Olli can take the healthy specimen's heart killing him, and give it to his patient,\n" +
                " or Olli can let his patient die. What should Olli do?\n");
            Console.WriteLine("1. Take the healthy specimen's heart");
            Console.WriteLine("2. Let his patient die.");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    //scenario 1
                    levelThree.FourthScenario();
                    break;
                case "2":
                    //scenario 2
                    ThirdScenario();
                    break;
                default:
                    Console.WriteLine("Please select one or two");
                    break;
            }
            Console.ReadLine();
        }
        public void ThirdScenario()
        {
            Program_UI program_UI = new Program_UI();
            Console.Clear();
            Console.WriteLine("Skye is president, and has just been informed that the Russians have launched an atomic bomb towards New York.\n" +
                " The only way which the bomb can be prevented from hitting New York is by deflecting it;\n" +
                " but the only deflection path available will cause the bomb to hit Worcester.\n" +
                " What does Skye do, Let the bomb hit New York killing everyone in it?\n" +
                " Or Let the bomb hit Worcester killing everyone in it?\n");
            Console.WriteLine("1. Let the bomb hit New York");
            Console.WriteLine("2. Let the bomb hit Worcester.");
            //while loop possibly
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    //scenario 1
                    Console.WriteLine("The bomb hit New York.");
                    break;
                case "2":
                    //scenario 2
                    Console.WriteLine("The bomb hit Worcester.");
                    break;
                default:
                    Console.WriteLine("Please select one or two");
                    break;
            }
            Console.ReadLine();
            Console.WriteLine("Press any key to return to menu");
            program_UI.Menu();
        }
    }
    public class LevelThree
    {
        public void FourthScenario()
        {
            Program_UI program_UI = new Program_UI();
            Console.Clear();
            Console.WriteLine("You go out with your husband for dinner at a new restaurant you have not frequented before.\n It is in a part of town you rarely visit.\n You are shocked to see your friend’s spouse having dinner with a very young, attractive person.\n From the way they are behaving, it is obvious they are more than friends.\n The couple finish their meal and leave without seeing you.\n They behave very affectionately on the way out the door.\n Do you tell your friend knowing you probably wont be believed or\n do you say nothing and mind your own business?\n");
            Console.WriteLine("1. Tell your friend.");
            Console.WriteLine("2. Say nothing.");
            //while loop possibly
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    //scenario 1
                    Console.WriteLine("Test");
                    break;
                case "2":
                    //scenario 2
                    Console.WriteLine("Test");
                    break;
                default:
                    Console.WriteLine("Please select one or two");
                    break;
            }
            Console.ReadLine();
            program_UI.Menu();
        }
    }

}
