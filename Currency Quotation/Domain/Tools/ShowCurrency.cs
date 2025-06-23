using Currency_Quotation.Domain.Model;

namespace Currency_Quotation.Domain.Tools;

public static class ShowCurrency
{
	public static void Show(Currency currency)
	{
		Console.WriteLine($"Currency: {currency.Coin}");
		Console.WriteLine($"Name: {currency.Name}");
		Console.WriteLine($"Previous Price: {currency.PreviousClosure}");
		Console.WriteLine($"Sell Price: {currency.SellPrice}");
		Console.WriteLine($"Buy Price: {currency.BuyPrice}");
	}
}
