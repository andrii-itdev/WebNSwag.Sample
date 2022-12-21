// See https://aka.ms/new-console-template for more information

using MyNamespace;

Console.WriteLine("Welcome to Nswag Generated Client");


var testClient = new Client("https://localhost:7181");

var results = testClient.GetWeatherForecastAsync().GetAwaiter().GetResult();

//var getAllresult = testClient.GetAllAsync().GetAwaiter().GetResult();

results.ToList().ForEach(
    x => Console.WriteLine(@$"Date: {x.Date}\tTemp: {x.TemperatureC}\tSummary: {x.Summary}")
);
