using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Service.Models
{

   public class Result
    {

        [JsonProperty("updated")]
        public DateTime updated { get; set; }

        [JsonProperty("source")]
        public string source { get; set; }

        [JsonProperty("target")]
        public string target { get; set; }

        [JsonProperty("value")]
        public double value { get; set; }

        [JsonProperty("quantity")]
        public double quantity { get; set; }

        [JsonProperty("amount")]
        public double amount { get; set; }
    }

    public class Resultado
    {

        [JsonProperty("result")]
        public Result result { get; set; }

        [JsonProperty("status")]
        public string status { get; set; }
    }




}
