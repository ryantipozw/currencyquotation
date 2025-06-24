using Currency_Quotation.API.Endpoints;
using Currency_Quotation.Domain.Model;
using System.Net.Http.Json;
using System.Threading.Channels;

namespace Currency_Quotation.Application.Services;

public static class GetAllCotations
{
	public static async Task<Currency> Get(string endpoint)
	{
		HttpClient client = new();
		HttpResponseMessage response = await client.GetAsync(endpoint);
		if (!response.IsSuccessStatusCode)
		{
			var emptyCurrency = new Currency();
			emptyCurrency.IsEmpty = true;
			return emptyCurrency;
		}
		else
		{
			var json = response.Content.ReadFromJsonAsync<Currency>().Result;
			json.IsEmpty = false;
			return json;
		}

	}
	public static async Task<List<Currency>> GetAll()
	{
		HttpClient client = new();
		HttpResponseMessage response = await client.GetAsync(Endpoints.Cotations);
		if (!response.IsSuccessStatusCode)
		{
			var emptyCurrencyList = new List<Currency>();
			return emptyCurrencyList;
		}
		else
		{
			var json = response.Content.ReadFromJsonAsync<List<Currency>>().Result;
			return json;
		}
	}
}
