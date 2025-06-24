using Currency_Quotation.Application.Services;

namespace Currency_Quotation.Domain.Tools;

public static class ShowOptions
{
	public static void Show()
	{
		Writer.Write("Welcome!! Choose a currency below to check the informations: \n" +
			"1. Dollar \n" +
			"2. Euro \n" +
			"3. Argentine Peso \n" +
			"4. Chilean Peso \n" +
			"5. Uruguayan Peso \n" +
			"6. All of them!! \n" +
			"Or you could say 'bye' to close the app!\n \n");
	}
}
