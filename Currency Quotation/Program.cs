using Currency_Quotation.API.Endpoints;
using Currency_Quotation.Application.Services;
using Currency_Quotation.Domain.Interfaces;
using Currency_Quotation.Domain.Model;
using Currency_Quotation.Domain.Tools;

namespace Currency_Quotation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var text = GetAllCotations.Get(Endpoints.USDPrice);
            ShowCurrency.Show(text.Result);
        }
    }
}
