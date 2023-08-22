
using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;

for (int i = 0; i < 5; i++)
{
var client = new HttpClient();


var kanyeURL = "https://api.kanye.rest/";
var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";


var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
var ronResponse = client.GetStringAsync(ronURL).Result;


var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim(); 

 Console.WriteLine($"Kanye: {kanyeQuote}\nRon: {ronQuote}");
    Console.WriteLine("...");
    Thread.Sleep(1000);
    Console.WriteLine("...");
    Thread.Sleep(1000);

}