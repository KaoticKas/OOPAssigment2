using System;

public class Check
{
	bool isDifferent;
	//a boolean that wil lbe used to check if there is a difference in files or not
	public Check()
	{
		ReadInput readObj = new ReadInput();
		//makes a new object to execute the class readinput
		string[] listA = readObj.file1.ToArray();
		string[] listB = readObj.file2.ToArray();
		//converts the lists into arrays to be read into
		if (listA.Length > listB.Length || listB.Length > listA.Length)
		{
			isDifferent = true;
			//if the two arrays have different lengths they will be different so this is a condition that checks if either is larger than the other by using an or logic.
			//if they are they set the bool to true.
		}
		else
		{
			for (int i = 0; i < listA.Length; i++)
			{
				//for loop that goes through the entire array using a index i
				if (listA[i] != listB[i])
				{
					isDifferent = true;
					break;
					//if the array indexes for both lists are not the same it will set the bool to true and break out of the loop.
				}
				else
				{
					isDifferent = false;
					//if the lists are the same then they are not different so the bool is set to false
				}		
			}
		}
		if (isDifferent == true)
		{
			//if statement that checks the state of the bool to output the appropiate message.
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("a.txt and b.txt are different");
			Console.ForegroundColor = ConsoleColor.White;
			//if the files are different it will change the text colour and alert the user they are different.
		}
		else
		{
			//if the bool is false this message will be shown
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("a.txt and b.txt are not different");
			Console.ForegroundColor = ConsoleColor.White;
		}
	}
}
