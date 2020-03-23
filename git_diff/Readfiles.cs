using System;
using System.Collections.Generic;
using System.IO;


public class Readfiles
{
	public Readfiles()
	{
		string line = "",
			diffA = "",
			diffB = "";
		Console.WriteLine("Please enter the choice of files in format of 'Diff a.txt b.txt;'");
		line = Console.ReadLine();
		string[] locations = line.Split(" ");;

		diffA = locations[1];
		diffB = locations[2];

		var path2 = Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString();

		var pathA = (path2 +@"\" + diffA);

		Console.WriteLine(pathA);

	}
}
