namespace GolfDataAPI
{
    public class WeatherForecast
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }

        public int MaxNumber { get; }
        public int Test { get; private set; }

        private void SetTestValue()
        {
            Test=12;
        }

        public WeatherForecast()
        {
            Test=13;
        }
    }
}
