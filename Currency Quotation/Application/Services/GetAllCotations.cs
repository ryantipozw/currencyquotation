using Currency_Quotation.Domain.Interfaces;
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
		var json = response.Content.ReadFromJsonAsync<Currency>().Result;
		return json;
	}
}
