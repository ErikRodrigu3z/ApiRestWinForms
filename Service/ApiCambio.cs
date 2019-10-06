using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp; // instalar en el nuget Package "RestSharp"
using System.Web.Script.Serialization; // agregar referencia de "System.Web.Extensions"
using Service.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace Service
{
    public class ApiCambio
    {
        //List
        public List<Resultado> ListGetCambio(string monedaOrigen, string monedaConversion, decimal cantidad, string key,string formato) 
        {
            var content = "";
            try 
            {
                // https://api.cambio.today/v1/quotes/CAD/MXN/json?quantity=1&key=2443|EorKdxYBZz2EfuOprGiqUEWUfR38dnJm
                var client = new RestClient("https://api.cambio.today/v1/quotes/"+ monedaOrigen + "/" + monedaConversion + 
                                            "/" + formato + "?quantity=" + cantidad + "&key=" + key + "");

                var request = new RestRequest(Method.GET);               
                request.AddHeader("Host", "api.cambio.today");               
                IRestResponse response = client.Execute(request);
                content = response.Content;

                if (response.StatusDescription == "OK")
                {
                    var serializer = new JavaScriptSerializer();
                    List<Resultado> serializedResult = serializer.Deserialize<List<Resultado>>(content);                    
                    return serializedResult;
                }
                else
                {
                    List<Resultado> serializedResult = new List<Resultado>();
                    Resultado res = new Resultado();
                    res.status = content;
                    serializedResult.Add(res);
                    return serializedResult;
                }

            }
            catch (Exception ex)
            {
                List<Resultado> serializedResult = new List<Resultado>();
                Resultado res = new Resultado();
                res.status = content;
                return serializedResult;
            }
        }

        //Model
        public Resultado modelGetCambio(string monedaOrigen, string monedaConversion, decimal cantidad, string key, string formato)
        {
            var content = ""; 
            try
            {
                // https://api.cambio.today/v1/quotes/CAD/MXN/json?quantity=1&key=2443|EorKdxYBZz2EfuOprGiqUEWUfR38dnJm

                var client = new RestClient("https://api.cambio.today/v1/quotes/" + monedaOrigen + "/" + monedaConversion +
                                            "/" + formato + "?quantity=" + cantidad + "&key=" + key + "");

                var request = new RestRequest(Method.GET);
                request.AddHeader("Host", "api.cambio.today");
                IRestResponse response = client.Execute(request);
                content = response.Content;

                if (response.StatusDescription == "OK")
                {
                    var serializer = new JavaScriptSerializer();
                    Resultado serializedResult = serializer.Deserialize<Resultado>(content);                    
                    return serializedResult;
                }
                else
                {
                    Resultado res = new Resultado();
                    res.status = content;
                    return res;
                }

            }
            catch (Exception ex)
            {
                Resultado res = new Resultado();
                res.status = ex.Message;
                return res;
            }
        }


      




    }
}
