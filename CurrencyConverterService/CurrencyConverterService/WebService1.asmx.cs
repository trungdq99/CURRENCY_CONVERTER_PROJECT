using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CurrencyConverterService
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public double Convert(double from, string fromCurrency, string toCurrency)
        {
            double fromRate = GetExchangeRate(fromCurrency);
            double toRate = GetExchangeRate(toCurrency);
            double result = 0;
            try
            {
                result = from * fromRate / toRate;
            }catch(Exception e){}
            return result;
        }

        private double GetExchangeRate(string currency)
        {
            switch (currency)
            {
                case "VND":
                    return 1;
                case "AUD":
                    return 15394.88;
                case "EUR":
                    return 25400.81;
                case "GBP":
                    return 29295.26;
                case "HKD":
                    return 2911.78;
                case "JPY":
                    return 203.3;
                case "SGD":
                    return 16690.08;
                case "THB":
                    return 747.79;
                case "USD":
                    return 23110.00;
                default:
                    return 0;
            }
        }
    }
}
