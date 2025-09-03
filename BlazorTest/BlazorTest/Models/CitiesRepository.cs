namespace BlazorTest.Models
{
    public static class CitiesRepository
    {

        private static List<string> _cities = new List<string>()
        {
            "Karlsruhe",
            "Hamburg",
            "Freiburg"
        };

        public static List<string> GetCities()
            => _cities;
    }
}
