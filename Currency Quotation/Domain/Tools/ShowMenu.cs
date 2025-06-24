using Currency_Quotation.API.Endpoints;
using Currency_Quotation.Application.Services;
using System.Runtime.InteropServices;

namespace Currency_Quotation.Domain.Tools;

public static class ShowMenu
{
	public static void Show()
	{
		bool loop = true;
		while (loop)
		{
			Console.Clear();
			ShowOptions.Show();
			var answer = AnswerText.GetAnswer();
			switch (answer)
			{
				case "1": 
					Console.Clear();
					Writer.Write($"You chose: {answer}, United State Dollar!\n");
					var choice1 = GetAllCotations.Get(Endpoints.USDPrice).Result;
					ShowCurrency.Show(choice1);
					Writer.Write("Press a key to return to the menu... ");
					Console.ReadKey();
					break;
				case "2":
					Console.Clear();
					Writer.Write($"You chose: {answer}, Euro!\n");
					var choice2 = GetAllCotations.Get(Endpoints.EURPrice).Result;
					ShowCurrency.Show(choice2);
					Writer.Write("Press a key to return to the menu... ");
					Console.ReadKey();
					break;
				case "3":
					Console.Clear();
					Writer.Write($"You chose: {answer}, Argentine Peso!\n");
					var choice3 = GetAllCotations.Get(Endpoints.ARSPrice).Result;
					ShowCurrency.Show(choice3);
					Writer.Write("Press a key to return to the menu... ");
					Console.ReadKey();
					break;
				case "4":
					Console.Clear();
					Writer.Write($"You chose: {answer}, Chilean Peso!\n");
					var choice4 = GetAllCotations.Get(Endpoints.CLPPrice).Result;
					ShowCurrency.Show(choice4);
					Writer.Write("Press a key to return to the menu... ");
					Console.ReadKey();
					break;
				case "5":
					Console.Clear();
					Writer.Write($"You chose: {answer}, Urugayan Peso!\n");
					var choice5 = GetAllCotations.Get(Endpoints.UYUPrice).Result;
					ShowCurrency.Show(choice5);
					Writer.Write("Press a key to return to the menu... ");
					Console.ReadKey();
					break;
				case "6":
					Console.Clear();
					Writer.Write($"You chose: {answer}, All of them!\n");
					var choice6 = GetAllCotations.GetAll().Result;
					ShowCurrency.ShowAll(choice6);
					Writer.Write("Press a key to return to the menu... ");
					Console.ReadKey();
					break;
				case "bye":
					Console.Clear();
					Environment.Exit(0);
					break;
				default: 
					Writer.Write("Choose a valid option. \n");
					Thread.Sleep(2000);
					break;
			}

		}
	}
}
