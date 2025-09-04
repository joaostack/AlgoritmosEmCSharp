namespace PredictiveModelSample;

class Program
{
    static void Main()
    {
        // DAY - FORECAST
        var forecast = new Dictionary<int, int>()
        {
            { 1,  24 },
            { 2, 30 },
            { 3, 29 },
            { 4, 32 },
            { 5, 25 },
            { 6, 20 },
        };
        var lastForecast = PredictTemperature(ref forecast);
        Console.WriteLine($"Added prediction => DAY {forecast.Keys.Max()} - FORECAST {lastForecast}");

        foreach (var day in forecast)
        {
            Console.WriteLine($"Day {day.Key} - Forecast {day.Value}");
        }
    }

    static int PredictTemperature(ref Dictionary<int, int> temps)
    {
        var sum = temps.Values.Sum();
        var days = temps.Keys.Count();
        var prediction = sum / days;
        var lastDay = temps.Keys.Max();

        // Add prediction to temps
        temps.Add(lastDay + 1, prediction);

        return prediction;
    }
}