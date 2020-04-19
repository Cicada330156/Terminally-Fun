using System;

namespace Form
{
    class Program
	{
		//private const string name = "";

		static void Main(string[] args)
        {
			if (args is null)
			{
				throw new ArgumentNullException(nameof(args));
			}

			//Variables
			string name;
           
            //welcome, collect name
            Console.WriteLine("Hello World!");
            Console.WriteLine("What's your name?");
            name = Console.ReadLine();

			//verify name
			if (name.Length < 1)
			{
				Console.WriteLine("Name too short. Please enter an acceptable name.");
				name = Console.ReadLine();
				if (name.Length < 1)/*add or statement to check if string name is a space*/
				{
					//add random number generator, choose from list of names
					Console.WriteLine($"Alright, fine. Do it your way. Your name is now {name}");
				}
				else
				{
					Console.WriteLine($"hi, {name}.");
				}
			}
			else
			{
				Console.WriteLine($"hi, {name}.");
			}
			Menu(name);
        }

		//menu
		private static void Menu(string name)
		{
			string activityChoice = "";
			Console.WriteLine("----->MENU<-----");
			Console.WriteLine($"What would you like to do, {name}?");
			Console.WriteLine("A. Draw");
			Console.WriteLine("B. Quiz");
			activityChoice = Console.ReadLine().ToLower();
			switch (activityChoice)
			{
				case "a":
					Draw(name, false, false);
					break;
				case "draw":
					Draw(name, false, false);
					break;
				default:
					Console.WriteLine("I\'m not sure what went wrong. You may have made a typo or that may not be an option. Since We can't go on without your selection, please try again.");
					Menu(name);
					break;
			}
		}

		//draw
		private static void Draw(string name, bool showquit, bool hideInfo)
		{

			//ask what to draw, but only if hideinfo is false
			if (hideInfo == false)
			{
				Console.WriteLine("What do you want to draw? Please only type the letter of your option.");//only need to include the letter for now
			}
			//show options
			Console.WriteLine("A. iPhone");
			Console.WriteLine("B. Building");
			Console.WriteLine("C. City");
			//decide whether to show quit option
			if (showquit == true)
			{
				Console.WriteLine("If you would like to quit, type \"quit\".");
			}
			string response = Console.ReadLine().ToLower();

			Console.WriteLine("Here you go!");
			switch (response)
			{
				case "a":
					Console.WriteLine("╭━━━━━━━╮");
					Console.WriteLine("┃ ● ══  ┃");
					Console.WriteLine("┃███████┃");
					Console.WriteLine("┃███████┃");
					Console.WriteLine("┃███████┃");
					Console.WriteLine("┃███████┃");
					Console.WriteLine("┃███████┃");
					Console.WriteLine("┃███████┃");
					Console.WriteLine("┃███████┃");
					Console.WriteLine("┃███████┃");
					Console.WriteLine("┃\u3000O\u3000  ┃");
					Console.WriteLine("╰━━━━━━━╯\n");
					Console.WriteLine("Source: copy and paste dump ASCII Art");
					Console.WriteLine("http://copy.r74n.com/ascii-art");
					break;
				case "b":
					Console.WriteLine("   /\\");
					Console.WriteLine("  /\\/\\");
					Console.WriteLine(" /\\/\\/\\");
					Console.WriteLine("/\\/\\/\\/\\");
					Console.WriteLine("||    ||");
					Console.WriteLine("||    ||");
					Console.WriteLine("||    ||");
					Console.WriteLine("||    ||");
					Console.WriteLine("||    ||");
					Console.WriteLine("||    ||");
					Console.WriteLine("||    ||");
					Console.WriteLine("||    ||");
					Console.WriteLine("||    ||");
					Console.WriteLine("||    ||");
					break;
				case "c":
					Console.WriteLine("   /\\");
					Console.WriteLine("  /\\/\\                                _______");
					Console.WriteLine(" /\\/\\/\\                   _______     |▮▮▮▮▮|");
					Console.WriteLine("/\\/\\/\\/\\                  |▮▮▮▮▮|     |▮▮▮▮▮|");
					Console.WriteLine("||    ||                  |▮▮▮▮▮|     |▮▮▮▮▮|");
					Console.WriteLine("||    ||                  |▮▮▮▮▮|     |▮▮▮▮▮|");
					Console.WriteLine("||    ||______________    |▮▮▮▮▮|     |▮▮▮▮▮|");
					Console.WriteLine("||    ||             |    |▮▮▮▮▮|     |▮▮▮▮▮|");
					Console.WriteLine("||    ||             |    |▮▮▮▮▮_______▮▮▮▮▮|");
					Console.WriteLine("||    ||             |    |▮▮▮▮▮_______▮▮▮▮▮|");
					Console.WriteLine("||    ||             |----|▮▮▮▮▮|     |▮▮▮▮▮|");
					Console.WriteLine("||    ||             |    |▮▮▮▮▮|     |▮▮▮▮▮|");
					Console.WriteLine("||    ||             |    |▮▮▮▮▮|     |▮▮▮▮▮|");
					Console.WriteLine("||    ||             |    |▮▮▮▮▮|     |▮▮▮▮▮|");
					break;
				case "d":
					Console.WriteLine(name);
					Console.WriteLine(DateTime.Now);
					break;
				case "quit":
					Menu(name);
					break;
				default:
					Console.WriteLine("That is not an option. Try again.");
					Draw(name, true, true);
					break;
			}
            //let the user decide whether to revert to menu or to draw something else
            Console.WriteLine("Type quit to go back to menu. To draw something else, type continue");
			response = Console.ReadLine().ToLower();
			if (response == "quit")
			{
				Console.WriteLine("Just follow the yellow brick road to get to the menu. I\'ll meet you there just to tell you that your entire journey was useless and you can actually just teleport there.");
				Console.WriteLine("-The Good Witch, The Wizard of Oz.");
				Menu(name);
			}
			else if (response == "continue")
			{
				Draw(name, true, false);
			}
			else
			{
				Console.WriteLine("Hm... I\'m not sure what to make of that. I am redirecting you to the menu now.");/*maybe add a second try after this*/
				Menu(name);
			}
			Menu(name);
		}
	}
}