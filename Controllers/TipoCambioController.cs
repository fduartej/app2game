using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using app2game.Integration.CurrencyExchange;
using app2game.ViewModel;
using app2game.Integration.CurrencyExchange.dto;

namespace app2game.Controllers
{
    public class TipoCambioController : Controller
    {
        private readonly ILogger<TipoCambioController> _logger;
        private readonly CurrencyExchangeIntegration _currencyExchangeIntegration;

        public TipoCambioController(ILogger<TipoCambioController> logger, 
            CurrencyExchangeIntegration currencyExchangeIntegration){
            _logger = logger;
            _currencyExchangeIntegration = currencyExchangeIntegration;
        }

        public IActionResult Index()
        {
            var currencySymbols = _currencyExchangeIntegration.GetCurrencySymbols();
            ViewData["symbols"] = currencySymbols.Result.Symbols;
            return View();
        }


        public async Task<IActionResult> Exchange(TipoCambioViewModel viewmodel){
            var tipoCambio = await _currencyExchangeIntegration.GetExchangeRate(viewmodel.From, viewmodel.To, viewmodel.Amount);
            ViewData["result"] = tipoCambio.result;
            ViewData["rate"] = tipoCambio.info.rate;
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
        
    }
}