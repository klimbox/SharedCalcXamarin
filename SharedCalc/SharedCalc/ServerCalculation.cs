using System;
using System.Net.Http;

namespace SharedCalc
{
    public class ServerCalculation : ICalculation
    {
        private HttpClient _client;
        private string _deffaultUrl = "http://localhost:9999";

        public ServerCalculation()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri(_deffaultUrl)
            };
        }

        public ServerCalculation(string url)
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri(url)
            };
        }

        public int Calculate(string num1, string num2, string op)
        {
            int res = 0;

            var content = new StringContent("num1=" + num1 + "&num2=" + num2 + "&opr=" + op);

            var result = _client.PostAsync("/api/Membership/exists", content).Result;
            
            if (result.IsSuccessStatusCode)
            {
                var responseContent = result.Content;

                // by calling .Result you are synchronously reading the result
                string responseString = responseContent.ReadAsStringAsync().Result;
                try
                {
                    res = Convert.ToInt32(responseString);
                }
                catch (Exception)
                { }

            }
            
            return res;
        }
    }
}
