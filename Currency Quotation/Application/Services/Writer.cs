namespace Currency_Quotation.Application.Services;

public static class Writer
{
	public static void Write(string str)
	{
		foreach (char c in str) 
		{
			Console.Write(c);
			Thread.Sleep(10);
		}
	}
}
