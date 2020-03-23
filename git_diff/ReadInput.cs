using System;
using System.Collections.Generic;
using System.IO;


public class ReadInput
{
	public ReadInput()
	{
		List<string> file1 = new List<string>();
		List<string> file2 = new List<string>();
		string line,
			diffA = "",
			diffB = "";
		var path = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString();
		Console.WriteLine("Please enter the choice of files in format of 'Diff a.txt b.txt;'");
		line = Console.ReadLine();
		string[] locations = line.Split(" ");;

		diffA = locations[1];
		diffB = locations[2];



		var filepathA = (path + @"\Files" + diffA);
		var filepathB = (path + @"\Files" + diffB);
		//Console.WriteLine(filepath);
		StreamReader fileA = new StreamReader(filepathA);
		while ((line = fileA.ReadLine()) != null)
		{
			file1.Add(line);
		}
		fileA.Close();

		StreamReader fileB = new StreamReader(filepathB);
		while ((line = fileB.ReadLine()) != null)
		{
			file2.Add(line);
		}
		fileB.Close();
	}
}
