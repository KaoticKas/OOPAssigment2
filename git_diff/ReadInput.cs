using System;
using System.Collections.Generic;
using System.IO;


public class ReadInput
{
	public List<string> file1 = new List<string>();
	public List<string> file2 = new List<string>();
	//Creates two lists of type string that will contain the contents of the file a and file b for comparison purposes
	public ReadInput()
	{

		string line,
			diffA = "",
			diffB = "";
		//3 string variables that will hold the line that will be read by the stream reader, and 2 strings that will hold whatever files the user wants to load.
		var path = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString();
		//This gets the folder of bin by finding where the program gets executed from, then going back 2 directorys to get to the bin folder and converts it into a string format
		Console.WriteLine("Please enter the choice of files in format of 'Diff a.txt b.txt;'");
		string input = Console.ReadLine();
		//this reads the user input
		string[] locations = input.Split(" ");;
		//An array that holds the user input as 3 seperate locations to allow allocation of file a and file b for comparison
		diffA = locations[1];
		diffB = locations[2];
		//assigning file locations to their respective variable names to get the paths for the file


		var filepathA = (path + @"\Files\GitRepositories_" + diffA);
		var filepathB = (path + @"\Files\GitRepositories_" + diffB);
		//gets the full path to find both files within the files folder
		StreamReader fileA = new StreamReader(filepathA);
		//new stream reader object that will read whatever file ive picked
		while ((line = fileA.ReadLine()) != null)
		{
			file1.Add(line);
		}
		// A loop that will add each line into an list until it can no longer read any lines
		fileA.Close();
		//closes the file
		StreamReader fileB = new StreamReader(filepathB);
		//stream reader object for file B
		while ((line = fileB.ReadLine()) != null)
		{
			file2.Add(line);
			//Adding data to the File B list.
		}
		fileB.Close();
		//close file B after it finishes reading it
	}
}
