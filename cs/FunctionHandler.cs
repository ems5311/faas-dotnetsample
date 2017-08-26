using System;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Function
{
    public class FunctionHandler
    {
        public void Handle(string input)
        {
            string value = "";
            if (!string.IsNullOrWhiteSpace(input))
            {
                dynamic jsonResponse = JsonConvert.DeserializeObject(input);
                if (jsonResponse.value != null)
                {
                    value = (string)jsonResponse.value;
                }
            }

            //var output = new { factors = GetFactors(value) };
            Console.WriteLine(JsonConvert.SerializeObject(value));
        }

        private int[] GetFactors(int value)
        {
            return Enumerable.Range(1, value).Where(i => value % i == 0).ToArray();
        }
    }
}
