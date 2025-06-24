using System.Text.Json.Serialization;

namespace Currency_Quotation.Domain.Model;

public class Currency
{
	[JsonPropertyName("moeda")]
	public string Coin { get; set; }
	[JsonPropertyName("nome")]
	public string Name { get; set; }
	[JsonPropertyName("compra")]
	public decimal BuyPrice { get; set; }
	[JsonPropertyName("venda")]
	public decimal SellPrice { get; set; }
	[JsonPropertyName("fechoAnterior")]
	public decimal PreviousClosure { get; set; }
	[JsonPropertyName("dataAtualizacao")]
	public DateTime UpdateDate { get; set; }
	public bool IsEmpty { get; set; }
}
