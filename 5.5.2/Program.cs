using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._5._2
{
	internal class Program
	{
		static string [] SplitText()
		{
			Console.WriteLine("Введите предложение для реверса");
			string EnteredText = Console.ReadLine();
			string [] EnteredTextArray = EnteredText.Split(new char[] { ' ' });
			return EnteredTextArray;
		}
		static void ReverseString(string [] EnteredTextArray)
		{
			Array.Reverse(EnteredTextArray);
			foreach (var item in EnteredTextArray)
			{
				Console.Write(item + ' ');
			}
		}
		static void Main(string[] args)
		{
			ReverseString(SplitText());
			Console.ReadKey();
			
		}
	}
}
