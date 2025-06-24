using Currency_Quotation.Application.Services;

namespace Currency_Quotation.Domain.Tools;

public static class AnswerText
{
	public static string GetAnswer()
	{
		Writer.Write("My answer is... ");
		var answer = Console.ReadLine();
		return answer;
	}
}
