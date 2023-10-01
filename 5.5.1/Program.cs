using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _5._5._1
{
	internal class Program
	{
		static string[] SplitText()
		{
            Console.WriteLine("Введите предложение для разделения");
			string EnteredText = Console.ReadLine();
			string [] EnteredTextArray = EnteredText.Split(new char [] { ' ' });
            return EnteredTextArray;
		}

		static void OutputEnteredText(string[] EnteredTextArray)
		{
			foreach (string str in EnteredTextArray)
			{
				Console.WriteLine(str);
			}
			Console.ReadKey();
			
		}

		static void Main(string[] args)
		{
			OutputEnteredText(SplitText());
		}
	}
}
