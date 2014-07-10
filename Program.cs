using System;
using System.Collections.Generic;

namespace bot
{
	class MainClass
	{
		public static void Main (string[] args)
		{	List<string> iL = new List<string> ();
			Random rnd = new Random ();
			int q = 0;
			Console.WriteLine ("Начните со мной беседу");
			while (true)
			{
				string x = Console.ReadLine ();
				x = x.ToUpper ();
				if (iL.Contains (x))
				{
					q = rnd.Next () % 4;
					switch (q)
					{
						case (0):
							Console.WriteLine ("Мы же уже говорили об этом. Ты что, забыл?");
							break;
							case (1):
							Console.WriteLine ("У меня ощущения deja vu.");
							break;
							case (2):
							Console.WriteLine ("Что-то ты повторяешься, друже.");
							break;
							case (3):
							Console.WriteLine ("По-моему мы это обсуждали ранее.");
							break;
					}
					continue;
				}	
				else
					iL.Add (x);

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
					continue;
				}
			
				if (x.Contains ("КАК ДЕЛА?") || x.Contains ("КАК ТЫ?") || x.Contains ("КАК САМ?") || x.Contains ("КАК ОНО?"))
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
					continue;
				}

				q = rnd.Next () % 4;
				switch (q)
				{
					case (0):
						Console.WriteLine ("Я разделяю твою точку зрения.");
						break;
					case (1):
						Console.WriteLine ("Фу, ты упал в моих глазах.");
						break;
					case (2):
						Console.WriteLine ("Да, твоя позиция мне ясна.");
						break;
					case (3):
						Console.WriteLine ("Ничего себе!");
						break;
				} continue;
			}
		}
	}
}
