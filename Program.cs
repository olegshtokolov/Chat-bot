using System;
using System.Collections.Generic;

namespace bot
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List <string> a = new List<string> ();
			int i = 0;
			int q = 0;
			Console.WriteLine ("Начните со мной беседу");
			while (true)
			{
				Random rnd = new Random ();
				string x = Console.ReadLine ();
				//	i = System.Array.IndexOf(a, x);
				////	if (i == -1) 
				//	Console.WriteLine ("Мы же уже говорили об этом.");
				//else
				//	a.Add (x);
				x = x.ToUpper ();
				if (x.Contains ("ПРИВЕТ") || x.Contains ("ДАРОВА") || x.Contains ("ДОБРОЕ УТРО") ||
					x.Contains ("ЗДАРОВА") || x.Contains ("ЗДРАВСТВУЙ") || x.Contains ("ДОБРЫЙ ДЕНЬ") ||
					x.Contains ("ДОБРЫЙ ВЕЧЕР") || x.Contains ("ДОБРОЙ НОЧИ") || x.Contains ("ЗИГ ХАЙЛЬ")
					|| x.Contains ("ПРИВЕТОСЫ") || x.Contains ("ХАЙ") || x.Contains ("ЗДРАВСТВУЙ") || x.Contains ("ЙОУ"))
				{
					q = rnd.Next (1, 5) % 4;
					switch (q)
					{
						case (0):
							Console.WriteLine ("Привет!");
							break;
						case (1):
							Console.WriteLine ("Здравствуй");
							break;
						case (2):
							Console.WriteLine ("Оооо, привет! Давно не виделись.");
							break;
						case (3):
							Console.WriteLine ("Доброго времени суток, друг.");
							break;
					}
				}
			
				if (x.Contains ("КАК ДЕЛА") || x.Contains ("КАК ТЫ") || x.Contains ("КАК САМ") || x.Contains ("КАК ОНО"))
				{
					q = rnd.Next () % 4;
					switch (q)
					{
						case (0):
							Console.WriteLine ("Нормально, спасибо, твои как?");
							break;
						case (1):
							Console.WriteLine ("Лучше всех!");
							break;
						case (2):
							Console.WriteLine ("Хорошо, а у тебя?");
							break;
						case (3):
							Console.WriteLine ("Отлично!");
							break;
					}
				}
			}
		}
	}
}
