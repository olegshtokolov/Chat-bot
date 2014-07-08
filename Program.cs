//
//  Program.cs
//
//  Author:
//       student <>
//
//  Copyright (c) 2014 student
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;

namespace bot
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine("Начните со мной беседу");
			while (true)
			{
				string x = Console.ReadLine ();
				x = x.ToUpper ();
				if (x.Contains ("ПРИВЕТ") || x.Contains ("ДАРОВА") || x.Contains ("ДОБРОЕ УТРО") ||
					x.Contains ("ЗДАРОВА") || x.Contains ("ЗДРАВСТВУЙ") || x.Contains ("ДОБРЫЙ ДЕНЬ") ||
					x.Contains ("ДОБРЫЙ ВЕЧЕР") || x.Contains ("ДОБРОЙ НОЧИ") || x.Contains ("ЗИГ ХАЙЛЬ")
					|| x.Contains ("ПРИВЕТОСЫ") || x.Contains ("ХАЙ"))
					Console.WriteLine ("Здравствуй!");
				if (x.Contains ("КАК ДЕЛА") || x.Contains ("КАК ТЫ") || x.Contains ("КАК САМ")|| x.Contains ("КАК ОНО"))
					Console.WriteLine ("Хорошо, а ты?");
			}
		}
	}
}
