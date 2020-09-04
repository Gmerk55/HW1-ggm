using System;

// Date: 9/4/2020
// Created By: Gabrielle Merk
// About: A text based game about a mysterious farm in which a player must face and get through different challenges.
namespace HW1_ggm
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start Area - Input user name

            Console.WriteLine("Hello PLAYER and welcome to 'The Mysteries of Sweet Berry Farm'");
            Console.WriteLine("RULES: Explore areas of Sweet Berry farm alongside the other farmhands " +
                "\nand complete challenges and side quests that pop up." +
                "\nOBJECTIVES: Discover the mysteries of Sweet Berry Farm, explore, and defeat the challenges.\nGood luck PLAYER and have fun!");
            Console.WriteLine("\n");
            Console.WriteLine("Before you start you must first choose a name...");
            Console.Write("Please Enter a Name (This cannot be changed later): ");
            string playerName;
            playerName = Console.ReadLine();
            Console.WriteLine("Your name is now " + playerName + "!");

            // Beginning storyline

            Console.WriteLine("You drive down a fairly long gravel path that's lined with partially chipped white fencing. You then " +
                "\npull up to a simple looking farm with the signature red barn and a white farm house to its right.");
            Console.WriteLine("\n");
            Console.WriteLine("Ben: Welcome to Sweet Berry Farm " + playerName + "! I'm Ben, one of the head farmhands on the farm." +
                "\nWe're so glad you could come and help out, we've been having some problems lately." +
                "\nHead over to the barn and talk with Sherry, she'll tell you what to do first. See ya around!");
            Console.WriteLine("OBJECTIVE: Go to the barn and talk to Sherry");

            // (Level 1) Gravel path side quests 

            // (Level 2) Barn entrance appearance and challenge (find key)

            Console.WriteLine("Sherry: Hi there, you must be " + playerName + "! Nice to meet ya, I'm Sherry. Your first task is to find the " +
                "\nmissing key that Freddie lost, gosh that kid. Give me a holler when you find it.");

            // Barn main quest

            Console.WriteLine("Inside the barn you find a few animals in their stalls, a work station filled with tools and supplies, a " +
                "\nsmall office with a chest in it, and lastly a smaller door which leads to an unknown place.");
                // (Room 1) Unlock the chest with lock code

                // (Room 2) 

                // (Room 3) Find bolt cutters to open the cellar
            // (Level 3) Cellar main quest

            // (Level 4) Escape the cellar (Game End)

            //input.trim.substring
            //if else
            //use int.tryparse
        }
    }
}
