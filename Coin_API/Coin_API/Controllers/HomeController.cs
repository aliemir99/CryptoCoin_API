using Coin_API.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Coin_API.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://api.coinlore.net/api/tickers/?start=0&limit=20");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();

                        CoinBank resultObject = JsonConvert.DeserializeObject<CoinBank>(result);
                        LoadCoinsFromBank(resultObject);
                        return View(resultObject);
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Server could not be reached");
                    }
                    

                }
                catch (Exception ex)
                {

                    var ss = ex.Message;
                }
                

            }
                return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        private void LoadCoinsFromBank(CoinBank bank)
        {
            foreach(var coin in bank.data)
            {
                Coin coinToAdd = new Coin();
                coinToAdd.ID = coin.id;
                coinToAdd.Rank = coin.rank;
                coinToAdd.Name = coin.name;
                coinToAdd.Symbol = coin.symbol;
                coinToAdd.NameID = coin.nameid;
                coinToAdd.Price_USD = coin.price_usd;
                coinToAdd.Price_BTC = coin.price_btc;
                coinToAdd.Percent_Change_24hr = coin.percent_change_24h;
                coinToAdd.Volume24 = coin.volume24;
                coinToAdd.Image = bank.Images[coin.rank];

                bank.Coins.Add(coinToAdd);
            }
        }
    }
}