using Newtonsoft.Json.Linq;


string apikey = File.ReadAllText("appsettings.json");
var key = JObject.Parse(apikey).GetValue("DefaultKey").ToString();
   

    var client = new HttpClient();
    var apiKey = "f0479d19c30f27af0b87ab50c66bc66b";
    var cityName = "Somerset";
    var weatherUrl = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=imperial";
    var weatherResponse = client.GetStringAsync(weatherUrl).Result;
    var weatherObject = JObject.Parse(weatherResponse);
Console.WriteLine(weatherObject);


