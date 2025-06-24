using Currency_Quotation.Application.Services;
using Currency_Quotation.Domain.Model;

namespace Currency_Quotation.Domain.Tools;

public static class ShowCurrency
{
	public static void Show(Currency currency)
	{
		if (!currency.IsEmpty)
		{
			Writer.Write($"Currency: {currency.Coin} \n" +
				$"Name: {currency.Name} \n" +
				$"Previous Price: R${currency.PreviousClosure} \n" +
				$"Sell Price: R${currency.SellPrice} \n" +
				$"Buy Price: R${currency.BuyPrice} \n\n\n");

		} else
		{
			Writer.Write("Something went wrong");
		}
	}
	public static void ShowAll(List<Currency> currencyList)
	{
		if (currencyList.Count == 0)
		{
			Writer.Write("Something went wrong!\n");
		}
		else
		{
			foreach (Currency currency in currencyList)
			{
				Show(currency);
			}
		}
	}
}
