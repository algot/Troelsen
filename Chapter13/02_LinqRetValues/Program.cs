using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LinqRetValues
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("***** LINQ transformations *****\n");
		  var subset = GetStringSubset();
		  foreach (string item in subset)
		  {
		    Console.WriteLine(item);
		  }

		  foreach (string s in GetStringSubsetAsArray())
		  {
		    Console.WriteLine(s);
		  }
		}

	  static IEnumerable<string> GetStringSubset()
	  {
	    string[] colors = {"Light Red", "Green", "Yellow", "Dark Red", "Red", "Purple"};

	    IEnumerable<string> theRedColors = from c in colors where c.Contains("Red") select c;
	    return theRedColors;
	  }

	  static IEnumerable<string> GetStringSubsetAsArray()
	  {
      string[] colors = { "Light Red", "Green", "Yellow", "Dark Red", "Red", "Purple" };
	    var theRedColors = from c in colors where c.Contains("Red") select c;
	    return theRedColors.ToArray();
	  }
	}
}
