// 11.7 Strings Cannot Be Changed.
// If you really need to modify a string, C# provides another class that can be used—the StringBuilder class.
using System;
namespace Str_Err
{
	class Str_Err
	{
		public static void Main(string[] args)
		{
			string str1 = "mike";
			str1[2] = 'I'; //Error!!! Tries to change i to I, says it's "read only" as can't be changed.
			Console.WriteLine(str1);
			Console.ReadKey(true);
		}
	}
}